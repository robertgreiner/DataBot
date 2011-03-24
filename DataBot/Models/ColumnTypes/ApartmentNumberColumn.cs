using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class ApartmentNumberColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.ApartmentNumber;
            }
        }

        public string DisplayName {
            get {
                return "APT #";
            }
        }

        public string Value {
            get {
                return new Random().Next(1, 3500).ToString();
            }
        }
    }
}