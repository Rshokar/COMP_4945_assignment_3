using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _4945_in_class_assignment.Models
{
    public class Student
    {

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression("[A-Z].*")]
        public string StudentName { get; set; }

        [Range(60 ,120)]
        public string StudentAge { get; set; }

    }

    public class StudentContext : DbContext { 

        public DbSet<Student> Students { get; set; }
    }
}