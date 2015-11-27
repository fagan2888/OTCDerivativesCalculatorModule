using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class MATSER_INFO_Table_DAO
    {
        public MATSER_INFO_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string ITEM_CODE_ { get; set; }
        public string ITEM_NAME_ { get; set; }
        public string NOTIONAL_ { get; set; }
        public string REMAIN_NOTIONAL_ { get; set; }
        public string CURRENCY_ { get; set; }
        public string TRADE_DATE_ { get; set; }
        public string MATURITY_DATE_ { get; set; }
        public string COUNTERPARTY_ { get; set; }
        public string EXPORT_ITEMCODE_ { get; set; }
        public string TRADE_ID_ { get; set; }
        public string TRADE_STATUS_ { get; set; }
        public string INSTRUMENT_TYPE_ { get; set; }
        public string UNDERLYING_TYPE_ { get; set; }
        public string UNDERLYING_DETAIL_TYPE_ { get; set; }
        public string CONTRACT_TYPE_ { get; set; }
        public string CONTRACT_SUBTYPE_ { get; set; }
        public string CONTRACT_DETAIL_TYPE_ { get; set; }
        public string BOOKING_TYPE_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT ITEM_CODE, ITEM_NAME, NOTIONAL, REMAIN_NOTIONAL, CURRENCY, TRADE_DATE, MATURITY_DATE, COUNTERPARTY, EXPORT_ITEMCODE, TRADE_ID, TRADE_STATUS, INSTRUMENT_TYPE, UNDERLYING_TYPE, UNDERLYING_DETAIL_TYPE, CONTRACT_TYPE, CONTRACT_SUBTYPE, CONTRACT_DETAIL_TYPE, BOOKING_TYPE " +
         "FROM MATSER_INFO WHERE ITEM_CODE = '@ITEM_CODEValue@'";

        private static string InsertQuery_
        = "INSERT INTO MATSER_INFO (ITEM_CODE, ITEM_NAME, NOTIONAL, REMAIN_NOTIONAL, CURRENCY, TRADE_DATE, MATURITY_DATE, COUNTERPARTY, EXPORT_ITEMCODE, TRADE_ID, TRADE_STATUS, INSTRUMENT_TYPE, UNDERLYING_TYPE, UNDERLYING_DETAIL_TYPE, CONTRACT_TYPE, CONTRACT_SUBTYPE, CONTRACT_DETAIL_TYPE, BOOKING_TYPE )" +
        "VALUES ('@ITEM_CODEVALUE@', '@ITEM_NAMEVALUE@', '@NOTIONALVALUE@', '@REMAIN_NOTIONALVALUE@', '@CURRENCYVALUE@', '@TRADE_DATEVALUE@', '@MATURITY_DATEVALUE@', '@COUNTERPARTYVALUE@', '@EXPORT_ITEMCODEVALUE@', '@TRADE_IDVALUE@', '@TRADE_STATUSVALUE@', '@INSTRUMENT_TYPEVALUE@', '@UNDERLYING_TYPEVALUE@', '@UNDERLYING_DETAIL_TYPEVALUE@', '@CONTRACT_TYPEVALUE@', '@CONTRACT_SUBTYPEVALUE@', '@CONTRACT_DETAIL_TYPEVALUE@', '@BOOKING_TYPEVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE MATSER_INFO SET ITEM_CODE='@ITEM_CODEVALUE@' ITEM_NAME='@ITEM_NAMEVALUE@' NOTIONAL='@NOTIONALVALUE@' REMAIN_NOTIONAL='@REMAIN_NOTIONALVALUE@' CURRENCY='@CURRENCYVALUE@' TRADE_DATE='@TRADE_DATEVALUE@' MATURITY_DATE='@MATURITY_DATEVALUE@' COUNTERPARTY='@COUNTERPARTYVALUE@' EXPORT_ITEMCODE='@EXPORT_ITEMCODEVALUE@' TRADE_ID='@TRADE_IDVALUE@' TRADE_STATUS='@TRADE_STATUSVALUE@' INSTRUMENT_TYPE='@INSTRUMENT_TYPEVALUE@' UNDERLYING_TYPE='@UNDERLYING_TYPEVALUE@' UNDERLYING_DETAIL_TYPE='@UNDERLYING_DETAIL_TYPEVALUE@' CONTRACT_TYPE='@CONTRACT_TYPEVALUE@' CONTRACT_SUBTYPE='@CONTRACT_SUBTYPEVALUE@' CONTRACT_DETAIL_TYPE='@CONTRACT_DETAIL_TYPEVALUE@' BOOKING_TYPE='@BOOKING_TYPEVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM MATSER_INFO WHERE ITEM_CODE = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.ITEM_CODE_ = dataRow["ITEM_CODE"].ToString();
            this.ITEM_NAME_ = dataRow["ITEM_NAME"].ToString();
            this.NOTIONAL_ = dataRow["NOTIONAL"].ToString();
            this.REMAIN_NOTIONAL_ = dataRow["REMAIN_NOTIONAL"].ToString();
            this.CURRENCY_ = dataRow["CURRENCY"].ToString();
            this.TRADE_DATE_ = dataRow["TRADE_DATE"].ToString();
            this.MATURITY_DATE_ = dataRow["MATURITY_DATE"].ToString();
            this.COUNTERPARTY_ = dataRow["COUNTERPARTY"].ToString();
            this.EXPORT_ITEMCODE_ = dataRow["EXPORT_ITEMCODE"].ToString();
            this.TRADE_ID_ = dataRow["TRADE_ID"].ToString();
            this.TRADE_STATUS_ = dataRow["TRADE_STATUS"].ToString();
            this.INSTRUMENT_TYPE_ = dataRow["INSTRUMENT_TYPE"].ToString();
            this.UNDERLYING_TYPE_ = dataRow["UNDERLYING_TYPE"].ToString();
            this.UNDERLYING_DETAIL_TYPE_ = dataRow["UNDERLYING_DETAIL_TYPE"].ToString();
            this.CONTRACT_TYPE_ = dataRow["CONTRACT_TYPE"].ToString();
            this.CONTRACT_SUBTYPE_ = dataRow["CONTRACT_SUBTYPE"].ToString();
            this.CONTRACT_DETAIL_TYPE_ = dataRow["CONTRACT_DETAIL_TYPE"].ToString();
            this.BOOKING_TYPE_ = dataRow["BOOKING_TYPE"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = MATSER_INFO_Table_DAO.SelectQuery_;

            selectQuery = selectQuery.Replace("@ITEM_CODEValue@", this.ITEM_CODE_);

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
                this.ITEM_NAME_ = item[1].ToString();
                this.NOTIONAL_ = item[2].ToString();
                this.REMAIN_NOTIONAL_ = item[3].ToString();
                this.CURRENCY_ = item[4].ToString();
                this.TRADE_DATE_ = item[5].ToString();
                this.MATURITY_DATE_ = item[6].ToString();
                this.COUNTERPARTY_ = item[7].ToString();
                this.EXPORT_ITEMCODE_ = item[8].ToString();
                this.TRADE_ID_ = item[9].ToString();
                this.TRADE_STATUS_ = item[10].ToString();
                this.INSTRUMENT_TYPE_ = item[11].ToString();
                this.UNDERLYING_TYPE_ = item[12].ToString();
                this.UNDERLYING_DETAIL_TYPE_ = item[13].ToString();
                this.CONTRACT_TYPE_ = item[14].ToString();
                this.CONTRACT_SUBTYPE_ = item[15].ToString();
                this.CONTRACT_DETAIL_TYPE_ = item[16].ToString();
                this.BOOKING_TYPE_ = item[17].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = MATSER_INFO_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@ITEM_CODEVALUE@", ITEM_CODE_);
            insertQuery = insertQuery.Replace("@ITEM_NAMEVALUE@", ITEM_NAME_);
            insertQuery = insertQuery.Replace("@NOTIONALVALUE@", NOTIONAL_);
            insertQuery = insertQuery.Replace("@REMAIN_NOTIONALVALUE@", REMAIN_NOTIONAL_);
            insertQuery = insertQuery.Replace("@CURRENCYVALUE@", CURRENCY_);
            insertQuery = insertQuery.Replace("@TRADE_DATEVALUE@", TRADE_DATE_);
            insertQuery = insertQuery.Replace("@MATURITY_DATEVALUE@", MATURITY_DATE_);
            insertQuery = insertQuery.Replace("@COUNTERPARTYVALUE@", COUNTERPARTY_);
            insertQuery = insertQuery.Replace("@EXPORT_ITEMCODEVALUE@", EXPORT_ITEMCODE_);
            insertQuery = insertQuery.Replace("@TRADE_IDVALUE@", TRADE_ID_);
            insertQuery = insertQuery.Replace("@TRADE_STATUSVALUE@", TRADE_STATUS_);
            insertQuery = insertQuery.Replace("@INSTRUMENT_TYPEVALUE@", INSTRUMENT_TYPE_);
            insertQuery = insertQuery.Replace("@UNDERLYING_TYPEVALUE@", UNDERLYING_TYPE_);
            insertQuery = insertQuery.Replace("@UNDERLYING_DETAIL_TYPEVALUE@", UNDERLYING_DETAIL_TYPE_);
            insertQuery = insertQuery.Replace("@CONTRACT_TYPEVALUE@", CONTRACT_TYPE_);
            insertQuery = insertQuery.Replace("@CONTRACT_SUBTYPEVALUE@", CONTRACT_SUBTYPE_);
            insertQuery = insertQuery.Replace("@CONTRACT_DETAIL_TYPEVALUE@", CONTRACT_DETAIL_TYPE_);
            insertQuery = insertQuery.Replace("@BOOKING_TYPEVALUE@", BOOKING_TYPE_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = MATSER_INFO_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@ITEM_CODEVALUE@", ITEM_CODE_);
            updateQuery = updateQuery.Replace("@ITEM_NAMEVALUE@", ITEM_NAME_);
            updateQuery = updateQuery.Replace("@NOTIONALVALUE@", NOTIONAL_);
            updateQuery = updateQuery.Replace("@REMAIN_NOTIONALVALUE@", REMAIN_NOTIONAL_);
            updateQuery = updateQuery.Replace("@CURRENCYVALUE@", CURRENCY_);
            updateQuery = updateQuery.Replace("@TRADE_DATEVALUE@", TRADE_DATE_);
            updateQuery = updateQuery.Replace("@MATURITY_DATEVALUE@", MATURITY_DATE_);
            updateQuery = updateQuery.Replace("@COUNTERPARTYVALUE@", COUNTERPARTY_);
            updateQuery = updateQuery.Replace("@EXPORT_ITEMCODEVALUE@", EXPORT_ITEMCODE_);
            updateQuery = updateQuery.Replace("@TRADE_IDVALUE@", TRADE_ID_);
            updateQuery = updateQuery.Replace("@TRADE_STATUSVALUE@", TRADE_STATUS_);
            updateQuery = updateQuery.Replace("@INSTRUMENT_TYPEVALUE@", INSTRUMENT_TYPE_);
            updateQuery = updateQuery.Replace("@UNDERLYING_TYPEVALUE@", UNDERLYING_TYPE_);
            updateQuery = updateQuery.Replace("@UNDERLYING_DETAIL_TYPEVALUE@", UNDERLYING_DETAIL_TYPE_);
            updateQuery = updateQuery.Replace("@CONTRACT_TYPEVALUE@", CONTRACT_TYPE_);
            updateQuery = updateQuery.Replace("@CONTRACT_SUBTYPEVALUE@", CONTRACT_SUBTYPE_);
            updateQuery = updateQuery.Replace("@CONTRACT_DETAIL_TYPEVALUE@", CONTRACT_DETAIL_TYPE_);
            updateQuery = updateQuery.Replace("@BOOKING_TYPEVALUE@", BOOKING_TYPE_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = MATSER_INFO_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
