using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class StreetNameColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.StreetName;
            }
        }

        public string DisplayName {
            get {
                return "Street Name";
            }
        }

        public string Value {
            get {
                string value = string.Empty;
                using (var ctx = new DataBotDataContext()) {
                    var query = (from row in ctx.StreetNames
                                 orderby ctx.Random()
                                 select row).FirstOrDefault();

                    value = query.Value;
                }
                return value;
            }
        }
    }
}