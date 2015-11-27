using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_crsViewModel : Excel_interfaceViewModel
    {
        public Excel_crsViewModel() 
        {
            // 여기에는 exchange 정보 머 이런거를 넣어야겠음. 우선은 null 넣어놈
            this.excel_issueInfoViewModel_ = new Excel_emptyInfoViewModel();

            this.excel_underlyingCalcInfoViewModel_ = new Excel_underlyingCalcInfoViewModel();

            this.excel_swapLegViewModel_ = new ObservableCollection<Excel_swapLegViewModel>();
            
            this.excel_swapLegViewModel_.Add(new Excel_fixedRateSwapLegViewModel());
            this.excel_swapLegViewModel_.Add(new Excel_vanillaFloatingRateSwapLegViewModel());
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
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_swapInterface");
                xmlWriter.WriteElementString("excel_type" , "excel_crs");
                xmlWriter.WriteStartElement("excel_crs");

                foreach (var item in this.excel_swapLegViewModel_)
                {
                    item.buildXml(xmlWriter);
                }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_crsView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapInterface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_swapInterface;
            FpmlSerializedCSharp.Excel_crs serial_Excel_crs = serial_Excel_interface.Excel_crs_;
        
            List<FpmlSerializedCSharp.Excel_swapLeg> serial_excel_swapLeg = serial_Excel_crs.Excel_swapLeg_;
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
            throw new NotImplementedException();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            foreach (var item in this.excel_swapLegViewModel_)
            {
                item.bookingEvent(masterInformationViewModel);
            }
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

        public override void buildFromTradeString(TradeString tradeString)
        {
            throw new NotImplementedException();
        }
    }
    
}

