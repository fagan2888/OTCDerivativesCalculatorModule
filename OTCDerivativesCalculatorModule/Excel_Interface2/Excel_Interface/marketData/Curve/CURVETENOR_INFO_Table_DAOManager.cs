using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class CURVETENOR_INFO_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<CURVETENOR_INFO_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string CURVE_CODE_;
        public string CURVE_NAME_;
        public string TENORLIST_;
        public string UPDATE_DATE_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT CURVE_CODE, CURVE_NAME, TENORLIST, UPDATE_DATE " +
         "FROM CURVETENOR_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM CURVETENOR_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<CURVETENOR_INFO_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = CURVETENOR_INFO_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                CURVETENOR_INFO_Table_DAO dao = new CURVETENOR_INFO_Table_DAO();

                dao.CURVE_CODE_ = item[0].ToString();
                dao.CURVE_NAME_ = item[1].ToString();
                dao.TENORLIST_ = item[2].ToString();
                dao.UPDATE_DATE_ = item[3].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = CURVETENOR_INFO_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
