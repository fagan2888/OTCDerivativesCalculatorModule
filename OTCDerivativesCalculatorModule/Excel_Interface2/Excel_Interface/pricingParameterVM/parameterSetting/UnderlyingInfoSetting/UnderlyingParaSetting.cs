using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class UnderlyingParaSetting
    {
        private ParameterSettingManager owner_parameterSettingManager_;

        public UnderlyingParaSetting(ParameterSettingManager parameterSettingManager)
        {
            // TODO: Complete member initialization
            this.owner_parameterSettingManager_ = parameterSettingManager;

            this.StockParaSetting_ = new GBMSetting();
            this.InterestRateParaSetting_= new HullWhiteSetting();

            this.CorrelationParaSetting_ = new Constant_CorrelationParaSetting(parameterSettingManager);

        }

        public StockParaSetting StockParaSetting_;
        public InterestRateParaSetting InterestRateParaSetting_;
        public FxRateParaSetting FxRateParaSetting_;

        public CorrelationParaSetting CorrelationParaSetting_;

        public Excel_underlyingModel_paraViewModel underModel(Excel_underlyingInfoViewModel excel_uivm)
        {
            // if 이놈이 stock이면 
            string underType = excel_uivm.Excel_type_;

            if (underType.ToUpper() == "STOCK" || underType.ToUpper() == "EXCEL_STOCK" || underType.ToUpper() == "EQUITY")
            {
                return this.StockParaSetting_.underModel(excel_uivm, owner_parameterSettingManager_.Excel_InstrumentViewModel_, owner_parameterSettingManager_.ReferenceDate_);

            }
            else if (underType.ToUpper() == "INTERESTRATE" || underType.ToUpper() == "EXCEL_INTERESTRATE")
            {
                return this.InterestRateParaSetting_.underModel(excel_uivm, owner_parameterSettingManager_.Excel_InstrumentViewModel_, owner_parameterSettingManager_.ReferenceDate_);
            }
            else if (underType.ToUpper() == "FXRATE" )
            {
                return this.FxRateParaSetting_.underModel(excel_uivm, owner_parameterSettingManager_.Excel_InstrumentViewModel_, owner_parameterSettingManager_.ReferenceDate_);
            }
            else if (underType.ToUpper() == "INDEX" || 
                     underType.ToUpper() == "INDEX_TYPE" || 
                     underType.ToUpper() == "EXCEL_INDEXTYPE")
            {
                Excel_indexTypeViewModel excel_itvm = excel_uivm as Excel_indexTypeViewModel;

                string subType = excel_itvm.Sub_type_.ToUpper();

                if (subType == "STOCK")
                {
                    return this.StockParaSetting_.underModel(excel_uivm, owner_parameterSettingManager_.Excel_InstrumentViewModel_, owner_parameterSettingManager_.ReferenceDate_);
                }
                else if (subType == "INTERESTRATE")
                { 
                    return this.InterestRateParaSetting_.underModel(excel_uivm, owner_parameterSettingManager_.Excel_InstrumentViewModel_, owner_parameterSettingManager_.ReferenceDate_);
                }
                else if (subType == "FXRATE")
                {
                    return this.FxRateParaSetting_.underModel(excel_uivm, owner_parameterSettingManager_.Excel_InstrumentViewModel_, owner_parameterSettingManager_.ReferenceDate_);
                }
                else
                {
                    OutputLogViewModel.addResult("unknown subtype in indexType underlying " + subType);
                    
                    throw new NotImplementedException();
                }
            }
            else
            {
                OutputLogViewModel.addResult("unknown underlying type" + underType);

                throw new NotImplementedException();

                //return new Excel_forwardModelViewModel();
            }


        }
    }
}
