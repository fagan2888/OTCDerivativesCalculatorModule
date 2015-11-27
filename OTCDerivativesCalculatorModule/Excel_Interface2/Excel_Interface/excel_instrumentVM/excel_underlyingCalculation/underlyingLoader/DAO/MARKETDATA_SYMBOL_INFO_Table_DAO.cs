using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class MARKETDATA_SYMBOL_INFO_Table_DAO : INotifyPropertyChanged
    {

        #region Event
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                if (propertyName == "")
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
                else
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
        #endregion

        public MARKETDATA_SYMBOL_INFO_Table_DAO() { }

        public string SYMBOL_KeyColumn_ { get; set; }
        public string KeyColumn_ { get; set; }

        #region Properties

        public string SYMBOL_ { get; set; }
        public string NAME_ENG_ { get; set; }
        public string NAME_KOR_ { get; set; }
        public string SYMBOL_TYPE_ { get; set; }
        public string PROVIDER_ { get; set; }
        public string DESCRIPTION_ { get; set; }
        public string TENOR_ { get; set; }
        public string SUB_TYPE_ { get; set; }
        public string LINKEDCURVE_ { get; set; }
        public string RATE_TYPE_ { get; set; }
        public string LEG_TENOR_ { get; set; }
        public string CURRENCY_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT SYMBOL, NAME_ENG, NAME_KOR, SYMBOL_TYPE, PROVIDER, DESCRIPTION, TENOR, SUB_TYPE, LINKEDCURVE, RATE_TYPE, LEG_TENOR, CURRENCY " +
         "FROM MARKETDATA_SYMBOL_INFO WHERE SYMBOL = '@KeyColumnValue@'";

        private static string SelectNAME_KORQuery_
        = "SELECT SYMBOL, NAME_ENG, NAME_KOR, SYMBOL_TYPE, PROVIDER, DESCRIPTION, TENOR, SUB_TYPE, LINKEDCURVE, RATE_TYPE, LEG_TENOR, CURRENCY  " +
         "FROM MARKETDATA_SYMBOL_INFO WHERE NAME_KOR = '@NAME_KORValue@'";

        private static string SelectFilterQuery_
        = "SELECT SYMBOL, NAME_ENG, NAME_KOR, SYMBOL_TYPE, PROVIDER, DESCRIPTION, TENOR, SUB_TYPE, LINKEDCURVE, RATE_TYPE, LEG_TENOR, CURRENCY  " +
         "FROM MARKETDATA_SYMBOL_INFO WHERE SYMBOL = '%@FILTER_Value@%' OR " +
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

        private static string InsertQuery_
        = "INSERT INTO MARKETDATA_SYMBOL_INFO (SYMBOL, NAME_ENG, NAME_KOR, SYMBOL_TYPE, PROVIDER, DESCRIPTION, TENOR, SUB_TYPE, LINKEDCURVE, RATE_TYPE, LEG_TENOR, CURRENCY )" +
        "VALUES ('@SYMBOLVALUE@', '@NAME_ENGVALUE@', '@NAME_KORVALUE@', '@SYMBOL_TYPEVALUE@', '@PROVIDERVALUE@', '@DESCRIPTIONVALUE@', '@TENORVALUE@', '@SUB_TYPEVALUE@', '@LINKEDCURVEVALUE@' ,'@RATE_TYPEVALUE@','@LEG_TENORVALUE@','@CURRENCYVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE MARKETDATA_SYMBOL_INFO SET SYMBOL='@SYMBOLVALUE@' NAME_ENG='@NAME_ENGVALUE@' NAME_KOR='@NAME_KORVALUE@' " + 
                                            "SYMBOL_TYPE='@SYMBOL_TYPEVALUE@' PROVIDER='@PROVIDERVALUE@' DESCRIPTION='@DESCRIPTIONVALUE@' TENOR='@TENORVALUE@' SUB_TYPE='@SUB_TYPEVALUE@' LINKEDCURVE='@LINKEDCURVEVALUE@' " +
                                            "RATE_TYPE='@RATE_TYPEVALUE@' LEG_TENOR='@LEG_TENORVALUE@' CURRENCY='@CURRENCYVALUE@' " +
                                            "WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
         = "DELETE FROM MARKETDATA_SYMBOL_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.SYMBOL_ = dataRow["SYMBOL"].ToString();
            this.NAME_ENG_ = dataRow["NAME_ENG"].ToString();
            this.NAME_KOR_ = dataRow["NAME_KOR"].ToString();
            this.SYMBOL_TYPE_ = dataRow["SYMBOL_TYPE"].ToString();
            this.PROVIDER_ = dataRow["PROVIDER"].ToString();
            this.DESCRIPTION_ = dataRow["DESCRIPTION"].ToString();
            this.TENOR_ = dataRow["TENOR"].ToString();
            this.SUB_TYPE_ = dataRow["SUB_TYPE"].ToString();
            this.LINKEDCURVE_ = dataRow["LINKEDCURVE"].ToString();
            this.RATE_TYPE_ = dataRow["RATE_TYPE"].ToString();
            this.LEG_TENOR_ = dataRow["LEG_TENOR"].ToString();
            this.CURRENCY_ = dataRow["CURRENCY"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            try
            {
                DataTable tb = new DataTable();

                DbCommand dbCommand = conn.CreateCommand();

                string selectQuery = MARKETDATA_SYMBOL_INFO_Table_DAO.SelectQuery_;

                selectQuery = selectQuery.Replace("@KeyColumnValue@", this.SYMBOL_);

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
                    this.SYMBOL_ = item[0].ToString();
                    this.NAME_ENG_ = item[1].ToString();
                    this.NAME_KOR_ = item[2].ToString();
                    this.SYMBOL_TYPE_ = item[3].ToString();
                    this.PROVIDER_ = item[4].ToString();
                    this.DESCRIPTION_ = item[5].ToString();
                    this.TENOR_ = item[6].ToString();
                    this.SUB_TYPE_ = item[7].ToString();
                    this.LINKEDCURVE_ = item[8].ToString();
                    this.RATE_TYPE_ = item[9].ToString();
                    this.LEG_TENOR_ = item[10].ToString();
                    this.CURRENCY_ = item[11].ToString();
                }

            
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }

        public void selectNAME_KOR(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            try
            {
                DataTable tb = new DataTable();

                DbCommand dbCommand = conn.CreateCommand();

                string selectNAME_KORQuery = MARKETDATA_SYMBOL_INFO_Table_DAO.SelectNAME_KORQuery_;

                selectNAME_KORQuery = selectNAME_KORQuery.Replace("@NAME_KORValue@", this.NAME_KOR_);

                dbCommand.CommandText = selectNAME_KORQuery;

                //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
                DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

                dataAdapter.Fill(tb);

                DataRow[] dr = tb.Select();
                int rowCount = dr.Length;

                if (!(rowCount == 0 || rowCount == 1))
                { throw new Exception(); }

                foreach (DataRow item in dr)
                {
                    this.SYMBOL_ = item[0].ToString();
                    this.NAME_ENG_ = item[1].ToString();
                    this.NAME_KOR_ = item[2].ToString();
                    this.SYMBOL_TYPE_ = item[3].ToString();
                    this.PROVIDER_ = item[4].ToString();
                    this.DESCRIPTION_ = item[5].ToString();
                    this.TENOR_ = item[6].ToString();
                    this.SUB_TYPE_ = item[7].ToString();
                    this.LINKEDCURVE_ = item[8].ToString();
                    this.RATE_TYPE_ = item[9].ToString();
                    this.LEG_TENOR_ = item[10].ToString();
                    this.CURRENCY_ = item[11].ToString();
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

                string insertQuery = MARKETDATA_SYMBOL_INFO_Table_DAO.InsertQuery_;

                insertQuery = insertQuery.Replace("@SYMBOLVALUE@", SYMBOL_);
                insertQuery = insertQuery.Replace("@NAME_ENGVALUE@", NAME_ENG_);
                insertQuery = insertQuery.Replace("@NAME_KORVALUE@", NAME_KOR_);
                insertQuery = insertQuery.Replace("@SYMBOL_TYPEVALUE@", SYMBOL_TYPE_);
                insertQuery = insertQuery.Replace("@PROVIDERVALUE@", PROVIDER_);
                insertQuery = insertQuery.Replace("@DESCRIPTIONVALUE@", DESCRIPTION_);
                insertQuery = insertQuery.Replace("@TENORVALUE@", TENOR_);
                insertQuery = insertQuery.Replace("@SUB_TYPEVALUE@", SUB_TYPE_);
                insertQuery = insertQuery.Replace("@LINKEDCURVEVALUE@", LINKEDCURVE_);
                insertQuery = insertQuery.Replace("@RATE_TYPEVALUE@", RATE_TYPE_);
                insertQuery = insertQuery.Replace("@LEG_TENORVALUE@", LEG_TENOR_);
                insertQuery = insertQuery.Replace("@CURRENCYVALUE@", CURRENCY_);


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

            string updateQuery = MARKETDATA_SYMBOL_INFO_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@SYMBOLVALUE@", SYMBOL_);
            updateQuery = updateQuery.Replace("@NAME_ENGVALUE@", NAME_ENG_);
            updateQuery = updateQuery.Replace("@NAME_KORVALUE@", NAME_KOR_);
            updateQuery = updateQuery.Replace("@SYMBOL_TYPEVALUE@", SYMBOL_TYPE_);
            updateQuery = updateQuery.Replace("@PROVIDERVALUE@", PROVIDER_);
            updateQuery = updateQuery.Replace("@DESCRIPTIONVALUE@", DESCRIPTION_);
            updateQuery = updateQuery.Replace("@TENORVALUE@", TENOR_);
            updateQuery = updateQuery.Replace("@SUB_TYPEVALUE@", SUB_TYPE_);
            updateQuery = updateQuery.Replace("@LINKEDCURVEVALUE@", LINKEDCURVE_);
            updateQuery = updateQuery.Replace("@RATE_TYPEVALUE@", RATE_TYPE_);
            updateQuery = updateQuery.Replace("@LEG_TENORVALUE@", LEG_TENOR_);
            updateQuery = updateQuery.Replace("@CURRENCYVALUE@", CURRENCY_);



            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = MARKETDATA_SYMBOL_INFO_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@SYMBOL_KeyColumnValue@", this.SYMBOL_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

        public MARKETDATA_SYMBOL_INFO_Table_DAO clone()
        {
            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.DESCRIPTION_ = this.DESCRIPTION_;
            dao.SYMBOL_ = this.SYMBOL_;
            dao.SYMBOL_TYPE_ = this.SYMBOL_TYPE_;
            dao.NAME_ENG_ = this.NAME_ENG_;
            dao.NAME_KOR_ = this.NAME_KOR_;
            dao.PROVIDER_ = this.PROVIDER_;
            dao.TENOR_ = this.TENOR_;
            dao.SUB_TYPE_ = this.SUB_TYPE_;
            dao.LINKEDCURVE_ = this.LINKEDCURVE_;
            dao.RATE_TYPE_ = this.RATE_TYPE_;
            dao.LEG_TENOR_ = this.LEG_TENOR_;
            dao.CURRENCY_ = this.CURRENCY_;

            return dao;
        }

        public void copy(MARKETDATA_SYMBOL_INFO_Table_DAO clone)
        {
            this.DESCRIPTION_ = clone.DESCRIPTION_;
            this.SYMBOL_ = clone.SYMBOL_;
            this.SYMBOL_TYPE_ = clone.SYMBOL_TYPE_;
            this.NAME_ENG_ = clone.NAME_ENG_;
            this.NAME_KOR_ = clone.NAME_KOR_;
            this.PROVIDER_ = clone.PROVIDER_;
            this.TENOR_ = clone.TENOR_;
            this.SUB_TYPE_ = clone.SUB_TYPE_;
            this.LINKEDCURVE_ = clone.LINKEDCURVE_;
            this.RATE_TYPE_ = clone.RATE_TYPE_;
            this.LEG_TENOR_ = clone.LEG_TENOR_;
            this.CURRENCY_ = clone.CURRENCY_;
        }

    }
}
