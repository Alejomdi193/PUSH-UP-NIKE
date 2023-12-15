using AutoMapper;
using Api.Dtos;
using Dominio.Entities;

namespace Api.ProfileS
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Rol, RolDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Transaccion, TransaccionDto>().ReverseMap();
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
        }

 
    }
}