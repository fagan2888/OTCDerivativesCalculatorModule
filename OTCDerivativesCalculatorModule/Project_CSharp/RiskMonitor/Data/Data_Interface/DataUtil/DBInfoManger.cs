using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class DBSettingInfoManger
    {
        public static DBSetting dbSetting(string p)
        {
            DBSetting setting = new DBSetting();

            //setting.ConnectionString_ = "DSN=RMS_OP;UID=RM_VIEW;PWD=ahslxj1!;";
            setting.ConnectionString_ = "Data Source=RMS_OP;Persist Security Info=True;User ID=RM_VIEW;Password=ahslxj1!;";

            return setting;
        }
    }
}
