use Company_SD;
-- 1.	Dispaly the ids, names and locations of  the pojects which controled with department 10.
select p.dnum, p.plocation, p.pname, d.dname
from Project p
         join Departments d
              on p.Dnum = d.Dnum


-- 2.	Display the Department id, name and id and the name of its manager.
select d.dnum, d.dname, e.fname + ' ' + e.lname as manager_name
from Departments d
         join Employee e
              on d.MGRSSN = e.ssn;

-- 3.	Display the name of the departments and the name of the projects under its control.
select d.dname, p.pname
from Departments d
         join Project p
              on d.dnum = p.dnum;


-- 4.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select e.fname + ' ' + e.lname as employee_name,
       d.dependent_name,
       d.sex,
       d.bdate
from Employee e
         join Dependent d
              on e.SSN = d.ESSN;

-- 5.	Display the ID, name and location of the projects in Cairo or Alex city.
select pnumber Project_Number, pname Project_Name, plocation Project_Location
from Project
where Project.City in ('Cairo', 'Alex');

-- 6.	Display the Projects full data of the projects with a name starts with "a" letter.
select Pname, Pnumber, Plocation, City, Dnum
from Project
where Pname like 'a%';

-- 7.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select e.fname + ' ' + e.lname as employee_name, e.salary
from Employee e
where e.Dno = 30
  and e.salary between 1000 and 2000;
-- 8.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.

select e.fname + ' ' + e.lname as employee_name, p.pname as project_name
from Employee e
         join Works_for w
              on e.SSN = w.ESSn
         join Project p
              on w.Pno = p.Pnumber
where e.Dno = 10
  and w.Hours >= 10
  and p.Pname = 'AL Rabwah';


-- 9.	Find the names of the employees who directly supervised with Kamel Mohamed.

select e.fname + ' ' + e.lname as employee_name, m.fname + ' ' + m.lname as manager_name
from Employee e
         join Employee m
              on e.SuperSSN = m.SSN
where m.Fname = 'Kamel';

-- 10.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.

select e.fname + ' ' + e.lname as employee_name, p.pname as project_name
from Employee e
         join Works_for w
              on e.SSN = w.ESSn
         join Project p
              on w.Pno = p.Pnumber
order by p.pname;

-- 11.	For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.

select p.pnumber as project_number,
       d.dname   as department_name,
       m.lname   as manager_last_name,
       m.address,
       m.bdate
from Project p
         join Departments D
              on D.Dnum = p.Dnum
         join Employee m
              on D.Dnum = m.Dno
where p.City = 'Cairo';

-- 12.	Display All Data of the managers
select Fname,
       Lname,
       SSN,
       Bdate,
       Address,
       Sex,
       Salary,
       Superssn,
       Dno
from Employee
where SSN in (select MGRSSN from Departments)
   or SSN in (select SuperSSN from Employee);

-- 13. Display (Using Union Function)
--
-- a. The name and the gender of the dependence that's gender is Female and depending on Female Employee.
-- b. And the male dependence that depends on Male Employee.

select d.Dependent_name, d.sex
from Dependent d
         join Employee e on d.ESSN = e.SSN
where d.Sex = 'F'
  and e.Sex = 'F'

union

select d.dependent_name, d.sex
from Dependent d
         join Employee e on d.ESSN = e.SSN
where d.Sex = 'M'
  and e.Sex = 'M'


-- 14. Get the names of employees that is similar to any dependent name (using Intersect)

select e.fname + ' ' + e.lname as name
from Employee e

intersect
select Dependent_name from Dependent


select  substring(d.dependent_name, charindex(' ', d.dependent_name) + 1, len(d.dependent_name)) as last_name
from Dependent d





























