using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBot.Models;

namespace DataBot.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<RandomDataRow> randomDataRows = new List<RandomDataRow>();
            randomDataRows.Add(new RandomDataRow());
            return View(randomDataRows);
        }

    }
}
