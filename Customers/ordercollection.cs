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
    public class ordercollection: Idrepositorybase
    {
        #region variables
        private static string myTableName = "Orderinfo";
        public static int count = 0;
         #endregion

        #region constructor
        public ordercollection()
            : base()
        { }

        public ordercollection(int Id)
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
            if (Id is order)
            {
                order theOrder = Id as order;
                this.Row["Id"] = theOrder.Id;
                this.Row["Ordernumber"] = theOrder.Ordernumber;
                this.Row["Routenumber"] = theOrder.Routenumber;
                this.Row["Name"] = theOrder.Name;
                this.Row["Epost"] = theOrder.Epost;
                this.Row["Mobil"] = theOrder.Mobil;
                this.Row["Address"] = theOrder.Address;
                this.Row["Adultnumber"] = theOrder.Adultnumber;
                this.Row["Childrennumber"] = theOrder.Childrennumber;
                this.Row["Babynumber"] = theOrder.Babynumber;
                this.Row["Forlengelse"] = theOrder.Forlengelse;
                this.Row["Ordertime"] = theOrder.Ordertime;
                this.Row["Ip"] = theOrder.Ip;
                this.Row["Status"] = theOrder.Status;
                this.Row["Tilleggsinformasjon"] = theOrder.Tilleggsinformasjon;
            }
        }

        public override void Delete(IId Id)
        {
            base.Delete(Id);
        }

        public override void Update(IId Id)
        {
            base.Update(Id);
            if (Id is order)
            {
                order theOrder = Id as order;
                this.Row["Id"] = theOrder.Id;
                this.Row["Ordernumber"] = theOrder.Ordernumber;
                this.Row["Routenumber"] = theOrder.Routenumber;
                this.Row["Name"] = theOrder.Name;
                this.Row["Epost"] = theOrder.Epost;
                this.Row["Mobil"] = theOrder.Mobil;
                this.Row["Address"] = theOrder.Address;
                this.Row["Adultnumber"] = theOrder.Adultnumber;
                this.Row["Childrennumber"] = theOrder.Childrennumber;
                this.Row["Babynumber"] = theOrder.Babynumber;
                this.Row["Forlengelse"] = theOrder.Forlengelse;
                this.Row["Ordertime"] = theOrder.Ordertime;
                this.Row["Ip"] = theOrder.Ip;
                this.Row["Status"] = theOrder.Status;
                this.Row["Tilleggsinformasjon"] = theOrder.Tilleggsinformasjon;
            }
        }

        #endregion 

        #region non-override Usernamee methods
        /// <summary>
        /// add a mail object to the out-mail list
        /// </summary>
        /// <param name="outnew"></param>
        public DataTable GetOrderByUser(string username)
        {
            DataTable mytable = dataAccess.GetOrderByUsername(username, SqlAd);
            return mytable;
        }

        public DataTable GetOrderByOrdernumber(int ordernumber)
        {
            DataTable mytable = dataAccess.GetOrdersByOrderNumber(ordernumber, SqlAd);
            return mytable;
        }


        public DataTable GetOrdersByRouternumber(string routernumber)
        {
            DataTable mytable = dataAccess.GetOrdersByRouterNumber(routernumber, SqlAd);
            return mytable;
        }

        public DataTable GetOrdersByStatus(string status)
        {
            DataTable mytable = dataAccess.GetOrderByStatus(status, SqlAd);
            return mytable;
        }

        public DataTable GetOrdersByOrdertime(DateTime ordertime)
        {
            DataTable mytable = dataAccess.GetOrdersByOrdertime(ordertime, SqlAd);
            return mytable;
        }

        public void DeleteOrderById(int Id)
        {
           dataAccess.DeleteOrderById(Id, SqlAd);
        }

        public void DeleteOrderByOrdernumber(int ordernumber)
        {
            dataAccess.DeleteOrderByOrdernumber(ordernumber, SqlAd);
        }

        public void DeleteOrderByStatus(string status)
        {
            dataAccess.DeleteOrderByStatus(status, SqlAd);
        }

        public void DeleteOrderByRouternumber(string routernumber)
        {
            dataAccess.DeleteOrderByRouternumber(routernumber, SqlAd);
        }

        public void UpdateTillInforOrderByOrdernumber(string tillinfor, int ordernumber)
        {
            dataAccess.UpdateTillInforOrderByOrder(tillinfor, ordernumber, SqlAd);
        }
        //create History id
        public int CreateOrderId()
        {
            int id = dataAccess.GetId(TableName, SqlAd);
            return id;
        }

        #endregion


    }
}
