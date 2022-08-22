using RestaurantWebApi.Model;

namespace RestaurantWebApi.Repository.IRepository
{
    public interface IProductoRepository
    {
        Task<List<Producto>> ListaProductosActivas();
    }
}
