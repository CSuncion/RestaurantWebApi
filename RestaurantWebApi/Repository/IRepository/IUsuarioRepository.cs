using RestaurantWebApi.Model;

namespace RestaurantWebApi.Repository.IRepository
{
    public interface IUsuarioRepository
    {
        Task<Usuario> BuscarUsuarioXCodigo(string codigoUsuario);
    }
}
