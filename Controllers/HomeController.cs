using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;
using System.Collections.Generic;
using System;

namespace Places.Controllers
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
      return View(Place.Find())
    }

    [HttpPost("/Place")]
    public ActionResult Place()
    {
      string city = [Request.Form("city")];
      Place newPlace = new Place(city);

      return View(newPlace)
    }

  }
}
