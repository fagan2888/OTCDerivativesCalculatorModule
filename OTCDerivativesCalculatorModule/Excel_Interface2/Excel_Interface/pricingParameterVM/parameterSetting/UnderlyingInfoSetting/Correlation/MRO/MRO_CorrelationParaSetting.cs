using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class MRO_CorrelationParaSetting : CorrelationParaSetting
    {
        public MRO_CorrelationParaSetting(ParameterSettingManager parameterSettingManager)
        : base(parameterSettingManager)
        {
        }

        public override string value(DateTime refDate, string code, string other_code)
        {
            OTC_TD_MRELSSTOCKCORR_Table_DAO dao = new OTC_TD_MRELSSTOCKCORR_Table_DAO();

            dao.STD_DATE_ = StringConverter.dbDateTimeToDateString(refDate);
            dao.STOCK_ID_ = code;
            dao.OTHER_ID_ = other_code;
            
            dao.select_date_id_otherid_Query(DataBaseConnectManager.ConnectionFactory("MRO"));

            if (dao.CORR_ == null)
            {
                dao.CORR_ = "0.5";
            }

            return dao.CORR_;
        }
    }
}
