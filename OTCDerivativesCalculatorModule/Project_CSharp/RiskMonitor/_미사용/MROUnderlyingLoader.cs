//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.Data.Odbc;
//using System.Data.OleDb;
//using QLNet;

//namespace RiskMonitor
//{
//    public class MROUnderlyingLoader : UnderlyingLoader
//    {
        

//        public MROUnderlyingLoader() 
//        {
        
//        }

//        public MROUnderlyingLoader( ParameterSetting setting)
//        {
//            // TODO: Complete member initialization
//            this.Setting_ = setting;
//            this.DBConnSetting_ = new DBConnectionSetting();
            
//            this.loadData();
//        }

//        public override long currentValue()
//        {
//            DataTable tb = this.dataSet_.Tables["UnderlyingCurrentPrice"];

//            string selectionStr = " STOCK_ID = '" + StockKRCode_ + "'";
//            DataRow[] results = tb.Select(selectionStr);

//            string resultStr = results[0]["CURR_PRICE"].ToString();

//            return Convert.ToInt64(results[0]["CURR_PRICE"].ToString());
//        }

//        public override double drift()
//        {
//            return 0.0285;
//        }

//        public override double dividend()
//        {
//            DataTable tb = this.dataSet_.Tables["Underlying"];
//            string selectionStr = "KR_CODE = '" + InstCode_ + "' and STOCK_ID = '" + StockKRCode_ + "'";
//            DataRow[] results = tb.Select(selectionStr);

//            return Convert.ToDouble(results[0]["DIVIDEND_RATE"].ToString());
//        }

//        public override double vol()
//        {
//            DataTable tb = this.dataSet_.Tables["Underlying"];
//            string selectionStr = "KR_CODE = '" + InstCode_ + "' and STOCK_ID = '" + StockKRCode_ + "'";
//            DataRow[] results = tb.Select(selectionStr);

//            return Convert.ToDouble(results[0]["VOL"].ToString());
//        }

//        public override void loadData()
//        {
//            OdbcConnection conn = new OdbcConnection();
//            conn.ConnectionString = DBConnSetting_.ConnectionStr;
//            //DateTime referenceDate = Settings.evaluationDate();
//            DateTime referenceDate = new DateTime(2013, 07, 30);

//            try
//            {
//                OdbcCommand sqlCommand = new OdbcCommand();

//                conn.Open();

//                // ------------------------------------------ Vol & Dividend --------------------------------------------
//                sqlCommand.CommandText = "select STD_DATE, " +
//                                         "KR_CODE, " +
//                                         "STOCK_ID, " +
//                                         "VOL, " +
//                                         "DIVIDEND_RATE " +
//                                         "from mro.otc_td_mrstockfactorvol " +
//                                         "where STD_DATE='" + referenceDate.ToString("yyyyMMdd") + "'";

//                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(sqlCommand.CommandText, conn);

//                dataSet_.Tables.Add("Underlying");
//                dataAdapter.Fill(dataSet_.Tables["Underlying"]);

//                // ------------------------------------------ Vol & Dividend --------------------------------------------
//                sqlCommand.CommandText = "select STD_DATE, " +
//                                         "STOCK_ID, " +
//                                         "STOCK_INDEX_TYPE, " +
//                                         "STOCK_NAME, " +
//                                         "ROUND(CURR_PRICE,0) AS CURR_PRICE, " +
//                                         "ADJ_STOCK_PRICE " +
//                                         "from mro.td_mrstockfactor " +
//                                         "where STD_DATE='" + referenceDate.ToString("yyyyMMdd") + "' " +
//                                         "and STOCK_INDEX_TYPE IN ('KOSPI200','KOSTAR')";

//                dataAdapter = new OdbcDataAdapter(sqlCommand.CommandText, conn);

//                dataSet_.Tables.Add("UnderlyingCurrentPrice");
//                dataAdapter.Fill(dataSet_.Tables["UnderlyingCurrentPrice"]);



//                conn.Close();

//            }
//            catch (OdbcException e)
//            {
//                conn.Close();
//            }
//        }
//    }
//}
