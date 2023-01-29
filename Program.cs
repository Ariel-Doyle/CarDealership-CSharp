using System;
using System.Collections.Generic;

namespace Dealership {
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagon Thing", 1100, 368792);

      Car yugo = new Car("1980 Yugo Koral", 700, 56000);

      Car ford = new Car("1988 Ford Country Squire", 1400, 239001);

      Car amc = new Car("1976 AMC Pacer", 400, 198000);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      Console.WriteLine("Enter maximum price:");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingBudget = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingBudget.Add(automobile);
        } else {
          Console.WriteLine("Ya ain't got the monies, friend.");
        }
      }

      foreach(Car automobile in CarsMatchingBudget)
      {
        Console.WriteLine(automobile.MakeModel);
      }
    }
  }
}