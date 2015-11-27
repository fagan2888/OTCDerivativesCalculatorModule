using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Buy_TradeEventViewModel : TradeEventViewModel
    {
        public Buy_TradeEventViewModel()
        {
            this.tradeType = "buy_event";
        }
    }
}
