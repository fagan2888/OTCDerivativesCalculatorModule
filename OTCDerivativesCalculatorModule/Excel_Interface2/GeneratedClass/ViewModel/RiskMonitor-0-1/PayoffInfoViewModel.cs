using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class PayoffInfoViewModel : IXmlData
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
        
        public PayoffInfoViewModel() { }
        
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
        
        #region PreDefinedVariableListViewModel_
        private PreDefinedVariableListViewModel preDefinedVariableListViewModel_;
        public PreDefinedVariableListViewModel PreDefinedVariableListViewModel_
        {
            get { return this.preDefinedVariableListViewModel_; }
            set
            {
                if (this.preDefinedVariableListViewModel_ != value)
                {
                    this.preDefinedVariableListViewModel_ = value;
                    this.NotifyPropertyChanged("PreDefinedVariableListViewModel_");
                }
            }
        }
        #endregion
        
        #region StopLossPayoffViewModel_
        private StopLossPayoffViewModel stopLossPayoffViewModel_;
        public StopLossPayoffViewModel StopLossPayoffViewModel_
        {
            get { return this.stopLossPayoffViewModel_; }
            set
            {
                if (this.stopLossPayoffViewModel_ != value)
                {
                    this.stopLossPayoffViewModel_ = value;
                    this.NotifyPropertyChanged("StopLossPayoffViewModel_");
                }
            }
        }
        #endregion
        
        #region VanillaPayoffViewModel_
        private VanillaPayoffViewModel vanillaPayoffViewModel_;
        public VanillaPayoffViewModel VanillaPayoffViewModel_
        {
            get { return this.vanillaPayoffViewModel_; }
            set
            {
                if (this.vanillaPayoffViewModel_ != value)
                {
                    this.vanillaPayoffViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaPayoffViewModel_");
                }
            }
        }
        #endregion
        
        #region CompositeSumOptionPayoffViewModel_
        private CompositeSumOptionPayoffViewModel compositeSumOptionPayoffViewModel_;
        public CompositeSumOptionPayoffViewModel CompositeSumOptionPayoffViewModel_
        {
            get { return this.compositeSumOptionPayoffViewModel_; }
            set
            {
                if (this.compositeSumOptionPayoffViewModel_ != value)
                {
                    this.compositeSumOptionPayoffViewModel_ = value;
                    this.NotifyPropertyChanged("CompositeSumOptionPayoffViewModel_");
                }
            }
        }
        #endregion
        
        #region AutoCallablePayoffViewModel_
        private AutoCallablePayoffViewModel autoCallablePayoffViewModel_;
        public AutoCallablePayoffViewModel AutoCallablePayoffViewModel_
        {
            get { return this.autoCallablePayoffViewModel_; }
            set
            {
                if (this.autoCallablePayoffViewModel_ != value)
                {
                    this.autoCallablePayoffViewModel_ = value;
                    this.NotifyPropertyChanged("AutoCallablePayoffViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_payoffType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static PayoffInfoViewModel CreatePayoffInfo(string typeStr)
        {
            if ( typeStr == "preDefinedVariableList")
            {
                return new PreDefinedVariableListViewModel();
            }
            else if ( typeStr == "stopLossPayoff")
            {
                return new StopLossPayoffViewModel();
            }
            else if ( typeStr == "vanillaPayoff")
            {
                return new VanillaPayoffViewModel();
            }
            else if ( typeStr == "compositeSumOptionPayoff")
            {
                return new CompositeSumOptionPayoffViewModel();
            }
            else if ( typeStr == "autoCallablePayoff")
            {
                return new AutoCallablePayoffViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

