using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class POSITION_PL_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<POSITION_PL_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string ITEM_CODE_;
        public string TRADE_ID_;
        public string NOTIONAL_;
        public string REMAIN_NOTIONAL_;
        public string BOOK_PRICE_;
        public string BOOK_NOTIONAL_;
        public string EVAL_PRICE_;
        public string BOOK_PL_;
        public string TOTAL_EVAL_PL_;
        public string DAILY_EVAL_PL_;
        public string TRADE_PL_;
        public string TOTAL_PL_;
        public string ETC_PL_;
        public string STD_DATE_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT ITEM_CODE, TRADE_ID, NOTIONAL, REMAIN_NOTIONAL, BOOK_PRICE, BOOK_NOTIONAL, EVAL_PRICE, BOOK_PL, TOTAL_EVAL_PL, DAILY_EVAL_PL, TRADE_PL, TOTAL_PL, ETC_PL, STD_DATE " +
         "FROM POSITION_PL WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM POSITION_PL WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<POSITION_PL_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = POSITION_PL_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                POSITION_PL_Table_DAO dao = new POSITION_PL_Table_DAO();

                dao.ITEM_CODE_ = item[0].ToString();
                dao.TRADE_ID_ = item[1].ToString();
                dao.NOTIONAL_ = item[2].ToString();
                dao.REMAIN_NOTIONAL_ = item[3].ToString();
                dao.BOOK_PRICE_ = item[4].ToString();
                dao.BOOK_NOTIONAL_ = item[5].ToString();
                dao.EVAL_PRICE_ = item[6].ToString();
                dao.BOOK_PL_ = item[7].ToString();
                dao.TOTAL_EVAL_PL_ = item[8].ToString();
                dao.DAILY_EVAL_PL_ = item[9].ToString();
                dao.TRADE_PL_ = item[10].ToString();
                dao.TOTAL_PL_ = item[11].ToString();
                dao.ETC_PL_ = item[12].ToString();
                dao.STD_DATE_ = item[13].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = POSITION_PL_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
