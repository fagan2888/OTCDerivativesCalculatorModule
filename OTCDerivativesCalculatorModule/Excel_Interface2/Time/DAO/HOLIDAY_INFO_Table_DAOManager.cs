using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class HOLIDAY_INFO_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<HOLIDAY_INFO_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string HOLIDAY_DATE_;
        public string HOLIDAY_NAME_;
        public string HOLIDAY_COUNTRY_NAME_;
        public string HOLIDAY_CURRENCY_CODE_;
        public string HOLIDAY_TYPE_;
        public string USING_START_DATE_;
        public string USING_END_DATE_;
        public string DESCRIPTION_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT HOLIDAY_DATE, HOLIDAY_NAME, HOLIDAY_COUNTRY_NAME, HOLIDAY_CURRENCY_CODE, HOLIDAY_TYPE, USING_START_DATE, USING_END_DATE, DESCRIPTION " +
         "FROM HOLIDAY_INFO WHERE HOLIDAY_COUNTRY_NAME = '@HOLIDAY_COUNTRY_NAMEVALUE@'";

        private static string SelectContryNameQuery_
        = "SELECT HOLIDAY_DATE, HOLIDAY_NAME, HOLIDAY_COUNTRY_NAME, HOLIDAY_CURRENCY_CODE, HOLIDAY_TYPE, USING_START_DATE, USING_END_DATE, DESCRIPTION " +
         "FROM HOLIDAY_INFO WHERE HOLIDAY_COUNTRY_NAME = '@HOLIDAY_COUNTRY_NAMEVALUE@'";

        private static string DeleteQuery_
        = "DELETE FROM HOLIDAY_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<HOLIDAY_INFO_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = HOLIDAY_INFO_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                HOLIDAY_INFO_Table_DAO dao = new HOLIDAY_INFO_Table_DAO();

                dao.HOLIDAY_DATE_ = item[0].ToString();
                dao.HOLIDAY_NAME_ = item[1].ToString();
                dao.HOLIDAY_COUNTRY_NAME_ = item[2].ToString();
                dao.HOLIDAY_CURRENCY_CODE_ = item[3].ToString();
                dao.HOLIDAY_TYPE_ = item[4].ToString();
                dao.USING_START_DATE_ = item[5].ToString();
                dao.USING_END_DATE_ = item[6].ToString();
                dao.DESCRIPTION_ = item[7].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void selectContryName(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<HOLIDAY_INFO_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectContryNameQuery = HOLIDAY_INFO_Table_DAOManager.SelectContryNameQuery_;

            selectContryNameQuery = selectContryNameQuery.Replace("@HOLIDAY_COUNTRY_NAMEVALUE@", this.HOLIDAY_COUNTRY_NAME_);

            dbCommand.CommandText = selectContryNameQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                HOLIDAY_INFO_Table_DAO dao = new HOLIDAY_INFO_Table_DAO();

                dao.HOLIDAY_DATE_ = item[0].ToString();
                dao.HOLIDAY_NAME_ = item[1].ToString();
                dao.HOLIDAY_COUNTRY_NAME_ = item[2].ToString();
                dao.HOLIDAY_CURRENCY_CODE_ = item[3].ToString();
                dao.HOLIDAY_TYPE_ = item[4].ToString();
                dao.USING_START_DATE_ = item[5].ToString();
                dao.USING_END_DATE_ = item[6].ToString();
                dao.DESCRIPTION_ = item[7].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = HOLIDAY_INFO_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
