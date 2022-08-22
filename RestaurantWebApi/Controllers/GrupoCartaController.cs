using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebApi.Model.Dtos;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoCartaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IGrupoCartaRepository _grupoCartaRepository;
        public GrupoCartaController(IMapper mapper,
            IGrupoCartaRepository grupoCartaRepository)
        {
            this._mapper = mapper;
            this._grupoCartaRepository = grupoCartaRepository;
        }
        [HttpGet("GetGrupoCarta/{codCategoriaCarta}")]
        public async Task<List<GrupoCartaDto>> GetGrupoCarta(int codCategoriaCarta)
        {
            return _mapper.Map<List<GrupoCartaDto>>(await _grupoCartaRepository.ListaGrupoCartaPorCategoriaCartaActivas(codCategoriaCarta));
        }
    }
}
