using AutoMapper;
using magicVilla.Web.DTOs.Readable;
using magicVilla.Web.DTOs.Writable;

namespace magicVilla.Web
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
           

            CreateMap<VillaDTO, VillaCreateDTOW>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTOW>().ReverseMap();

           
            CreateMap<VillaNumberDTO, VillaNumberCreateDTOW>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTOW>().ReverseMap();
        }
    }
}
