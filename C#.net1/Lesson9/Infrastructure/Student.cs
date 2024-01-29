using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Infrastructure
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Math { get; set; }
        public double Literature { get; set; }

        public Student(string name, int age, double math, double literature)
        {
            Name = name;
            Age = age;
            Math = math;
            Literature = literature;
        }
        public string GetInfo()
        {
            return $"Name: {Name}, age: {Age}, Average score: {CalculateScore()} ";
        }
        protected virtual double CalculateScore()
        {
            return (Math + Literature) * 0.5;
        }
    }

    public class EnglishStudent : Student
    {
        public double English { get; set; }
        public EnglishStudent(string name, int age, double math, double literature, double english)
        : base(name, age, math, literature)
        {
            English = english;
        }

        protected override double CalculateScore()
        {
            return (Math + Literature + English * 2) / 4; ;
        }
    }

    public class HistoryStudent : Student
    {
        public double History { get; set; }

        public HistoryStudent(string name, int age, double math, double literature, double history)
            : base(name, age, math, literature)
        {
            History = history;
        }

        protected override double CalculateScore()
        {
            return (Math + Literature + History * 3) / 5;
        }
    }
}

