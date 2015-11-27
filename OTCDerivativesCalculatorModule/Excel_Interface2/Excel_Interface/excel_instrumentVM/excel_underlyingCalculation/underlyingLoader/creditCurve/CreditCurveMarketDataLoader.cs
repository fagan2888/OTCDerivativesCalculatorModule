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
    public abstract class CreditCurveMarketDataLoader
    {
        protected DbConnection conn_;

        public CreditCurveMarketDataLoader(DbConnection conn)
        {
            this.conn_ = conn;
        }

        public abstract void load(DateTime refDate, string curveCode, ObservableCollection<Excel_creditCurveDataViewModel> e_ccdvmList);

        public static CreditCurveMarketDataLoader CreateMarketDataLoader(string dataSourceName)
        {
            if (dataSourceName == "MRO")
            {
                CreditCurveMarketDataLoader loader = new MRO_CreditCurveMarketDataLoader(dataSourceName);

                return loader;
            }
            else
            {
                CreditCurveMarketDataLoader loader = new NotImple_CreditCurveMarketDataLoader();

                return loader;
            }
            
        }
    }
}
