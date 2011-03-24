using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class IDColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.ID;
            }
        }

        public string DisplayName {
            get {
                return "ID";
            }
        }

        public string Value {
            get {
                return new Random().Next(10000, 99999).ToString();
            }
        }
    }
}