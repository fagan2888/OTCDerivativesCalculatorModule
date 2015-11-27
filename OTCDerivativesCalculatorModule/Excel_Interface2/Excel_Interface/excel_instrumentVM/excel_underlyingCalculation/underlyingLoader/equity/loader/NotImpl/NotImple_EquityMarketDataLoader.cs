using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class NotImple_EquityMarketDataLoader : EquityMarketDataLoader
    {
        public NotImple_EquityMarketDataLoader()
        : base(DataBaseConnectManager.ConnectionFactory(""))
        { 

        }

        public override void load(DateTime refDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_equityDataViewModel> e_idvmList)
        {
            throw new NotImplementedException();
        }

        public override string load(DateTime refDate, string symbol)
        {
            throw new NotImplementedException();
        }
    }
}
