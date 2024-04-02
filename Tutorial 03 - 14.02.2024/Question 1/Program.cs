using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tute3._1
{
    internal class Program
    {
        public class Course
        {
            private string courseName;
            private string instructorName;
            private double grade;
            private readonly object InstructorName;

            public string CourseName
            {
                get { return courseName; }
            }
            public double Grade
            {
                get { return grade; }
            }
            public string instructorname
            {
                get { return instructorname; }
            }
            
            public Course(string courseName, string instructorName, double grade)
            {
                this.courseName = courseName;
                this.instructorName = instructorName;
                this.grade = grade;
            }
            public string SetInstructorName()
            {
                Console.WriteLine("Enter the instructor name: ");
                string name = Console.ReadLine();

                while (name == null)
                {
                    Console.Write("Instructor name cannot be empty");
                    name = Console.ReadLine();
                }
                return name;
            }

            private string CalculateLetterGrade()
            {
                if (grade >= 75)
                {
                    return "A";
                }
                else if (grade >= 65)
                {
                    return "B";
                }
                else if (grade >= 55)
                {
                    return "C";
                }
                else if (grade >= 35)
                {
                    return "S";
                }
                else
                {
                    return "F";
                }
            }
            public void PrintCourseInfo()
            {
                Console.WriteLine($"Course name: {CourseName}");
                Console.WriteLine($"Course Instructor: {InstructorName}");
                Console.WriteLine($"Course Grade: {CalculateLetterGrade()}");
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the course name: ");
            string coursename = Console.ReadLine();

            Console.WriteLine("Enter the name of the course instructor: ");
            string instructorName = Console.ReadLine();

            Console.WriteLine("Enter the marks: ");
            string courseName = Console.ReadLine();
        }
    }
}
