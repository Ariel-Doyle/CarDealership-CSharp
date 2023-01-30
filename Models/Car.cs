using System;

namespace Dealership.Models
{
    public static void Sale()
    {     
      Price = forEach(Models in Cars)
    }
  public class Car
  {


    public string MakeModel {get; set;}
    public static int Price {get; set;}
    public int Miles {get; set;}

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}