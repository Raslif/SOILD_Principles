using System;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Single Responsibility Principle");
            //new Customer().Register();
            Console.WriteLine("Single Responsibility Principle");
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());
            Console.ReadLine();

        }
    }

    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
