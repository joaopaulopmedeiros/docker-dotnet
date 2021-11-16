using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Controllers
{
    public interface IService
    {
        Task<IEnumerable<Hero>> GetAsync();
    }
}
