using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customers
{
    [Serializable]
    public class order : Idbase
    {

        #region properites

        private DateTime ordertime;
        public DateTime Ordertime
        {
            get
            {
                return ordertime;
            }
            set
            {
                ordertime = value;
            }
        }

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

        private string routenumber;
        public string Routenumber
        {
            get
            {
                return routenumber;
            }
            set
            {
                routenumber = value;
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

        private string epost;
        public string Epost
        {
            get
            {
                return epost;
            }
            set
            {
                epost = value;
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


        private int adultnumber;
        public int Adultnumber
        {
            get
            {
                return adultnumber;
            }
            set
            {
                adultnumber = value;
            }
        }

        private int childrennumber;
        public int Childrennumber
        {
            get
            {
                return childrennumber;
            }
            set
            {
                childrennumber = value;
            }
        }

        private int babynumber;
        public int Babynumber
        {
            get
            {
                return babynumber;
            }
            set
            {
                babynumber = value;
            }
        }

        private string ip;
        public string Ip
        {
            get
            {
                return ip;
            }
            set
            {
                ip = value;
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

        private string forlengelse;
        public string Forlengelse
        {
            get
            {
                return forlengelse;
            }
            set
            {
                forlengelse = value;
            }
        }

        private string tilleggsinformasjon;
        public string Tilleggsinformasjon
        {
            get
            {
                return tilleggsinformasjon;
            }
            set
            {
                tilleggsinformasjon = value;
            }
        }
        #endregion

        #region constructor
        public order() : base() { }
        public order(int Id, int Ordernumber, string Routenumber, string Name, string Epost, string Mobil, string Address, int Adultnumber, int Childrennumber, int Babynumber, string Forlengelse, DateTime Ordertime, string Ip, string Status, string Tilleggsinformasjon)
            : base(Id)
        {
            ordernumber = Ordernumber;
            routenumber = Routenumber;
            name = Name;
            epost = Epost;
            mobil = Mobil;
            address = Address;
            adultnumber = Adultnumber;
            childrennumber = Childrennumber;
            babynumber = Babynumber;
            forlengelse = Forlengelse;
            ordertime = Ordertime;
            ip = Ip;
            status = Status;
            tilleggsinformasjon = Tilleggsinformasjon;
        }
        #endregion
    }
}
