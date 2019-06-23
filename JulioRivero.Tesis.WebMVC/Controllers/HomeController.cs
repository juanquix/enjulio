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
        public ActionResult Index()
        {
            fillMenu();
            return View();
        }

        public ActionResult About()
        {
            fillMenu();
            ViewBag.Message = "Your application description page.";
            return View("Contact", "_LayoutAdmin");//
        }

        public ActionResult LogOut()
        {
            fillMenu();
            ViewBag.LastNameUser = lastName;
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult LogOut(string number)
        {
            fillMenu();
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
        //
    }
}