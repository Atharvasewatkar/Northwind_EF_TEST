//using OPERATION_NORTHWIND;
using Northwind_EF_TEST.OPERATIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind_EF_TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<");


            Console.WriteLine(" Enter 1 to get Employee's sales report \n Enter 2 to get Product wise report");

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<<<<");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) 
            {
                case 1:
                    {

                        EMP_SALE_OPERATION.empExecute();
                        break;
                    }
                case 2:
                    {
                        PRO_WR_OPERATION.PWR_Execute();
                        break;
                    }
            }
            Console.ReadLine();


        }
    }
}
