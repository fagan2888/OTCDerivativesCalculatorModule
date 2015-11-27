using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;

namespace RiskMonitor
{
    public abstract class UnderlyingLoader
    {
        public string InstCode_ { get; set; }
        protected DataSet dataSet_;

        public DateTime ReferenceDate_ { get; set; }

        IndexQuoteLoader quoteLoader = new IndexQuoteLoader();
        VolatilityLoader volLoader = new VolatilityLoader();

        public ParameterSetting Setting_ { get; set; }
        public string StockKRCode_ { get; set; }

        public DBConnectionSetting DBConnSetting_ { get; set; }

        public UnderlyingLoader() 
        {
            //this.connStr_ = connStr;
            

            dataSet_ = new DataSet("OTCDataSet");
        }

        public abstract void loadData();

        public abstract long currentValue();
        //public abstract double drift();
        //public abstract double dividend();
        //public abstract double vol();

    }
}
