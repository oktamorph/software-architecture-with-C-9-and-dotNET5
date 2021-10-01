using Microsoft.AspNetCore.Mvc;
using PackagesManagement.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagesManagement.Controllers
{
    public class ManagePackageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index([FromServices] IPackageListQuery query)
        {
            var result = await query.GetAllPackages();
            var vm = new PackagesListViewModel { Items = result };
            return View(vm);
        }
    }
}
