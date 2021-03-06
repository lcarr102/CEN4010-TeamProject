using System.Collections.Generic;
using AspNetCoreDemoApp.Models;
using AspNetCoreDemoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDemoApp.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// GET endpoint to retrieve a single user.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>The user with the corresponding ID.</returns>
        [HttpGet("{userId}")]
        public ActionResult<User> Get(string userId)
        {
            User user = userService.FindById(userId);
            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPut("{userId}")]
        public ActionResult Put(string userId, [FromBody]User userData)
        {
            User user = userService.FindById(userId);
            if (user == null)
            {
                userService.Create(userId, userData);
            }
            else
            {
                userService.Update(userId, userData);
            }

            return Ok();
        }
    }
}
