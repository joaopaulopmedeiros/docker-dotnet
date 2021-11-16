using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Repositories
{
    public interface IHeroRepository
    {
        Task<IEnumerable<Hero>> GetAsync();
    }
}
