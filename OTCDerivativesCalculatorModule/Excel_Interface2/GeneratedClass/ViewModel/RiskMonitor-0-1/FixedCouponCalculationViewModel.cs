using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class FixedCouponCalculationViewModel : CouponCalculationViewModel
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
        
    
        public FixedCouponCalculationViewModel() { }
        
    
        #region FixedRate_
        private string fixedRate_;
        public string FixedRate_
        {
            get { return this.fixedRate_; }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                    this.NotifyPropertyChanged("FixedRate_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("couponCalculation");
                xmlWriter.WriteElementString("type" , "fixedCouponCalculation");
                xmlWriter.WriteStartElement("fixedCouponCalculation");
                    xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CouponCalculation serial_CouponCalculation = serial_Class as FpmlSerializedCSharp.CouponCalculation;
            FpmlSerializedCSharp.FixedCouponCalculation serial_FixedCouponCalculation = serial_CouponCalculation.FixedCouponCalculation_;
        
            this.fixedRate_ = serial_FixedCouponCalculation.FixedRate_.ValueStr;
            
            this.view_ = new FixedCouponCalculationView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

