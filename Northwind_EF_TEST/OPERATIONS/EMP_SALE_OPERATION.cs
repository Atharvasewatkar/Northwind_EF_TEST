using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_EF_TEST.OPERATIONS
{
    public class EMP_SALE_OPERATION
    {

        public static void empExecute()
        {
            using (var db = new NorthwindEntities())
            {
                Console.WriteLine("Enter employee id");
                int @EMP_ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter from date");

                string @FROM_DATE = Console.ReadLine();// "1996-07-04";
                Console.WriteLine("Enter to date");

                string @TO_DATE = Console.ReadLine();// "1997-07-04";
                var emplo = db.EMPLOYEE_SALES_REPORT(@EMP_ID, @FROM_DATE, @TO_DATE).ToList();
                int cnt = 0;
                foreach (var emp in emplo)
                {
                    Console.WriteLine($" EmployeeID  :{emp.EmployeeID} \n FIRSTNAME :{emp.FIRSTNAME} \n LASTNAME :{emp.LASTNAME} \n ORDERID :{emp.ORDERID} \n ----------------------------------");

                    cnt++;
                }
                if (cnt == 0)
                {
                    Console.WriteLine("No employee Found");
                                
                }

                Console.ReadLine();
            }

        }
    }
}
