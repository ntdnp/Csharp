using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnArray
{
    public class Service
    {
        public static void DemoArray()
        {
           int[] arrNumbers = new int[6];
           arrNumbers[0] = 1;// gan gia tri
           arrNumbers[1] = 6;
           arrNumbers[2] = 6;
           arrNumbers[3] = 7;
           arrNumbers[4] = 8;
           arrNumbers[5] = 4;
           arrNumbers[6] = 7;
           string[] fruits = new string[6] { "le", "tao", "na", "dao", "cam", "man" };
           string[] words = { "le", "tao", "na", };
           Console.WriteLine(words[1]);// lay gia tri ra 
           int length = words.Length;
           Console.ReadKey();
         
        }
        // viet ham trong ham tao ra 1 mang cac so , dung vong lap for in ra cac phan tu trong mang 
        public static void Mang()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("cac phan tu trong mang :");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);

            }
            Console.ReadKey();
        }
        // viết hàm ứng dụng từ điển: Trong hàm khai báo 2 mảng 1 mảng tiếng việt (vd: bàn, ghế bút), và mảng tiếng anh tương ứng (vd: table,chair, pen).Yêu cầu khi người dùng nhập vào 1 từ tiếng anh thì trả ra từ tiếng việt tương ứng, nếu ko có thì trả ra ko tìm thấy.
        public static void DomeArray1(string keyword)
        {
            string[] vietnamse = { "ban", "ghe", "but", };
            string[] english   = { "table", "chair", "pen", };
            for(int i = 0; i < english.Length; i++)
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
