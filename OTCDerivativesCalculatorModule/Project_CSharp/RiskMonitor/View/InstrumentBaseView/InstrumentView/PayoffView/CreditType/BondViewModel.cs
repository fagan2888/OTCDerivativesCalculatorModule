using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class BondViewModel : IXmlData
    {
        #region View_
        private Control view_;
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
        
    
        public BondViewModel() { }
        
    
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Bond serial_Bond = serial_Class as FpmlSerializedCSharp.Bond;
        
            this.instrumentId_ = serial_Bond.InstrumentId_.ValueStr;
            
            this.couponRate_ = serial_Bond.CouponRate_.ValueStr;
            
            this.maturity_ = serial_Bond.Maturity_.ValueStr;
            
        }
    
    }
    
}

