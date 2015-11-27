using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace ExcelAddInRibbonTest
{
    public class OPTION_POSITION_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<OPTION_POSITION_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string POSITIONNAME_;
        public string CURRPRICE_;
        public string PREDIFF_;
        public string PREDIFFRATE_;
        public string CURRPRICE2_;
        public string PREDIFF2_;
        public string PREDIFFRATE2_;
        public string TRADINGAMT_;
        public string IMVOL_;
        public string GREEK_DELTA_;
        public string GREEK_GAMMA_;
        public string GREEK_VEGA_;
        public string GREEK_THETA_;
        public string GREEK_RHO_;
        public string TRADINGVALUE_;
        public string REMAINAMT_;
        public string REMAINAMTPREDIFF_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT POSITIONNAME, CURRPRICE, PREDIFF, PREDIFFRATE, CURRPRICE2, PREDIFF2, PREDIFFRATE2, TRADINGAMT, IMVOL, GREEK_DELTA, GREEK_GAMMA, GREEK_VEGA, GREEK_THETA, GREEK_RHO, TRADINGVALUE, REMAINAMT, REMAINAMTPREDIFF " +
         "FROM OPTION_POSITION WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM OPTION_POSITION WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<OPTION_POSITION_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = OPTION_POSITION_Table_DAOManager.SelectQuery_;

            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                OPTION_POSITION_Table_DAO dao = new OPTION_POSITION_Table_DAO();

                dao.POSITIONNAME_ = item[0].ToString();
                dao.CURRPRICE_ = item[1].ToString();
                dao.PREDIFF_ = item[2].ToString();
                dao.PREDIFFRATE_ = item[3].ToString();
                dao.CURRPRICE2_ = item[4].ToString();
                dao.PREDIFF2_ = item[5].ToString();
                dao.PREDIFFRATE2_ = item[6].ToString();
                dao.TRADINGAMT_ = item[7].ToString();
                dao.IMVOL_ = item[8].ToString();
                dao.GREEK_DELTA_ = item[9].ToString();
                dao.GREEK_GAMMA_ = item[10].ToString();
                dao.GREEK_VEGA_ = item[11].ToString();
                dao.GREEK_THETA_ = item[12].ToString();
                dao.GREEK_RHO_ = item[13].ToString();
                dao.TRADINGVALUE_ = item[14].ToString();
                dao.REMAINAMT_ = item[15].ToString();
                dao.REMAINAMTPREDIFF_ = item[16].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = OPTION_POSITION_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
