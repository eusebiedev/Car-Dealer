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
      Car newCar = new Car("Corolla", 0);
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }

    [TestMethod]
    public void GetCarType_ReturnsCarType_String()
    {
      //Arrange
      string carType = "Corolla";
      //Act
      Car newCar = new Car(carType, 0);
      string result = newCar.CarType;
      //Assert
      Assert.AreEqual(carType, result);
    }

    [TestMethod]
    public void SetCarType_SetsCarType_String()
    {
      //Arrange
      string carType = "Corolla";
      Car newCar = new Car(carType, 0);
      //Act
      string updatedCarType = "Corolla LE";
      newCar.CarType = updatedCarType;
      string result = newCar.CarType;
      //Assert
      Assert.AreEqual(updatedCarType, result);
    }

    [TestMethod]
    public void GetCarPrice_ReturnsCarPrice_Int()
    {
      //Arrange
      int price = 0;
      //Act
      Car newCar = new Car("corolla", price);
      int result = newCar.Price;
      //Assert
      Assert.AreEqual(price, result);
    }
  }
}