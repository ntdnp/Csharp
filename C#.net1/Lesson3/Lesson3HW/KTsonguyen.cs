using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3HW
{
    internal class KTsonguyen
    {
        static void Main()
        {
            Console.Write("Nhap mot so nguyen: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                CheckNumberType(number);
            }
            else
            {
                Console.WriteLine("khong hop le ");
            }

           
            Console.ReadKey();
        }

        static void CheckNumberType(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("so duong .");
            }
            else if (number < 0)
            {
                Console.WriteLine("So am.");
            }
            else
            {
                Console.WriteLine("So bang 0 .");
            }
        }

    }
   
}
