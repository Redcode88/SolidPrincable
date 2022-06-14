using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincable.OCP
{
    public class Manager : Employee
    {

        public override decimal CalculateBouns()
        {
            var result = ((this.Salary * this.OvertimeHours) * 2);
            return result;    
         }
    }
}
