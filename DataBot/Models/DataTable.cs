using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace DataBot.Models {
    [Table (Name="Users")]
    public class DataTable {
        [Column]
        public int ApartmentNumber;

        [Column]
        public int BirthDay;

        [Column]
        public int BirthMonth;

        [Column]
        public int BirthYear;

        [Column]
        public string City;

        [Column]
        public int DriversLicenseNumber;

        [Column]
        public int ID;

        [Column]
        public string LastName;

        [Column]
        public int PhoneNumber;

        [Column]
        public int SocialSecurityNumber;

        [Column]
        public string State;

        [Column]
        public string StreetName;

        [Column]
        public int StreetNumber;

        [Column]
        public int ZipCode;
    }
}