using System;

namespace Inheritance_Work_01
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Child child = new Child(name, age);
            Console.WriteLine(child);
        }

    }
}
