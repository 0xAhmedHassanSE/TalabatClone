using System;
using System.Collections.Generic;
using System.Text;

namespace TalabatClone.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public virtual User User { get; set; } = null!;
        public string UserId { get; set; } = null!;

    }
}
