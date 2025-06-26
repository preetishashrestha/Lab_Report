using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lab_Report
{
    //class DatabaseExample
    //{
    //    public string ConnectionString =
    //   "SERVER=localhost;DATABASE=labreportdotnet;UID=root;PASSWORD=;";
    //    MySqlConnection connect;
    //    public void connection()
    //    {
    //        connect = new MySqlConnection(ConnectionString);
    //        try
    //        {
    //            connect.Open();
    //            Console.WriteLine("Connection Success");
    //        }
    //        catch (MySqlException ex)
    //        {
    //            Console.WriteLine("Database Error: " + ex.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Error:" + ex.Message);
    //        }
    //    }
    //    public void UpdateStudent()
    //    {
    //        try
    //        {
    //            if (connect?.State != ConnectionState.Open)
    //            {
    //                Console.WriteLine("Database connection is not open");
    //                return;
    //            }

    //            Console.WriteLine("Enter student id to be updated?");
    //            int id = Convert.ToInt32(Console.ReadLine());
    //            Console.WriteLine("********Enter New Information for Selected ID");
    //            Console.WriteLine("Enter student name?");
    //            string name = Console.ReadLine();
    //            Console.WriteLine("Enter student roll?");
    //            string roll = Console.ReadLine();  // Changed to string to match VARCHAR
    //            Console.WriteLine("Enter student semester?");
    //            int semester = int.Parse(Console.ReadLine());

    //            using (MySqlCommand cmd = new MySqlCommand(
    //                "UPDATE students SET name = @name, semester = @semester, rollno = @roll WHERE id = @sid",
    //                connect))
    //            {
    //                cmd.Parameters.AddWithValue("@sid", id);
    //                cmd.Parameters.AddWithValue("@name", name);
    //                cmd.Parameters.AddWithValue("@semester", semester);
    //                cmd.Parameters.AddWithValue("@roll", roll);  // Changed to match parameter name in SQL

    //                int num = cmd.ExecuteNonQuery();
    //                Console.WriteLine(num == 1
    //                    ? "Student Updated Successfully"
    //                    : "Student Update Failed (ID might not exist)");
    //            }
    //        }
    //        catch (MySqlException ex)
    //        {
    //            Console.WriteLine("Database Error: " + ex.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Error:" + ex.Message);
    //        }
    //    }

    //    public void DeleteStudent()
    //    {
    //        try
    //        {
    //            Console.WriteLine("Enter student id?");
    //            int id = Convert.ToInt32(Console.ReadLine());

    //            MySqlCommand cmd = new MySqlCommand("delete from students where id=@sid",
    //           connect);
    //            cmd.Parameters.AddWithValue("@sid", id);
    //            int num = cmd.ExecuteNonQuery();
    //            if (num == 1)
    //            {
    //                Console.WriteLine("Student Deleted Successfully");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Student Delete Failed");
    //            }
    //        }
    //        catch (MySqlException ex)
    //        {
    //            Console.WriteLine("Database Error: " + ex.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Error:" + ex.Message);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        DatabaseExample de = new DatabaseExample();
    //        de.connection();
    //        de.DeleteStudent();
    //        de.UpdateStudent();
    //        Console.ReadKey();
    //    }




    //    }
    }
