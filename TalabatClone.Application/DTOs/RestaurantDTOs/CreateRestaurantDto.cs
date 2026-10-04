

using System.ComponentModel.DataAnnotations;

namespace TalabatClone.Application.DTOs.RestaurantDTOs
{
    public sealed class CreateRestaurantDto
    {
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        public required string Name { get; set; }
        public required AddressDTO Address { get; set; }
    }
}
