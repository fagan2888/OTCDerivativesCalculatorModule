using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class TYPE_VARIABLE_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<TYPE_VARIABLE_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string TYPE_CODE_;
        public string TYPE_NAME_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT TYPE_CODE, TYPE_NAME " +
         "FROM TYPE_VARIABLE WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM TYPE_VARIABLE WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<TYPE_VARIABLE_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = TYPE_VARIABLE_Table_DAOManager.SelectQuery_;

            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                TYPE_VARIABLE_Table_DAO dao = new TYPE_VARIABLE_Table_DAO();

                dao.TYPE_CODE_ = item[0].ToString();
                dao.TYPE_NAME_ = item[1].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = TYPE_VARIABLE_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
