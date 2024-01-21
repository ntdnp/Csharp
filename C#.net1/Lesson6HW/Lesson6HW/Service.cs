using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6HW
{
    internal class Service
    {
        
        public static void Number()
        {
            //1. Tạo một danh sách:
            // Tạo một danh sách số nguyên và hiển thị nó trên màn hình.
            List<int> number = new List<int>() { -6, -2, -9, -4, 7, 1, 91,37, 3, 5, 2, -4, 2, 8, };
            Console.WriteLine("\n danh sach so nguyen vua tao la :");
            for (int i = 0; i < number.Count; i++)
            {
                Console.WriteLine(number[i]);

            }
            
            //2. Thêm và xóa phần tử:
            //Thêm một phần tử mới vào danh sách và hiển thị danh sách sau khi thêm.
            number.Add(78);
            Console.WriteLine("\n Ds sau khi them mot phan tu:");
            foreach (int number1 in number)
            {
                Console.Write(number1 + " ");

            }

            // Xóa một phần tử từ danh sách và hiển thị danh sách sau khi xóa
            number.Remove(8);
            Console.WriteLine("\n Ds sau khi xoa mot phan tu:");
            foreach (int number1 in number)
            {
                Console.Write(number1 + " ");

            }
            //3.Tính tổng và trung bình:
            //Tính tổng của tất cả các phần tử trong danh sách.
            int sum = number.Sum(); 
            Console.WriteLine("\n Tong Ds la:");
            Console.WriteLine(sum);
            
            //Tính giá trị trung bình của các phần tử trong danh sách.
            double average = number.Average();
            Console.WriteLine("\n TB Ds la:");
            Console.WriteLine(average);
            Console.ReadLine();

        }
        public static void Number1()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            // Tính tổng các số lẻ
            int sumOdd = numbers.Where(n => n % 2 != 0).Sum();
            Console.WriteLine($"Tong le: {sumOdd}");

            // Tính tổng các số chẵn
            int sumEven = numbers.Where(n => n % 2 == 0).Sum();
            Console.WriteLine($"Tong chan: {sumEven}");

            // Tính tổng các số nguyên tố
            int sumPrime = numbers.Where(IsPrime).Sum();
            Console.WriteLine($"Tong so nguyen to : {sumPrime}");
            Console.ReadLine();
        }

        // Phương thức kiểm tra số nguyên tố
        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
