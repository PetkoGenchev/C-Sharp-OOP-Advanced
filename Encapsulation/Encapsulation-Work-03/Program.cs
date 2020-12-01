using System;

namespace Encapsulation_Work_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Topping topping = new Topping("meat", 500);
            Console.WriteLine(topping.CalculateToppingCalories());


        }
    }
}
