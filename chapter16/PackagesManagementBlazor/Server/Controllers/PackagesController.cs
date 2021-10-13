using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackagesManagementBlazor.Server.Queries;
using PackagesManagementBlazor.Shared;

namespace PackagesManagementBlazor.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        // GET api/<PackagesController>/flor
        [HttpGet("{location}")]
        public async Task<PackagesListViewModel> Get(string location, [FromServices] IPackagesListByLocationQuery query)
        {
            return new PackagesListViewModel
            {
                Items = await query.GetPackagesOf(location)
            };
        }
    }
}
