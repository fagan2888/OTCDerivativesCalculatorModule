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
    public abstract class FxMarketDataLoader
    {
        protected DbConnection conn_;

        public FxMarketDataLoader(DbConnection conn)
        {
            this.conn_ = conn;
        }

        public abstract void load(DateTime refDate, string curveCode, ObservableCollection<Excel_fxDataViewModel> e_fdvmList);

        public static FxMarketDataLoader CreateMarketDataLoader(string dataSourceName)
        {
            if (dataSourceName == "MRO")
            {
                FxMarketDataLoader loader = new MRO_FxMarketDataLoader(dataSourceName);

                return loader;
            }
            else
            {
                FxMarketDataLoader loader = new NotImple_FxMarketDataLoader();

                return loader;
            }

        }

    }
}
