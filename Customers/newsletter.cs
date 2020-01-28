using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Customers
{
    [Serializable]
    public class newsletter: Idbase
    {
   

     #region properites

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
       
        private string pensjonist;
        public string Pensjonist
        {
            get
            {
                return pensjonist;
            }
            set
            {
                pensjonist = value;
            }
        }

     

        #endregion

    #region constructor
        public newsletter() : base() { }
        public newsletter(int Id, string Epost, string Pensjonist)
            : base(Id)
        {
            epost = Epost;
            pensjonist = Pensjonist;
        }
        #endregion
    }
}
