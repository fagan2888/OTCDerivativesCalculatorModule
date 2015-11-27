using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class EVENT_INFO_Table_DAO
    {
        public EVENT_INFO_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string EVENT_CODE_ { get; set; }
        public string EVENT_DATE_ { get; set; }
        public string EVENT_TYPE_ { get; set; }
        public string EVENT_SUBTYPE_ { get; set; }
        public string EVENT_NAME_ { get; set; }
        public string EVENT_DESCRIPTION_ { get; set; }
        public string CURRENCY_ { get; set; }
        public string NOTIONAL_ { get; set; }
        public string REMAIN_NOTIONAL_ { get; set; }
        public string EVENT_AMOUNT_ { get; set; }
        public string COUNTERPARTY_ { get; set; }
        public string FLOATING_FLAG_ { get; set; }
        public string CALCULATION_TYPE_ { get; set; }
        public string FIXING_UNDERLYINGS_ { get; set; }
        public string FIXING_OBSERVATION_ { get; set; }
        public string FIXING_FLAG_ { get; set; }
        public string EXPIRED_FLAG_ { get; set; }
        public string ITEM_CODE_ { get; set; }
        public string ITEM_TYPE_ { get; set; }
        public string ITEM_NAME_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT EVENT_CODE, EVENT_DATE, EVENT_TYPE, EVENT_SUBTYPE, EVENT_NAME, EVENT_DESCRIPTION, CURRENCY, NOTIONAL, REMAIN_NOTIONAL, EVENT_AMOUNT, COUNTERPARTY, FLOATING_FLAG, CALCULATION_TYPE, FIXING_UNDERLYINGS, FIXING_OBSERVATION, FIXING_FLAG, EXPIRED_FLAG, ITEM_CODE, ITEM_TYPE, ITEM_NAME " +
         "FROM EVENT_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO EVENT_INFO (EVENT_CODE, EVENT_DATE, EVENT_TYPE, EVENT_SUBTYPE, EVENT_NAME, EVENT_DESCRIPTION, CURRENCY, NOTIONAL, REMAIN_NOTIONAL, EVENT_AMOUNT, COUNTERPARTY, FLOATING_FLAG, CALCULATION_TYPE, FIXING_UNDERLYINGS, FIXING_OBSERVATION, FIXING_FLAG, EXPIRED_FLAG, ITEM_CODE, ITEM_TYPE, ITEM_NAME )" +
        "VALUES ('@EVENT_CODEVALUE@', '@EVENT_DATEVALUE@', '@EVENT_TYPEVALUE@', '@EVENT_SUBTYPEVALUE@', '@EVENT_NAMEVALUE@', '@EVENT_DESCRIPTIONVALUE@', '@CURRENCYVALUE@', '@NOTIONALVALUE@', '@REMAIN_NOTIONALVALUE@', '@EVENT_AMOUNTVALUE@', '@COUNTERPARTYVALUE@', '@FLOATING_FLAGVALUE@', '@CALCULATION_TYPEVALUE@', '@FIXING_UNDERLYINGSVALUE@', '@FIXING_OBSERVATIONVALUE@', '@FIXING_FLAGVALUE@', '@EXPIRED_FLAGVALUE@', '@ITEM_CODEVALUE@', '@ITEM_TYPEVALUE@', '@ITEM_NAMEVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE EVENT_INFO SET EVENT_CODE='@EVENT_CODEVALUE@' EVENT_DATE='@EVENT_DATEVALUE@' EVENT_TYPE='@EVENT_TYPEVALUE@' EVENT_SUBTYPE='@EVENT_SUBTYPEVALUE@' EVENT_NAME='@EVENT_NAMEVALUE@' EVENT_DESCRIPTION='@EVENT_DESCRIPTIONVALUE@' CURRENCY='@CURRENCYVALUE@' NOTIONAL='@NOTIONALVALUE@' REMAIN_NOTIONAL='@REMAIN_NOTIONALVALUE@' EVENT_AMOUNT='@EVENT_AMOUNTVALUE@' COUNTERPARTY='@COUNTERPARTYVALUE@' FLOATING_FLAG='@FLOATING_FLAGVALUE@' CALCULATION_TYPE='@CALCULATION_TYPEVALUE@' FIXING_UNDERLYINGS='@FIXING_UNDERLYINGSVALUE@' FIXING_OBSERVATION='@FIXING_OBSERVATIONVALUE@' FIXING_FLAG='@FIXING_FLAGVALUE@' EXPIRED_FLAG='@EXPIRED_FLAGVALUE@' ITEM_CODE='@ITEM_CODEVALUE@' ITEM_TYPE='@ITEM_TYPEVALUE@' ITEM_NAME='@ITEM_NAMEVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM EVENT_INFO WHERE EVENT_CODE = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.EVENT_CODE_ = dataRow["EVENT_CODE"].ToString();
            this.EVENT_DATE_ = dataRow["EVENT_DATE"].ToString();
            this.EVENT_TYPE_ = dataRow["EVENT_TYPE"].ToString();
            this.EVENT_SUBTYPE_ = dataRow["EVENT_SUBTYPE"].ToString();
            this.EVENT_NAME_ = dataRow["EVENT_NAME"].ToString();
            this.EVENT_DESCRIPTION_ = dataRow["EVENT_DESCRIPTION"].ToString();
            this.CURRENCY_ = dataRow["CURRENCY"].ToString();
            this.NOTIONAL_ = dataRow["NOTIONAL"].ToString();
            this.REMAIN_NOTIONAL_ = dataRow["REMAIN_NOTIONAL"].ToString();
            this.EVENT_AMOUNT_ = dataRow["EVENT_AMOUNT"].ToString();
            this.COUNTERPARTY_ = dataRow["COUNTERPARTY"].ToString();
            this.FLOATING_FLAG_ = dataRow["FLOATING_FLAG"].ToString();
            this.CALCULATION_TYPE_ = dataRow["CALCULATION_TYPE"].ToString();
            this.FIXING_UNDERLYINGS_ = dataRow["FIXING_UNDERLYINGS"].ToString();
            this.FIXING_OBSERVATION_ = dataRow["FIXING_OBSERVATION"].ToString();
            this.FIXING_FLAG_ = dataRow["FIXING_FLAG"].ToString();
            this.EXPIRED_FLAG_ = dataRow["EXPIRED_FLAG"].ToString();
            this.ITEM_CODE_ = dataRow["ITEM_CODE"].ToString();
            this.ITEM_TYPE_ = dataRow["ITEM_TYPE"].ToString();
            this.ITEM_NAME_ = dataRow["ITEM_NAME"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = EVENT_INFO_Table_DAO.SelectQuery_;

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
                this.EVENT_CODE_ = item[0].ToString();
                this.EVENT_DATE_ = item[1].ToString();
                this.EVENT_TYPE_ = item[2].ToString();
                this.EVENT_SUBTYPE_ = item[3].ToString();
                this.EVENT_NAME_ = item[4].ToString();
                this.EVENT_DESCRIPTION_ = item[5].ToString();
                this.CURRENCY_ = item[6].ToString();
                this.NOTIONAL_ = item[7].ToString();
                this.REMAIN_NOTIONAL_ = item[8].ToString();
                this.EVENT_AMOUNT_ = item[9].ToString();
                this.COUNTERPARTY_ = item[10].ToString();
                this.FLOATING_FLAG_ = item[11].ToString();
                this.CALCULATION_TYPE_ = item[12].ToString();
                this.FIXING_UNDERLYINGS_ = item[13].ToString();
                this.FIXING_OBSERVATION_ = item[14].ToString();
                this.FIXING_FLAG_ = item[15].ToString();
                this.EXPIRED_FLAG_ = item[16].ToString();
                this.ITEM_CODE_ = item[17].ToString();
                this.ITEM_TYPE_ = item[18].ToString();
                this.ITEM_NAME_ = item[19].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = EVENT_INFO_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@EVENT_CODEVALUE@", EVENT_CODE_);
            insertQuery = insertQuery.Replace("@EVENT_DATEVALUE@", EVENT_DATE_);
            insertQuery = insertQuery.Replace("@EVENT_TYPEVALUE@", EVENT_TYPE_);
            insertQuery = insertQuery.Replace("@EVENT_SUBTYPEVALUE@", EVENT_SUBTYPE_);
            insertQuery = insertQuery.Replace("@EVENT_NAMEVALUE@", EVENT_NAME_);
            insertQuery = insertQuery.Replace("@EVENT_DESCRIPTIONVALUE@", EVENT_DESCRIPTION_);
            insertQuery = insertQuery.Replace("@CURRENCYVALUE@", CURRENCY_);
            insertQuery = insertQuery.Replace("@NOTIONALVALUE@", NOTIONAL_);
            insertQuery = insertQuery.Replace("@REMAIN_NOTIONALVALUE@", REMAIN_NOTIONAL_);
            insertQuery = insertQuery.Replace("@EVENT_AMOUNTVALUE@", EVENT_AMOUNT_);
            insertQuery = insertQuery.Replace("@COUNTERPARTYVALUE@", COUNTERPARTY_);
            insertQuery = insertQuery.Replace("@FLOATING_FLAGVALUE@", FLOATING_FLAG_);
            insertQuery = insertQuery.Replace("@CALCULATION_TYPEVALUE@", CALCULATION_TYPE_);
            insertQuery = insertQuery.Replace("@FIXING_UNDERLYINGSVALUE@", FIXING_UNDERLYINGS_);
            insertQuery = insertQuery.Replace("@FIXING_OBSERVATIONVALUE@", FIXING_OBSERVATION_);
            insertQuery = insertQuery.Replace("@FIXING_FLAGVALUE@", FIXING_FLAG_);
            insertQuery = insertQuery.Replace("@EXPIRED_FLAGVALUE@", EXPIRED_FLAG_);
            insertQuery = insertQuery.Replace("@ITEM_CODEVALUE@", ITEM_CODE_);
            insertQuery = insertQuery.Replace("@ITEM_TYPEVALUE@", ITEM_TYPE_);
            insertQuery = insertQuery.Replace("@ITEM_NAMEVALUE@", ITEM_NAME_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = EVENT_INFO_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@EVENT_CODEVALUE@", EVENT_CODE_);
            updateQuery = updateQuery.Replace("@EVENT_DATEVALUE@", EVENT_DATE_);
            updateQuery = updateQuery.Replace("@EVENT_TYPEVALUE@", EVENT_TYPE_);
            updateQuery = updateQuery.Replace("@EVENT_SUBTYPEVALUE@", EVENT_SUBTYPE_);
            updateQuery = updateQuery.Replace("@EVENT_NAMEVALUE@", EVENT_NAME_);
            updateQuery = updateQuery.Replace("@EVENT_DESCRIPTIONVALUE@", EVENT_DESCRIPTION_);
            updateQuery = updateQuery.Replace("@CURRENCYVALUE@", CURRENCY_);
            updateQuery = updateQuery.Replace("@NOTIONALVALUE@", NOTIONAL_);
            updateQuery = updateQuery.Replace("@REMAIN_NOTIONALVALUE@", REMAIN_NOTIONAL_);
            updateQuery = updateQuery.Replace("@EVENT_AMOUNTVALUE@", EVENT_AMOUNT_);
            updateQuery = updateQuery.Replace("@COUNTERPARTYVALUE@", COUNTERPARTY_);
            updateQuery = updateQuery.Replace("@FLOATING_FLAGVALUE@", FLOATING_FLAG_);
            updateQuery = updateQuery.Replace("@CALCULATION_TYPEVALUE@", CALCULATION_TYPE_);
            updateQuery = updateQuery.Replace("@FIXING_UNDERLYINGSVALUE@", FIXING_UNDERLYINGS_);
            updateQuery = updateQuery.Replace("@FIXING_OBSERVATIONVALUE@", FIXING_OBSERVATION_);
            updateQuery = updateQuery.Replace("@FIXING_FLAGVALUE@", FIXING_FLAG_);
            updateQuery = updateQuery.Replace("@EXPIRED_FLAGVALUE@", EXPIRED_FLAG_);
            updateQuery = updateQuery.Replace("@ITEM_CODEVALUE@", ITEM_CODE_);
            updateQuery = updateQuery.Replace("@ITEM_TYPEVALUE@", ITEM_TYPE_);
            updateQuery = updateQuery.Replace("@ITEM_NAMEVALUE@", ITEM_NAME_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = EVENT_INFO_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
