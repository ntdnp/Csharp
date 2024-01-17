using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnList
{
    public class Service2
    {
        //Service2 data member su dung tat ca cac ham 
        public List<int> number = new List<int>() { 1, 23, 4, 56, 7 };
        public void DemoLinQ()
        {
            // tao ta mot list tu cac so le tu list da cho
            List<int> oddNumber = new List<int>();
            // cach 1
            //for (int i = 0; i <number.Count ; i++)
            //{
            //    if (number[i] % 2 != 0)
            //    {
            //        oddNumber.Add(number[i]);

            //    }

            //}
            //cach2
            //foreach (int number in number) 
            //{
            //    if(number %2!=0)
            //    {
            //        oddNumber.Add(number);
            //    } 
            //}
            oddNumber = number.Where(item => item % 2 != 0).ToList();


        }
        // từ list đã cho lấy ra 1 list các số lẻ chia hết cho 3
        public void DemoLinQ1()
        {
            // tao ta mot list tu cac so le tu list da cho
            List<int> oddNumber = new List<int>();

            oddNumber = number.Where(num => num % 2 != 0 && num % 3 == 0).ToList();
        }
        public void Arrager()
        {
            var accendingNumber = number.OrderBy(num => num).ToList();
            var descendingNumber = number.OrderByDescending(num => num).ToList();

        }
    }
}
