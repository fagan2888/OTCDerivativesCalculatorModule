using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_underlyingCalcInfo_paraViewModel : IXmlData
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    
        public Excel_underlyingCalcInfo_paraViewModel() 
        {
            this.excel_underlyingInfo_paraViewModel_ = new ObservableCollection<Excel_underlyingInfo_paraViewModel>();
            this.excel_correlationInfo_paraViewModel_ = new Excel_correlationInfo_paraViewModel();

            //this.view_ = new Excel_underlyingCalcInfo_paraView();
            //this.view_.DataContext = this;

        }
        
        #region Excel_underlyingInfo_paraViewModel_
        private ObservableCollection<Excel_underlyingInfo_paraViewModel> excel_underlyingInfo_paraViewModel_;
        public ObservableCollection<Excel_underlyingInfo_paraViewModel> Excel_underlyingInfo_paraViewModel_
        {
            get { return this.excel_underlyingInfo_paraViewModel_; }
            set
            {
                if (this.excel_underlyingInfo_paraViewModel_ != value)
                {
                    this.excel_underlyingInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingInfo_paraViewModel_");
                }
            }
        }
        #endregion

        #region Excel_correlationInfo_paraViewModel_
        private Excel_correlationInfo_paraViewModel excel_correlationInfo_paraViewModel_;
        public Excel_correlationInfo_paraViewModel Excel_correlationInfo_paraViewModel_
        {
            get { return this.excel_correlationInfo_paraViewModel_; }
            set
            {
                if (this.excel_correlationInfo_paraViewModel_ != value)
                {
                    this.excel_correlationInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_correlationInfo_paraViewModel_");
                }
            }
        }
        #endregion

        //#region CorrelationInfo_paraViewModel_
        //private CorrelationInfo_paraViewModel correlationInfo_paraViewModel_;
        //public CorrelationInfo_paraViewModel CorrelationInfo_paraViewModel_
        //{
        //    get { return this.correlationInfo_paraViewModel_; }
        //    set
        //    {
        //        if (this.correlationInfo_paraViewModel_ != value)
        //        {
        //            this.correlationInfo_paraViewModel_ = value;
        //            this.NotifyPropertyChanged("CorrelationInfo_paraViewModel_");
        //        }
        //    }
        //}
        //#endregion
        
        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingCalcInfo_para");

            foreach (var item in excel_underlyingInfo_paraViewModel_)
            {
                item.buildXml(xmlWriter);
            }

            excel_correlationInfo_paraViewModel_.buildXml(xmlWriter);

            xmlWriter.WriteEndElement();
        }

        public void buildPricingXml(XmlWriter xmlWriter)
        {
            //xmlWriter.WriteStartElement("underlyingInfo_para");

            //foreach (var item in excel_underlyingInfo_paraViewModel_)
            //{
            //    item.buildPricingXml(xmlWriter);
            //}

            //correlationInfo_paraViewModel_.buildPricingXml(xmlWriter);

            //xmlWriter.WriteEndElement();
        }

        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingCalcInfo_para serial_Excel_underlyingCalcInfo_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingCalcInfo_para;

            List<FpmlSerializedCSharp.Excel_underlyingInfo_para> serial_excel_underlyingInfo_para = serial_Excel_underlyingCalcInfo_para.Excel_underlyingInfo_para_;
            this.excel_underlyingInfo_paraViewModel_ = new ObservableCollection<Excel_underlyingInfo_paraViewModel>();
            foreach (var item in serial_excel_underlyingInfo_para)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_underlyingInfo_paraViewModel viewModel = new Excel_underlyingInfo_paraViewModel();
                viewModel.setFromSerial(item);
                this.excel_underlyingInfo_paraViewModel_.Add(viewModel);
            }

            FpmlSerializedCSharp.Excel_correlationInfo_para serial_excel_correlationInfo_para = serial_Excel_underlyingCalcInfo_para.Excel_correlationInfo_para_;
            //string excel_correlationInfo_paratype = serial_excel_correlationInfo_para.Excel_type_.ValueStr;
            this.excel_correlationInfo_paraViewModel_ = new Excel_correlationInfo_paraViewModel();//.CreateExcel_correlationInfo_para(excel_correlationInfo_paratype);
            this.excel_correlationInfo_paraViewModel_.setFromSerial(serial_excel_correlationInfo_para);
        }

        public Control view()
        {
            Control v = new Excel_underlyingCalcInfo_paraView();

            v.DataContext = this;

            return v;
        }

        public void loadMarketData(DateTime referenceDate)
        {
            foreach (var item in this.excel_underlyingInfo_paraViewModel_)
            {
                item.loadMarketData(referenceDate);
            }

            this.excel_correlationInfo_paraViewModel_.loadMarketData(referenceDate);
            
            
        }

        public void buildParaSetting(ParameterSettingManager paraSettingManager)
        {
            this.excel_underlyingInfo_paraViewModel_.Clear();

            Excel_underlyingCalcInfoViewModel e_ucvm = paraSettingManager.Excel_InstrumentViewModel_.Excel_interfaceViewModel_.getExcel_underlyingCalcInfoViewModel();

            foreach (var item in e_ucvm.Excel_underlyingInfoViewModel_)
            {
                Excel_underlyingInfo_paraViewModel e_uparavm = new Excel_underlyingInfo_paraViewModel();

                e_uparavm.buildParaSetting(item,paraSettingManager);

                this.excel_underlyingInfo_paraViewModel_.Add(e_uparavm);

            }

            this.excel_correlationInfo_paraViewModel_.buildParaSetting(paraSettingManager);
        }

        public void historyUnderData(XmlWriter xmlWriter, DateTime issueDate, DateTime referenceDate)
        {
            //MarketDataLoaderFactory.CreateMarketLoader(

            foreach (var item in this.Excel_underlyingInfo_paraViewModel_)
            {
                IndexHistoryMarketData ihmd = new IndexHistoryMarketData(item.KrCode_);

                QLNet.TimeSeries<string> series = new QLNet.TimeSeries<string>();

                if (item.Excel_type_.ToUpper() == "INTERESTRATE")
                {
                    series = ihmd.historyCurveSeriesMRO(issueDate, referenceDate);
                }
                else 
                {
                    series = ihmd.historySeriesMRO(issueDate, referenceDate);
                }

                xmlWriter.WriteStartElement("marketData");

                    xmlWriter.WriteElementString("krcode", item.KrCode_);

                    xmlWriter.WriteElementString("name", item.UnderNameTrans_.Value_);

                    xmlWriter.WriteStartElement("dataValueInfo");

                    foreach (var itemData in series)
                    {
                        xmlWriter.WriteStartElement("dataValue");
                        DateTime d = itemData.Key;
                        xmlWriter.WriteElementString("date", d.ToString("yyyy-MM-dd"));
                        xmlWriter.WriteElementString("value", itemData.Value);
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();

            }
        }

        public bool hasUnderlying(string underCode)
        {
            foreach (var item in this.excel_underlyingInfo_paraViewModel_)
            {
                if (item.KrCode_.ToUpper() == underCode.ToUpper())
                {
                    return true;


                }
            }

            return false;
        }

    }
    
}

