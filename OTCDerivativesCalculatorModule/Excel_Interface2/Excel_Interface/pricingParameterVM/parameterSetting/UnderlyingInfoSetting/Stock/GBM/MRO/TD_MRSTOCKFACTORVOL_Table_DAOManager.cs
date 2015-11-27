using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class OTC_TD_MRSTOCKFACTORVOL_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<OTC_TD_MRSTOCKFACTORVOL_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string STD_DATE_;
        public string KR_CODE_;
        public string STOCK_ID_;
        public string VOL_;
        public string QUANTO_VOL_;
        public string QUANTO_RHO_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT STD_DATE, KR_CODE, STOCK_ID, VOL, QUANTO_VOL, QUANTO_RHO " +
         "FROM OTC_TD_MRSTOCKFACTORVOL WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM OTC_TD_MRSTOCKFACTORVOL WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<OTC_TD_MRSTOCKFACTORVOL_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = OTC_TD_MRSTOCKFACTORVOL_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                OTC_TD_MRSTOCKFACTORVOL_Table_DAO dao = new OTC_TD_MRSTOCKFACTORVOL_Table_DAO();

                dao.STD_DATE_ = item[0].ToString();
                dao.KR_CODE_ = item[1].ToString();
                dao.STOCK_ID_ = item[2].ToString();
                dao.VOL_ = item[3].ToString();
                dao.QUANTO_VOL_ = item[4].ToString();
                dao.QUANTO_RHO_ = item[5].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = OTC_TD_MRSTOCKFACTORVOL_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
