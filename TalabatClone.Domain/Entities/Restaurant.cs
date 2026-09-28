using System;
using System.Collections.Generic;
using System.Text;
using TalabatClone.Domain.Enums;

namespace TalabatClone.Domain.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public RestaurantStatus? status { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
