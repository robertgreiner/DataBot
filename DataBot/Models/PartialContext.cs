using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace DataBot.Models {
    public partial class DataBotDataContext {
        [Function(Name = "NEWID", IsComposable = true)]
        public Guid Random() {
            throw new NotImplementedException();
        }
    }
}