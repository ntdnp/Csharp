using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLoop
{
    internal class Service
    {
        public static void LearnForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break; // thoat ra khoi dong lenh
                    continue;// bo qua cai cac dong lenh sau 
                }

            }


        }

        public static void LearnForLoop1()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void LearnForLoop2()
        { // viets hàm in ra các số lẻ và chia hết cho 3 từ 1 đến 100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
        public static void LearnWhileLoop()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

        }
        //viết ứng dụng cho phép người dùng nhập tên tuổi, địa chỉ,
        //sau khi nhập xong thì in ra thông tin  => hỏi có muốn tiếp tục ko,
        //nếu bấm "y" thì tiếp tục cho nhập lại , nếu bấm bất kỳ phím nào khác => dừng chương trình
        public static void InputUser()
        {
            bool isContinue = true;
            while (isContinue)
            {
                Console.Write("Ten: ");
                string name = Console.ReadLine();
                // yêu cầu tuổi phải hợp lệ và > 0, nếu người dùng ko nhập đúng yêu cầu thì hiển thị ra thống báo : bạn vui lòng nhập lại tuổi và yêu cầu người dùng nhập đúng mới thôi (while)
                Console.Write("Tuoi: ");
                int age;
                //int.TryParse(Console.ReadLine(), out age);
                //while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
                //{
                //    Console.WriteLine("Tuoi khong hop le. vui long nhap lai");
                //    Console.Write("Tuoi: ");
                //}
                bool checkAge = int.TryParse(Console.ReadLine(), out age) && age > 0;
                while (!checkAge)
                {
                    Console.WriteLine("Bạn vui lòng nhập tuổi hợp lệ và > 0");
                    checkAge = int.TryParse(Console.ReadLine(), out age) && age > 0;
                }
                int.TryParse(Console.ReadLine(), out age);
                Console.Write("Dia chi : ");
                string address = Console.ReadLine();
                Console.WriteLine($"name: {name},age:{age},addres:{address} ");
                Console.WriteLine("nhan y de tiep tuc");
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
        //nhập thông tin học sinh : tên và điểm 3 môn văn toán anh (double), điểm trong khaong 0=>10, nếu nhập ko đúng bắt nhập cho đến khi đúng mới thôi  => in ra thông tin học sinh
        public static void InputStudent()
        {
            Console.WriteLine("input the name");
            string name = Console.ReadLine();

            Console.WriteLine("Input your math score");
            ValidateScore(out double mathScore);

            Console.WriteLine("Input your literature score");
            ValidateScore(out double literatureScore);

            Console.WriteLine("Input your english score");
            ValidateScore(out double englishScore);

            Console.WriteLine($"Name: {name}, math: {mathScore}, literature: {literatureScore}, english: {englishScore} ");

        }

        public static void ValidateScore(out double score)
        {
            bool check =
                double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 10;

            while (!check)
            {
                Console.WriteLine("score must be between 0 - 10");
                check = double.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 10;
            }
        }

    }
}
