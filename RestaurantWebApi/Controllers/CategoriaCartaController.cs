using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebApi.Model.Dtos;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaCartaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaCartaRepository _categoriaCartaRepository;
        public CategoriaCartaController(IMapper mapper,
            ICategoriaCartaRepository categoriaCartaRepository)
        {
            this._mapper = mapper;
            this._categoriaCartaRepository = categoriaCartaRepository;
        }
        [HttpGet("GetCategoriaCarta/{codSuperCategoriaCarta}")]
        public async Task<List<CategoriaCartaDto>> GetCategoriaCarta(int codSuperCategoriaCarta)
        {
            return _mapper.Map<List<CategoriaCartaDto>>(await _categoriaCartaRepository.ListaCategoriaCartaPorSupeCategoriaCartaActivas(codSuperCategoriaCarta));
        }
    }
}
