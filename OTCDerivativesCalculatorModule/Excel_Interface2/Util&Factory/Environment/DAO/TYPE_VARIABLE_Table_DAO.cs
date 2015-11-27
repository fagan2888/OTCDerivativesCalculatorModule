using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class TYPE_VARIABLE_Table_DAO
    {
        public TYPE_VARIABLE_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string TYPE_CODE_ { get; set; }
        public string TYPE_NAME_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT TYPE_CODE, TYPE_NAME " +
         "FROM TYPE_VARIABLE WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO TYPE_VARIABLE (TYPE_CODE, TYPE_NAME )" +
        "VALUES ('@TYPE_CODEVALUE@', '@TYPE_NAMEVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE TYPE_VARIABLE SET TYPE_CODE='@TYPE_CODEVALUE@' TYPE_NAME='@TYPE_NAMEVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM TYPE_VARIABLE WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.TYPE_CODE_ = dataRow["TYPE_CODE"].ToString();
            this.TYPE_NAME_ = dataRow["TYPE_NAME"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = TYPE_VARIABLE_Table_DAO.SelectQuery_;

            selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            if (!(rowCount == 0 || rowCount == 1))
            { throw new Exception(); }

            foreach (DataRow item in dr)
            {
                this.TYPE_CODE_ = item[0].ToString();
                this.TYPE_NAME_ = item[1].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = TYPE_VARIABLE_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@TYPE_CODEVALUE@", TYPE_CODE_);
            insertQuery = insertQuery.Replace("@TYPE_NAMEVALUE@", TYPE_NAME_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = TYPE_VARIABLE_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@TYPE_CODEVALUE@", TYPE_CODE_);
            updateQuery = updateQuery.Replace("@TYPE_NAMEVALUE@", TYPE_NAME_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = TYPE_VARIABLE_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
