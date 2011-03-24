using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class SocialSecurityNumberColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.SocialSecurityNumber;
            }
        }

        public string DisplayName {
            get {
                return "SSN";
            }
        }

        public string Value {
            get {
                return new Random().Next(100000000, 999999999).ToString();
            }
        }
    }
}