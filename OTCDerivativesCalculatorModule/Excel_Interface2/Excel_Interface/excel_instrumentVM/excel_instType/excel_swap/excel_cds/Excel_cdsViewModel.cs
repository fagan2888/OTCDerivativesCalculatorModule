using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_cdsViewModel : Excel_interfaceViewModel
    {
        public Excel_cdsViewModel() 
        {
            this.excel_issueInfoViewModel_ = new Excel_swapInfoViewModel();

            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            this.excel_swapLegViewModel_ = new Excel_fixedRateSwapLegViewModel();

            //this.excel_swapLegViewModel_.Excel_swapLegInfoViewModel_
            //    .PropertyChanged += this.currencyEventObserver;

            this.excel_creditEventSwapLegViewModel_ = new Excel_creditEventSwapLegViewModel();

            //this.excel_creditEventSwapLegViewModel_.Excel_swapLegInfoViewModel_
            //    .PropertyChanged += this.currencyEventObserver;
        }

        #region Excel_swapLegViewModel_
        private Excel_swapLegViewModel excel_swapLegViewModel_;
        public Excel_swapLegViewModel Excel_swapLegViewModel_
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
        
        #region Excel_creditEventSwapLegViewModel_
        private Excel_creditEventSwapLegViewModel excel_creditEventSwapLegViewModel_;
        public Excel_creditEventSwapLegViewModel Excel_creditEventSwapLegViewModel_
        {
            get { return this.excel_creditEventSwapLegViewModel_; }
            set
            {
                if (this.excel_creditEventSwapLegViewModel_ != value)
                {
                    this.excel_creditEventSwapLegViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_creditEventSwapLegViewModel_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapInterface");
                xmlWriter.WriteElementString("excel_type" , "excel_cds");
                xmlWriter.WriteStartElement("excel_cds");

                    this.excel_issueInfoViewModel_.buildXml(xmlWriter);
                    this.excel_swapLegViewModel_.buildXml(xmlWriter);
                    this.excel_creditEventSwapLegViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_cdsView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapInterface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_swapInterface;
            FpmlSerializedCSharp.Excel_cds serial_Excel_cds = serial_Excel_interface.Excel_cds_;
        
            FpmlSerializedCSharp.Excel_swapLeg serial_excel_swapLeg = serial_Excel_cds.Excel_swapLeg_;
            string excel_swapLegtype = serial_excel_swapLeg.Excel_type_.ValueStr;
            this.excel_swapLegViewModel_ = Excel_swapLegViewModel.CreateExcel_swapLeg(excel_swapLegtype);
            this.excel_swapLegViewModel_.setFromSerial(serial_excel_swapLeg);
            
            FpmlSerializedCSharp.Excel_creditEventSwapLeg serial_excel_creditEventSwapLeg = serial_Excel_cds.Excel_creditEventSwapLeg_;
            //string excel_creditEventSwapLegtype = serial_excel_creditEventSwapLeg.Excel_type_.ValueStr;
            this.excel_creditEventSwapLegViewModel_ = new Excel_creditEventSwapLegViewModel();
            this.excel_creditEventSwapLegViewModel_.setFromSerial(serial_excel_creditEventSwapLeg);
            
        }
        
        public override void buildPricingXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setUnderlying()
        {
            this.excel_swapLegViewModel_.setUnderlying();
            this.excel_creditEventSwapLegViewModel_.setUnderlying();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            this.excel_swapLegViewModel_.bookingEvent(masterInformationViewModel);
            this.excel_creditEventSwapLegViewModel_.bookingEvent(masterInformationViewModel);
        }

        public override List<CurrencyViewModel> currencyList()
        {
            List<CurrencyViewModel> currList = new List<CurrencyViewModel>();

            //currList.Add(this.excel_swapLegViewModel_.Excel_swapLegInfoViewModel_.Currency_);
            //currList.Add(this.excel_creditEventSwapLegViewModel_.Excel_swapLegInfoViewModel_.Currency_);

            return currList;
        }

        public override void buildFromTradeString(TradeString tradeString)
        {
            throw new NotImplementedException();
        }
    }
    
}

