using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class KOM_PSIT_INF_Table_DAO
    {
        public KOM_PSIT_INF_Table_DAO() { }

        public string KeyColumn_ { get; set; }

        #region Properties

        public string BASC_DT_ { get; set; }
        public string OFFC_CD_ { get; set; }
        public string SEQ_NO_ { get; set; }
        public string POSITION_ID_ { get; set; }
        public string KR_CD_ { get; set; }
        public string BCOF_ITM_NM_ { get; set; }
        public string ISD_FUND_CD_ { get; set; }
        public string CRPN_ID_ { get; set; }
        public string CRPN_NM_ { get; set; }
        public string DEAL_TYP_ { get; set; }
        public string HOLD_QNT_ { get; set; }
        public string BCOF_EXHG_RT_CD_ { get; set; }
        public string PURT_AMT_ { get; set; }
        public string ACBK_UPRC_ { get; set; }
        public string FRC_ACBK_UPRC_ { get; set; }
        public string MKT_UPRC_ { get; set; }
        public string FRC_MKT_UPRC_ { get; set; }
        public string FCVL_UNIT_ { get; set; }
        public string FRC_FCVL_UNIT_ { get; set; }
        public string FCVL_AMT_ { get; set; }
        public string FRC_FCVL_AMT_ { get; set; }
        public string ACBK_AMT_ { get; set; }
        public string FRC_ACBK_AMT_ { get; set; }
        public string MKT_AMT_ { get; set; }
        public string FRC_MKT_AMT_ { get; set; }
        public string WRNT_AMT_ { get; set; }
        public string HOLD_MAX_QNT_ { get; set; }
        public string FST_BUY_DT_ { get; set; }
        public string BUY_UPRC_ { get; set; }
        public string FST_BUY_AMT_ { get; set; }
        public string FST_FRC_ACBK_AMT_ { get; set; }
        public string DD_BY_ASES_LNG_ { get; set; }
        public string DD_BY_INT_LNG_ { get; set; }
        public string DD_BY_DEAL_LNG_ { get; set; }
        public string DD_BY_DIVD_LNG_ { get; set; }
        public string DD_EXP_ { get; set; }
        public string ASES_LNG_ { get; set; }
        public string ETC_PL_AMT_1_ { get; set; }
        public string ETC_PL_AMT_2_ { get; set; }
        public string ETC_PL_AMT_3_ { get; set; }
        public string ETC_PL_AMT_4_ { get; set; }
        public string ETC_PL_AMT_5_ { get; set; }
        public string ETC_PL_AMT_6_ { get; set; }
        public string ETC_PL_AMT_7_ { get; set; }
        public string ETC_PL_AMT_8_ { get; set; }
        public string ETC_PL_AMT_9_ { get; set; }
        public string ETC_PL_AMT_10_ { get; set; }
        public string ETC_PL_AMT_11_ { get; set; }
        public string ETC_PL_AMT_12_ { get; set; }
        public string ETC_PL_AMT_13_ { get; set; }
        public string ETC_PL_AMT_14_ { get; set; }
        public string ETC_PL_AMT_15_ { get; set; }
        public string ETC_PL_AMT_16_ { get; set; }
        public string ETC_PL_AMT_17_ { get; set; }
        public string ETC_PL_AMT_18_ { get; set; }
        public string ETC_PL_AMT_19_ { get; set; }
        public string ETC_PL_AMT_20_ { get; set; }
        public string ETC_PL_AMT_21_ { get; set; }
        public string ETC_PL_AMT_22_ { get; set; }
        public string ETC_PL_AMT_23_ { get; set; }
        public string ETC_PL_AMT_24_ { get; set; }
        public string ETC_PL_AMT_25_ { get; set; }
        public string BCOF_AC_CD_1_ { get; set; }
        public string BCOF_PRD_CD_1_ { get; set; }
        public string BCOF_PRD_CD_2_ { get; set; }
        public string BCOF_PRD_CD_3_ { get; set; }
        public string CLTR_OFFR_AMT_ { get; set; }
        public string CLTR_OFFR_YN_ { get; set; }
        public string MKT_PRC_ASES_CD_ { get; set; }
        public string OPT_EVET_YN_ { get; set; }
        public string HDG_TRSC_YN_ { get; set; }
        public string TST_ISS_TYP_ { get; set; }
        public string USER_SET_YN_ { get; set; }
        public string NOTE_ { get; set; }
        public string FILE_DT_ { get; set; }
        public string DB_INSERT_DT_ { get; set; }

        #endregion

        #region Properties

        private static string SelectQuery_
        = "SELECT BASC_DT, OFFC_CD, SEQ_NO, POSITION_ID, KR_CD, BCOF_ITM_NM, ISD_FUND_CD, CRPN_ID, CRPN_NM, DEAL_TYP, HOLD_QNT, BCOF_EXHG_RT_CD, PURT_AMT, ACBK_UPRC, FRC_ACBK_UPRC, MKT_UPRC, FRC_MKT_UPRC, FCVL_UNIT, FRC_FCVL_UNIT, FCVL_AMT, FRC_FCVL_AMT, ACBK_AMT, FRC_ACBK_AMT, MKT_AMT, FRC_MKT_AMT, WRNT_AMT, HOLD_MAX_QNT, FST_BUY_DT, BUY_UPRC, FST_BUY_AMT, FST_FRC_ACBK_AMT, DD_BY_ASES_LNG, DD_BY_INT_LNG, DD_BY_DEAL_LNG, DD_BY_DIVD_LNG, DD_EXP, ASES_LNG, ETC_PL_AMT_1, ETC_PL_AMT_2, ETC_PL_AMT_3, ETC_PL_AMT_4, ETC_PL_AMT_5, ETC_PL_AMT_6, ETC_PL_AMT_7, ETC_PL_AMT_8, ETC_PL_AMT_9, ETC_PL_AMT_10, ETC_PL_AMT_11, ETC_PL_AMT_12, ETC_PL_AMT_13, ETC_PL_AMT_14, ETC_PL_AMT_15, ETC_PL_AMT_16, ETC_PL_AMT_17, ETC_PL_AMT_18, ETC_PL_AMT_19, ETC_PL_AMT_20, ETC_PL_AMT_21, ETC_PL_AMT_22, ETC_PL_AMT_23, ETC_PL_AMT_24, ETC_PL_AMT_25, BCOF_AC_CD_1, BCOF_PRD_CD_1, BCOF_PRD_CD_2, BCOF_PRD_CD_3, CLTR_OFFR_AMT, CLTR_OFFR_YN, MKT_PRC_ASES_CD, OPT_EVET_YN, HDG_TRSC_YN, TST_ISS_TYP, USER_SET_YN, NOTE, FILE_DT, DB_INSERT_DT_ " +
         "FROM KOM_PSIT_INF WHERE KeyColumn = '@KeyColumnValue@'";

        private static string InsertQuery_
        = "INSERT INTO KOM_PSIT_INF (BASC_DT, OFFC_CD, SEQ_NO, POSITION_ID, KR_CD, BCOF_ITM_NM, ISD_FUND_CD, CRPN_ID, CRPN_NM, DEAL_TYP, HOLD_QNT, BCOF_EXHG_RT_CD, PURT_AMT, ACBK_UPRC, FRC_ACBK_UPRC, MKT_UPRC, FRC_MKT_UPRC, FCVL_UNIT, FRC_FCVL_UNIT, FCVL_AMT, FRC_FCVL_AMT, ACBK_AMT, FRC_ACBK_AMT, MKT_AMT, FRC_MKT_AMT, WRNT_AMT, HOLD_MAX_QNT, FST_BUY_DT, BUY_UPRC, FST_BUY_AMT, FST_FRC_ACBK_AMT, DD_BY_ASES_LNG, DD_BY_INT_LNG, DD_BY_DEAL_LNG, DD_BY_DIVD_LNG, DD_EXP, ASES_LNG, ETC_PL_AMT_1, ETC_PL_AMT_2, ETC_PL_AMT_3, ETC_PL_AMT_4, ETC_PL_AMT_5, ETC_PL_AMT_6, ETC_PL_AMT_7, ETC_PL_AMT_8, ETC_PL_AMT_9, ETC_PL_AMT_10, ETC_PL_AMT_11, ETC_PL_AMT_12, ETC_PL_AMT_13, ETC_PL_AMT_14, ETC_PL_AMT_15, ETC_PL_AMT_16, ETC_PL_AMT_17, ETC_PL_AMT_18, ETC_PL_AMT_19, ETC_PL_AMT_20, ETC_PL_AMT_21, ETC_PL_AMT_22, ETC_PL_AMT_23, ETC_PL_AMT_24, ETC_PL_AMT_25, BCOF_AC_CD_1, BCOF_PRD_CD_1, BCOF_PRD_CD_2, BCOF_PRD_CD_3, CLTR_OFFR_AMT, CLTR_OFFR_YN, MKT_PRC_ASES_CD, OPT_EVET_YN, HDG_TRSC_YN, TST_ISS_TYP, USER_SET_YN, NOTE, FILE_DT, DB_INSERT_DT_ )" +
        "VALUES ('@BASC_DTVALUE@', '@OFFC_CDVALUE@', '@SEQ_NOVALUE@', '@POSITION_IDVALUE@', '@KR_CDVALUE@', '@BCOF_ITM_NMVALUE@', '@ISD_FUND_CDVALUE@', '@CRPN_IDVALUE@', '@CRPN_NMVALUE@', '@DEAL_TYPVALUE@', '@HOLD_QNTVALUE@', '@BCOF_EXHG_RT_CDVALUE@', '@PURT_AMTVALUE@', '@ACBK_UPRCVALUE@', '@FRC_ACBK_UPRCVALUE@', '@MKT_UPRCVALUE@', '@FRC_MKT_UPRCVALUE@', '@FCVL_UNITVALUE@', '@FRC_FCVL_UNITVALUE@', '@FCVL_AMTVALUE@', '@FRC_FCVL_AMTVALUE@', '@ACBK_AMTVALUE@', '@FRC_ACBK_AMTVALUE@', '@MKT_AMTVALUE@', '@FRC_MKT_AMTVALUE@', '@WRNT_AMTVALUE@', '@HOLD_MAX_QNTVALUE@', '@FST_BUY_DTVALUE@', '@BUY_UPRCVALUE@', '@FST_BUY_AMTVALUE@', '@FST_FRC_ACBK_AMTVALUE@', '@DD_BY_ASES_LNGVALUE@', '@DD_BY_INT_LNGVALUE@', '@DD_BY_DEAL_LNGVALUE@', '@DD_BY_DIVD_LNGVALUE@', '@DD_EXPVALUE@', '@ASES_LNGVALUE@', '@ETC_PL_AMT_1VALUE@', '@ETC_PL_AMT_2VALUE@', '@ETC_PL_AMT_3VALUE@', '@ETC_PL_AMT_4VALUE@', '@ETC_PL_AMT_5VALUE@', '@ETC_PL_AMT_6VALUE@', '@ETC_PL_AMT_7VALUE@', '@ETC_PL_AMT_8VALUE@', '@ETC_PL_AMT_9VALUE@', '@ETC_PL_AMT_10VALUE@', '@ETC_PL_AMT_11VALUE@', '@ETC_PL_AMT_12VALUE@', '@ETC_PL_AMT_13VALUE@', '@ETC_PL_AMT_14VALUE@', '@ETC_PL_AMT_15VALUE@', '@ETC_PL_AMT_16VALUE@', '@ETC_PL_AMT_17VALUE@', '@ETC_PL_AMT_18VALUE@', '@ETC_PL_AMT_19VALUE@', '@ETC_PL_AMT_20VALUE@', '@ETC_PL_AMT_21VALUE@', '@ETC_PL_AMT_22VALUE@', '@ETC_PL_AMT_23VALUE@', '@ETC_PL_AMT_24VALUE@', '@ETC_PL_AMT_25VALUE@', '@BCOF_AC_CD_1VALUE@', '@BCOF_PRD_CD_1VALUE@', '@BCOF_PRD_CD_2VALUE@', '@BCOF_PRD_CD_3VALUE@', '@CLTR_OFFR_AMTVALUE@', '@CLTR_OFFR_YNVALUE@', '@MKT_PRC_ASES_CDVALUE@', '@OPT_EVET_YNVALUE@', '@HDG_TRSC_YNVALUE@', '@TST_ISS_TYPVALUE@', '@USER_SET_YNVALUE@', '@NOTEVALUE@', '@FILE_DTVALUE@', '@DB_INSERT_DTVALUE@' )";

        private static string UpdateQuery_
        = "UPDATE KOM_PSIT_INF SET BASC_DT='@BASC_DTVALUE@' OFFC_CD='@OFFC_CDVALUE@' SEQ_NO='@SEQ_NOVALUE@' POSITION_ID='@POSITION_IDVALUE@' KR_CD='@KR_CDVALUE@' BCOF_ITM_NM='@BCOF_ITM_NMVALUE@' ISD_FUND_CD='@ISD_FUND_CDVALUE@' CRPN_ID='@CRPN_IDVALUE@' CRPN_NM='@CRPN_NMVALUE@' DEAL_TYP='@DEAL_TYPVALUE@' HOLD_QNT='@HOLD_QNTVALUE@' BCOF_EXHG_RT_CD='@BCOF_EXHG_RT_CDVALUE@' PURT_AMT='@PURT_AMTVALUE@' ACBK_UPRC='@ACBK_UPRCVALUE@' FRC_ACBK_UPRC='@FRC_ACBK_UPRCVALUE@' MKT_UPRC='@MKT_UPRCVALUE@' FRC_MKT_UPRC='@FRC_MKT_UPRCVALUE@' FCVL_UNIT='@FCVL_UNITVALUE@' FRC_FCVL_UNIT='@FRC_FCVL_UNITVALUE@' FCVL_AMT='@FCVL_AMTVALUE@' FRC_FCVL_AMT='@FRC_FCVL_AMTVALUE@' ACBK_AMT='@ACBK_AMTVALUE@' FRC_ACBK_AMT='@FRC_ACBK_AMTVALUE@' MKT_AMT='@MKT_AMTVALUE@' FRC_MKT_AMT='@FRC_MKT_AMTVALUE@' WRNT_AMT='@WRNT_AMTVALUE@' HOLD_MAX_QNT='@HOLD_MAX_QNTVALUE@' FST_BUY_DT='@FST_BUY_DTVALUE@' BUY_UPRC='@BUY_UPRCVALUE@' FST_BUY_AMT='@FST_BUY_AMTVALUE@' FST_FRC_ACBK_AMT='@FST_FRC_ACBK_AMTVALUE@' DD_BY_ASES_LNG='@DD_BY_ASES_LNGVALUE@' DD_BY_INT_LNG='@DD_BY_INT_LNGVALUE@' DD_BY_DEAL_LNG='@DD_BY_DEAL_LNGVALUE@' DD_BY_DIVD_LNG='@DD_BY_DIVD_LNGVALUE@' DD_EXP='@DD_EXPVALUE@' ASES_LNG='@ASES_LNGVALUE@' ETC_PL_AMT_1='@ETC_PL_AMT_1VALUE@' ETC_PL_AMT_2='@ETC_PL_AMT_2VALUE@' ETC_PL_AMT_3='@ETC_PL_AMT_3VALUE@' ETC_PL_AMT_4='@ETC_PL_AMT_4VALUE@' ETC_PL_AMT_5='@ETC_PL_AMT_5VALUE@' ETC_PL_AMT_6='@ETC_PL_AMT_6VALUE@' ETC_PL_AMT_7='@ETC_PL_AMT_7VALUE@' ETC_PL_AMT_8='@ETC_PL_AMT_8VALUE@' ETC_PL_AMT_9='@ETC_PL_AMT_9VALUE@' ETC_PL_AMT_10='@ETC_PL_AMT_10VALUE@' ETC_PL_AMT_11='@ETC_PL_AMT_11VALUE@' ETC_PL_AMT_12='@ETC_PL_AMT_12VALUE@' ETC_PL_AMT_13='@ETC_PL_AMT_13VALUE@' ETC_PL_AMT_14='@ETC_PL_AMT_14VALUE@' ETC_PL_AMT_15='@ETC_PL_AMT_15VALUE@' ETC_PL_AMT_16='@ETC_PL_AMT_16VALUE@' ETC_PL_AMT_17='@ETC_PL_AMT_17VALUE@' ETC_PL_AMT_18='@ETC_PL_AMT_18VALUE@' ETC_PL_AMT_19='@ETC_PL_AMT_19VALUE@' ETC_PL_AMT_20='@ETC_PL_AMT_20VALUE@' ETC_PL_AMT_21='@ETC_PL_AMT_21VALUE@' ETC_PL_AMT_22='@ETC_PL_AMT_22VALUE@' ETC_PL_AMT_23='@ETC_PL_AMT_23VALUE@' ETC_PL_AMT_24='@ETC_PL_AMT_24VALUE@' ETC_PL_AMT_25='@ETC_PL_AMT_25VALUE@' BCOF_AC_CD_1='@BCOF_AC_CD_1VALUE@' BCOF_PRD_CD_1='@BCOF_PRD_CD_1VALUE@' BCOF_PRD_CD_2='@BCOF_PRD_CD_2VALUE@' BCOF_PRD_CD_3='@BCOF_PRD_CD_3VALUE@' CLTR_OFFR_AMT='@CLTR_OFFR_AMTVALUE@' CLTR_OFFR_YN='@CLTR_OFFR_YNVALUE@' MKT_PRC_ASES_CD='@MKT_PRC_ASES_CDVALUE@' OPT_EVET_YN='@OPT_EVET_YNVALUE@' HDG_TRSC_YN='@HDG_TRSC_YNVALUE@' TST_ISS_TYP='@TST_ISS_TYPVALUE@' USER_SET_YN='@USER_SET_YNVALUE@' NOTE='@NOTEVALUE@' FILE_DT='@FILE_DTVALUE@' DB_INSERT_DT='@DB_INSERT_DTVALUE@'WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM KOM_PSIT_INF WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            this.BASC_DT_ = dataRow["BASC_DT"].ToString();
            this.OFFC_CD_ = dataRow["OFFC_CD"].ToString();
            this.SEQ_NO_ = dataRow["SEQ_NO"].ToString();
            this.POSITION_ID_ = dataRow["POSITION_ID"].ToString();
            this.KR_CD_ = dataRow["KR_CD"].ToString();
            this.BCOF_ITM_NM_ = dataRow["BCOF_ITM_NM"].ToString();
            this.ISD_FUND_CD_ = dataRow["ISD_FUND_CD"].ToString();
            this.CRPN_ID_ = dataRow["CRPN_ID"].ToString();
            this.CRPN_NM_ = dataRow["CRPN_NM"].ToString();
            this.DEAL_TYP_ = dataRow["DEAL_TYP"].ToString();
            this.HOLD_QNT_ = dataRow["HOLD_QNT"].ToString();
            this.BCOF_EXHG_RT_CD_ = dataRow["BCOF_EXHG_RT_CD"].ToString();
            this.PURT_AMT_ = dataRow["PURT_AMT"].ToString();
            this.ACBK_UPRC_ = dataRow["ACBK_UPRC"].ToString();
            this.FRC_ACBK_UPRC_ = dataRow["FRC_ACBK_UPRC"].ToString();
            this.MKT_UPRC_ = dataRow["MKT_UPRC"].ToString();
            this.FRC_MKT_UPRC_ = dataRow["FRC_MKT_UPRC"].ToString();
            this.FCVL_UNIT_ = dataRow["FCVL_UNIT"].ToString();
            this.FRC_FCVL_UNIT_ = dataRow["FRC_FCVL_UNIT"].ToString();
            this.FCVL_AMT_ = dataRow["FCVL_AMT"].ToString();
            this.FRC_FCVL_AMT_ = dataRow["FRC_FCVL_AMT"].ToString();
            this.ACBK_AMT_ = dataRow["ACBK_AMT"].ToString();
            this.FRC_ACBK_AMT_ = dataRow["FRC_ACBK_AMT"].ToString();
            this.MKT_AMT_ = dataRow["MKT_AMT"].ToString();
            this.FRC_MKT_AMT_ = dataRow["FRC_MKT_AMT"].ToString();
            this.WRNT_AMT_ = dataRow["WRNT_AMT"].ToString();
            this.HOLD_MAX_QNT_ = dataRow["HOLD_MAX_QNT"].ToString();
            this.FST_BUY_DT_ = dataRow["FST_BUY_DT"].ToString();
            this.BUY_UPRC_ = dataRow["BUY_UPRC"].ToString();
            this.FST_BUY_AMT_ = dataRow["FST_BUY_AMT"].ToString();
            this.FST_FRC_ACBK_AMT_ = dataRow["FST_FRC_ACBK_AMT"].ToString();
            this.DD_BY_ASES_LNG_ = dataRow["DD_BY_ASES_LNG"].ToString();
            this.DD_BY_INT_LNG_ = dataRow["DD_BY_INT_LNG"].ToString();
            this.DD_BY_DEAL_LNG_ = dataRow["DD_BY_DEAL_LNG"].ToString();
            this.DD_BY_DIVD_LNG_ = dataRow["DD_BY_DIVD_LNG"].ToString();
            this.DD_EXP_ = dataRow["DD_EXP"].ToString();
            this.ASES_LNG_ = dataRow["ASES_LNG"].ToString();
            this.ETC_PL_AMT_1_ = dataRow["ETC_PL_AMT_1"].ToString();
            this.ETC_PL_AMT_2_ = dataRow["ETC_PL_AMT_2"].ToString();
            this.ETC_PL_AMT_3_ = dataRow["ETC_PL_AMT_3"].ToString();
            this.ETC_PL_AMT_4_ = dataRow["ETC_PL_AMT_4"].ToString();
            this.ETC_PL_AMT_5_ = dataRow["ETC_PL_AMT_5"].ToString();
            this.ETC_PL_AMT_6_ = dataRow["ETC_PL_AMT_6"].ToString();
            this.ETC_PL_AMT_7_ = dataRow["ETC_PL_AMT_7"].ToString();
            this.ETC_PL_AMT_8_ = dataRow["ETC_PL_AMT_8"].ToString();
            this.ETC_PL_AMT_9_ = dataRow["ETC_PL_AMT_9"].ToString();
            this.ETC_PL_AMT_10_ = dataRow["ETC_PL_AMT_10"].ToString();
            this.ETC_PL_AMT_11_ = dataRow["ETC_PL_AMT_11"].ToString();
            this.ETC_PL_AMT_12_ = dataRow["ETC_PL_AMT_12"].ToString();
            this.ETC_PL_AMT_13_ = dataRow["ETC_PL_AMT_13"].ToString();
            this.ETC_PL_AMT_14_ = dataRow["ETC_PL_AMT_14"].ToString();
            this.ETC_PL_AMT_15_ = dataRow["ETC_PL_AMT_15"].ToString();
            this.ETC_PL_AMT_16_ = dataRow["ETC_PL_AMT_16"].ToString();
            this.ETC_PL_AMT_17_ = dataRow["ETC_PL_AMT_17"].ToString();
            this.ETC_PL_AMT_18_ = dataRow["ETC_PL_AMT_18"].ToString();
            this.ETC_PL_AMT_19_ = dataRow["ETC_PL_AMT_19"].ToString();
            this.ETC_PL_AMT_20_ = dataRow["ETC_PL_AMT_20"].ToString();
            this.ETC_PL_AMT_21_ = dataRow["ETC_PL_AMT_21"].ToString();
            this.ETC_PL_AMT_22_ = dataRow["ETC_PL_AMT_22"].ToString();
            this.ETC_PL_AMT_23_ = dataRow["ETC_PL_AMT_23"].ToString();
            this.ETC_PL_AMT_24_ = dataRow["ETC_PL_AMT_24"].ToString();
            this.ETC_PL_AMT_25_ = dataRow["ETC_PL_AMT_25"].ToString();
            this.BCOF_AC_CD_1_ = dataRow["BCOF_AC_CD_1"].ToString();
            this.BCOF_PRD_CD_1_ = dataRow["BCOF_PRD_CD_1"].ToString();
            this.BCOF_PRD_CD_2_ = dataRow["BCOF_PRD_CD_2"].ToString();
            this.BCOF_PRD_CD_3_ = dataRow["BCOF_PRD_CD_3"].ToString();
            this.CLTR_OFFR_AMT_ = dataRow["CLTR_OFFR_AMT"].ToString();
            this.CLTR_OFFR_YN_ = dataRow["CLTR_OFFR_YN"].ToString();
            this.MKT_PRC_ASES_CD_ = dataRow["MKT_PRC_ASES_CD"].ToString();
            this.OPT_EVET_YN_ = dataRow["OPT_EVET_YN"].ToString();
            this.HDG_TRSC_YN_ = dataRow["HDG_TRSC_YN"].ToString();
            this.TST_ISS_TYP_ = dataRow["TST_ISS_TYP"].ToString();
            this.USER_SET_YN_ = dataRow["USER_SET_YN"].ToString();
            this.NOTE_ = dataRow["NOTE"].ToString();
            this.FILE_DT_ = dataRow["FILE_DT"].ToString();
            this.DB_INSERT_DT_ = dataRow["DB_INSERT_DT"].ToString();
        }

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = KOM_PSIT_INF_Table_DAO.SelectQuery_;

            selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand.CommandText, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            if (rowCount != 0 || rowCount != 1)
            { throw new Exception(); }

            foreach (DataRow item in dr)
            {
                this.BASC_DT_ = item[0].ToString();
                this.OFFC_CD_ = item[1].ToString();
                this.SEQ_NO_ = item[2].ToString();
                this.POSITION_ID_ = item[3].ToString();
                this.KR_CD_ = item[4].ToString();
                this.BCOF_ITM_NM_ = item[5].ToString();
                this.ISD_FUND_CD_ = item[6].ToString();
                this.CRPN_ID_ = item[7].ToString();
                this.CRPN_NM_ = item[8].ToString();
                this.DEAL_TYP_ = item[9].ToString();
                this.HOLD_QNT_ = item[10].ToString();
                this.BCOF_EXHG_RT_CD_ = item[11].ToString();
                this.PURT_AMT_ = item[12].ToString();
                this.ACBK_UPRC_ = item[13].ToString();
                this.FRC_ACBK_UPRC_ = item[14].ToString();
                this.MKT_UPRC_ = item[15].ToString();
                this.FRC_MKT_UPRC_ = item[16].ToString();
                this.FCVL_UNIT_ = item[17].ToString();
                this.FRC_FCVL_UNIT_ = item[18].ToString();
                this.FCVL_AMT_ = item[19].ToString();
                this.FRC_FCVL_AMT_ = item[20].ToString();
                this.ACBK_AMT_ = item[21].ToString();
                this.FRC_ACBK_AMT_ = item[22].ToString();
                this.MKT_AMT_ = item[23].ToString();
                this.FRC_MKT_AMT_ = item[24].ToString();
                this.WRNT_AMT_ = item[25].ToString();
                this.HOLD_MAX_QNT_ = item[26].ToString();
                this.FST_BUY_DT_ = item[27].ToString();
                this.BUY_UPRC_ = item[28].ToString();
                this.FST_BUY_AMT_ = item[29].ToString();
                this.FST_FRC_ACBK_AMT_ = item[30].ToString();
                this.DD_BY_ASES_LNG_ = item[31].ToString();
                this.DD_BY_INT_LNG_ = item[32].ToString();
                this.DD_BY_DEAL_LNG_ = item[33].ToString();
                this.DD_BY_DIVD_LNG_ = item[34].ToString();
                this.DD_EXP_ = item[35].ToString();
                this.ASES_LNG_ = item[36].ToString();
                this.ETC_PL_AMT_1_ = item[37].ToString();
                this.ETC_PL_AMT_2_ = item[38].ToString();
                this.ETC_PL_AMT_3_ = item[39].ToString();
                this.ETC_PL_AMT_4_ = item[40].ToString();
                this.ETC_PL_AMT_5_ = item[41].ToString();
                this.ETC_PL_AMT_6_ = item[42].ToString();
                this.ETC_PL_AMT_7_ = item[43].ToString();
                this.ETC_PL_AMT_8_ = item[44].ToString();
                this.ETC_PL_AMT_9_ = item[45].ToString();
                this.ETC_PL_AMT_10_ = item[46].ToString();
                this.ETC_PL_AMT_11_ = item[47].ToString();
                this.ETC_PL_AMT_12_ = item[48].ToString();
                this.ETC_PL_AMT_13_ = item[49].ToString();
                this.ETC_PL_AMT_14_ = item[50].ToString();
                this.ETC_PL_AMT_15_ = item[51].ToString();
                this.ETC_PL_AMT_16_ = item[52].ToString();
                this.ETC_PL_AMT_17_ = item[53].ToString();
                this.ETC_PL_AMT_18_ = item[54].ToString();
                this.ETC_PL_AMT_19_ = item[55].ToString();
                this.ETC_PL_AMT_20_ = item[56].ToString();
                this.ETC_PL_AMT_21_ = item[57].ToString();
                this.ETC_PL_AMT_22_ = item[58].ToString();
                this.ETC_PL_AMT_23_ = item[59].ToString();
                this.ETC_PL_AMT_24_ = item[60].ToString();
                this.ETC_PL_AMT_25_ = item[61].ToString();
                this.BCOF_AC_CD_1_ = item[62].ToString();
                this.BCOF_PRD_CD_1_ = item[63].ToString();
                this.BCOF_PRD_CD_2_ = item[64].ToString();
                this.BCOF_PRD_CD_3_ = item[65].ToString();
                this.CLTR_OFFR_AMT_ = item[66].ToString();
                this.CLTR_OFFR_YN_ = item[67].ToString();
                this.MKT_PRC_ASES_CD_ = item[68].ToString();
                this.OPT_EVET_YN_ = item[69].ToString();
                this.HDG_TRSC_YN_ = item[70].ToString();
                this.TST_ISS_TYP_ = item[71].ToString();
                this.USER_SET_YN_ = item[72].ToString();
                this.NOTE_ = item[73].ToString();
                this.FILE_DT_ = item[74].ToString();
                this.DB_INSERT_DT_ = item[75].ToString();
            }


        }

        public void insert(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string insertQuery = KOM_PSIT_INF_Table_DAO.InsertQuery_;

            insertQuery.Replace("@BASC_DTVALUE@", BASC_DT_);
            insertQuery.Replace("@OFFC_CDVALUE@", OFFC_CD_);
            insertQuery.Replace("@SEQ_NOVALUE@", SEQ_NO_);
            insertQuery.Replace("@POSITION_IDVALUE@", POSITION_ID_);
            insertQuery.Replace("@KR_CDVALUE@", KR_CD_);
            insertQuery.Replace("@BCOF_ITM_NMVALUE@", BCOF_ITM_NM_);
            insertQuery.Replace("@ISD_FUND_CDVALUE@", ISD_FUND_CD_);
            insertQuery.Replace("@CRPN_IDVALUE@", CRPN_ID_);
            insertQuery.Replace("@CRPN_NMVALUE@", CRPN_NM_);
            insertQuery.Replace("@DEAL_TYPVALUE@", DEAL_TYP_);
            insertQuery.Replace("@HOLD_QNTVALUE@", HOLD_QNT_);
            insertQuery.Replace("@BCOF_EXHG_RT_CDVALUE@", BCOF_EXHG_RT_CD_);
            insertQuery.Replace("@PURT_AMTVALUE@", PURT_AMT_);
            insertQuery.Replace("@ACBK_UPRCVALUE@", ACBK_UPRC_);
            insertQuery.Replace("@FRC_ACBK_UPRCVALUE@", FRC_ACBK_UPRC_);
            insertQuery.Replace("@MKT_UPRCVALUE@", MKT_UPRC_);
            insertQuery.Replace("@FRC_MKT_UPRCVALUE@", FRC_MKT_UPRC_);
            insertQuery.Replace("@FCVL_UNITVALUE@", FCVL_UNIT_);
            insertQuery.Replace("@FRC_FCVL_UNITVALUE@", FRC_FCVL_UNIT_);
            insertQuery.Replace("@FCVL_AMTVALUE@", FCVL_AMT_);
            insertQuery.Replace("@FRC_FCVL_AMTVALUE@", FRC_FCVL_AMT_);
            insertQuery.Replace("@ACBK_AMTVALUE@", ACBK_AMT_);
            insertQuery.Replace("@FRC_ACBK_AMTVALUE@", FRC_ACBK_AMT_);
            insertQuery.Replace("@MKT_AMTVALUE@", MKT_AMT_);
            insertQuery.Replace("@FRC_MKT_AMTVALUE@", FRC_MKT_AMT_);
            insertQuery.Replace("@WRNT_AMTVALUE@", WRNT_AMT_);
            insertQuery.Replace("@HOLD_MAX_QNTVALUE@", HOLD_MAX_QNT_);
            insertQuery.Replace("@FST_BUY_DTVALUE@", FST_BUY_DT_);
            insertQuery.Replace("@BUY_UPRCVALUE@", BUY_UPRC_);
            insertQuery.Replace("@FST_BUY_AMTVALUE@", FST_BUY_AMT_);
            insertQuery.Replace("@FST_FRC_ACBK_AMTVALUE@", FST_FRC_ACBK_AMT_);
            insertQuery.Replace("@DD_BY_ASES_LNGVALUE@", DD_BY_ASES_LNG_);
            insertQuery.Replace("@DD_BY_INT_LNGVALUE@", DD_BY_INT_LNG_);
            insertQuery.Replace("@DD_BY_DEAL_LNGVALUE@", DD_BY_DEAL_LNG_);
            insertQuery.Replace("@DD_BY_DIVD_LNGVALUE@", DD_BY_DIVD_LNG_);
            insertQuery.Replace("@DD_EXPVALUE@", DD_EXP_);
            insertQuery.Replace("@ASES_LNGVALUE@", ASES_LNG_);
            insertQuery.Replace("@ETC_PL_AMT_1VALUE@", ETC_PL_AMT_1_);
            insertQuery.Replace("@ETC_PL_AMT_2VALUE@", ETC_PL_AMT_2_);
            insertQuery.Replace("@ETC_PL_AMT_3VALUE@", ETC_PL_AMT_3_);
            insertQuery.Replace("@ETC_PL_AMT_4VALUE@", ETC_PL_AMT_4_);
            insertQuery.Replace("@ETC_PL_AMT_5VALUE@", ETC_PL_AMT_5_);
            insertQuery.Replace("@ETC_PL_AMT_6VALUE@", ETC_PL_AMT_6_);
            insertQuery.Replace("@ETC_PL_AMT_7VALUE@", ETC_PL_AMT_7_);
            insertQuery.Replace("@ETC_PL_AMT_8VALUE@", ETC_PL_AMT_8_);
            insertQuery.Replace("@ETC_PL_AMT_9VALUE@", ETC_PL_AMT_9_);
            insertQuery.Replace("@ETC_PL_AMT_10VALUE@", ETC_PL_AMT_10_);
            insertQuery.Replace("@ETC_PL_AMT_11VALUE@", ETC_PL_AMT_11_);
            insertQuery.Replace("@ETC_PL_AMT_12VALUE@", ETC_PL_AMT_12_);
            insertQuery.Replace("@ETC_PL_AMT_13VALUE@", ETC_PL_AMT_13_);
            insertQuery.Replace("@ETC_PL_AMT_14VALUE@", ETC_PL_AMT_14_);
            insertQuery.Replace("@ETC_PL_AMT_15VALUE@", ETC_PL_AMT_15_);
            insertQuery.Replace("@ETC_PL_AMT_16VALUE@", ETC_PL_AMT_16_);
            insertQuery.Replace("@ETC_PL_AMT_17VALUE@", ETC_PL_AMT_17_);
            insertQuery.Replace("@ETC_PL_AMT_18VALUE@", ETC_PL_AMT_18_);
            insertQuery.Replace("@ETC_PL_AMT_19VALUE@", ETC_PL_AMT_19_);
            insertQuery.Replace("@ETC_PL_AMT_20VALUE@", ETC_PL_AMT_20_);
            insertQuery.Replace("@ETC_PL_AMT_21VALUE@", ETC_PL_AMT_21_);
            insertQuery.Replace("@ETC_PL_AMT_22VALUE@", ETC_PL_AMT_22_);
            insertQuery.Replace("@ETC_PL_AMT_23VALUE@", ETC_PL_AMT_23_);
            insertQuery.Replace("@ETC_PL_AMT_24VALUE@", ETC_PL_AMT_24_);
            insertQuery.Replace("@ETC_PL_AMT_25VALUE@", ETC_PL_AMT_25_);
            insertQuery.Replace("@BCOF_AC_CD_1VALUE@", BCOF_AC_CD_1_);
            insertQuery.Replace("@BCOF_PRD_CD_1VALUE@", BCOF_PRD_CD_1_);
            insertQuery.Replace("@BCOF_PRD_CD_2VALUE@", BCOF_PRD_CD_2_);
            insertQuery.Replace("@BCOF_PRD_CD_3VALUE@", BCOF_PRD_CD_3_);
            insertQuery.Replace("@CLTR_OFFR_AMTVALUE@", CLTR_OFFR_AMT_);
            insertQuery.Replace("@CLTR_OFFR_YNVALUE@", CLTR_OFFR_YN_);
            insertQuery.Replace("@MKT_PRC_ASES_CDVALUE@", MKT_PRC_ASES_CD_);
            insertQuery.Replace("@OPT_EVET_YNVALUE@", OPT_EVET_YN_);
            insertQuery.Replace("@HDG_TRSC_YNVALUE@", HDG_TRSC_YN_);
            insertQuery.Replace("@TST_ISS_TYPVALUE@", TST_ISS_TYP_);
            insertQuery.Replace("@USER_SET_YNVALUE@", USER_SET_YN_);
            insertQuery.Replace("@NOTEVALUE@", NOTE_);
            insertQuery.Replace("@FILE_DTVALUE@", FILE_DT_);
            insertQuery.Replace("@DB_INSERT_DTVALUE@", DB_INSERT_DT_);


            dbCommand.CommandText = insertQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void update(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string updateQuery = KOM_PSIT_INF_Table_DAO.UpdateQuery_;

            updateQuery.Replace("@BASC_DTVALUE@", BASC_DT_);
            updateQuery.Replace("@OFFC_CDVALUE@", OFFC_CD_);
            updateQuery.Replace("@SEQ_NOVALUE@", SEQ_NO_);
            updateQuery.Replace("@POSITION_IDVALUE@", POSITION_ID_);
            updateQuery.Replace("@KR_CDVALUE@", KR_CD_);
            updateQuery.Replace("@BCOF_ITM_NMVALUE@", BCOF_ITM_NM_);
            updateQuery.Replace("@ISD_FUND_CDVALUE@", ISD_FUND_CD_);
            updateQuery.Replace("@CRPN_IDVALUE@", CRPN_ID_);
            updateQuery.Replace("@CRPN_NMVALUE@", CRPN_NM_);
            updateQuery.Replace("@DEAL_TYPVALUE@", DEAL_TYP_);
            updateQuery.Replace("@HOLD_QNTVALUE@", HOLD_QNT_);
            updateQuery.Replace("@BCOF_EXHG_RT_CDVALUE@", BCOF_EXHG_RT_CD_);
            updateQuery.Replace("@PURT_AMTVALUE@", PURT_AMT_);
            updateQuery.Replace("@ACBK_UPRCVALUE@", ACBK_UPRC_);
            updateQuery.Replace("@FRC_ACBK_UPRCVALUE@", FRC_ACBK_UPRC_);
            updateQuery.Replace("@MKT_UPRCVALUE@", MKT_UPRC_);
            updateQuery.Replace("@FRC_MKT_UPRCVALUE@", FRC_MKT_UPRC_);
            updateQuery.Replace("@FCVL_UNITVALUE@", FCVL_UNIT_);
            updateQuery.Replace("@FRC_FCVL_UNITVALUE@", FRC_FCVL_UNIT_);
            updateQuery.Replace("@FCVL_AMTVALUE@", FCVL_AMT_);
            updateQuery.Replace("@FRC_FCVL_AMTVALUE@", FRC_FCVL_AMT_);
            updateQuery.Replace("@ACBK_AMTVALUE@", ACBK_AMT_);
            updateQuery.Replace("@FRC_ACBK_AMTVALUE@", FRC_ACBK_AMT_);
            updateQuery.Replace("@MKT_AMTVALUE@", MKT_AMT_);
            updateQuery.Replace("@FRC_MKT_AMTVALUE@", FRC_MKT_AMT_);
            updateQuery.Replace("@WRNT_AMTVALUE@", WRNT_AMT_);
            updateQuery.Replace("@HOLD_MAX_QNTVALUE@", HOLD_MAX_QNT_);
            updateQuery.Replace("@FST_BUY_DTVALUE@", FST_BUY_DT_);
            updateQuery.Replace("@BUY_UPRCVALUE@", BUY_UPRC_);
            updateQuery.Replace("@FST_BUY_AMTVALUE@", FST_BUY_AMT_);
            updateQuery.Replace("@FST_FRC_ACBK_AMTVALUE@", FST_FRC_ACBK_AMT_);
            updateQuery.Replace("@DD_BY_ASES_LNGVALUE@", DD_BY_ASES_LNG_);
            updateQuery.Replace("@DD_BY_INT_LNGVALUE@", DD_BY_INT_LNG_);
            updateQuery.Replace("@DD_BY_DEAL_LNGVALUE@", DD_BY_DEAL_LNG_);
            updateQuery.Replace("@DD_BY_DIVD_LNGVALUE@", DD_BY_DIVD_LNG_);
            updateQuery.Replace("@DD_EXPVALUE@", DD_EXP_);
            updateQuery.Replace("@ASES_LNGVALUE@", ASES_LNG_);
            updateQuery.Replace("@ETC_PL_AMT_1VALUE@", ETC_PL_AMT_1_);
            updateQuery.Replace("@ETC_PL_AMT_2VALUE@", ETC_PL_AMT_2_);
            updateQuery.Replace("@ETC_PL_AMT_3VALUE@", ETC_PL_AMT_3_);
            updateQuery.Replace("@ETC_PL_AMT_4VALUE@", ETC_PL_AMT_4_);
            updateQuery.Replace("@ETC_PL_AMT_5VALUE@", ETC_PL_AMT_5_);
            updateQuery.Replace("@ETC_PL_AMT_6VALUE@", ETC_PL_AMT_6_);
            updateQuery.Replace("@ETC_PL_AMT_7VALUE@", ETC_PL_AMT_7_);
            updateQuery.Replace("@ETC_PL_AMT_8VALUE@", ETC_PL_AMT_8_);
            updateQuery.Replace("@ETC_PL_AMT_9VALUE@", ETC_PL_AMT_9_);
            updateQuery.Replace("@ETC_PL_AMT_10VALUE@", ETC_PL_AMT_10_);
            updateQuery.Replace("@ETC_PL_AMT_11VALUE@", ETC_PL_AMT_11_);
            updateQuery.Replace("@ETC_PL_AMT_12VALUE@", ETC_PL_AMT_12_);
            updateQuery.Replace("@ETC_PL_AMT_13VALUE@", ETC_PL_AMT_13_);
            updateQuery.Replace("@ETC_PL_AMT_14VALUE@", ETC_PL_AMT_14_);
            updateQuery.Replace("@ETC_PL_AMT_15VALUE@", ETC_PL_AMT_15_);
            updateQuery.Replace("@ETC_PL_AMT_16VALUE@", ETC_PL_AMT_16_);
            updateQuery.Replace("@ETC_PL_AMT_17VALUE@", ETC_PL_AMT_17_);
            updateQuery.Replace("@ETC_PL_AMT_18VALUE@", ETC_PL_AMT_18_);
            updateQuery.Replace("@ETC_PL_AMT_19VALUE@", ETC_PL_AMT_19_);
            updateQuery.Replace("@ETC_PL_AMT_20VALUE@", ETC_PL_AMT_20_);
            updateQuery.Replace("@ETC_PL_AMT_21VALUE@", ETC_PL_AMT_21_);
            updateQuery.Replace("@ETC_PL_AMT_22VALUE@", ETC_PL_AMT_22_);
            updateQuery.Replace("@ETC_PL_AMT_23VALUE@", ETC_PL_AMT_23_);
            updateQuery.Replace("@ETC_PL_AMT_24VALUE@", ETC_PL_AMT_24_);
            updateQuery.Replace("@ETC_PL_AMT_25VALUE@", ETC_PL_AMT_25_);
            updateQuery.Replace("@BCOF_AC_CD_1VALUE@", BCOF_AC_CD_1_);
            updateQuery.Replace("@BCOF_PRD_CD_1VALUE@", BCOF_PRD_CD_1_);
            updateQuery.Replace("@BCOF_PRD_CD_2VALUE@", BCOF_PRD_CD_2_);
            updateQuery.Replace("@BCOF_PRD_CD_3VALUE@", BCOF_PRD_CD_3_);
            updateQuery.Replace("@CLTR_OFFR_AMTVALUE@", CLTR_OFFR_AMT_);
            updateQuery.Replace("@CLTR_OFFR_YNVALUE@", CLTR_OFFR_YN_);
            updateQuery.Replace("@MKT_PRC_ASES_CDVALUE@", MKT_PRC_ASES_CD_);
            updateQuery.Replace("@OPT_EVET_YNVALUE@", OPT_EVET_YN_);
            updateQuery.Replace("@HDG_TRSC_YNVALUE@", HDG_TRSC_YN_);
            updateQuery.Replace("@TST_ISS_TYPVALUE@", TST_ISS_TYP_);
            updateQuery.Replace("@USER_SET_YNVALUE@", USER_SET_YN_);
            updateQuery.Replace("@NOTEVALUE@", NOTE_);
            updateQuery.Replace("@FILE_DTVALUE@", FILE_DT_);
            updateQuery.Replace("@DB_INSERT_DTVALUE@", DB_INSERT_DT_);


            dbCommand.CommandText = updateQuery;

            dbCommand.ExecuteNonQuery();
        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = KOM_PSIT_INF_Table_DAO.DeleteQuery_;

            deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
