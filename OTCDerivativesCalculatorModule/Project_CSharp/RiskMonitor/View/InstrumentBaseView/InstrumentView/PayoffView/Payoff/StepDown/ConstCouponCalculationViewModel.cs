using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class ConstCouponCalculationViewModel : CouponCalculationViewModel
    {
    
        public ConstCouponCalculationViewModel() { }
        
    
        #region Value_
        private string value_;
        public string Value_
        {
            get { return this.value_; }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                    this.NotifyPropertyChanged("Value_");
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
            FpmlSerializedCSharp.CouponCalculation serial_CouponCalculation = serial_Class as FpmlSerializedCSharp.CouponCalculation;
            FpmlSerializedCSharp.ConstCouponCalculation serial_ConstCouponCalculation = serial_CouponCalculation.ConstCouponCalculation_;
        
            this.value_ = serial_ConstCouponCalculation.Value_.ValueStr;
            
            //this.view_ = new ConstCouponCalculationView();
            //this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

