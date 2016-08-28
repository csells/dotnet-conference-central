using Microsoft.AspNetCore.Mvc;

namespace ConferenceCentral.Controllers {
  public class HomeController : Controller {
    public IActionResult Index() {
      return View();
    }

    public IActionResult Error() {
      return View();
    }
  }
}
