using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineStore.Models.User;
using OnlineStore.Engine.BusinessControllers;

namespace OnlineStore.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                //do my stuff
            }

            return View(model);
        }


        public ActionResult Register()
        {
            var model = new RegisterViewModel();


            return View(model);
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new UserBC();
                user.FirstName = model.FirstName;
                user.Register();
            }
            return View(model);
        }




    }



}