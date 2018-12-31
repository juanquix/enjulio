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
            var preventions = Mapper.Map<IList<Prevention>, IList<PreventionViewModel>>(preventionManager.GetAllPreventions()).ToList();
            return View(preventions);
        }

        // GET: Prevention/Details/5
        public ActionResult Details(int id)
        {
            var model = Mapper.Map<PreventionViewModel>(preventionManager.GetById(id));
            return View(model);
        }

        // GET: Prevention/Create
        public ActionResult Create()
        {
            var model = new PreventionViewModel();
            return View(model);
        }

        // POST: Prevention/Create
        [HttpPost]
        public ActionResult Create(PreventionViewModel model)
        {
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
            var model = Mapper.Map<Prevention, PreventionViewModel>(preventionManager.GetById(id));
            return View(model);
        }

        // POST: Prevention/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PreventionViewModel model)
        {
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
            var model = Mapper.Map<Prevention, PreventionViewModel>(preventionManager.GetById(id));
            return View(model);
        }

        // POST: Prevention/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PreventionViewModel model)
        {
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