


using System.ComponentModel.DataAnnotations;

namespace TalabatClone.Application.DTOs.RestaurantDTOs
{
    public class UpdateRestaurantDto
    {
        [StringLength(maximumLength:100,MinimumLength =5)]
        public required string Name { get; set; } = string.Empty;
        public required AddressDTO Address { get; set; } 
    }
}
