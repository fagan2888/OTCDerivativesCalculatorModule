using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_equitySymbolViewModel : Excel_marketDataSymbol
    {

        public override string dataLoad(DateTime refDate, string code)
        {
            
            //EquityMarketDataLoader emdl = EquityMarketDataLoader.CreateMarketDataLoader();

            MARKETDATA_SYMBOL_INFO_Table_DAO dao = new MARKETDATA_SYMBOL_INFO_Table_DAO();

            dao.SYMBOL_ = code;

            dao.select(DataBaseConnectManager.ConnectionFactory("myDB"));

            this.setFromDAO(dao);

            EquityMarketDataLoader loader = EquityMarketDataLoader.CreateMarketDataLoader(this.provider_);

            string value = loader.load(refDate,code);

            return value;

        }

        //public override string dataLoad(DateTime refDate)
        //{

        //    //EquityMarketDataLoader emdl = EquityMarketDataLoader.CreateMarketDataLoader();

        //    string provider = Excel_marketDataSymbol.getProvider(this.symbol_);// dao.PROVIDER_;

        //    EquityMarketDataLoader loader = EquityMarketDataLoader.CreateMarketDataLoader(provider);

        //    string value = loader.load(refDate, code);

        //    return value;

        //}

        public override Excel_underlyingInfoViewModel underlyingInfoVM()
        {
            Excel_stockIndexViewModel e_sivm = new Excel_stockIndexViewModel();

            e_sivm.KrCode_ = this.Symbol_;
            e_sivm.NameTrans_ = new NameTrans(this.name_eng_);
            
            return e_sivm;
        }
    }
}
