using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalLife.Models
{
    /// <summary>
    /// Model for musical track
    /// </summary>
    public class Track
    {
        public int TrackID { get; set; }
        public string Performer { get; set; }
        public string Album { get; set; }
        public int AlbumID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
    }
}
