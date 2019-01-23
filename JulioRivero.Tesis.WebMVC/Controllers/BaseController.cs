using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JulioRivero.Tesis.Biz;
using JulioRivero.Tesis.EFContext;
using AutoMapper;
using JulioRivero.Tesis.Entities;
using JulioRivero.Tesis.WebMVC.Models;

namespace JulioRivero.Tesis.WebMVC.Controllers
{
    public class BaseController : Controller
    {
        protected ImpairmentManager ImpairmentManager = new ImpairmentManager(new ImpairmentDao());
        protected DeficiencyManager deficiencyManager = new DeficiencyManager(new DeficiencyDao());
        protected UserManager userManager = new UserManager(new UserDao());
        protected RoleManager roleManager = new RoleManager(new RoleDao());
        protected RightManager rightManager = new RightManager(new RightDao());
        protected PreventionManager preventionManager = new PreventionManager(new PreventionDao());
        protected IntoPreventionManager intoPreventionManager = new IntoPreventionManager(new IntoPreventionDao());

        public void fillMenu()
        {
            var imparirments = Mapper.Map<IList<Impairment>, IList<ImpairmentViewModel>>(ImpairmentManager.GetAllImpairments()).ToList();
            ViewBag.impairmentsMenu = imparirments;
            var preventions = Mapper.Map<IList<Prevention>, IList<PreventionViewModel>>(preventionManager.GetAllPreventions()).ToList();
            ViewBag.preventionsMenu = preventions;
            var rights = Mapper.Map<IList<Right>, IList<RightViewModel>>(rightManager.GetAllRights()).ToList();
            ViewBag.rightsMenu = rights;
        }

    }
}