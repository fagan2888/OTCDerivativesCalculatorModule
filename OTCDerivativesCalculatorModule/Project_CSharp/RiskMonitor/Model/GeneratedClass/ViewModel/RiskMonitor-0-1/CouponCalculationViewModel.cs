using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public abstract class CouponCalculationViewModel : IXmlData
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
        
    
        public CouponCalculationViewModel() { }
        
    
        #region FixedCouponCalculationViewModel_
        private FixedCouponCalculationViewModel fixedCouponCalculationViewModel_;
        public FixedCouponCalculationViewModel FixedCouponCalculationViewModel_
        {
            get { return this.fixedCouponCalculationViewModel_; }
            set
            {
                if (this.fixedCouponCalculationViewModel_ != value)
                {
                    this.fixedCouponCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("FixedCouponCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region VanillaCouponCaclulationViewModel_
        private VanillaCouponCaclulationViewModel vanillaCouponCaclulationViewModel_;
        public VanillaCouponCaclulationViewModel VanillaCouponCaclulationViewModel_
        {
            get { return this.vanillaCouponCaclulationViewModel_; }
            set
            {
                if (this.vanillaCouponCaclulationViewModel_ != value)
                {
                    this.vanillaCouponCaclulationViewModel_ = value;
                    this.NotifyPropertyChanged("VanillaCouponCaclulationViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_0;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static CouponCalculationViewModel CreateCouponCalculation(string typeStr)
        {
            if ( typeStr == "fixedCouponCalculation")
            {
                return new FixedCouponCalculationViewModel();
            }
            else if ( typeStr == "vanillaCouponCaclulation")
            {
                return new VanillaCouponCaclulationViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static CouponCalculationViewModel CreateCouponCalculation(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CouponCalculation serial_CouponCalculation = serial_Class as FpmlSerializedCSharp.CouponCalculation;
            string typeStr = serial_CouponCalculation.Excel_type_.ValueStr;
            return CouponCalculationViewModel.CreateCouponCalculation(typeStr);
        }
        
    
    }
    
}

