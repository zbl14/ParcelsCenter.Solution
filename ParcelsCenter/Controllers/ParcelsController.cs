using Microsoft.AspNetCore.Mvc;
using ParcelsCenter.Models;
using System.Collections.Generic;

namespace ParcelsCenter.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(double length, double width, double height, double weight)
    {
      Parcel myParcel = new Parcel(length, width, height, weight);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Parcel.ClearAll();
      return RedirectToAction("Index");
    }
  }
}