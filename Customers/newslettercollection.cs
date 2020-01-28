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
    public class newslettercollection: Idrepositorybase
    {
        #region variables
        private static string myTableName = "Newsletterinfo";

        public static int count = 0;
         #endregion

        #region constructor
        public newslettercollection()
            : base()
        { }
 
        public newslettercollection(int Id)
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
            if (Id is newsletter)
            {
                newsletter thenewsletter = Id as newsletter;
                this.Row["Id"] = thenewsletter.Id;
                this.Row["Epost"] = thenewsletter.Epost;
                this.Row["Pensjonist"] = thenewsletter.Pensjonist;

            }
        }

        public override void Delete(IId Id)
        {
            base.Delete(Id);
        }

        public override void Update(IId Id)
        {
            base.Update(Id);
            if (Id is newsletter)
            {
                newsletter thenewsletter = Id as newsletter;
                this.Row["Id"] = thenewsletter.Id;
                this.Row["Epost"] = thenewsletter.Epost;
                this.Row["Pensjonist"] = thenewsletter.Pensjonist;

            }
        }

        #endregion

        #region non-override Usernamee methods
        /// <summary>
        /// add a mail object to the out-mail list
        /// </summary>
        /// <param name="outnew"></param>
  

        //create History id
        public int CreateLetterId()
        {
            int id = dataAccess.GetId(TableName, SqlAd);
            return id;
        }

     
        //get History by id
        public DataTable DeleteByEpost(string epost)
        {
            DataTable mytable = dataAccess.DeleteNewsLetterByEpost(epost, SqlAd);
            return mytable;
        }

     
        #endregion


    }
}
