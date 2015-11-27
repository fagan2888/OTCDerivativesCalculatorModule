using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_fxSymbolViewModel : Excel_marketDataSymbol
    {
        public override string dataLoad(DateTime refDate, string code)
        {
            throw new NotImplementedException();
        }

        public override Excel_underlyingInfoViewModel underlyingInfoVM()
        {
            Excel_stockIndexViewModel e_sivm = new Excel_stockIndexViewModel();

            e_sivm.KrCode_ = this.Symbol_;
            e_sivm.NameTrans_= new NameTrans(this.name_eng_);

            return e_sivm;
        }

    }
}
