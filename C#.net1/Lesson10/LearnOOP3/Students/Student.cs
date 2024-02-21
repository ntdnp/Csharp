using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP3.Students
{
    public class Student
    {
        public int No { get; set; }
        public string Name { get; set; }
        public double AvgScore { get; set; }

        public Student(int no, string name, double avgScore)
        {
            No = no;
            Name = name;
            AvgScore = avgScore;
        }
    }

}
