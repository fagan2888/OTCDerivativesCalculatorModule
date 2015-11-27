using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuerySerializeCodeGenerator
{
    public class MROVIEW_View_DAO
    {
        public MROVIEW_View_DAO() { }

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

    }
}
