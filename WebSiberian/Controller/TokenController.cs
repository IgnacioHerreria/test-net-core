using Microsoft.AspNetCore.Mvc;
using System;
using WebSiberian.Token.Seguridad;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSiberian.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ISecurityToken _securityToken;
        public TokenController(ISecurityToken securityToken)
        {
            _securityToken = securityToken;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_securityToken.CrearToken(Guid.NewGuid().ToString()));
        }

     
    }
}
