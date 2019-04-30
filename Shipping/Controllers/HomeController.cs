using Microsoft.AspNetCore.Mvc;

namespace Shipping.Controllers
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
