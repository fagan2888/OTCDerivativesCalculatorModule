using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class CURVE_DATA_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<CURVE_DATA_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string CURVE_DATE_;
        public string CURVE_CODE_;
        public string TENOR_;
        public string VALUE_;
        public string CURVE_TYPE_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT CURVE_DATE, CURVE_CODE, TENOR, VALUE, CURVE_TYPE " +
         "FROM CURVE_DATA WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM CURVE_DATA WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<CURVE_DATA_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = CURVE_DATA_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                CURVE_DATA_Table_DAO dao = new CURVE_DATA_Table_DAO();

                dao.CURVE_DATE_ = item[0].ToString();
                dao.CURVE_CODE_ = item[1].ToString();
                dao.TENOR_ = item[2].ToString();
                dao.VALUE_ = item[3].ToString();
                dao.CURVE_TYPE_ = item[4].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = CURVE_DATA_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
