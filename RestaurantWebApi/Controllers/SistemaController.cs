using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebApi.Model.Dtos;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISistemaRepository _sistemaRepository;
        public SistemaController(IMapper mapper,
            ISistemaRepository sistemaRepository)
        {
            this._mapper = mapper;
            this._sistemaRepository = sistemaRepository;
        }
        [HttpGet("GetSistemasPorNroTabla/{nroTabla}")]
        public async Task<List<SistemaDto>> GetSistemasPorNroTabla(string nroTabla)
        {
            return _mapper.Map<List<SistemaDto>>(await _sistemaRepository.GetSistemasPorNroTabla(nroTabla));
        }
    }
}
