using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace ExcelAddInRibbonTest
{
    public class OPTION_POSITION_1928_Table_DAO
    {
        public OPTION_POSITION_1928_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string POSITIONNAME_ { get; set; }
        public string SELLBUY_ { get; set; }
        public string UNIT_ { get; set; }
        public string EVALAMT_ { get; set; }
        public string DELTA_ { get; set; }
        public string GAMMA_ { get; set; }
        public string VEGA_ { get; set; }
        public string IMVOL_ { get; set; }
        public string DELTAPOSITION_ { get; set; }
        public string TOTALRISK_ { get; set; }
        public string DELTARISK_ { get; set; }
        public string GAMMARISK_ { get; set; }
        public string VEGARISK_ { get; set; }
        public string DEEPOTM_ { get; set; }
        public string REMAINDAYS_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT POSITIONNAME, SELLBUY, UNIT, EVALAMT, DELTA, GAMMA, VEGA, IMVOL, DELTAPOSITION, TOTALRISK, DELTARISK, GAMMARISK, VEGARISK, DEEPOTM, REMAINDAYS " +
         "FROM OPTION_POSITION_1928 WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO OPTION_POSITION_1928 (POSITIONNAME, SELLBUY, UNIT, EVALAMT, DELTA, GAMMA, VEGA, IMVOL, DELTAPOSITION, TOTALRISK, DELTARISK, GAMMARISK, VEGARISK, DEEPOTM, REMAINDAYS )" +
        "VALUES ('@POSITIONNAMEVALUE@', '@SELLBUYVALUE@', '@UNITVALUE@', '@EVALAMTVALUE@', '@DELTAVALUE@', '@GAMMAVALUE@', '@VEGAVALUE@', '@IMVOLVALUE@', '@DELTAPOSITIONVALUE@', '@TOTALRISKVALUE@', '@DELTARISKVALUE@', '@GAMMARISKVALUE@', '@VEGARISKVALUE@', '@DEEPOTMVALUE@', '@REMAINDAYSVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE OPTION_POSITION_1928 SET POSITIONNAME='@POSITIONNAMEVALUE@' SELLBUY='@SELLBUYVALUE@' UNIT='@UNITVALUE@' EVALAMT='@EVALAMTVALUE@' DELTA='@DELTAVALUE@' GAMMA='@GAMMAVALUE@' VEGA='@VEGAVALUE@' IMVOL='@IMVOLVALUE@' DELTAPOSITION='@DELTAPOSITIONVALUE@' TOTALRISK='@TOTALRISKVALUE@' DELTARISK='@DELTARISKVALUE@' GAMMARISK='@GAMMARISKVALUE@' VEGARISK='@VEGARISKVALUE@' DEEPOTM='@DEEPOTMVALUE@' REMAINDAYS='@REMAINDAYSVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM OPTION_POSITION_1928 WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.POSITIONNAME_ = dataRow["POSITIONNAME"].ToString();
            this.SELLBUY_ = dataRow["SELLBUY"].ToString();
            this.UNIT_ = dataRow["UNIT"].ToString();
            this.EVALAMT_ = dataRow["EVALAMT"].ToString();
            this.DELTA_ = dataRow["DELTA"].ToString();
            this.GAMMA_ = dataRow["GAMMA"].ToString();
            this.VEGA_ = dataRow["VEGA"].ToString();
            this.IMVOL_ = dataRow["IMVOL"].ToString();
            this.DELTAPOSITION_ = dataRow["DELTAPOSITION"].ToString();
            this.TOTALRISK_ = dataRow["TOTALRISK"].ToString();
            this.DELTARISK_ = dataRow["DELTARISK"].ToString();
            this.GAMMARISK_ = dataRow["GAMMARISK"].ToString();
            this.VEGARISK_ = dataRow["VEGARISK"].ToString();
            this.DEEPOTM_ = dataRow["DEEPOTM"].ToString();
            this.REMAINDAYS_ = dataRow["REMAINDAYS"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = OPTION_POSITION_1928_Table_DAO.SelectQuery_;

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
                this.SELLBUY_ = item[1].ToString();
                this.UNIT_ = item[2].ToString();
                this.EVALAMT_ = item[3].ToString();
                this.DELTA_ = item[4].ToString();
                this.GAMMA_ = item[5].ToString();
                this.VEGA_ = item[6].ToString();
                this.IMVOL_ = item[7].ToString();
                this.DELTAPOSITION_ = item[8].ToString();
                this.TOTALRISK_ = item[9].ToString();
                this.DELTARISK_ = item[10].ToString();
                this.GAMMARISK_ = item[11].ToString();
                this.VEGARISK_ = item[12].ToString();
                this.DEEPOTM_ = item[13].ToString();
                this.REMAINDAYS_ = item[14].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = OPTION_POSITION_1928_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@POSITIONNAMEVALUE@", POSITIONNAME_);
            insertQuery = insertQuery.Replace("@SELLBUYVALUE@", SELLBUY_);
            insertQuery = insertQuery.Replace("@UNITVALUE@", UNIT_);
            insertQuery = insertQuery.Replace("@EVALAMTVALUE@", EVALAMT_);
            insertQuery = insertQuery.Replace("@DELTAVALUE@", DELTA_);
            insertQuery = insertQuery.Replace("@GAMMAVALUE@", GAMMA_);
            insertQuery = insertQuery.Replace("@VEGAVALUE@", VEGA_);
            insertQuery = insertQuery.Replace("@IMVOLVALUE@", IMVOL_);
            insertQuery = insertQuery.Replace("@DELTAPOSITIONVALUE@", DELTAPOSITION_);
            insertQuery = insertQuery.Replace("@TOTALRISKVALUE@", TOTALRISK_);
            insertQuery = insertQuery.Replace("@DELTARISKVALUE@", DELTARISK_);
            insertQuery = insertQuery.Replace("@GAMMARISKVALUE@", GAMMARISK_);
            insertQuery = insertQuery.Replace("@VEGARISKVALUE@", VEGARISK_);
            insertQuery = insertQuery.Replace("@DEEPOTMVALUE@", DEEPOTM_);
            insertQuery = insertQuery.Replace("@REMAINDAYSVALUE@", REMAINDAYS_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = OPTION_POSITION_1928_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@POSITIONNAMEVALUE@", POSITIONNAME_);
            updateQuery = updateQuery.Replace("@SELLBUYVALUE@", SELLBUY_);
            updateQuery = updateQuery.Replace("@UNITVALUE@", UNIT_);
            updateQuery = updateQuery.Replace("@EVALAMTVALUE@", EVALAMT_);
            updateQuery = updateQuery.Replace("@DELTAVALUE@", DELTA_);
            updateQuery = updateQuery.Replace("@GAMMAVALUE@", GAMMA_);
            updateQuery = updateQuery.Replace("@VEGAVALUE@", VEGA_);
            updateQuery = updateQuery.Replace("@IMVOLVALUE@", IMVOL_);
            updateQuery = updateQuery.Replace("@DELTAPOSITIONVALUE@", DELTAPOSITION_);
            updateQuery = updateQuery.Replace("@TOTALRISKVALUE@", TOTALRISK_);
            updateQuery = updateQuery.Replace("@DELTARISKVALUE@", DELTARISK_);
            updateQuery = updateQuery.Replace("@GAMMARISKVALUE@", GAMMARISK_);
            updateQuery = updateQuery.Replace("@VEGARISKVALUE@", VEGARISK_);
            updateQuery = updateQuery.Replace("@DEEPOTMVALUE@", DEEPOTM_);
            updateQuery = updateQuery.Replace("@REMAINDAYSVALUE@", REMAINDAYS_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = OPTION_POSITION_1928_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
