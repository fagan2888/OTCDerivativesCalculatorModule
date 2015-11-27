using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class FixedRateCouponCalculationViewModel : RateCouponCalculationViewModel
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
        
        public FixedRateCouponCalculationViewModel() { }
        
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
            xmlWriter.WriteStartElement("rateCouponCalculation");
                xmlWriter.WriteElementString("type" , "fixedRateCouponCalculation");
                xmlWriter.WriteStartElement("fixedRateCouponCalculation");
                    xmlWriter.WriteElementString("rate" , this.rate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new FixedRateCouponCalculationView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RateCouponCalculation serial_RateCouponCalculation = serial_Class as FpmlSerializedCSharp.RateCouponCalculation;
            FpmlSerializedCSharp.FixedRateCouponCalculation serial_FixedRateCouponCalculation = serial_RateCouponCalculation.FixedRateCouponCalculation_;
        
            this.rate_ = serial_FixedRateCouponCalculation.Rate_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

