using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class IRMarketDataLoader
    {
        protected DbConnection conn_;

        public IRMarketDataLoader(DbConnection conn)
        {
            this.conn_ = conn;
        }

        public abstract void load(DateTime refDate, string curveCode, ObservableCollection<Excel_irDataViewModel> e_irdvmList);

        public static IRMarketDataLoader CreateMarketDataLoader(string dataSourceName)
        {
            if (dataSourceName == "MRO")
            {
                IRMarketDataLoader loader = new MRO_IRMarketDataLoader(dataSourceName);

                return loader;
            }
            else
            {
                IRMarketDataLoader loader = new NotImple_IRMarketDataLoader();

                return loader;
            }
            
        }
    }
}
