using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace QuerySerializeCodeGenerator
{
    public class asfasfasf_Table_DAO
    {
        public asfasfasf_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        public string STD_DATE_ { get; set; }
        public string CUST_FUND_CODE_ { get; set; }
        public string FIRST_BUY_DATE_ { get; set; }
        public string KR_CODE_ { get; set; }
        public string ITEM_NAME_ { get; set; }
        public string CURRENCY_CODE_ { get; set; }
        public string FACE_AMT_ { get; set; }
        public string MRO_ { get; set; }
        public string SIMPONY_ { get; set; }
        public string DIFF_ { get; set; }
        public string FIRM_NAME_ { get; set; }
        public string CREDIT_GRADE_ { get; set; }
        public string FIRM_ID_ { get; set; }

        private static string SelectQuery_
        = "SELECT STD_DATE_, CUST_FUND_CODE_, FIRST_BUY_DATE_, KR_CODE_, ITEM_NAME_, CURRENCY_CODE_, FACE_AMT_, MRO_, SIMPONY_, DIFF_, FIRM_NAME_, CREDIT_GRADE_, FIRM_ID_ " +
         "FROM asfasfasf WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO asfasfasf (STD_DATE_, CUST_FUND_CODE_, FIRST_BUY_DATE_, KR_CODE_, ITEM_NAME_, CURRENCY_CODE_, FACE_AMT_, MRO_, SIMPONY_, DIFF_, FIRM_NAME_, CREDIT_GRADE_, FIRM_ID_ )" +
        "VALUES ('@STD_DATEVALUE@', '@CUST_FUND_CODEVALUE@', '@FIRST_BUY_DATEVALUE@', '@KR_CODEVALUE@', '@ITEM_NAMEVALUE@', '@CURRENCY_CODEVALUE@', '@FACE_AMTVALUE@', '@MROVALUE@', '@SIMPONYVALUE@', '@DIFFVALUE@', '@FIRM_NAMEVALUE@', '@CREDIT_GRADEVALUE@', '@FIRM_IDVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE asfasfasf SET STD_DATE='@STD_DATEVALUE@'CUST_FUND_CODE='@CUST_FUND_CODEVALUE@'FIRST_BUY_DATE='@FIRST_BUY_DATEVALUE@'KR_CODE='@KR_CODEVALUE@'ITEM_NAME='@ITEM_NAMEVALUE@'CURRENCY_CODE='@CURRENCY_CODEVALUE@'FACE_AMT='@FACE_AMTVALUE@'MRO='@MROVALUE@'SIMPONY='@SIMPONYVALUE@'DIFF='@DIFFVALUE@'FIRM_NAME='@FIRM_NAMEVALUE@'CREDIT_GRADE='@CREDIT_GRADEVALUE@'FIRM_ID='@FIRM_IDVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM asfasfasf WHERE KeyColumn = '@KeyColumnValue@'";
        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.STD_DATE_ = dataRow["STD_DATE"].ToString();
            this.CUST_FUND_CODE_ = dataRow["CUST_FUND_CODE"].ToString();
            this.FIRST_BUY_DATE_ = dataRow["FIRST_BUY_DATE"].ToString();
            this.KR_CODE_ = dataRow["KR_CODE"].ToString();
            this.ITEM_NAME_ = dataRow["ITEM_NAME"].ToString();
            this.CURRENCY_CODE_ = dataRow["CURRENCY_CODE"].ToString();
            this.FACE_AMT_ = dataRow["FACE_AMT"].ToString();
            this.MRO_ = dataRow["MRO"].ToString();
            this.SIMPONY_ = dataRow["SIMPONY"].ToString();
            this.DIFF_ = dataRow["DIFF"].ToString();
            this.FIRM_NAME_ = dataRow["FIRM_NAME"].ToString();
            this.CREDIT_GRADE_ = dataRow["CREDIT_GRADE"].ToString();
            this.FIRM_ID_ = dataRow["FIRM_ID"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = asfasfasf_Table_DAO.SelectQuery_;

            selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand.CommandText, conn);

            //dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            if (rowCount != 0 || rowCount != 1)
            { throw new Exception(); }

            foreach (DataRow item in dr)
            {
                this.STD_DATE_ = item[0].ToString();
                this.CUST_FUND_CODE_ = item[1].ToString();
                this.FIRST_BUY_DATE_ = item[2].ToString();
                this.KR_CODE_ = item[3].ToString();
                this.ITEM_NAME_ = item[4].ToString();
                this.CURRENCY_CODE_ = item[5].ToString();
                this.FACE_AMT_ = item[6].ToString();
                this.MRO_ = item[7].ToString();
                this.SIMPONY_ = item[8].ToString();
                this.DIFF_ = item[9].ToString();
                this.FIRM_NAME_ = item[10].ToString();
                this.CREDIT_GRADE_ = item[11].ToString();
                this.FIRM_ID_ = item[12].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = asfasfasf_Table_DAO.InsertQuery_;

            insertQuery.Replace("@STD_DATEVALUE@", STD_DATE_);
            insertQuery.Replace("@CUST_FUND_CODEVALUE@", CUST_FUND_CODE_);
            insertQuery.Replace("@FIRST_BUY_DATEVALUE@", FIRST_BUY_DATE_);
            insertQuery.Replace("@KR_CODEVALUE@", KR_CODE_);
            insertQuery.Replace("@ITEM_NAMEVALUE@", ITEM_NAME_);
            insertQuery.Replace("@CURRENCY_CODEVALUE@", CURRENCY_CODE_);
            insertQuery.Replace("@FACE_AMTVALUE@", FACE_AMT_);
            insertQuery.Replace("@MROVALUE@", MRO_);
            insertQuery.Replace("@SIMPONYVALUE@", SIMPONY_);
            insertQuery.Replace("@DIFFVALUE@", DIFF_);
            insertQuery.Replace("@FIRM_NAMEVALUE@", FIRM_NAME_);
            insertQuery.Replace("@CREDIT_GRADEVALUE@", CREDIT_GRADE_);
            insertQuery.Replace("@FIRM_IDVALUE@", FIRM_ID_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = asfasfasf_Table_DAO.UpdateQuery_;

            updateQuery.Replace("@STD_DATEVALUE@", STD_DATE_);
            updateQuery.Replace("@CUST_FUND_CODEVALUE@", CUST_FUND_CODE_);
            updateQuery.Replace("@FIRST_BUY_DATEVALUE@", FIRST_BUY_DATE_);
            updateQuery.Replace("@KR_CODEVALUE@", KR_CODE_);
            updateQuery.Replace("@ITEM_NAMEVALUE@", ITEM_NAME_);
            updateQuery.Replace("@CURRENCY_CODEVALUE@", CURRENCY_CODE_);
            updateQuery.Replace("@FACE_AMTVALUE@", FACE_AMT_);
            updateQuery.Replace("@MROVALUE@", MRO_);
            updateQuery.Replace("@SIMPONYVALUE@", SIMPONY_);
            updateQuery.Replace("@DIFFVALUE@", DIFF_);
            updateQuery.Replace("@FIRM_NAMEVALUE@", FIRM_NAME_);
            updateQuery.Replace("@CREDIT_GRADEVALUE@", CREDIT_GRADE_);
            updateQuery.Replace("@FIRM_IDVALUE@", FIRM_ID_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = asfasfasf_Table_DAO.DeleteQuery_;

            deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
