using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public abstract class BondCouponInfoViewModel : IXmlData
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
        
        public BondCouponInfoViewModel() { }
        
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
        
        #region FixedRateTypeViewModel_
        private FixedRateTypeViewModel fixedRateTypeViewModel_;
        public FixedRateTypeViewModel FixedRateTypeViewModel_
        {
            get { return this.fixedRateTypeViewModel_; }
            set
            {
                if (this.fixedRateTypeViewModel_ != value)
                {
                    this.fixedRateTypeViewModel_ = value;
                    this.NotifyPropertyChanged("FixedRateTypeViewModel_");
                }
            }
        }
        #endregion
        
        public string choiceStr_bondCouponType;
        
    
        public abstract void buildXml(System.Xml.XmlWriter xmlWriter);
        public abstract void setFromXml(System.Xml.XmlNode node);
        public abstract void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class);
        
    
        public static BondCouponInfoViewModel CreateBondCouponInfo(string typeStr)
        {
            if ( typeStr == "fixedRateType")
            {
                return new FixedRateTypeViewModel();
            }
            else
            {
            throw new NotImplementedException();
            }
        }
        
        
    
    }
    
}

