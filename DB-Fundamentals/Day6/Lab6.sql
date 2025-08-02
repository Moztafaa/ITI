
create table sc.Departments
(
    DeptNo   INT,
    DeptName NVARCHAR(50) NOT NULL,
    Location NVARCHAR(50)
);

-- add primary key constraint
alter table sc.Departments
    add constraint PK_Departments primary key (DeptNo);
-- add check constraint for Location
create rule CK_Departments_Location as
    @Location in ('NY', 'DS', 'KW');

sp_bindrule 'CK_Departments_Location', 'sc.Departments.Location';
-- drop the check constraint

------------------------
create table sc.Employees
(
    EmpNo    INT          NOT NULL,
    EmpFname NVARCHAR(50) NOT NULL,
    EmpLname NVARCHAR(50) NOT NULL,
    DeptNo   INT,
    Salary   DECIMAL(10, 2)
);

-- add primary key constraint
alter table sc.Employees
    add constraint PK_Employees primary key (EmpNo);
-- add foreign key constraint
alter table sc.Employees
    add constraint FK_Employees_Departments foreign key (DeptNo) references sc.Departments (DeptNo);
-- add unique constraint on Salary
alter table sc.Employees
    add constraint UQ_Employees_Salary unique (Salary);

create rule CK_Employees_Salary as
    @Salary < 6000;

sp_bindrule 'CK_Employees_Salary', 'sc.Employees.Salary';
-----------------------------------------------------

create table sc.Projects
(
    ProjectNo   INT primary key,
    ProjectName NVARCHAR(50)   NOT NULL,
    Budget      DECIMAL(15, 2) NULL
);

---------------------------------------------------------
create table sc.Works_on
(
    EmpNo      INT          NOT NULL,
    ProjectNo  INT          NOT NULL,
    Job        NVARCHAR(50) NULL,
    Enter_Date DATETIME     NOT NULL DEFAULT GETDATE(),
    primary key (EmpNo, ProjectNo)
);
-- add foreign key constraints
alter table sc.Works_on
    add constraint FK_Works_on_Employees foreign key (EmpNo) references sc.Employees (EmpNo);

alter table sc.Works_on
    add constraint FK_Works_on_Projects foreign key (ProjectNo) references sc.Projects (ProjectNo);

--------------------------------------------------------

-- Insert sample data into Departments
insert into sc.Departments (DeptNo, DeptName, Location)
values (1, 'Research', 'NY'),
       (2, 'Accounting', 'DS'),
       (3, 'Marketing', 'KW');

-- Insert sample data into Employees
insert into sc.Employees (EmpNo, EmpFname, EmpLname, DeptNo, Salary)
values (25348, 'Mathew', 'Smith', 3, 2500),
       (10102, 'Ann', 'Jones', 3, 3000),
       (18316, 'John', 'Barrimore', 1, 2400),
       (29346, 'James', 'James', 2, 2800),
       (9031, 'Lisa', 'Bertoni', 2, 4000),
       (2581, 'Elisa', 'Hansel', 2, 3600),
       (28559, 'Sybl', 'Moser', 1, 2900);

-- Insert sample data into Projects
insert into sc.Projects (ProjectNo, ProjectName, Budget)
values (1, 'Apollo', 120000),
       (2, 'Gemini', 95000),
       (3, 'Mercury', 185600);

-- Insert sample data into Works_on
insert into sc.Works_on (EmpNo, ProjectNo, Job, Enter_Date)
values (10102, 1, 'Analyst', '2006-10-01'),
       (10102, 3, 'Manager', '2012-01-01'),
       (25348, 2, 'Clerk', '2007-02-15'),
       (18316, 2, NULL, '2007-06-01'),
       (29346, 2, NULL, '2006-12-15'),
       (2581, 3, 'Analyst', '2007-10-15'),
       (9031, 1, 'Manager', '2007-04-15'),
       (28559, 1, NULL, '2007-08-01'),
       (28559, 2, 'Clerk', '2012-02-01'),
       (9031, 3, 'Clerk', '2006-11-15'),
       (29346, 1, 'Clerk', '2007-01-04');



