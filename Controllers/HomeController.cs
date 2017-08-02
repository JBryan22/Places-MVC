using Microsoft.AspNetCore.Mvc;
using PlacePage.Models;
using System.Collections.Generic;
using System;

namespace PlacePage.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/PlaceList")]
    public ActionResult PlaceList()
    {
      return View(Place.GetAllPlaces());
    }

    [HttpGet("/Place/{id}")]
    public ActionResult PlaceDetail(int id)
    {
      return View(Place.Find(id));
    }

    [HttpPost("/Place")]
    public ActionResult PlaceCreate()
    {
      string city = (Request.Form["city"]);
      Place newPlace = new Place(city);

      return View(newPlace);
    }

    [HttpPost("/PlaceList/remove/{id}")]
    public ActionResult Remove(int id)
    {
      Place.GetAllPlaces().RemoveAt(id - 1);

      return View(Place.GetAllPlaces());
    }

  }
}
