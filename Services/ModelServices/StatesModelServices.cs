using System.Collections.Generic;
using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class StatesModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;

        public StatesModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public List<States> findAll()
        {
            var context = this._context;
            var query = from st in context.Set<States>()
                        select st;
            return query.ToList();
        }

        public States findByKeyword(string Keyword)
        {
            var context = this._context;
            var query = from st in context.Set<States>()
                        where st.Keyword == Keyword
                        select st;
            return query.Single();
        }
    }
}
