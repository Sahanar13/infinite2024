using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1_ADO_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Management");

            bool running = true;

            string connectionString = "Data Source=ICS-LT-9R368G3\\SQLEXPRESS;Initial Catalog=Employeemanagement;Integrated Security=True";

            while (running)
            {
                Console.WriteLine("Please Enter Your Choice:");
                Console.WriteLine("1. Add Employee Details");
                Console.WriteLine("2. View Employee Details");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            AddEmployee(connectionString);
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case 2:
                        ViewEmployeeDetails(connectionString);
                        break;
                    case 3:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddEmployee(string connectionString)
        {
            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            decimal empSal = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Employee Type ('P' or 'C'): ");
            string empType = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AddEmployee", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpName", empName);
                    command.Parameters.AddWithValue("@Empsal", empSal);
                    command.Parameters.AddWithValue("@Emptype", empType);

                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Employee details added successfully!");
            ViewEmployeeDetails(connectionString);
        }

        static void ViewEmployeeDetails(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Employee_Details", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine("Employee Details:");
                            while (reader.Read())
                            {
                                Console.WriteLine($"Empno: {reader.GetInt32(0)}, EmpName: {reader.GetString(1)}, Empsal: {reader.GetDecimal(2)}, Emptype: {reader.GetString(3)}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No employee details found.");
                        }
                    }
                }
            }
        }
    }
}
