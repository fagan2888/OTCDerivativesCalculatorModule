using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using QLNet;

namespace RiskMonitor
{
    public class CorrelationLoader
    {
        enum CorrelationMethod { Constant }

        protected DataSet dataSet_;

        public DateTime ReferenceDate_ { get; set; }
        public DBConnectionSetting DBConnSetting_ { get; set; }

        public ParameterSetting Method_ { get; set; }

        public CorrelationLoader()
        {
            this.DBConnSetting_ = new DBConnectionSetting();
        }

        public void loadData()
        {
            OdbcConnection conn = new OdbcConnection();
            conn.ConnectionString = DBConnSetting_.ConnectionStr;
            //DateTime referenceDate = Settings.evaluationDate();
            DateTime referenceDate = ReferenceDate_;

            try
            {
                OdbcCommand sqlCommand = new OdbcCommand();

                conn.Open();

                // ------------------------------------------ Vol & Dividend --------------------------------------------
                sqlCommand.CommandText = "select STD_DATE,STOCK_ID,OTHER_ID,CORR " +
                                         "from otc_td_mrelsstockcorr " +
                                         "where STD_DATE='" + referenceDate.ToString("yyyyMMdd") + "'";

                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(sqlCommand.CommandText, conn);

                DataTable tb = new DataTable();
                dataAdapter.Fill(tb);

                using (SqlCeConnection connection = new SqlCeConnection("Data Source=D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\Data\\MarketDataBase.sdf"))
                using (SqlCeCommand command = connection.CreateCommand())
                {
                    //command.CommandText = "INSERT INTO CORRELATION (DATE,   CODE_A,   NAME_A,   CODE_B,   NAME_B,   CORR,   TYPE,   VENDOR,  DESCRIPTION) " +
                    //                                       " VALUES (@pdate, @pcode_a, @pname_a ,@pcode_b, @pname_b, @pcorr, @ptype, @pvendor, @pdescription)" +
                    //                                       " WHERE DATE not in ( select DATE from CORRELATION where DATE='" + ReferenceDate_.ToString("yyyyMMdd") + "')";

                    connection.Open();

                    SqlCeCommand delCommand = connection.CreateCommand();
                    delCommand.CommandText = "DELETE FROM CORRELATION WHERE DATE ='" + ReferenceDate_.ToString("yyyyMMdd") + "'";

                    delCommand.ExecuteNonQuery();

                    command.CommandText = "INSERT INTO CORRELATION (DATE,   CODE_A,   NAME_A,   CODE_B,   NAME_B,   CORR,   TYPE,   VENDOR,  DESCRIPTION) " +
                                                           " VALUES (@pdate, @pcode_a, @pname_a ,@pcode_b, @pname_b, @pcorr, @ptype, @pvendor, @pdescription)";

                    command.Parameters.Add("@pdate", SqlDbType.NVarChar);
                    command.Parameters.Add("@pcode_a", SqlDbType.NVarChar);
                    command.Parameters.Add("@pname_a", SqlDbType.NVarChar);
                    command.Parameters.Add("@pcode_b", SqlDbType.NVarChar);
                    command.Parameters.Add("@pname_b", SqlDbType.NVarChar);
                    command.Parameters.Add("@pcorr", SqlDbType.NVarChar);
                    command.Parameters.Add("@ptype", SqlDbType.NVarChar);
                    command.Parameters.Add("@pvendor", SqlDbType.NVarChar);
                    command.Parameters.Add("@pdescription", SqlDbType.NVarChar);

                    

                    //command.ExecuteNonQuery();

                    foreach (DataRow item in tb.Rows)
                    {
                        string code_a = item["STOCK_ID"].ToString();
                        string code_b = item["OTHER_ID"].ToString();

                        if (code_a != code_b)
                        {
                            command.Parameters["@pdate"].Value = item["STD_DATE"].ToString();
                            command.Parameters["@pcode_a"].Value = code_a;
                            command.Parameters["@pname_a"].Value = "null";
                            command.Parameters["@pcode_b"].Value = code_b;
                            command.Parameters["@pname_b"].Value = "null";
                            command.Parameters["@pcorr"].Value = item["CORR"].ToString();
                            command.Parameters["@ptype"].Value = "History";
                            command.Parameters["@pvendor"].Value = "MRO";
                            command.Parameters["@pdescription"].Value = "This is test";

                            command.ExecuteNonQuery();
                        }
                    }

                    
                }

                conn.Close();

            }
            catch (OdbcException e)
            {
                conn.Close();
                OutputLogViewModel.addResult("DataBase Connection Error : MRO DB Load");
                throw;
            }

        }

        public double corr(string itemCode1, string itemCode2) 
        {
            double corrValue = 0.0;

            using (SqlCeConnection connection = new SqlCeConnection("Data Source=D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\Data\\MarketDataBase.sdf"))
            using (SqlCeCommand command = connection.CreateCommand())
            {

                command.CommandText = "SELECT DATE,CODE_A,CODE_B,CORR FROM CORRELATION WHERE DATE='" + ReferenceDate_.ToString("yyyyMMdd") +
                                        "' AND CODE_A = '" + itemCode1 + "' AND CODE_B = '" + itemCode2 + "'";

                connection.Open();
                SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command.CommandText, connection);

                DataTable tb = new DataTable();
                dataAdapter.Fill(tb);
                //string selectionStr = " DATE = '"++"' and CODE_A = '" + itemCode1 + "' and CODE_B = '" + itemCode2 + "'";
                //DataRow[] results = tb.Select(selectionStr);

                //tb.Select("

                if (tb.Rows.Count == 1)
                {
                    corrValue = Convert.ToDouble(tb.Rows[0]["CORR"].ToString());
                }
            }

            return corrValue;
        }

        public Matrix corr(List<string> itemCodes)
        {
            return new Matrix();
        }

        
    }
}
