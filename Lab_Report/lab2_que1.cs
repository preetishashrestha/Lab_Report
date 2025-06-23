using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Report
{
    class employee
    {
        public string Name;
        public string Email;
        public double Salary;
        public employee(string name, string email, double salary )
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine("\nEmployee Details\n");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Salary:" + Salary);
        }
        }

    class display
    {

        //public static void Main(string[] args)
        //{
        //     employee emp1 = new employee("Preetisha", "preetisha@email.com", 55000);
        //    emp1.Display();
        //    Console.ReadLine();
        //}
    }             

}
