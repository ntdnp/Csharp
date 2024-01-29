using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOP
{
    public class Service 
    {
        // tạo class Student có các thành phần: tên tuổi (int), điểm (double)
        // viết constructor nhận vào 3 đối số: tên tuổi và điểm 
        // viết chương trình cho phép người dùng nhập thông tin học sinh,
        // sau khi nhập xong thì hỏi xem
        // có muốn tiếp tục không, nếu bấm "y" thì nhập tiếp,
        // nếu bấm phím khác thì dừng chương trinhg
        // và in ra thông tin các học sinh đã nhập ( lưu ý validate tuổi và điểm )
        public class Student 
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public double Score { get; set; }
            public Student(string name, int age, double score)
            {
                Name = name;
                Age = (age >= 0) ? age : 0;
                Score = (score >= 0 && score <= 10) ? score : 0;
            }

         
            public void GetInfo()
            {
                Console.WriteLine($"Tên: {Name}, Tuổi: {Age}, Điểm: {Score}");
            }

        }
    }
}
