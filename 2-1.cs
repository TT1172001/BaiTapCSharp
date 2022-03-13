using System;

namespace Bai1Phan2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double S, C;
            C = a + b + c ;
            if (a+b>c&&b+c>a&&a+c>b){
            Console.WriteLine("Chu vi la: " + C);
            S = Math.Sqrt(C/2 * (C/2 - a) * (C/2 - b) * (C/2 - c));
            Console.WriteLine("Dien tich la: " + S);
            }
            else {
            Console.WriteLine("Kich thuoc tam giac khong phu hop");
            }
            
        }
    }
}