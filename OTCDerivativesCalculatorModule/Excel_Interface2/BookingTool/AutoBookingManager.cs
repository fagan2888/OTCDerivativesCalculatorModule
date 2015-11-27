using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class AutoBookingManager
    {
        #region Excel_instrumentList_
        private List<Excel_instrumentViewModel> excel_instrumentList_;
        public List<Excel_instrumentViewModel> Excel_instrumentList_
        {
            get { return this.excel_instrumentList_; }
            set
            {
                if (this.excel_instrumentList_ != value)
                {
                    this.excel_instrumentList_ = value;
                    //this.NotifyPropertyChanged("Excel_instrumentList_");
                }
            }
        }
        #endregion

        public AutoBookingManager() 
        {
            this.excel_instrumentList_ = new List<Excel_instrumentViewModel>();
        }

        public void addInstrument(TradeString tradeString)
        {
            Excel_instrument_hifiveViewModel e_inst_hifive_VM = new Excel_instrument_hifiveViewModel(true);

            e_inst_hifive_VM.bookingFromTradeString(tradeString);

        }

        //public void excuteBooking()
        //{
        //    foreach (var item in this.excel_instrumentList_)
        //    {
        //        //item.bookingFromTradeString(tradeString);    
        //    }
        //}

        public void testStringAdd()
        {
            string k = "Type=2 Stock Step Down Double Callable;Underlyings=우리투자증권,하나금융지주;Tenor=3y;Observation period=6m;Trigger level=92.5/92.5/87.5/87.5/82.5/82.5;Knock In barrier=57.499;Coupon(p.a)=11.3;EffectiveDate=2013-07-08;";

            StepDownKI_TradeString s_ts = new StepDownKI_TradeString();

            s_ts.parsingString(k);

            this.addInstrument(s_ts);
        }



    }
}
