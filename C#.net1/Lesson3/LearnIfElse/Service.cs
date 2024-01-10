using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace LearnIfElse
{
    internal class Service
    {
        //xac dịnh học lụcư điểm <5 => bad ,=5 => average >5 => good 
        public string EvaluateStudent(double score)
        {
            string result = " ";
            if (score == 5)
            {
                result = " average";
            }
            if (score < 5)

            {
                result = "bad";
            }

            if (score > 5)

            {
                result = "good";
            }
            return result;
        }
        // viet ham xem nam do co phai nam nhuận hay ko 
        // neu nam do chia het cho 100 thi phai chia het cho 400
        // neu nam do ko chia het cho 100 thi phai chia het cho 4
        public bool CheckLunarYear(int year)
        {
            if (year < 0)
            {
                return false;
            }

            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (year % 4 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }



        }
        public bool CheckLunarYear1(int year)
        {
            if ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            {
                return true;
            }
            return false;
        }

        public bool CheckLunarYear2(int year)
        {
            return (year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
        }

        public bool CheckLunarYear3(int year)
            => (year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);

    }
}
