using Microsoft.AspNetCore.Mvc;
using DevAcademyOnlineShop.Models;

namespace DevAcademyOnlineShop.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController    {
        [HttpPost]
        
        public IActionResult CreateUser([FromBody] Users user)
        {


            return Ok();
        }
    }
}
