using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebApi.Model.Dtos;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesaController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMesaRepository _mesaRepository;
        public MesaController(IMapper mapper,
            IMesaRepository mesaRepository)
        {
            this._mapper = mapper;
            this._mesaRepository = mesaRepository;
        }
        [HttpGet("GetMesas")]
        public async Task<List<MesaDto>> GetMesas()
        {
            return _mapper.Map<List<MesaDto>>(await _mesaRepository.ListarMesasActivas());
        }
        [HttpGet("GetMesasPorTipo/{tipo}")]
        public async Task<List<MesaDto>> GetMesasPorTipo(string tipo)
        {
            return _mapper.Map<List<MesaDto>>(await _mesaRepository.ListarMesasActivasPorTipo(tipo));
        }
    }
}
