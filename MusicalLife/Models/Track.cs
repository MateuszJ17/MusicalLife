using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalLife.Models
{
    /// <summary>
    /// Model for musical track
    /// </summary>
    public class Track
    {
        [Key]
        public int TrackID { get; set; }
        public string Performer { get; set; }
        public string Album { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int Downloads { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
