using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str2;
            string str = "Hello,guys!";
            str2 = str.Remove(5);
            Console.WriteLine(str2.Insert (5, "..."));

            Console.ReadKey();
        }
    }
}
