﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    [Authorize(Roles ="Admin")]
    public class CategoriesController : Controller
    {
        // GET: Categories
        //[AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}