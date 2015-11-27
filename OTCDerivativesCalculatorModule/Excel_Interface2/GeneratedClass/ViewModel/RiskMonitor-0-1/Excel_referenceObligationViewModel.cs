using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_referenceObligationViewModel : IXmlData
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
        
        public Excel_referenceObligationViewModel() { }
        
        #region InstrumentId_
        private string instrumentId_;
        public string InstrumentId_
        {
            get { return this.instrumentId_; }
            set
            {
                if (this.instrumentId_ != value)
                {
                    this.instrumentId_ = value;
                    this.NotifyPropertyChanged("InstrumentId_");
                }
            }
        }
        #endregion
        
        #region CouponRate_
        private string couponRate_;
        public string CouponRate_
        {
            get { return this.couponRate_; }
            set
            {
                if (this.couponRate_ != value)
                {
                    this.couponRate_ = value;
                    this.NotifyPropertyChanged("CouponRate_");
                }
            }
        }
        #endregion
        
        #region Maturity_
        private string maturity_;
        public string Maturity_
        {
            get { return this.maturity_; }
            set
            {
                if (this.maturity_ != value)
                {
                    this.maturity_ = value;
                    this.NotifyPropertyChanged("Maturity_");
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_referenceObligation");
                xmlWriter.WriteStartElement("excel_referenceObligation");
                    xmlWriter.WriteElementString("instrumentId" , this.instrumentId_);
                    
                    xmlWriter.WriteElementString("couponRate" , this.couponRate_);
                    
                    xmlWriter.WriteElementString("maturity" , this.maturity_);
                    
                    xmlWriter.WriteElementString("currency" , this.currency_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_referenceObligationView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceObligation serial_Excel_referenceObligation = serial_Class as FpmlSerializedCSharp.Excel_referenceObligation;
        
            this.instrumentId_ = serial_Excel_referenceObligation.InstrumentId_.ValueStr;
            
            this.couponRate_ = serial_Excel_referenceObligation.CouponRate_.ValueStr;
            
            this.maturity_ = serial_Excel_referenceObligation.Maturity_.ValueStr;
            
            this.currency_ = serial_Excel_referenceObligation.Currency_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

