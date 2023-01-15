using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace Company.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public DbSet<Organization> Organizations => Set<Organization>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Position> Positions => Set<Position>();
        public DbSet<EmployeePosition> EmployeePositions => Set<EmployeePosition>();


        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EmployeePosition>().HasKey(ep => new { ep.EmployeeId, ep.PositionId });
            builder.Entity<Employee>().Property(e => e.Salary)
                .HasConversion(
                    v => v.ToString(),
                    v => decimal.Parse(v));
            SeedData(builder);
            
        }
      


        private static void SeedData(ModelBuilder builder)
        {
            var organizations = new List<Organization>
        {
            new Organization
            {
                Id = 1,
                CompanyName="Tesla",
                CompanyIdentityNumber = 123456,
            },
            new Organization
            {
                Id = 2,
                CompanyName="Apple",
                CompanyIdentityNumber = 654321,
            }
        };
            builder.Entity<Organization>().HasData(organizations);

            var employees = new List<Employee>
        {
            new Employee
            {
                Id=1,
                DepartmentId=1,
                FirstName="Mario",
                LastName="Youssef",
                Salary=30000,
                Union=true,
            },
            new Employee
            {
                Id=2,
                DepartmentId=3,
                FirstName="Johnny",
                LastName="Aho",
                Salary=40000,
                Union=true,
            },
            new Employee
            {
                Id=3,
                DepartmentId=4,
                FirstName="Jacob",
                LastName="Ercan",
                Salary=50000,
                Union=true,
            },
            new Employee
            {
                Id=4,
                DepartmentId=4,
                FirstName="Robin",
                LastName="Amoun",
                Salary=50000,
                Union=false,
            },
        };
            builder.Entity<Employee>().HasData(employees);

            var departments = new List<Department>
            {
                new Department
                {
                    Id = 1,
                    CompanyId=1,
                    DepartmentName="Engineer",
                   
                    

                },
                new Department
                {
                    Id = 2,
                    CompanyId=1,
                    DepartmentName="RnD",
                    

                },
                new Department
                {
                    Id = 3,
                    CompanyId=2,
                    DepartmentName="Doctor",
                    

                },
                new Department
                {
                    Id = 4,
                    CompanyId=1,
                    DepartmentName="Cleaner",
                    

                },

            };
            builder.Entity<Department>().HasData(departments);

            var positions = new List<Position>
            {
                new Position
                {
                    Id=1,
                    PositionName="Doctor",
                },
                new Position
                {
                    Id=2,
                    PositionName="Engineer",
                },
                new Position
                {
                    Id=3,
                    PositionName="CEO",
                },
                new Position
                {
                    Id=4,
                    PositionName="RnD",
                },
            };
            builder.Entity<Position>().HasData(positions);

            var employeepositions = new List<EmployeePosition>
            {
                new EmployeePosition
                {
                    
                    EmployeeId=1,
                    PositionId=1,
                },
                new EmployeePosition
                {
                    
                    EmployeeId=1,
                    PositionId=2,
                },
                new EmployeePosition
                {
                    
                    EmployeeId=2,
                    PositionId=2,
                },
                new EmployeePosition
                {
                    
                    EmployeeId=3,
                    PositionId=4,
                },
            };

            builder.Entity<EmployeePosition>().HasData(employeepositions);
            



        }
       
       

    }
}
