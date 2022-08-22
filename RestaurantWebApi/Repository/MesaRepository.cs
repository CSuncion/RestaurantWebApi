using Microsoft.EntityFrameworkCore;
using RestaurantWebApi.Model;
using RestaurantWebApi.Persistence;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Repository
{
    public class MesaRepository : IMesaRepository
    {
        private readonly DbRestaurantContext _context;
        public MesaRepository(DbRestaurantContext context)
        {
            _context = context;
        }
        public async Task<List<Mesa>> ListarMesasActivas()
        {
            return await _context.Mesas.Where(x => x.EstadoMesa != false).ToListAsync();
        }
        public async Task<List<Mesa>> ListarMesasActivasPorTipo(string tipo)
        {
            return await _context.Mesas.Where(x => x.EstadoMesa != false && x.TipoMesa == tipo).ToListAsync();
        }
    }
}
