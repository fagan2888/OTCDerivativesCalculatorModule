using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    //모든 상품들의 method를 정의 해논 놈. 즐겨찾기처럼 쓸거임 setting 해놓고
    public class PricingMethodSettingManager
    {

        public PricingMethodSettingManager()
        {
            this.CompositeOptionEnginType_ = Excel_instrument_compositeOptionViewModel.EngineType.AnalyticQuantLib;
        }   
        public Excel_instrument_compositeOptionViewModel.EngineType CompositeOptionEnginType_ { get; set; }
        public Excel_instrument_fxForwardViewModel.EngineType FxForwardEnginType_ { get; set; }

        //public PricingParameterSetting CompositeOptionEngine_ { get; set; }
        //public PricingParameterSetting CreditDefaultSwapEngine_ { get; set; }




        public Excel_instrument_fxSwapViewModel.EngineType FxSwapEnginType_ { get; set; }

        public Excel_instrument_multiAssetCompositeOptionViewModel.EngineType MultiAssetCompositeOptionEnginType_ { get; set; }
    }
}
