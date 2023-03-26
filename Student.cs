using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2_
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int StudentId { get; set; }
        public string TheoryExamResult { get; set; }
        public string PracticalTasksResult { get; set; }
        public Student(string name, string surname, int studentId, string theoryExamResult, string practicalTasksResult)
        {
            Name = name;
            Surname = surname;
            StudentId = studentId;
            TheoryExamResult = theoryExamResult;
            PracticalTasksResult = practicalTasksResult;
        }
    }
}
