using portfolio_Authentication.Models;
using portfolio_Authentication.Servies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio_Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticateServies _authenticateServies;
        public AuthenticationController(IAuthenticateServies authenticateServies)
        {
            _authenticateServies = authenticateServies;
        }
        [HttpGet]
        public ActionResult<string> Post(int Id, string Password)
        {
            string user = _authenticateServies.Authenticate(Id,Password);
            if(user == null)
            {
                return "failed";
            }
            else
            {
                return user; ;
            }
        }
    }
}
