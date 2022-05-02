using System;
using System.Collections.Generic;

#nullable disable

namespace ToyUniverseData.Models
{
    public partial class ToyBrand
    {
        public ToyBrand()
        {
            Toys = new HashSet<Toy>();
        }

        public string CBrandId { get; set; }
        public string CBrandName { get; set; }

        public virtual ICollection<Toy> Toys { get; set; }
    }
}
