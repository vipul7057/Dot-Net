using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationEmployee.Models
{
    public class Employee
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public int EmpBasic { get; set; }
        public int deptid { get; set; }
    }
}