﻿using MusicalLife.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalLife.Models
{
    public class MockTrackRepository : ITrackRepository
    {
        private List<Track> _tracks;

        /// <summary>
        /// Default constructor creates mock Track model list
        /// </summary>
        public MockTrackRepository()
        {
            _tracks = new List<Track>()
            {
                new Track()
                {
                    TrackID = 1,
                    Performer = "TestPerformer1",
                    Album = "TestAlbum1",
                    AlbumID = 1,
                    ReleaseDate = new DateTime(1997, 02, 01),
                    Genre = "Rock"
                },
                new Track()
                {
                    TrackID = 2,
                    Performer = "TestPerformer2",
                    Album = "TestAlbum2",
                    AlbumID = 2,
                    ReleaseDate = new DateTime(2004, 02, 01),
                    Genre = "Jazz"
                },
                new Track()
                {
                    TrackID = 3,
                    Performer = "TestPerformer3",
                    Album = "TestAlbum3",
                    AlbumID = 3,
                    ReleaseDate = new DateTime(2014, 02, 01),
                    Genre = "Country"
                },
            };
        }

        public Track GetTrack(int trackID)
        {
            var result = _tracks.FirstOrDefault(x => x.TrackID == trackID);
            return result;
        }

        public Track GetTracksByDate(DateTime releaseDate)
        {
            throw new NotImplementedException();
        }

        public Track GetTracksByGenre(string genre)
        {
            throw new NotImplementedException();
        }
    }
}
