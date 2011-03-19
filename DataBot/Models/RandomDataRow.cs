using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;
using System.Text;

namespace DataBot.Models {
    public class RandomDataRow {
        //refactor this later.
        public string FirstName {
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
        public string LastName {
            get {
                string value = string.Empty;
                using (var ctx = new DataBotDataContext()) {
                    var query = (from row in ctx.LastNames
                                 orderby ctx.Random()
                                 select row).FirstOrDefault();

                    value = query.Value;
                }
                return value;
            }
        }
        public string City {
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
        public string State {
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
        public string StreetName {
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
        public int StreetNumber {
            get {
                return new Random().Next(100, 9999);
            }
        }
        public int ApartmentNumber {
            get {
                return new Random().Next(1, 3500);
            }
        }
        public int ZipCode {
            get {
                return new Random().Next(10000, 99999);
            }
        }
        public string PhoneNumber {
            get {
                StringBuilder phoneNumber = new StringBuilder();
                phoneNumber.Append(new Random().Next(100, 999));
                phoneNumber.Append("555");
                phoneNumber.Append(new Random().Next(1000, 9999));
                return phoneNumber.ToString();
            }
        }
        public int BirthYear {
            get {
                int thisYear = DateTime.Now.Year;
                return new Random().Next(thisYear - 80, thisYear - 18);
            }
        }
        public int BirthMonth {
            get {
                return new Random().Next(1, 12);
            }
        }
        public int BirthDay {
            get {
                //NOTE: I don't want to deal with leap years yet.
                return new Random().Next(1,28);
            }
        }
    }
    partial class DataBotDataContext {
        [Function(Name = "NEWID", IsComposable = true)]
        public Guid Random() {
            throw new NotImplementedException();
        }
    }
}