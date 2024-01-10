using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3HW
{
    internal class KTsonguyen
    {
        public string IntegerCheck(int number)
        {
            string result = "";
            if (number > 0)
            {
                result = "So nguyen duong";
            }
            else if (number < 0)
            {
                result = "So nguyen am ";
            }
            else
            {
                result = "So da nhap la 0 ";
            }

            return result;
        }


    }

}
