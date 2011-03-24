using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace DataBot.Models.ColumnTypes {
    public class PhoneNumberColumn : IRandomColumnType {

        public string ColumnName {
            get {
                return ColumnNames.PhoneNumber;
            }
        }

        public string DisplayName {
            get {
                return "Phone #";
            }
        }

        public string Value {
            get {
                //We don't want to generate any real phone numbers here.
                //Let's do things like they do in the movies.
                StringBuilder phoneNumber = new StringBuilder();
                phoneNumber.Append(new Random().Next(100, 999));
                phoneNumber.Append("555");
                phoneNumber.Append(new Random().Next(1000, 9999));
                return phoneNumber.ToString();
            }
        }
    }
}