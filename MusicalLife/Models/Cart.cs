using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalLife.Models
{
    public class Cart
    {
        public List<Track> Products { get; set; }
        public decimal Total { get; set; }
    }
}
