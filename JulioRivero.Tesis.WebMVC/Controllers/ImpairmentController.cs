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
    public class ImpairmentController : BaseController
    {
        // GET: Imparirment
        public ActionResult Index()
        {
            fillMenu();
            var imparirments = Mapper.Map<IList<Impairment>, IList<ImpairmentViewModel>>(ImpairmentManager.GetAllImpairments()).ToList();
            return View(imparirments);
        }

        // GET: Imparirment/Details/5
        public ActionResult Details(int id)
        {
            fillMenu();
            var model = Mapper.Map<ImpairmentViewModel>(ImpairmentManager.GetById(id));
            return View(model);
        }

        // GET: Imparirment/Create
        public ActionResult Create()
        {
            fillMenu();
            var model = new ImpairmentViewModel();
            return View(model);
        }

        // POST: Imparirment/Create
        [HttpPost]
        public ActionResult Create(ImpairmentViewModel model)
        {
            fillMenu();
            try
            {
                var impairment = Mapper.Map<ImpairmentViewModel, Impairment>(model);
                ImpairmentManager.StoreImpairment(impairment);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Imparirment/Edit/5
        public ActionResult Edit(int id)
        {
            fillMenu();
            var model = Mapper.Map<Impairment, ImpairmentViewModel>(ImpairmentManager.GetById(id));
            return View(model);
        }

        // POST: Imparirment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ImpairmentViewModel model)
        {
            fillMenu();
            try
            {
                var impairment = Mapper.Map<ImpairmentViewModel, Impairment>(model);
                ImpairmentManager.StoreImpairment(impairment);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Imparirment/Delete/5
        public ActionResult Delete(int id)
        {
            fillMenu();
            var model = Mapper.Map<Impairment, ImpairmentViewModel>(ImpairmentManager.GetById(id));
            return View(model);
        }

        // POST: Imparirment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ImpairmentViewModel model)
        {
            fillMenu();
            try
            {
                ImpairmentManager.DeleteImpairment(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}