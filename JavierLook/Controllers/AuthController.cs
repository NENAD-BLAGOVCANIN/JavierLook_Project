using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using JavierLook.Models;
using JavierLook.Data;
using System.Security.Cryptography;
using System.Text;

namespace JavierLook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _context;

        public AuthController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] UserRegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newUser = new User
            {
                Email = model.Email,
            };


            _context.users.Add(newUser);
            _context.SaveChanges();

            return Ok(newUser);
        }
    }
}
