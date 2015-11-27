using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class UnderlyingModelSettingManager
    {


        public UnderlyingModelSettingManager()
        { 
            
        }

        public Excel_underlyingModel_paraViewModel.ModelType StockType_;
        public Excel_underlyingModel_paraViewModel.ModelType IRType_;
        public Excel_underlyingModel_paraViewModel.ModelType Type_;

        public Excel_underlyingCalcInfo_paraViewModel underInfo_para(Excel_underlyingCalcInfoViewModel underInfo)
        {
            Excel_underlyingCalcInfo_paraViewModel e_uc_pvm = new Excel_underlyingCalcInfo_paraViewModel();

            Excel_underlyingInfo_paraViewModel e_u_pvm = new Excel_underlyingInfo_paraViewModel();
            e_u_pvm.Excel_underlyingModel_paraViewModel_ = new Excel_geometricBMViewModel();

            e_u_pvm.CurrentValue_ = "100";

            Excel_geometricBMViewModel e_gbmvm = new Excel_geometricBMViewModel();

            e_gbmvm.Dividend_ = "0.012";
            e_gbmvm.Drift_ = "0.03";
            e_gbmvm.Volatility_ = "0.03";

            e_u_pvm.Excel_underlyingModel_paraViewModel_ = e_gbmvm;

            e_uc_pvm.Excel_underlyingInfo_paraViewModel_.Add(e_u_pvm);

            return e_uc_pvm;
        
        }


    }
}
