using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class Employee : IEntity
    {
        public int Id { get; set; }

        [MaxLength(80), Required]
        public string? FirstName { get; set; }

        [MaxLength(80), Required]
        public string? LastName { get; set; }

        public int DepartmentId { get; set; }
        public decimal? Salary { get; set; }

        public bool? Union { get; set; }
        public virtual ICollection<EmployeePosition>? EmployeePositions { get; set; }
        //public virtual ICollection<Department>? Departments { get; set; }
    }
}
