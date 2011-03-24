using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class BirthMonthColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.BirthMonth;
            }
        }

        public string DisplayName {
            get {
                return "Birth Month";
            }
        }

        public string Value {
            get {
                return new Random().Next(1, 12).ToString();
            }
        }
    }
}