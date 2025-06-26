using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;


namespace Lab_Report{
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

    //    public void AddStudent()
    //    {
    //        try
    //        {
    //            Console.WriteLine("Enter student name?");
    //            string name = Console.ReadLine();
    //            Console.WriteLine("Enter student roll?");
    //            int roll = Convert.ToInt32(Console.ReadLine());
    //            Console.WriteLine("Enter student semester?");
    //            int semester = int.Parse(Console.ReadLine());
    //            MySqlCommand cmd = new MySqlCommand("Insert into students (name, rollno, semester)values(@name, @roll, @semester)", connect);

    //            cmd.Parameters.AddWithValue("@name", name);
    //            cmd.Parameters.AddWithValue("@roll", roll);
    //            cmd.Parameters.AddWithValue("@semester", semester);
    //            /*cmd.Parameters.AddWithValue("@name", "Kazol");
    //            cmd.Parameters.AddWithValue("@roll", 10);
    //            cmd.Parameters.AddWithValue("@semester", 5);*/
    //            int num = cmd.ExecuteNonQuery();
    //            if (num == 1)
    //            {
    //                Console.WriteLine("Student Added Successfully");
    //            }
    //            else
    //            {
    //                Console.WriteLine("Student Addtion Failed");
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
    //    void SelectStudents()
    //    {
    //        MySqlCommand cmd = new MySqlCommand("select * from students", connect);
    //        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
    //        DataTable dt = new DataTable();
    //        adapter.Fill(dt);
    //        if (dt.Rows.Count != 0)
    //        {
    //            Console.WriteLine("ID\tName\tRoll\tSemester");
    //            for (int i = 0; i < dt.Rows.Count; i++)
    //            {
    //                string id = dt.Rows[i]["id"].ToString();
    //                string name = dt.Rows[i]["name"].ToString();
    //                string semester = dt.Rows[i]["semester"].ToString();
    //                string roll = dt.Rows[i]["rollno"].ToString();
    //                Console.WriteLine("{0}\t{1}\t{2}\t{3}", id, name, roll, semester);
    //            }
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        DatabaseExample de = new DatabaseExample();
    //        de.connection();
    //        de.AddStudent();
    //        de.SelectStudents();
    //        //de.DeleteStudent();
    //        //de.UpdateStudent();
    //        Console.ReadKey();
    //    }
    //}
}




