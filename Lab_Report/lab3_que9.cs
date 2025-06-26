using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace Lab_Report
{
    class DatabaseExample
    {
        public string ConnectionString = "SERVER=localhost;DATABASE=labreportdotnet;UID=root;PASSWORD=;";
        MySqlConnection connect;

        public void Connection()
        {
            connect = new MySqlConnection(ConnectionString);
            try
            {
                connect.Open();
                Console.WriteLine("Connection Success");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        public void AddStudent()
        {
            try
            {
                if (connect?.State != ConnectionState.Open)
                {
                    Console.WriteLine("Database connection is not open");
                    return;
                }

                Console.WriteLine("Enter student name?");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student roll?");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student semester?");
                int semester = int.Parse(Console.ReadLine());

                using (MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO students (name, rollno, semester) VALUES (@name, @rollno, @semester)",
                    connect))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@rollno", roll);
                    cmd.Parameters.AddWithValue("@semester", semester);

                    int num = cmd.ExecuteNonQuery();
                    Console.WriteLine(num == 1
                        ? "Student Added Successfully"
                        : "Student Addition Failed");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        public void SelectStudents()
        {
            try
            {
                if (connect?.State != ConnectionState.Open)
                {
                    Console.WriteLine("Database connection is not open");
                    return;
                }

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM students", connect))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count != 0)
                    {
                        Console.WriteLine("ID\tName\tRollNo\tSemester");
                        foreach (DataRow row in dt.Rows)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                                row["id"],
                                row["name"],
                                row["rollno"],
                                row["semester"]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No students found in database");
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        public void DeleteStudent()
        {
            try
            {
                if (connect?.State != ConnectionState.Open)
                {
                    Console.WriteLine("Database connection is not open");
                    return;
                }

                Console.WriteLine("Enter student id?");
                int id = Convert.ToInt32(Console.ReadLine());

                using (MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM students WHERE id=@sid", connect))
                {
                    cmd.Parameters.AddWithValue("@sid", id);
                    int num = cmd.ExecuteNonQuery();
                    Console.WriteLine(num == 1
                        ? "Student Deleted Successfully"
                        : "Student Delete Failed (ID might not exist)");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        public void UpdateStudent()
        {
            try
            {
                if (connect?.State != ConnectionState.Open)
                {
                    Console.WriteLine("Database connection is not open");
                    return;
                }

                Console.WriteLine("Enter student id to be updated?");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("********Enter New Information for Selected ID");
                Console.WriteLine("Enter student name?");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student roll?");
                int roll = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student semester?");
                int semester = int.Parse(Console.ReadLine());

                using (MySqlCommand cmd = new MySqlCommand(
                    "UPDATE students SET name = @name, semester = @semester, rollno = @rollno WHERE id = @sid",
                    connect))
                {
                    cmd.Parameters.AddWithValue("@sid", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@semester", semester);
                    cmd.Parameters.AddWithValue("@rollno", roll);

                    int num = cmd.ExecuteNonQuery();
                    Console.WriteLine(num == 1
                        ? "Student Updated Successfully"
                        : "Student Update Failed (ID might not exist)");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            DatabaseExample de = new DatabaseExample();
            de.Connection();
            de.AddStudent();
            de.SelectStudents();
            de.DeleteStudent();
            de.UpdateStudent();
            Console.ReadKey();
        }
    }
}