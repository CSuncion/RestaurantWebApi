using Microsoft.EntityFrameworkCore;
using RestaurantWebApi.Model;
using RestaurantWebApi.Persistence;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Repository
{
    public class CartaRepository : ICartaRepository
    {
        private readonly DbRestaurantContext _context;
        public CartaRepository(DbRestaurantContext context)
        {
            _context = context;
        }
        public async Task<List<Carta>> ListaCartaPorCategoriaCartaYGrupoCartaActivas(int codCategoriaCarta, int codGrupoCarta)
        {
            return await _context.Carta.Where(x => x.EstadoCarta == true
            && x.CodCategoriaCarta == codCategoriaCarta
            && x.CodGrupoCarta == codGrupoCarta).ToListAsync();
        }
    }
}
