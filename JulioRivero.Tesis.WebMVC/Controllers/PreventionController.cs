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
    public class PreventionController : BaseController
    {
        // GET: Prevention
        public ActionResult Index()
        {
            fillMenu();
            ViewBag.LastNameUser = lastName;
            var preventions = Mapper.Map<IList<Prevention>, IList<PreventionViewModel>>(preventionManager.GetAllPreventions()).ToList();
            ViewBag.preventionsMenu = preventions;
           
            return View(preventions);
        }
        enum Preventions  //quizas llevar esto a un lugar mas organizado
        {
            Embarazo = 1,
            Accidente = 2,
            Violencia = 3
        }
        // GET: Prevention/Details/5
        public ActionResult Details(int id)
        {
            fillMenu();
            var model = Mapper.Map<PreventionViewModel>(preventionManager.GetById(id));
            var intoPreventions = Mapper.Map<IList<IntoPrevention>, IList<IntoPreventionViewModel>>(intoPreventionManager.GetAllIntoPreventions()).ToList();

            if (id == (int)Preventions.Embarazo)
            {
                var ownList = intoPreventions.ToList().Where(c => c.Kind.CompareTo(Preventions.Embarazo.ToString()) == 0);
                ViewBag.ownData = ownList;
            }
            else if (id == (int)Preventions.Accidente)
            {
                var ownList = intoPreventions.ToList().Where(c => c.Kind.CompareTo(Preventions.Accidente.ToString()) == 0);
                ViewBag.ownData = ownList;
            }
            else if (id == (int)Preventions.Violencia)
            {
                var ownList = intoPreventions.ToList().Where(c => c.Kind.CompareTo(Preventions.Violencia.ToString()) == 0);
                ViewBag.ownData = ownList;
            }
            
            return View(model);
        }

        // GET: Prevention/Create
        public ActionResult Create()
        {
            fillMenu();
            ViewBag.LastNameUser = lastName;
            var model = new PreventionViewModel();
            return View(model);
        }

        // POST: Prevention/Create
        [HttpPost]
        public ActionResult Create(PreventionViewModel model)
        {
            fillMenu();
            ViewBag.LastNameUser = lastName;
            try
            {
                var prevention = Mapper.Map<PreventionViewModel, Prevention>(model);
                preventionManager.StorePrevention(prevention);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prevention/Edit/5
        public ActionResult Edit(int id)
        {
            fillMenu();
            ViewBag.LastNameUser = lastName;
            var model = Mapper.Map<Prevention, PreventionViewModel>(preventionManager.GetById(id));
            return View(model);
        }

        // POST: Prevention/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PreventionViewModel model)
        {
            fillMenu();
            ViewBag.LastNameUser = lastName;
            try
            {
                var prevention = Mapper.Map<PreventionViewModel, Prevention>(model);
                preventionManager.StorePrevention(prevention);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Prevention/Delete/5
        public ActionResult Delete(int id)
        {
            fillMenu();
            ViewBag.LastNameUser = lastName;
            var model = Mapper.Map<Prevention, PreventionViewModel>(preventionManager.GetById(id));
            return View(model);
        }

        // POST: Prevention/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PreventionViewModel model)
        {
            fillMenu();
            ViewBag.LastNameUser = lastName;
            try
            {
                preventionManager.DeletePrevention(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}