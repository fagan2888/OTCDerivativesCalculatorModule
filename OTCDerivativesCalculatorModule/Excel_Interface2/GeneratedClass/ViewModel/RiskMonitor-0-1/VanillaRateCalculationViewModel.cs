using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class VanillaRateCalculationViewModel : RateCalculationViewModel
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
        
        public VanillaRateCalculationViewModel() { }
        
        #region RateCouponCalculationViewModel_
        private RateCouponCalculationViewModel rateCouponCalculationViewModel_;
        public RateCouponCalculationViewModel RateCouponCalculationViewModel_
        {
            get { return this.rateCouponCalculationViewModel_; }
            set
            {
                if (this.rateCouponCalculationViewModel_ != value)
                {
                    this.rateCouponCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("RateCouponCalculationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("rateCalculation");
                xmlWriter.WriteElementString("excel_type" , "vanillaRateCalculation");
                xmlWriter.WriteStartElement("vanillaRateCalculation");
                    rateCouponCalculationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new VanillaRateCalculationView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RateCalculation serial_RateCalculation = serial_Class as FpmlSerializedCSharp.RateCalculation;
            FpmlSerializedCSharp.VanillaRateCalculation serial_VanillaRateCalculation = serial_RateCalculation.VanillaRateCalculation_;
        
            FpmlSerializedCSharp.RateCouponCalculation serial_rateCouponCalculation = serial_VanillaRateCalculation.RateCouponCalculation_;
            string rateCouponCalculationtype = serial_rateCouponCalculation.Excel_type_.ValueStr;
            this.rateCouponCalculationViewModel_ = RateCouponCalculationViewModel.CreateRateCouponCalculation(rateCouponCalculationtype);
            this.rateCouponCalculationViewModel_.setFromSerial(serial_rateCouponCalculation);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

