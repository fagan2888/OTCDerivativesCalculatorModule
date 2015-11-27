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
    public abstract class IRCurveMarketDataLoader
    {
        protected DbConnection conn_;

        public IRCurveMarketDataLoader(DbConnection conn)
        {
            this.conn_ = conn;
        }

        public abstract void load(DateTime refDate, string curveCode, ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList);

        public abstract void loadInterval(DateTime startDate, DateTime endDate, string curveCode, ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList);

        public static IRCurveMarketDataLoader CreateMarketDataLoader(string dataSourceName)
        {
            if (dataSourceName == "" || dataSourceName.ToUpper() == "MRO")
            {
                IRCurveMarketDataLoader loader = new MRO_IRCurveMarketDataLoader(dataSourceName);

                return loader;
            }
            else
            {
                IRCurveMarketDataLoader loader = new NotImple_IRCurveMarketDataLoader();

                return loader;
            }
            
        }


    }
}
