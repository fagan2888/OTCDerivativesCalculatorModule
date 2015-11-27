//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.Data.Common;

//namespace Excel_Interface
//{
//    public class CURVE_DATA_Table_DAO
//    {
//        public CURVE_DATA_Table_DAO() { }

//        public string KeyColumn_ { get; set; }

//        #region Properties

//        public string CURVE_DATE_ { get; set; }
//        public string CURVE_CODE_ { get; set; }
//        public string CURVE_NAME_ { get; set; }
//        public string DATA_1_ { get; set; }
//        public string DATA_2_ { get; set; }
//        public string DATA_3_ { get; set; }
//        public string DATA_4_ { get; set; }
//        public string DATA_5_ { get; set; }
//        public string DATA_6_ { get; set; }
//        public string DATA_7_ { get; set; }
//        public string DATA_8_ { get; set; }
//        public string DATA_9_ { get; set; }
//        public string DATA_10_ { get; set; }
//        public string DATA_11_ { get; set; }
//        public string DATA_12_ { get; set; }
//        public string DATA_13_ { get; set; }
//        public string DATA_14_ { get; set; }
//        public string DATA_15_ { get; set; }

//        public List<string> DataList_ { get; set; }

//        #endregion

//        #region built-in-Query

//        private static string SelectQuery_
//        = "SELECT CURVE_DATE, CURVE_CODE, CURVE_NAME, DATA_1, DATA_2, DATA_3, DATA_4, DATA_5, DATA_6, DATA_7, DATA_8, DATA_9, DATA_10, DATA_11, DATA_12, DATA_13, DATA_14, DATA_15 " +
//         "FROM CURVE_DATA WHERE CURVE_CODE = '@KeyColumnValue1@' AND CURVE_DATE = '@KeyColumnValue2@'";

//        private static string InsertQuery_
//        = "INSERT INTO CURVE_DATA (CURVE_DATE, CURVE_CODE, CURVE_NAME, DATA_1, DATA_2, DATA_3, DATA_4, DATA_5, DATA_6, DATA_7, DATA_8, DATA_9, DATA_10, DATA_11, DATA_12, DATA_13, DATA_14, DATA_15 )" +
//        "VALUES ('@CURVE_DATEVALUE@', '@CURVE_CODEVALUE@', '@CURVE_NAMEVALUE@', '@DATA_1VALUE@', '@DATA_2VALUE@', '@DATA_3VALUE@', '@DATA_4VALUE@', '@DATA_5VALUE@', '@DATA_6VALUE@', '@DATA_7VALUE@', '@DATA_8VALUE@', '@DATA_9VALUE@', '@DATA_10VALUE@', '@DATA_11VALUE@', '@DATA_12VALUE@', '@DATA_13VALUE@', '@DATA_14VALUE@', '@DATA_15VALUE@' )";

//        private static string UpdateQuery_
//        = "UPDATE CURVE_DATA SET CURVE_DATE='@CURVE_DATEVALUE@' CURVE_CODE='@CURVE_CODEVALUE@' CURVE_NAME='@CURVE_NAMEVALUE@' DATA_1='@DATA_1VALUE@' DATA_2='@DATA_2VALUE@' DATA_3='@DATA_3VALUE@' DATA_4='@DATA_4VALUE@' DATA_5='@DATA_5VALUE@' DATA_6='@DATA_6VALUE@' DATA_7='@DATA_7VALUE@' DATA_8='@DATA_8VALUE@' DATA_9='@DATA_9VALUE@' DATA_10='@DATA_10VALUE@' DATA_11='@DATA_11VALUE@' DATA_12='@DATA_12VALUE@' DATA_13='@DATA_13VALUE@' DATA_14='@DATA_14VALUE@' DATA_15='@DATA_15VALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

//        private static string DeleteQuery_
//        = "DELETE FROM CURVE_DATA WHERE KeyColumn = '@KeyColumnValue@'";

//        #endregion

