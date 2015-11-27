using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class VanillaCouponCaclulationViewModel : CouponCalculationViewModel
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
        
    
        public VanillaCouponCaclulationViewModel() { }
        
    
        #region Gearing_
        private string gearing_;
        public string Gearing_
        {
            get { return this.gearing_; }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                    this.NotifyPropertyChanged("Gearing_");
                }
            }
        }
        #endregion
        
        #region Spread_
        private string spread_;
        public string Spread_
        {
            get { return this.spread_; }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                    this.NotifyPropertyChanged("Spread_");
                }
            }
        }
        #endregion
        
        #region CalculationRateSymbol_
        private string calculationRateSymbol_;
        public string CalculationRateSymbol_
        {
            get { return this.calculationRateSymbol_; }
            set
            {
                if (this.calculationRateSymbol_ != value)
                {
                    this.calculationRateSymbol_ = value;
                    this.NotifyPropertyChanged("CalculationRateSymbol_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("couponCalculation");
                xmlWriter.WriteElementString("type" , "vanillaCouponCaclulation");
                xmlWriter.WriteStartElement("vanillaCouponCaclulation");
                    xmlWriter.WriteElementString("gearing" , this.gearing_);
                    
                    xmlWriter.WriteElementString("spread" , this.spread_);
                    
                    xmlWriter.WriteElementString("calculationRateSymbol" , this.calculationRateSymbol_);
                    
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
            FpmlSerializedCSharp.VanillaCouponCaclulation serial_VanillaCouponCaclulation = serial_CouponCalculation.VanillaCouponCaclulation_;
        
            this.gearing_ = serial_VanillaCouponCaclulation.Gearing_.ValueStr;
            
            this.spread_ = serial_VanillaCouponCaclulation.Spread_.ValueStr;
            
            this.calculationRateSymbol_ = serial_VanillaCouponCaclulation.CalculationRateSymbol_.ValueStr;
            
            this.view_ = new VanillaCouponCaclulationView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

