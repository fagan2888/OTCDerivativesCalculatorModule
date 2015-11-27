using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace ParallelCalculationMangerServer
{
    public class CALCULATION_QUEUE_INFO_Table_DAO
    {
        public CALCULATION_QUEUE_INFO_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string INST_CODE_ { get; set; }
        public string INST_TYPE_ { get; set; }
        public string INST_NAME_ { get; set; }
        public string PARA_DATE_ { get; set; }
        public string CALCULATION_STATE_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT INST_CODE, INST_TYPE, INST_NAME, PARA_DATE, CALCULATION_STATE " +
         "FROM CALCULATION_QUEUE_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO CALCULATION_QUEUE_INFO (INST_CODE, INST_TYPE, INST_NAME, PARA_DATE, CALCULATION_STATE )" +
        "VALUES ('@INST_CODEVALUE@', '@INST_TYPEVALUE@', '@INST_NAMEVALUE@', '@PARA_DATEVALUE@', '@CALCULATION_STATEVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE CALCULATION_QUEUE_INFO SET INST_CODE='@INST_CODEVALUE@' INST_TYPE='@INST_TYPEVALUE@' INST_NAME='@INST_NAMEVALUE@' PARA_DATE='@PARA_DATEVALUE@' CALCULATION_STATE='@CALCULATION_STATEVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM CALCULATION_QUEUE_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.INST_CODE_ = dataRow["INST_CODE"].ToString();
            this.INST_TYPE_ = dataRow["INST_TYPE"].ToString();
            this.INST_NAME_ = dataRow["INST_NAME"].ToString();
            this.PARA_DATE_ = dataRow["PARA_DATE"].ToString();
            this.CALCULATION_STATE_ = dataRow["CALCULATION_STATE"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = CALCULATION_QUEUE_INFO_Table_DAO.SelectQuery_;

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
                this.INST_CODE_ = item[0].ToString();
                this.INST_TYPE_ = item[1].ToString();
                this.INST_NAME_ = item[2].ToString();
                this.PARA_DATE_ = item[3].ToString();
                this.CALCULATION_STATE_ = item[4].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = CALCULATION_QUEUE_INFO_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@INST_CODEVALUE@", INST_CODE_);
            insertQuery = insertQuery.Replace("@INST_TYPEVALUE@", INST_TYPE_);
            insertQuery = insertQuery.Replace("@INST_NAMEVALUE@", INST_NAME_);
            insertQuery = insertQuery.Replace("@PARA_DATEVALUE@", PARA_DATE_);
            insertQuery = insertQuery.Replace("@CALCULATION_STATEVALUE@", CALCULATION_STATE_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = CALCULATION_QUEUE_INFO_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@INST_CODEVALUE@", INST_CODE_);
            updateQuery = updateQuery.Replace("@INST_TYPEVALUE@", INST_TYPE_);
            updateQuery = updateQuery.Replace("@INST_NAMEVALUE@", INST_NAME_);
            updateQuery = updateQuery.Replace("@PARA_DATEVALUE@", PARA_DATE_);
            updateQuery = updateQuery.Replace("@CALCULATION_STATEVALUE@", CALCULATION_STATE_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = CALCULATION_QUEUE_INFO_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
