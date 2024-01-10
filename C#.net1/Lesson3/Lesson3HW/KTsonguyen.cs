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
            public void InputNumber()// xu ly ngoai le bang if else
            {
                Console.WriteLine("Input the number");
                string value = Console.ReadLine();
                try
                {
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
                catch(Exception ex )
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(" co loi ");
                }
              
            }
            public void InputNumber1() // xu ly ngoai le bang bool check 
            {
                Console.WriteLine("Input the number");
                string value = Console.ReadLine();
                //int number = int.Parse(value);
                bool  check= int.TryParse(value, out int number);
                if (check == false)
                {
                    Console.WriteLine("Number is not correct");
                    return;
                }
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
