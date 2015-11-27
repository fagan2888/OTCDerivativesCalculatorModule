using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;

namespace Excel_Interface
{
    class MRO_CreditCurveMarketDataLoader : CreditCurveMarketDataLoader
    {
        public MRO_CreditCurveMarketDataLoader(string dbName)
        : base(DataBaseConnectManager.ConnectionFactory(dbName))
        {
            
        }

        public override void load(DateTime refDate, string curveCode, ObservableCollection<Excel_creditCurveDataViewModel> e_ccdvmList)
        {
            throw new NotImplementedException();
        }
    }
}
