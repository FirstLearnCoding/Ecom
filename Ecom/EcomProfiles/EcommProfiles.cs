using AutoMapper;
using Ecom.Dtos;
using Ecom.Ppty;
namespace Ecom.EcomProfiles
{
    public class EcommProfiles : Profile
    {
        public EcommProfiles()
        {
            CreateMap<Ecomm, EcomReadDtos>();
            CreateMap<Profiles, ProfilesReadDto>();
            CreateMap<ProfileCreateDtos, Profiles>();
            CreateMap<ProfileUpdateDtos, Profiles>();
            CreateMap<ProductPurchase, PurchaseReadDtos>();
        }
    }
}