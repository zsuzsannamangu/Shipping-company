using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Shipping.Models;

namespace Shipping.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpGet("/parcels/invalid")]
    public ActionResult Invalid()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult CalculatePrice(string height, string width, string depth, string weight)
    {
      int i = 0;
      if(int.TryParse(height, out i) && int.TryParse(width, out i) && int.TryParse(depth, out i) && int.TryParse(weight, out i))
      {
        Parcel newParcel = new Parcel(height, width, depth, weight);
        return View(newParcel);
      }
      else
      {
        return RedirectToAction("Invalid");
      }
    }

  }
}
