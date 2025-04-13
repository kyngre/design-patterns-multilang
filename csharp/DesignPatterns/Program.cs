// Program.cs
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Adapter Pattern =====");
            AdapterDemo.Run();

            Console.WriteLine("\n===== Decorator Pattern =====");
            DecoratorDemo.Run();

            Console.WriteLine("\n===== Facade Pattern =====");
            FacadeDemo.Run();

            Console.WriteLine("\n===== Factory Pattern =====");
            FactoryDemo.Run();

            Console.WriteLine("\n===== Builder Pattern =====");
            BuilderDemo.Run();
        }
    }
}