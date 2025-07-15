using AutoMapper;
using DevAcademyOnlineShop.Data;
using DevAcademyOnlineShop.Helpers;
using DevAcademyOnlineShop.Models;
using DevAcademyOnlineShop.View.Model.Models;
//using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static StackExchange.Redis.Role;

namespace DevAcademyOnlineShop.Controllers
{

    [ApiController]
    [Route("api/users")]
    public class UserController: ControllerBase    {
       
        private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
        private readonly IMapper _mapper;

        public UserController(IDbContextFactory<ApplicationDbContext> contextFactory, IMapper mapper)
        {
            _contextFactory = contextFactory;
            _mapper = mapper;
        }

        [HttpPost]        
        public ActionResult<Users> CreateUser([FromBody] Users user)
        {
            using (var context = _contextFactory.CreateDbContext())
            {
               var myuser = _mapper.Map<UserDto>(user);
               context.Add(myuser);
               return Ok(myuser);
             }
        }
    }
}
