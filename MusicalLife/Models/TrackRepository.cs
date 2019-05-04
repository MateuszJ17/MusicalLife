using MusicalLife.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalLife.Models
{
    public class TrackRepository : ITrackRepository
    {
        private readonly AppDbContext _context;

        public TrackRepository(AppDbContext context)
        {
            _context = context;
        }

        public Track Add(Track track)
        {
            _context.Tracks.Add(track);
            _context.SaveChanges();
            return track;
        }

        public List<Track> GetAllTracks()
        {
            return _context.Tracks.ToList();
        }

        public Track GetTrack(int trackID)
        {
            return _context.Tracks.Find(trackID);
        }

        public List<Track> GetTracksByDate(DateTime releaseDate)
        {
            var tracks = _context.Tracks.Where(song => song.ReleaseDate == releaseDate);
            return tracks.ToList();
        }

        public List<Track> GetTracksByGenre(string genre)
        {
            var tracks = _context.Tracks.Where(song => song.Genre == genre);
            return tracks.ToList();
        }
    }
}
