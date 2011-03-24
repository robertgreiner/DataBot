using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataBot.Models.ColumnTypes;

namespace DataBot.Models {
    public class DataRow {
        public Dictionary<string, IRandomColumnType> Columns { get; set; }

        public DataRow() {
            Columns = new Dictionary<string, IRandomColumnType>();
        }

        public void AddColumn(IRandomColumnType column) {
            Columns.Add(column.ColumnName, column);
        }

        public IRandomColumnType GetColumn(string key) {
            return Columns[key];
        }
    }
}