using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class NotImple_CommodityMarketDataLoader : CommodityMarketDataLoader
    {
        public NotImple_CommodityMarketDataLoader()
        : base(DataBaseConnectManager.ConnectionFactory(""))
        { 

        }

        public override void load(DateTime refDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_commodityDataViewModel> e_cdvmList)
        {
            throw new NotImplementedException();
        }

    }
}
