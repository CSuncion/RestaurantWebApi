using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestaurantWebApi.Model.Dtos;
using RestaurantWebApi.Repository.IRepository;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductoRepository _productoRepository;
        public ProductoController(IMapper mapper,
            IProductoRepository productoRepository)
        {
            this._mapper = mapper;
            this._productoRepository = productoRepository;
        }
        [HttpGet("GetProductos")]
        public async Task<List<ProductoDto>> GetProductos()
        {
            return _mapper.Map<List<ProductoDto>>(await _productoRepository.ListaProductosActivas());
        }
    }
}
