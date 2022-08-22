using RestaurantWebApi.Model;

namespace RestaurantWebApi.Repository.IRepository
{
    public interface IMesaRepository
    {
        Task<List<Mesa>> ListarMesasActivas();
        Task<List<Mesa>> ListarMesasActivasPorTipo(string tipo);
    }
}
