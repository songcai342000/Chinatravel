using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customers
{
    [Serializable]
    public class customer: Idbase
    {
     #region properites
  
        private int ordernumber;
        public int Ordernumber
        {
            get
            {
                return ordernumber;
            }
            set
            {
                ordernumber = value;
            }
        }
       
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string sunname;
        public string Sunname
        {
            get
            {
                return sunname;
            }
            set
            {
                sunname = value;
            }
        }

        private string fødelsdato;
        public string Fødelsdato
        {
            get
            {
                return fødelsdato;
            }
            set
            {
                fødelsdato = value;
            }
        }

        private string gender;
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        private string mobil;
        public string Mobil
        {
            get
            {
                return mobil;
            }
            set
            {
                mobil = value;
            }
        }

        private string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        
      
        private string location;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }


        private string status;
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

       

        #endregion

    #region constructor
        public customer() : base() { }
        public customer(int Id, int Ordernumber, string Name, string Sunname, string Fødelsdato, string Location, string Gender, string Address, string Mobil, string Status)
            : base(Id)
        {
            ordernumber = Ordernumber;
            name = Name;
            sunname = Sunname;
            fødelsdato = Fødelsdato;
            location = Location;
            gender = Gender;
            address = Address;
            mobil = Mobil;
            status = Status;
        }
        #endregion
    }
}
