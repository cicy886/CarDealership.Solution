using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;

      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}



// using System;

// namespace CarDealership.Models {

//   public class Car
//   {
//     private string _makeModel;
//     private int _price;
//     private int _miles;


//     public Car(string makeModel, int price, int miles)
//     {
//       _makeModel = makeModel;
//       _price = price;
//       _miles = miles;
//     }

//     public static string MakeSound(string sound)
//   {
//     return "Our cars sound like " + sound;
//   }

//     public string GetMakeModel()
//     {
//       return _makeModel;
//     }

//     public int GetPrice()
//     {
//       return _price;
//     }

//     public int GetMiles()
//     {
//       return _miles;
//     }

//     public bool WorthBuying(int maxPrice)
//     {
//       return (_price <= maxPrice);
//     }
//   }

// }