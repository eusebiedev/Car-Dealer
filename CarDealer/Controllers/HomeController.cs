using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;
using System.Collections.Generic;

namespace CarDealer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CarForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string carType, int price, int miles)
    {
      Car myCar = new Car(carType, price, miles);
      return RedirectToAction("Index");
    }
    
  }
}