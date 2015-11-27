using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_instrument_fixedBondViewModel : Excel_instrumentViewModel
    {
        public Excel_instrument_fixedBondViewModel(bool bookingMode = false)
            : base(bookingMode)
        {

            this.booking_type_ = "fixedBond";

            if (bookingMode)
            {
                this.bookingModelSetting();
            }

            this.Excel_interfaceViewModel_ = Excel_InterfaceLoader.Load(this.booking_type_);
            this.Excel_parameterViewModel_ = Excel_parameterLoader.Load(this.booking_type_);


            this.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.MaturityDate_
                = this.masterInformationViewModel_.Maturity_date_;

            this.masterInformationViewModel_.PropertyChanged +=
                this.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.MaturityDateObserver;
        }

        public override void calculate()
        {
            throw new NotImplementedException();
        }

        public override void buildParameterFromInstrument(DateTime refDate)
        {
            //xml load
            //this.excel_interfaceViewModel_.load

            Excel_standardParaViewModel e_spvm = this.Excel_parameterViewModel_ as Excel_standardParaViewModel; //new Excel_standardParaViewModel();

            e_spvm.ItemCode_ = this.masterInformationViewModel_.Item_code_;

            UnderlyingModelSettingManager umsm = new UnderlyingModelSettingManager();

            e_spvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Clear();

            Excel_underlyingCalcInfo_paraViewModel e_ucivm = umsm.underInfo_para(this.excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_);

            e_spvm.Excel_underlyingCalcInfo_paraViewModel_ = e_ucivm;

            this.excel_parameterViewModel_ = e_spvm;

            
        }

    }
}
