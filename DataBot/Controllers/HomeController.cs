using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBot.Models;
using System.Xml.Linq;

namespace DataBot.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<RandomDataRow> randomDataRows = GenerateRows(5);
            return View(randomDataRows);
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection) {
            int numRows = Convert.ToInt32(collection["numRows"]);
            List<RandomDataRow> randomDataRows = GenerateRows(numRows);

            XDocument xml = GenerateXML(randomDataRows);

            return View(randomDataRows.GetRange(0, 5));
        }

        private XDocument GenerateXML(List<RandomDataRow> rows) {
            return new XDocument(
                    new XElement("Users", 
                        from r in rows
                        select new XElement("User", 
                            new XElement("FirstName", r.FirstName),
                            new XElement("LastName", r.LastName),
                            new XElement("State", r.State),
                            new XElement("City", r.City),
                            new XElement("ZipCode", r.ZipCode),
                            new XElement("StreetNumber", r.StreetNumber),
                            new XElement("StreetName", r.StreetName),
                            new XElement("ApartmentNumber", r.ApartmentNumber),
                            new XElement("PhoneNumber", r.PhoneNumber),
                            new XElement("BirthYear", r.BirthYear),
                            new XElement("BirthMonth", r.BirthMonth),
                            new XElement("BirthDay", r.BirthDay))));
        }

        private List<RandomDataRow> GenerateRows(int numRows) {
            List<RandomDataRow> randomDataRows = new List<RandomDataRow>();
            for (int x = 0; x < numRows; x++) {
                RandomDataRow row = new RandomDataRow();
                randomDataRows.Add(row);
            }
            return randomDataRows;
        }
    }
}
