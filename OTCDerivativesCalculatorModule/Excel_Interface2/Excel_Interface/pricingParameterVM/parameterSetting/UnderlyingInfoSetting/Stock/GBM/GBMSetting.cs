using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel_Interface;

namespace Excel_Interface
{
    public class GBMSetting : StockParaSetting
    {
        public GBMSetting()
        {
            this.GBMDriftSetting_ = new GBM_Const_DriftSetting();
            this.GBMDividendSetting_ = new GBM_Const_DividendSetting();
            this.GBMVolatilitySetting_ = new GBM_Const_VolatilitySetting();
        }

        public GBM_DriftSetting GBMDriftSetting_;
        public GBM_DividendSetting GBMDividendSetting_;
        public GBM_VolatilitySetting GBMVolatilitySetting_;

        public override Excel_underlyingModel_paraViewModel underModel(Excel_underlyingInfoViewModel excel_uivm,
                                                                       Excel_instrumentViewModel excel_instrumentViewModel, 
                                                                       DateTime dateTime)
        {
            Excel_geometricBMViewModel e_gbmvm = new Excel_geometricBMViewModel();

            //excel_upvm.loadMarketData(dateTime);

            string value = Excel_loaderViewModel.loadMarketData(dateTime, excel_uivm.Excel_type_, excel_uivm.KrCode_);

            e_gbmvm.CurrentValue_ = value;

            e_gbmvm.Drift_ = this.GBMDriftSetting_.value(dateTime, excel_instrumentViewModel, excel_uivm);
            e_gbmvm.Dividend_ = this.GBMDividendSetting_.value(dateTime, excel_instrumentViewModel, excel_uivm);
            e_gbmvm.Volatility_ = this.GBMVolatilitySetting_.value(dateTime, excel_instrumentViewModel, excel_uivm);

            return e_gbmvm;

        }
    }
}
