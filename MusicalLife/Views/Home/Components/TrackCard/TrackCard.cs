using Microsoft.AspNetCore.Mvc;
using MusicalLife.Enums;
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
            var test = HttpHelper.HttpContext.Session.GetObjectFromJson<UserRoles>("Role");
            this.ViewData["Role"] = test;

            return View("TrackCard");
        }
    }
}
