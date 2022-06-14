using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincable.OCP_2
{
   public abstract  class Employee1
   {
        public int EmpId { get; set; }

        public string empName { get; set; }

        public int Salary { get; set; }

        public int OvertimeHours { get; set; }

       
    }
}
