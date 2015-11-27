using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class FixedRateCalculationViewModel : IRCouponCalculationViewModel
    {
    
        public FixedRateCalculationViewModel() { }
    
        #region Rate_
        private string rate_;
        public string Rate_
        {
            get { return this.rate_; }
            set
            {
                if (this.rate_ != value)
                {
                    this.rate_ = value;
                    this.NotifyPropertyChanged("Rate_");
                }
            }
        }
        #endregion
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.IRCouponCalculation serial_IRCouponCalculation = serial_Class as FpmlSerializedCSharp.IRCouponCalculation;
            FpmlSerializedCSharp.FixedRateCalculation serial_FixedRateCalculation = serial_IRCouponCalculation.FixedRateCalculation_;
        
            this.rate_ = serial_FixedRateCalculation.Rate_.ValueStr;
            
            this.view_ = new FixedRateCalculationView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

