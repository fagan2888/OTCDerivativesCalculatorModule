using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_irsViewModel : Excel_interfaceViewModel
    {
        public Excel_irsViewModel() 
        {
            this.excel_issueInfoViewModel_ = new Excel_swapInfoViewModel();
            this.excel_swapLegViewModel_ = new ObservableCollection<Excel_swapLegViewModel>();

            //default
            this.excel_swapLegViewModel_.Add(new Excel_fixedRateSwapLegViewModel());
            this.excel_swapLegViewModel_.Add(new Excel_vanillaFloatingRateSwapLegViewModel());

            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();
            //this.excel_counterUnderlyingCalcInfoViewModel_ = new Excel_counterUnderlyingCalcInfoViewModel();
            //사용안함
            //this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

        }

        public override void masterEventObserver(object sender, PropertyChangedEventArgs e)
        {
            base.masterEventObserver(sender, e);

            // 밑에 딸린거 처리
            //this.excel_swapLegViewModel_[0].Excel_swapLegInfoViewModel_.MaturityDateObserver(sender, e);
            //this.excel_swapLegViewModel_[1].Excel_swapLegInfoViewModel_.MaturityDateObserver(sender, e);
        }
        
        #region Excel_swapLegViewModel_
        private ObservableCollection<Excel_swapLegViewModel> excel_swapLegViewModel_;
        public ObservableCollection<Excel_swapLegViewModel> Excel_swapLegViewModel_
        {
            get { return this.excel_swapLegViewModel_; }
            set
            {
                if (this.excel_swapLegViewModel_ != value)
                {
                    this.excel_swapLegViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_swapLegViewModel_");
                }
            }
        }
        #endregion

        //#region Excel_counterUnderlyingCalcInfoViewModel_
        //private Excel_counterUnderlyingCalcInfoViewModel excel_counterUnderlyingCalcInfoViewModel_;
        //public Excel_counterUnderlyingCalcInfoViewModel Excel_counterUnderlyingCalcInfoViewModel_
        //{
        //    get { return this.excel_counterUnderlyingCalcInfoViewModel_; }
        //    set
        //    {
        //        if (this.excel_counterUnderlyingCalcInfoViewModel_ != value)
        //        {
        //            this.excel_counterUnderlyingCalcInfoViewModel_ = value;
        //            this.NotifyPropertyChanged("Excel_counterUnderlyingCalcInfoViewModel_");
        //        }
        //    }
        //}
        //#endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapInterface");
                xmlWriter.WriteElementString("excel_type" , "excel_irs");
                xmlWriter.WriteStartElement("excel_irs");

                    //사용안함 
                    //this.excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);
                    //this.excel_counterUnderlyingCalcInfoViewModel_.buildXml(xmlWriter);

                    excel_swapLegViewModel_[0].buildXml(xmlWriter); // me
                    excel_swapLegViewModel_[1].buildXml(xmlWriter); // counter
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapInterface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_swapInterface;
            FpmlSerializedCSharp.Excel_irs serial_Excel_irs = serial_Excel_interface.Excel_irs_;
        
            List<FpmlSerializedCSharp.Excel_swapLeg> serial_excel_swapLeg = serial_Excel_irs.Excel_swapLeg_;
            this.excel_swapLegViewModel_ = new ObservableCollection<Excel_swapLegViewModel>();
            foreach (var item in serial_excel_swapLeg)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_swapLegViewModel viewModel = Excel_swapLegViewModel.CreateExcel_swapLeg(type);
                viewModel.setFromSerial(item);
                this.excel_swapLegViewModel_.Add(viewModel);
            }
            
        }

        public override void buildPricingXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setUnderlying()
        {
            foreach (var item in this.excel_swapLegViewModel_)
	        {
                item.setUnderlying();
	        }
            
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            throw new NotImplementedException();
        }

        public override Control view()
        {
            Control v = new Excel_irsView();
            v.DataContext = this;
            return v;
        }

        public override List<CurrencyViewModel> currencyList()
        {
            List<CurrencyViewModel> currList = new List<CurrencyViewModel>();

            //foreach (var item in this.excel_swapLegViewModel_)
            //{
            //    currList.Add(item.Excel_swapLegInfoViewModel_.Currency_);
            //}

            return currList;
        }

        public override Excel_underlyingCalcInfoViewModel getExcel_underlyingCalcInfoViewModel()
        {
            Excel_underlyingCalcInfoViewModel e_ucvm = new Excel_underlyingCalcInfoViewModel();


            foreach (var item in this.excel_swapLegViewModel_[0].getExcel_underlyingCalcInfoViewModel().Excel_underlyingInfoViewModel_)
            {
                e_ucvm.Excel_underlyingInfoViewModel_.Add(item);
            }

            foreach (var item in this.excel_swapLegViewModel_[1].getExcel_underlyingCalcInfoViewModel().Excel_underlyingInfoViewModel_)
            {
                e_ucvm.Excel_underlyingInfoViewModel_.Add(item);
            }

            //e_ucvm.Excel_underlyingInfoViewModel_.Add(

            return e_ucvm;
            //e_ucvm.Excel_underlyingInfoViewModel_.Add(

        }


        public override void buildFromTradeString(TradeString tradeString)
        {
            throw new NotImplementedException();
        }
    }
    
}

