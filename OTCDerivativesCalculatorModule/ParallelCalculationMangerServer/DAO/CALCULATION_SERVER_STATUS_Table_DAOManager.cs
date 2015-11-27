using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace ParallelCalculationMangerServer
{
    public class CALCULATION_SERVER_STATUS_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<CALCULATION_SERVER_STATUS_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string SERVER_NAME_;
        public string SERVER_IP_;
        public string SERVER_PORT_;
        public string SERVER_STATUS_;
        public string SERVER_CORENUM_;
        public string SERVER_USE_;
        public string SERVER_ALIVETIME_;
        public string SERVER_DESCRIPTION_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT SERVER_NAME, SERVER_IP, SERVER_PORT, SERVER_STATUS, SERVER_CORENUM, SERVER_USE, SERVER_ALIVETIME, SERVER_DESCRIPTION " +
         "FROM CALCULATION_SERVER_STATUS WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM CALCULATION_SERVER_STATUS WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<CALCULATION_SERVER_STATUS_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = CALCULATION_SERVER_STATUS_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                CALCULATION_SERVER_STATUS_Table_DAO dao = new CALCULATION_SERVER_STATUS_Table_DAO();

                dao.SERVER_NAME_ = item[0].ToString();
                dao.SERVER_IP_ = item[1].ToString();
                dao.SERVER_PORT_ = item[2].ToString();
                dao.SERVER_STATUS_ = item[3].ToString();
                dao.SERVER_CORENUM_ = item[4].ToString();
                dao.SERVER_USE_ = item[5].ToString();
                dao.SERVER_ALIVETIME_ = item[6].ToString();
                dao.SERVER_DESCRIPTION_ = item[7].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = CALCULATION_SERVER_STATUS_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
