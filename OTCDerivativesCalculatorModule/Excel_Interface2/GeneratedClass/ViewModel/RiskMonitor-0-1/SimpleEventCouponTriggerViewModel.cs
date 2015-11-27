using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SimpleEventCouponTriggerViewModel : EventTriggerViewModel
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
        
        public SimpleEventCouponTriggerViewModel() { }
        
        #region EventCalculationInfoViewModel_
        private EventCalculationInfoViewModel eventCalculationInfoViewModel_;
        public EventCalculationInfoViewModel EventCalculationInfoViewModel_
        {
            get { return this.eventCalculationInfoViewModel_; }
            set
            {
                if (this.eventCalculationInfoViewModel_ != value)
                {
                    this.eventCalculationInfoViewModel_ = value;
                    this.NotifyPropertyChanged("EventCalculationInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region ReturnCalculationInfoViewModel_
        private ReturnCalculationInfoViewModel returnCalculationInfoViewModel_;
        public ReturnCalculationInfoViewModel ReturnCalculationInfoViewModel_
        {
            get { return this.returnCalculationInfoViewModel_; }
            set
            {
                if (this.returnCalculationInfoViewModel_ != value)
                {
                    this.returnCalculationInfoViewModel_ = value;
                    this.NotifyPropertyChanged("ReturnCalculationInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region ComplementReturnCalculationViewModel_
        private ComplementReturnCalculationViewModel complementReturnCalculationViewModel_;
        public ComplementReturnCalculationViewModel ComplementReturnCalculationViewModel_
        {
            get { return this.complementReturnCalculationViewModel_; }
            set
            {
                if (this.complementReturnCalculationViewModel_ != value)
                {
                    this.complementReturnCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("ComplementReturnCalculationViewModel_");
                }
            }
        }
        #endregion
        
        #region PayoffDateInfoViewModel_
        private PayoffDateInfoViewModel payoffDateInfoViewModel_;
        public PayoffDateInfoViewModel PayoffDateInfoViewModel_
        {
            get { return this.payoffDateInfoViewModel_; }
            set
            {
                if (this.payoffDateInfoViewModel_ != value)
                {
                    this.payoffDateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("PayoffDateInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region IsExpired_
        private string isExpired_;
        public string IsExpired_
        {
            get { return this.isExpired_; }
            set
            {
                if (this.isExpired_ != value)
                {
                    this.isExpired_ = value;
                    this.NotifyPropertyChanged("IsExpired_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventTrigger");
                xmlWriter.WriteElementString("excel_type" , "simpleEventCouponTrigger");
                xmlWriter.WriteStartElement("simpleEventCouponTrigger");
                    eventCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    returnCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    complementReturnCalculationViewModel_.buildXml(xmlWriter);
                    
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("isExpired" , this.isExpired_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new SimpleEventCouponTriggerView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            FpmlSerializedCSharp.SimpleEventCouponTrigger serial_SimpleEventCouponTrigger = serial_EventTrigger.SimpleEventCouponTrigger_;
        
            FpmlSerializedCSharp.EventCalculationInfo serial_eventCalculationInfo = serial_SimpleEventCouponTrigger.EventCalculationInfo_;
            string eventCalculationInfotype = serial_eventCalculationInfo.Excel_type_.ValueStr;
            this.eventCalculationInfoViewModel_ = EventCalculationInfoViewModel.CreateEventCalculationInfo(eventCalculationInfotype);
            this.eventCalculationInfoViewModel_.setFromSerial(serial_eventCalculationInfo);
            
            FpmlSerializedCSharp.ReturnCalculationInfo serial_returnCalculationInfo = serial_SimpleEventCouponTrigger.ReturnCalculationInfo_;
            string returnCalculationInfotype = serial_returnCalculationInfo.Excel_type_.ValueStr;
            this.returnCalculationInfoViewModel_ = ReturnCalculationInfoViewModel.CreateReturnCalculationInfo(returnCalculationInfotype);
            this.returnCalculationInfoViewModel_.setFromSerial(serial_returnCalculationInfo);
            
            FpmlSerializedCSharp.ComplementReturnCalculation serial_complementReturnCalculation = serial_SimpleEventCouponTrigger.ComplementReturnCalculation_;
            string complementReturnCalculationtype = serial_complementReturnCalculation.Excel_type_.ValueStr;
            this.complementReturnCalculationViewModel_ = ComplementReturnCalculationViewModel.CreateComplementReturnCalculation(complementReturnCalculationtype);
            this.complementReturnCalculationViewModel_.setFromSerial(serial_complementReturnCalculation);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_SimpleEventCouponTrigger.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            this.isExpired_ = serial_SimpleEventCouponTrigger.IsExpired_.ValueStr;
            
        }
        
        
    
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

