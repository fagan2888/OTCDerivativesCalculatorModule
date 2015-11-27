using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace Excel_Interface
{
    public class Excel_instrument_multiAssetCompositeOptionViewModel : Excel_instrumentViewModel
    {
        public enum EngineType
        {
            Monte // default
        };

        public Excel_instrument_multiAssetCompositeOptionViewModel(bool bookingMode = false)
            : base(bookingMode)
        {
            this.booking_type_ = "multiAssetCompositeOption";

            if (bookingMode)
            {
                this.bookingModelSetting();
            }

            this.Excel_interfaceViewModel_ = Excel_InterfaceLoader.Load(this.booking_type_);
            this.Excel_parameterViewModel_ = Excel_parameterLoader.Load(this.booking_type_);

            // 이걸 그냥 내부에서 딸 수도 있음..

            EngineType engineType = ProgramVariable.CurrenctPricingMethodSettingManager_.MultiAssetCompositeOptionEnginType_;

            //this.Excel_parameterViewModel_ = this.createParameterVM(engineType);

        }

        private Excel_parameterViewModel createParameterVM(EngineType engineType)
        {
            if (engineType == EngineType.Monte)
            {
                //수정해야함. standard로 그냥 가면 댈거 같은데 mc니까
                return new Excel_singleAssetCompositeOptionStandParaWithEngineViewModel();
            }
            else
            {
                throw new Exception("unknown Engine");
            }

        }





    }
}
