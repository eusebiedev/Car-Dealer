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
      Car newCar = new Car();
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
  }
}