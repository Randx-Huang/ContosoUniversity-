﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public partial class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public int? Grade { get; set; }

        [ForeignKey(nameof(CourseID))]
        [InverseProperty("Enrollment")]
        public virtual Course Course { get; set; }
        [ForeignKey(nameof(StudentID))]
        [InverseProperty(nameof(Person.Enrollment))]
        public virtual Person Student { get; set; }
    }
}