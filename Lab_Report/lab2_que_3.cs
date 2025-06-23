using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Report
{
     public partial class Student
    {
        public string Name;
        public int age;

        public void display()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Age:" +age);
        }
    }


    public partial class Student
    {
        public string Address;
        public string Email;

        public void displayinfo()
        {
            Console.WriteLine("Address:" +Address);
            Console.WriteLine("Email:" +Email);
        }
    }
    class program
    {
        //static void Main(string[] args)
        //{
        //    Student S1 = new Student();
        //    S1.Name = "Preetisha Shrestha";
        //    S1.age = 20;
        //    S1.Address = "Lubhoo lalitpur";
        //    S1.Email = "preetisha@gmail.com";
        //    S1.display();
        //    S1.displayinfo();
        //    Console.ReadLine();

        //}

    }
}
