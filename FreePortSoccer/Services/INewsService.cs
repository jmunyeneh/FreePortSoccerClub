using FreePortSoccer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreePortSoccer.Services
{
    public interface INewsService
    {
        Task<News> FindAsync(long id);
        IQueryable<News> GetAll(int? count = null, int? page = null);
        Task<News[]> GetAllAsync(int? count = null, int? page = null);
    }
}
