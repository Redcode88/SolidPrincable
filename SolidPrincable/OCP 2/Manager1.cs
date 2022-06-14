using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincable.OCP_2
{
    public class Manager1 : Employee1, IEmployee1
    {
       
        public decimal CalclauteBounse()
        {
            var OverTime = ((this.OvertimeHours * this.Salary) / 30)*2;
            return OverTime;
        }
    }
}
