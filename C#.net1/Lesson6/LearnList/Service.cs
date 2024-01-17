using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnList
{
    public class Service
    {
       
        public static void DemoList() 
        {
            List<int> lstNumber = new List<int>();
            lstNumber.Add(1);
            lstNumber.Add(2);
            lstNumber.Add(3);
            lstNumber.Add(4);
            lstNumber.Remove(4);
            List<string> studen = new List<string>() { "nam ", "na", "dat" };
            studen[0] = "nam";
            string std1 = studen[^1];
            string std1a = studen[studen.Count - 1];
            Console.ReadKey();
        }
        // làm lại bài từ điển sử dụng list
        public static void DemoList1(string keyword) 
        {
            List<string> vietnamse = new List<string>() { "ban", "ghe", "but", };
            List<string>  english = new List<string>() { "table", "chair", "pen", };

            for (int i = 0; i < english.Count; i++)
            {
                // if (english[i] == keyword)
                if (english[i].Equals(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Tu co nghia tieng viet la: {vietnamse[i]}");
                    return;
                }

            }
            Console.WriteLine($"Khong tim thay ket qua");

        } 

    }
}
