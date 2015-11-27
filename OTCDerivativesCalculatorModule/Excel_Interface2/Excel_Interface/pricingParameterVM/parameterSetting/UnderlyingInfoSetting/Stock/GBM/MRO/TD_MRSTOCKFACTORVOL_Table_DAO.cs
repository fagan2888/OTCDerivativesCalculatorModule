using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class OTC_TD_MRSTOCKFACTORVOL_Table_DAO
    {
        public OTC_TD_MRSTOCKFACTORVOL_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string STD_DATE_ { get; set; }
        public string KR_CODE_ { get; set; }
        public string STOCK_ID_ { get; set; }
        public string VOL_ { get; set; }
        public string QUANTO_VOL_ { get; set; }
        public string QUANTO_RHO_ { get; set; }

        #endregion

        #region built-in-Query

        private static string Select_date_code_id_Query_
        = "SELECT STD_DATE, KR_CODE, STOCK_ID, VOL, QUANTO_VOL, QUANTO_RHO " +
         "FROM OTC_TD_MRSTOCKFACTORVOL " + 
         "WHERE STD_DATE = '@STD_DATEValue@' AND " +
         "KR_CODE = '@KR_CODEValue@' AND " +
         "STOCK_ID = '@STOCK_IDValue@'";

        private static string SelectQuery_
        = "SELECT STD_DATE, KR_CODE, STOCK_ID, VOL, QUANTO_VOL, QUANTO_RHO " +
         "FROM OTC_TD_MRSTOCKFACTORVOL WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO OTC_TD_MRSTOCKFACTORVOL (STD_DATE, KR_CODE, STOCK_ID, VOL, QUANTO_VOL, QUANTO_RHO )" +
        "VALUES ('@STD_DATEVALUE@', '@KR_CODEVALUE@', '@STOCK_IDVALUE@', '@VOLVALUE@', '@QUANTO_VOLVALUE@', '@QUANTO_RHOVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE OTC_TD_MRSTOCKFACTORVOL SET STD_DATE='@STD_DATEVALUE@' KR_CODE='@KR_CODEVALUE@' STOCK_ID='@STOCK_IDVALUE@' VOL='@VOLVALUE@' QUANTO_VOL='@QUANTO_VOLVALUE@' QUANTO_RHO='@QUANTO_RHOVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM OTC_TD_MRSTOCKFACTORVOL WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.STD_DATE_ = dataRow["STD_DATE"].ToString();
            this.KR_CODE_ = dataRow["KR_CODE"].ToString();
            this.STOCK_ID_ = dataRow["STOCK_ID"].ToString();
            this.VOL_ = dataRow["VOL"].ToString();
            this.QUANTO_VOL_ = dataRow["QUANTO_VOL"].ToString();
            this.QUANTO_RHO_ = dataRow["QUANTO_RHO"].ToString();
        }

        public string select_date_code_id(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            try
            {
                DataTable tb = new DataTable();

                DbCommand dbCommand = conn.CreateCommand();

                string select_date_code_id_Query = OTC_TD_MRSTOCKFACTORVOL_Table_DAO.Select_date_code_id_Query_;

                select_date_code_id_Query = select_date_code_id_Query.Replace("@STD_DATEValue@", this.STD_DATE_);
                select_date_code_id_Query = select_date_code_id_Query.Replace("@KR_CODEValue@", this.KR_CODE_);
                select_date_code_id_Query = select_date_code_id_Query.Replace("@STOCK_IDValue@", this.STOCK_ID_);

                dbCommand.CommandText = select_date_code_id_Query;

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
                    this.KR_CODE_ = item[1].ToString();
                    this.STOCK_ID_ = item[2].ToString();
                    this.VOL_ = item[3].ToString();
                    this.QUANTO_VOL_ = item[4].ToString();
                    this.QUANTO_RHO_ = item[5].ToString();
                }

                conn.Close();

                return select_date_code_id_Query;
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
            try
            {
                DataTable tb = new DataTable();

                DbCommand dbCommand = conn.CreateCommand();

                string selectQuery = OTC_TD_MRSTOCKFACTORVOL_Table_DAO.SelectQuery_;

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
                    this.KR_CODE_ = item[1].ToString();
                    this.STOCK_ID_ = item[2].ToString();
                    this.VOL_ = item[3].ToString();
                    this.QUANTO_VOL_ = item[4].ToString();
                    this.QUANTO_RHO_ = item[5].ToString();
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

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = OTC_TD_MRSTOCKFACTORVOL_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@STD_DATEVALUE@", STD_DATE_);
            insertQuery = insertQuery.Replace("@KR_CODEVALUE@", KR_CODE_);
            insertQuery = insertQuery.Replace("@STOCK_IDVALUE@", STOCK_ID_);
            insertQuery = insertQuery.Replace("@VOLVALUE@", VOL_);
            insertQuery = insertQuery.Replace("@QUANTO_VOLVALUE@", QUANTO_VOL_);
            insertQuery = insertQuery.Replace("@QUANTO_RHOVALUE@", QUANTO_RHO_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = OTC_TD_MRSTOCKFACTORVOL_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@STD_DATEVALUE@", STD_DATE_);
            updateQuery = updateQuery.Replace("@KR_CODEVALUE@", KR_CODE_);
            updateQuery = updateQuery.Replace("@STOCK_IDVALUE@", STOCK_ID_);
            updateQuery = updateQuery.Replace("@VOLVALUE@", VOL_);
            updateQuery = updateQuery.Replace("@QUANTO_VOLVALUE@", QUANTO_VOL_);
            updateQuery = updateQuery.Replace("@QUANTO_RHOVALUE@", QUANTO_RHO_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = OTC_TD_MRSTOCKFACTORVOL_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
