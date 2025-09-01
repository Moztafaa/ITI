using Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3;

public partial class Form1 : Form
{
    private readonly UniversityDbContext ctx = new();



    public Form1() => InitializeComponent();

    private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e) =>
        throw new NotImplementedException();

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var name = txtSearchName.Text;
        var student = ctx.Students.AsNoTracking().Select(s => new { s.StudentId, s.StudentName, s.Email })
            .FirstOrDefault(s => s.StudentName == name);
        dgvStudents.DataSource = new[] { student };
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        txtSearchName.Clear();
        txtName.Clear();
        txtEmail.Clear();
        txtId.Clear();
        txtDepartment.Clear();
        dgvStudents.DataSource = null;
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        var name = txtName.Text;
        var email = txtEmail.Text;
        var deptName = txtDepartment.Text;
        Department? department = ctx.Departments.FirstOrDefault(d => d.DepartmentName == deptName);
        var student = new Student { StudentName = name, Email = email, DepartmentId = department.DepartmentId };
        ctx.Students.Add(student);
        // ctx.Entry(student).State = EntityState.Added;
        ctx.SaveChanges();
        MessageBox.Show("Student created successfully");
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        var id = int.Parse(txtId.Text);
        Student? student = ctx.Students.FirstOrDefault(s => s.StudentId == id);
        if (student != null)
        {
            // ctx.Entry(student).CurrentValues.SetValues(new
            // {
            //     StudentName = txtName.Text,
            //     Email = txtEmail.Text
            // });
            // ctx.SaveChanges();
            // MessageBox.Show("Student updated successfully");
            // --------------------------------------------------------------
            student.StudentName = txtName.Text;
            student.Email = txtEmail.Text;
            ctx.SaveChanges();
            MessageBox.Show("Student updated successfully");
        }
        else
        {
            MessageBox.Show("Student not found");
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var id = int.Parse(txtId.Text);
        Student? student = ctx.Students.FirstOrDefault(s => s.StudentId == id);
        if (student != null)
        {
            // ctx.Students.Remove(student);
            ctx.Entry(student).State = EntityState.Deleted;
            ctx.SaveChanges();
            MessageBox.Show("Student deleted successfully");
        }
        else
        {
            MessageBox.Show("Student not found");
        }
    }

    private void btnShowAll_Click(object sender, EventArgs e)
    {
        var students = ctx.Students.Include(s => s.Department).AsNoTracking().ToList();
        dgvStudents.DataSource = students.Select(s => new
        {
            s.StudentId,
            s.StudentName,
            s.Email,
            Department = s.Department.DepartmentName
        }).ToList();
    }
}

