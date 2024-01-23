using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLinQ
{
    public class Service
    {
        public List<int> _lstNumber = new List<int>() { 12, 17, 23, 27, 56, 79, 2, 11, 20, 8 };

        public void Demo()
        {
            // lấy ra phần từ đầu tiên/ cuối cùng là số lẻ
            var firstOddNumber = _lstNumber.FirstOrDefault(s => s % 2 != 0);
            var lastOddNumber = _lstNumber.LastOrDefault(s => s % 2 != 0);

            var test = _lstNumber.FirstOrDefault(s => s > 1000);

            var threeElement = _lstNumber.Take(3).ToList();
            var threeElement1 = _lstNumber.Skip(3).Take(3).ToList();

            // từ list đã cho lấy ra các số lẻ, sắp xếp tăng dần và lấy ra list 3 phần tử đầu tiên
            var oddNumbers = _lstNumber.Where(s => s % 2 != 0).OrderBy(s => s).Take(3).ToList();

            //

            var select1 = _lstNumber.Select(s => s * s).ToList();
            var select2 = _lstNumber.Select(s => $"number-{s}").ToList();

            //loại bỏ ptu giống nhau
            var distinct = _lstNumber.Distinct().ToList();

            var sum = _lstNumber.Sum(s => s);
            var avg = _lstNumber.Average(s => s);
            var max = _lstNumber.Max(s => s);
            var min = _lstNumber.Min(s => s);

            var aggregate = _lstNumber.Aggregate((s1, s2) => s1 + 1 + s2);
            var aggregate1 = _lstNumber.Aggregate((s1, s2) => s1 % s2);
        }
    }

}
