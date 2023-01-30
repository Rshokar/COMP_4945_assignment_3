using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace assignment.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Customer : Person
    {
       public string Address { get; set; }

    }

    public class Employee : Person
    {
        public string Department { get; set; }
    }

    public class PersonContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }


}