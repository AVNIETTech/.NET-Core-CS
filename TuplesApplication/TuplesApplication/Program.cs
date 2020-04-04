using System;
using System.Collections.Generic;
using System.Globalization;

namespace TuplesApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManagement management = new StudentManagement();
            var details = ReadDetails();
            management.Age = details.age;
            management.Name = details.name;
            management.SGPA = details.SGPA;
            management.Grade = details.grade;
            PrintDetails(management);
        }

        static (string name, IList<Double> SGPA, int age, int grade) ReadDetails()
        {
            IList<Double> SGPA = new List<Double>();
            Console.WriteLine("Enter the student's name");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter the student's age");
            if (!int.TryParse(Console.ReadLine(), out int studentAge))
            {
                Console.WriteLine("Age cannot be anything but an integer.");
            }
            Console.WriteLine("Enter the student's grade.");
            if (!int.TryParse(Console.ReadLine(), out int studentGrade))
            {
                Console.WriteLine("Grade must be an integer!");
            }
            Console.WriteLine("Enter the student's SGPA for every semester. Enter 0 if you've finished.");
            while (true)
            {
                double sgpa = Convert.ToDouble(Console.ReadLine(), new CultureInfo("en-US").NumberFormat);
                if (sgpa != 0)
                {
                    SGPA.Add(sgpa);
                }
                else
                    break;
            }
            return (studentName, SGPA, studentAge, studentGrade);
        }

        static void PrintDetails(StudentManagement studentManagement)
        {
            (string name, double gpa) = studentManagement.CalculateCGPA();
            var studentGeneralData = studentManagement.GetStudentGeneralInformation();
            Console.WriteLine(name + " of grade " + studentGeneralData.studentGrade + " has scored " + gpa);
        }
    }
}
