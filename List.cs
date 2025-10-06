using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_Student_Management_System
{
    internal class List
    {
        private List<Students> students = new List<Students>();
        private void DisplayMenu()
        {
            Console.WriteLine("1 - Add student");
            Console.WriteLine("2 - List students");
            Console.WriteLine("3-Remove student");
            Console.WriteLine("4-Show average grade");
            Console.WriteLine("5-Exit");

        }
        private void Exit()
        {
            Console.WriteLine("Exiting the program. Goodbye!");
            Environment.Exit(0);
        }
        private void AddStudent()
        {
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student grades:");
            int grades = int.Parse(Console.ReadLine());
            Students student = new Students(age, name, grades);
            students.Add(student);
            Console.WriteLine("Student added successfully!");   
        }
        private void RemoveStudent()
        {
            Console.WriteLine("Enter student name to remove:");
            string nameToRemove = Console.ReadLine();
            var studentToRemove = students.FirstOrDefault(s => s.Name == nameToRemove);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Student removed successfully!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }

        }
        private void ListStudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students available.");
                return;
            }
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grades: {student.Grades}");
            }

        }
        private void ShowAverageGrade()
        {
            if (students.Count > 0)
            {
                double average = students.Average(s => s.Grades);
                Console.WriteLine($"Average grade: {average}");
            }
            else
            {
                Console.WriteLine("No students available to calculate average grade.");
            }
        }
        public List()
        {
            while (true)
            {
                DisplayMenu();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ListStudent();

                        break;
                    case 3:
                        RemoveStudent();

                        break;
                    case 4:
                        ShowAverageGrade();
                        break;
                    default:
                        Exit();
                        break;
                }

            }
            


        }
        
    }
}
