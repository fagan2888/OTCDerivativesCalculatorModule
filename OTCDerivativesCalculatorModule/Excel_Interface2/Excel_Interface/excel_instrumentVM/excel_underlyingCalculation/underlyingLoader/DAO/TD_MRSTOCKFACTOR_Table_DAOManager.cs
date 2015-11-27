using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class TD_MRSTOCKFACTOR_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<TD_MRSTOCKFACTOR_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string STD_DATE_;
        public string STOCK_ID_;
        public string STOCK_NAME_;
        public string CURR_PRICE_;
        public string DIVIDEND_RATE_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT STD_DATE, STOCK_ID, STOCK_NAME, CURR_PRICE, DIVIDEND_RATE " +
         "FROM TD_MRSTOCKFACTOR WHERE KeyColumn = '@KeyColumnValue@'";

        private static string SelectInterValQuery_
        = "SELECT STD_DATE, STOCK_ID, STOCK_NAME, CURR_PRICE, DIVIDEND_RATE " +
         "FROM TD_MRSTOCKFACTOR WHERE STOCK_ID = '@KeyColumnValue@' AND STD_DATE >= '@StartDateValue@' AND STD_DATE <= '@EndDateValue@'";

        private static string DeleteQuery_
        = "DELETE FROM TD_MRSTOCKFACTOR WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                this.DAOList_ = new List<TD_MRSTOCKFACTOR_Table_DAO>();

                DbCommand dbCommand = conn.CreateCommand();

                string selectQuery = TD_MRSTOCKFACTOR_Table_DAOManager.SelectQuery_;



                //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

                dbCommand.CommandText = selectQuery;

                //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
                DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

                dataAdapter.Fill(tb);

                DataRow[] dr = tb.Select();
                int rowCount = dr.Length;

                foreach (DataRow item in dr)
                {
                    TD_MRSTOCKFACTOR_Table_DAO dao = new TD_MRSTOCKFACTOR_Table_DAO();

                    dao.STD_DATE_ = item[0].ToString();
                    dao.STOCK_ID_ = item[1].ToString();
                    dao.STOCK_NAME_ = item[2].ToString();
                    dao.CURR_PRICE_ = item[3].ToString();
                    dao.DIVIDEND_RATE_ = item[4].ToString();

                    this.DAOList_.Add(dao);
                }
                conn.Close();

            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
      

        }

        public void selectInterval(DbConnection conn, DateTime startDate, DateTime endDate)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            try
            {
                DataTable tb = new DataTable();

                this.DAOList_ = new List<TD_MRSTOCKFACTOR_Table_DAO>();

                DbCommand dbCommand = conn.CreateCommand();

                string SelectInterValQuery_ = TD_MRSTOCKFACTOR_Table_DAOManager.SelectInterValQuery_;

                SelectInterValQuery_ = SelectInterValQuery_.Replace("@KeyColumnValue@", this.STOCK_ID_);
                SelectInterValQuery_ = SelectInterValQuery_.Replace("@StartDateValue@", startDate.ToString(StringFormat.DbDateFormat_));
                SelectInterValQuery_ = SelectInterValQuery_.Replace("@EndDateValue@", endDate.ToString(StringFormat.DbDateFormat_));

                //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

                dbCommand.CommandText = SelectInterValQuery_;

                //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
                DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

                dataAdapter.Fill(tb);

                DataRow[] dr = tb.Select();
                int rowCount = dr.Length;

                foreach (DataRow item in dr)
                {
                    TD_MRSTOCKFACTOR_Table_DAO dao = new TD_MRSTOCKFACTOR_Table_DAO();

                    dao.STD_DATE_ = item[0].ToString();
                    dao.STOCK_ID_ = item[1].ToString();
                    dao.STOCK_NAME_ = item[2].ToString();
                    dao.CURR_PRICE_ = item[3].ToString();
                    dao.DIVIDEND_RATE_ = item[4].ToString();

                    this.DAOList_.Add(dao);
                }

                conn.Close();

            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = TD_MRSTOCKFACTOR_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
