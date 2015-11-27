using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class CurveHeaderInfo_Table_DAO
    {
        public CurveHeaderInfo_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string CURVE_CODE_ { get; set; }
        public string CURVE_NAME_ { get; set; }
        public string CURVE_CLASS_ { get; set; }
        public string DISCRIPTION_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT CURVE_CODE, CURVE_NAME, CURVE_CLASS, DISCRIPTION " +
         "FROM CurveHeaderInfo WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO CurveHeaderInfo (CURVE_CODE, CURVE_NAME, CURVE_CLASS, DISCRIPTION )" +
        "VALUES ('@CURVE_CODEVALUE@', '@CURVE_NAMEVALUE@', '@CURVE_CLASSVALUE@', '@DISCRIPTIONVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE CurveHeaderInfo SET CURVE_CODE='@CURVE_CODEVALUE@' CURVE_NAME='@CURVE_NAMEVALUE@' CURVE_CLASS='@CURVE_CLASSVALUE@' DISCRIPTION='@DISCRIPTIONVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM CurveHeaderInfo WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.CURVE_CODE_ = dataRow["CURVE_CODE"].ToString();
            this.CURVE_NAME_ = dataRow["CURVE_NAME"].ToString();
            this.CURVE_CLASS_ = dataRow["CURVE_CLASS"].ToString();
            this.DISCRIPTION_ = dataRow["DISCRIPTION"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = CurveHeaderInfo_Table_DAO.SelectQuery_;

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
                this.CURVE_CODE_ = item[0].ToString();
                this.CURVE_NAME_ = item[1].ToString();
                this.CURVE_CLASS_ = item[2].ToString();
                this.DISCRIPTION_ = item[3].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = CurveHeaderInfo_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@CURVE_CODEVALUE@", CURVE_CODE_);
            insertQuery = insertQuery.Replace("@CURVE_NAMEVALUE@", CURVE_NAME_);
            insertQuery = insertQuery.Replace("@CURVE_CLASSVALUE@", CURVE_CLASS_);
            insertQuery = insertQuery.Replace("@DISCRIPTIONVALUE@", DISCRIPTION_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = CurveHeaderInfo_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@CURVE_CODEVALUE@", CURVE_CODE_);
            updateQuery = updateQuery.Replace("@CURVE_NAMEVALUE@", CURVE_NAME_);
            updateQuery = updateQuery.Replace("@CURVE_CLASSVALUE@", CURVE_CLASS_);
            updateQuery = updateQuery.Replace("@DISCRIPTIONVALUE@", DISCRIPTION_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = CurveHeaderInfo_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
