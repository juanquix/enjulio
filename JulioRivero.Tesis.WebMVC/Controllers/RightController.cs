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
using System.IO;
using System.Text;

namespace JulioRivero.Tesis.WebMVC.Controllers
{
    public class RightController : BaseController
    {
        // GET: Right
        public ActionResult Index()
        {
            var rights = Mapper.Map<IList<Right>, IList<RightViewModel>>(rightManager.GetAllRights()).ToList();
            return View(rights);
        }

        // GET: Right/Details/5
        //public ActionResult Details(int id)
        //{
        //    var model = Mapper.Map<RightViewModel>(rightManager.GetById(id));


        //    return View(model);
        //}
        // public ActionResult Details(int id)
        //public FileStreamResult Details(int id)
        //{
        //    //string filename = @"~/Content/derechos-pcd-onu.pdf";
        //    //return File(filename, "application/pdf", Server.HtmlEncode(filename));

        //}
        public FileResult OpenPDF(string id)
        {
            return File(Server.MapPath("~/Content/"+ id + ".pdf"), "application/pdf");
            
            ////// return File(Server.MapPath("~/Content/default.pdf"), "application/pdf");
        }
        ////public FileStreamResult GetPDF()
        ////{
        ////    FileStream fs = new FileStream("~/Content/derechos-pcd-onu.pdf", FileMode.Open, FileAccess.Read);
        ////    return File(fs, "application/pdf");
        ////}
        // GET: Right/Create
        public ActionResult Create()
        {
            var model = new RightViewModel();
            return View(model);
        }

        // POST: Right/Create
        [HttpPost]
        public ActionResult Create(RightViewModel model, HttpPostedFileBase file)
        {
            //convert to binary data
            //byte[] newDataFile;
            //using (Stream inputStream = file.InputStream)
            //{
            //    MemoryStream memoryStream = inputStream as MemoryStream;
            //    if (memoryStream == null)
            //    {
            //        memoryStream = new MemoryStream();
            //        inputStream.CopyTo(memoryStream);
            //    }

            //    newDataFile = memoryStream.ToArray();
            //}
            //////add to model
            //model.FilePdf = newDataFile;
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
        //public byte[] convertToBinaryFile(FileStream fileName)
        //{
        //    byte[] newFile = null;
        //    newFile = System.IO.File.ReadAllBytes(fileName.ToString());
        //    return newFile;
        //}
        // GET: Right/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Mapper.Map<Right, RightViewModel>(rightManager.GetById(id));
            return View(model);
        }

        // POST: Right/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, RightViewModel model)
        {
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
            var model = Mapper.Map<Right, RightViewModel>(rightManager.GetById(id));
            return View(model);
        }

        // POST: Right/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, RightViewModel model)
        {
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