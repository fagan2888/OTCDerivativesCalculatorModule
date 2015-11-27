using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class CashFlowInfoResultViewModel : IXmlData
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
        
        public CashFlowInfoResultViewModel() { }
        
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
        
        #region SimpleCashFlowResultViewModel_
        private SimpleCashFlowResultViewModel simpleCashFlowResultViewModel_;
        public SimpleCashFlowResultViewModel SimpleCashFlowResultViewModel_
        {
            get { return this.simpleCashFlowResultViewModel_; }
            set
            {
                if (this.simpleCashFlowResultViewModel_ != value)
                {
                    this.simpleCashFlowResultViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleCashFlowResultViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_cashFlowType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static CashFlowInfoResultViewModel CreateCashFlowInfoResult(string typeStr)
        {
            if ( typeStr == "simpleCashFlowResult")
            {
                return new SimpleCashFlowResultViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

