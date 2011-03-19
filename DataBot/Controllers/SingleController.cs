using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBot.Models;

namespace DataBot.Controllers
{
    public class SingleController : Controller
    {
        //
        // GET: /Single/

        public ActionResult Index()
        {
            return View(new RandomDataRow());
        }

    }
}
