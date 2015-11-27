using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class POSITION_PL_Table_DAO
    {
        public POSITION_PL_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string ITEM_CODE_ { get; set; }
        public string TRADE_ID_ { get; set; }
        public string NOTIONAL_ { get; set; }
        public string REMAIN_NOTIONAL_ { get; set; }
        public string BOOK_PRICE_ { get; set; }
        public string BOOK_NOTIONAL_ { get; set; }
        public string EVAL_PRICE_ { get; set; }
        public string BOOK_PL_ { get; set; }
        public string TOTAL_EVAL_PL_ { get; set; }
        public string DAILY_EVAL_PL_ { get; set; }
        public string TRADE_PL_ { get; set; }
        public string TOTAL_PL_ { get; set; }
        public string ETC_PL_ { get; set; }
        public string STD_DATE_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT ITEM_CODE, TRADE_ID, NOTIONAL, REMAIN_NOTIONAL, BOOK_PRICE, BOOK_NOTIONAL, EVAL_PRICE, BOOK_PL, TOTAL_EVAL_PL, DAILY_EVAL_PL, TRADE_PL, TOTAL_PL, ETC_PL, STD_DATE " +
         "FROM POSITION_PL WHERE TRADE_ID = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO POSITION_PL (ITEM_CODE, TRADE_ID, NOTIONAL, REMAIN_NOTIONAL, BOOK_PRICE, BOOK_NOTIONAL, EVAL_PRICE, BOOK_PL, TOTAL_EVAL_PL, DAILY_EVAL_PL, TRADE_PL, TOTAL_PL, ETC_PL, STD_DATE )" +
        "VALUES ('@ITEM_CODEVALUE@', '@TRADE_IDVALUE@', '@NOTIONALVALUE@', '@REMAIN_NOTIONALVALUE@', '@BOOK_PRICEVALUE@', '@BOOK_NOTIONALVALUE@', '@EVAL_PRICEVALUE@', '@BOOK_PLVALUE@', '@TOTAL_EVAL_PLVALUE@', '@DAILY_EVAL_PLVALUE@', '@TRADE_PLVALUE@', '@TOTAL_PLVALUE@', '@ETC_PLVALUE@', '@STD_DATEVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE POSITION_PL SET ITEM_CODE='@ITEM_CODEVALUE@' TRADE_ID='@TRADE_IDVALUE@' NOTIONAL='@NOTIONALVALUE@' REMAIN_NOTIONAL='@REMAIN_NOTIONALVALUE@' BOOK_PRICE='@BOOK_PRICEVALUE@' BOOK_NOTIONAL='@BOOK_NOTIONALVALUE@' EVAL_PRICE='@EVAL_PRICEVALUE@' BOOK_PL='@BOOK_PLVALUE@' TOTAL_EVAL_PL='@TOTAL_EVAL_PLVALUE@' DAILY_EVAL_PL='@DAILY_EVAL_PLVALUE@' TRADE_PL='@TRADE_PLVALUE@' TOTAL_PL='@TOTAL_PLVALUE@' ETC_PL='@ETC_PLVALUE@' STD_DATE='@STD_DATEVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM POSITION_PL WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.ITEM_CODE_ = dataRow["ITEM_CODE"].ToString();
            this.TRADE_ID_ = dataRow["TRADE_ID"].ToString();
            this.NOTIONAL_ = dataRow["NOTIONAL"].ToString();
            this.REMAIN_NOTIONAL_ = dataRow["REMAIN_NOTIONAL"].ToString();
            this.BOOK_PRICE_ = dataRow["BOOK_PRICE"].ToString();
            this.BOOK_NOTIONAL_ = dataRow["BOOK_NOTIONAL"].ToString();
            this.EVAL_PRICE_ = dataRow["EVAL_PRICE"].ToString();
            this.BOOK_PL_ = dataRow["BOOK_PL"].ToString();
            this.TOTAL_EVAL_PL_ = dataRow["TOTAL_EVAL_PL"].ToString();
            this.DAILY_EVAL_PL_ = dataRow["DAILY_EVAL_PL"].ToString();
            this.TRADE_PL_ = dataRow["TRADE_PL"].ToString();
            this.TOTAL_PL_ = dataRow["TOTAL_PL"].ToString();
            this.ETC_PL_ = dataRow["ETC_PL"].ToString();
            this.STD_DATE_ = dataRow["STD_DATE"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = POSITION_PL_Table_DAO.SelectQuery_;

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
                this.ITEM_CODE_ = item[0].ToString();
                this.TRADE_ID_ = item[1].ToString();
                this.NOTIONAL_ = item[2].ToString();
                this.REMAIN_NOTIONAL_ = item[3].ToString();
                this.BOOK_PRICE_ = item[4].ToString();
                this.BOOK_NOTIONAL_ = item[5].ToString();
                this.EVAL_PRICE_ = item[6].ToString();
                this.BOOK_PL_ = item[7].ToString();
                this.TOTAL_EVAL_PL_ = item[8].ToString();
                this.DAILY_EVAL_PL_ = item[9].ToString();
                this.TRADE_PL_ = item[10].ToString();
                this.TOTAL_PL_ = item[11].ToString();
                this.ETC_PL_ = item[12].ToString();
                this.STD_DATE_ = item[13].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = POSITION_PL_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@ITEM_CODEVALUE@", ITEM_CODE_);
            insertQuery = insertQuery.Replace("@TRADE_IDVALUE@", TRADE_ID_);
            insertQuery = insertQuery.Replace("@NOTIONALVALUE@", NOTIONAL_);
            insertQuery = insertQuery.Replace("@REMAIN_NOTIONALVALUE@", REMAIN_NOTIONAL_);
            insertQuery = insertQuery.Replace("@BOOK_PRICEVALUE@", BOOK_PRICE_);
            insertQuery = insertQuery.Replace("@BOOK_NOTIONALVALUE@", BOOK_NOTIONAL_);
            insertQuery = insertQuery.Replace("@EVAL_PRICEVALUE@", EVAL_PRICE_);
            insertQuery = insertQuery.Replace("@BOOK_PLVALUE@", BOOK_PL_);
            insertQuery = insertQuery.Replace("@TOTAL_EVAL_PLVALUE@", TOTAL_EVAL_PL_);
            insertQuery = insertQuery.Replace("@DAILY_EVAL_PLVALUE@", DAILY_EVAL_PL_);
            insertQuery = insertQuery.Replace("@TRADE_PLVALUE@", TRADE_PL_);
            insertQuery = insertQuery.Replace("@TOTAL_PLVALUE@", TOTAL_PL_);
            insertQuery = insertQuery.Replace("@ETC_PLVALUE@", ETC_PL_);
            insertQuery = insertQuery.Replace("@STD_DATEVALUE@", STD_DATE_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = POSITION_PL_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@ITEM_CODEVALUE@", ITEM_CODE_);
            updateQuery = updateQuery.Replace("@TRADE_IDVALUE@", TRADE_ID_);
            updateQuery = updateQuery.Replace("@NOTIONALVALUE@", NOTIONAL_);
            updateQuery = updateQuery.Replace("@REMAIN_NOTIONALVALUE@", REMAIN_NOTIONAL_);
            updateQuery = updateQuery.Replace("@BOOK_PRICEVALUE@", BOOK_PRICE_);
            updateQuery = updateQuery.Replace("@BOOK_NOTIONALVALUE@", BOOK_NOTIONAL_);
            updateQuery = updateQuery.Replace("@EVAL_PRICEVALUE@", EVAL_PRICE_);
            updateQuery = updateQuery.Replace("@BOOK_PLVALUE@", BOOK_PL_);
            updateQuery = updateQuery.Replace("@TOTAL_EVAL_PLVALUE@", TOTAL_EVAL_PL_);
            updateQuery = updateQuery.Replace("@DAILY_EVAL_PLVALUE@", DAILY_EVAL_PL_);
            updateQuery = updateQuery.Replace("@TRADE_PLVALUE@", TRADE_PL_);
            updateQuery = updateQuery.Replace("@TOTAL_PLVALUE@", TOTAL_PL_);
            updateQuery = updateQuery.Replace("@ETC_PLVALUE@", ETC_PL_);
            updateQuery = updateQuery.Replace("@STD_DATEVALUE@", STD_DATE_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = POSITION_PL_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
