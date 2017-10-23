using System;
using System.Collections.Generic;

namespace Random_Number_Csharp
{
    class Program
    {   
        static List<string> cars = new List<string>{"ford", "toyota", "mitisubish", "mazda"};
        static void Main(string[] args)
        {
            //var rand = new Random();
            Console.WriteLine(DisplayCars());
            Console.WriteLine(DisplayCars());
            Console.WriteLine(DisplayCars());
            Console.WriteLine(DisplayCars());
        }
        static int GenerateRandomNumber(List<string> myList)
        {
            var rand = new Random();
            return rand.Next(1, cars.Count);
        }
        static string DisplayCars() 
        {
            var selectedCar = cars[GenerateRandomNumber(cars)];
            return $"Selected car = {selectedCar}";
        }
    }
}
