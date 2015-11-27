using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public abstract class Excel_interfaceViewModel : IXmlData , INotifyPropertyChanged
    {
        #region Event
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                if (propertyName == "")
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
                else 
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }
        #endregion

        #region ItemCode_
        private string itemCode_;
        public string ItemCode_
        {
            get { return this.itemCode_; }
            set
            {
                if (this.itemCode_ != value)
                {
                    this.itemCode_ = value;
                    this.NotifyPropertyChanged("ItemCode_");
                }
            }
        }
        #endregion

        #region Excel_issueInfoViewModel_
        protected Excel_issueInfoViewModel excel_issueInfoViewModel_;
        public Excel_issueInfoViewModel Excel_issueInfoViewModel_
        {
            get { return this.excel_issueInfoViewModel_; }
            set
            {
                if (this.excel_issueInfoViewModel_ != value)
                {
                    this.excel_issueInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_issueInfoViewModel_");
                }
            }
        }

        #endregion

        public Excel_interfaceViewModel() 
        {
            //this.currencyList_ = new List<CurrencyViewModel>();
        }
    
        #region Excel_workBookType_
        private string excel_workBookType_;
        public string Excel_workBookType_
        {
            get { return this.excel_workBookType_; }
            set
            {
                if (this.excel_workBookType_ != value)
                {
                    this.excel_workBookType_ = value;
                    this.NotifyPropertyChanged("Excel_workBookType_");
                }
            }
        }
        #endregion

        #region Excel_underlyingCalcInfoViewModel_
        protected Excel_underlyingCalcInfoViewModel excel_underlyingCalcInfoViewModel_;
        public Excel_underlyingCalcInfoViewModel Excel_underlyingCalcInfoViewModel_
        {
            get { 
                return this.getExcel_underlyingCalcInfoViewModel(); 
            }
            set
            {
                if (this.excel_underlyingCalcInfoViewModel_ != value)
                {
                    this.excel_underlyingCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcInfoViewModel_");
                }
            }
        }
        #endregion

        public virtual void masterEventObserver(object sender, PropertyChangedEventArgs e) 
        {
            //issue쪽을 처리함. 하위에서 나머지를 setting함.
            this.excel_issueInfoViewModel_.MaturityDateObserver(sender, e);
        }

        //public virtual void currencyEventObserver(object sender, PropertyChangedEventArgs e)
        //{ 
        
        //}

        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void buildPricingXml(XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);

        public abstract void setUnderlying();
        public abstract List<CurrencyViewModel> currencyList();

        public string productXml(bool bodyOnly = false)
        {
            //XmlDocument InstXml = new XmlDocument();

            StringBuilder sb = new StringBuilder();
            XmlWriterSettings setting = new XmlWriterSettings();

            setting.Indent = true;

            if (bodyOnly == true)
                setting.OmitXmlDeclaration = true;

            //setting.Encoding = Encoding.UTF8;

            XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");
            
            xmlWriter.WriteStartElement("instrument");

                if (this.itemCode_ == null || this.itemCode_ == "")
                {
                    xmlWriter.WriteElementString("code", "testCode");
                }
                else
                {
                    xmlWriter.WriteElementString("code", this.itemCode_);
                }
                
                this.buildXml(xmlWriter);
                // 우선 뺴놓자..
                //this.buildPricingXml(xmlWriter);

            xmlWriter.WriteEndElement();

            xmlWriter.Close();

            //InstXml.LoadXml(sb.ToString());

            return sb.ToString();
        }

        //public static Excel_interfaceViewModel CreateExcel_interface(string typeStr)
        //{
        //    if ( typeStr == "excel_hifive")
        //    {
        //        return new Excel_hifiveViewModel();
        //    }
        //    //else if (typeStr == "excel_general")
        //    //{
        //    //    return new Excel_generalViewModel();
        //    //}

        //    else
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        
        //public static Excel_interfaceViewModel CreateExcel_interface(FpmlSerializedCSharp.ISerialized serial_Class)
        //{
        //    //FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
        //    //string typeStr = serial_Excel_interface.Type_.ValueStr;
        //    //return Excel_interfaceViewModel.CreateExcel_interface(typeStr);
        //}

        //public void loadInterfaceFromXml()
        //{
        //    XmlDocument xmlDoc = XMLFileLoader.LoadInstrument(this.itemCode_);

        //    //XmlNode paraNode = xmlDoc.SelectSingleNode("
        //    XmlNode instNode = xmlDoc.SelectSingleNode("instrument");

        //    FpmlSerializedCSharp.Instrument inst = new FpmlSerializedCSharp.Instrument(instNode);

        //    this.setFromXml(instNode);
        //}

        public abstract void bookingEvent(MasterInformationViewModel masterInformationViewModel);

        public abstract Control view();

        public virtual Excel_underlyingCalcInfoViewModel getExcel_underlyingCalcInfoViewModel()
        {
            // default는 그냥 내보냄.

            // swap 같은데서 여러개 취합해서 내보낼경우 구현함.

            return this.excel_underlyingCalcInfoViewModel_;
        }

        public abstract void buildFromTradeString(TradeString tradeString);
    }
    
}

