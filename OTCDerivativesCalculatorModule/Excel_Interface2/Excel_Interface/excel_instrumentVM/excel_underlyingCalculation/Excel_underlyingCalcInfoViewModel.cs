using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_underlyingCalcInfoViewModel : IXmlData , INotifyPropertyChanged
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

        #region EffectiveDate_
        private DateTime effectiveDate_;
        public DateTime EffectiveDate_
        {
            get { return this.effectiveDate_; }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                    this.NotifyPropertyChanged("EffectiveDate_");
                }
            }
        }
        #endregion

        public Excel_underlyingCalcInfoViewModel() 
        {
            this.excel_underlyingInfoViewModel_ = new ObservableCollection<Excel_underlyingInfoViewModel>();

            //this.view_ = new Excel_underlyingCalcInfoView();
            //this.view_.DataContext = this;

        }
        
        // 단지 underlying 이 이떤게 사용되는지에 대한 정보
        #region Excel_underlyingInfoViewModel_
        private ObservableCollection<Excel_underlyingInfoViewModel> excel_underlyingInfoViewModel_;
        public ObservableCollection<Excel_underlyingInfoViewModel> Excel_underlyingInfoViewModel_
        {
            get { return this.excel_underlyingInfoViewModel_; }
            set
            {
                if (this.excel_underlyingInfoViewModel_ != value)
                {
                    this.excel_underlyingInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingInfoViewModel_");
                }
            }
        }
        #endregion

        public virtual void issueInfoObserver(object sender, PropertyChangedEventArgs e)
        {
            Excel_issueInfoViewModel e_iivm = sender as Excel_issueInfoViewModel;

            if (e.PropertyName == "EffectiveDate_")
            {
                this.EffectiveDate_ = e_iivm.EffectiveDate_;
            }
        }

        public void addUnderlyingInfoVM(Excel_underlyingInfoViewModel vm)
        {
            excel_underlyingInfoViewModel_.Add(vm);

            this.NotifyPropertyChanged("Excel_underlyingInfoViewModel_");
        }

        public bool hasUnderlying(string code)
        {
            foreach (var item in this.excel_underlyingInfoViewModel_)
	        {
                if (code == item.KrCode_)
                {
                    return true;
                }
	        }

            return false;
        }

        //#region Excel_underlyingCalcIDViewModel_
        //private ObservableCollection<Excel_underlyingCalcIDViewModel> excel_underlyingCalcIDViewModel_;
        //public ObservableCollection<Excel_underlyingCalcIDViewModel> Excel_underlyingCalcIDViewModel_
        //{
        //    get { return this.excel_underlyingCalcIDViewModel_; }
        //    set
        //    {
        //        if (this.excel_underlyingCalcIDViewModel_ != value)
        //        {
        //            this.excel_underlyingCalcIDViewModel_ = value;
        //            this.NotifyPropertyChanged("Excel_underlyingCalcIDViewModel_");
        //        }
        //    }
        //}
        //#endregion

        //#region UnderlyingInfoViewModel_
        //private UnderlyingInfoViewModel underlyingInfoViewModel_;
        //public UnderlyingInfoViewModel UnderlyingInfoViewModel_
        //{
        //    get { return this.underlyingInfoViewModel_; }
        //    set
        //    {
        //        if (this.underlyingInfoViewModel_ != value)
        //        {
        //            this.underlyingInfoViewModel_ = value;
        //            this.NotifyPropertyChanged("UnderlyingInfoViewModel_");
        //        }
        //    }
        //}
        //#endregion

        public string underlyingString()
        {
            string underStr = "";

            foreach (var item in this.excel_underlyingInfoViewModel_)
            {
                underStr = underStr + item.NameTrans_.trans()+ " ";
            }

            return underStr.Trim();
        }

        public void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingCalcInfo");

            foreach (var item in excel_underlyingInfoViewModel_)
            {
                item.buildXml(xmlWriter);
            }

            xmlWriter.WriteEndElement();
        }

        //public void buildPricingXml(XmlWriter xmlWriter)
        //{
        //    this.vmBuildFromInterface();
        //    this.underlyingInfoViewModel_.buildXml(xmlWriter);
        //}

        //private void vmBuildFromInterface()
        //{
        //    IndexUnderInfoViewModel iuivm = new IndexUnderInfoViewModel();

        //    foreach (var item in this.excel_underlyingInfoViewModel_)
        //    {

        //        if (item.Excel_type_.ToUpper() == "STOCK")
        //        {
        //            StockIndexUnderViewModel siuvm = new StockIndexUnderViewModel();

        //            siuvm.BasePrice_ = item.BasePrice_;
        //            siuvm.KRCode_ = item.KrCode_;
        //            //siuvm.Name_ = item.Name_;

        //            iuivm.IndexUnderList_.Add(siuvm);
        //        }
        //        else if (item.Excel_type_.ToUpper() == "INTERESTRATE")
        //        {

        //        }
        //        else 
        //        {
        //            StockIndexUnderViewModel siuvm = new StockIndexUnderViewModel();

        //            siuvm.BasePrice_ = "testBasePrice";
        //            siuvm.KRCode_ = "testKR1";
        //            siuvm.Name_ = "nameTest1";

        //            iuivm.IndexUnderList_.Add(siuvm);
        //        }
        //    }

        //    this.underlyingInfoViewModel_ = iuivm;
            
        //}

        public void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_Excel_underlyingCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_underlyingCalcInfo;

            List<FpmlSerializedCSharp.Excel_underlyingInfo> serial_excel_underlyingInfo = serial_Excel_underlyingCalcInfo.Excel_underlyingInfo_;
            // 역시 이미 있음.
            //this.excel_underlyingInfoViewModel_ = new ObservableCollection<Excel_underlyingInfoViewModel>();
            this.excel_underlyingInfoViewModel_.Clear();
            foreach (var item in serial_excel_underlyingInfo)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_underlyingInfoViewModel viewModel = Excel_underlyingInfoViewModel.CreateExcel_underlyingInfo(type);
                viewModel.setFromSerial(item);
                //this.excel_underlyingInfoViewModel_.Add(viewModel);
                this.addUnderlyingInfoVM(viewModel);
            }

            //List<FpmlSerializedCSharp.Excel_underlyingCalcID> serial_excel_underlyingCalcID = serial_Excel_underlyingCalcInfo.Excel_underlyingCalcID_;
            //this.excel_underlyingCalcIDViewModel_ = new ObservableCollection<Excel_underlyingCalcIDViewModel>();
            //foreach (var item in serial_excel_underlyingCalcID)
            //{
            //    string type = item.Type_.ValueStr;
            //    Excel_underlyingCalcIDViewModel viewModel = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(type);
            //    viewModel.setFromSerial(item);
            //    this.excel_underlyingCalcIDViewModel_.Add(viewModel);
            //}
            
            //this.view_ = new Excel_underlyingCalcInfoView();
            //this.view_.DataContext = this;
        }

        public System.Windows.Controls.Control view()
        {
            Control v = new Excel_underlyingCalcInfoView();

            v.DataContext = this;

            return v;
        }

        public void buildFromTradeString(TradeString tradeString)
        {
            this.excel_underlyingInfoViewModel_.Clear();

            DateTime effectiveDate = StringConverter.xmlDateToDateTime(tradeString.EffectiveDate_);

            foreach (var item in tradeString.UnderlyingList_)
	        {
                this.excel_underlyingInfoViewModel_.Add(Excel_loaderViewModel.loadUnderInfo(effectiveDate,item));

	        }
            
        }

        public string getUnderlyingString()
        {
            string str = "";

            foreach (var item in this.excel_underlyingInfoViewModel_)
            {
                str += "code : " + item.KrCode_ + "basePrice : " + item.BasePrice_ + "\n";
            }

            return str;

            //return str.Remove(str.Length - 1); ;
        }

        public string historyUnderData(DateTime effectiveDate, DateTime referenceDate, bool bodyOnly = false)
        {
            //Dictionary<string, QLNet.TimeSeries<string>> dataList = new Dictionary<string, QLNet.TimeSeries<string>>();

            StringBuilder sb = new StringBuilder();
            XmlWriterSettings setting = new XmlWriterSettings();

            setting.Indent = true;
            //setting.Encoding = Encoding.UTF8;

            if (bodyOnly == true)
                setting.OmitXmlDeclaration = true;

            XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

            xmlWriter.WriteStartElement("hisoryData");
                

            foreach (var item in this.excel_underlyingInfoViewModel_)
            {
                IndexHistoryMarketData ihmd = new IndexHistoryMarketData(item.KrCode_);

                QLNet.TimeSeries<string> series = new QLNet.TimeSeries<string>();

                if (item.Excel_type_.ToUpper() == "INTERESTRATE" || item.Excel_type_.ToUpper() == "EXCEL_INTERESTRATE")
                {
                    ihmd.Tenor_ = ((Excel_interestRateViewModel)item).Tenor_;
                    ihmd.LinkedCurveCode_ = ((Excel_interestRateViewModel)item).LinkedCurveCode_;
                    series = ihmd.historyCurveSeriesMRO(effectiveDate, referenceDate);
                }
                else
                {
                    series = ihmd.historySeriesMRO(effectiveDate, referenceDate);
                }

                xmlWriter.WriteStartElement("marketData");

                xmlWriter.WriteElementString("krcode", item.KrCode_);

                xmlWriter.WriteElementString("name", item.NameTrans_.Value_);

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

            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            return sb.ToString();
        }
    }
    
}

