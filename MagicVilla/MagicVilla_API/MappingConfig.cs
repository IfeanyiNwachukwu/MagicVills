using AutoMapper;
using MagicVilla_API.DTOs.Readable;
using MagicVilla_API.DTOs.Writable;
using MagicVilla_API.Models;

namespace MagicVilla_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa,VillaCreateDTOW>().ReverseMap();
            CreateMap<Villa, VillaCreateDTOW>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberCreateDTOW>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTOW>().ReverseMap();
        }
    }
}
