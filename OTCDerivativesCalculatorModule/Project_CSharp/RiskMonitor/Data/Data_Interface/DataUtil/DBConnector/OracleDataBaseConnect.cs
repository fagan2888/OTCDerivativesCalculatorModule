using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace RiskMonitor
{
    public class OracleDataBaseConnect : DataBaseConnect
    {
        #region StaticFunction

        public static OracleDataBaseConnect CreateOracleDBConnet(string p)
        {
            OracleDataBaseConnect conn = new OracleDataBaseConnect();
            conn.DBSetting_ = DBSettingInfoManger.dbSetting(p);

            return conn;
        }

        #endregion

        public OracleDataBaseConnect()
        { 
        }

        public override void excute()
        {
            this.ResultDataSet_ = new DataSet();

            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = this.ConnectionString_;

            try
            {
                OracleCommand sqlCommand = new OracleCommand();

                conn.Open();

                // ------------------------------------------ Position --------------------------------------------
                //sqlCommand.CommandText = "SELECT  STD_DATE, SECTOR_ID , STOCK_ID , STOCK_NAME, CURR_PRICE, " +
                //                         " ADJ_STOCK_PRICE, MIN_PRICE, MAX_PRICE, DIVIDEND_RATE " +
                //                         " FROM TD_MRSTOCKFACTOR " +
                //                         " WHERE (SUBSTR(STOCK_ID, 1, 3) = 'KR7') " +
                //                         " AND STD_DATE = '"++"' AND STD_DATE = '20130909' " + 
                //                         " AND (SECTOR_ID = 'KOSPI200')";

                foreach (var item in QueryList_)
                {
		            sqlCommand.CommandText = item.Value;
                    OracleDataAdapter dataAdapter = new OracleDataAdapter(sqlCommand.CommandText, conn);

                    ResultDataSet_.Tables.Add(item.Key);
                    dataAdapter.Fill(ResultDataSet_.Tables[item.Key]);
                }

                conn.Close();

            }
            catch (OracleException e)
            {
                conn.Close();
            }
        }



        
    }
}
