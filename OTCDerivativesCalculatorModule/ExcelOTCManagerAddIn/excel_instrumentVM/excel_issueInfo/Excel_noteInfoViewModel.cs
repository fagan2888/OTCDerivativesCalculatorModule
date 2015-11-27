using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_noteInfoViewModel : Excel_issueInfoViewModel
    {
        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion
        
    
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
        private string tradeDate_;
        public string TradeDate_
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
        private string effectiveDate_;
        public string EffectiveDate_
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
        private string maturityDate_;
        public string MaturityDate_
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_issueInfo");
                xmlWriter.WriteElementString("type" , "excel_noteInfo");
                xmlWriter.WriteStartElement("excel_noteInfo");
                    xmlWriter.WriteElementString("tradeDate" , this.tradeDate_);
                    
                    xmlWriter.WriteElementString("effectiveDate" , this.effectiveDate_);
                    
                    xmlWriter.WriteElementString("maturityDate" , this.maturityDate_);
                    
                    xmlWriter.WriteElementString("notional" , this.notional_);
                    
                    xmlWriter.WriteElementString("premium" , this.premium_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_issueInfo serial_Excel_issueInfo = serial_Class as FpmlSerializedCSharp.Excel_issueInfo;
            FpmlSerializedCSharp.Excel_noteInfo serial_Excel_noteInfo = serial_Excel_issueInfo.Excel_noteInfo_;
        
            this.tradeDate_ = serial_Excel_noteInfo.TradeDate_.ValueStr;
            
            this.effectiveDate_ = serial_Excel_noteInfo.EffectiveDate_.ValueStr;
            
            this.maturityDate_ = serial_Excel_noteInfo.MaturityDate_.ValueStr;
            
            this.notional_ = serial_Excel_noteInfo.Notional_.ValueStr;
            
            this.premium_ = serial_Excel_noteInfo.Premium_.ValueStr;
            
            this.view_ = new Excel_noteInfoView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

