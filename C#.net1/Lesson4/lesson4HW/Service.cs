using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4HW
{
    internal class Service
    {
        /// Viết hàm nhận vào 3 cạnh của 1 tam giác ( kiểu int) và trả ra xem tam giác đó là cân, vuông hay không phải là tam giác

        public string TriangleTest(int a,int b,int c)
        {
            try 
           
            {
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    return "Khong phai tam giac ";

                }
                else if (a == b && b == c)
                {
                    return "La tam giac deu";
                }
                else if (a == b || b == c || a == c)
                {
                    return "La tam giac can";
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    return "La tam giac vuong";
                }
                else
                {
                    return "La tam giac thuong";
                }
            }
            catch 
            
            {
                return "co loi ";
            }
        }
    }
}
