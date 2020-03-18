using System;

namespace Employeeclas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE INVENTORY FOR THE RESTAURANT");
            Console.WriteLine("*************************************");
            Console.Write("ENTER THE NUMBER OF EMPLOYEE : ");
          
            int n = Convert.ToInt32(Console.ReadLine());
            Employee[] salary = new Employee[n];   //Instantiate a variable of type Employee

            for (int i = 0; i < n; i++)

            {

                salary[i] = new Employee();

                Console.WriteLine("Employee ID : {0}", i + 1);

                Console.Write("Employee Name :");

                salary[i].EmployeeName = Console.ReadLine();

                Console.Write("Monthly Salary :");

                salary[i].Salary = Convert.ToDouble(Console.ReadLine());

                

            }
            // Prints the Employee details in the console 
            Console.WriteLine("Employee ID\tEmployeeName\tMonthlysalary");

            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < n; i++)

            {

                Console.WriteLine("\t {0}\t{1}\t{2}", i + 1, salary[i].EmployeeName , salary[i].Salary);

            }

            Console.ReadLine();

        }

        class Employee

        {

            public string EmployeeName { get; set; }
            public double Salary { get; set; }

        }
    }
}
