using Microsoft.AspNetCore.Mvc;

namespace Toverland_API_V2.Controllers;

[ApiController]
[Route("")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public ActionResult Hello() {
        return Ok("Hello World!");
    }
}