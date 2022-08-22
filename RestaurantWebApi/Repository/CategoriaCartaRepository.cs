using Microsoft.EntityFrameworkCore;
using RestaurantWebApi.Model;
using RestaurantWebApi.Persistence;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Repository
{
    public class CategoriaCartaRepository : ICategoriaCartaRepository
    {
        private readonly DbRestaurantContext _context;
        public CategoriaCartaRepository(DbRestaurantContext context)
        {
            _context = context;
        }
        public async Task<List<CategoriaCarta>> ListaCategoriaCartaPorSupeCategoriaCartaActivas(int codSuperCategoriaCarta)
        {
            return await _context.CategoriaCarta.Where(x => x.CodSuperCategoriaCarta == codSuperCategoriaCarta).ToListAsync();
        }
    }
}
