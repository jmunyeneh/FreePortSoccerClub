using FreePortSoccer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreePortSoccer.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly SoccerContext _db;

        public PlayerService(SoccerContext db)
        {
            this._db = db;
        }
        public Task<Player> FindAsync(long id)
        {
            return  _db.Players.FirstOrDefaultAsync(x => x.PlayerId == id);
        }

        public IQueryable<Player> GetAll(int? count = null, int? page = null)
        {
            var actualCount = count.GetValueOrDefault(10);

            return _db.Players
                    .Skip(actualCount * page.GetValueOrDefault(0))
                    .Take(actualCount);
        }

        public Task<Player[]> GetAllAsync(int? count = null, int? page = null)
        {
            return GetAll(count, page).ToArrayAsync();
        }
    }
}
