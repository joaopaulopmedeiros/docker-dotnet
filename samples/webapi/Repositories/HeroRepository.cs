using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapi.Contexts;
using webapi.Models;

namespace webapi.Repositories
{
    public class HeroRepository : IHeroRepository
    {
        private readonly HeroContext _context;

        public HeroRepository(HeroContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Hero>> GetAsync()
        {
            return await _context.Heroes.ToListAsync();
        }
    }
}
