using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalLife.Views.Home.Components.TrackCard
{
    public class TrackCard : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("TrackCard");
        }
    }
}
