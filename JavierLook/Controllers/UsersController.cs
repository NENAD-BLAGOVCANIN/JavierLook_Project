using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace JavierLook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumbers()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            return Ok(numbers);
        }
    }
}
