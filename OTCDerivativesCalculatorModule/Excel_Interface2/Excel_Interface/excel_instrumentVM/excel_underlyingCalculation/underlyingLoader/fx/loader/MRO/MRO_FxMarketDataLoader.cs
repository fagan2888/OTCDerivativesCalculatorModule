using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class MRO_FxMarketDataLoader : FxMarketDataLoader
    {
        public MRO_FxMarketDataLoader(string dbName)
        : base(DataBaseConnectManager.ConnectionFactory(dbName))
        {
            
        }

        public override void load(DateTime refDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_fxDataViewModel> e_fdvmList)
        {
            throw new NotImplementedException();
        }
    }
}
