using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class CreditPayoffInfoViewModel : IXmlData
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
        
        #region CreditDefaultSwapViewModel_
        private CreditDefaultSwapViewModel creditDefaultSwapViewModel_;
        public CreditDefaultSwapViewModel CreditDefaultSwapViewModel_
        {
            get { return this.creditDefaultSwapViewModel_; }
            set
            {
                if (this.creditDefaultSwapViewModel_ != value)
                {
                    this.creditDefaultSwapViewModel_ = value;
                    this.NotifyPropertyChanged("CreditDefaultSwapViewModel_");
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
        
        
    
    }
    
}

