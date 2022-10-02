using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_EF_TEST.OPERATIONS
{
    public class PRO_WR_OPERATION
    {
        public static void PWR_Execute()
        {
            using (var db = new NorthwindEntities())
            {
                Console.WriteLine("Enter product name");
                string Productname = Console.ReadLine();
                Console.WriteLine("Enter month");

                string month = Console.ReadLine();
                Console.WriteLine("Enter year");

                int Year = int.Parse(Console.ReadLine());
                var PWR = db.PRODUCT_WISE_REPORT(Productname, month, Year).ToList();
                // int cnt = 0;

                foreach (var pwr in PWR)
                {
                     Console.WriteLine($" ProductName :{pwr.ProductName} \n Month :{pwr.month} \n TotalCost :{pwr.TatalCost}  \n ----------------------------------");
                   // cnt++;
                }


                Console.ReadLine();
            }

        }

    }
}
