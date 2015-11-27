using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class INDEX_DATA_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<INDEX_DATA_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string INDEX_DATE_;
        public string INDEX_CODE_;
        public string INDEX_NAME_;
        public string INDEX_VALUE_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT INDEX_DATE, INDEX_CODE, INDEX_NAME, INDEX_VALUE " +
         "FROM INDEX_DATA WHERE KeyColumn = '@KeyColumnValue@'";

        private static string SelectInterValQuery_
        = "SELECT INDEX_DATE, INDEX_CODE, INDEX_NAME, INDEX_VALUE " +
         "FROM INDEX_DATA WHERE INDEX_CODE = '@KeyColumnValue@' AND INDEX_DATE >= '@StartDateValue@' AND INDEX_DATE <= '@EndDateValue@'";

        private static string DeleteQuery_
        = "DELETE FROM INDEX_DATA WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<INDEX_DATA_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = INDEX_DATA_Table_DAOManager.SelectQuery_;

            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                INDEX_DATA_Table_DAO dao = new INDEX_DATA_Table_DAO();

                dao.INDEX_DATE_ = item[0].ToString();
                dao.INDEX_CODE_ = item[1].ToString();
                dao.INDEX_NAME_ = item[2].ToString();
                dao.INDEX_VALUE_ = item[3].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void selectInterval(DbConnection conn, DateTime startDate, DateTime endDate)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<INDEX_DATA_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string SelectInterValQuery_ = INDEX_DATA_Table_DAOManager.SelectInterValQuery_;

            SelectInterValQuery_ = SelectInterValQuery_.Replace("@KeyColumnValue@", this.INDEX_CODE_);
            SelectInterValQuery_ = SelectInterValQuery_.Replace("@StartDateValue@", startDate.ToString(StringFormat.DbDateFormat_));
            SelectInterValQuery_ = SelectInterValQuery_.Replace("@EndDateValue@", endDate.ToString(StringFormat.DbDateFormat_));

            dbCommand.CommandText = SelectInterValQuery_;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                INDEX_DATA_Table_DAO dao = new INDEX_DATA_Table_DAO();

                dao.INDEX_DATE_ = item[0].ToString();
                dao.INDEX_CODE_ = item[1].ToString();
                dao.INDEX_NAME_ = item[2].ToString();
                dao.INDEX_VALUE_ = item[3].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = INDEX_DATA_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
