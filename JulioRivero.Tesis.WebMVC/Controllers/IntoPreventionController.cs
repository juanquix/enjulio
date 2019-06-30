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
    public class IntoPreventionController : BaseController
    {
        public IntoPreventionController()
        {
            fillMenu();
        }
        // GET: IntoPrevention
        public ActionResult Index()
        {
            ViewBag.LastNameUser = lastName;
            var intoPreventions = Mapper.Map<IList<IntoPrevention>, IList<IntoPreventionViewModel>>(intoPreventionManager.GetAllIntoPreventions()).ToList();
            return View(intoPreventions);
        }

        // GET: IntoPrevention/Details/5
        public ActionResult Details(int id)
        {
            var model = Mapper.Map<IntoPreventionViewModel>(intoPreventionManager.GetById(id));
            return View(model);
        }

        // GET: IntoPrevention/Create
        public ActionResult Create()
        {
            ViewBag.LastNameUser = lastName;
            var model = new IntoPreventionViewModel();
            return View(model);
        }

        // POST: IntoPrevention/Create
        [HttpPost]
        public ActionResult Create(IntoPreventionViewModel model)
        {
            ViewBag.LastNameUser = lastName;
            try
            {
                var intoPrevention = Mapper.Map<IntoPreventionViewModel, IntoPrevention>(model);
                intoPreventionManager.StoreIntoPrevention(intoPrevention);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: IntoPrevention/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.LastNameUser = lastName;
            var model = Mapper.Map<IntoPrevention, IntoPreventionViewModel>(intoPreventionManager.GetById(id));
            return View(model);
        }

        // POST: IntoPrevention/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IntoPreventionViewModel model)
        {
            ViewBag.LastNameUser = lastName;
            try
            {
                var intoPrevention = Mapper.Map<IntoPreventionViewModel, IntoPrevention>(model);
                intoPreventionManager.StoreIntoPrevention(intoPrevention);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: IntoPrevention/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.LastNameUser = lastName;
            var model = Mapper.Map<IntoPrevention, IntoPreventionViewModel>(intoPreventionManager.GetById(id));
            return View(model);
        }

        // POST: IntoPrevention/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, IntoPreventionViewModel model)
        {
            ViewBag.LastNameUser = lastName;
            try
            {
                intoPreventionManager.DeleteIntoPrevention(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}