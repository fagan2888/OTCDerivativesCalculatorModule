using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;

namespace RiskMonitor
{
    public abstract class DataBaseConnect
    {
        public DBSetting DBSetting_ { get; set; }
        public DataSet ResultDataSet_ { get; set; }

        public string ConnectionString_ { get; set; }
        
        //tableName , queryString
        public Dictionary<string, string> QueryList_ { get; set; }

        #region StaticFunction

        public static DataBaseConnect CreateDBConnet(string p)
        {
            DataBaseConnect conn = new OracleDataBaseConnect();
            conn.DBSetting_ = DBSettingInfoManger.dbSetting(p);

            return conn;
        }

        #endregion

        public DataBaseConnect()
        { 
            this.QueryList_ = new Dictionary<string, string>();
        }

        public void addQuery(string tableName, string query)
        {
            this.QueryList_.Add(tableName, query);
        }

        public void clearQuery()
        {
            this.QueryList_ = new Dictionary<string, string>();
        }

        public abstract void excute();

    }
}
