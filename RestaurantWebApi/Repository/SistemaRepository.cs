using Microsoft.EntityFrameworkCore;
using RestaurantWebApi.Model;
using RestaurantWebApi.Persistence;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Repository
{
    public class SistemaRepository : ISistemaRepository
    {
        private readonly DbRestaurantContext _context;
        public SistemaRepository(DbRestaurantContext context)
        {
            _context = context;
        }
        public async Task<List<Sistema>> GetSistemasPorNroTabla(string nroTabla)
        {
            return await _context.Sistemas.Where(x => x.Estreg != "0" && x.NroTab == nroTabla).ToListAsync();
        }
    }
}
