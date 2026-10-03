using System.ComponentModel.DataAnnotations;

namespace TalabatClone.Domain.Entities
{
    public class Address
    {
        [MaxLength(100)]
        public string Country { get; set; } = string.Empty;
        [MaxLength(100)]
        public string City { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Street { get; set; } = string.Empty;
        [MaxLength(20)]
        public string ZipCode { get; set; } = string.Empty;

    }
}
