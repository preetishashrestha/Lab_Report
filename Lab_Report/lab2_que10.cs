//Write a C# program to create generic class and methods.

using System;

namespace Lab_Report
{
    //public class FirstGeneric
    //{
    //    public static void Main()
    //    {
    //        DataStore<string> cities = new DataStore<string>();
    //        cities.AddOrUpdate(0, "Mumbai");
    //        cities.AddOrUpdate(1, "Chicago");
    //        cities.AddOrUpdate(2, "London");
    //        Console.WriteLine(cities.GetData(100));
    //        DataStore<int> empIds = new DataStore<int>();
    //        empIds.AddOrUpdate(0, 50);
    //        empIds.AddOrUpdate(1, 65);
    //        empIds.AddOrUpdate(2, 89);
    //        Console.WriteLine(empIds.GetData(0));
    //        Console.ReadLine();
    //    }
    //}
    //class DataStore<T>
    //{
    //    private T[] _data = new T[10];
    //    public void AddOrUpdate(int index, T item)
    //    {
    //        if (index >= 0 && index < 10)
    //            _data[index] = item;
    //    }
    //    public T GetData(int index)
    //    {
    //        if (index >= 0 && index < 10)
    //            return _data[index];
    //        else
    //            return default(T);
    //    }
    //}
}
