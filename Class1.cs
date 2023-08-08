using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Class1
    {
        public class CommissionEmployee : Object
        {

            public string FirstName { get; }
            public string LastName { get; }
            public string SocialSecurityNumber { get; }
            private decimal grossSales;
            private decimal commissionRate;
            

            public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber,decimal grossSales, decimal commissionRate)
            {

                FirstName = firstName;
                LastName = lastName;
                SocialSecurityNumber = socialSecurityNumber;
                grossSales = grossSales;
                CommissionRate = commissionRate;
            }

            public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal commissionRate, decimal v) : this(firstName, lastName, socialSecurityNumber, commissionRate)
            {
                this.v = v;
            }

            public decimal GrossSales
            {
                get
                {
                    return grossSales;
                }
                set
                {

                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GrossSales)}must be >=0");
                    }
                    grossSales = value;
                }
            }
            public decimal CommissionRate
            {
                get
                {
                    return commissionRate;
                }
                set
                {
                    if (value <= 0 || value >= 1)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(CommissionRate)}must be>0 and<1");
                    }
                    commissionRate = value;
                }
            }

            public decimal Earings() => commissionRate * grossSales;

            public override string ToString() =>
                $"Commission Employee:{FirstName}{LastName}\n" + $"social security number:{SocialSecurityNumber}\n" + $"gross sales:{grossSales:C}\n" + $"commission rate :{commissionRate:F2}";


        }
    }
}
                
            
        
