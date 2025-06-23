using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Report
{


    class school
    {
        public void education()
        {
            Console.WriteLine("School provides education");
        }
    }
    class Teacher : school
    {
        public void teach()
        {
            Console.WriteLine("Teacher teach student");
        }
    }
    class student : Teacher
    {
        public void learns()
        {
            Console.WriteLine("Student learn from teacher");
        }
    }
    class people : school
    {
        public void Goes()
        {
            Console.WriteLine("People goes to school");
        }
    }

    class inheritance
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Single Inheritance:");
        //    Teacher t = new Teacher();
        //    t.education();
        //    t.teach();

        //    Console.WriteLine("\nMultilevel Inheritance:");
        //    student s = new student();
        //    s.education();
        //    s.teach();
        //    s.learns();

        //    Console.WriteLine("\nHierarchical Inheritance:");
        //    people p = new people();
        //    p.education();
        //    p.Goes();

        //    Console.ReadLine();
        //}

    }
}
