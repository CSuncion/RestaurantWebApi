using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebApi.Model.Dtos;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperCategoriaCartaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISuperCategoriaCartaRepository _superCategoriaCartaRepository;
        public SuperCategoriaCartaController(IMapper mapper,
            ISuperCategoriaCartaRepository superCategoriaCartaRepository)
        {
            this._mapper = mapper;
            this._superCategoriaCartaRepository = superCategoriaCartaRepository;
        }
        [HttpGet("GetSuperCategoriaCarta")]
        public async Task<List<SuperCategoriaCartaDto>> GetSuperCategoriaCarta()
        {
            return _mapper.Map<List<SuperCategoriaCartaDto>>(await _superCategoriaCartaRepository.ListaSuperCategoriaCarta());
        }
    }
}
