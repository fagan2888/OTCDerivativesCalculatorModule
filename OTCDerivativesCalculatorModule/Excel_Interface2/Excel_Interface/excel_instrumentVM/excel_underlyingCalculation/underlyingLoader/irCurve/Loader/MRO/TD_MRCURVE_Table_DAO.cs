using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class TD_MRCURVE_Table_DAO
    {
        public TD_MRCURVE_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        public string KeyColumn_InitialDate_ { get; set; }
        public string KeyColumn_EndDate_ { get; set; }

        public string KeyColumn_RefDate_ { get; set; }
        public string KeyColumn_BOND_CLASS_ID_ { get; set; }
        public string KeyColumn_CURVE_CODE_ { get; set; }


        #region Properties

        public string STD_DATE_ { get; set; }
        public string CURVE_CODE_ { get; set; }
        public string BOND_CLASS_ID_ { get; set; }
        public string D001_ { get; set; }
        public string M003_ { get; set; }
        public string M006_ { get; set; }
        public string M009_ { get; set; }
        public string M012_ { get; set; }
        public string M018_ { get; set; }
        public string M024_ { get; set; }
        public string M030_ { get; set; }
        public string M036_ { get; set; }
        public string M048_ { get; set; }
        public string M060_ { get; set; }
        public string M084_ { get; set; }
        public string M120_ { get; set; }
        public string M180_ { get; set; }
        public string M240_ { get; set; }
        public string M360_ { get; set; }

        #endregion

        #region built-in-Query

        private static string SelectQuery_
        = "SELECT STD_DATE, CURVE_CODE, BOND_CLASS_ID, D001, M003, M006, M009, M012, M018, M024, M030, M036, M048, M060, M084, M120, M180, M240, M360 " +
         "FROM TD_MRCURVE WHERE STD_DATE = '@KeyColumn_RefDateValue@' " + 
                          " AND BOND_CLASS_ID = '@KeyColumn_BOND_CLASS_IDValue@' " +
                          " AND CURVE_CODE = '@KeyColumn_CURVE_CODEValue@' ";



        

        private static string InsertQuery_
        = "INSERT INTO TD_MRCURVE (STD_DATE, CURVE_CODE, BOND_CLASS_ID, D001, M003, M006, M009, M012, M018, M024, M030, M036, M048, M060, M084, M120, M180, M240, M360 )" +
        "VALUES ('@STD_DATEVALUE@', '@CURVE_CODEVALUE@', '@BOND_CLASS_IDVALUE@', '@D001VALUE@', '@M003VALUE@', '@M006VALUE@', '@M009VALUE@', '@M012VALUE@', '@M018VALUE@', '@M024VALUE@', '@M030VALUE@', '@M036VALUE@', '@M048VALUE@', '@M060VALUE@', '@M084VALUE@', '@M120VALUE@', '@M180VALUE@', '@M240VALUE@', '@M360VALUE@' )";

        private static string UpdateQuery_
        = "UPDATE TD_MRCURVE SET STD_DATE='@STD_DATEVALUE@' CURVE_CODE='@CURVE_CODEVALUE@' BOND_CLASS_ID='@BOND_CLASS_IDVALUE@' D001='@D001VALUE@' M003='@M003VALUE@' M006='@M006VALUE@' M009='@M009VALUE@' M012='@M012VALUE@' M018='@M018VALUE@' M024='@M024VALUE@' M030='@M030VALUE@' M036='@M036VALUE@' M048='@M048VALUE@' M060='@M060VALUE@' M084='@M084VALUE@' M120='@M120VALUE@' M180='@M180VALUE@' M240='@M240VALUE@' M360='@M360VALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM TD_MRCURVE WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.STD_DATE_ = dataRow["STD_DATE"].ToString();
            this.CURVE_CODE_ = dataRow["CURVE_CODE"].ToString();
            this.BOND_CLASS_ID_ = dataRow["BOND_CLASS_ID"].ToString();
            this.D001_ = dataRow["D001"].ToString();
            this.M003_ = dataRow["M003"].ToString();
            this.M006_ = dataRow["M006"].ToString();
            this.M009_ = dataRow["M009"].ToString();
            this.M012_ = dataRow["M012"].ToString();
            this.M018_ = dataRow["M018"].ToString();
            this.M024_ = dataRow["M024"].ToString();
            this.M030_ = dataRow["M030"].ToString();
            this.M036_ = dataRow["M036"].ToString();
            this.M048_ = dataRow["M048"].ToString();
            this.M060_ = dataRow["M060"].ToString();
            this.M084_ = dataRow["M084"].ToString();
            this.M120_ = dataRow["M120"].ToString();
            this.M180_ = dataRow["M180"].ToString();
            this.M240_ = dataRow["M240"].ToString();
            this.M360_ = dataRow["M360"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                DbCommand dbCommand = conn.CreateCommand();

                string selectQuery = TD_MRCURVE_Table_DAO.SelectQuery_;

                selectQuery = selectQuery.Replace("@KeyColumn_RefDateValue@", this.KeyColumn_RefDate_);
                selectQuery = selectQuery.Replace("@KeyColumn_BOND_CLASS_IDValue@", this.KeyColumn_BOND_CLASS_ID_);
                selectQuery = selectQuery.Replace("@KeyColumn_CURVE_CODEValue@", this.KeyColumn_CURVE_CODE_);
                
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
                    this.STD_DATE_ = item[0].ToString();
                    this.CURVE_CODE_ = item[1].ToString();
                    this.BOND_CLASS_ID_ = item[2].ToString();
                    this.D001_ = item[3].ToString();
                    this.M003_ = item[4].ToString();
                    this.M006_ = item[5].ToString();
                    this.M009_ = item[6].ToString();
                    this.M012_ = item[7].ToString();
                    this.M018_ = item[8].ToString();
                    this.M024_ = item[9].ToString();
                    this.M030_ = item[10].ToString();
                    this.M036_ = item[11].ToString();
                    this.M048_ = item[12].ToString();
                    this.M060_ = item[13].ToString();
                    this.M084_ = item[14].ToString();
                    this.M120_ = item[15].ToString();
                    this.M180_ = item[16].ToString();
                    this.M240_ = item[17].ToString();
                    this.M360_ = item[18].ToString();
                }

                conn.Close();

            }
            catch (Exception)
            {

                conn.Close();
            }

        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = TD_MRCURVE_Table_DAO.InsertQuery_;

            insertQuery = insertQuery.Replace("@STD_DATEVALUE@", STD_DATE_);
            insertQuery = insertQuery.Replace("@CURVE_CODEVALUE@", CURVE_CODE_);
            insertQuery = insertQuery.Replace("@BOND_CLASS_IDVALUE@", BOND_CLASS_ID_);
            insertQuery = insertQuery.Replace("@D001VALUE@", D001_);
            insertQuery = insertQuery.Replace("@M003VALUE@", M003_);
            insertQuery = insertQuery.Replace("@M006VALUE@", M006_);
            insertQuery = insertQuery.Replace("@M009VALUE@", M009_);
            insertQuery = insertQuery.Replace("@M012VALUE@", M012_);
            insertQuery = insertQuery.Replace("@M018VALUE@", M018_);
            insertQuery = insertQuery.Replace("@M024VALUE@", M024_);
            insertQuery = insertQuery.Replace("@M030VALUE@", M030_);
            insertQuery = insertQuery.Replace("@M036VALUE@", M036_);
            insertQuery = insertQuery.Replace("@M048VALUE@", M048_);
            insertQuery = insertQuery.Replace("@M060VALUE@", M060_);
            insertQuery = insertQuery.Replace("@M084VALUE@", M084_);
            insertQuery = insertQuery.Replace("@M120VALUE@", M120_);
            insertQuery = insertQuery.Replace("@M180VALUE@", M180_);
            insertQuery = insertQuery.Replace("@M240VALUE@", M240_);
            insertQuery = insertQuery.Replace("@M360VALUE@", M360_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = TD_MRCURVE_Table_DAO.UpdateQuery_;

            updateQuery = updateQuery.Replace("@STD_DATEVALUE@", STD_DATE_);
            updateQuery = updateQuery.Replace("@CURVE_CODEVALUE@", CURVE_CODE_);
            updateQuery = updateQuery.Replace("@BOND_CLASS_IDVALUE@", BOND_CLASS_ID_);
            updateQuery = updateQuery.Replace("@D001VALUE@", D001_);
            updateQuery = updateQuery.Replace("@M003VALUE@", M003_);
            updateQuery = updateQuery.Replace("@M006VALUE@", M006_);
            updateQuery = updateQuery.Replace("@M009VALUE@", M009_);
            updateQuery = updateQuery.Replace("@M012VALUE@", M012_);
            updateQuery = updateQuery.Replace("@M018VALUE@", M018_);
            updateQuery = updateQuery.Replace("@M024VALUE@", M024_);
            updateQuery = updateQuery.Replace("@M030VALUE@", M030_);
            updateQuery = updateQuery.Replace("@M036VALUE@", M036_);
            updateQuery = updateQuery.Replace("@M048VALUE@", M048_);
            updateQuery = updateQuery.Replace("@M060VALUE@", M060_);
            updateQuery = updateQuery.Replace("@M084VALUE@", M084_);
            updateQuery = updateQuery.Replace("@M120VALUE@", M120_);
            updateQuery = updateQuery.Replace("@M180VALUE@", M180_);
            updateQuery = updateQuery.Replace("@M240VALUE@", M240_);
            updateQuery = updateQuery.Replace("@M360VALUE@", M360_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = TD_MRCURVE_Table_DAO.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
