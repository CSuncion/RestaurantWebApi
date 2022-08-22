using RestaurantWebApi.Model;

namespace RestaurantWebApi.Repository.IRepository
{
    public interface IGrupoCartaRepository
    {
        Task<List<GrupoCarta>> ListaGrupoCartaPorCategoriaCartaActivas(int codCategoriaCarta);
    }
}
