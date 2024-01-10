using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSwitchCase
{
    internal class Service
    {
        // ham nhan vao 1 so va tra ra message tuong ung
        // 
        public string GetMessage (int statusCode) 
        {
            string message = string.Empty;
            switch (statusCode)
            {
                case 200:
                    message = "Ok";
                    break;
                case 404:
                    message = "Notfound";
                    break;
                case 400:
                    message = "Badrequest";
                    break;
                case 500:
                    message = "Server error";
                    break;
                default:
                    message = "Status Code is not in system";
                    break;
            }
            return message;
        }
        // viet ham nhap vao 1 thang va nam kiemtra nam nhuan  tra ra thansg day co bao nhieu ngay ,mac dinh thang 2 co 28 ngay 
        public int GetDaysOfMonth(int month, int year )
        {
            int days = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 2:
                    if (CheckLunarYear(year))
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                default:
                    days = 0;
                    break;
            }
            return days;
        }
        public int GetDaysOfMonth1(int month, int year)
        {
            int daysInMonth = 0;
            switch (month)
            {
                case Month.January:
                case Month.March:
                case Month.May:
                case Month.July:
                case Month.August:
                case Month.October:
                case Month.December:
                    daysInMonth = 31;
                    break;
                case Month.April:
                case Month.June:
                case Month.September:
                case Month.November:
                    daysInMonth = 30;
                    break;
                case Month.February:
                    if (CheckLunarYear(year))
                    {
                        daysInMonth = 29;
                    }
                    else
                    {
                        daysInMonth = 28;
                    }
                    break;
                default:
                    Console.WriteLine("Tháng không hợp lệ.");
                    break;
            }
            return daysInMonth; ;
        }
        public bool CheckLunarYear(int year)
        {
            if ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            {
                return true;
            }
            return false;
        }
    }
}
