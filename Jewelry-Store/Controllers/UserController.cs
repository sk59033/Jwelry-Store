using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jewelry_Store.IServices;
using Jewelry_Store.Models;
using System.Net.Mime;
using Microsoft.AspNetCore.Authorization;

namespace Jewelry_Store.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
      
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet("GetAllUser")]
        public IActionResult GetAllUser()
        {
            var users= _userService.GetAll();
            if (!users.Any())
            {
                return NotFound("No Records found");
            }
            return Ok(users);
        }

        [HttpGet("GetUserById")]
        public IActionResult GetUserById(int Id)
        {
            var user = _userService.GetById(Id);
            if (user == null)
            {
                return NotFound("No Records found");
            }
            return Ok(user);
        }

        [Route("Login")]
        [AllowAnonymous]
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        public ActionResult Login([FromBody] UserViewModel model)
        {
            var user = _userService.GetUser(model.Username, model.Password);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            return Ok(user);
        }

        [HttpPost("CreateUser")]
        [AllowAnonymous]
        public IActionResult CreateUser(Users model)
        {
            _userService.Register(model);
            return Ok();
        }

        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser(Users model)
        {
            _userService.UpdateUser(model);
            return Ok();
        }
        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int Id)
        {
            _userService.DeleteUser(Id);
            return Ok();
        }
    }
}