-- 1- Add new employee with EmpNo = 11111 in the Works_on table
insert into sc.Works_on (EmpNo, ProjectNo, Job, Enter_Date)
values (11111, 1, 'Analyst', '2023-10-01');
-- No employee with EmpNo 11111 exists

-- 2- Change the employee number 10102 to 11111 in the Works_on table
update sc.Works_on
set EmpNo = 11111
where EmpNo = 10102;
-- No employee with EmpNo 11111 exists to ref

-- 3- Modify the employee number 10102 in the Employees table to 22222
update HumanResource.Employees
set EmpNo = 22222
where EmpNo = 10102;
-- conflict with works_on table, as 10102 is referenced in Works_on

-- 4- Delete the employee with id 10102
delete
from HumanResource.Employees
where EmpNo = 10102;
-- conflict with works_on table, as 10102 is referenced in Works_on

/*
 1-Add  TelephoneNumber column to the employee table[programmatically]
2-drop this column[programmatically]
3-Bulid A diagram to show Relations between tables
 */

-- 1- Add TelephoneNumber column to the Employees table
alter table sc.Employees
    add TelephoneNumber NVARCHAR(13);

-- 2- Drop the TelephoneNumber column from the Employees table
alter table sc.Employees
    drop column TelephoneNumber;

---------------------------------------------------------------------- Q1 Finished -------------------------------------------------------------


-- 2. Create the following schema and transfer the following tables to it
-- a. Company Schema
create schema Company;
alter schema Company transfer sc.Departments;
alter schema Company transfer sc.Projects;

-- b. Human Resource Schema
create schema HumanResource;
alter schema HumanResource transfer sc.Employees;

-- 3. Write query to display the constraints for the Employee table.
select *
from information_schema.table_constraints tc
where tc.table_name = 'Employees'

-- 4.	Create Synonym for table Employee as Emp and then run the following queries and describe the results
-- a.	Select * from Employee
-- b.	Select * from [Human Resource].Employee
-- c.	Select * from Emp
-- d.	Select * from [Human Resource].Emp

create synonym Emp for Company_SD.HumanResource.Employees;

select *
from Employees;
select *
from [HumanResource].Employees;
select *
from Emp;
select *
from [HumanResource].Emp;

-- 5.	Increase the budget of the project where the manager number is 10102 by 10%.

update Company.Projects
set Budget = Budget * 1.10
where ProjectNo in (select ProjectNo
                    from sc.Works_on
                    where EmpNo = 10102)

select ProjectName, Budget, EmpFname, e.EmpNo
from Company.Projects p
         join sc.Works_on w on p.ProjectNo = w.ProjectNo
         join HumanResource.Employees e on w.EmpNo = e.EmpNo
where e.EmpNo = 10102;


-- 6.	Change the name of the department for which the employee named James works.The new department name is Sales.

update Company.Departments
set DeptName = 'Sales'
where DeptNo = (select DeptNo
                from HumanResource.Employees
                where EmpFname = 'James')

-- 7.	Change the enter date for the projects for those employees who work in project p1 and belong to department ‘Sales’. The new date is 12.12.2007.

update sc.Works_on
set Enter_Date = '2007-12-12'
where ProjectNo = 1
  and EmpNo in (select EmpNo
                from HumanResource.Employees
                where DeptNo = (select DeptNo
                                from Company.Departments
                                where DeptName = 'Sales'))


select *
from HumanResource.Employees
where EmpFname = 'James';


-- 8.	Delete the information in the works_on table for all employees who work for the department located in KW.

delete
from sc.Works_on
where EmpNo in (select EmpNo
                from Emp
                where DeptNo in (select DeptNo
                                 from Company.Departments
                                 where Location = 'KW'))


-- 8.	select the information in the works_on table for all employees who work for the department located in KW.

select *
from sc.Works_on
where EmpNo in (select EmpNo
                from HumanResource.Employees
                where DeptNo in (select DeptNo
                                 from Company.Departments
                                 where Location = 'KW'))

