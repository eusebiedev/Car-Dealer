using System.Collections.Generic;

namespace CarDealer.Models
{
  public class Car
  {
    public string CarType { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string carType)
    {
      CarType = carType;
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