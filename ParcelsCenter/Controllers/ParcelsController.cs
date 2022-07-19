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
    public ActionResult Create(double width, double height, double length, double weight)
    {
      Parcel myParcel = new Parcel(width, height, length, weight);
      return RedirectToAction("Index");
    }
  }
}