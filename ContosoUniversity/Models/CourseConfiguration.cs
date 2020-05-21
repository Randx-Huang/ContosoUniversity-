﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContosoUniversity.Models
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> entity)
        {
            entity.HasIndex(e => e.DepartmentID)
                .HasName("IX_DepartmentID");

            entity.Property(e => e.DepartmentID).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Department)
                .WithMany(p => p.Course)
                .HasForeignKey(d => d.DepartmentID)
                .HasConstraintName("FK_dbo.Course_dbo.Department_DepartmentID");
        }
    }
}
