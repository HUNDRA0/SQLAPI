using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Interfaces;

namespace Company.Data.Entities
{
    public class Organization : IEntity
    {
        public int Id { get; set; }
        [MaxLength(100), Required]
        public string? CompanyName { get; set; }
        public int CompanyIdentityNumber { get; set; }

        //public virtual ICollection<Department>? Departments { get; set; }
    }
}
