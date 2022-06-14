using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincable.OCP
{
    public class Regular : Employee
    {
        public override decimal CalculateBouns()
        {
            var result = ((this.Salary * this.OvertimeHours));
            return result;
        }
    }
}
