using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBot.Models.ColumnTypes {
    public interface IRandomColumnType {
        string ColumnName { get; }
        string DisplayName { get; }
        string Value { get; }
    }
}
