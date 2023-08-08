using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp59.Class1;

namespace ConsoleApp59
{
    class CommissionEmployeeTest
    {
        static void Main(string[] args)
        {
            var employee = new CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.00M, 0.6M);

            Console.WriteLine("Employee information obtained by properties and methods:\n");
            Console.WriteLine($"First name is {employee.FirstName}");
            Console.WriteLine($"Last name is{employee.LastName}");
            Console.WriteLine($"Social security number is{employee.SocialSecurityNumber}");
            Console.WriteLine($"Gross sales are{employee.GrossSales:C}");
            Console.WriteLine($"Commission rate is{employee.CommissionRate:F2}");
            Console.WriteLine($"Earnings are{employee.Earings():C}");

            employee.GrossSales = 5000.00M;
            employee.CommissionRate = .1M;

            Console.WriteLine("\nUpdated employee information obtained by ToString:\n");

            Console.WriteLine(employee);
            Console.WriteLine($"earings:{employee.Earings():C}");
            Console.ReadLine();
        
        }
    }
}
