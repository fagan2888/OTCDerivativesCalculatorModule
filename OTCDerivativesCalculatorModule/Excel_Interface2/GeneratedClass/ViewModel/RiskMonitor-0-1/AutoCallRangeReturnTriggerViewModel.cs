using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class AutoCallRangeReturnTriggerViewModel : EventTriggerViewModel
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
        
        public AutoCallRangeReturnTriggerViewModel() { }
        
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
                xmlWriter.WriteElementString("excel_type" , "autoCallRangeReturnTrigger");
                xmlWriter.WriteStartElement("autoCallRangeReturnTrigger");
                    simpleRangeEventCalViewModel_.buildXml(xmlWriter);
                    
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
            Control v = new AutoCallRangeReturnTriggerView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            FpmlSerializedCSharp.AutoCallRangeReturnTrigger serial_AutoCallRangeReturnTrigger = serial_EventTrigger.AutoCallRangeReturnTrigger_;
        
            FpmlSerializedCSharp.SimpleRangeEventCal serial_simpleRangeEventCal = serial_AutoCallRangeReturnTrigger.SimpleRangeEventCal_;
            string simpleRangeEventCaltype = serial_simpleRangeEventCal.Excel_type_.ValueStr;
            this.simpleRangeEventCalViewModel_ = SimpleRangeEventCalViewModel.CreateSimpleRangeEventCal(simpleRangeEventCaltype);
            this.simpleRangeEventCalViewModel_.setFromSerial(serial_simpleRangeEventCal);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_AutoCallRangeReturnTrigger.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            this.isExpired_ = serial_AutoCallRangeReturnTrigger.IsExpired_.ValueStr;
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

