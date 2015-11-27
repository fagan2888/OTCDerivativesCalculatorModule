using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class GBM_MRO_DividendSetting : GBM_DividendSetting
    {
        public override string value(DateTime dateTime, Excel_instrumentViewModel excel_instrumentViewModel, Excel_underlyingInfoViewModel excel_uivm)
        {
            TD_MRSTOCKFACTOR_Table_DAO dao = new TD_MRSTOCKFACTOR_Table_DAO();

            dao.STOCK_ID_ = excel_uivm.KrCode_;
            dao.STD_DATE_ = StringConverter.dbDateTimeToDateString(dateTime);

            dao.select_ID_Date(DataBaseConnectManager.ConnectionFactory("MRO"));

            string v = dao.DIVIDEND_RATE_;

            return v;
        }
    }
}
