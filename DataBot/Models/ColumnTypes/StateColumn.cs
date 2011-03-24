using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBot.Models.ColumnTypes {
    public class StateColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.State;
            }
        }

        public string DisplayName {
            get {
                return "State";
            }
        }

        public string Value {
            get {
                string value = string.Empty;
                using (var ctx = new DataBotDataContext()) {
                    var query = (from row in ctx.States
                                 orderby ctx.Random()
                                 select row).FirstOrDefault();

                    value = query.Value;
                }
                return value;
            }
        }
    }
}