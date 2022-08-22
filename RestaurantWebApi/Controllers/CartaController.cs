using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebApi.Model.Dtos;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICartaRepository _cartaRepository;
        public CartaController(IMapper mapper,
            ICartaRepository cartaRepository)
        {
            this._mapper = mapper;
            this._cartaRepository = cartaRepository;
        }
        [HttpGet("GetCarta/{codCategoriaCarta}/{codGrupoCarta}")]
        public async Task<List<CartaDto>> GetCarta(int codCategoriaCarta, int codGrupoCarta)
        {
            return _mapper.Map<List<CartaDto>>(await _cartaRepository.ListaCartaPorCategoriaCartaYGrupoCartaActivas(codCategoriaCarta, codGrupoCarta));
        }
    }
}
