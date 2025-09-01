using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Models;

public partial class UniversityDbContext : DbContext
{
    public UniversityDbContext()
    {
    }

    public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1434;Database=UniversityDB;User Id=SA;Password=Mm181120011#;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Course__C92D71A7F0846CF2");

            entity.ToTable("Course");

            entity.Property(e => e.CourseName).HasMaxLength(100);
            entity.Property(e => e.Credits).HasDefaultValue(3);

            entity.HasOne(d => d.Department).WithMany(p => p.Courses)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_Course_Department");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BEDB9519C67");

            entity.ToTable("Department");

            entity.HasIndex(e => e.DepartmentName, "UQ__Departme__D949CC34D68BB429").IsUnique();

            entity.Property(e => e.DepartmentName).HasMaxLength(100);
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("PK__Enrollme__7F68771B93CE8592");

            entity.ToTable("Enrollment");

            entity.HasIndex(e => new { e.StudentId, e.CourseId }, "UQ_Student_Course").IsUnique();

            entity.Property(e => e.EnrollmentDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Grade)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Course).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Enrollment_Course");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_Enrollment_Student");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B9907BA2B65");

            entity.ToTable("Student");

            entity.HasIndex(e => e.Email, "UQ__Student__A9D10534C9FA9EFD").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.StudentName).HasMaxLength(100);

            entity.HasOne(d => d.Department).WithMany(p => p.Students)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("FK_Student_Department");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
