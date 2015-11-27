using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_instrument_vanillaFloatingBondViewModel : Excel_instrumentViewModel
    {
        public Excel_instrument_vanillaFloatingBondViewModel(bool bookingMode = false)
            : base(bookingMode)
        {

            this.booking_type_ = "vanillaFloatingBond";

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

            //this.maturityYear_ = 3.0;
            //this.maturityDate_ = this.effectiveDate_.AddYears(3);

            //this.view_.DataContext = this;
        }

        public override void calculate()
        {
            throw new NotImplementedException();
        }
    }
}
