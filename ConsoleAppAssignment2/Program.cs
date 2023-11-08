using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Employee Id");
            int ID=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string Name=Console.ReadLine();
            Console.WriteLine("Enter Employee Gender");
            char gender=char.Parse(Console.ReadLine());
            Console.WriteLine("Employee Salary");
            double Salary=double.Parse(Console.ReadLine());
            Console.WriteLine("Date of Joining");
            DateTime DOJ=DateTime.Parse(Console.ReadLine());

            Console.WriteLine("ID\tEmployee Name\tEmployee Gender\tEmployee Salary\t\tDOJ");
            Console.WriteLine($"{ID}\t{Name}\t\t{gender}\t\t{Salary:C2}\t\t{DOJ:MM/dd/yyyy}");

            

            if (Salary >= 90000)
            {
                Console.WriteLine("you have to pay 30% tax .\n");
            }
            else
            {
                Console.WriteLine("You have to pay 15% tax.\n");
            }
            Console.ReadKey();
        }
    }
}
