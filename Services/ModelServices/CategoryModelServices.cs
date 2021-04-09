using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class CategoryModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;
        public CategoryModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public List<Category> findAll()
        {
             var context = this._context;

            var query = from br in context.Set<Category>()
                        select br;
            return query.ToList();
        }
    }
}