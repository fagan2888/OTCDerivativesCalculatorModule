using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_structuredSwapViewModel : Excel_interfaceViewModel
    {
        public Excel_structuredSwapViewModel() 
        {
            this.excel_swapLegViewModel_ = new ObservableCollection<Excel_swapLegViewModel>();
        }
        
        #region Excel_counterUnderlyingCalcInfoViewModel_
        private Excel_counterUnderlyingCalcInfoViewModel excel_counterUnderlyingCalcInfoViewModel_;
        public Excel_counterUnderlyingCalcInfoViewModel Excel_counterUnderlyingCalcInfoViewModel_
        {
            get { return this.excel_counterUnderlyingCalcInfoViewModel_; }
            set
            {
                if (this.excel_counterUnderlyingCalcInfoViewModel_ != value)
                {
                    this.excel_counterUnderlyingCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_counterUnderlyingCalcInfoViewModel_");
                }
            }
        }
        #endregion
        
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
                xmlWriter.WriteElementString("excel_type" , "excel_structuredSwap");
                xmlWriter.WriteStartElement("excel_structuredSwap");

                    //excel_counterUnderlyingCalcInfoViewModel_.buildXml(xmlWriter);

                    this.excel_issueInfoViewModel_.buildXml(xmlWriter);

                    foreach (var item in excel_swapLegViewModel_)
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
            Control v = new Excel_structuredSwapView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_swapInterface serial_Excel_swapInterface = serial_Class as FpmlSerializedCSharp.Excel_swapInterface;
            FpmlSerializedCSharp.Excel_structuredSwap serial_Excel_structuredSwap = serial_Excel_swapInterface.Excel_structuredSwap_;
        
            //FpmlSerializedCSharp.Excel_counterUnderlyingCalcInfo serial_excel_counterUnderlyingCalcInfo = serial_Excel_structuredSwap.Excel_counterUnderlyingCalcInfo_;
            //string excel_counterUnderlyingCalcInfotype = serial_excel_counterUnderlyingCalcInfo.Excel_type_.ValueStr;
            //this.excel_counterUnderlyingCalcInfoViewModel_ = Excel_counterUnderlyingCalcInfoViewModel.CreateExcel_counterUnderlyingCalcInfo(excel_counterUnderlyingCalcInfotype);
            //this.excel_counterUnderlyingCalcInfoViewModel_.setFromSerial(serial_excel_counterUnderlyingCalcInfo);

            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_structuredSwap.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);

            List<FpmlSerializedCSharp.Excel_swapLeg> serial_excel_swapLeg = serial_Excel_structuredSwap.Excel_swapLeg_;
            this.excel_swapLegViewModel_ = new ObservableCollection<Excel_swapLegViewModel>();
            foreach (var item in serial_excel_swapLeg)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_swapLegViewModel viewModel = Excel_swapLegViewModel.CreateExcel_swapLeg(type);
                viewModel.setFromSerial(item);
                this.excel_swapLegViewModel_.Add(viewModel);
            }
            
        }

        public override Excel_underlyingCalcInfoViewModel getExcel_underlyingCalcInfoViewModel()
        {
            Excel_underlyingCalcInfoViewModel mergedUnderyingInfoVM = new Excel_underlyingCalcInfoViewModel();
            
            //part A
            foreach (var item in this.excel_swapLegViewModel_[0].getExcel_underlyingCalcInfoViewModel().Excel_underlyingInfoViewModel_)
	        {
                if (!mergedUnderyingInfoVM.hasUnderlying(item.KrCode_))
                {
                    mergedUnderyingInfoVM.addUnderlyingInfoVM(item);
                }
	        }

            //part B
            foreach (var item in this.excel_swapLegViewModel_[1].getExcel_underlyingCalcInfoViewModel().Excel_underlyingInfoViewModel_)
            {
                if (!mergedUnderyingInfoVM.hasUnderlying(item.KrCode_))
                {
                    mergedUnderyingInfoVM.addUnderlyingInfoVM(item);
                }
            }


            return mergedUnderyingInfoVM;
        }

        public override void buildPricingXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setUnderlying()
        {
            throw new NotImplementedException();
        }

        public override List<CurrencyViewModel> currencyList()
        {
            List<CurrencyViewModel> currencyVMList = new List<CurrencyViewModel>();

            foreach (var item in this.excel_swapLegViewModel_)
            {
                currencyVMList.Add(item.getExcel_issueInfoViewModel().Currency_);
            }

            return currencyVMList;
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel)
        {
            
        }

        public override void buildFromTradeString(TradeString tradeString)
        {
            throw new NotImplementedException();
        }
    }
    
}

