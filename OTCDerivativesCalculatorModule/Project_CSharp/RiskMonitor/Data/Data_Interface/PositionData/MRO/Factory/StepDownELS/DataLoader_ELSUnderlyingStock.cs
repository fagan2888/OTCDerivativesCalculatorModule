using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class DataLoader_ELSUnderlyingStock
    {
        private string dataSQL = SQLSetting.ELSUnderlyingStock;

        public List<ELSUnderlyingStock> ELSUnderlyingStockListLoad() 
        {
            DataSet dataSet_ = new DataSet();

            DataTable dt = dataSet_.Tables["ELSUNDERLYINGSTOCK"];

            List<ELSUnderlyingStock> underList = new List<ELSUnderlyingStock>();

            foreach (DataRow item in dt.Rows)
            {
                string name = item["STOCKNAME"].ToString();
                long currentPrice = Convert.ToInt64(item["CURRENTPRICE"].ToString());
                long basePrice = Convert.ToInt64(item["BASEPRICE"].ToString());
                double dividend = Convert.ToDouble(item["DIVIDEND"].ToString());
                string assDerivativesCode = Convert.ToString(item["ASSDERIVATIVESCODE"].ToString());
                double vol = Convert.ToDouble(item["VOL"].ToString());
                Delta delta = new Delta(Convert.ToDouble(item["DELTA"].ToString()));
                Gamma gamma = new Gamma(Convert.ToDouble(item["GAMMA"].ToString()));
                Vega vega = new Vega(Convert.ToDouble(item["VEGA"].ToString()));

                underList.Add(new ELSUnderlyingStock(name,
                                                    currentPrice,
                                                    basePrice,
                                                    dividend,
                                                    assDerivativesCode,
                                                    vol,
                                                    delta,
                                                    gamma,
                                                    vega));
            }

            return underList;
        }
    }
}
