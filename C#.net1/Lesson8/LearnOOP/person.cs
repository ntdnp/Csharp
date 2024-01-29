using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LearnOOP
{
    public class Person
    {
        public Person() { }
        public Person(string name1,int age1,string address1)
        {
            name = name1;
            age = age1;
            address = address1;
        } 




        public string name;
        public int age;
        private string address;
        private readonly string template = "Studen name:{0},Studen Age:{1}";// co dinh ko thay doi dc (readonly)
        private double score;
        public double Score
        {
            get { return score; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new Exception("score is invalid");

                }
                else
                {
                    score = value * 2;

                }
            }

        }
        public double Score2 { get; set; } 
        public string Info
        
        {
            get
            {

                return $"name:{name},age:{age},address:{address},score:{score}";

            }
        }
        public string Info1 => $"name:{name},age:{age},address:{address},score:{score}";
        public void GetInfo() 
            
        {
            Console.WriteLine(string.Format(template,name,age));
            //Console.WriteLine($"Studen name:{name},studen age:{age}");
            Console.ReadKey();

        }
    }
    //tạo ra 1 class vehicle gồm các nội dung
    // property name (string)
    // property price (int) price >100 và price <10000
    // property info trả ra thông tin name và price
    public class Vehicle 
    {
        public string name;
        public int price;
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int Price
        {
            get { return price; }
            set
            {
                // Kiem tra dk  cho Price
                if (value > 100 && value < 10000)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("gia tri khong nam trong khoang 100 den 10000");
                }
            }
        }
        public string GetInfo()
        {
            return $"Ten: {name}, Gia: {price}";
        }

    }

}
