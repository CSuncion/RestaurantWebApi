using RestaurantWebApi.Model;

namespace RestaurantWebApi.Repository.IRepository
{
    public interface ICategoriaCartaRepository
    {
        Task<List<CategoriaCarta>> ListaCategoriaCartaPorSupeCategoriaCartaActivas(int codSuperCategoriaCarta);
    }
}
