using RestaurantWebApi.Model;

namespace RestaurantWebApi.Repository.IRepository
{
    public interface ISuperCategoriaCartaRepository
    {
        Task<List<SuperCategoriaCarta>> ListaSuperCategoriaCarta();
    }
}
