using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class MATSER_INFO_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<MATSER_INFO_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string ITEM_CODE_;
        public string ITEM_NAME_;
        public string NOTIONAL_;
        public string REMAIN_NOTIONAL_;
        public string CURRENCY_;
        public string TRADE_DATE_;
        public string MATURITY_DATE_;
        public string COUNTERPARTY_;
        public string EXPORT_ITEMCODE_;
        public string TRADE_ID_;
        public string TRADE_STATUS_;
        public string INSTRUMENT_TYPE_;
        public string UNDERLYING_TYPE_;
        public string UNDERLYING_DETAIL_TYPE_;
        public string CONTRACT_TYPE_;
        public string CONTRACT_SUBTYPE_;
        public string CONTRACT_DETAIL_TYPE_;
        public string BOOKING_TYPE_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT ITEM_CODE, ITEM_NAME, NOTIONAL, REMAIN_NOTIONAL, CURRENCY, TRADE_DATE, MATURITY_DATE, COUNTERPARTY, EXPORT_ITEMCODE, TRADE_ID, TRADE_STATUS, INSTRUMENT_TYPE, UNDERLYING_TYPE, UNDERLYING_DETAIL_TYPE, CONTRACT_TYPE, CONTRACT_SUBTYPE, CONTRACT_DETAIL_TYPE, BOOKING_TYPE " +
         "FROM MATSER_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        private static string SelectAllQuery_
        = "SELECT ITEM_CODE, ITEM_NAME, NOTIONAL, REMAIN_NOTIONAL, CURRENCY, TRADE_DATE, MATURITY_DATE, COUNTERPARTY, EXPORT_ITEMCODE, TRADE_ID, TRADE_STATUS, INSTRUMENT_TYPE, UNDERLYING_TYPE, UNDERLYING_DETAIL_TYPE, CONTRACT_TYPE, CONTRACT_SUBTYPE, CONTRACT_DETAIL_TYPE, BOOKING_TYPE " +
         "FROM MATSER_INFO";

        private static string DeleteQuery_
        = "DELETE FROM MATSER_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<MATSER_INFO_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = MATSER_INFO_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                MATSER_INFO_Table_DAO dao = new MATSER_INFO_Table_DAO();

                dao.ITEM_CODE_ = item[0].ToString();
                dao.ITEM_NAME_ = item[1].ToString();
                dao.NOTIONAL_ = item[2].ToString();
                dao.REMAIN_NOTIONAL_ = item[3].ToString();
                dao.CURRENCY_ = item[4].ToString();
                dao.TRADE_DATE_ = item[5].ToString();
                dao.MATURITY_DATE_ = item[6].ToString();
                dao.COUNTERPARTY_ = item[7].ToString();
                dao.EXPORT_ITEMCODE_ = item[8].ToString();
                dao.TRADE_ID_ = item[9].ToString();
                dao.TRADE_STATUS_ = item[10].ToString();
                dao.INSTRUMENT_TYPE_ = item[11].ToString();
                dao.UNDERLYING_TYPE_ = item[12].ToString();
                dao.UNDERLYING_DETAIL_TYPE_ = item[13].ToString();
                dao.CONTRACT_TYPE_ = item[14].ToString();
                dao.CONTRACT_SUBTYPE_ = item[15].ToString();
                dao.CONTRACT_DETAIL_TYPE_ = item[16].ToString();
                dao.BOOKING_TYPE_ = item[17].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void selectAll(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<MATSER_INFO_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectAllQuery = MATSER_INFO_Table_DAOManager.SelectAllQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectAllQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                MATSER_INFO_Table_DAO dao = new MATSER_INFO_Table_DAO();

                dao.ITEM_CODE_ = item[0].ToString();
                dao.ITEM_NAME_ = item[1].ToString();
                dao.NOTIONAL_ = item[2].ToString();
                dao.REMAIN_NOTIONAL_ = item[3].ToString();
                dao.CURRENCY_ = item[4].ToString();
                dao.TRADE_DATE_ = item[5].ToString();
                dao.MATURITY_DATE_ = item[6].ToString();
                dao.COUNTERPARTY_ = item[7].ToString();
                dao.EXPORT_ITEMCODE_ = item[8].ToString();
                dao.TRADE_ID_ = item[9].ToString();
                dao.TRADE_STATUS_ = item[10].ToString();
                dao.INSTRUMENT_TYPE_ = item[11].ToString();
                dao.UNDERLYING_TYPE_ = item[12].ToString();
                dao.UNDERLYING_DETAIL_TYPE_ = item[13].ToString();
                dao.CONTRACT_TYPE_ = item[14].ToString();
                dao.CONTRACT_SUBTYPE_ = item[15].ToString();
                dao.CONTRACT_DETAIL_TYPE_ = item[16].ToString();
                dao.BOOKING_TYPE_ = item[17].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = MATSER_INFO_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
