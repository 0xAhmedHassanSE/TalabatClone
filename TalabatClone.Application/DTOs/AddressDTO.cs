
using System.ComponentModel.DataAnnotations;

namespace TalabatClone.Application.DTOs
{
    public class AddressDTO
    {
        [MaxLength(100)]
        public required string Country { get; set; }
        [MaxLength(100)]
        public required string City { get; set; }
        [MaxLength(100)]
        public required string Street { get; set; }
        [MaxLength(20)]
        public required string ZipCode { get; set; }
    }
}
