using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFunction
{
    internal class Service
    {
        public double sum(double number1, double number2 )
        {
            double sum = number1 + number2;
            return sum;
        }
        // dien tich hinh chu nhat
        public double CalRecArea(double length, double width)
        {
            double area = length * width;
            
            return area;
        }
        // dien tich hinh tron
        public double CaAreaCircle(double banKinh)
        {
            double area = banKinh*banKinh*3.14;
            return area;

        }
        // sao chep gia tri sang mot bo nho khac
        public void CalAreaCircle1(double banKinh, ref double area)
        {
            area = banKinh * banKinh * 3.14;
        }

        public void CalAreaCircle2(double banKinh, double area)
        {
            area = banKinh * banKinh * 3.14;
        }
        // out ra gia tri ma ko can viet lai ham
        public double CalRecArea1(double length, double width, out double perimeter)
        {
            double area = length * width;
            perimeter = (length + width) * 2;
            return area;
        }
    }
}
