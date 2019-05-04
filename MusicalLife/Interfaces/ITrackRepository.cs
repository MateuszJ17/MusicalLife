using MusicalLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalLife.Interfaces
{
    public interface ITrackRepository
    {
        /// <summary>
        /// Gets specific track
        /// </summary>
        /// <param name="trackID">ID of desired track</param>
        /// <returns>Track with specific ID</returns>
        Track GetTrack(int trackID);

        /// <summary>
        /// Gets all avaiable tracks
        /// </summary>
        /// <returns>Returns list of all tracks</returns>
        List<Track> GetAllTracks();

        /// <summary>
        /// Get tracks in the genre
        /// </summary>
        /// <param name="genre">Desired genre of music (ex. "rock", "jazz")</param>
        /// <returns>Tracks in desired genre</returns>
        List<Track> GetTracksByGenre(string genre);

        /// <summary>
        /// Get tracks released in desired years
        /// </summary>
        /// <param name="releaseDate">Desired year</param>
        /// <returns>Tracks released in desired year</returns>
        List<Track> GetTracksByDate(DateTime releaseDate);

        Track Add(Track track);
    }
}
