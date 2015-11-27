using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class CreditPayoffInfoViewModel : IXmlData
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
        
    
        public CreditPayoffInfoViewModel() { }
        
    
        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion
        
        public string choiceStr_creditPayoffType;
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static CreditPayoffInfoViewModel CreateCreditPayoffInfo(string typeStr)
        {
            if ( typeStr == "creditDefaultSwap")
            {
                return new CreditDefaultSwapViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static CreditPayoffInfoViewModel CreateCreditPayoffInfo(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CreditPayoffInfo serial_CreditPayoffInfo = serial_Class as FpmlSerializedCSharp.CreditPayoffInfo;
            string typeStr = serial_CreditPayoffInfo.Type_.ValueStr;
            return CreditPayoffInfoViewModel.CreateCreditPayoffInfo(typeStr);
        }
        
    
    }
    
}

