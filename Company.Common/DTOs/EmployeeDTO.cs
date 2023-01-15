﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Common.DTOs
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int DepartmentId { get; set; }
        public decimal? Salary { get; set; }

        public bool? Union { get; set; }
    }
}
