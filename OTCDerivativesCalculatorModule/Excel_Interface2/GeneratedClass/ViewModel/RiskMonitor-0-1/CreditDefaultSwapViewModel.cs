using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CreditDefaultSwapViewModel : CreditPayoffInfoViewModel
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
            xmlWriter.WriteStartElement("creditPayoffInfo");
                xmlWriter.WriteElementString("excel_type" , "creditDefaultSwap");
                xmlWriter.WriteStartElement("creditDefaultSwap");
                    protectionPartViewModel_.buildXml(xmlWriter);
                    
                    couponPartViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new CreditDefaultSwapView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CreditPayoffInfo serial_CreditPayoffInfo = serial_Class as FpmlSerializedCSharp.CreditPayoffInfo;
            FpmlSerializedCSharp.CreditDefaultSwap serial_CreditDefaultSwap = serial_CreditPayoffInfo.CreditDefaultSwap_;
        
            FpmlSerializedCSharp.ProtectionPart serial_protectionPart = serial_CreditDefaultSwap.ProtectionPart_;
            string protectionParttype = serial_protectionPart.Excel_type_.ValueStr;
            this.protectionPartViewModel_ = ProtectionPartViewModel.CreateProtectionPart(protectionParttype);
            this.protectionPartViewModel_.setFromSerial(serial_protectionPart);
            
            FpmlSerializedCSharp.CouponPart serial_couponPart = serial_CreditDefaultSwap.CouponPart_;
            string couponParttype = serial_couponPart.Excel_type_.ValueStr;
            this.couponPartViewModel_ = CouponPartViewModel.CreateCouponPart(couponParttype);
            this.couponPartViewModel_.setFromSerial(serial_couponPart);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

