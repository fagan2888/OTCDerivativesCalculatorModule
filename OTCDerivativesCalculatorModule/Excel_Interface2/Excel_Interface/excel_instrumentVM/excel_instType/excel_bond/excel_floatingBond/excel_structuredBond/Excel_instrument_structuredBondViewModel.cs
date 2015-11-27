using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_instrument_structuredBondViewModel : Excel_instrumentViewModel
    {
        public Excel_instrument_structuredBondViewModel(bool bookingMode = false)
            : base(bookingMode)
        {
            this.booking_type_ = "structuredBond";

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

    }
}
