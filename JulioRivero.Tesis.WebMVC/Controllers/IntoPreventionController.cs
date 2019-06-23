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
        // GET: IntoPrevention
        public ActionResult Index()
        {
            fillMenu();
            ViewBag.LastNameUser = lastName;
            var intoPreventions = Mapper.Map<IList<IntoPrevention>, IList<IntoPreventionViewModel>>(intoPreventionManager.GetAllIntoPreventions()).ToList();
            return View(intoPreventions);
        }

        // GET: IntoPrevention/Details/5
        public ActionResult Details(int id)
        {
            fillMenu();
            var model = Mapper.Map<IntoPreventionViewModel>(intoPreventionManager.GetById(id));
            return View(model);
        }

        // GET: IntoPrevention/Create
        public ActionResult Create()
        {
            fillMenu();
            ViewBag.LastNameUser = lastName;
            var model = new IntoPreventionViewModel();
            return View(model);
        }

        // POST: IntoPrevention/Create
        [HttpPost]
        public ActionResult Create(IntoPreventionViewModel model)
        {
            fillMenu();
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
            fillMenu();
            ViewBag.LastNameUser = lastName;
            var model = Mapper.Map<IntoPrevention, IntoPreventionViewModel>(intoPreventionManager.GetById(id));
            return View(model);
        }

        // POST: IntoPrevention/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IntoPreventionViewModel model)
        {
            fillMenu();
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
            fillMenu();
            ViewBag.LastNameUser = lastName;
            var model = Mapper.Map<IntoPrevention, IntoPreventionViewModel>(intoPreventionManager.GetById(id));
            return View(model);
        }

        // POST: IntoPrevention/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, IntoPreventionViewModel model)
        {
            fillMenu();
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