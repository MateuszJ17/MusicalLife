using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicalLife.Interfaces;
using MusicalLife.Models;

namespace MusicalLife.Controllers
{
    public class HomeController : Controller
    {

        private ITrackRepository _trackRepository;
        private List<Track> _cart;

        public HomeController(ITrackRepository trackRepository)
        {
            //var track = new Track();
            //Adding shopping cart to session
            if (HttpHelper.HttpContext.Session.GetObjectFromJson<List<Track>>("Cart") == null)
            {
                HttpHelper.HttpContext.Session.SetObjectAsJson("Cart", new List<Track>());
            }

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
            tracks = _trackRepository.GetAllTracks();
            return View(tracks);
        }

        public IActionResult Recommended(List<Track> tracks)
        {
            tracks = _trackRepository.GetTracksByDownloads(500);
            return View(tracks);
        }

        public IActionResult Bestsellers(List<Track> tracks)
        {
            tracks = _trackRepository.GetTracksByDownloads(10000);
            return View(tracks);
        }

        public IActionResult AddTrack(Track track)
        {
            track = _trackRepository.Add(track);
            return View("Create");
        }

        public IActionResult CreateTrack()
        {
            return View("Create");
        }

        public IActionResult Search(string input)
        {
            if (DateTime.TryParse(input, out DateTime date))
            {
                var search = _trackRepository.GetTracksByDate(date);
                if (search.Count > 0)
                    return View(search);
            }
            if (!(input == String.Empty))
            {
                var search = _trackRepository.GetTracksByGenre(input);
                if (search.Count > 0)
                    return View(search);
            }
            if (!(input == String.Empty))
            {
                var search = _trackRepository.GetTracksByAuthor(input);
                if (search.Count > 0)
                    return View(search);
            }
            if (!(input == String.Empty))
            {
                var search = _trackRepository.GetTracksByAlbum(input);
                if (search.Count > 0)
                    return View(search);
            }
            return View(new List<Track>());
        }

        public IActionResult Cart()
        {
            var cart = HttpHelper.HttpContext.Session.GetObjectFromJson<List<Track>>("Cart");
            return View(cart);
        }

        public IActionResult AddToCart(int trackID)
        {
            var product = _trackRepository.GetTrack(trackID);
            if (_cart == null)
                _cart = new List<Track>();

            var cart = HttpHelper.HttpContext.Session.GetObjectFromJson<List<Track>>("Cart");
            _cart.Add(product);
            cart.AddRange(_cart);
            HttpHelper.HttpContext.Session.SetObjectAsJson("Cart", cart);

            return View("Index", _trackRepository.GetAllTracks());
        }
    }
}