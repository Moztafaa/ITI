use iti
-- 1
create or alter function dateToMonth(@dateInput date)
    returns varchar(10)
begin
    declare @monthOutput varchar(30) = format(@dateInput, 'MM')
    return @monthOutput
end

select dbo.dateToMonth('8-9-2001')

-- 2
create or alter function betweenInt(@first int, @second int)
    returns @t table
               (
                   numbers int
               )
as
begin
    while (@first < @second - 1)
        begin
            set @first = 1 + @first
            insert into @t select @first
        end
    return
end

select *
from dbo.betweenInt(10, 20)

-- 3
create or alter function NameWithDept(@st_no int)
    returns table
        as return(select concat(St_Fname, ' ', St_Lname) as FullName, Dept_Name
                  from Student s
                           join Department d
                                on s.Dept_Id = d.Dept_Id and s.St_Id = @st_no)

select *
from dbo.NameWithDept(2)

-- 4
create or alter function returnMessage(@id int)
    returns varchar(50)
begin
    declare @first varchar(50) = (select St_Fname from Student where St_Id = @id)
    declare @last varchar(50) = (select St_Lname from Student where St_Id = @id)
    -- 	 select @fname=st_fname , @lname=St_Lname from student where St_Id = @st_id
    declare @res varchar(50)
    if @first IS NULL and @last IS NULL
        select @res = 'First name & last name are null'
    else
        if @first is null
            select @res = 'first name is null'
        else
            if @last is null
                select @res = 'last name is null'
            else
                select @res = 'First name & last name are not null'
    return @res
end

select dbo.returnMessage(13)


-- 5
create or alter function displayData(@mgrId int)
    returns table
        as return(select d.dept_name, i.ins_name, d.manager_hiredate
                  from Department D
                           join Instructor i on i.Ins_Id = D.Dept_Manager and d.Dept_Manager = @mgrId)
select *
from dbo.displayData(1)

-- 6
create or alter function getName(@str varchar(20))
    returns @t table
               (
                   name varchar(50)
               )
as
begin
    if @str = 'first name'
        insert into @t
        select isnull(St_Fname, 'FName')
        from Student
    else
        if @str = 'last name'
            insert into @t
            select isnull(St_Lname, 'Lname')
            from Student
        else
            if @str = 'full name'
                insert into @t
                select isnull(concat(St_Fname, ' ', St_Lname), 'full_name')
                from Student
    return
end

select *
from dbo.getName('full name')

-- 7
select St_Id, isnull(substring(St_Fname, 1, len(St_Fname) - 1), ' null') as Name_without_last_char
from Student


-- 8
delete Stud_Course
from Stud_Course
         join dbo.Student S on Stud_Course.St_Id = S.St_Id
         join dbo.Department D on S.Dept_Id = D.Dept_Id
where d.Dept_Name = 'SD'

-- 9
declare @i int = 1
while @i <= 3000
    begin
        insert into employee1 (Fname,
                               Lname,
                               SSN,
                               Bdate,
                               Address,
                               Sex,
                               Salary,
                               Superssn,
                               Dno)
        values ('Jane',
                'Smith',
                @i,
                '2000-01-01',
                'Address ' + cast(@i as varchar(10)),
                'F',
                50000,
                null,
                1)
        set @i = @i + 1
    end
select *
from employee1



















