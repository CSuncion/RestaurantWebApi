using RestaurantWebApi.Model;

namespace RestaurantWebApi.Repository.IRepository
{
    public interface ICartaRepository
    {
        Task<List<Carta>> ListaCartaPorCategoriaCartaYGrupoCartaActivas(int codCategoriaCarta, int codGrupoCarta);
    }
}
