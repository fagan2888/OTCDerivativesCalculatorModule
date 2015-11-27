using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_instrument_stepDownKICustomViewModel : Excel_instrumentViewModel
    {
        public Excel_instrument_stepDownKICustomViewModel(bool bookingMode = false)
        : base(bookingMode)
        {
            if (bookingMode)
            {
                this.masterInformationViewModel_.Booking_type_ = "stepDownKICustom";

                this.masterInformationViewModel_.Item_code_
                   = CodeClassificationGenerator.CreateItemCode("stepDownKICustom");
            }

            this.Excel_interfaceViewModel_ = new Excel_stepDownKICustomViewModel();
            this.Excel_parameterViewModel_ = new Excel_stepDownKICustomParaViewModel();

            this.excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.PropertyChanged
                += this.excel_parameterViewModel_.instrumentEventObserver;

            //this.view_.DataContext = this;
        }

        public override void calculate()
        {
            throw new NotImplementedException();
        }
    }
}
