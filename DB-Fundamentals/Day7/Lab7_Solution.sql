--1.	Create a stored procedure without parameters to show the number of students per department name
create procedure ShowStudentsPerDepartment
as
begin
    Select count(*) as NumberOfStudents, d.Dept_Name
    from Student s
             join Department d on s.Dept_Id = d.Dept_Id
    group by d.Dept_Name
end

    -- 2.	Create a stored procedure that will check for the # of employees in the project p1 if they are more than 3 print mesgesa to the user “'The number of employees in the project p1 is 3 or more'” if they are less display a	 message to the user “'The following employees work for the project p1'” in addition to the first name and last name of each one. [Company DB]
    create procedure CheckEmployeesInProjectP1
    as
    begin
        declare @EmpCount int;
        set @EmpCount = (select count(*)
                         from Employee e
                                  join Works_for w on e.SSN = w.ESSn
                                  join dbo.Project P on P.Pnumber = w.Pno
                         where P.Pnumber = 100);
        if @EmpCount >= 3
            begin
                print 'The number of employees in the project p1 is 3 or more';
            end
        else
            begin
                print 'The following employees work for the project p1:';
                select e.FirstName, e.LastName
                from Employee e
                         join Works_for w on e.SSN = w.ESSn
                         join dbo.Project P on P.Pnumber = w.Pno
                where P.Pnumber = 100;
            end
    end
go

-- 3.	Create a stored procedure that will be used in case there is an old employee has left the project and a new one become instead of him. The procedure should take 3 parameters (old Emp. number, new Emp. number and the project number) and it will be used to update works_on table. [Company DB]

create procedure UpdateWorksOn @OldEmpNo int,
                               @NewEmpNo int,
                               @ProjectNo int
as
begin
    update Works_for
    set ESSn = @NewEmpNo
    where ESSn = @OldEmpNo
      and Pno = @ProjectNo;
end
go

exec UpdateWorksOn 669955, 112233, 300

-- 4.	add column budget in project table and insert any draft values in it then
-- then Create an Audit table with the following structure
-- ProjectNo 	UserName 	ModifiedDate 	Budget_Old 	Budget_New
-- p2 	Dbo 	2008-01-31	95000 	200000
--
-- This table will be used to audit the update trials on the Budget column (Project table, Company DB)
-- Example:
-- If a user updated the budget column then the project number, user name that made that update, the date of the modification and the value of the old and the new budget will be inserted into the Audit table
-- Note: This process will take place only if the user updated the budget column

create table ProjectAudit
(
    ProjectNo    int,
    UserName     nvarchar(50),
    ModifiedDate datetime,
    Budget_Old   decimal(18, 2),
    Budget_New   decimal(18, 2)
);

alter table Project
    add Budget decimal(18, 2);

-- Create a trigger to audit updates on the Budget column
create or alter trigger trg_AuditProjectBudget
    on Project
    after update
    as
begin
    if update(Budget)
        begin
            declare @ProjectNo int,
                @UserName nvarchar(50),
                @OldBudget decimal(18, 2),
                @NewBudget decimal(18, 2);

            select @ProjectNo = inserted.Pnumber,
                   @UserName = SUSER_NAME(),
                   @OldBudget = deleted.Budget,
                   @NewBudget = inserted.Budget
            from inserted
                     join deleted on inserted.Pnumber = deleted.Pnumber;

            insert into ProjectAudit (ProjectNo, UserName, ModifiedDate, Budget_Old, Budget_New)
            values (@ProjectNo, @UserName, GETDATE(), @OldBudget, @NewBudget);
        end
end
go


-- 5.	Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
-- “Print a message for user to tell him that he can’t insert a new record in that table”

create trigger trg_PreventDepartmentInsert
    on Department
    instead of insert
    as
begin
    select 'Insertion is not allowed in the Department table';
end
go


-- 6.	 Create a trigger that prevents the insertion Process for Employee table in March [Company DB].

create trigger trg_PreventMarchInsert
    on Employee
    instead of insert
    as
begin
    declare @InsertDate datetime;
    select @InsertDate = GETDATE();

    if month(@InsertDate) = 3
        begin
            select 'Insertion is not allowed in March'
        end
    else
        begin
            insert into Employee
            select *
            from inserted;
        end
end
go

-- 7.	Create a trigger on student table after insert to add Row in Student Audit table (Server User Name , Date, Note) where note will be “[username] Insert New Row with Key=[Key Value] in table [table name]”
-- Server User Name		Date
-- 	Note

create table StudentAudit
(
    ServerUserName nvarchar(50),
    Date           datetime,
    Note           nvarchar(255)
);

create trigger trg_AuditStudentInsert
    on Student
    after insert
    as
begin
    declare @UserName nvarchar(50),
        @CurrentDate datetime,
        @KeyValue int;

    select @UserName = SUSER_NAME(),
           @CurrentDate = GETDATE(),
           @KeyValue = inserted.St_Id
    from inserted;

    insert into StudentAudit (ServerUserName, Date, Note)
    values (@UserName, @CurrentDate,
            CONCAT(@UserName, ' Insert New Row with Key=', @KeyValue, ' in table Student'));
end
go

-- 8.	 Create a trigger on student table instead of delete to add Row in Student Audit table (Server User Name, Date, Note) where note will be“ try to delete Row with Key=[Key Value]”

create trigger trg_AuditStudentDelete
    on Student
    instead of delete
    as
begin
    declare @UserName nvarchar(50),
        @CurrentDate datetime,
        @KeyValue int;

    select @UserName = SUSER_NAME(),
           @CurrentDate = GETDATE(),
           @KeyValue = deleted.St_Id
    from deleted;

    insert into StudentAudit (ServerUserName, Date, Note)
    values (@UserName, @CurrentDate,
            CONCAT('try to delete Row with Key=', @KeyValue));
--     delete from Student where St_Id = @KeyValue;
end
