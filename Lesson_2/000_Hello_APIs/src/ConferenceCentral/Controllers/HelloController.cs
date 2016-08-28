using Microsoft.AspNetCore.Mvc;

namespace ConferenceCentral.Controllers {
  [Route("api/[controller]")]
  public class HelloController : Controller {
    const string message = "Hello World";

    // GET api/hello
    [HttpGet]
    public string Get() {
      return message;
    }

    // GET api/hello/bob
    [HttpGet("{name}")]
    public string Get(string name) {
      return "Hello " + name + "!";
    }
  }
}
