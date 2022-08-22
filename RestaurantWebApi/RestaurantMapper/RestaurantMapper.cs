using AutoMapper;
using RestaurantWebApi.Model.Dtos;
using RestaurantWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApi.RestaurantMapper
{
    public class RestaurantMapper : Profile
    {
        public RestaurantMapper()
        {
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Mesa, MesaDto>().ReverseMap();
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Sistema, SistemaDto>().ReverseMap();
            CreateMap<Carta, CartaDto>().ReverseMap();
            CreateMap<CategoriaCarta, CategoriaCartaDto>().ReverseMap();
            CreateMap<SuperCategoriaCarta, SuperCategoriaCartaDto>().ReverseMap();
            CreateMap<GrupoCarta, GrupoCartaDto>().ReverseMap();
        }
    }
}
