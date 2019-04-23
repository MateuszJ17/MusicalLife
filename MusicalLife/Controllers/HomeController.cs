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

        public IActionResult Index(Track track)
        {
            track = _trackRepository.GetTrack(1);
            return View(track);
        }
        
        [Route("/Test")]
        public IActionResult Test()
        {
            return View();
        }
    }
}