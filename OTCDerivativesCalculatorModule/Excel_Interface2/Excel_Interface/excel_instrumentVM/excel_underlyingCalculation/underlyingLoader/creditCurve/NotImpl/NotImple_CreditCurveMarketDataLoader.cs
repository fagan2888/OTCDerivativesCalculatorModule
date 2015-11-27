using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class NotImple_CreditCurveMarketDataLoader : CreditCurveMarketDataLoader
    {
        public NotImple_CreditCurveMarketDataLoader()
        : base(DataBaseConnectManager.ConnectionFactory(""))
        { 

        }

        public override void load(DateTime refDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_creditCurveDataViewModel> e_ircdvmList)
        {
            throw new NotImplementedException();
        }
    }
}
