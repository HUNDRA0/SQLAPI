using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class DepartmentDTO
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int CompanyId { get; set; }
    }
}
