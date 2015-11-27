using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class HOLIDAY_INFO_Table_DAO
    {
        public HOLIDAY_INFO_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string HOLIDAY_DATE_ { get; set; }
        public string HOLIDAY_NAME_ { get; set; }
        public string HOLIDAY_COUNTRY_NAME_ { get; set; }
        public string HOLIDAY_CURRENCY_CODE_ { get; set; }
        public string HOLIDAY_TYPE_ { get; set; }
        public string USING_START_DATE_ { get; set; }
        public string USING_END_DATE_ { get; set; }
        public string DESCRIPTION_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT HOLIDAY_DATE, HOLIDAY_NAME, HOLIDAY_COUNTRY_NAME, HOLIDAY_CURRENCY_CODE, HOLIDAY_TYPE, USING_START_DATE, USING_END_DATE, DESCRIPTION " +
         "FROM HOLIDAY_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO HOLIDAY_INFO (HOLIDAY_DATE, HOLIDAY_NAME, HOLIDAY_COUNTRY_NAME, HOLIDAY_CURRENCY_CODE, HOLIDAY_TYPE, USING_START_DATE, USING_END_DATE, DESCRIPTION )" +
        "VALUES ('@HOLIDAY_DATEVALUE@', '@HOLIDAY_NAMEVALUE@', '@HOLIDAY_COUNTRY_NAMEVALUE@', '@HOLIDAY_CURRENCY_CODEVALUE@', '@HOLIDAY_TYPEVALUE@', '@USING_START_DATEVALUE@', '@USING_END_DATEVALUE@', '@DESCRIPTIONVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE HOLIDAY_INFO SET HOLIDAY_DATE='@HOLIDAY_DATEVALUE@' HOLIDAY_NAME='@HOLIDAY_NAMEVALUE@' HOLIDAY_COUNTRY_NAME='@HOLIDAY_COUNTRY_NAMEVALUE@' HOLIDAY_CURRENCY_CODE='@HOLIDAY_CURRENCY_CODEVALUE@' HOLIDAY_TYPE='@HOLIDAY_TYPEVALUE@' USING_START_DATE='@USING_START_DATEVALUE@' USING_END_DATE='@USING_END_DATEVALUE@' DESCRIPTION='@DESCRIPTIONVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM HOLIDAY_INFO WHERE HOLIDAY_DATE = '@HOLIDAY_DATEVALUE@' AND HOLIDAY_COUNTRY_NAME = '@HOLIDAY_COUNTRY_NAMEVALUE@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.HOLIDAY_DATE_ = dataRow["HOLIDAY_DATE"].ToString();
            this.HOLIDAY_NAME_ = dataRow["HOLIDAY_NAME"].ToString();
            this.HOLIDAY_COUNTRY_NAME_ = dataRow["HOLIDAY_COUNTRY_NAME"].ToString();
            this.HOLIDAY_CURRENCY_CODE_ = dataRow["HOLIDAY_CURRENCY_CODE"].ToString();
            this.HOLIDAY_TYPE_ = dataRow["HOLIDAY_TYPE"].ToString();
            this.USING_START_DATE_ = dataRow["USING_START_DATE"].ToString();
            this.USING_END_DATE_ = dataRow["USING_END_DATE"].ToString();
            this.DESCRIPTION_ = dataRow["DESCRIPTION"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = HOLIDAY_INFO_Table_DAO.SelectQuery_;

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
                this.HOLIDAY_DATE_ = item[0].ToString();
                this.HOLIDAY_NAME_ = item[1].ToString();
                this.HOLIDAY_COUNTRY_NAME_ = item[2].ToString();
                this.HOLIDAY_CURRENCY_CODE_ = item[3].ToString();
                this.HOLIDAY_TYPE_ = item[4].ToString();
                this.USING_START_DATE_ = item[5].ToString();
                this.USING_END_DATE_ = item[6].ToString();
                this.DESCRIPTION_ = item[7].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = HOLIDAY_INFO_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@HOLIDAY_DATEVALUE@", HOLIDAY_DATE_);
            insertQuery = insertQuery.Replace("@HOLIDAY_NAMEVALUE@", HOLIDAY_NAME_);
            insertQuery = insertQuery.Replace("@HOLIDAY_COUNTRY_NAMEVALUE@", HOLIDAY_COUNTRY_NAME_);
            insertQuery = insertQuery.Replace("@HOLIDAY_CURRENCY_CODEVALUE@", HOLIDAY_CURRENCY_CODE_);
            insertQuery = insertQuery.Replace("@HOLIDAY_TYPEVALUE@", HOLIDAY_TYPE_);
            insertQuery = insertQuery.Replace("@USING_START_DATEVALUE@", USING_START_DATE_);
            insertQuery = insertQuery.Replace("@USING_END_DATEVALUE@", USING_END_DATE_);
            insertQuery = insertQuery.Replace("@DESCRIPTIONVALUE@", DESCRIPTION_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = HOLIDAY_INFO_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@HOLIDAY_DATEVALUE@", HOLIDAY_DATE_);
            updateQuery = updateQuery.Replace("@HOLIDAY_NAMEVALUE@", HOLIDAY_NAME_);
            updateQuery = updateQuery.Replace("@HOLIDAY_COUNTRY_NAMEVALUE@", HOLIDAY_COUNTRY_NAME_);
            updateQuery = updateQuery.Replace("@HOLIDAY_CURRENCY_CODEVALUE@", HOLIDAY_CURRENCY_CODE_);
            updateQuery = updateQuery.Replace("@HOLIDAY_TYPEVALUE@", HOLIDAY_TYPE_);
            updateQuery = updateQuery.Replace("@USING_START_DATEVALUE@", USING_START_DATE_);
            updateQuery = updateQuery.Replace("@USING_END_DATEVALUE@", USING_END_DATE_);
            updateQuery = updateQuery.Replace("@DESCRIPTIONVALUE@", DESCRIPTION_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = HOLIDAY_INFO_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@HOLIDAY_DATEVALUE@", this.HOLIDAY_DATE_);
            deleteQuery = deleteQuery.Replace("@HOLIDAY_COUNTRY_NAMEVALUE@", this.HOLIDAY_COUNTRY_NAME_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }


        public bool hasHoliday(string dateStr_yyyyMMdd)
        {
            this.HOLIDAY_DATE_ = dateStr_yyyyMMdd;

            this.select(DataBaseConnectManager.ConnectionFactory("mydb"));
            

            return false;
        }
    }
}
