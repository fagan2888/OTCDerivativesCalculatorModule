using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_instrument_fxSwapViewModel : Excel_instrumentViewModel
    {
        public enum EngineType
        {
            FX_AnalyticQuantLib // default
        };

        public Excel_instrument_fxSwapViewModel(bool bookingMode = false)
            : base(bookingMode)
        {

            this.booking_type_ = "fxSwap";

            if (bookingMode)
            {
                this.bookingModelSetting();
            }

            this.Excel_interfaceViewModel_ = Excel_InterfaceLoader.Load(this.booking_type_);
            this.Excel_parameterViewModel_ = Excel_parameterLoader.Load(this.booking_type_);

            EngineType engineType = ProgramVariable.CurrenctPricingMethodSettingManager_.FxSwapEnginType_;

            //this.view_.DataContext = this;
        }

        private Excel_parameterViewModel createParameterVM(EngineType engineType)
        {
            if (engineType == EngineType.FX_AnalyticQuantLib)
            {
                // 요놈이 주가면 gmb을 쓰고 머.. 이자면 hull을 쓰고 머 그런 정보.. 는 어디에..?
                //throw new Exception("engine not implemented");

                return new Excel_standardParaViewModel();
            }
            else
            {
                throw new Exception("unknown Engine");
            }

        }

        public override void calculate()
        {
            throw new NotImplementedException();
        }
    }
}
