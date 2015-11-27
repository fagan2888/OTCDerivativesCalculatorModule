using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class EventTrigger_AViewModel : IXmlData
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
        
        public EventTrigger_AViewModel() { }
        
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
        
        #region FixedRatePayoff_AViewModel_
        private FixedRatePayoff_AViewModel fixedRatePayoff_AViewModel_;
        public FixedRatePayoff_AViewModel FixedRatePayoff_AViewModel_
        {
            get { return this.fixedRatePayoff_AViewModel_; }
            set
            {
                if (this.fixedRatePayoff_AViewModel_ != value)
                {
                    this.fixedRatePayoff_AViewModel_ = value;
                    this.NotifyPropertyChanged("FixedRatePayoff_AViewModel_");
                }
            }
        }
        #endregion
        
        #region VanillaFloatingRatePayoff_AViewModel_
        private VanillaFloatingRatePayoff_AViewModel vanillaFloatingRatePayoff_AViewModel_;
        public VanillaFloatingRatePayoff_AViewModel VanillaFloatingRatePayoff_AViewModel_
        {
            get { return this.vanillaFloatingRatePayoff_AViewModel_; }
            set
            {
                if (this.vanillaFloatingRatePayoff_AViewModel_ != value)
                {
                    this.vanillaFloatingRatePayoff_AViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaFloatingRatePayoff_AViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_eventTriggerType_A;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static EventTrigger_AViewModel CreateEventTrigger_A(string typeStr)
        {
            if ( typeStr == "fixedRatePayoff_A")
            {
                return new FixedRatePayoff_AViewModel();
            }
            else if ( typeStr == "vanillaFloatingRatePayoff_A")
            {
                return new VanillaFloatingRatePayoff_AViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

