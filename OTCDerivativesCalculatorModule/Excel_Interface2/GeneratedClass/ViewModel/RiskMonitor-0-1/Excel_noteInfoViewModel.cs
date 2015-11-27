using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_noteInfoViewModel : Excel_issueInfoViewModel
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
        
        public Excel_noteInfoViewModel() { }
        
        #region TradeDate_
        private DateTime tradeDate_;
        public DateTime TradeDate_
        {
            get { return this.tradeDate_; }
            set
            {
                if (this.tradeDate_ != value)
                {
                    this.tradeDate_ = value;
                    this.NotifyPropertyChanged("TradeDate_");
                }
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
        
        #region MaturityDate_
        private DateTime maturityDate_;
        public DateTime MaturityDate_
        {
            get { return this.maturityDate_; }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                    this.NotifyPropertyChanged("MaturityDate_");
                }
            }
        }
        #endregion
        
        #region Notional_
        private string notional_;
        public string Notional_
        {
            get { return this.notional_; }
            set
            {
                if (this.notional_ != value)
                {
                    this.notional_ = value;
                    this.NotifyPropertyChanged("Notional_");
                }
            }
        }
        #endregion
        
        #region Currency_
        private string currency_;
        public string Currency_
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency_");
                }
            }
        }
        #endregion
        
        #region Premium_
        private string premium_;
        public string Premium_
        {
            get { return this.premium_; }
            set
            {
                if (this.premium_ != value)
                {
                    this.premium_ = value;
                    this.NotifyPropertyChanged("Premium_");
                }
            }
        }
        #endregion
        
        #region IncludeNotionalPayment_
        private string includeNotionalPayment_;
        public string IncludeNotionalPayment_
        {
            get { return this.includeNotionalPayment_; }
            set
            {
                if (this.includeNotionalPayment_ != value)
                {
                    this.includeNotionalPayment_ = value;
                    this.NotifyPropertyChanged("IncludeNotionalPayment_");
                }
            }
        }
        #endregion
        
        #region Vba_description_
        private string vba_description_;
        public string Vba_description_
        {
            get { return this.vba_description_; }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                    this.NotifyPropertyChanged("Vba_description_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_issueInfo");
                xmlWriter.WriteElementString("excel_type" , "excel_noteInfo");
                xmlWriter.WriteStartElement("excel_noteInfo");
                    xmlWriter.WriteElementString("tradeDate" , StringConverter.xmlDateTimeToDateString(this.tradeDate_));
                    
                    xmlWriter.WriteElementString("effectiveDate" , StringConverter.xmlDateTimeToDateString(this.effectiveDate_));
                    
                    xmlWriter.WriteElementString("maturityDate" , StringConverter.xmlDateTimeToDateString(this.maturityDate_));
                    
                    xmlWriter.WriteElementString("notional" , this.notional_);
                    
                    xmlWriter.WriteElementString("currency" , this.currency_);
                    
                    xmlWriter.WriteElementString("premium" , this.premium_);
                    
                    xmlWriter.WriteElementString("includeNotionalPayment" , this.includeNotionalPayment_);
                    
                    xmlWriter.WriteElementString("vba_description" , this.vba_description_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_noteInfoView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_issueInfo serial_Excel_issueInfo = serial_Class as FpmlSerializedCSharp.Excel_issueInfo;
            FpmlSerializedCSharp.Excel_noteInfo serial_Excel_noteInfo = serial_Excel_issueInfo.Excel_noteInfo_;
        
            this.tradeDate_ = StringConverter.xmlDateToDateTime(serial_Excel_noteInfo.TradeDate_.ValueStr);
            
            this.effectiveDate_ = StringConverter.xmlDateToDateTime(serial_Excel_noteInfo.EffectiveDate_.ValueStr);
            
            this.maturityDate_ = StringConverter.xmlDateToDateTime(serial_Excel_noteInfo.MaturityDate_.ValueStr);
            
            this.notional_ = serial_Excel_noteInfo.Notional_.ValueStr;
            
            this.currency_ = serial_Excel_noteInfo.Currency_.ValueStr;
            
            this.premium_ = serial_Excel_noteInfo.Premium_.ValueStr;
            
            this.includeNotionalPayment_ = serial_Excel_noteInfo.IncludeNotionalPayment_.ValueStr;
            
            this.vba_description_ = serial_Excel_noteInfo.Vba_description_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

