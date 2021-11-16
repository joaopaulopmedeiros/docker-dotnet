using System;
using webapi.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Controllers
{
    public class HeroService : IService
    {
        private readonly IHeroRepository _repository;

        public HeroService(IHeroRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Hero>> GetAsync()
        {
            var result = await _repository.GetAsync();
            return result;
        }
    }
}
