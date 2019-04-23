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
        /// Get tracks in the genre
        /// </summary>
        /// <param name="genre">Desired genre of music (ex. "rock", "jazz")</param>
        /// <returns>Tracks in desired genre</returns>
        Track GetTracksByGenre(string genre);

        /// <summary>
        /// Get tracks released in desired years
        /// </summary>
        /// <param name="releaseDate">Desired year</param>
        /// <returns>Tracks released in desired year</returns>
        Track GetTracksByDate(DateTime releaseDate);
    }
}
