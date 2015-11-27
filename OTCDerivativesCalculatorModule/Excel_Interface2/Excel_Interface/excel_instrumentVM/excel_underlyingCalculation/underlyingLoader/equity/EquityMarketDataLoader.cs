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
    public abstract class EquityMarketDataLoader
    {
        protected DbConnection conn_;

        public EquityMarketDataLoader(DbConnection conn)
        {
            this.conn_ = conn;
        }

        public abstract void load(DateTime refDate, string curveCode, ObservableCollection<Excel_equityDataViewModel> e_edvmList);

        public abstract string load(DateTime refDate, string symbol);

        public static EquityMarketDataLoader CreateMarketDataLoader(string dataSourceName)
        {
            if (dataSourceName == "MRO")
            {
                EquityMarketDataLoader loader = new MRO_EquityMarketDataLoader(dataSourceName);

                return loader;
            }
            else
            {
                EquityMarketDataLoader loader = new NotImple_EquityMarketDataLoader();

                return loader;
            }

        }

    }
}
