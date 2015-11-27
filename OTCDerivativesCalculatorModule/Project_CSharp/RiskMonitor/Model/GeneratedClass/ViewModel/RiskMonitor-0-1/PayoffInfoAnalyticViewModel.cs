using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class PayoffInfoAnalyticViewModel : IXmlData
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
        
        public PayoffInfoAnalyticViewModel() { }
        
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
        
        #region StandardPayoff_AViewModel_
        private StandardPayoff_AViewModel standardPayoff_AViewModel_;
        public StandardPayoff_AViewModel StandardPayoff_AViewModel_
        {
            get { return this.standardPayoff_AViewModel_; }
            set
            {
                if (this.standardPayoff_AViewModel_ != value)
                {
                    this.standardPayoff_AViewModel_ = value;
                    this.NotifyPropertyChanged("StandardPayoff_AViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_payoffType_A;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static PayoffInfoAnalyticViewModel CreatePayoffInfoAnalytic(string typeStr)
        {
            if ( typeStr == "standardPayoff_A")
            {
                return new StandardPayoff_AViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

