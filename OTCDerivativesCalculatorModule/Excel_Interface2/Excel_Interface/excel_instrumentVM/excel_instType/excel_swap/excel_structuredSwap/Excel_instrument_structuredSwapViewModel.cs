using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_instrument_structuredSwapViewModel :Excel_instrumentViewModel
    {
        public Excel_instrument_structuredSwapViewModel(bool bookingMode = false)
        : base(bookingMode)
        {
            this.booking_type_ = "structuredSwap";

            if (bookingMode)
            {
                this.masterInformationViewModel_.Booking_type_ = this.booking_type_;

                this.masterInformationViewModel_.Item_code_
                   = CodeClassificationGenerator.CreateItemCode(this.booking_type_);
            }

            // 메뉴 Booking
            // private void menuBookingItem_Click(object sender, RoutedEventArgs e)

            this.Excel_interfaceViewModel_ = Excel_InterfaceLoader.Load(this.booking_type_);
            this.Excel_parameterViewModel_ = Excel_parameterLoader.Load(this.booking_type_);

            //this.Excel_interfaceViewModel_.setUnderlying();

            //this.excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.PropertyChanged
            //    += this.excel_parameterViewModel_.instrumentEventObserver;

        }

    }
}
