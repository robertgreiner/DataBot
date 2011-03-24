using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class BirthDayColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.BirthDay;
            }
        }

        public string DisplayName {
            get {
                return "Birth Day";
            }
        }

        public string Value {
            get {
                //NOTE: I don't want to deal with leap years yet.
                return new Random().Next(1, 28).ToString();
            }
        }
    }
}