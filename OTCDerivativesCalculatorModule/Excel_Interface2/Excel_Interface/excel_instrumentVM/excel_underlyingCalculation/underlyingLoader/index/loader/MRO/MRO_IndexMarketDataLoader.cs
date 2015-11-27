using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class MRO_IndexMarketDataLoader : IndexMarketDataLoader 
    {
        public MRO_IndexMarketDataLoader(string dbName)
        : base(DataBaseConnectManager.ConnectionFactory(dbName))
        {
            
        }

        public override void load(DateTime refDate, string curveCode, System.Collections.ObjectModel.ObservableCollection<Excel_indexDataViewModel> e_idvmList)
        {
            throw new NotImplementedException();
        }

        public override string load(DateTime refDate, string symbol)
        {
            TD_MRSTOCKFACTOR_Table_DAO dao = new TD_MRSTOCKFACTOR_Table_DAO();

            dao.STD_DATE_ = StringConverter.dbDateTimeToDateString(refDate);
            dao.STOCK_ID_ = symbol;

            dao.select_ID_Date(this.conn_);

            return dao.CURR_PRICE_;
        }
    }
}
