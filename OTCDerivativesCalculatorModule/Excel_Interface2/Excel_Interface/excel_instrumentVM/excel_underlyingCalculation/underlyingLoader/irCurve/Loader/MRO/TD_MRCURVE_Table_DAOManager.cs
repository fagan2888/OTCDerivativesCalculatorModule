using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class TD_MRCURVE_Table_DAOManager
    {
        public string KeyColumn_InitialDate_ { get; set; }
        public string KeyColumn_EndDate_ { get; set; }
        public string KeyColumn_RefDate_ { get; set; }
        public string KeyColumn_CurveCode_ { get; set; }
        public string KeyColumn_BOND_CLASS_ID_ { get; set; }
        public string KeyColumn_CURVE_CODE_ { get; set; }

        public List<TD_MRCURVE_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string STD_DATE_;
        public string CURVE_CODE_;
        public string BOND_CLASS_ID_;
        public string D001_;
        public string M003_;
        public string M006_;
        public string M009_;
        public string M012_;
        public string M018_;
        public string M024_;
        public string M030_;
        public string M036_;
        public string M048_;
        public string M060_;
        public string M084_;
        public string M120_;
        public string M180_;
        public string M240_;
        public string M360_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT STD_DATE, CURVE_CODE, BOND_CLASS_ID, D001, M003, M006, M009, M012, M018, M024, M030, M036, M048, M060, M084, M120, M180, M240, M360 " +
         "FROM TD_MRCURVE WHERE STD_DATE = '@KeyColumn_RefDateValue@' AND CURVE_CODE = '@KeyColumn_CurveCodeValue@'";

        private static string SelectIntervalQuery_
        = "SELECT STD_DATE, CURVE_CODE, BOND_CLASS_ID, D001, M003, M006, M009, M012, M018, M024, M030, M036, M048, M060, M084, M120, M180, M240, M360 " +
         "FROM TD_MRCURVE WHERE STD_DATE >= '@KeyColumn_InitialDateValue@' " +
                          " AND STD_DATE <= '@KeyColumn_EndDateValue@' " +
                          " AND BOND_CLASS_ID = '@KeyColumn_BOND_CLASS_IDValue@' " +
                          " AND CURVE_CODE = '@KeyColumn_CURVE_CODEValue@' ";

        private static string DeleteQuery_
        = "DELETE FROM TD_MRCURVE WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<TD_MRCURVE_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = TD_MRCURVE_Table_DAOManager.SelectQuery_;

            selectQuery = selectQuery.Replace("@KeyColumn_RefDateValue@", this.KeyColumn_RefDate_);
            selectQuery = selectQuery.Replace("@KeyColumn_CurveCodeValue@", this.KeyColumn_CurveCode_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                TD_MRCURVE_Table_DAO dao = new TD_MRCURVE_Table_DAO();

                dao.STD_DATE_ = item[0].ToString();
                dao.CURVE_CODE_ = item[1].ToString();
                dao.BOND_CLASS_ID_ = item[2].ToString();
                dao.D001_ = item[3].ToString();
                dao.M003_ = item[4].ToString();
                dao.M006_ = item[5].ToString();
                dao.M009_ = item[6].ToString();
                dao.M012_ = item[7].ToString();
                dao.M018_ = item[8].ToString();
                dao.M024_ = item[9].ToString();
                dao.M030_ = item[10].ToString();
                dao.M036_ = item[11].ToString();
                dao.M048_ = item[12].ToString();
                dao.M060_ = item[13].ToString();
                dao.M084_ = item[14].ToString();
                dao.M120_ = item[15].ToString();
                dao.M180_ = item[16].ToString();
                dao.M240_ = item[17].ToString();
                dao.M360_ = item[18].ToString();

                this.DAOList_.Add(dao);
            }
        }

        public void selectInterval(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            try
            {
                DataTable tb = new DataTable();

                this.DAOList_ = new List<TD_MRCURVE_Table_DAO>();

                DbCommand dbCommand = conn.CreateCommand();

                string selectIntervalQuery = TD_MRCURVE_Table_DAOManager.SelectIntervalQuery_;

                selectIntervalQuery = selectIntervalQuery.Replace("@KeyColumn_InitialDateValue@", this.KeyColumn_InitialDate_);
                selectIntervalQuery = selectIntervalQuery.Replace("@KeyColumn_EndDateValue@", this.KeyColumn_EndDate_);
                selectIntervalQuery = selectIntervalQuery.Replace("@KeyColumn_BOND_CLASS_IDValue@", this.KeyColumn_BOND_CLASS_ID_);
                selectIntervalQuery = selectIntervalQuery.Replace("@KeyColumn_CURVE_CODEValue@", this.KeyColumn_CURVE_CODE_);

                dbCommand.CommandText = selectIntervalQuery;

                //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
                DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

                dataAdapter.Fill(tb);

                DataRow[] dr = tb.Select();
                int rowCount = dr.Length;

                foreach (DataRow item in dr)
                {
                    TD_MRCURVE_Table_DAO dao = new TD_MRCURVE_Table_DAO();

                    dao.STD_DATE_ = item[0].ToString();
                    dao.CURVE_CODE_ = item[1].ToString();
                    dao.BOND_CLASS_ID_ = item[2].ToString();
                    dao.D001_ = item[3].ToString();
                    dao.M003_ = item[4].ToString();
                    dao.M006_ = item[5].ToString();
                    dao.M009_ = item[6].ToString();
                    dao.M012_ = item[7].ToString();
                    dao.M018_ = item[8].ToString();
                    dao.M024_ = item[9].ToString();
                    dao.M030_ = item[10].ToString();
                    dao.M036_ = item[11].ToString();
                    dao.M048_ = item[12].ToString();
                    dao.M060_ = item[13].ToString();
                    dao.M084_ = item[14].ToString();
                    dao.M120_ = item[15].ToString();
                    dao.M180_ = item[16].ToString();
                    dao.M240_ = item[17].ToString();
                    dao.M360_ = item[18].ToString();

                    this.DAOList_.Add(dao);
                }

                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }
            
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = TD_MRCURVE_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_CurveCode_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
