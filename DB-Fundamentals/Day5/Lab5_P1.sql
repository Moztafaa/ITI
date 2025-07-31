use ITI

-- 1.	Retrieve number of students who have a value in their age.
select count(st_id)
from Student
where St_Age is not null;

-- 2.	Get all instructors Names without repetition
select distinct ins_name
from Instructor

-- 3.	Display student with the following Format (use isNull function)
select St_Id       as 'Student ID',
       St_Fname    as 'Student Full Name',
       d.Dept_name as 'Department name'
from Student s
         join Department d on s.Dept_Id = d.Dept_Id

-- 4.	Display instructor Name and Department Name
-- Note: display all the instructors if they are attached to a department or not
select ins_name, Dept_Name
from Instructor i
         left join dbo.Department D on i.Dept_Id = D.Dept_Id

-- 5.	Display student full name and the name of the course he is taking For only courses which have a grade
select concat(St_fname, ' ', St_Lname) as Full_Name, Crs_Name
from Student s
         join stud_course sc on s.St_Id = sc.St_Id
         join Course c on sc.Crs_Id = c.Crs_Id
where Grade is not null

-- 6.	Display number of courses for each topic name
select count(crs_name) as no_of_courses, Top_Name
from Course c
         join Topic t
              on c.Top_Id = t.Top_Id
group by t.Top_Name

-- 7.	Display max and min salary for instructors
select Max(salary) as Max_salary, Min(Salary) as Min_salary
from Instructor

-- 8.	Display instructors who have salaries less than the average salary of all instructors.
select ins_name
from Instructor
where Salary < (select avg(Salary)
                from Instructor)

-- 9.	Display the Department name that contains the instructor who receives the minimum salary.
select Dept_Name
from Department
where Dept_Id = (select Dept_Id
                 from Instructor
                 where Salary = (select min(Salary)
                                 from Instructor))

-- 10.	 Select max two salaries in instructor table.
select top 2 Salary
from Instructor
order by Salary desc

-- 11.	 Select instructor name and his salary but if there is no salary display instructor bonus keyword. “use coalesce Function”
select ins_name, coalesce(convert(nvarchar(20), Salary), 'instructor bonus') as salary
from Instructor


-- 12.	Select Average Salary for instructors
select AVG(Salary) as 'Average Salary'
from Instructor

-- 13.	Select Student first name and the data of his supervisor
select st.St_Fname,
       sp.St_Id,
       sp.St_Id,
       sp.St_Fname,
       sp.St_Lname,
       sp.St_Address,
       sp.St_Age,
       sp.Dept_Id,
       sp.St_super
from Student st
         join Student sp
              on sp.St_Id = st.St_super

-- 14.	Write a query to select the highest two salaries in Each Department for instructors who have salaries. “using one of Ranking Functions”
select * from (
    select salary, Dept_Id, ROW_NUMBER() over ( partition by Dept_Id order by Salary desc) as rk from Instructor where Salary is not null
) as newtable where rk < 3;


-- 15.	 Write a query to select a random  student from each department.  “using one of Ranking Functions”

select * from (select *, rank() over (partition by Dept_Id order by newid()) as rk from Student)
as newtable where rk <2

