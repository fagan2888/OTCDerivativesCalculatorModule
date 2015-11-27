using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class MRO_IRMarketDataLoader : IRMarketDataLoader
    {
        public MRO_IRMarketDataLoader(string dbName)
        : base(DataBaseConnectManager.ConnectionFactory(dbName))
        {
            
        }

        public override void load(DateTime refDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_irDataViewModel> e_irdvmList)
        {
            throw new NotImplementedException();
        }
    }
}
