using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class EmployeePosition : IReferenceEntity
    {
       
        public int PositionId { get; set; }

        public int EmployeeId { get; set; }

        //public virtual ICollection<Employee>? Employees { get; set; }
        //public virtual ICollection<Position>? Positions { get; set; }
    }
}
