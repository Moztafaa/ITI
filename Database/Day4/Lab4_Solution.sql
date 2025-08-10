use Company_SD;


-- 1.	For each project, list the project name and the total hours per week (for all employees) spent on that project.

select p.pname as Project_Name, sum(w.hours) as Total_Hours_Per_Week
from Project p
         join Works_for w
              on p.Pnumber = w.Pno
group by p.pname


-- 2.	Display the data of the department which has the smallest employee ID over all employees' ID.

select Dname, Dnum, MGRSSN, [MGRStart Date], ssn as employee_ssn
from Employee
         join Departments on Employee.Dno = Departments.Dnum
where SSN = (select min(SSN) from Employee);


-- 3.	For each department, retrieve the department name and the maximum, minimum and average salary of its employees.

select Dname, MAX(Salary) as max_salary, MIN(Salary) as min_salary, AVG(Salary) as avg_salary
from Employee
         join dbo.Departments D on D.Dnum = Employee.Dno
group by Dname

-- 4.	List the full name of all managers who have no dependents. (using subquery)

select d.MGRSSN, Fname + ' ' + Lname as Full_name
from Employee e
         join dbo.Departments D on e.ssn = D.MGRSSN
where d.MGRSSN not in (select distinct ssn
                       from Employee
                                join Dependent on Employee.SSN = Dependent.ESSN);

select MGRSSN
from Departments;

select distinct ESSn
from Dependent;

-- 5.	For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.

select dnum, avg(isnull(Salary, 0))
from Employee
         join dbo.Departments D on D.Dnum = Employee.Dno
group by dnum
having avg(Salary) < (select avg(salary)
                      from Employee)

-- 6.	Retrieve a list of employees names and the projects names they are working on ordered by department number and within each department, ordered alphabetically by last name, first name.

select Fname + ' ' + Lname as Full_Name, Dno, Pname
from Employee e
         join Works_for w on e.SSN = w.ESSn
         join Project p on w.Pno = p.Pnumber
order by e.Dno, Full_Name

-- 7.	Try to get the max 2 salaries using subquery
select top 2 Salary
from employee
where Salary in (select top 2 Salary
                 from Employee
                 order by Salary desc)
order by Salary desc


Select Max(Salary)
from Employee
union all
select Max(Salary)
from Employee
where Salary != (select Max(Salary)
                 from Employee)


-- 8.	Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.

insert into Employee
values ('Mostafa', 'Ibrahim', 102672, '2001-11-18', 'Cairo', 'M', 5400, 321654, 30);


-- 9.	Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.

insert into dbo.Employee(Fname, Lname, SSN, Bdate, Address, Sex, Dno)
values ('Mohamed', 'Alaa', '102677', '2000-10-22', 'Cairo', 'M', 30);


-- 10.	Upgrade your salary by 20 % of its last value.

update Employee
set Salary = (Salary + Salary * 0.2)
where SSN = 102672


-- 13.	Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department (id = 100), and they give you(use your SSN from question1) her position (Dept. 20 manager)
insert into Departments
values ('New Department', 100, Default, default);

update Departments
set MGRSSN = 102672
where Dnum = 20

update Departments
set MGRSSN =968574
where Dnum = 100


-- 14.	Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so try to delete his data from your database in case you know that you will be temporarily in his position.
update Employee
set Superssn = 102672
where SSN = 223344

update Employee
set Superssn =102672
where Superssn = 223344

delete
from Dependent
where ESSN = 223344;

delete
from Works_for
where ESSn = 223344;

update Departments
set MGRSSN = 102672
where MGRSSN = 223344

delete
from Employee
where SSN = 223344


-- 15.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%

update Employee
set Salary = (Salary + Salary * 0.3)
where dno = (select dno
             from Employee e
                      join Works_for w on e.SSN = w.ESSn
                      join Project p on w.Pno = p.Pnumber
             where p.Pname = 'Al Rabwah')



