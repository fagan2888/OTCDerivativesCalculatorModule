using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace ExcelAddInRibbonTest
{
    public class OPTION_POSITION_1928_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<OPTION_POSITION_1928_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string POSITIONNAME_;
        public string SELLBUY_;
        public string UNIT_;
        public string EVALAMT_;
        public string DELTA_;
        public string GAMMA_;
        public string VEGA_;
        public string IMVOL_;
        public string DELTAPOSITION_;
        public string TOTALRISK_;
        public string DELTARISK_;
        public string GAMMARISK_;
        public string VEGARISK_;
        public string DEEPOTM_;
        public string REMAINDAYS_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT POSITIONNAME, SELLBUY, UNIT, EVALAMT, DELTA, GAMMA, VEGA, IMVOL, DELTAPOSITION, TOTALRISK, DELTARISK, GAMMARISK, VEGARISK, DEEPOTM, REMAINDAYS " +
         "FROM OPTION_POSITION_1928 WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM OPTION_POSITION_1928 WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<OPTION_POSITION_1928_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = OPTION_POSITION_1928_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                OPTION_POSITION_1928_Table_DAO dao = new OPTION_POSITION_1928_Table_DAO();

                dao.POSITIONNAME_ = item[0].ToString();
                dao.SELLBUY_ = item[1].ToString();
                dao.UNIT_ = item[2].ToString();
                dao.EVALAMT_ = item[3].ToString();
                dao.DELTA_ = item[4].ToString();
                dao.GAMMA_ = item[5].ToString();
                dao.VEGA_ = item[6].ToString();
                dao.IMVOL_ = item[7].ToString();
                dao.DELTAPOSITION_ = item[8].ToString();
                dao.TOTALRISK_ = item[9].ToString();
                dao.DELTARISK_ = item[10].ToString();
                dao.GAMMARISK_ = item[11].ToString();
                dao.VEGARISK_ = item[12].ToString();
                dao.DEEPOTM_ = item[13].ToString();
                dao.REMAINDAYS_ = item[14].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = OPTION_POSITION_1928_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
