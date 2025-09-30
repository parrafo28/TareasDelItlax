using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My1Program
{
    public static class Class2
    {
        /// <summary>
        /// We can send parameters options, if we dont send it, the default value will be used 
        /// </summary>
        /// <param name="baseRate"></param>
        /// <param name="bonus"></param>
        /// <param name="tax"></param>
        /// <returns></returns>
        /// 
        public static int CalculateRateOfEmployeeFunction(int baseRate = 1000, int bonus = 200, int tax = 150)
        {
            //Calculate the rate of an employee
            var rate = baseRate + bonus - tax;
            return rate;
        }
    }
}
