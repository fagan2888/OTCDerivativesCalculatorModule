using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class ParameterSetting
    {

        public string Method_ { get; set; }
        public long SimulationNum_ { get; set; }
        public double DiscountFlatTS_ { get; set; }

        public void buildParametorXmlData(System.Xml.XmlWriter xmlWriter, ParameterSetting ParameterSetting_)
        {
            throw new NotImplementedException();
        }

        public string SettingCode_ { get; set; }

        public static ParameterSetting createSetting(string settingStr)
        {
            ParameterSetting setting = new ParameterSetting();
            setting.Method_ = "simul";
            setting.SimulationNum_ = 10000;
            setting.DiscountFlatTS_ = 0.03;
            setting.SettingCode_ = "defaultSetting";

            return setting;
        }
    }
}
