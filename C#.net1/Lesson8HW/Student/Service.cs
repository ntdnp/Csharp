using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace Lesson8HW
{    // tạo class Student có các thành phần: tên tuổi (int), điểm (double)
     // viết constructor nhận vào 3 đối số: tên tuổi và điểm 
     // viết chương trình cho phép người dùng nhập thông tin học sinh
     // sau khi nhập xong thì hỏi xem có muốn tiếp tục không
     // nếu bấm "y" thì nhập tiếp, nếu bấm phím khác thì dừng
     // chương trình và in ra thông tin các học sinh đã nhập ( lưu ý validate tuổi và điểm )
    public class Student
    {
        private string name { get; set; }
        private int age;
        private double score;

        public Student()
        {

        }
        public Student(string name1, int age1, double score1)
        {
            name = name1;
            age = age1;
            score = score1;
        }
        public string Name
        {
            get { return name; }
            set
            { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                bool check = int.TryParse(Console.ReadLine(), out age) && age > 0 && age < 100;
                while (!check)
                {
                    Console.WriteLine("Vui long nhap dung");
                    check = int.TryParse(Console.ReadLine(), out age) && age > 0 && age < 100;
                }
              
            }
        }
        public double Score
        {
            get { return score; }
            set
            {
                bool check = double.TryParse(Console.ReadLine(), out score) && score > 0 && score <= 10;
                while (!check)
                {
                    Console.WriteLine("Vui long nhap dung");
                    check = double.TryParse(Console.ReadLine(), out score) && score > 0 && score <= 10;
                }
                
            }
        }
        public string infor => $"name: {name}, age: {age}, score: {score}";

        public void Program()
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("Input your student name:");
                Name = Console.ReadLine();

                Console.WriteLine("Input your student age: ");
                Age = age;

                Console.WriteLine("Input your student score: ");
                Score = score;

                Console.WriteLine(infor);
                Console.WriteLine("Ban co muon tiep tuc khong");
                string value = Console.ReadLine();
                if (value == "y")
                {
                    isContinue = true;
                }
                else
                {
                    isContinue = false;
                }
            }
        }
    }
}





