using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class RateCouponCalculationViewModel : IXmlData
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
        
        public RateCouponCalculationViewModel() { }
        
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
        
        #region FixedRateCouponCalculationViewModel_
        private FixedRateCouponCalculationViewModel fixedRateCouponCalculationViewModel_;
        public FixedRateCouponCalculationViewModel FixedRateCouponCalculationViewModel_
        {
            get { return this.fixedRateCouponCalculationViewModel_; }
            set
            {
                if (this.fixedRateCouponCalculationViewModel_ != value)
                {
                    this.fixedRateCouponCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("FixedRateCouponCalculationViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_rateCouponCalType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static RateCouponCalculationViewModel CreateRateCouponCalculation(string typeStr)
        {
            if ( typeStr == "fixedRateCouponCalculation")
            {
                return new FixedRateCouponCalculationViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

