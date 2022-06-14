using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincable.OCP
{
   public abstract class Employee
    {
        public int EmpId { get; set; }

        public string empName { get; set; }

        public int Salary { get; set; }

        public int OvertimeHours { get; set; }


        
        public abstract decimal CalculateBouns();
        
    }
}
