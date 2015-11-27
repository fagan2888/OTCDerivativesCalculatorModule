//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.Data.SqlClient;

//namespace QuerySerializeCodeGenerator
//{
//    public class asdasd_View_DAOManager
//    {
//        public string KEYCOLUMN1_ { get; set; }
//        public string KEYCOLUMN2_ { get; set; }

//        public List<asdasd_View_DAO> DAOList_ { get; set; }

//        public string STD_DATE_;
//        public string CUST_FUND_CODE_;
//        public string FIRST_BUY_DATE_;
//        public string KR_CODE_;
//        public string ITEM_NAME_;
//        public string CURRENCY_CODE_;
//        public string FACE_AMT_;
//        public string MRO_;
//        public string SIMPONY_;
//        public string DIFF_;
//        public string FIRM_NAME_;
//        public string CREDIT_GRADE_;
//        public string FIRM_ID_;

//        private static string SelectQuery_
//        = "  select C.std_date, " +
//         "  C.cust_fund_code, " +
//         "  C.first_buy_date as FIRST_BUY_DATE, " +
//         "  C.kr_code as KR_CODE, " +
//         "  C.item_name as ITEM_NAME, " +
//         "  C.CURRENCY_CODE as CURRENCY_CODE, " +
//         "  C.FACE_AMT as FACE_AMT, " +
//         "  D.dirty_price / 10000 * C.FACE_AMT as MRO, " +
//         "  C.market_amt as SIMPONY, " +
//         "  round(abs(D.dirty_price / 10000 * C.FACE_AMT - C.market_amt)/C.FACE_AMT * 10000,2) as DIFF, " +
//         "  C.firm_name as FIRM_NAME, " +
//         "  C.CREDIT_GRADE as CREDIT_GRADE, " +
//         "  C.firm_id as FIRM_ID " +
//         "  from ( " +
//         "  SELECT std_date, " +
//         "  cust_fund_code, " +
//         "  first_buy_date, " +
//         "  kr_code, " +
//         "  item_name, " +
//         "  CURRENCY_CODE, " +
//         "  FACE_AMT, " +
//         "  market_amt, " +
//         "  firm_name, " +
//         "  CREDIT_GRADE, " +
//         "  firm_id " +
//         "  FROM td_mrposition A WHERE std_date='@KeyColumn1@' " +
//         "  AND FIRST_BUY_DATE >= '@KeyColumn2@' " +
//         "  AND substr(cust_fund_code, 1, 1) in ('A' ,'F') " +
//         "  order by first_buy_date desc) C, " +
//         "  ( select * from otc_td_mrcalcprice where std_date='@KeyColumn1@' ) D " +
//         "  where C.kr_code = D.kr_code(+) ";

//        public void select(DbConnection conn)
//        {
//            if (conn.State != ConnectionState.Open)
//                conn.Open();

//            DataTable tb = new DataTable();

//            DbCommand dbCommand = conn.CreateCommand();

//            string selectQuery = asdasd_View_DAOManager.SelectQuery_;

//            if (this.KEYCOLUMN1_ == null || this.KEYCOLUMN1_ == "") { throw new Exception(); }

//            selectQuery.Replace("@KEYCOLUMN1VALUE@", this.KEYCOLUMN1_);
//            selectQuery.Replace("@KEYCOLUMN2VALUE@", this.KEYCOLUMN2_);


//            //selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

//            dbCommand.CommandText = selectQuery;

//            DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand.CommandText, conn);

//            dataAdapter.Fill(tb);

//            DataRow[] dr = tb.Select();
//            int rowCount = dr.Length;

//            foreach (DataRow item in dr)
//            {
//                asdasd_View_DAO dao = new asdasd_View_DAO();

//                dao.STD_DATE_ = item[0].ToString();
//                dao.CUST_FUND_CODE_ = item[1].ToString();
//                dao.FIRST_BUY_DATE_ = item[2].ToString();
//                dao.KR_CODE_ = item[3].ToString();
//                dao.ITEM_NAME_ = item[4].ToString();
//                dao.CURRENCY_CODE_ = item[5].ToString();
//                dao.FACE_AMT_ = item[6].ToString();
//                dao.MRO_ = item[7].ToString();
//                dao.SIMPONY_ = item[8].ToString();
//                dao.DIFF_ = item[9].ToString();
//                dao.FIRM_NAME_ = item[10].ToString();
//                dao.CREDIT_GRADE_ = item[11].ToString();
//                dao.FIRM_ID_ = item[12].ToString();

//                this.DAOList_.Add(dao);
//            }



//        }

//    }
//}
