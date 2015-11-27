using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class MARKETDATA_SYMBOL_INFO_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }
        public string KeyColumn_SYMBOL_TYPE_ { get; set; }

        public List<MARKETDATA_SYMBOL_INFO_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string SYMBOL_;
        public string NAME_ENG_;
        public string NAME_KOR_;
        public string SYMBOL_TYPE_;
        public string PROVIDER_;
        public string DESCRIPTION_;
        public string TENOR_;
        public string SUB_TYPE_;
        public string LINKEDCURVE_;
        public string RATE_TYPE_;
        public string LEG_TENOR_;
        public string CURRENCY_;

        #endregion

        #region Query

        private static string SelectSymbolQuery_
        = "SELECT SYMBOL, NAME_ENG, NAME_KOR, SYMBOL_TYPE, PROVIDER, DESCRIPTION, TENOR, SUB_TYPE, LINKEDCURVE, RATE_TYPE, LEG_TENOR, CURRENCY " +
        "FROM MARKETDATA_SYMBOL_INFO WHERE SYMBOL = '@KeyColumnValue@'";

        private static string SelectQuery_
        = "SELECT SYMBOL, NAME_ENG, NAME_KOR, SYMBOL_TYPE, PROVIDER, DESCRIPTION, TENOR, SUB_TYPE, LINKEDCURVE, RATE_TYPE, LEG_TENOR, CURRENCY  " +
         "FROM MARKETDATA_SYMBOL_INFO WHERE SYMBOL_TYPE = '@SYMBOL_TYPEKeyColumnValue@'";

        private static string SelectAllQuery_
        = "SELECT SYMBOL, NAME_ENG, NAME_KOR, SYMBOL_TYPE, PROVIDER, DESCRIPTION, TENOR, SUB_TYPE, LINKEDCURVE, RATE_TYPE, LEG_TENOR, CURRENCY  " +
         "FROM MARKETDATA_SYMBOL_INFO ";

        private static string SelectFilterQuery_
        = "SELECT SYMBOL, NAME_ENG, NAME_KOR, SYMBOL_TYPE, PROVIDER, DESCRIPTION, TENOR, SUB_TYPE, LINKEDCURVE, RATE_TYPE, LEG_TENOR, CURRENCY " +
         "FROM MARKETDATA_SYMBOL_INFO WHERE SYMBOL like '%@FILTER_Value@%' OR " +
                                           "NAME_ENG like '%@FILTER_Value@%' OR " +
                                           "NAME_KOR like '%@FILTER_Value@%' OR " +
                                           "SYMBOL_TYPE like '%@FILTER_Value@%' OR " +
                                           "PROVIDER like '%@FILTER_Value@%' OR " +
                                           "DESCRIPTION like '%@FILTER_Value@%' OR " +
                                           "TENOR like '%@FILTER_Value@%' OR " +
                                           "SUB_TYPE like '%@FILTER_Value@%' OR " +
                                           "LINKEDCURVE like '%@FILTER_Value@%' OR " +
                                           "RATE_TYPE like '%@FILTER_Value@%' OR " +
                                           "LEG_TENOR like '%@FILTER_Value@%' OR " +
                                           "CURRENCY like '%@FILTER_Value@%'  ";


        private static string DeleteQuery_
        = "DELETE FROM MARKETDATA_SYMBOL_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                this.DAOList_ = new List<MARKETDATA_SYMBOL_INFO_Table_DAO>();

                DbCommand dbCommand = conn.CreateCommand();

                string selectQuery = MARKETDATA_SYMBOL_INFO_Table_DAOManager.SelectQuery_;

                selectQuery = selectQuery.Replace("@SYMBOL_TYPEKeyColumnValue@", this.KeyColumn_SYMBOL_TYPE_);

                dbCommand.CommandText = selectQuery;

                //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
                DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

                dataAdapter.Fill(tb);

                DataRow[] dr = tb.Select();
                int rowCount = dr.Length;

                foreach (DataRow item in dr)
                {
                    MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

                    dao.SYMBOL_ = item[0].ToString();
                    dao.NAME_ENG_ = item[1].ToString();
                    dao.NAME_KOR_ = item[2].ToString();
                    dao.SYMBOL_TYPE_ = item[3].ToString();
                    dao.PROVIDER_ = item[4].ToString();
                    dao.DESCRIPTION_ = item[5].ToString();
                    dao.TENOR_ = item[6].ToString();
                    dao.SUB_TYPE_ = item[7].ToString();
                    dao.LINKEDCURVE_ = item[8].ToString();
                    dao.RATE_TYPE_ = item[9].ToString();
                    dao.LEG_TENOR_ = item[10].ToString();
                    dao.CURRENCY_ = item[11].ToString();

                    this.DAOList_.Add(dao);
                }

                conn.Close();

            }
            catch (Exception)
            {
                conn.Close();
            }
            
        }

        public void selectAll(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                this.DAOList_ = new List<MARKETDATA_SYMBOL_INFO_Table_DAO>();

                DbCommand dbCommand = conn.CreateCommand();

                string selectAllQuery = MARKETDATA_SYMBOL_INFO_Table_DAOManager.SelectAllQuery_;

                dbCommand.CommandText = selectAllQuery;

                //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
                DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

                dataAdapter.Fill(tb);

                DataRow[] dr = tb.Select();
                int rowCount = dr.Length;

                foreach (DataRow item in dr)
                {
                    MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

                    dao.SYMBOL_ = item[0].ToString();
                    dao.NAME_ENG_ = item[1].ToString();
                    dao.NAME_KOR_ = item[2].ToString();
                    dao.SYMBOL_TYPE_ = item[3].ToString();
                    dao.PROVIDER_ = item[4].ToString();
                    dao.DESCRIPTION_ = item[5].ToString();
                    dao.TENOR_ = item[6].ToString();
                    dao.SUB_TYPE_ = item[7].ToString();
                    dao.LINKEDCURVE_ = item[8].ToString();
                    dao.RATE_TYPE_ = item[9].ToString();
                    dao.LEG_TENOR_ = item[10].ToString();
                    dao.CURRENCY_ = item[11].ToString();

                    this.DAOList_.Add(dao);
                }

                conn.Close();

            }
            catch (Exception)
            {
                conn.Close();
            }

        }

        public void selectSymbol(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                this.DAOList_ = new List<MARKETDATA_SYMBOL_INFO_Table_DAO>();

                DbCommand dbCommand = conn.CreateCommand();

                string selectSymbolQuery = MARKETDATA_SYMBOL_INFO_Table_DAOManager.SelectSymbolQuery_;

                selectSymbolQuery = selectSymbolQuery.Replace("@KeyColumnValue@", this.SYMBOL_);

                dbCommand.CommandText = selectSymbolQuery;

                //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
                DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

                dataAdapter.Fill(tb);

                DataRow[] dr = tb.Select();
                int rowCount = dr.Length;

                foreach (DataRow item in dr)
                {
                    MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

                    dao.SYMBOL_ = item[0].ToString();
                    dao.NAME_ENG_ = item[1].ToString();
                    dao.NAME_KOR_ = item[2].ToString();
                    dao.SYMBOL_TYPE_ = item[3].ToString();
                    dao.PROVIDER_ = item[4].ToString();
                    dao.DESCRIPTION_ = item[5].ToString();
                    dao.TENOR_ = item[6].ToString();
                    dao.SUB_TYPE_ = item[7].ToString();
                    dao.LINKEDCURVE_ = item[8].ToString();
                    dao.RATE_TYPE_ = item[9].ToString();
                    dao.LEG_TENOR_ = item[10].ToString();
                    dao.CURRENCY_ = item[11].ToString();

                    this.DAOList_.Add(dao);
                }

                conn.Close();

            }
            catch (Exception)
            {
                conn.Close();
            }

        }

        public void selectFiltering(DbConnection conn, string filter)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                this.DAOList_ = new List<MARKETDATA_SYMBOL_INFO_Table_DAO>();

                DbCommand dbCommand = conn.CreateCommand();

                string selectFilterQuery = MARKETDATA_SYMBOL_INFO_Table_DAOManager.SelectFilterQuery_;

                selectFilterQuery = selectFilterQuery.Replace("@FILTER_Value@", filter);

                dbCommand.CommandText = selectFilterQuery;

                //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
                DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

                dataAdapter.Fill(tb);

                DataRow[] dr = tb.Select();
                int rowCount = dr.Length;

                foreach (DataRow item in dr)
                {
                    MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

                    dao.SYMBOL_ = item[0].ToString();
                    dao.NAME_ENG_ = item[1].ToString();
                    dao.NAME_KOR_ = item[2].ToString();
                    dao.SYMBOL_TYPE_ = item[3].ToString();
                    dao.PROVIDER_ = item[4].ToString();
                    dao.DESCRIPTION_ = item[5].ToString();
                    dao.TENOR_ = item[6].ToString();
                    dao.SUB_TYPE_ = item[7].ToString();
                    dao.LINKEDCURVE_ = item[8].ToString();
                    dao.RATE_TYPE_ = item[9].ToString();
                    dao.LEG_TENOR_ = item[10].ToString();
                    dao.CURRENCY_ = item[11].ToString();

                    this.DAOList_.Add(dao);
                }

                conn.Close();

            }
            catch (Exception)
            {
                conn.Close();
            }

        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = MARKETDATA_SYMBOL_INFO_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
