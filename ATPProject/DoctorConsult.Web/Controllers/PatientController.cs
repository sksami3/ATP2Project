﻿using DoctorConsult.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoctorConsult.Web.Controllers
{
    public class PatientController : Controller
    {
        // patient dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChangePassword(PatientChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Profile", "Patient");
            }
            else
            {
                return View(model: model);
            }
        }




    }
}