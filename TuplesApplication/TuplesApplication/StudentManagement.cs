using System;
using System.Collections.Generic;

namespace TuplesApplication
{
    class StudentManagement
    {
        public string Name { private get; set; }
        public int Grade { private get; set; }
        public int Age { private get; set; }
        public IList<Double> SGPA { private get; set; }

        public (string studentName, int studentGrade) GetNameAndGrade()
        {
            var studentInfo = (this.Name, grade: this.Grade);
            return studentInfo;
        }

        public (string studentName, int studentGrade, int studentAge) GetStudentGeneralInformation()
        {
            var studentGeneralInfo = (this.Name, this.Grade, this.Age);
            return studentGeneralInfo;
        }

        public (string studentName, double CGPA) CalculateCGPA()
        {
            var academicStats = (name: this.Name, CGPA: 0.0);
            foreach (var gpa in this.SGPA)
            {
                academicStats.CGPA += gpa;
            }
            academicStats.CGPA /= this.SGPA.Count;
            return academicStats;
        }
    }
}
