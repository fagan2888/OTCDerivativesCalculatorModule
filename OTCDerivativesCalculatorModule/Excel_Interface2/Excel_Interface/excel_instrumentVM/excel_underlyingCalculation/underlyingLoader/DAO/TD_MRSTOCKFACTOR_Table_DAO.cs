using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class TD_MRSTOCKFACTOR_Table_DAO
    {
        public TD_MRSTOCKFACTOR_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string STD_DATE_ { get; set; }
        public string STOCK_ID_ { get; set; }
        public string STOCK_NAME_ { get; set; }
        public string CURR_PRICE_ { get; set; }
        public string DIVIDEND_RATE_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT STD_DATE, STOCK_ID, STOCK_NAME, CURR_PRICE, DIVIDEND_RATE " +
         "FROM TD_MRSTOCKFACTOR WHERE STOCK_ID = '@STOCK_IDValue@'";

        private static string Select_ID_Date_Query_
        = "SELECT STD_DATE, STOCK_ID, STOCK_NAME, CURR_PRICE, DIVIDEND_RATE " +
         "FROM TD_MRSTOCKFACTOR WHERE STD_DATE = '@STD_DATEValue@'  AND STOCK_ID = '@STOCK_IDValue@'";

        private static string InsertQuery_
        = "INSERT INTO TD_MRSTOCKFACTOR (STD_DATE, STOCK_ID, STOCK_NAME, CURR_PRICE, DIVIDEND_RATE )" +
        "VALUES ('@STD_DATEVALUE@', '@STOCK_IDVALUE@', '@STOCK_NAMEVALUE@', '@CURR_PRICEVALUE@', '@DIVIDEND_RATEVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE TD_MRSTOCKFACTOR SET STD_DATE='@STD_DATEVALUE@' STOCK_ID='@STOCK_IDVALUE@' STOCK_NAME='@STOCK_NAMEVALUE@' CURR_PRICE='@CURR_PRICEVALUE@' DIVIDEND_RATE='@DIVIDEND_RATEVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM TD_MRSTOCKFACTOR WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.STD_DATE_ = dataRow["STD_DATE"].ToString();
            this.STOCK_ID_ = dataRow["STOCK_ID"].ToString();
            this.STOCK_NAME_ = dataRow["STOCK_NAME"].ToString();
            this.CURR_PRICE_ = dataRow["CURR_PRICE"].ToString();
            this.DIVIDEND_RATE_ = dataRow["DIVIDEND_RATE"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                DbCommand dbCommand = conn.CreateCommand();

                string selectQuery = TD_MRSTOCKFACTOR_Table_DAO.SelectQuery_;

                selectQuery = selectQuery.Replace("@STOCK_IDValue@", this.STOCK_ID_);

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
                    this.STD_DATE_ = item[0].ToString();
                    this.STOCK_ID_ = item[1].ToString();
                    this.STOCK_NAME_ = item[2].ToString();
                    this.CURR_PRICE_ = item[3].ToString();
                    this.DIVIDEND_RATE_ = item[4].ToString();
                }

                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
            
        }

        public void select_ID_Date(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                DbCommand dbCommand = conn.CreateCommand();

                string select_ID_Date_Query = TD_MRSTOCKFACTOR_Table_DAO.Select_ID_Date_Query_;

                select_ID_Date_Query = select_ID_Date_Query.Replace("@STD_DATEValue@", this.STD_DATE_);
                select_ID_Date_Query = select_ID_Date_Query.Replace("@STOCK_IDValue@", this.STOCK_ID_);

                dbCommand.CommandText = select_ID_Date_Query;

                //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
                DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

                dataAdapter.Fill(tb);

                DataRow[] dr = tb.Select();
                int rowCount = dr.Length;

                if (!(rowCount == 0 || rowCount == 1))
                { throw new Exception(); }

                foreach (DataRow item in dr)
                {
                    this.STD_DATE_ = item[0].ToString();
                    this.STOCK_ID_ = item[1].ToString();
                    this.STOCK_NAME_ = item[2].ToString();
                    this.CURR_PRICE_ = item[3].ToString();
                    this.DIVIDEND_RATE_ = item[4].ToString();
                }

                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }

        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();


            try
            {
                DbCommand dbCommand = conn.CreateCommand();

                string insertQuery = TD_MRSTOCKFACTOR_Table_DAO.InsertQuery_;

                insertQuery = insertQuery.Replace("@STD_DATEVALUE@", STD_DATE_);
                insertQuery = insertQuery.Replace("@STOCK_IDVALUE@", STOCK_ID_);
                insertQuery = insertQuery.Replace("@STOCK_NAMEVALUE@", STOCK_NAME_);
                insertQuery = insertQuery.Replace("@CURR_PRICEVALUE@", CURR_PRICE_);
                insertQuery = insertQuery.Replace("@DIVIDEND_RATEVALUE@", DIVIDEND_RATE_);


                dbCommand.CommandText = insertQuery;

                dbCommand.ExecuteNonQuery();
            
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = TD_MRSTOCKFACTOR_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@STD_DATEVALUE@", STD_DATE_);
            updateQuery = updateQuery.Replace("@STOCK_IDVALUE@", STOCK_ID_);
            updateQuery = updateQuery.Replace("@STOCK_NAMEVALUE@", STOCK_NAME_);
            updateQuery = updateQuery.Replace("@CURR_PRICEVALUE@", CURR_PRICE_);
            updateQuery = updateQuery.Replace("@DIVIDEND_RATEVALUE@", DIVIDEND_RATE_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = TD_MRSTOCKFACTOR_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
