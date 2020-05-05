using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EntitiesLibrary.DTO;
using EntitiesLibrary.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AngularApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {
        readonly IRegisterDetails _registerDetails;

        private readonly ILogger<RegisterController> _logger;

        public RegisterController(ILogger<RegisterController> logger, IRegisterDetails registerDetails)
        {
            _logger = logger;
            _registerDetails = registerDetails;

        }
        [HttpPost("SaveRegistrationDetails")]
        public void SaveRegistrationDetails([FromBody]DTORegisterDetails obj)
        {
            var i = _registerDetails.SaveRegisterDetails( obj);
        }
        

    }
}
