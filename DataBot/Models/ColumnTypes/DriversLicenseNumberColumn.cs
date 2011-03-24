using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class DriversLicenseNumberColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.DriversLicenseNumber;
            }
        }

        public string DisplayName {
            get {
                return "DL #";
            }
        }

        public string Value {
            get {
                return new Random().Next(10000, 99999).ToString();
            }
        }
    }
}