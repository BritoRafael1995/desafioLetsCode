using BACK.Business.Implementation;
using BACK.Business.Interface;
using BACK.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BACK.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserBusiness _usersBusiness;

        public LoginController()
        {
            _usersBusiness = new UserBusiness();
        }
        [HttpPost]
        public ActionResult Login([FromBody] User userInfo)
        {
                var result = _usersBusiness.Login(userInfo);
                return Ok(result.Token);
        }
    }
}
