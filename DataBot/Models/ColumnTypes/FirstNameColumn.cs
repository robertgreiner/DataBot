using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class FirstNameColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.FirstName;
            }
        }

        public string DisplayName {
            get {
                return "First Name";
            }
        }

        public string Value {
            get {
                string value = string.Empty;
                using (var ctx = new DataBotDataContext()) {
                    var query = (from row in ctx.FirstNames
                                 orderby ctx.Random()
                                 select row).FirstOrDefault();

                    value = query.Value;
                }
                return value;
            }
        }
    }
}