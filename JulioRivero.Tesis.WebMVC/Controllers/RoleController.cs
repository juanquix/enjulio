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
    public class RoleController : BaseController
    {
        // GET: Role
        public ActionResult Index()
        {
            fillMenu();
            var roles = Mapper.Map<IList<Role>, IList<RoleViewModel>>(roleManager.GetAllRoles()).ToList();
            return View(roles);
        }

        // GET: Role/Details/5
        public ActionResult Details(int id)
        {
            fillMenu();
            var model = Mapper.Map<RoleViewModel>(roleManager.GetById(id));
            return View(model);
        }

        // GET: Role/Create
        public ActionResult Create()
        {
            fillMenu();
            var model = new RoleViewModel();
            return View(model);
        }

        // POST: Role/Create
        [HttpPost]
        public ActionResult Create(RoleViewModel model)
        {
            fillMenu();
            try
            {
                var role = Mapper.Map<RoleViewModel, Role>(model);
                roleManager.StoreRole(role);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Role/Edit/5
        public ActionResult Edit(int id)
        {
            fillMenu();
            var model = Mapper.Map<Role, RoleViewModel>(roleManager.GetById(id));
            return View(model);
        }

        // POST: Role/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, RoleViewModel model)
        {
            fillMenu();
            try
            {
                var role = Mapper.Map<RoleViewModel, Role>(model);
                roleManager.StoreRole(role);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Role/Delete/5
        public ActionResult Delete(int id)
        {
            fillMenu();
            var model = Mapper.Map<Role, RoleViewModel>(roleManager.GetById(id));
            return View(model);
        }

        // POST: Role/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, RoleViewModel model)
        {
            fillMenu();
            try
            {
                roleManager.DeleteRole(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }
    }
}