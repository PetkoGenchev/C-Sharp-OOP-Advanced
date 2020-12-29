using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Models;
using WildFarm.Models.Abstract;

namespace PolymorphismWork03
{
    class Program
    {
        static void Main()
        {

            string input;

            List<Animal> animals = new List<Animal>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalEntry = input.Split().ToArray();

                string animalType = animalEntry[0];
                string animalName = animalEntry[1];
                double animalWeight = double.Parse(animalEntry[2]);

                string[] foodEntry = Console.ReadLine().Split().ToArray();

                string foodType = foodEntry[0];
                int quantityOfFood = int.Parse(foodEntry[1]);

                Animal animal = null;

                if (animalType == "Hen")
                {
                    animal = new Hen(animalName, animalWeight, double.Parse(animalEntry[3]));
                }
                else if (animalType == "Owl")
                {
                    animal = new Owl(animalName, animalWeight, double.Parse(animalEntry[3]));
                }
                else if (animalType == "Mouse")
                {
                    animal = new Mouse(animalName, animalWeight, animalEntry[3]);
                }
                else if (animalType == "Cat")
                {
                    animal = new Cat(animalName, animalWeight, animalEntry[3], animalEntry[4]);
                }
                else if (animalType == "Dog")
                {
                    animal = new Dog(animalName, animalWeight, animalEntry[3]);
                }
                else if (animalType == "Tiger")
                {
                    animal = new Tiger(animalName, animalWeight, animalEntry[3], animalEntry[4]);
                }

                Console.WriteLine(animal.MakeSound());

                try
                {
                    animal.EatFood(foodType, quantityOfFood);
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }


                animals.Add(animal);

            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
