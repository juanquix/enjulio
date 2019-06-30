using AutoMapper;
using JulioRivero.Tesis.Entities;
using JulioRivero.Tesis.WebMVC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace JulioRivero.Tesis.WebMVC.Controllers
{
    public class RightController : BaseController
    {
        public RightController()
        {
            fillMenu();
        }
        // GET: Right
        public ActionResult Index()
        {
            ViewBag.LastNameUser = lastName;
            var rights = Mapper.Map<IList<Right>, IList<RightViewModel>>(rightManager.GetAllRights()).ToList();
            return View(rights);
        }
        
        public FileResult OpenPDF(int id)
        {
            var model = Mapper.Map<RightViewModel>(rightManager.GetById(id));
            return File(Server.MapPath("~/Uploads/"+model.FilePdf.ToString()), "application/pdf");
        }
        
        // GET: Right/Create
        public ActionResult Create()
        {
            ViewBag.LastNameUser = lastName;
            var model = new RightViewModel();
            return View(model);
        }

        // POST: Right/Create
        [HttpPost]
        public ActionResult Create(RightViewModel model, HttpPostedFileBase file)
        {
            ViewBag.LastNameUser = lastName;
            string archivo = (DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + file.FileName).ToLower();
            string pathPlusFile = string.Format("~/Uploads/" + archivo);
            file.SaveAs(Server.MapPath(pathPlusFile));    
            model.FilePdf = archivo;

            try
            {
                var right = Mapper.Map<RightViewModel, Right>(model);
                rightManager.StoreRight(right);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
       
        // GET: Right/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.LastNameUser = lastName;
            var model = Mapper.Map<Right, RightViewModel>(rightManager.GetById(id));
            return View(model);
        }

        // POST: Right/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, RightViewModel model)
        {
            ViewBag.LastNameUser = lastName;
            try
            {
                var right = Mapper.Map<RightViewModel, Right>(model);
                rightManager.StoreRight(right);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Right/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.LastNameUser = lastName;
            var model = Mapper.Map<Right, RightViewModel>(rightManager.GetById(id));
            return View(model);
        }

        // POST: Right/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, RightViewModel model)
        {
            ViewBag.LastNameUser = lastName;
            try
            {
                rightManager.DeleteRight(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}