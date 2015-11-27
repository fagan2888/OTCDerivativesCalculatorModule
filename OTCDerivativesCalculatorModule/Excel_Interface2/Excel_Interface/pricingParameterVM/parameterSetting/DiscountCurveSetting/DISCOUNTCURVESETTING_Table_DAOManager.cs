using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class DISCOUNTCURVESETTING_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<DISCOUNTCURVESETTING_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string CURRENCY_;
        public string CURVECODE_;
        public string PROVIDER_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT CURRENCY, CURVECODE, PROVIDER " +
         "FROM DISCOUNTCURVESETTING WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM DISCOUNTCURVESETTING WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<DISCOUNTCURVESETTING_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = DISCOUNTCURVESETTING_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                DISCOUNTCURVESETTING_Table_DAO dao = new DISCOUNTCURVESETTING_Table_DAO();

                dao.CURRENCY_ = item[0].ToString();
                dao.CURVECODE_ = item[1].ToString();
                dao.PROVIDER_ = item[2].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = DISCOUNTCURVESETTING_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
