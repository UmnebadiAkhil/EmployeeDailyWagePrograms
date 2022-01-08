using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class US2
    {
        public static void EmpDailyWage()
        {

            Random random = new Random();
            int number = random.Next(2);

            if (number == 0)
            {
                int empRatePerHr = 20;
                int empHrs = 8;
                int salary = (empRatePerHr * empHrs);
                Console.WriteLine("Employee Daily Wage is " + salary);
            }
            else
            {
                int salary = 0;
                Console.WriteLine("Employee Daily Wage is " + salary);
            }
            
        }
    }
}
