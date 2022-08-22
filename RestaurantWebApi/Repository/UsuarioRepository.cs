using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RestaurantWebApi.Model;
using RestaurantWebApi.Persistence;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DbRestaurantContext _context;
        public UsuarioRepository(DbRestaurantContext context)
        {
            _context = context;
        }
        public async Task<Usuario> BuscarUsuarioXCodigo(string codigoUsuario)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(c => c.CodigoUsuario == codigoUsuario);
        }

    }
}
