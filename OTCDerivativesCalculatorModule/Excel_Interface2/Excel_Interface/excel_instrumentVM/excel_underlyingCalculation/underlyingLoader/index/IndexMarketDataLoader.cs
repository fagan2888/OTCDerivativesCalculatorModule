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
    public abstract class IndexMarketDataLoader
    {
        protected DbConnection conn_;

        public IndexMarketDataLoader(DbConnection conn)
        {
            this.conn_ = conn;
        }

        public abstract void load(DateTime refDate, string curveCode, ObservableCollection<Excel_indexDataViewModel> e_idvmList);

        public abstract string load(DateTime refDate, string symbol);

        public static IndexMarketDataLoader CreateMarketDataLoader(string dataSourceName)
        {
            if (dataSourceName == "MRO")
            {
                IndexMarketDataLoader loader = new MRO_IndexMarketDataLoader(dataSourceName);

                return loader;
            }
            else
            {
                IndexMarketDataLoader loader = new NotImple_IndexMarketDataLoader();

                return loader;
            }
            
        }

    }
}
