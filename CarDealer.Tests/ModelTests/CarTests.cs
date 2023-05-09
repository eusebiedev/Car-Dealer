using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarDealer.Models;
using System;

namespace CarDealer.Tests
{
  [TestClass]
  public class CarDealerTests : IDisposable
  {
    public void Dispose()
    {
      CarDealer.ClearAll();
    }
  }
}