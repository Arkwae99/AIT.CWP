using CWP.IdentityAuth;
using CWP.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CWP.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorld : ControllerBase
    {
        private readonly ILogger<HelloWorld> _logger;
        private readonly UserManager<ApplicationUser> _userManager;

        public HelloWorld(ILogger<HelloWorld> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        [HttpGet(Name = "GetHelloWorld")]
        public string Get()
        {
            return "Hello " + _userManager.GetUserName(User).ToString();
        }

    }
}
