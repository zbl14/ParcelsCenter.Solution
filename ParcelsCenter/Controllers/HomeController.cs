using Microsoft.AspNetCore.Mvc;

namespace ParcelsCenter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}