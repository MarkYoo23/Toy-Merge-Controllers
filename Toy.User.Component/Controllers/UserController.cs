using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Toy.User.Component.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        [HttpGet("user-name-collection")]
        public IEnumerable<string> GetUserNames()
        {
            return new string[] { "test1", "test2" };
        }
    }
}
