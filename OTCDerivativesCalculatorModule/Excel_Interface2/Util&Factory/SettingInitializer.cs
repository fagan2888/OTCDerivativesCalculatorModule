using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class SettingInitializer
    {
        public SettingInitializer()
        { 
        
        }

        public void initialze(int type)
        {

            //DataBaseConnectManager.DBConnection_ 
            //    //= DataBaseConnectManager.ConnectionFactory("MyDb_MsCe",EnvironmentVariable.MarketDataDBFile_);
            //    = DataBaseConnectManager.ConnectionFactory("MyDb_MsCe");
            OutputLogViewModel.OutputList_ = new System.Collections.ObjectModel.ObservableCollection<IOutput>();

            //ProgramVariable.CurrenctParameterSettingManager_ = new ParameterSettingManager();
            ProgramVariable.CurrenctPricingMethodSettingManager_ = new PricingMethodSettingManager();
            ProgramVariable.UnderlyingModelSetting_ = new UnderlyingModelSetting();


        }


    }
}

