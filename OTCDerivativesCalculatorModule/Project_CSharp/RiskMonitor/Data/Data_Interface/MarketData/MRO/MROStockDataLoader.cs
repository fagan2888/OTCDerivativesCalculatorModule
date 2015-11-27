//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.Data.Odbc;
//using System.Data.OleDb;

//namespace RiskMonitor
//{
//    public class MROStockDataLoader : StockDataLoader
//    {
//        //ELS_ItemCode

//        public MROStockDataLoader() 
//        {
//            this.DBConnSetting_ = new DBConnectionSetting();

//            //PositionPath_ = new DirectoryInfo("D:\\Project File\\OTCDerivativesCalculatorModule\\");
//            //PositionPath_ = new DirectoryInfo("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\");

//            dataSet_ = new DataSet("OTCDataSet");
//            //this.loadDataSet();
//        }

//        public override void loadData()
//        {
//            OdbcConnection conn = new OdbcConnection();
//            conn.ConnectionString = DBConnSetting_.ConnectionStr;
//            //DateTime referenceDate = Settings.evaluationDate();
//            DateTime referenceDate = ReferenceDate_;

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
//                                         "ROUND(ADJ_STOCK_PRICE,0) AS ADJ_STOCK_PRICE " +
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
//                OutputLogViewModel.addResult("DataBase Connection Error " + ItemCode_);
//                throw;
//            }
//        }


//        // MarketDataBase.sdf 에 Feed 함.
//        public override void feedData()
//        {
//            OdbcConnection conn = new OdbcConnection();
//            conn.ConnectionString = DBConnSetting_.ConnectionStr;
//            //DateTime referenceDate = Settings.evaluationDate();
//            DateTime referenceDate = ReferenceDate_;

//            try
//            {
//                OdbcCommand sqlCommand = new OdbcCommand();

//                conn.Open();

//                // ------------------------------------------ Vol & Dividend --------------------------------------------
//                sqlCommand.CommandText = "select STD_DATE, " +
//                                         "'MROVol', " +
//                                         "KR_CODE, " +
//                                         "'MROVolatility', " +
//                                         "STOCK_ID, " +
//                                         "VOL, " +
//                                         "'MROVol', " +
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
//                                         "ROUND(ADJ_STOCK_PRICE,0) AS ADJ_STOCK_PRICE " +
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
//                OutputLogViewModel.addResult("DataBase Connection Error " + ItemCode_);
//                throw;
//            }
//        }

//        public override double drift()
//        {
//            return 0.029;
//        }

//        public override double dividend()
//        {
//            double div = 0.0;

//            DataRow[] resultRow = dataSet_.Tables["Underlying"].Select(" KR_CODE ='" + ItemCode_ + "' AND STOCK_ID ='" + UnderCode_ + "'");

//            if( resultRow.Length < 1 )
//            {
//                OutputLogViewModel.addResult("No Dividend Result in Underlying" + UnderCode_);
//            }else
//            {
//                div = Convert.ToDouble(resultRow[0]["DIVIDEND_RATE"].ToString());
//            }

//            return div;
//        }

//        public override double vol()
//        {
//            double volatility = 0.0;

//            DataRow[] resultRow = dataSet_.Tables["Underlying"].Select(" KR_CODE ='" + ItemCode_ + "' AND STOCK_ID ='" + UnderCode_ + "'");

//            if (resultRow.Length < 1)
//            {
//                OutputLogViewModel.addResult("No VOL Result in Underlying" + UnderCode_);
//            }
//            else
//            {
//                volatility = Convert.ToDouble(resultRow[0]["VOL"].ToString());
//            }

//            return volatility;
//        }

//        public override long currentValue()
//        {
//            long current = 0;

//            DataRow[] resultRow = dataSet_.Tables["UnderlyingCurrentPrice"].Select(" STOCK_ID ='" + UnderCode_ + "'");

//            if (resultRow.Length < 1)
//            {
//                OutputLogViewModel.addResult("No CurrentValue Result in Underlying" + UnderCode_);
//            }
//            else
//            {
//                string valueStr = resultRow[0]["ADJ_STOCK_PRICE"].ToString();
//                current = Convert.ToInt32(valueStr);
//            }

//            return current;
//        }
//    }
//}
