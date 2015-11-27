using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace ExcelAddInRibbonTest
{
    public class OPTION_POSITION_Table_DAO
    {
        public OPTION_POSITION_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string POSITIONNAME_ { get; set; }
        public string CURRPRICE_ { get; set; }
        public string PREDIFF_ { get; set; }
        public string PREDIFFRATE_ { get; set; }
        public string CURRPRICE2_ { get; set; }
        public string PREDIFF2_ { get; set; }
        public string PREDIFFRATE2_ { get; set; }
        public string TRADINGAMT_ { get; set; }
        public string IMVOL_ { get; set; }
        public string GREEK_DELTA_ { get; set; }
        public string GREEK_GAMMA_ { get; set; }
        public string GREEK_VEGA_ { get; set; }
        public string GREEK_THETA_ { get; set; }
        public string GREEK_RHO_ { get; set; }
        public string TRADINGVALUE_ { get; set; }
        public string REMAINAMT_ { get; set; }
        public string REMAINAMTPREDIFF_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT POSITIONNAME, CURRPRICE, PREDIFF, PREDIFFRATE, CURRPRICE2, PREDIFF2, PREDIFFRATE2, TRADINGAMT, IMVOL, GREEK_DELTA, GREEK_GAMMA, GREEK_VEGA, GREEK_THETA, GREEK_RHO, TRADINGVALUE, REMAINAMT, REMAINAMTPREDIFF " +
         "FROM OPTION_POSITION WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO OPTION_POSITION (POSITIONNAME, CURRPRICE, PREDIFF, PREDIFFRATE, CURRPRICE2, PREDIFF2, PREDIFFRATE2, TRADINGAMT, IMVOL, GREEK_DELTA, GREEK_GAMMA, GREEK_VEGA, GREEK_THETA, GREEK_RHO, TRADINGVALUE, REMAINAMT, REMAINAMTPREDIFF )" +
        "VALUES ('@POSITIONNAMEVALUE@', '@CURRPRICEVALUE@', '@PREDIFFVALUE@', '@PREDIFFRATEVALUE@', '@CURRPRICE2VALUE@', '@PREDIFF2VALUE@', '@PREDIFFRATE2VALUE@', '@TRADINGAMTVALUE@', '@IMVOLVALUE@', '@GREEK_DELTAVALUE@', '@GREEK_GAMMAVALUE@', '@GREEK_VEGAVALUE@', '@GREEK_THETAVALUE@', '@GREEK_RHOVALUE@', '@TRADINGVALUEVALUE@', '@REMAINAMTVALUE@', '@REMAINAMTPREDIFFVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE OPTION_POSITION SET POSITIONNAME='@POSITIONNAMEVALUE@' CURRPRICE='@CURRPRICEVALUE@' PREDIFF='@PREDIFFVALUE@' PREDIFFRATE='@PREDIFFRATEVALUE@' CURRPRICE2='@CURRPRICE2VALUE@' PREDIFF2='@PREDIFF2VALUE@' PREDIFFRATE2='@PREDIFFRATE2VALUE@' TRADINGAMT='@TRADINGAMTVALUE@' IMVOL='@IMVOLVALUE@' GREEK_DELTA='@GREEK_DELTAVALUE@' GREEK_GAMMA='@GREEK_GAMMAVALUE@' GREEK_VEGA='@GREEK_VEGAVALUE@' GREEK_THETA='@GREEK_THETAVALUE@' GREEK_RHO='@GREEK_RHOVALUE@' TRADINGVALUE='@TRADINGVALUEVALUE@' REMAINAMT='@REMAINAMTVALUE@' REMAINAMTPREDIFF='@REMAINAMTPREDIFFVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM OPTION_POSITION WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.POSITIONNAME_ = dataRow["POSITIONNAME"].ToString();
            this.CURRPRICE_ = dataRow["CURRPRICE"].ToString();
            this.PREDIFF_ = dataRow["PREDIFF"].ToString();
            this.PREDIFFRATE_ = dataRow["PREDIFFRATE"].ToString();
            this.CURRPRICE2_ = dataRow["CURRPRICE2"].ToString();
            this.PREDIFF2_ = dataRow["PREDIFF2"].ToString();
            this.PREDIFFRATE2_ = dataRow["PREDIFFRATE2"].ToString();
            this.TRADINGAMT_ = dataRow["TRADINGAMT"].ToString();
            this.IMVOL_ = dataRow["IMVOL"].ToString();
            this.GREEK_DELTA_ = dataRow["GREEK_DELTA"].ToString();
            this.GREEK_GAMMA_ = dataRow["GREEK_GAMMA"].ToString();
            this.GREEK_VEGA_ = dataRow["GREEK_VEGA"].ToString();
            this.GREEK_THETA_ = dataRow["GREEK_THETA"].ToString();
            this.GREEK_RHO_ = dataRow["GREEK_RHO"].ToString();
            this.TRADINGVALUE_ = dataRow["TRADINGVALUE"].ToString();
            this.REMAINAMT_ = dataRow["REMAINAMT"].ToString();
            this.REMAINAMTPREDIFF_ = dataRow["REMAINAMTPREDIFF"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = OPTION_POSITION_Table_DAO.SelectQuery_;

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
                this.POSITIONNAME_ = item[0].ToString();
                this.CURRPRICE_ = item[1].ToString();
                this.PREDIFF_ = item[2].ToString();
                this.PREDIFFRATE_ = item[3].ToString();
                this.CURRPRICE2_ = item[4].ToString();
                this.PREDIFF2_ = item[5].ToString();
                this.PREDIFFRATE2_ = item[6].ToString();
                this.TRADINGAMT_ = item[7].ToString();
                this.IMVOL_ = item[8].ToString();
                this.GREEK_DELTA_ = item[9].ToString();
                this.GREEK_GAMMA_ = item[10].ToString();
                this.GREEK_VEGA_ = item[11].ToString();
                this.GREEK_THETA_ = item[12].ToString();
                this.GREEK_RHO_ = item[13].ToString();
                this.TRADINGVALUE_ = item[14].ToString();
                this.REMAINAMT_ = item[15].ToString();
                this.REMAINAMTPREDIFF_ = item[16].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = OPTION_POSITION_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@POSITIONNAMEVALUE@", POSITIONNAME_);
            insertQuery = insertQuery.Replace("@CURRPRICEVALUE@", CURRPRICE_);
            insertQuery = insertQuery.Replace("@PREDIFFVALUE@", PREDIFF_);
            insertQuery = insertQuery.Replace("@PREDIFFRATEVALUE@", PREDIFFRATE_);
            insertQuery = insertQuery.Replace("@CURRPRICE2VALUE@", CURRPRICE2_);
            insertQuery = insertQuery.Replace("@PREDIFF2VALUE@", PREDIFF2_);
            insertQuery = insertQuery.Replace("@PREDIFFRATE2VALUE@", PREDIFFRATE2_);
            insertQuery = insertQuery.Replace("@TRADINGAMTVALUE@", TRADINGAMT_);
            insertQuery = insertQuery.Replace("@IMVOLVALUE@", IMVOL_);
            insertQuery = insertQuery.Replace("@GREEK_DELTAVALUE@", GREEK_DELTA_);
            insertQuery = insertQuery.Replace("@GREEK_GAMMAVALUE@", GREEK_GAMMA_);
            insertQuery = insertQuery.Replace("@GREEK_VEGAVALUE@", GREEK_VEGA_);
            insertQuery = insertQuery.Replace("@GREEK_THETAVALUE@", GREEK_THETA_);
            insertQuery = insertQuery.Replace("@GREEK_RHOVALUE@", GREEK_RHO_);
            insertQuery = insertQuery.Replace("@TRADINGVALUEVALUE@", TRADINGVALUE_);
            insertQuery = insertQuery.Replace("@REMAINAMTVALUE@", REMAINAMT_);
            insertQuery = insertQuery.Replace("@REMAINAMTPREDIFFVALUE@", REMAINAMTPREDIFF_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = OPTION_POSITION_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@POSITIONNAMEVALUE@", POSITIONNAME_);
            updateQuery = updateQuery.Replace("@CURRPRICEVALUE@", CURRPRICE_);
            updateQuery = updateQuery.Replace("@PREDIFFVALUE@", PREDIFF_);
            updateQuery = updateQuery.Replace("@PREDIFFRATEVALUE@", PREDIFFRATE_);
            updateQuery = updateQuery.Replace("@CURRPRICE2VALUE@", CURRPRICE2_);
            updateQuery = updateQuery.Replace("@PREDIFF2VALUE@", PREDIFF2_);
            updateQuery = updateQuery.Replace("@PREDIFFRATE2VALUE@", PREDIFFRATE2_);
            updateQuery = updateQuery.Replace("@TRADINGAMTVALUE@", TRADINGAMT_);
            updateQuery = updateQuery.Replace("@IMVOLVALUE@", IMVOL_);
            updateQuery = updateQuery.Replace("@GREEK_DELTAVALUE@", GREEK_DELTA_);
            updateQuery = updateQuery.Replace("@GREEK_GAMMAVALUE@", GREEK_GAMMA_);
            updateQuery = updateQuery.Replace("@GREEK_VEGAVALUE@", GREEK_VEGA_);
            updateQuery = updateQuery.Replace("@GREEK_THETAVALUE@", GREEK_THETA_);
            updateQuery = updateQuery.Replace("@GREEK_RHOVALUE@", GREEK_RHO_);
            updateQuery = updateQuery.Replace("@TRADINGVALUEVALUE@", TRADINGVALUE_);
            updateQuery = updateQuery.Replace("@REMAINAMTVALUE@", REMAINAMT_);
            updateQuery = updateQuery.Replace("@REMAINAMTPREDIFFVALUE@", REMAINAMTPREDIFF_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = OPTION_POSITION_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
