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
            var model = new UserViewModel();
            return View(model);
        }

        // POST: IntoPrevention/Create
        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            try
            {
                var user = Mapper.Map<UserViewModel, User>(model);
                userManager.StoreUser(user);
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
            var model = Mapper.Map<User, UserViewModel>(userManager.GetById(id));
            return View(model);
        }

        // POST: IntoPrevention/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UserViewModel model)
        {
            try
            {
                var user = Mapper.Map<UserViewModel, User>(model);
                userManager.StoreUser(user);
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
            var model = Mapper.Map<User, UserViewModel>(userManager.GetById(id));
            return View(model);
        }

        // POST: IntoPrevention/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, UserViewModel model)
        {
            try
            {
                userManager.DeleteUser(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}