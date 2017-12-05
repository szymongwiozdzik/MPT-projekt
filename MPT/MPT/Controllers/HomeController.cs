﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MPT.Models;

namespace MPT.Controllers
{
    public class HomeController : Controller
    {
        private MPTDBContext db;

        public HomeController()
        {
            db = new MPTDBContext();
        }

        public HomeController(MPTDBContext _db)
        {
            db = _db;
        }

        public ActionResult Login()
        {
            User usr = new User();
            if (Request.Cookies["userInfp"] != null)
            {
                return RedirectToAction("Index");
            }
            return View(usr);
        }
        
        //action after login need to be applied. We have to find in a databe a proped id. Password should be hashed. It could be added, after database creation
        [HttpPost]
        public ActionResult Login(string ID, string HasPassword) // this method could also contain a permissions.
        {
            return View();
  
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public JsonResult GetEvents()
        {
           var events = db.Events.ToList();
           return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        
        
        
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}