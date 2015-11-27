using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class NotImple_IRCurveMarketDataLoader : IRCurveMarketDataLoader
    {

        public NotImple_IRCurveMarketDataLoader()
        : base(DataBaseConnectManager.ConnectionFactory(""))
        { 

        }

        public override void load(DateTime refDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList)
        {
            throw new NotImplementedException();
        }

        public override void loadInterval(DateTime startDate, DateTime endDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_irCurveDataViewModel> e_ircdvmList)
        {
            throw new NotImplementedException();
        }
    }
}
