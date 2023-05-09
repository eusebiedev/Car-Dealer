using System.Collections.Generic;

namespace CarDealer.Models
{
  public class Car
  {
    public string CarType { get; set; }
    public int Price { get; set; }
    // public int Miles { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string carType, int price)
    {
      CarType = carType;
      Price = price;
      // Miles = miles;
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