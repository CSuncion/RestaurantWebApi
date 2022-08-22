using RestaurantWebApi.Model;

namespace RestaurantWebApi.Repository.IRepository
{
    public interface ISistemaRepository
    {
        Task<List<Sistema>> GetSistemasPorNroTabla(string nroTabla);
    }
}
