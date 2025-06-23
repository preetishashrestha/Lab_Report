using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Report;

namespace Lab_Report
{
    public class Employee
    {
        public string Name;
        public int age;
        public string mail;

        public void display() 
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" +age);
            Console.WriteLine("Mail:" +mail);
        }
    }
}

namespace report
{
    class program
    {
        //static void Main(string[] args)
        //{
        //    Employee emp = new Employee();
        //    emp.Name = "preetishashrestha";
        //    emp.age = 20;
        //    emp.mail = "preetisha@gmail.com";
        //    emp.display();
        //    Console.ReadLine();

        //}
    }
}
