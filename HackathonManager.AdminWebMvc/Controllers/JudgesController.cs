﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackathonManager.AdminWebMvc.Controllers
{
    public class JudgesController : Controller
    {
        // GET: Judges
        public ActionResult Index()
        {
            return View();
        }

        // GET: Judges/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Judges/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Judges/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Judges/Edit/5
        public ActionResult Edit(Guid id)
        {

            return View();
        }

        // POST: Judges/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Judges/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Judges/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}