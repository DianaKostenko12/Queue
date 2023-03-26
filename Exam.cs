using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_2_
{
    public class Exam
    {
        public Student [] Students { get; set; }
        public Exam(Student [] students)
        {
            Students = students;
        }
    }
}
