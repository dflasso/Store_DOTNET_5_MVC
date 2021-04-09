using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class ProductsModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;

        public ProductsModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public List<Product> findAll()
        {
            var context = this._context;

            var query = from pr in context.Set<Product>()
                        select pr;
            return query.ToList();
        }
    }
}