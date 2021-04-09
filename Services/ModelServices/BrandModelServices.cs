using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class BrandModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;
        public BrandModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public List<Brand> findAll()
        {
            var context = this._context;

            var query = from br in context.Set<Brand>()
                        select br;
            return query.ToList();
        }
    }
}