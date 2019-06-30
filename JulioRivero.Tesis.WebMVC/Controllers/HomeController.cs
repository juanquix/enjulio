using AutoMapper;
using JulioRivero.Tesis.Entities;
using JulioRivero.Tesis.WebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JulioRivero.Tesis.WebMVC.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {
            fillMenu();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View("Contact", "_LayoutAdmin");//
        }

        public ActionResult LogOut()
        {
            ViewBag.LastNameUser = lastName;
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult LogOut(string number)
        {
            ViewBag.LastNameUser = lastName;
            if (number != null)
            {
                if (number.CompareTo("number") == 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}