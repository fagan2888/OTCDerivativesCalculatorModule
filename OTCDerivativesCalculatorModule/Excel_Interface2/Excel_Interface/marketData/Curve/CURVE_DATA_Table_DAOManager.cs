//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.Data.Common;

//namespace Excel_Interface
//{
//    public class CURVE_DATA_Table_DAOManager
//    {
//        public string KeyColumn_ { get; set; }

//        public List<CURVE_DATA_Table_DAO> DAOList_ { get; set; }

//        #region Properties

//        public string CURVE_DATE_;
//        public string CURVE_CODE_;
//        public string CURVE_NAME_;
//        public string DATA_1_;
//        public string DATA_2_;
//        public string DATA_3_;
//        public string DATA_4_;
//        public string DATA_5_;
//        public string DATA_6_;
//        public string DATA_7_;
//        public string DATA_8_;
//        public string DATA_9_;
//        public string DATA_10_;
//        public string DATA_11_;
//        public string DATA_12_;
//        public string DATA_13_;
//        public string DATA_14_;
//        public string DATA_15_;

//        #endregion

//        #region Query

//        private static string SelectQuery_
//        = "SELECT CURVE_DATE, CURVE_CODE, CURVE_NAME, DATA_1, DATA_2, DATA_3, DATA_4, DATA_5, DATA_6, DATA_7, DATA_8, DATA_9, DATA_10, DATA_11, DATA_12, DATA_13, DATA_14, DATA_15 " +
//         "FROM CURVE_DATA WHERE KeyColumn = '@KeyColumnValue@'";

//        private static string DeleteQuery_
//        = "DELETE FROM CURVE_DATA WHERE KeyColumn = '@KeyColumnValue@'";

//        #endregion

//        public void select(DbConnection conn)
//        {
//            if (conn.State != ConnectionState.Open)
//                conn.Open();

//            DataTable tb = new DataTable();

//            this.DAOList_ = new List<CURVE_DATA_Table_DAO>();

//            DbCommand dbCommand = conn.CreateCommand();

//            string selectQuery = CURVE_DATA_Table_DAOManager.SelectQuery_;

//            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

//            dbCommand.CommandText = selectQuery;

//            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
//            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

//            dataAdapter.Fill(tb);

//            DataRow[] dr = tb.Select();
//            int rowCount = dr.Length;

//            foreach (DataRow item in dr)
//            {
//                CURVE_DATA_Table_DAO dao = new CURVE_DATA_Table_DAO();

//                dao.CURVE_DATE_ = item[0].ToString();
//                dao.CURVE_CODE_ = item[1].ToString();
//                dao.CURVE_NAME_ = item[2].ToString();
//                dao.DATA_1_ = item[3].ToString();
//                dao.DATA_2_ = item[4].ToString();
//                dao.DATA_3_ = item[5].ToString();
//                dao.DATA_4_ = item[6].ToString();
//                dao.DATA_5_ = item[7].ToString();
//                dao.DATA_6_ = item[8].ToString();
//                dao.DATA_7_ = item[9].ToString();
//                dao.DATA_8_ = item[10].ToString();
//                dao.DATA_9_ = item[11].ToString();
//                dao.DATA_10_ = item[12].ToString();
//                dao.DATA_11_ = item[13].ToString();
//                dao.DATA_12_ = item[14].ToString();
//                dao.DATA_13_ = item[15].ToString();
//                dao.DATA_14_ = item[16].ToString();
//                dao.DATA_15_ = item[17].ToString();

//                this.DAOList_.Add(dao);
//            }



//        }

//        public void delete(DbConnection conn)
//        {
//            if (conn.State != ConnectionState.Open)
//                conn.Open();

//            DbCommand dbCommand = conn.CreateCommand();

//            string deleteQuery = CURVE_DATA_Table_DAOManager.DeleteQuery_;

//            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

//            dbCommand.CommandText = deleteQuery;

//            dbCommand.ExecuteNonQuery();
//        }

//    }
//}
