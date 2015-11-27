using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace Excel_Interface
{
    public class Excel_instrument_compositeOptionViewModel : Excel_instrumentViewModel
    {
        public enum EngineType
        { 
            AnalyticQuantLib // default
        };

        public Excel_instrument_compositeOptionViewModel(bool bookingMode = false)
            : base(bookingMode)
        {
            this.booking_type_ = "compositeOption";

            if (bookingMode)
            {
                this.bookingModelSetting();
            }

            this.Excel_interfaceViewModel_ = Excel_InterfaceLoader.Load(this.booking_type_);
            this.Excel_parameterViewModel_ = Excel_parameterLoader.Load(this.booking_type_);

            // 이걸 그냥 내부에서 딸 수도 있음..

            //EngineType engineType = ProgramVariable.CurrenctPricingMethodSettingManager_.CompositeOptionEnginType_;

            //this.Excel_parameterViewModel_ = this.createParameterVM(engineType);

            

        }

        private Excel_parameterViewModel createParameterVM(EngineType engineType)
        {
            if (engineType == EngineType.AnalyticQuantLib)
            {
                // 요놈이 주가면 gmb을 쓰고 머.. 이자면 hull을 쓰고 머 그런 정보.. 는 어디에..?
                return new Excel_singleAssetCompositeOptionStandParaWithEngineViewModel();
            }
            else
            {
                throw new Exception("unknown Engine");
            }

        }

        public override void buildParameterFromInstrument(DateTime refDate)
        {
            // createParameterVM 으로 setting에서 받아 ㄱㄱ해야함.

            Excel_singleAssetCompositeOptionStandParaWithEngineViewModel e_para = new Excel_singleAssetCompositeOptionStandParaWithEngineViewModel();

            e_para.IssueDate_ = this.excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;

            e_para.ReferenceDate_ = refDate;

            e_para.ItemCode_ = this.masterInformationViewModel_.Item_code_;

            ParameterSettingManager parameterSettingManager 
                = ParameterSettingManagerBuilder.makeParaSettingManager ("default",refDate, this);

            e_para.buildParaSetting(parameterSettingManager);

            this.excel_parameterViewModel_ = e_para;
        }



    }
}
