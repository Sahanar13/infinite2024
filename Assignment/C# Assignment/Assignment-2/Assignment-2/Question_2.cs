using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Student
    {
        private int rollNo;
        private string name;
        private string className;
        private string semester;
        private string branch;
        private int[] marks = new int[5];

        public Student(int rollNo, string name, string className, string semester, string branch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.className = className;
            this.semester = semester;
            this.branch = branch;
        }

        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            int totalMarks = 0;
            foreach (int mark in marks)
            {
                totalMarks += mark;
                if (mark < 35)
                {
                    Console.WriteLine("Result: Failed");
                    Console.ReadKey();
                    return;
                }
            }

            double averageMarks = totalMarks / 5.0;

            if (averageMarks < 50)
            {
                Console.WriteLine("Result: Failed");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Result: Passed");
                Console.ReadKey();
            }
        }

        public void DisplayData()
        {
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
                Console.ReadKey();
            }
        }
    }

    class Question_2
    {
        static void Main(string[] args)
        {
            Student student = new Student(18, "Yash", "10th", "Seventh", "Computer Science");
            student.GetMarks();
            student.DisplayResult();
            student.DisplayData();
            Console.ReadKey();
        }
    }
}