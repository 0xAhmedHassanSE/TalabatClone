
using TalabatClone.Domain.Entities;
using TalabatClone.Domain.Enums;

namespace TalabatClone.Application.DTOs.RestaurantDTOs
{
    public sealed class RestaurantResponseDto()
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AddressDTO Address { get; set; } 
        public string Status { get; set; } 

    }
}