//        public void loadFromDataRow(System.Data.DataRow dataRow)
//        {
//            this.CURVE_DATE_ = dataRow["CURVE_DATE"].ToString();
//            this.CURVE_CODE_ = dataRow["CURVE_CODE"].ToString();
//            this.CURVE_NAME_ = dataRow["CURVE_NAME"].ToString();
//            this.DATA_1_ = dataRow["DATA_1"].ToString();
//            this.DATA_2_ = dataRow["DATA_2"].ToString();
//            this.DATA_3_ = dataRow["DATA_3"].ToString();
//            this.DATA_4_ = dataRow["DATA_4"].ToString();
//            this.DATA_5_ = dataRow["DATA_5"].ToString();
//            this.DATA_6_ = dataRow["DATA_6"].ToString();
//            this.DATA_7_ = dataRow["DATA_7"].ToString();
//            this.DATA_8_ = dataRow["DATA_8"].ToString();
//            this.DATA_9_ = dataRow["DATA_9"].ToString();
//            this.DATA_10_ = dataRow["DATA_10"].ToString();
//            this.DATA_11_ = dataRow["DATA_11"].ToString();
//            this.DATA_12_ = dataRow["DATA_12"].ToString();
//            this.DATA_13_ = dataRow["DATA_13"].ToString();
//            this.DATA_14_ = dataRow["DATA_14"].ToString();
//            this.DATA_15_ = dataRow["DATA_15"].ToString();
//        }

//        public void select(DbConnection conn)
//        {
//            if (conn.State != ConnectionState.Open)
//                conn.Open();

//            DataTable tb = new DataTable();

//            DbCommand dbCommand = conn.CreateCommand();

//            string selectQuery = CURVE_DATA_Table_DAO.SelectQuery_;

//            selectQuery = selectQuery.Replace("@KeyColumnValue1@", this.CURVE_CODE_);
//            selectQuery = selectQuery.Replace("@KeyColumnValue2@", this.CURVE_DATE_);

//            dbCommand.CommandText = selectQuery;

//            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
//            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

//            dataAdapter.Fill(tb);

//            DataRow[] dr = tb.Select();
//            int rowCount = dr.Length;

//            if (!(rowCount == 0 || rowCount == 1))
//            { throw new Exception(); }

//            this.DataList_ = new List<string>();

//            foreach (DataRow item in dr)
//            {
//                this.CURVE_DATE_ = item[0].ToString();
//                this.CURVE_CODE_ = item[1].ToString();
//                this.CURVE_NAME_ = item[2].ToString();
//                this.DATA_1_ = item[3].ToString(); this.DataList_.Add(this.DATA_1_);
//                this.DATA_2_ = item[4].ToString(); this.DataList_.Add(this.DATA_2_);
//                this.DATA_3_ = item[5].ToString(); this.DataList_.Add(this.DATA_3_);
//                this.DATA_4_ = item[6].ToString(); this.DataList_.Add(this.DATA_4_);
//                this.DATA_5_ = item[7].ToString(); this.DataList_.Add(this.DATA_5_);
//                this.DATA_6_ = item[8].ToString(); this.DataList_.Add(this.DATA_6_);
//                this.DATA_7_ = item[9].ToString(); this.DataList_.Add(this.DATA_7_);
//                this.DATA_8_ = item[10].ToString(); this.DataList_.Add(this.DATA_8_);
//                this.DATA_9_ = item[11].ToString(); this.DataList_.Add(this.DATA_9_);
//                this.DATA_10_ = item[12].ToString(); this.DataList_.Add(this.DATA_10_);
//                this.DATA_11_ = item[13].ToString(); this.DataList_.Add(this.DATA_11_);
//                this.DATA_12_ = item[14].ToString(); this.DataList_.Add(this.DATA_12_);
//                this.DATA_13_ = item[15].ToString(); this.DataList_.Add(this.DATA_13_);
//                this.DATA_14_ = item[16].ToString(); this.DataList_.Add(this.DATA_14_);
//                this.DATA_15_ = item[17].ToString(); this.DataList_.Add(this.DATA_15_);
//            }


//        }

//        public void insert(DbConnection conn)
//        {
//            if (conn.State != ConnectionState.Open)
//                conn.Open();

//            DbCommand dbCommand = conn.CreateCommand();

//            string insertQuery = CURVE_DATA_Table_DAO.InsertQuery_;

