using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{//tạo class school có các property:
    // 1 list các english student
    // thêm mới 1 std vào list
    // tính tổng điểm trung bình của các học sinh trong list

    public class School
    {
        internal List<Student> Students { get; set; }
        public void AddStudent(EnglishStudent std)  
        {
            Students.Add(std);
        }
        public double SumAvgScore() 
        {
            return Students.Sum(s=> s.Math);
        }

    }
    public class GenericSchool<TStudent> where TStudent : Student
    {
        internal List<TStudent> Students { get; set; }
        public void AddStudent(TStudent std)
        {
            Students.Add(std);
        }
        public double SumAvgScore()
        {
            return Students.Sum(s => s.Math);
        }
    }
}
