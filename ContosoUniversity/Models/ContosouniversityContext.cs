﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContosoUniversity.Models
{
    public partial class ContosouniversityContext : DbContext
    {
        public ContosouniversityContext()
        {
        }

        public ContosouniversityContext(DbContextOptions<ContosouniversityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseInstructor> CourseInstructor { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Enrollment> Enrollment { get; set; }
        public virtual DbSet<OfficeAssignment> OfficeAssignment { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<vwCourseStudentCount> vwCourseStudentCount { get; set; }
        public virtual DbSet<vwCourseStudents> vwCourseStudents { get; set; }
        public virtual DbSet<vwDepartmentCourseCount> vwDepartmentCourseCount { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new CourseInstructorConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EnrollmentConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeAssignmentConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new vwCourseStudentCountConfiguration());
            modelBuilder.ApplyConfiguration(new vwCourseStudentsConfiguration());
            modelBuilder.ApplyConfiguration(new vwDepartmentCourseCountConfiguration());


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
