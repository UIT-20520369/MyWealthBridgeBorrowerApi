using Domain.AggregateModels.Borrowers;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using MyWealthBridgeBorrowerApi.DTOs.Users;
using BCrypt.Net;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Cors;
using MyWealthBridgeBorrowerApi.Services.BorrowerServices;
using MyWealthBridgeBorrowerApi.DTOs.ExternalLogins;
using System.Diagnostics.Eventing.Reader;

namespace MyWealthBridgeBorrowerApi.Controllers.Users
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    [EnableCors("AllowSpecificOrigin")]
    public class userController: ControllerBase
    {
        private readonly IBorrowerService _borrowerService;
        public userController(IBorrowerService borrowerService)
        {
           _borrowerService = borrowerService;
        }
        [HttpPost]
        public IActionResult register([FromBody] UserDTOcs userDto)
        {
           var result = _borrowerService.Register(userDto);
            if (result != null)
            { return Ok(result); }
            return BadRequest();
        }
        [HttpPost]
        public Borrower login([FromBody] UserDTOcs userDto)
        {
            var result = _borrowerService.Login(userDto);
            return result;
        }
        [HttpPost]
        public IActionResult externalLogin([FromBody] ExternalLoginInput input)
        {
            var result = _borrowerService.ExternalLogin(input);
            if (result != null) { return Ok(result); }
            return BadRequest();
        }
    }
   
}
