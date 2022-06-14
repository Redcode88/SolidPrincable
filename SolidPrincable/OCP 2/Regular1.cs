using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincable.OCP_2
{
    public class Regular1 : Employee1, IEmployee1
    {
        public decimal CalclauteBounse()
        {
            var OverTime = (this.OvertimeHours * this.Salary)/30;
            return OverTime;
        }
    }
}
