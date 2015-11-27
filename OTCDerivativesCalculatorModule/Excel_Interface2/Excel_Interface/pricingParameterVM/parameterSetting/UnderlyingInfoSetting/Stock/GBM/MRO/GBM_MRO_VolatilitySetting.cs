using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class GBM_MRO_VolatilitySetting : GBM_VolatilitySetting
    {
        public override string value(DateTime dateTime, Excel_instrumentViewModel e_instVM, Excel_underlyingInfoViewModel excel_uivm)
        {
            OTC_TD_MRSTOCKFACTORVOL_Table_DAO dao = new OTC_TD_MRSTOCKFACTORVOL_Table_DAO();

            dao.STD_DATE_ = StringConverter.dbDateTimeToDateString(dateTime);
            dao.STOCK_ID_ = excel_uivm.KrCode_;
            dao.KR_CODE_ = e_instVM.MasterInformationViewModel_.Export_itemcode_;

            string sql = dao.select_date_code_id(DataBaseConnectManager.ConnectionFactory("MRO"));

            if (dao.STOCK_ID_ == "KR7060980000")
            {
                dao.VOL_ = "0.33";
            }

            //SQL_Logger.addLog(sql);

            return dao.VOL_;
        }
    }
}
