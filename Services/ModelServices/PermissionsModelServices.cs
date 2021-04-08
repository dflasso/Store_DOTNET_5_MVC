using G10COMERCIALIZADORA_DOTNET.Models;
using G10COMERCIALIZADORA_DOTNET.Repositories;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace G10COMERCIALIZADORA_DOTNET.Services
{
    public class PermissionsModelServices
    {
        private CoreContext _context;
        private readonly ILogger _logger;

        public PermissionsModelServices(CoreContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        public Permissions findById(int PermissionsId)
        {
            var context = this._context;

            var query = from pr in context.Set<Permissions>()
                        where pr.PermissionsId == PermissionsId
                        select pr;

            return query.Single();
        }

        public List<Permissions> findAll()
        {
            var context = this._context;

            var query = from pr in context.Set<Permissions>()
                        select pr;

            return query.ToList();
        }

        public Boolean savePermisson(Permissions permissions)
        {
            Boolean updateSuccess = false;
            try
            {
                _context.permissions.Update(permissions);
                updateSuccess = true;
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError("[NOT SAVE PERMISSON] name: " + permissions.NameMenu + "\nExceprtion:\n" + ex.Message
                + "\n" + ex.StackTrace);
            }
            return updateSuccess;
        }

        public List<Permissions> findByIds(string[] ids)
        {
            if(ids != null)
            {
                 int[] idsNumbers = new int[ids.Length];

                for (int i = 0; i < ids.Length; i++)
                {
                    try
                    {
                        idsNumbers[i] = Int32.Parse(ids[i]);
                    }
                    catch (ArgumentNullException ex)
                    {
                        _logger.LogError(ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        _logger.LogError(ex.Message);
                    }
                    catch (OverflowException ex)
                    {
                        _logger.LogError(ex.Message);
                    }
                }

                return this.findByIds(idsNumbers);
            }
            else
            {
                return new List<Permissions>();
            }           

        }

        public List<Permissions> findByIds(int[] ids)
        {
            var context = this._context;

            var query = from pr in context.Set<Permissions>()
                        .Where(p => ids.Contains(p.PermissionsId))
                        select pr;

            return query.ToList();
        }
    }

}
