using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class CouponScheduleViewModel : IXmlData
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
        
    
        public CouponScheduleViewModel() { }
        
    
        #region EventDate_
        private string eventDate_;
        public string EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
                }
            }
        }
        #endregion
        
        #region CalculationStartDate_
        private string calculationStartDate_;
        public string CalculationStartDate_
        {
            get { return this.calculationStartDate_; }
            set
            {
                if (this.calculationStartDate_ != value)
                {
                    this.calculationStartDate_ = value;
                    this.NotifyPropertyChanged("CalculationStartDate_");
                }
            }
        }
        #endregion
        
        #region CalculationEndDate_
        private string calculationEndDate_;
        public string CalculationEndDate_
        {
            get { return this.calculationEndDate_; }
            set
            {
                if (this.calculationEndDate_ != value)
                {
                    this.calculationEndDate_ = value;
                    this.NotifyPropertyChanged("CalculationEndDate_");
                }
            }
        }
        #endregion
        
        #region PaymentDate_
        private string paymentDate_;
        public string PaymentDate_
        {
            get { return this.paymentDate_; }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                    this.NotifyPropertyChanged("PaymentDate_");
                }
            }
        }
        #endregion
        
        #region DetailScheduleType_
        private string detailScheduleType_;
        public string DetailScheduleType_
        {
            get { return this.detailScheduleType_; }
            set
            {
                if (this.detailScheduleType_ != value)
                {
                    this.detailScheduleType_ = value;
                    this.NotifyPropertyChanged("DetailScheduleType_");
                }
            }
        }
        #endregion
        
        #region Description_
        private string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion
        
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "couponSchedule");
                xmlWriter.WriteStartElement("couponSchedule");
                    xmlWriter.WriteElementString("eventDate" , this.eventDate_);
                    
                    xmlWriter.WriteElementString("calculationStartDate" , this.calculationStartDate_);
                    
                    xmlWriter.WriteElementString("calculationEndDate" , this.calculationEndDate_);
                    
                    xmlWriter.WriteElementString("paymentDate" , this.paymentDate_);
                    
                    xmlWriter.WriteElementString("detailScheduleType" , this.detailScheduleType_);
                    
                    xmlWriter.WriteElementString("description" , this.description_);
                    
                    couponCalculationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CouponSchedule serial_CouponSchedule = serial_Class as FpmlSerializedCSharp.CouponSchedule;
        
            this.eventDate_ = serial_CouponSchedule.EventDate_.ValueStr;
            
            this.calculationStartDate_ = serial_CouponSchedule.CalculationStartDate_.ValueStr;
            
            this.calculationEndDate_ = serial_CouponSchedule.CalculationEndDate_.ValueStr;
            
            this.paymentDate_ = serial_CouponSchedule.PaymentDate_.ValueStr;
            
            this.detailScheduleType_ = serial_CouponSchedule.DetailScheduleType_.ValueStr;
            
            this.description_ = serial_CouponSchedule.Description_.ValueStr;
            
            FpmlSerializedCSharp.CouponCalculation serial_couponCalculation = serial_CouponSchedule.CouponCalculation_;
            string couponCalculationtype = serial_couponCalculation.Excel_type_.ValueStr;
            this.couponCalculationViewModel_ = CouponCalculationViewModel.CreateCouponCalculation(couponCalculationtype);
            this.couponCalculationViewModel_.setFromSerial(serial_couponCalculation);
            
            this.view_ = new CouponScheduleView();
            this.view_.DataContext = this;
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
            
        
    
        
    
    }
    
}

