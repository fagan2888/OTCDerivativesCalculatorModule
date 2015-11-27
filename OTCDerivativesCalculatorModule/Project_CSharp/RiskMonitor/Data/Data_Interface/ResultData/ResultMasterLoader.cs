using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace RiskMonitor
{
    public class ResultMasterLoader
    {
        public PositionHostInfo PositionHostInfo_ { get; set; }

        public ResultMasterLoader()
        { 
        }

        public List<ResultMasterInfo> loadResultData()
        {
            DataTable tb = new DataTable();

            using (SqlCeConnection connection = new SqlCeConnection("Data Source=D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\Data\\Data_Interface\\MarketDataBase.sdf"))
            using (SqlCeCommand command = connection.CreateCommand())
            {

                command.CommandText = "SELECT KR_CODE , INST_NAME , INST_CODE , CAL_VALUE , " +
                                            " CAL_UNIT_VALUE , REFERENCE_DATE , CALCULATE_DATE , " +
                                            " FILE_NAME , INST_TYPE , RESULT_TYPE FROM RESULTMASTER";
                                        

                connection.Open();
                SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command.CommandText, connection);

                dataAdapter.Fill(tb);
            }

            List<ResultMasterInfo> resultList = new List<ResultMasterInfo>();

            DataLoader loader = new DataLoader();

            DataRow[] resultRows = tb.Select();

            foreach (DataRow item in resultRows)
	        {
                ResultMasterInfo resultData = new ResultMasterInfo(item["KR_CODE"].ToString(),
                                                 item["INST_NAME"].ToString(),
                                                 item["INST_CODE"].ToString(),
                                                 item["CAL_VALUE"].ToString(),
                                                 item["CAL_UNIT_VALUE"].ToString(),
                                                 item["REFERENCE_DATE"].ToString(),
                                                 item["CALCULATE_DATE"].ToString(),
                                                 item["FILE_NAME"].ToString(),
                                                 item["INST_TYPE"].ToString(),
                                                 item["RESULT_TYPE"].ToString()
                                                 );
                resultList.Add(resultData);

	        }

            return resultList;
        }
    }
}
