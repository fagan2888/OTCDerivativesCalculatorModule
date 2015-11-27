using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class IRCouponCalculationViewModel : IXmlData
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
    
        public IRCouponCalculationViewModel() { }
        
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
        
        #region FixedRateCalculationViewModel_
        private FixedRateCalculationViewModel fixedRateCalculationViewModel_;
        public FixedRateCalculationViewModel FixedRateCalculationViewModel_
        {
            get { return this.fixedRateCalculationViewModel_; }
            set
            {
                if (this.fixedRateCalculationViewModel_ != value)
                {
                    this.fixedRateCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("FixedRateCalculationViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_irCouponCalType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static IRCouponCalculationViewModel CreateIRCouponCalculation(string typeStr)
        {
            if ( typeStr == "fixedRateCalculation")
            {
                return new FixedRateCalculationViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static IRCouponCalculationViewModel CreateIRCouponCalculation(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.IRCouponCalculation serial_IRCouponCalculation = serial_Class as FpmlSerializedCSharp.IRCouponCalculation;
            string typeStr = serial_IRCouponCalculation.Type_.ValueStr;
            return IRCouponCalculationViewModel.CreateIRCouponCalculation(typeStr);
        }
        
    
    }
    
}

