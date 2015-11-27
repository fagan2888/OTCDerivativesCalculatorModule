using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    public class CurveHeaderInfo_Table_DAOManager
    {
        public string KeyColumn_ { get; set; }

        public List<CurveHeaderInfo_Table_DAO> DAOList_ { get; set; }

        #region Properties

        public string CURVE_CODE_;
        public string CURVE_NAME_;
        public string CURVE_CLASS_;
        public string DISCRIPTION_;

        #endregion

        #region Query

        private static string SelectQuery_
        = "SELECT CURVE_CODE, CURVE_NAME, CURVE_CLASS, DISCRIPTION " +
         "FROM CURVEHEADER_INFO";// WHERE KeyColumn = '@KeyColumnValue@'";

        private static string DeleteQuery_
        = "DELETE FROM CURVEHEADER_INFO WHERE KeyColumn = '@KeyColumnValue@'";

        #endregion

        public void select(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DataTable tb = new DataTable();

            this.DAOList_ = new List<CurveHeaderInfo_Table_DAO>();

            DbCommand dbCommand = conn.CreateCommand();

            string selectQuery = CurveHeaderInfo_Table_DAOManager.SelectQuery_;



            //selectQuery = selectQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = selectQuery;

            //DbDataAdapter dataAdapter = new DbDataAdapter(dbCommand, conn);
            DbDataAdapter dataAdapter = DataBaseConnectManager.CreateDataAdapter(dbCommand, conn);

            dataAdapter.Fill(tb);

            DataRow[] dr = tb.Select();
            int rowCount = dr.Length;

            foreach (DataRow item in dr)
            {
                CurveHeaderInfo_Table_DAO dao = new CurveHeaderInfo_Table_DAO();

                dao.CURVE_CODE_ = item[0].ToString();
                dao.CURVE_NAME_ = item[1].ToString();
                dao.CURVE_CLASS_ = item[2].ToString();
                dao.DISCRIPTION_ = item[3].ToString();

                this.DAOList_.Add(dao);
            }



        }

        public void delete(DbConnection conn)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();

            DbCommand dbCommand = conn.CreateCommand();

            string deleteQuery = CurveHeaderInfo_Table_DAOManager.DeleteQuery_;

            deleteQuery = deleteQuery.Replace("@KeyColumnValue@", this.KeyColumn_);

            dbCommand.CommandText = deleteQuery;

            dbCommand.ExecuteNonQuery();
        }

    }
}
