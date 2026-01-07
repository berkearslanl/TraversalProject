using AutoMapper;
using DTOLayer.Dtos.AppUserDtos;
using DTOLayer.Dtos.DuyurularDtos;
using DTOLayer.Dtos.iletisimDtos;
using DTOLayer.Dtos.RotalarDtos;
using DTOLayer.Dtos.SehirDtos;
using EntityLayer.Concrete;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<DuyurularAddDto, Duyurular>();
            CreateMap<Duyurular, DuyurularAddDto>();

            //CreateMap<SehirAddDto, Sehir>();
            //CreateMap<Sehir, SehirAddDto>();

            CreateMap<AppUserRegisterDto, AppUser>();
            CreateMap<AppUser, AppUserRegisterDto>();

            CreateMap<AppUserLoginDto, AppUser>();
            CreateMap<AppUser, AppUserLoginDto>();

            CreateMap<RotalarAddDto, VarisNoktalari>();
            CreateMap<VarisNoktalari, RotalarAddDto>();

            CreateMap<DuyurularListDto, Duyurular>();
            CreateMap<Duyurular, DuyurularListDto>();

            CreateMap<DuyurularUpdateDto, Duyurular>();
            CreateMap<Duyurular, DuyurularUpdateDto>();

            CreateMap<iletisimAddDto, BizeUlasin>().ReverseMap();
        }
    }
}
