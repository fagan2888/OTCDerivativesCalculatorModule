using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class MRO_CommodityMarketDataLoader : CommodityMarketDataLoader
    {
        public MRO_CommodityMarketDataLoader(string dbName)
        : base(DataBaseConnectManager.ConnectionFactory(dbName))
        {
            
        }

        public override void load(DateTime refDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_commodityDataViewModel> e_edvmList)
        {
            throw new NotImplementedException();
        }
    }
}
