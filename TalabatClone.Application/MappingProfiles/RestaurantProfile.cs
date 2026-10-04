

using AutoMapper;
using TalabatClone.Application.DTOs;
using TalabatClone.Application.DTOs.RestaurantDTOs;
using TalabatClone.Domain.Entities;

namespace TalabatClone.Application.MappingProfiles
{
    public class RestaurantProfile : Profile
    {
        public RestaurantProfile()
        {
            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<CreateRestaurantDto, Restaurant>();
            CreateMap<Restaurant, RestaurantResponseDto>();
        }
    }
}
