using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class DISCOUNTCURVESETTING_Table_DAO
    {
        public DISCOUNTCURVESETTING_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string CURRENCY_ { get; set; }
        public string CURVECODE_ { get; set; }
        public string PROVIDER_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT CURRENCY, CURVECODE, PROVIDER " +
         "FROM DISCOUNTCURVESETTING WHERE CURRENCY = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO DISCOUNTCURVESETTING (CURRENCY, CURVECODE, PROVIDER )" +
        "VALUES ('@CURRENCYVALUE@', '@CURVECODEVALUE@', '@PROVIDERVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE DISCOUNTCURVESETTING SET CURRENCY='@CURRENCYVALUE@' CURVECODE='@CURVECODEVALUE@' PROVIDER='@PROVIDERVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM DISCOUNTCURVESETTING WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.CURRENCY_ = dataRow["CURRENCY"].ToString();
            this.CURVECODE_ = dataRow["CURVECODE"].ToString();
            this.PROVIDER_ = dataRow["PROVIDER"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = DISCOUNTCURVESETTING_Table_DAO.SelectQuery_;

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
                this.CURRENCY_ = item[0].ToString();
                this.CURVECODE_ = item[1].ToString();
                this.PROVIDER_ = item[2].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = DISCOUNTCURVESETTING_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@CURRENCYVALUE@", CURRENCY_);
            insertQuery = insertQuery.Replace("@CURVECODEVALUE@", CURVECODE_);
            insertQuery = insertQuery.Replace("@PROVIDERVALUE@", PROVIDER_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = DISCOUNTCURVESETTING_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@CURRENCYVALUE@", CURRENCY_);
            updateQuery = updateQuery.Replace("@CURVECODEVALUE@", CURVECODE_);
            updateQuery = updateQuery.Replace("@PROVIDERVALUE@", PROVIDER_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = DISCOUNTCURVESETTING_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
