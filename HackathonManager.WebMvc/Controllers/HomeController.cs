﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackathonManager.DIContext;
using HackathonManager.DTO;
using Microsoft.AspNet.SignalR;
using SignalRProgressBarSimpleExample.Hubs;

namespace HackathonManager.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();
            string id = (string)hubContext.Clients.All.GetConnectionId().Result;

            var Db = MvcApplication.DbRepo;

            //var db = Context.GetMLabsMongoDbRepo();
            var model = new List<Mentor>();
            model = Db.All<Mentor>().Where(x => x.IsPresent == true).ToList().OrderBy(e => e.IsAvailable ? 0 : 1).ToList();
            //model = Db.All<Mentor>().Where(x => x.IsPresent == true).ToList();

            //mentorViewModel.PresentMentors = repo.All<Mentor>().Where(x => x.IsPresent == true).ToList();
            //mentorViewModel.AvailableMentors = repo.All<Mentor>().Where(x => x.IsAvailable == true).ToList();

            return View(model);
        }

        public ActionResult SetTeam()
        {
            HttpCookie cookie = Request.Cookies["team"];
            if (cookie == null)
            {
                Response.Cookies["team"].Value = "ExampleTeam";
                Response.Cookies["team"].Expires = DateTime.UtcNow.AddDays(3);
            }
            else
            {
                Response.Cookies["team"].Value = "ExampleTeam";
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public ActionResult LogOut()
        {
            HttpCookie cookie = Request.Cookies["team"];
            if (cookie != null)
            {
                Response.Cookies["team"].Value = "";
            }
            else
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Something()
        {
            HttpCookie cookie = Request.Cookies["temp"];
            ViewData["Message"] = cookie.Value;
            return View();
        }
    }
}