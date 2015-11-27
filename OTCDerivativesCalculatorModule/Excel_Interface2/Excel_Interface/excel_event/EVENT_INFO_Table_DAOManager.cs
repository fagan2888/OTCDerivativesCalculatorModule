using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class EVENT_INFO_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<EVENT_INFO_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string EVENT_CODE_;
        public string EVENT_DATE_;
        public string EVENT_TYPE_;
        public string EVENT_SUBTYPE_;
        public string EVENT_NAME_;
        public string EVENT_DESCRIPTION_;
        public string CURRENCY_;
        public string NOTIONAL_;
        public string REMAIN_NOTIONAL_;
        public string EVENT_AMOUNT_;
        public string COUNTERPARTY_;
        public string FLOATING_FLAG_;
        public string CALCULATION_TYPE_;
        public string FIXING_UNDERLYINGS_;
        public string FIXING_OBSERVATION_;
        public string FIXING_FLAG_;
        public string EXPIRED_FLAG_;
        public string ITEM_CODE_;
        public string ITEM_TYPE_;
        public string ITEM_NAME_;

        #endregion

        #region Query

        private static string SelectAllQuery_
        = "SELECT EVENT_CODE, EVENT_DATE, EVENT_TYPE, EVENT_SUBTYPE, EVENT_NAME, EVENT_DESCRIPTION, CURRENCY, NOTIONAL, REMAIN_NOTIONAL, EVENT_AMOUNT, COUNTERPARTY, FLOATING_FLAG, CALCULATION_TYPE, FIXING_UNDERLYINGS, FIXING_OBSERVATION, FIXING_FLAG, EXPIRED_FLAG, ITEM_CODE, ITEM_TYPE, ITEM_NAME " +
         "FROM EVENT_INFO ";

        private static string SelectQuery_
        = "SELECT EVENT_CODE, EVENT_DATE, EVENT_TYPE, EVENT_SUBTYPE, EVENT_NAME, EVENT_DESCRIPTION, CURRENCY, NOTIONAL, REMAIN_NOTIONAL, EVENT_AMOUNT, COUNTERPARTY, FLOATING_FLAG, CALCULATION_TYPE, FIXING_UNDERLYINGS, FIXING_OBSERVATION, FIXING_FLAG, EXPIRED_FLAG, ITEM_CODE, ITEM_TYPE, ITEM_NAME " +
         "FROM EVENT_INFO WHERE ITEM_CODE = '@KeyColumnValue@'";

        private static string SelectEventDateListQuery_
        = "SELECT EVENT_CODE, EVENT_DATE, EVENT_TYPE, EVENT_SUBTYPE, EVENT_NAME, EVENT_DESCRIPTION, CURRENCY, NOTIONAL, REMAIN_NOTIONAL, EVENT_AMOUNT, COUNTERPARTY, FLOATING_FLAG, CALCULATION_TYPE, FIXING_UNDERLYINGS, FIXING_OBSERVATION, FIXING_FLAG, EXPIRED_FLAG, ITEM_CODE, ITEM_TYPE, ITEM_NAME " +
         "FROM EVENT_INFO WHERE EVENT_DATE in ( @DatesList@ )" ;

        private static string DeleteQuery_
        = "DELETE FROM EVENT_INFO WHERE ITEM_CODE = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<EVENT_INFO_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = EVENT_INFO_Table_DAOManager.SelectQuery_;

            selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

                dao.EVENT_CODE_ = item[0].ToString();
                dao.EVENT_DATE_ = item[1].ToString();
                dao.EVENT_TYPE_ = item[2].ToString();
                dao.EVENT_SUBTYPE_ = item[3].ToString();
                dao.EVENT_NAME_ = item[4].ToString();
                dao.EVENT_DESCRIPTION_ = item[5].ToString();
                dao.CURRENCY_ = item[6].ToString();
                dao.NOTIONAL_ = item[7].ToString();
                dao.REMAIN_NOTIONAL_ = item[8].ToString();
                dao.EVENT_AMOUNT_ = item[9].ToString();
                dao.COUNTERPARTY_ = item[10].ToString();
                dao.FLOATING_FLAG_ = item[11].ToString();
                dao.CALCULATION_TYPE_ = item[12].ToString();
                dao.FIXING_UNDERLYINGS_ = item[13].ToString();
                dao.FIXING_OBSERVATION_ = item[14].ToString();
                dao.FIXING_FLAG_ = item[15].ToString();
                dao.EXPIRED_FLAG_ = item[16].ToString();
                dao.ITEM_CODE_ = item[17].ToString();
                dao.ITEM_TYPE_ = item[18].ToString();
                dao.ITEM_NAME_ = item[19].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void selectEventDateList(DbConnection conn, List<string> dates)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<EVENT_INFO_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = EVENT_INFO_Table_DAOManager.SelectEventDateListQuery_;

            StringBuilder datesListSb = new StringBuilder();

            foreach (var item in dates)
            {
                datesListSb.Append("'" + dates + "',");
            }

            datesListSb.Remove(datesListSb.Length - 1, 1);

            selectQuery = selectQuery.Replace("@DatesList@", datesListSb.ToString());

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

                dao.EVENT_CODE_ = item[0].ToString();
                dao.EVENT_DATE_ = item[1].ToString();
                dao.EVENT_TYPE_ = item[2].ToString();
                dao.EVENT_SUBTYPE_ = item[3].ToString();
                dao.EVENT_NAME_ = item[4].ToString();
                dao.EVENT_DESCRIPTION_ = item[5].ToString();
                dao.CURRENCY_ = item[6].ToString();
                dao.NOTIONAL_ = item[7].ToString();
                dao.REMAIN_NOTIONAL_ = item[8].ToString();
                dao.EVENT_AMOUNT_ = item[9].ToString();
                dao.COUNTERPARTY_ = item[10].ToString();
                dao.FLOATING_FLAG_ = item[11].ToString();
                dao.CALCULATION_TYPE_ = item[12].ToString();
                dao.FIXING_UNDERLYINGS_ = item[13].ToString();
                dao.FIXING_OBSERVATION_ = item[14].ToString();
                dao.FIXING_FLAG_ = item[15].ToString();
                dao.EXPIRED_FLAG_ = item[16].ToString();
                dao.ITEM_CODE_ = item[17].ToString();
                dao.ITEM_TYPE_ = item[18].ToString();
                dao.ITEM_NAME_ = item[19].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = EVENT_INFO_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }


        public void selectAll(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<EVENT_INFO_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = EVENT_INFO_Table_DAOManager.SelectAllQuery_;

            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                EVENT_INFO_Table_DAO dao = new EVENT_INFO_Table_DAO();

                dao.EVENT_CODE_ = item[0].ToString();
                dao.EVENT_DATE_ = item[1].ToString();
                dao.EVENT_TYPE_ = item[2].ToString();
                dao.EVENT_SUBTYPE_ = item[3].ToString();
                dao.EVENT_NAME_ = item[4].ToString();
                dao.EVENT_DESCRIPTION_ = item[5].ToString();
                dao.CURRENCY_ = item[6].ToString();
                dao.NOTIONAL_ = item[7].ToString();
                dao.REMAIN_NOTIONAL_ = item[8].ToString();
                dao.EVENT_AMOUNT_ = item[9].ToString();
                dao.COUNTERPARTY_ = item[10].ToString();
                dao.FLOATING_FLAG_ = item[11].ToString();
                dao.CALCULATION_TYPE_ = item[12].ToString();
                dao.FIXING_UNDERLYINGS_ = item[13].ToString();
                dao.FIXING_OBSERVATION_ = item[14].ToString();
                dao.FIXING_FLAG_ = item[15].ToString();
                dao.EXPIRED_FLAG_ = item[16].ToString();
                dao.ITEM_CODE_ = item[17].ToString();
                dao.ITEM_TYPE_ = item[18].ToString();
                dao.ITEM_NAME_ = item[19].ToString();

                this.DAOList_.Add(dao);
            }
        }
    }
}
