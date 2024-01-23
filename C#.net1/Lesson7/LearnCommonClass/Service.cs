using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCommonClass
{
    public class Service
    {
        public static void Demo0()
        {
            //length - trả về độ dài của chuỗi
            string str = "Hello";
            int length = str.Length;

            //concat - nối chuỗi
            string str1 = "Hello";
            string str2 = "World!";
            string result = string.Concat(str1, str2);


            string upperCase = str.ToUpper();
            string lowerCase = str.ToLower();

            string substr1 = result.Substring(6);
            string substr2 = result.Substring(0, 5);

            string str3 = "apple, orange, banana";
            string[] fruits = substr1.Split(',');

            string replace = result.Replace("world", "universe");

            string trimmed = str.Trim();

            int firstIndex = result.IndexOf("o");
            int lastIndex = str.LastIndexOf("o");
        }

        public static void Demo()
        {
            string str = "";
            str += "Hello ";
            str += "World!";
            Console.WriteLine(str);

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.Append("World!");
            Console.WriteLine(sb.ToString());

            sb.Insert(5, " beautiful");
            Console.WriteLine();

            StringBuilder sb3 = new StringBuilder("Hello beautiful world!");
            sb3.Remove(6, 10);
            sb3.Replace("world", "universe");
        }

        public static void DemoDateTime()
        {
            //var today = DateTime.Now;

            DateTime specificDate = new DateTime(2024, 1, 22);
            DateTime specificDateTime = new DateTime(2023, 5, 15, 10, 30, 0);



            DateTime earlierData = new DateTime(2022, 1, 1);
            DateTime laterData = new DateTime(2022, 1, 10);
            TimeSpan diffirence = laterData.Subtract(earlierData);

            DateTime date = DateTime.Now;
            string formattedData = date.ToString();

            string dataString = "2024-01-22";
            DateTime parsedDate = DateTime.Parse(dataString);


            int absoluteValue = Math.Abs(-5);

            double squareRoot = Math.Sqrt(25);

            double power = Math.Pow(2, 3);

            int maxValue = Math.Max(20, 30);
            int minValue = Math.Min(20, 30);

            double piValue = Math.PI;
            double eValue = Math.E;

            double sineValue = Math.Sin(Math.PI / 2);
            double cosineValue = Math.Cos(0);

        }


    }

}
