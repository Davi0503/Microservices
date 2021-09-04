using Authorization.Api.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login()
        {
            var result = _loginService.GenerateToken();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Teste()
        {
            return Ok("Deu bom");
        }

    }
}
