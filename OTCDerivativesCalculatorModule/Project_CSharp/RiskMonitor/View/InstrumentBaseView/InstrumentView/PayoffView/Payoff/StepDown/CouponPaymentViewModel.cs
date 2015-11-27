using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class CouponPaymentViewModel : EventTriggerViewModel
    {
        public CouponPaymentViewModel() { }
        
        #region CouponCalculationViewModel_
        private CouponCalculationViewModel couponCalculationViewModel_;
        public CouponCalculationViewModel CouponCalculationViewModel_
        {
            get { return this.couponCalculationViewModel_; }
            set
            {
                if (this.couponCalculationViewModel_ != value)
                {
                    this.couponCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("CouponCalculationViewModel_");
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
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            FpmlSerializedCSharp.CouponPayment serial_CouponPayment = serial_EventTrigger.CouponPayment_;
        
            this.date_ = serial_CouponPayment.Date_.ValueStr;
            
            FpmlSerializedCSharp.CouponCalculation serial_couponCalculation = serial_CouponPayment.CouponCalculation_;
            string couponCalculationtype = serial_couponCalculation.Type_.ValueStr;
            this.couponCalculationViewModel_ = CouponCalculationViewModel.CreateCouponCalculation(couponCalculationtype);
            this.couponCalculationViewModel_.setFromSerial(serial_couponCalculation);
            
            //this.view_ = new CouponPaymentView();
            //this.view_.DataContext = this;
        }
    
        #region SelectCouponCalculationInfo_
        private string selectCouponCalculationInfo_;
        public string SelectCouponCalculationInfo_
        {
            get { return this.selectCouponCalculationInfo_; }
            set
            {
                if (this.selectCouponCalculationInfo_ != value)
                {
                    this.selectCouponCalculationInfo_ = value;
                    this.NotifyPropertyChanged("SelectCouponCalculationInfo_");
                }
            }
        }
        #endregion
            
        public void selectCouponCalculationInfo(string typeStr)
        {
            this.couponCalculationViewModel_ = CouponCalculationViewModel.CreateCouponCalculation(typeStr);
            this.view_.DataContext = this;
        }

        public override void descriptionUpdate()
        {
            throw new NotImplementedException();
        }

    }
    
}

