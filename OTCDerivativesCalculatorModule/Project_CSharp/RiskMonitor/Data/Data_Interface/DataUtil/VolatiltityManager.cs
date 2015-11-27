using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace RiskMonitor
{
    public class VolatiltityManager
    {

        public string VendorType_ { get; set; }

        public double volatility(DateTime referenceDate, Underlying under, string type)
        {
            return 0.0;
        }

        public List<double> volatilityList(DateTime startDate,DateTime endDate, Underlying under, string type)
        {
            HistoryVolCalculator histVolCal = new HistoryVolCalculator();

            OracleDataBaseConnect connect = new OracleDataBaseConnect();
            connect.DBSetting_ = DBSettingInfoManger.dbSetting("MRO");
            string queryName = "Underlying";

            connect.addQuery(queryName,"");
            connect.excute();

            List<double> resultVol = new List<double>();

            foreach (DataRow item in connect.ResultDataSet_.Tables[queryName].Rows)
	        {
		        double vol = Convert.ToDouble(item["Value"].ToString());
                resultVol.Add(vol);
	        }

            histVolCal.ValueList_ = resultVol;
            histVolCal.historyCalVol();

            return histVolCal.ValueList_;

        }
        
    }
}