//            insertQuery = insertQuery.Replace("@CURVE_DATEVALUE@", CURVE_DATE_);
//            insertQuery = insertQuery.Replace("@CURVE_CODEVALUE@", CURVE_CODE_);
//            insertQuery = insertQuery.Replace("@CURVE_NAMEVALUE@", CURVE_NAME_);
//            insertQuery = insertQuery.Replace("@DATA_1VALUE@", DATA_1_);
//            insertQuery = insertQuery.Replace("@DATA_2VALUE@", DATA_2_);
//            insertQuery = insertQuery.Replace("@DATA_3VALUE@", DATA_3_);
//            insertQuery = insertQuery.Replace("@DATA_4VALUE@", DATA_4_);
//            insertQuery = insertQuery.Replace("@DATA_5VALUE@", DATA_5_);
//            insertQuery = insertQuery.Replace("@DATA_6VALUE@", DATA_6_);
//            insertQuery = insertQuery.Replace("@DATA_7VALUE@", DATA_7_);
//            insertQuery = insertQuery.Replace("@DATA_8VALUE@", DATA_8_);
//            insertQuery = insertQuery.Replace("@DATA_9VALUE@", DATA_9_);
//            insertQuery = insertQuery.Replace("@DATA_10VALUE@", DATA_10_);
//            insertQuery = insertQuery.Replace("@DATA_11VALUE@", DATA_11_);
//            insertQuery = insertQuery.Replace("@DATA_12VALUE@", DATA_12_);
//            insertQuery = insertQuery.Replace("@DATA_13VALUE@", DATA_13_);
//            insertQuery = insertQuery.Replace("@DATA_14VALUE@", DATA_14_);
//            insertQuery = insertQuery.Replace("@DATA_15VALUE@", DATA_15_);


//            dbCommand.CommandText = insertQuery;

//            dbCommand.ExecuteNonQuery();
//        }

//        public void update(DbConnection conn)
//        {
//            if (conn.State != ConnectionState.Open)
//                conn.Open();

//            DbCommand dbCommand = conn.CreateCommand();

//            string updateQuery = CURVE_DATA_Table_DAO.UpdateQuery_;

//            updateQuery = updateQuery.Replace("@CURVE_DATEVALUE@", CURVE_DATE_);
//            updateQuery = updateQuery.Replace("@CURVE_CODEVALUE@", CURVE_CODE_);
//            updateQuery = updateQuery.Replace("@CURVE_NAMEVALUE@", CURVE_NAME_);
//            updateQuery = updateQuery.Replace("@DATA_1VALUE@", DATA_1_);
//            updateQuery = updateQuery.Replace("@DATA_2VALUE@", DATA_2_);
//            updateQuery = updateQuery.Replace("@DATA_3VALUE@", DATA_3_);
//            updateQuery = updateQuery.Replace("@DATA_4VALUE@", DATA_4_);
//            updateQuery = updateQuery.Replace("@DATA_5VALUE@", DATA_5_);
//            updateQuery = updateQuery.Replace("@DATA_6VALUE@", DATA_6_);
//            updateQuery = updateQuery.Replace("@DATA_7VALUE@", DATA_7_);
//            updateQuery = updateQuery.Replace("@DATA_8VALUE@", DATA_8_);
//            updateQuery = updateQuery.Replace("@DATA_9VALUE@", DATA_9_);
//            updateQuery = updateQuery.Replace("@DATA_10VALUE@", DATA_10_);
//            updateQuery = updateQuery.Replace("@DATA_11VALUE@", DATA_11_);
//            updateQuery = updateQuery.Replace("@DATA_12VALUE@", DATA_12_);
//            updateQuery = updateQuery.Replace("@DATA_13VALUE@", DATA_13_);
//            updateQuery = updateQuery.Replace("@DATA_14VALUE@", DATA_14_);
//            updateQuery = updateQuery.Replace("@DATA_15VALUE@", DATA_15_);


//            dbCommand.CommandText = updateQuery;

//            dbCommand.ExecuteNonQuery();
//        }

//        public void delete(DbConnection conn)
//        {
//            if (conn.State != ConnectionState.Open)
//                conn.Open();

//            DbCommand dbCommand = conn.CreateCommand();

//            string deleteQuery = CURVE_DATA_Table_DAO.DeleteQuery_;

//            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

//            dbCommand.CommandText = deleteQuery;

//            dbCommand.ExecuteNonQuery();
//        }

