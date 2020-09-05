using FreePortSoccer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreePortSoccer.Services
{
    public class NewsService : INewsService
    {
        private readonly SoccerContext _db;

        public NewsService(SoccerContext db)
        {
            this._db = db;
        }
        public Task<News> FindAsync(long id)
        {
            return _db.News.FirstOrDefaultAsync(x => x.Id == id);
        }

        public IQueryable<News> GetAll(int? count = null, int? page = null)
        {
            var actualCount = count.GetValueOrDefault(10);

            return _db.News
                    .OrderByDescending(x => x.InsertedDate)
                    .Skip(actualCount * page.GetValueOrDefault(0))                    
                    .Take(actualCount);
        }

        public Task<News[]> GetAllAsync(int? count = null, int? page = null)
        {
            return GetAll(count, page)               
                .ToArrayAsync();
        }

        public int GetRecordCount()
        {
            var count = _db.News.Count();
            return count;
        }
    }
}
