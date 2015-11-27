using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class KOM_PSIT_INF_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<KOM_PSIT_INF_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string BASC_DT_;
        public string OFFC_CD_;
        public string SEQ_NO_;
        public string POSITION_ID_;
        public string KR_CD_;
        public string BCOF_ITM_NM_;
        public string ISD_FUND_CD_;
        public string CRPN_ID_;
        public string CRPN_NM_;
        public string DEAL_TYP_;
        public string HOLD_QNT_;
        public string BCOF_EXHG_RT_CD_;
        public string PURT_AMT_;
        public string ACBK_UPRC_;
        public string FRC_ACBK_UPRC_;
        public string MKT_UPRC_;
        public string FRC_MKT_UPRC_;
        public string FCVL_UNIT_;
        public string FRC_FCVL_UNIT_;
        public string FCVL_AMT_;
        public string FRC_FCVL_AMT_;
        public string ACBK_AMT_;
        public string FRC_ACBK_AMT_;
        public string MKT_AMT_;
        public string FRC_MKT_AMT_;
        public string WRNT_AMT_;
        public string HOLD_MAX_QNT_;
        public string FST_BUY_DT_;
        public string BUY_UPRC_;
        public string FST_BUY_AMT_;
        public string FST_FRC_ACBK_AMT_;
        public string DD_BY_ASES_LNG_;
        public string DD_BY_INT_LNG_;
        public string DD_BY_DEAL_LNG_;
        public string DD_BY_DIVD_LNG_;
        public string DD_EXP_;
        public string ASES_LNG_;
        public string ETC_PL_AMT_1_;
        public string ETC_PL_AMT_2_;
        public string ETC_PL_AMT_3_;
        public string ETC_PL_AMT_4_;
        public string ETC_PL_AMT_5_;
        public string ETC_PL_AMT_6_;
        public string ETC_PL_AMT_7_;
        public string ETC_PL_AMT_8_;
        public string ETC_PL_AMT_9_;
        public string ETC_PL_AMT_10_;
        public string ETC_PL_AMT_11_;
        public string ETC_PL_AMT_12_;
        public string ETC_PL_AMT_13_;
        public string ETC_PL_AMT_14_;
        public string ETC_PL_AMT_15_;
        public string ETC_PL_AMT_16_;
        public string ETC_PL_AMT_17_;
        public string ETC_PL_AMT_18_;
        public string ETC_PL_AMT_19_;
        public string ETC_PL_AMT_20_;
        public string ETC_PL_AMT_21_;
        public string ETC_PL_AMT_22_;
        public string ETC_PL_AMT_23_;
        public string ETC_PL_AMT_24_;
        public string ETC_PL_AMT_25_;
        public string BCOF_AC_CD_1_;
        public string BCOF_PRD_CD_1_;
        public string BCOF_PRD_CD_2_;
        public string BCOF_PRD_CD_3_;
        public string CLTR_OFFR_AMT_;
        public string CLTR_OFFR_YN_;
        public string MKT_PRC_ASES_CD_;
        public string OPT_EVET_YN_;
        public string HDG_TRSC_YN_;
        public string TST_ISS_TYP_;
        public string USER_SET_YN_;
        public string NOTE_;
        public string FILE_DT_;
        public string DB_INSERT_DT_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT BASC_DT, OFFC_CD, SEQ_NO, POSITION_ID, KR_CD, BCOF_ITM_NM, ISD_FUND_CD, CRPN_ID, CRPN_NM, DEAL_TYP, HOLD_QNT, BCOF_EXHG_RT_CD, PURT_AMT, ACBK_UPRC, FRC_ACBK_UPRC, MKT_UPRC, FRC_MKT_UPRC, FCVL_UNIT, FRC_FCVL_UNIT, FCVL_AMT, FRC_FCVL_AMT, ACBK_AMT, FRC_ACBK_AMT, MKT_AMT, FRC_MKT_AMT, WRNT_AMT, HOLD_MAX_QNT, FST_BUY_DT, BUY_UPRC, FST_BUY_AMT, FST_FRC_ACBK_AMT, DD_BY_ASES_LNG, DD_BY_INT_LNG, DD_BY_DEAL_LNG, DD_BY_DIVD_LNG, DD_EXP, ASES_LNG, ETC_PL_AMT_1, ETC_PL_AMT_2, ETC_PL_AMT_3, ETC_PL_AMT_4, ETC_PL_AMT_5, ETC_PL_AMT_6, ETC_PL_AMT_7, ETC_PL_AMT_8, ETC_PL_AMT_9, ETC_PL_AMT_10, ETC_PL_AMT_11, ETC_PL_AMT_12, ETC_PL_AMT_13, ETC_PL_AMT_14, ETC_PL_AMT_15, ETC_PL_AMT_16, ETC_PL_AMT_17, ETC_PL_AMT_18, ETC_PL_AMT_19, ETC_PL_AMT_20, ETC_PL_AMT_21, ETC_PL_AMT_22, ETC_PL_AMT_23, ETC_PL_AMT_24, ETC_PL_AMT_25, BCOF_AC_CD_1, BCOF_PRD_CD_1, BCOF_PRD_CD_2, BCOF_PRD_CD_3, CLTR_OFFR_AMT, CLTR_OFFR_YN, MKT_PRC_ASES_CD, OPT_EVET_YN, HDG_TRSC_YN, TST_ISS_TYP, USER_SET_YN, NOTE, FILE_DT, DB_INSERT_DT_ " +
         "FROM KOM_PSIT_INF WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM KOM_PSIT_INF WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = KOM_PSIT_INF_Table_DAOManager.SelectQuery_;

            //selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand.CommandText, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                KOM_PSIT_INF_Table_DAO dao = new KOM_PSIT_INF_Table_DAO();

                dao.BASC_DT_ = item[0].ToString();
                dao.OFFC_CD_ = item[1].ToString();
                dao.SEQ_NO_ = item[2].ToString();
                dao.POSITION_ID_ = item[3].ToString();
                dao.KR_CD_ = item[4].ToString();
                dao.BCOF_ITM_NM_ = item[5].ToString();
                dao.ISD_FUND_CD_ = item[6].ToString();
                dao.CRPN_ID_ = item[7].ToString();
                dao.CRPN_NM_ = item[8].ToString();
                dao.DEAL_TYP_ = item[9].ToString();
                dao.HOLD_QNT_ = item[10].ToString();
                dao.BCOF_EXHG_RT_CD_ = item[11].ToString();
                dao.PURT_AMT_ = item[12].ToString();
                dao.ACBK_UPRC_ = item[13].ToString();
                dao.FRC_ACBK_UPRC_ = item[14].ToString();
                dao.MKT_UPRC_ = item[15].ToString();
                dao.FRC_MKT_UPRC_ = item[16].ToString();
                dao.FCVL_UNIT_ = item[17].ToString();
                dao.FRC_FCVL_UNIT_ = item[18].ToString();
                dao.FCVL_AMT_ = item[19].ToString();
                dao.FRC_FCVL_AMT_ = item[20].ToString();
                dao.ACBK_AMT_ = item[21].ToString();
                dao.FRC_ACBK_AMT_ = item[22].ToString();
                dao.MKT_AMT_ = item[23].ToString();
                dao.FRC_MKT_AMT_ = item[24].ToString();
                dao.WRNT_AMT_ = item[25].ToString();
                dao.HOLD_MAX_QNT_ = item[26].ToString();
                dao.FST_BUY_DT_ = item[27].ToString();
                dao.BUY_UPRC_ = item[28].ToString();
                dao.FST_BUY_AMT_ = item[29].ToString();
                dao.FST_FRC_ACBK_AMT_ = item[30].ToString();
                dao.DD_BY_ASES_LNG_ = item[31].ToString();
                dao.DD_BY_INT_LNG_ = item[32].ToString();
                dao.DD_BY_DEAL_LNG_ = item[33].ToString();
                dao.DD_BY_DIVD_LNG_ = item[34].ToString();
                dao.DD_EXP_ = item[35].ToString();
                dao.ASES_LNG_ = item[36].ToString();
                dao.ETC_PL_AMT_1_ = item[37].ToString();
                dao.ETC_PL_AMT_2_ = item[38].ToString();
                dao.ETC_PL_AMT_3_ = item[39].ToString();
                dao.ETC_PL_AMT_4_ = item[40].ToString();
                dao.ETC_PL_AMT_5_ = item[41].ToString();
                dao.ETC_PL_AMT_6_ = item[42].ToString();
                dao.ETC_PL_AMT_7_ = item[43].ToString();
                dao.ETC_PL_AMT_8_ = item[44].ToString();
                dao.ETC_PL_AMT_9_ = item[45].ToString();
                dao.ETC_PL_AMT_10_ = item[46].ToString();
                dao.ETC_PL_AMT_11_ = item[47].ToString();
                dao.ETC_PL_AMT_12_ = item[48].ToString();
                dao.ETC_PL_AMT_13_ = item[49].ToString();
                dao.ETC_PL_AMT_14_ = item[50].ToString();
                dao.ETC_PL_AMT_15_ = item[51].ToString();
                dao.ETC_PL_AMT_16_ = item[52].ToString();
                dao.ETC_PL_AMT_17_ = item[53].ToString();
                dao.ETC_PL_AMT_18_ = item[54].ToString();
                dao.ETC_PL_AMT_19_ = item[55].ToString();
                dao.ETC_PL_AMT_20_ = item[56].ToString();
                dao.ETC_PL_AMT_21_ = item[57].ToString();
                dao.ETC_PL_AMT_22_ = item[58].ToString();
                dao.ETC_PL_AMT_23_ = item[59].ToString();
                dao.ETC_PL_AMT_24_ = item[60].ToString();
                dao.ETC_PL_AMT_25_ = item[61].ToString();
                dao.BCOF_AC_CD_1_ = item[62].ToString();
                dao.BCOF_PRD_CD_1_ = item[63].ToString();
                dao.BCOF_PRD_CD_2_ = item[64].ToString();
                dao.BCOF_PRD_CD_3_ = item[65].ToString();
                dao.CLTR_OFFR_AMT_ = item[66].ToString();
                dao.CLTR_OFFR_YN_ = item[67].ToString();
                dao.MKT_PRC_ASES_CD_ = item[68].ToString();
                dao.OPT_EVET_YN_ = item[69].ToString();
                dao.HDG_TRSC_YN_ = item[70].ToString();
                dao.TST_ISS_TYP_ = item[71].ToString();
                dao.USER_SET_YN_ = item[72].ToString();
                dao.NOTE_ = item[73].ToString();
                dao.FILE_DT_ = item[74].ToString();
                dao.DB_INSERT_DT_ = item[75].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = KOM_PSIT_INF_Table_DAOManager.DeleteQuery_;

            deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
