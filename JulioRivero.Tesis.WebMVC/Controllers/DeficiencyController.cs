using AutoMapper;
using JulioRivero.Tesis.Biz;
using JulioRivero.Tesis.Entities;
using JulioRivero.Tesis.WebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JulioRivero.Tesis.WebMVC.Controllers
{
    public class DeficiencyController : BaseController
    {
        // GET: Deficiency
        public ActionResult Index()
        {
            var deficiencys = Mapper.Map<IList<Deficiency>, IList<DeficiencyViewModel>>(deficiencyManager.GetAllDeficiencys()).ToList();
            return View(deficiencys);
        }

        // GET: Deficiency/Details/5
        public ActionResult Details(int id)
        {
            var model = Mapper.Map<DeficiencyViewModel>(deficiencyManager.GetById(id));
            return View(model);
        }

        // GET: Deficiency/Create
        public ActionResult Create()
        {
            var model = new DeficiencyViewModel();
            return View(model);
        }

        // POST: Deficiency/Create
        [HttpPost]
        public ActionResult Create(DeficiencyViewModel model)
        {
            try
            {
                var deficiency = Mapper.Map<DeficiencyViewModel, Deficiency>(model);
                deficiencyManager.StoreDeficiency(deficiency);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Deficiency/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Mapper.Map<Deficiency, DeficiencyViewModel>(deficiencyManager.GetById(id));
            return View(model);
        }

        // POST: Deficiency/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DeficiencyViewModel model)
        {
            try
            {
                var deficiency = Mapper.Map<DeficiencyViewModel, Deficiency>(model);
                deficiencyManager.StoreDeficiency(deficiency);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Deficiency/Delete/5
        public ActionResult Delete(int id)
        {
            var model = Mapper.Map<Deficiency, DeficiencyViewModel>(deficiencyManager.GetById(id));
            return View(model);
        }

        // POST: Deficiency/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, DeficiencyViewModel model)
        {
            try
            {
                deficiencyManager.DeleteDeficiency(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}