//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class CURVE_DATA_Table_DAO
    {
        public CURVE_DATA_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string CURVE_DATE_ { get; set; }
        public string CURVE_CODE_ { get; set; }
        public string TENOR_ { get; set; }
        public string VALUE_ { get; set; }
        public string CURVE_TYPE_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT CURVE_DATE, CURVE_CODE, TENOR, VALUE, CURVE_TYPE " +
         "FROM CURVE_DATA WHERE KeyColumn = '@KeyColumnValue@'";

        private static string SelectDateCurveQuery_
        = "SELECT CURVE_DATE, CURVE_CODE, TENOR, VALUE, CURVE_TYPE " +
        "FROM CURVE_DATA WHERE CURVE_DATE = '@CURVE_DATEVALUE@' AND CURVE_CODE = '@CURVE_CODEVALUE@'";

        private static string InsertQuery_
        = "INSERT INTO CURVE_DATA (CURVE_DATE, CURVE_CODE, TENOR, VALUE, CURVE_TYPE )" +
        "VALUES ('@CURVE_DATEVALUE@', '@CURVE_CODEVALUE@', '@TENORVALUE@', '@VALUEVALUE@', '@CURVE_TYPEVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE CURVE_DATA SET CURVE_DATE='@CURVE_DATEVALUE@' CURVE_CODE='@CURVE_CODEVALUE@' TENOR='@TENORVALUE@' VALUE='@VALUEVALUE@' CURVE_TYPE='@CURVE_TYPEVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM CURVE_DATA WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteCodeQuery_
        = "DELETE FROM CURVE_DATA WHERE CURVE_CODE = '@CURVE_CODEVALUE@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.CURVE_DATE_ = dataRow["CURVE_DATE"].ToString();
            this.CURVE_CODE_ = dataRow["CURVE_CODE"].ToString();
            this.TENOR_ = dataRow["TENOR"].ToString();
            this.VALUE_ = dataRow["VALUE"].ToString();
            this.CURVE_TYPE_ = dataRow["CURVE_TYPE"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                DbCommand dbCommand = conn.CreateCommand();

                string selectQuery = CURVE_DATA_Table_DAO.SelectQuery_;

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
                    this.CURVE_DATE_ = item[0].ToString();
                    this.CURVE_CODE_ = item[1].ToString();
                    this.TENOR_ = item[2].ToString();
                    this.VALUE_ = item[3].ToString();
                    this.CURVE_TYPE_ = item[4].ToString();
                }

                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
            


        }

        public void selectDateCurve(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                DbCommand dbCommand = conn.CreateCommand();

                string selectDateCurveQuery = CURVE_DATA_Table_DAO.SelectDateCurveQuery_;

                selectDateCurveQuery = selectDateCurveQuery.Replace("@CURVE_DATEVALUE@", this.CURVE_DATE_);
                selectDateCurveQuery = selectDateCurveQuery.Replace("@CURVE_CODEVALUE@", this.CURVE_CODE_);

                dbCommand.CommandText = selectDateCurveQuery;

                //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
                DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

                dataAdapter.Fill(tb);

                DataRow[] dr = tb.Select();
                int rowCount = dr.Length;

                if (!(rowCount == 0 || rowCount == 1))
                { throw new Exception("unique curveCode violation "); }

                foreach (DataRow item in dr)
                {
                    this.CURVE_DATE_ = item[0].ToString();
                    this.CURVE_CODE_ = item[1].ToString();
                    this.TENOR_ = item[2].ToString();
                    this.VALUE_ = item[3].ToString();
                    this.CURVE_TYPE_ = item[4].ToString();
                }

                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                throw;
            }

        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = CURVE_DATA_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@CURVE_DATEVALUE@", CURVE_DATE_);
            insertQuery = insertQuery.Replace("@CURVE_CODEVALUE@", CURVE_CODE_);
            insertQuery = insertQuery.Replace("@TENORVALUE@", TENOR_);
            insertQuery = insertQuery.Replace("@VALUEVALUE@", VALUE_);
            insertQuery = insertQuery.Replace("@CURVE_TYPEVALUE@", CURVE_TYPE_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = CURVE_DATA_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@CURVE_DATEVALUE@", CURVE_DATE_);
            updateQuery = updateQuery.Replace("@CURVE_CODEVALUE@", CURVE_CODE_);
            updateQuery = updateQuery.Replace("@TENORVALUE@", TENOR_);
            updateQuery = updateQuery.Replace("@VALUEVALUE@", VALUE_);
            updateQuery = updateQuery.Replace("@CURVE_TYPEVALUE@", CURVE_TYPE_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = CURVE_DATA_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void deleteCode(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteCodeQuery = CURVE_DATA_Table_DAO.DeleteCodeQuery_;

            deleteCodeQuery = deleteCodeQuery.Replace("@CURVE_CODEVALUE@", this.CURVE_CODE_);

            dbCommand.CommandText = deleteCodeQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
