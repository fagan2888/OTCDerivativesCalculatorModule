using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_instrument_generalViewModel : Excel_instrumentViewModel
    {
        public Excel_instrument_generalViewModel(bool bookingMode = false)
            : base(bookingMode)
        {
            if (bookingMode)
            {
                this.masterInformationViewModel_.Booking_type_ = "general";

                this.masterInformationViewModel_.Item_code_
                   = CodeClassificationGenerator.CreateItemCode("general");
            }

            this.Excel_interfaceViewModel_ = new Excel_generalViewModel();
            this.Excel_parameterViewModel_ = new Excel_generalParaViewModel();

            //this.view_.DataContext = this;
        }

        public override void calculate()
        {
            throw new NotImplementedException();
        }

        public override void buildParameterFromInstrument(DateTime refDate)
        {

        }
    }
}
