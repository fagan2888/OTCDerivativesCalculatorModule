using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class NotImple_FxMarketDataLoader : FxMarketDataLoader
    {
        public NotImple_FxMarketDataLoader()
        : base(DataBaseConnectManager.ConnectionFactory(""))
        { 

        }

        public override void load(DateTime refDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_fxDataViewModel> e_fdvmList)
        {
            throw new NotImplementedException();
        }
    }
}
