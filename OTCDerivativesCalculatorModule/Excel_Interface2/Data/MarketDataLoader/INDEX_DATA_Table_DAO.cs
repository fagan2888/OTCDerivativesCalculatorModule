using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class INDEX_DATA_Table_DAO
    {
        public INDEX_DATA_Table_DAO() { }

        public string KeyColumn1_ { get; set; } // INDEX_DATE_
        public string KeyColumn2_ { get; set; } // INDEX_CODE_

        #region Properties

        public string INDEX_DATE_ { get; set; }
        public string INDEX_CODE_ { get; set; }
        public string INDEX_NAME_ { get; set; }
        public string INDEX_VALUE_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT INDEX_DATE, INDEX_CODE, INDEX_NAME, INDEX_VALUE " +
         "FROM INDEX_DATA WHERE INDEX_DATE = '@KeyColumnValue1@' AND INDEX_CODE = '@KeyColumnValue2@'";

        private static string InsertQuery_
        = "INSERT INTO INDEX_DATA (INDEX_DATE, INDEX_CODE, INDEX_NAME, INDEX_VALUE )" +
        "VALUES ('@INDEX_DATEVALUE@', '@INDEX_CODEVALUE@', '@INDEX_NAMEVALUE@', '@INDEX_VALUEVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE INDEX_DATA SET INDEX_DATE='@INDEX_DATEVALUE@' INDEX_CODE='@INDEX_CODEVALUE@' INDEX_NAME='@INDEX_NAMEVALUE@' INDEX_VALUE='@INDEX_VALUEVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM INDEX_DATA WHERE INDEX_DATE = '@KeyColumnValue1@' AND INDEX_CODE = '@KeyColumnValue2@'";

        private static string DeleteIndexQuery_
        = "DELETE FROM INDEX_DATA WHERE INDEX_CODE = '@KeyColumnValue2@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.INDEX_DATE_ = dataRow["INDEX_DATE"].ToString();
            this.INDEX_CODE_ = dataRow["INDEX_CODE"].ToString();
            this.INDEX_NAME_ = dataRow["INDEX_NAME"].ToString();
            this.INDEX_VALUE_ = dataRow["INDEX_VALUE"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = INDEX_DATA_Table_DAO.SelectQuery_;

            selectQuery = selectQuery.Replace("@KeyColumnValue1@", this.INDEX_DATE_);
            selectQuery = selectQuery.Replace("@KeyColumnValue2@", this.INDEX_CODE_);

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
                this.INDEX_DATE_ = item[0].ToString();
                this.INDEX_CODE_ = item[1].ToString();
                this.INDEX_NAME_ = item[2].ToString();
                this.INDEX_VALUE_ = item[3].ToString();
            }

        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = INDEX_DATA_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@INDEX_DATEVALUE@", INDEX_DATE_);
            insertQuery = insertQuery.Replace("@INDEX_CODEVALUE@", INDEX_CODE_);
            insertQuery = insertQuery.Replace("@INDEX_NAMEVALUE@", INDEX_NAME_);
            insertQuery = insertQuery.Replace("@INDEX_VALUEVALUE@", INDEX_VALUE_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = INDEX_DATA_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@INDEX_DATEVALUE@", INDEX_DATE_);
            updateQuery = updateQuery.Replace("@INDEX_CODEVALUE@", INDEX_CODE_);
            updateQuery = updateQuery.Replace("@INDEX_NAMEVALUE@", INDEX_NAME_);
            updateQuery = updateQuery.Replace("@INDEX_VALUEVALUE@", INDEX_VALUE_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = INDEX_DATA_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue1@", this.KeyColumn1_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void deleteIndex(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteIndexQuery = INDEX_DATA_Table_DAO.DeleteIndexQuery_;

            deleteIndexQuery = deleteIndexQuery.Replace("@KeyColumnValue2@", this.KeyColumn2_);

            dbCommand.CommandText = deleteIndexQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
