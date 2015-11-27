using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace ParallelCalculationMangerServer
{
    public class CALCULATION_SERVER_STATUS_Table_DAO
    {
        public CALCULATION_SERVER_STATUS_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string SERVER_NAME_ { get; set; }
        public string SERVER_IP_ { get; set; }
        public string SERVER_PORT_ { get; set; }
        public string SERVER_STATUS_ { get; set; }
        public string SERVER_CORENUM_ { get; set; }
        public string SERVER_USE_ { get; set; }
        public string SERVER_ALIVETIME_ { get; set; }
        public string SERVER_DESCRIPTION_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT SERVER_NAME, SERVER_IP, SERVER_PORT, SERVER_STATUS, SERVER_CORENUM, SERVER_USE, SERVER_ALIVETIME, SERVER_DESCRIPTION " +
         "FROM CALCULATION_SERVER_STATUS WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO CALCULATION_SERVER_STATUS (SERVER_NAME, SERVER_IP, SERVER_PORT, SERVER_STATUS, SERVER_CORENUM, SERVER_USE, SERVER_ALIVETIME, SERVER_DESCRIPTION )" +
        "VALUES ('@SERVER_NAMEVALUE@', '@SERVER_IPVALUE@', '@SERVER_PORTVALUE@', '@SERVER_STATUSVALUE@', '@SERVER_CORENUMVALUE@', '@SERVER_USEVALUE@', '@SERVER_ALIVETIMEVALUE@', '@SERVER_DESCRIPTIONVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE CALCULATION_SERVER_STATUS SET SERVER_NAME='@SERVER_NAMEVALUE@' SERVER_IP='@SERVER_IPVALUE@' SERVER_PORT='@SERVER_PORTVALUE@' SERVER_STATUS='@SERVER_STATUSVALUE@' SERVER_CORENUM='@SERVER_CORENUMVALUE@' SERVER_USE='@SERVER_USEVALUE@' SERVER_ALIVETIME='@SERVER_ALIVETIMEVALUE@' SERVER_DESCRIPTION='@SERVER_DESCRIPTIONVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM CALCULATION_SERVER_STATUS WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.SERVER_NAME_ = dataRow["SERVER_NAME"].ToString();
            this.SERVER_IP_ = dataRow["SERVER_IP"].ToString();
            this.SERVER_PORT_ = dataRow["SERVER_PORT"].ToString();
            this.SERVER_STATUS_ = dataRow["SERVER_STATUS"].ToString();
            this.SERVER_CORENUM_ = dataRow["SERVER_CORENUM"].ToString();
            this.SERVER_USE_ = dataRow["SERVER_USE"].ToString();
            this.SERVER_ALIVETIME_ = dataRow["SERVER_ALIVETIME"].ToString();
            this.SERVER_DESCRIPTION_ = dataRow["SERVER_DESCRIPTION"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = CALCULATION_SERVER_STATUS_Table_DAO.SelectQuery_;

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
                this.SERVER_NAME_ = item[0].ToString();
                this.SERVER_IP_ = item[1].ToString();
                this.SERVER_PORT_ = item[2].ToString();
                this.SERVER_STATUS_ = item[3].ToString();
                this.SERVER_CORENUM_ = item[4].ToString();
                this.SERVER_USE_ = item[5].ToString();
                this.SERVER_ALIVETIME_ = item[6].ToString();
                this.SERVER_DESCRIPTION_ = item[7].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = CALCULATION_SERVER_STATUS_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@SERVER_NAMEVALUE@", SERVER_NAME_);
            insertQuery = insertQuery.Replace("@SERVER_IPVALUE@", SERVER_IP_);
            insertQuery = insertQuery.Replace("@SERVER_PORTVALUE@", SERVER_PORT_);
            insertQuery = insertQuery.Replace("@SERVER_STATUSVALUE@", SERVER_STATUS_);
            insertQuery = insertQuery.Replace("@SERVER_CORENUMVALUE@", SERVER_CORENUM_);
            insertQuery = insertQuery.Replace("@SERVER_USEVALUE@", SERVER_USE_);
            insertQuery = insertQuery.Replace("@SERVER_ALIVETIMEVALUE@", SERVER_ALIVETIME_);
            insertQuery = insertQuery.Replace("@SERVER_DESCRIPTIONVALUE@", SERVER_DESCRIPTION_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = CALCULATION_SERVER_STATUS_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@SERVER_NAMEVALUE@", SERVER_NAME_);
            updateQuery = updateQuery.Replace("@SERVER_IPVALUE@", SERVER_IP_);
            updateQuery = updateQuery.Replace("@SERVER_PORTVALUE@", SERVER_PORT_);
            updateQuery = updateQuery.Replace("@SERVER_STATUSVALUE@", SERVER_STATUS_);
            updateQuery = updateQuery.Replace("@SERVER_CORENUMVALUE@", SERVER_CORENUM_);
            updateQuery = updateQuery.Replace("@SERVER_USEVALUE@", SERVER_USE_);
            updateQuery = updateQuery.Replace("@SERVER_ALIVETIMEVALUE@", SERVER_ALIVETIME_);
            updateQuery = updateQuery.Replace("@SERVER_DESCRIPTIONVALUE@", SERVER_DESCRIPTION_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = CALCULATION_SERVER_STATUS_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
