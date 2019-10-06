using System;

namespace implicitandexplicitconversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int f1 = 232;
            float f2 = f1;//implicit conversion
            Console.WriteLine(f2);
            int a1 = 12;
            byte b1 = (byte)a1;//Exciplcit conversion
            Console.WriteLine(b1);
            
        }
    }
}
