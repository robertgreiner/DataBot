using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class ZipCodeColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.ZipCode;
            }
        }

        public string DisplayName {
            get {
                return "Zip";
            }
        }

        public string Value {
            get {
                return new Random().Next(10000, 99999).ToString();
            }
        }
    }
}