using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class BirthYearColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.BirthYear;
            }
        }

        public string DisplayName {
            get {
                return "Birth Year";
            }
        }

        public string Value {
            get {
                //To make things a little more realistic, we will only generate birth years
                //that make users younger than 80 and older than 18 at the time of creation.
                int thisYear = DateTime.Now.Year;
                return new Random().Next(thisYear - 80, thisYear - 18).ToString(); ;
            }
        }
    }
}