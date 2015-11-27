using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_commoditySymbolViewModel : Excel_marketDataSymbol
    {
        public override string dataLoad(DateTime refDate, string code)
        {
            throw new NotImplementedException();
        }

        public override Excel_underlyingInfoViewModel underlyingInfoVM()
        {
            throw new NotImplementedException();
        }
    }
}
