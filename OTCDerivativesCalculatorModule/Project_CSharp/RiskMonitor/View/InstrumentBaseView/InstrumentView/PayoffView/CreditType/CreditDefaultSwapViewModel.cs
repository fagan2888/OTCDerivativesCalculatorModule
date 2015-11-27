using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class CreditDefaultSwapViewModel : CreditPayoffInfoViewModel
    {
    
        public CreditDefaultSwapViewModel() { }
    
        #region ProtectionPartViewModel_
        private ProtectionPartViewModel protectionPartViewModel_;
        public ProtectionPartViewModel ProtectionPartViewModel_
        {
            get { return this.protectionPartViewModel_; }
            set
            {
                if (this.protectionPartViewModel_ != value)
                {
                    this.protectionPartViewModel_ = value;
                    this.NotifyPropertyChanged("ProtectionPartViewModel_");
                }
            }
        }
        #endregion
        
        #region CouponPartViewModel_
        private CouponPartViewModel couponPartViewModel_;
        public CouponPartViewModel CouponPartViewModel_
        {
            get { return this.couponPartViewModel_; }
            set
            {
                if (this.couponPartViewModel_ != value)
                {
                    this.couponPartViewModel_ = value;
                    this.NotifyPropertyChanged("CouponPartViewModel_");
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
            FpmlSerializedCSharp.CreditPayoffInfo serial_CreditPayoffInfo = serial_Class as FpmlSerializedCSharp.CreditPayoffInfo;
            FpmlSerializedCSharp.CreditDefaultSwap serial_CreditDefaultSwap = serial_CreditPayoffInfo.CreditDefaultSwap_;
        
            FpmlSerializedCSharp.ProtectionPart serial_protectionPart = serial_CreditDefaultSwap.ProtectionPart_;
            this.protectionPartViewModel_ = new ProtectionPartViewModel();
            this.protectionPartViewModel_.setFromSerial(serial_protectionPart);
            
            FpmlSerializedCSharp.CouponPart serial_couponPart = serial_CreditDefaultSwap.CouponPart_;
            this.couponPartViewModel_ = new CouponPartViewModel();
            this.couponPartViewModel_.setFromSerial(serial_couponPart);
            
            this.view_ = new CreditDefaultSwapView();
            this.view_.DataContext = this;
        }
    
    }
    
}

