using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CobbleStoneAPI.Controllers
{
    [Route("/")]
    [ApiController]
    public class RootController : ControllerBase //building a controller ment for an API
    {
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            var response = new
            {
                href = Url.Link(nameof(GetRoot), null)//route name is GetRoot and null route parameters
            };
            return Ok(response);
        }

    }//end class
}//end namespace