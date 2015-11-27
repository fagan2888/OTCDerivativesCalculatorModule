using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class CashFlowInfoResultViewModel : IXmlData
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
        
        public CashFlowInfoResultViewModel() { }
        
        #region Type_
        protected string type_;
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
        
        public static CashFlowInfoResultViewModel CreateCashFlowInfoResult(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CashFlowInfoResult serial_CashFlowInfoResult = serial_Class as FpmlSerializedCSharp.CashFlowInfoResult;
            string typeStr = serial_CashFlowInfoResult.Type_.ValueStr;
            return CashFlowInfoResultViewModel.CreateCashFlowInfoResult(typeStr);
        }
        
    
    }
    
}

