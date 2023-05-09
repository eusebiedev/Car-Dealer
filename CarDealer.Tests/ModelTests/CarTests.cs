using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarDealer.Models;
using System;

namespace CarDealer.Tests
{
  [TestClass]
  public class CarTests
  {
    // public void Dispose()
    // {
    //   CarDealer.ClearAll();
    // }

    [TestMethod]
    public void CarConstructor_CreatesInstanceOfCar_Car()
    {
      Car newCar = new Car("Corolla");
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }

    [TestMethod]
    public void GetCarType_ReturnsCarType_String()
    {
      //Arrange
      string carType = "Corolla";
      //Act
      Car newCar = new Car(carType);
      string result = newCar.CarType;
      //Assert
      Assert.AreEqual(carType, result);
    }
  }
}