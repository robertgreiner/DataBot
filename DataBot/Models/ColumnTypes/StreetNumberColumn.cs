using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class StreetNumberColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.StreetNumber;
            }
        }

        public string DisplayName {
            get {
                return "Street Number";
            }
        }

        public string Value {
            get {
                return new Random().Next(100, 9999).ToString();
            }
        }
    }
}