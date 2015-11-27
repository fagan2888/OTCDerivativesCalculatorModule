using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class CURVETENOR_INFO_Table_DAO
    {
        public CURVETENOR_INFO_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string CURVE_CODE_ { get; set; }
        public string CURVE_NAME_ { get; set; }
        public string TENORLIST_ { get; set; }
        public string UPDATE_DATE_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT CURVE_CODE, CURVE_NAME, TENORLIST, UPDATE_DATE " +
         "FROM CURVETENOR_INFO WHERE CURVE_CODE = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO CURVETENOR_INFO (CURVE_CODE, CURVE_NAME, TENORLIST, UPDATE_DATE )" +
        "VALUES ('@CURVE_CODEVALUE@', '@CURVE_NAMEVALUE@', '@TENORLISTVALUE@', '@UPDATE_DATEVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE CURVETENOR_INFO SET CURVE_CODE='@CURVE_CODEVALUE@' CURVE_NAME='@CURVE_NAMEVALUE@' TENORLIST='@TENORLISTVALUE@' UPDATE_DATE='@UPDATE_DATEVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM CURVETENOR_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.CURVE_CODE_ = dataRow["CURVE_CODE"].ToString();
            this.CURVE_NAME_ = dataRow["CURVE_NAME"].ToString();
            this.TENORLIST_ = dataRow["TENORLIST"].ToString();
            this.UPDATE_DATE_ = dataRow["UPDATE_DATE"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = CURVETENOR_INFO_Table_DAO.SelectQuery_;

            selectQuery = selectQuery.Replace("@KeyColumnValue@", this.CURVE_CODE_);

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
                this.CURVE_CODE_ = item[0].ToString();
                this.CURVE_NAME_ = item[1].ToString();
                this.TENORLIST_ = item[2].ToString();
                this.UPDATE_DATE_ = item[3].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = CURVETENOR_INFO_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@CURVE_CODEVALUE@", CURVE_CODE_);
            insertQuery = insertQuery.Replace("@CURVE_NAMEVALUE@", CURVE_NAME_);
            insertQuery = insertQuery.Replace("@TENORLISTVALUE@", TENORLIST_);
            insertQuery = insertQuery.Replace("@UPDATE_DATEVALUE@", UPDATE_DATE_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = CURVETENOR_INFO_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@CURVE_CODEVALUE@", CURVE_CODE_);
            updateQuery = updateQuery.Replace("@CURVE_NAMEVALUE@", CURVE_NAME_);
            updateQuery = updateQuery.Replace("@TENORLISTVALUE@", TENORLIST_);
            updateQuery = updateQuery.Replace("@UPDATE_DATEVALUE@", UPDATE_DATE_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = CURVETENOR_INFO_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
