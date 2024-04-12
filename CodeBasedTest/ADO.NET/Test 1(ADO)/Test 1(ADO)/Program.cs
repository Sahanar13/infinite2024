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
                            AddEmployee();
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;
                    case 2:
                        ViewEmployeeDetails();
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

        static void AddEmployee()
        {
            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            decimal empSal = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Employee Type ('P' or 'C'): ");
            string empType = Console.ReadLine();

            using (var context = new EmployeemanagementEntities())
            {
                context.Database.ExecuteSqlCommand("EXEC AddEmployee @EmpName, @Empsal, @Emptype",
                    new SqlParameter("@EmpName", empName),
                    new SqlParameter("@Empsal", empSal),
                    new SqlParameter("@Emptype", empType));
            }

            Console.WriteLine("Employee details added successfully!");
            ViewEmployeeDetails();
        }

        static void ViewEmployeeDetails()
        {
            using (var context = new EmployeemanagementEntities())
            {
                var employeeDetails = context.Employee_Details.ToList();

                if (employeeDetails.Any())
                {
                    Console.WriteLine("Employee Details:");
                    foreach (var emp in employeeDetails)
                    {
                        Console.WriteLine($"Empno: {emp.Empno}, EmpName: {emp.EmpName}, Empsal: {emp.Empsal}, Emptype: {emp.Emptype}");
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

