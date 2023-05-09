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
      Car newCar = new Car("Corolla", 0, 0);
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }

    [TestMethod]
    public void GetCarType_ReturnsCarType_String()
    {
      //Arrange
      string carType = "Corolla";
      //Act
      Car newCar = new Car(carType, 0, 0);
      string result = newCar.CarType;
      //Assert
      Assert.AreEqual(carType, result);
    }

    [TestMethod]
    public void SetCarType_SetsCarType_String()
    {
      //Arrange
      string carType = "Corolla";
      Car newCar = new Car(carType, 0, 0);
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
      Car newCar = new Car("corolla", price, 0);
      int result = newCar.Price;
      //Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetCarPrice_SetsCarPrice_Int()
    {
      //Arrange
      int price = 0;
      Car newCar = new Car("corolla", price, 0);
      //Act
      int updatedCarPrice = 10;
      newCar.Price = updatedCarPrice;
      int result = newCar.Price;
      //Assert
      Assert.AreEqual(updatedCarPrice, result);
    }


    [TestMethod]
    public void GetCarMiles_ReturnsCarMiles_Int()
    {
      //Arrange
      int miles = 0;
      //Act
      Car newCar = new Car("corolla", 10, miles);
      int result = newCar.Miles;
      //Assert
      Assert.AreEqual(miles, result);
    }

    [TestMethod]
    public void SetCarMiles_SetsCarMiles_Int()
    {
      //Arrange
      int miles = 0;
      Car newCar = new Car("corolla", 10, miles);
      //Act
      int updatedCarMiles = 15;
      newCar.Miles = updatedCarMiles;
      int result = newCar.Miles;
      //Assert
      Assert.AreEqual(updatedCarMiles, result);
    }
  }
}