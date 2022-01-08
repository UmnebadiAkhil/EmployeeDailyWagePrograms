using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class UC4
    {
        public static void EmpDailyWage2()
        {
            int isPartTimeHrs = 4;
            int isFullTimeHrs = 8;
            int absentHrs = 0;
            int empRatePerHr = 20;
            Random random = new Random();
            int number = random.Next(3);
            int salary = (isPartTimeHrs * empRatePerHr);
            int salary1 = (isFullTimeHrs * empRatePerHr);
            int salary2 = (absentHrs * empRatePerHr);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Employee Salary is " + salary);
                    break;
                case 2:
                    Console.WriteLine("Employee Salary is " + salary1);
                    break;
                default:
                    Console.WriteLine("Employee Salary is " + salary2);
                    break;

                    
            }
        }
    }
}