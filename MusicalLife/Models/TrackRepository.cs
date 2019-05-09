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

        public Track GetTrackByDate(DateTime releaseDate)
        {
            var track = _context.Tracks.Where(song => song.ReleaseDate == releaseDate);
            return track as Track;
        }

        public List<Track> GetTracksByAuthor(string performer)
        {
            var tracks = _context.Tracks.Where(song => song.Performer == performer);
            return tracks.ToList();
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

        public List<Track> GetTracksByAlbum(string album)
        {
            var tracks = _context.Tracks.Where(song => song.Album == album);
            return tracks.ToList();
        }

        public List<Track> GetTracksByDownloads(int downloads)
        {
            var tracks = _context.Tracks.Where(song => song.Downloads >= downloads);
            return tracks.ToList();
        }
    }
}
