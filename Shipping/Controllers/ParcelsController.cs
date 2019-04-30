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

    [HttpGet("/parcels")]
    public ActionResult CalculatePrice()
    {
      return View();
    }
  }
}
