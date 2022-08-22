using Microsoft.EntityFrameworkCore;
using RestaurantWebApi.Model;
using RestaurantWebApi.Persistence;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Repository
{
    public class GrupoCartaRepository : IGrupoCartaRepository
    {
        private readonly DbRestaurantContext _context;
        public GrupoCartaRepository(DbRestaurantContext context)
        {
            _context = context;
        }
        public async Task<List<GrupoCarta>> ListaGrupoCartaPorCategoriaCartaActivas(int codCategoriaCarta)
        {
            return await _context.GrupoCarta.Where(x => x.CodCategoriaCarta == codCategoriaCarta).ToListAsync();
        }
    }
}
