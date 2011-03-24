using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class CityColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.City;
            }
        }

        public string DisplayName {
            get {
                return "City";
            }
        }

        public string Value {
            get {
                string value = string.Empty;
                using (var ctx = new DataBotDataContext()) {
                    var query = (from row in ctx.Cities
                                 orderby ctx.Random()
                                 select row).FirstOrDefault();

                    value = query.Value;
                }
                return value;
            }
        }
    }
}