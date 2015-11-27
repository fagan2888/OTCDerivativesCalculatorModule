using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace QuerySerializeCodeGenerator
{
    public class asfasfasf_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<asfasfasf_Table_DAO> DAOList_ { get; set; }

        public string STD_DATE_;
        public string CUST_FUND_CODE_;
        public string FIRST_BUY_DATE_;
        public string KR_CODE_;
        public string ITEM_NAME_;
        public string CURRENCY_CODE_;
        public string FACE_AMT_;
        public string MRO_;
        public string SIMPONY_;
        public string DIFF_;
        public string FIRM_NAME_;
        public string CREDIT_GRADE_;
        public string FIRM_ID_;

        private static string SelectQuery_
        = "SELECT STD_DATE_, CUST_FUND_CODE_, FIRST_BUY_DATE_, KR_CODE_, ITEM_NAME_, CURRENCY_CODE_, FACE_AMT_, MRO_, SIMPONY_, DIFF_, FIRM_NAME_, CREDIT_GRADE_, FIRM_ID_ " +
         "FROM asfasfasf WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM asfasfasf WHERE KeyColumn = '@KeyColumnValue@'";
        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = asfasfasf_Table_DAOManager.SelectQuery_;



            //selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;
            
            //DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand.CommandText, conn);

            //dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                asfasfasf_Table_DAO dao = new asfasfasf_Table_DAO();

                dao.STD_DATE_ = item[0].ToString();
                dao.CUST_FUND_CODE_ = item[1].ToString();
                dao.FIRST_BUY_DATE_ = item[2].ToString();
                dao.KR_CODE_ = item[3].ToString();
                dao.ITEM_NAME_ = item[4].ToString();
                dao.CURRENCY_CODE_ = item[5].ToString();
                dao.FACE_AMT_ = item[6].ToString();
                dao.MRO_ = item[7].ToString();
                dao.SIMPONY_ = item[8].ToString();
                dao.DIFF_ = item[9].ToString();
                dao.FIRM_NAME_ = item[10].ToString();
                dao.CREDIT_GRADE_ = item[11].ToString();
                dao.FIRM_ID_ = item[12].ToString();

                this.DAOList_.Add(dao);
            }



        }

    }
}
