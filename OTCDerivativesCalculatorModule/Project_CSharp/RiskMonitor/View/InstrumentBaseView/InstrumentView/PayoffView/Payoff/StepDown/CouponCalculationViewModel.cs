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
        #region View_
        private Control view_;
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
        
    
        public CouponCalculationViewModel() { }
        
    
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
        
        #region ConstCouponCalculationViewModel_
        private ConstCouponCalculationViewModel constCouponCalculationViewModel_;
        public ConstCouponCalculationViewModel ConstCouponCalculationViewModel_
        {
            get { return this.constCouponCalculationViewModel_; }
            set
            {
                if (this.constCouponCalculationViewModel_ != value)
                {
                    this.constCouponCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("ConstCouponCalculationViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_couponType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static CouponCalculationViewModel CreateCouponCalculation(string typeStr)
        {
            if ( typeStr == "constCouponCalculation")
            {
                return new ConstCouponCalculationViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        public static CouponCalculationViewModel CreateCouponCalculation(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CouponCalculation serial_CouponCalculation = serial_Class as FpmlSerializedCSharp.CouponCalculation;
            string typeStr = serial_CouponCalculation.Type_.ValueStr;
            return CouponCalculationViewModel.CreateCouponCalculation(typeStr);
        }
        
    
    }
    
}

