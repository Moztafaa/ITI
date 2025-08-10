use ITI;


-- 1.	 Create a view that displays student full name, course name if the student has a grade more than 50.
create or alter view StudentCourseView as
select concat(s.st_fname, ' ', s.st_lname) as full_name,
       sc.Grade
from Student s
         join Stud_Course sc on s.st_id = sc.st_id
         join Course c on sc.Crs_id = c.Crs_id
where sc.grade > 50;

select *
from StudentCourseView


-- 2.	 Create an Encrypted view that displays manager names and the topics they teach.
-- Department -> instructor -> ins_course -> course
use ITI
create or alter view EncryptedManagerView with encryption
as
select ins.ins_Name as manager_name, Top_Name
from dbo.Department d
         join dbo.Instructor ins on d.Dept_Manager = ins.Ins_Id
         join dbo.ins_course ic on ins.Ins_Id = ic.Ins_Id
         join dbo.course c on ic.Crs_Id = c.Crs_Id
         join dbo.Topic t on c.Top_Id = t.Top_Id;


-- 3.	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department

create or alter view InstructorDepartmentView as
select ins.ins_Name, d.Dept_Name
from Instructor ins
         join Department d on ins.Dept_Id = d.Dept_Id
where d.Dept_Name in ('SD', 'Java');



-- 4. Create a view “V1” that displays student data for student who lives in Alex or Cairo.
-- Note: Prevent the users to run the following query
-- Update V1 set st_address=’tanta’
-- Where st_address=’alex’;

create or alter view V1 as
select *
from Student
where st_address in ('Alex', 'Cairo')
with check option;

update V1 set st_address = 'Tanta'

-- 5.	Create a view that will display the project name and the number of employees work on it. “Use Company DB”

use Company_SD;
create or alter view ProjectEmployeeCountView as
select p.Pname as Project_Name, count(w.essn) as Employee_Count
from Project p
         join Works_for w on p.Pnumber = w.Pno
--          join Employee e on w.Essn = e.Ssn
group by p.Pname;


-- 6.	Create index on column (Hiredate) that allow u to cluster the data in table Department. What will happen?
use ITI
create clustered index IX_Department_Hiredate
on Department(Manager_hiredate);


-- 7.	Create index that allow u to enter unique ages in student table. What will happen?

create unique index IX_Student_Age
on Student(St_Age);






