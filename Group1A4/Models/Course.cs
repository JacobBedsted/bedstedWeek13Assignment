﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Group1A4.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public string CourseName { get; set; }
        public DateTime CourseDate { get; set; }
        public double CoursePrice { get; set; }

        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }
    }
}