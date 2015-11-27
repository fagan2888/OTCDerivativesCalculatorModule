using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.IO;
using System.Xml;

namespace RiskMonitor
{
    public class DataLoader
    {

        public DBConnectionSetting DBConnectionSetting { get; set; }

        public DateTime ReferenceDate_ { get; set; }

        public DateTime SynchronizatedStartTime { get; private set; }
        public DateTime SynchronizatedEndTime { get; private set; }

        //public DirectoryInfo PositionPath_;
        
        public Dictionary<string, StringBuilder> QuerySet_ { get; set; }
        public Dictionary<string, List<string>> ColumnSet_ { get; set; }
        public Dictionary<string, string> QueryPathList_ { get; set; }

        private DataSet positionDataSet_ = new DataSet();

        public void synchronizateDataSet()
        {
            this.SynchronizatedStartTime = DateTime.Now;

            OdbcConnection conn = new OdbcConnection();

            conn.ConnectionString = this.DBConnectionSetting.ConnectionStr;

            try
            {
                foreach (var item in QuerySet_)
                {
                    OdbcCommand sqlCommand = new OdbcCommand();

                    conn.Open();

                    // ------------------------------------------ Position --------------------------------------------
                    sqlCommand.CommandText = item.Value.Replace("_ReferenceDate_", this.ReferenceDate_.ToString("yyyyMMdd")).ToString();

                    OdbcDataAdapter dataAdapter = new OdbcDataAdapter(sqlCommand.CommandText, conn);

                    positionDataSet_.Tables.Add(item.Key);
                    dataAdapter.Fill(positionDataSet_.Tables[item.Key]);
                }
            }
            catch (Exception e)
            {
                ErrorManager.setError(e);
            }

            this.SynchronizatedEndTime = DateTime.Now;
        }

    }
}
