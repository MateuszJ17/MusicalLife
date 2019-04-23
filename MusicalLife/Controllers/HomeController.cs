using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicalLife.Interfaces;
using MusicalLife.Models;

namespace MusicalLife.Controllers
{
    public class HomeController : Controller
    {

        private ITrackRepository _trackRepository;

        public HomeController(ITrackRepository trackRepository)
        {
            _trackRepository = trackRepository;
        }

        public IActionResult Index(List<Track> tracks)
        {
            tracks = _trackRepository.GetAllTracks();
            return View(tracks);
        }
        
        public IActionResult Details(int trackID)
        {   
            var result = _trackRepository.GetTrack(trackID);
            return View(result);
        }
        public IActionResult Hot(List<Track> tracks)
        {
            //TODO: Rebuild using GetTracksByDate
            tracks = _trackRepository.GetAllTracks();
            return View(tracks);
        }
        public IActionResult Recommended(List<Track> tracks)
        {
            //TODO: Rebuild using GetTracksByDate
            tracks = _trackRepository.GetTracksByGenre("Rock");
            return View(tracks);
        }
    }
}