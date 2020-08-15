using FreePortSoccer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreePortSoccer.Services
{
    public interface IPlayerService
    {
        Task<Player> FindAsync(long id);
        IQueryable<Player> GetAll(int? count = null, int? page = null);
        Task<Player[]> GetAllAsync(int? count = null, int? page = null);
    }
}
