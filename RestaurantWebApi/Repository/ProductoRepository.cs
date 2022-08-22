using Microsoft.EntityFrameworkCore;
using RestaurantWebApi.Model;
using RestaurantWebApi.Persistence;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly DbRestaurantContext _context;
        public ProductoRepository(DbRestaurantContext context)
        {
            _context = context;
        }
        public async Task<List<Producto>> ListaProductosActivas()
        {
            return await _context.Productos.Where(x => x.Estpro == "1").ToListAsync();
        }
    }
}
