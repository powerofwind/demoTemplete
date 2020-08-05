using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new logic();
            var result = a.add(10,2);
            Console.WriteLine($"{result}");
        }
    }
}
