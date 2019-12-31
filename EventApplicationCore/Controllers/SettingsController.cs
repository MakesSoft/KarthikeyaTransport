﻿using Microsoft.AspNetCore.Mvc;
using MyAccountProject.Model;
using System.Linq;

namespace MyMVC.Controllers
{
    public class SettingsController : Controller
    {
        private DatabaseContext _context;

        public SettingsController(DatabaseContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View(_context.Settings.ToList().OrderByDescending(x => x.SettingsId).First());
        }

        [HttpPost]
        public ActionResult Index(Settings settings)
        {
            _context.Settings.Add(settings);
            _context.SaveChanges();

            TempData["SettingsMessage"] = "Settings Updated Successfully";

            return View();
        }
    }
}