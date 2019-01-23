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
            //var imparirments = Mapper.Map<IList<Impairment>, IList<ImpairmentViewModel>>(ImpairmentManager.GetAllImpairments()).ToList();
            //ViewBag.impairmentsMenu = imparirments;
            //ViewData["impairmentsMenu"] = imparirments;
            return View();
        }

        public ActionResult About()
        {
            fillMenu();
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            fillMenu();
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}