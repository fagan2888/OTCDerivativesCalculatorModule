using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class OTC_TD_MRELSSTOCKCORR_Table_DAO
    {
        public OTC_TD_MRELSSTOCKCORR_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string STD_DATE_ { get; set; }
        public string STOCK_ID_ { get; set; }
        public string OTHER_ID_ { get; set; }
        public string CORR_ { get; set; }

        #endregion

        #region built-in-Query

        private static string Select_date_id_otherid_Query_
        = "SELECT STD_DATE, STOCK_ID, OTHER_ID, CORR " +
         "FROM OTC_TD_MRELSSTOCKCORR " +
         "WHERE STD_DATE = '@STD_DATEValue@' AND " +
         "STOCK_ID = '@STOCK_IDValue@' " +
         "AND OTHER_ID = '@OTHER_IDValue@'";

        private static string SelectQuery_
        = "SELECT STD_DATE, STOCK_ID, OTHER_ID, CORR " +
         "FROM OTC_TD_MRELSSTOCKCORR WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO OTC_TD_MRELSSTOCKCORR (STD_DATE, STOCK_ID, OTHER_ID, CORR )" +
        "VALUES ('@STD_DATEVALUE@', '@STOCK_IDVALUE@', '@OTHER_IDVALUE@', '@CORRVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE OTC_TD_MRELSSTOCKCORR SET STD_DATE='@STD_DATEVALUE@' STOCK_ID='@STOCK_IDVALUE@' OTHER_ID='@OTHER_IDVALUE@' CORR='@CORRVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM OTC_TD_MRELSSTOCKCORR WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.STD_DATE_ = dataRow["STD_DATE"].ToString();
            this.STOCK_ID_ = dataRow["STOCK_ID"].ToString();
            this.OTHER_ID_ = dataRow["OTHER_ID"].ToString();
            this.CORR_ = dataRow["CORR"].ToString();
        }

        public void select_date_id_otherid_Query(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                DbCommand dbCommand = conn.CreateCommand();

                string select_date_id_otherid_Query = OTC_TD_MRELSSTOCKCORR_Table_DAO.Select_date_id_otherid_Query_;

                select_date_id_otherid_Query = select_date_id_otherid_Query.Replace("@STD_DATEValue@", this.STD_DATE_);
                select_date_id_otherid_Query = select_date_id_otherid_Query.Replace("@STOCK_IDValue@", this.STOCK_ID_);
                select_date_id_otherid_Query = select_date_id_otherid_Query.Replace("@OTHER_IDValue@", this.OTHER_ID_);

                dbCommand.CommandText = select_date_id_otherid_Query;

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
                    this.OTHER_ID_ = item[2].ToString();
                    this.CORR_ = item[3].ToString();
                }

                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
     

        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = OTC_TD_MRELSSTOCKCORR_Table_DAO.SelectQuery_;

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
                this.STD_DATE_ = item[0].ToString();
                this.STOCK_ID_ = item[1].ToString();
                this.OTHER_ID_ = item[2].ToString();
                this.CORR_ = item[3].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = OTC_TD_MRELSSTOCKCORR_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@STD_DATEVALUE@", STD_DATE_);
            insertQuery = insertQuery.Replace("@STOCK_IDVALUE@", STOCK_ID_);
            insertQuery = insertQuery.Replace("@OTHER_IDVALUE@", OTHER_ID_);
            insertQuery = insertQuery.Replace("@CORRVALUE@", CORR_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = OTC_TD_MRELSSTOCKCORR_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@STD_DATEVALUE@", STD_DATE_);
            updateQuery = updateQuery.Replace("@STOCK_IDVALUE@", STOCK_ID_);
            updateQuery = updateQuery.Replace("@OTHER_IDVALUE@", OTHER_ID_);
            updateQuery = updateQuery.Replace("@CORRVALUE@", CORR_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = OTC_TD_MRELSSTOCKCORR_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
