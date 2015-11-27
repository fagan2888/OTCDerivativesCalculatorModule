using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;

namespace RiskMonitor
{
    public class OptionpPositionDataLoader
    {


        public ObservableCollection<Option> dataLoad()
        {
            ObservableCollection<Option> result = new ObservableCollection<Option>();

            return result;
        }


        private DataSet connectDB()
        {
            DataSet dataSet = new DataSet();

            string query = "";

            OracleDataBaseConnect dbConnect = new OracleDataBaseConnect();
            dbConnect.DBSetting_ = DBSettingInfoManger.dbSetting("MRO");

            dbConnect.addQuery("OptionPositionHist", query);
            dbConnect.excute();

            return dbConnect.ResultDataSet_;
        }

    }
}
