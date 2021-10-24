using Microsoft.AspNetCore.Mvc.Rendering;
using PackagesManagement.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackagesManagement.Queries
{
    public interface IDestinationListQuery : IQuery
    {
        Task<IEnumerable<SelectListItem>> AllDestinations();
    }
}