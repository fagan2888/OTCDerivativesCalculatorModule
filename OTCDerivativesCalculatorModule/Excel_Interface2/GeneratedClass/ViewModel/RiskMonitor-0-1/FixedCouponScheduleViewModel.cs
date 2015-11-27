using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class FixedCouponScheduleViewModel : IXmlData
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
        
    
        public FixedCouponScheduleViewModel() { }
        
    
        #region FixedRate_
        private string fixedRate_;
        public string FixedRate_
        {
            get { return this.fixedRate_; }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                    this.NotifyPropertyChanged("FixedRate_");
                }
            }
        }
        #endregion
        
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "fixedCouponSchedule");
                xmlWriter.WriteStartElement("fixedCouponSchedule");
                    xmlWriter.WriteElementString("fixedRate" , this.fixedRate_);
                    
                    xmlWriter.WriteElementString("eventDate" , this.eventDate_);
                    
                    xmlWriter.WriteElementString("calculationStartDate" , this.calculationStartDate_);
                    
                    xmlWriter.WriteElementString("calculationEndDate" , this.calculationEndDate_);
                    
                    xmlWriter.WriteElementString("paymentDate" , this.paymentDate_);
                    
                    xmlWriter.WriteElementString("detailScheduleType" , this.detailScheduleType_);
                    
                    xmlWriter.WriteElementString("description" , this.description_);
                    
                    fixedCouponCalculationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.FixedCouponSchedule serial_FixedCouponSchedule = serial_Class as FpmlSerializedCSharp.FixedCouponSchedule;
        
            this.fixedRate_ = serial_FixedCouponSchedule.FixedRate_.ValueStr;
            
            this.eventDate_ = serial_FixedCouponSchedule.EventDate_.ValueStr;
            
            this.calculationStartDate_ = serial_FixedCouponSchedule.CalculationStartDate_.ValueStr;
            
            this.calculationEndDate_ = serial_FixedCouponSchedule.CalculationEndDate_.ValueStr;
            
            this.paymentDate_ = serial_FixedCouponSchedule.PaymentDate_.ValueStr;
            
            this.detailScheduleType_ = serial_FixedCouponSchedule.DetailScheduleType_.ValueStr;
            
            this.description_ = serial_FixedCouponSchedule.Description_.ValueStr;
            
            FpmlSerializedCSharp.FixedCouponCalculation serial_fixedCouponCalculation = serial_FixedCouponSchedule.FixedCouponCalculation_;
            string fixedCouponCalculationtype = serial_fixedCouponCalculation.Excel_type_.ValueStr;
            this.fixedCouponCalculationViewModel_ = FixedCouponCalculationViewModel.CreateFixedCouponCalculation(fixedCouponCalculationtype);
            this.fixedCouponCalculationViewModel_.setFromSerial(serial_fixedCouponCalculation);
            
            this.view_ = new FixedCouponScheduleView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectFixedCouponCalculationInfo_
            private string selectFixedCouponCalculationInfo_;
            public string SelectFixedCouponCalculationInfo_
            {
                get { return this.selectFixedCouponCalculationInfo_; }
                set
                {
                    if (this.selectFixedCouponCalculationInfo_ != value)
                    {
                        this.selectFixedCouponCalculationInfo_ = value;
                        this.NotifyPropertyChanged("SelectFixedCouponCalculationInfo_");
                    }
                }
            }
            #endregion
            
            public void selectFixedCouponCalculationInfo(string typeStr)
            {
                this.fixedCouponCalculationViewModel_ = FixedCouponCalculationViewModel.CreateFixedCouponCalculation(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

