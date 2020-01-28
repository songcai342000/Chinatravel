using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using System.Data.SqlClient;
using System.Threading;
using System.Collections;

namespace Customers
{
    [Serializable]
    public class customercollection: Idrepositorybase
    {
        #region variables
        private static string myTableName = "Customerinfo";

        public static int count = 0;
         #endregion

        #region constructor
        public customercollection()
            : base()
        { }
 
        public customercollection(int Id)
            : base(Id)
        { }


        #endregion

        #region override methods
        protected override string TableName
        {
            get
            {
                return myTableName;
            }
        }

        /// <summary>
        /// Add, Delete, Update methods for updating database, objects data are first mapped to a datarow's data
        /// </summary>
        /// <param name="Record"></param>
        public override void Add(IId Id)
        {
            base.Add(Id);
            if (Id is customer)
            {
                customer thecustomer = Id as customer;
                this.Row["Id"] = thecustomer.Id;
                this.Row["Ordernumber"] = thecustomer.Ordernumber;
                this.Row["Name"] = thecustomer.Name;
                this.Row["Sunname"] = thecustomer.Sunname;
                this.Row["Fødelsdato"] = thecustomer.Fødelsdato;
                this.Row["Location"] = thecustomer.Location;
                this.Row["Gender"] = thecustomer.Gender;
                this.Row["Address"] = thecustomer.Address;
                this.Row["Mobil"] = thecustomer.Mobil;
                this.Row["Status"] = thecustomer.Status;

            }
        }

        public override void Delete(IId Id)
        {
            base.Delete(Id);
        }

        public override void Update(IId Id)
        {
            base.Update(Id);
            if (Id is customer)
            {
                customer thecustomer = Id as customer;
                this.Row["Id"] = thecustomer.Id;
                this.Row["Ordernumber"] = thecustomer.Ordernumber;
                this.Row["Name"] = thecustomer.Name;
                this.Row["Sunname"] = thecustomer.Sunname;
                this.Row["Fødelsdato"] = thecustomer.Fødelsdato;
                this.Row["Location"] = thecustomer.Location;
                this.Row["Gender"] = thecustomer.Gender;
                this.Row["Address"] = thecustomer.Address;
                this.Row["Mobil"] = thecustomer.Mobil;
                this.Row["Status"] = thecustomer.Status;

            }
        }

        #endregion

        #region non-override Usernamee methods
        /// <summary>
        /// add a mail object to the out-mail list
        /// </summary>
        /// <param name="outnew"></param>
        public DataTable GetAllCustomersByOrdernumber(int ordernumber)
        {
            DataTable mytable = dataAccess.GetAllCustomersByOrdernumber(ordernumber, SqlAd);
            return mytable;
        }
     
        public DataTable GetNewCustomersByOrdernumber(int ordernumber)
        {
            DataTable mytable = dataAccess.GetNewCustomersByOrdernumber(ordernumber, SqlAd);
            return mytable;
        }

        public DataTable GetPendingCustomersByOrdernumber(int ordernumber)
        {
            DataTable mytable = dataAccess.GetPendingCustomersByOrdernumber(ordernumber, SqlAd);
            return mytable;
        }

        //create History id
        public int CreateCustomerId()
        {
            int id = dataAccess.GetId(TableName, SqlAd);
            return id;
        }

        //create History id
        public void Updatenewcustomer(int id, string name, string sunname, string fødelsdato, string gender, string address)
        {
            dataAccess.UpdateCustomerById(id, name, sunname, fødelsdato, gender, address, SqlAd);
        }
     
        #endregion


    }
}
