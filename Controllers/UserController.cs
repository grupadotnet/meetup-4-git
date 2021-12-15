using System;
using meet_up_3.ViewModels.User;
using meet_up_4_git.Models;
using meet_up_4_git.Services;
using meet_up_4_git.ViewModels.User;
using Microsoft.AspNetCore.Mvc;

namespace meet_up_4_git.Controllers
{
    [ApiController]
    [Route("api")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("user")]
        public IActionResult GetUser([FromQuery] Guid userId)
        {
            var user = _userService.GetUser(userId);

            return Ok(user);
        }
        
        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }


        [HttpPatch("user")]
        public IActionResult UpdateUser([FromBody] UpdateUserViewModel userViewModel)
        {
            try
            {
                _userService.UpdateUser(userViewModel);
            
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Couldn't update user");
            }
        }
        
        [HttpPost("user")]
        public IActionResult CreateUser([FromBody] CreateUserViewModel userViewModel)
        {
            _userService.AddUser(new User()
            {
                Id = Guid.NewGuid(),
                Email = userViewModel.Email,
                Password = userViewModel.Password,
                FirstName = userViewModel.FirstName,
                LastName = userViewModel.LastName
            });
            
            return Ok();
        }

        [HttpDelete("user")]
        public IActionResult DeleteUser([FromQuery] Guid id)
        {
            try
            {

                if (id == Guid.Empty)
                    return BadRequest();
            
                _userService.DeleteUser(id);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest("Couldn't delete user");
            }
        }
    }
}