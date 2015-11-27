﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_instrument_crsViewModel : Excel_instrumentViewModel
    {
        public Excel_instrument_crsViewModel(bool bookingMode = false)
            : base(bookingMode)
        {

            this.booking_type_ = "crs";

            if (bookingMode)
            {
                this.bookingModelSetting();
            }

            this.Excel_interfaceViewModel_ = Excel_InterfaceLoader.Load(this.booking_type_);
            this.Excel_parameterViewModel_ = Excel_parameterLoader.Load(this.booking_type_);

            //this.view_.DataContext = this;
        }

        public override void calculate()
        {
            throw new NotImplementedException();
        }
    }
}