using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class US3
    {
        public static void EmpDailyWage1()
        {
            int isPartTime = 1;
            int isFullTime = 2;
            int empRatePerHr = 20;
            Random random = new Random();
            int number = random.Next(3);

            if (number == isPartTime)
            {
                int empHrs = 4;
                int salary = (empHrs * empRatePerHr);
                Console.WriteLine("Employee Salary is " + salary);
            }
            else if (number == isFullTime)
            {
                int empHrs = 8;
                int salary = (empHrs * empRatePerHr);
                Console.WriteLine("Employee Salary is " + salary);
            }
            else
            {
                int empHrs = 0;
                int salary = (empHrs * empRatePerHr);
                Console.WriteLine("Employee Salary is " + salary);
            }
            
        }
    }
}

