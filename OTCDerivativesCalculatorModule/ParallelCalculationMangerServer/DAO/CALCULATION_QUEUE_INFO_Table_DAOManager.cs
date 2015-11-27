using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace ParallelCalculationMangerServer
{
    public class CALCULATION_QUEUE_INFO_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<CALCULATION_QUEUE_INFO_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string INST_CODE_;
        public string INST_TYPE_;
        public string INST_NAME_;
        public string PARA_DATE_;
        public string CALCULATION_STATE_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT INST_CODE, INST_TYPE, INST_NAME, PARA_DATE, CALCULATION_STATE " +
         "FROM CALCULATION_QUEUE_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM CALCULATION_QUEUE_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<CALCULATION_QUEUE_INFO_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = CALCULATION_QUEUE_INFO_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                CALCULATION_QUEUE_INFO_Table_DAO dao = new CALCULATION_QUEUE_INFO_Table_DAO();

                dao.INST_CODE_ = item[0].ToString();
                dao.INST_TYPE_ = item[1].ToString();
                dao.INST_NAME_ = item[2].ToString();
                dao.PARA_DATE_ = item[3].ToString();
                dao.CALCULATION_STATE_ = item[4].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = CALCULATION_QUEUE_INFO_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
