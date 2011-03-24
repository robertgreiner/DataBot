using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBot.Models;
using System.Xml.Linq;
using System.IO;
using System.Text;
using DataBot.Models.ColumnTypes;

namespace DataBot.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<DataRow> dataRows = GenerateRows(5);
            return View(dataRows);
        }

        /* TODO: Eventually, I want to add code that will let the user actually download
         * the file they want.  Also, this will need to be refactored after I get everything 
         * else working the way I want it.  Right now, I'll just return some text/plain
         * content. */
        [HttpPost]
        public ActionResult Index(FormCollection collection) {
            int numRows = Convert.ToInt32(collection["numRows"]);
            string exportType = collection["export"];
            List<DataRow> randomDataRows = GenerateRows(numRows, collection);
            string result = string.Empty;

            if (exportType.Equals("SQL")) {
                //result = GenerateSQL(randomDataRows);
            } else if (exportType.Equals("CSV")) {
                //result = GenerateCSV(randomDataRows);
            } else {
                result = GenerateXML(randomDataRows).ToString();
            }

            return Content(result, "text/plain");
            //return View(randomDataRows.GetRange(0, 5));
        }

        private List<DataRow> GenerateRows(int numRows) {
            List<DataRow> rows = new List<DataRow>();

            for (int x = 0; x < numRows; x++) {
                DataRow row = new DataRow();
                row.AddColumn(new ApartmentNumberColumn());
                row.AddColumn(new BirthDayColumn());
                row.AddColumn(new BirthMonthColumn());
                row.AddColumn(new BirthYearColumn());
                row.AddColumn(new CityColumn());
                row.AddColumn(new DriversLicenseNumberColumn());
                row.AddColumn(new FirstNameColumn());
                row.AddColumn(new IDColumn());
                row.AddColumn(new LastNameColumn());
                row.AddColumn(new PhoneNumberColumn());
                row.AddColumn(new SocialSecurityNumberColumn());
                row.AddColumn(new StateColumn());
                row.AddColumn(new StreetNameColumn());
                row.AddColumn(new StreetNumberColumn());
                row.AddColumn(new ZipCodeColumn());
                rows.Add(row);
            }

            return rows;
        }

        private List<DataRow> GenerateRows(int numRows, FormCollection collection) {
            List<DataRow> rows = new List<DataRow>();

            for (int x = 0; x < numRows; x++) {
                DataRow row = new DataRow();
                if (collection["apartmentNumber"] != null) {
                    row.AddColumn(new ApartmentNumberColumn());
                }
                if (collection["birthDay"] != null) {
                    row.AddColumn(new BirthDayColumn());
                } 
                if (collection["birthMonth"] != null) {
                    row.AddColumn(new BirthMonthColumn());
                } 
                if (collection["birthYear"] != null) {
                    row.AddColumn(new BirthYearColumn());
                } 
                if (collection["city"] != null) {
                    row.AddColumn(new CityColumn());
                } 
                if (collection["driversLicenseNumber"] != null) {
                    row.AddColumn(new DriversLicenseNumberColumn());
                } 
                if (collection["firstName"] != null) {
                    row.AddColumn(new FirstNameColumn());
                } 
                if (collection["id"] != null) {
                    row.AddColumn(new IDColumn());
                } 
                if (collection["lastName"] != null) {
                    row.AddColumn(new LastNameColumn());
                } 
                if (collection["phoneNumber"] != null) {
                    row.AddColumn(new PhoneNumberColumn());
                } 
                if (collection["socialSecurityNumber"] != null) {
                    row.AddColumn(new SocialSecurityNumberColumn());
                } 
                if (collection["state"] != null) {
                    row.AddColumn(new StateColumn());
                } 
                if (collection["streetName"] != null) {
                    row.AddColumn(new StreetNameColumn());
                } 
                if (collection["streetNumber"] != null) {
                    row.AddColumn(new StreetNumberColumn());
                } 
                if (collection["zipCode"] != null) {
                    row.AddColumn(new ZipCodeColumn());
                }
                
                rows.Add(row);
            }

            return rows;
        }

        private XDocument GenerateXML(List<DataRow> rows) {
            return new XDocument(
                    new XElement("users",
                        from r in rows
                        select new XElement("user",
                            from c in r.Columns
                            select new XElement(c.Value.ColumnName, c.Value.Value))));
        }

        private string GenerateCSV(List<DataRow> rows) {

            return string.Empty;
        }

        private string GenerateSQL(List<DataRow> rows) {
            return string.Empty;
        }
    }
}
