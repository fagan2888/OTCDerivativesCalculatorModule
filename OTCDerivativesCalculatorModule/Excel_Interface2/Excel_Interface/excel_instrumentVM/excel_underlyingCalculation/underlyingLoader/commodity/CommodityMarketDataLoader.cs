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
    public abstract class CommodityMarketDataLoader
    {
        protected DbConnection conn_;

        public CommodityMarketDataLoader(DbConnection conn)
        {
            this.conn_ = conn;
        }

        public abstract void load(DateTime refDate, string curveCode, ObservableCollection<Excel_commodityDataViewModel> e_edvmList);

        public static CommodityMarketDataLoader CreateMarketDataLoader(string dataSourceName)
        {
            if (dataSourceName == "MRO")
            {
                CommodityMarketDataLoader loader = new MRO_CommodityMarketDataLoader(dataSourceName);

                return loader;
            }
            else
            {
                CommodityMarketDataLoader loader = new NotImple_CommodityMarketDataLoader();

                return loader;
            }

        }

    }
}
