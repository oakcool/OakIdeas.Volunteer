using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OakIdeas.Volunteer.Models
{
    public class Location :BaseModel
    {
        private string _street;

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        private string _streetNumber;

        public string StreetNumber
        {
            get { return _streetNumber; }
            set { _streetNumber = value; }
        }

        private string _postalCode;

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _adminDistrict;

        public string AdminDistrict
        {
            get { return _adminDistrict; }
            set { _adminDistrict = value; }
        }

        private string _adminDistrict2;

        public string AdminDistrict2
        {
            get { return _adminDistrict2; }
            set { _adminDistrict2 = value; }
        }
        

        private string _countryRegion;

        public string CountryRegion
        {
            get { return _countryRegion; }
            set { _countryRegion = value; }
        }

        private List<Organization> _organizations;

        public virtual List<Organization> Organizations
        {
            get { return _organizations; }
            set { _organizations = value; }
        }
        
        
    }
}
