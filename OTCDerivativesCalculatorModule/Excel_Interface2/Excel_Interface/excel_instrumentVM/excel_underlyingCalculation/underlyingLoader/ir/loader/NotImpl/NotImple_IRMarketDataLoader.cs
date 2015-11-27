using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class NotImple_IRMarketDataLoader : IRMarketDataLoader
    {
        public NotImple_IRMarketDataLoader()
        : base(DataBaseConnectManager.ConnectionFactory(""))
        { 

        }

        public override void load(DateTime refDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_irDataViewModel> e_irdvmList)
        {
            throw new NotImplementedException();
        }
    }
}
