using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class CompanyModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;
        public CompanyModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public Company findFrist()
        {
             var context = this._context;

            var query = from br in context.Set<Company>()
                        select br;
            
            if(query.Count() > 0)
            {
                return query.Single();
            }
            return null;
        }
    }
}