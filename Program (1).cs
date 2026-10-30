
using System;
using System.Collections.Generic;

public class Student
{
    public string Name;
    public int RollNumber;
    public double Marks;
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        int choice = 0;

        while (choice != 3)
        {
            Console.WriteLine("\n===== STUDENT RECORD MANAGEMENT SYSTEM =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                choice = 0;
                continue;
            }

            if (choice == 1)
            {
                Student s = new Student();

                Console.Write("Enter Student Name: ");
                s.Name = Console.ReadLine();

                Console.Write("Enter Roll Number: ");
                if (!int.TryParse(Console.ReadLine(), out s.RollNumber))
                {
                    Console.WriteLine("Invalid roll number!");
                    continue;
                }

                Console.Write("Enter Marks: ");
                if (!double.TryParse(Console.ReadLine(), out s.Marks))
                {
                    Console.WriteLine("Invalid marks!");
                    continue;
                }

                students.Add(s);
                Console.WriteLine("Student added successfully!");
            }
            else if (choice == 2)
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No student records found.");
                }
                else
                {
                    Console.WriteLine("\n===== STUDENT DETAILS =====");

                    foreach (Student s in students)
                    {
                        Console.WriteLine("Name: " + s.Name);
                        Console.WriteLine("Roll Number: " + s.RollNumber);
                        Console.WriteLine("Marks: " + s.Marks);
                        Console.WriteLine("-------------------------");
                    }
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thank you for using Student Record System!");
            }
            else
            {
                Console.WriteLine("Invalid choice! Try again.");
            }
        }
    }
}
