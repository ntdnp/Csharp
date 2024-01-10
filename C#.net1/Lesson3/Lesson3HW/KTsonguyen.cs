using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3HW
{
    internal class KTsonguyen
    {
        public class HW
        {
            //Viết chương trình C# để kiểm tra xem một số nguyên nhập từ người dùng là số dương,
            //số âm, hay bằng 0
            public void InputNumber()
            {
                Console.WriteLine("Input the number");
                string value = Console.ReadLine();
                int number = int.Parse(value);
                if (number == 0)
                {
                    Console.WriteLine(" the input number is 0");
                
                }
               
                else if (number > 0)
                {
                    Console.WriteLine(" the input number is positive number ");

                }
                 else if (number < 0)
                {
                    Console.WriteLine(" the input number is negative number ");

                }

            }
        }
        


    }

}
