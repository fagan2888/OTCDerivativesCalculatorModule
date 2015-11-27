using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_instrument_hifiveViewModel : Excel_instrumentViewModel
    {
        public Excel_instrument_hifiveViewModel(bool bookingMode = false)
        : base(bookingMode)
        {
            this.booking_type_ = "hifive";

            if (bookingMode)
            {
                this.bookingModelSetting();
            }

            this.Excel_interfaceViewModel_ = Excel_InterfaceLoader.Load(this.booking_type_);
            this.Excel_parameterViewModel_ = Excel_parameterLoader.Load(this.booking_type_);

            //new Excel_hifiveViewModel();
            //this.Excel_parameterViewModel_ = new Excel_standardHifiveParaViewModel();
            
            //this.Excel_interfaceViewModel_.setUnderlying();

            //this.excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.PropertyChanged
            //    += this.excel_parameterViewModel_.instrumentEventObserver;

        }

        public override void buildParameterFromInstrument(DateTime refDate)
        {
            Excel_standardHifiveParaViewModel e_spvm = new Excel_standardHifiveParaViewModel();

            e_spvm.IssueDate_ = this.excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;

            e_spvm.ReferenceDate_ = refDate;

            e_spvm.ItemCode_ = this.masterInformationViewModel_.Item_code_;

            ParameterSettingManager parameterSettingManager 
                = ParameterSettingManagerBuilder.makeParaSettingManager ("default",refDate, this);
            
            e_spvm.buildParaSetting(parameterSettingManager);

            this.excel_parameterViewModel_ = e_spvm;
        }

        public override void bookingFromTradeString(TradeString tradeString)
        {
            this.excel_interfaceViewModel_.buildFromTradeString(tradeString);

            // --------------------------------------------------------------
            this.masterInformationViewModel_.Item_name_ = tradeString.Name_;
            this.masterInformationViewModel_.Trade_date_ = this.excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;
            this.masterInformationViewModel_.Maturity_date_ = this.excel_interfaceViewModel_.Excel_issueInfoViewModel_.MaturityDate_;
            this.masterInformationViewModel_.Export_itemcode_ = tradeString.ExportCode_;

            // --------------------------------------------------------------
            this.excel_interfaceViewModel_.ItemCode_ = this.masterInformationViewModel_.Item_code_;
            // -------------------------------------------------------------- 
            //this.bookingFromTradeString(tradeString);

            this.bookingInstrument(); // db에 박음.

            XMLFileLoader.SaveInstrument(this);

            //이건 생략
            //MasterInformationViewModel.WholeMasterPosition_.Add(e_instVM);
            
        }


    }
}
