using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SimpleRangeReturnTriggerViewModel : EventTriggerViewModel
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
        
        public SimpleRangeReturnTriggerViewModel() { }
        
        #region SimpleRangeEventCalViewModel_
        private SimpleRangeEventCalViewModel simpleRangeEventCalViewModel_;
        public SimpleRangeEventCalViewModel SimpleRangeEventCalViewModel_
        {
            get { return this.simpleRangeEventCalViewModel_; }
            set
            {
                if (this.simpleRangeEventCalViewModel_ != value)
                {
                    this.simpleRangeEventCalViewModel_ = value;
                    this.NotifyPropertyChanged("SimpleRangeEventCalViewModel_");
                }
            }
        }
        #endregion
        
        #region AutoCallFlag_
        private string autoCallFlag_;
        public string AutoCallFlag_
        {
            get { return this.autoCallFlag_; }
            set
            {
                if (this.autoCallFlag_ != value)
                {
                    this.autoCallFlag_ = value;
                    this.NotifyPropertyChanged("AutoCallFlag_");
                }
            }
        }
        #endregion
        
        #region Expired_
        private string expired_;
        public string Expired_
        {
            get { return this.expired_; }
            set
            {
                if (this.expired_ != value)
                {
                    this.expired_ = value;
                    this.NotifyPropertyChanged("Expired_");
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("eventTrigger");
                xmlWriter.WriteElementString("type" , "simpleRangeReturnTrigger");
                xmlWriter.WriteStartElement("simpleRangeReturnTrigger");
                    simpleRangeEventCalViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("autoCallFlag" , this.autoCallFlag_);
                    
                    xmlWriter.WriteElementString("expired" , this.expired_);
                    
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new SimpleRangeReturnTriggerView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            FpmlSerializedCSharp.SimpleRangeReturnTrigger serial_SimpleRangeReturnTrigger = serial_EventTrigger.SimpleRangeReturnTrigger_;
        
            FpmlSerializedCSharp.SimpleRangeEventCal serial_simpleRangeEventCal = serial_SimpleRangeReturnTrigger.SimpleRangeEventCal_;
            string simpleRangeEventCaltype = serial_simpleRangeEventCal.Excel_type_.ValueStr;
            this.simpleRangeEventCalViewModel_ = SimpleRangeEventCalViewModel.CreateSimpleRangeEventCal(simpleRangeEventCaltype);
            this.simpleRangeEventCalViewModel_.setFromSerial(serial_simpleRangeEventCal);
            
            this.autoCallFlag_ = serial_SimpleRangeReturnTrigger.AutoCallFlag_.ValueStr;
            
            this.expired_ = serial_SimpleRangeReturnTrigger.Expired_.ValueStr;
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_SimpleRangeReturnTrigger.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

