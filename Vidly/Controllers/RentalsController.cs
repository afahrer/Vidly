﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class RentalsController : Controller
    {
        public ActionResult New()
        {
            return View();
        }
        public ActionResult Return()
        {
            return View();
        }
    }
}
