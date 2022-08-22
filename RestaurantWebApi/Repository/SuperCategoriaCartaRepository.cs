using Microsoft.EntityFrameworkCore;
using RestaurantWebApi.Model;
using RestaurantWebApi.Persistence;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Repository
{
    public class SuperCategoriaCartaRepository : ISuperCategoriaCartaRepository
    {
        private readonly DbRestaurantContext _context;
        public SuperCategoriaCartaRepository(DbRestaurantContext context)
        {
            _context = context;
        }
        public async Task<List<SuperCategoriaCarta>> ListaSuperCategoriaCarta()
        {
            return await _context.SuperCategoriaCarta.ToListAsync();
        }
    }
}
