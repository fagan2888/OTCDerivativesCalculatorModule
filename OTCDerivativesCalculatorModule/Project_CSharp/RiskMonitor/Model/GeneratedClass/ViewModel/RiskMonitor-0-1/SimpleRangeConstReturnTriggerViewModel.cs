using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class SimpleRangeConstReturnTriggerViewModel : EventTriggerViewModel
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
        
        public SimpleRangeConstReturnTriggerViewModel() { }
        
        #region DateOrder_
        private string dateOrder_;
        public string DateOrder_
        {
            get { return this.dateOrder_; }
            set
            {
                if (this.dateOrder_ != value)
                {
                    this.dateOrder_ = value;
                    this.NotifyPropertyChanged("DateOrder_");
                }
            }
        }
        #endregion
        
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
        
        #region ConstReturn_
        private string constReturn_;
        public string ConstReturn_
        {
            get { return this.constReturn_; }
            set
            {
                if (this.constReturn_ != value)
                {
                    this.constReturn_ = value;
                    this.NotifyPropertyChanged("ConstReturn_");
                }
            }
        }
        #endregion
        
        #region AverageDays_
        private string averageDays_;
        public string AverageDays_
        {
            get { return this.averageDays_; }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                    this.NotifyPropertyChanged("AverageDays_");
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
                xmlWriter.WriteElementString("type" , "simpleRangeConstReturnTrigger");
                xmlWriter.WriteStartElement("simpleRangeConstReturnTrigger");
                    xmlWriter.WriteElementString("dateOrder" , this.dateOrder_);
                    
                    simpleRangeEventCalViewModel_.buildXml(xmlWriter);
                    
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("constReturn" , this.constReturn_);
                    
                    xmlWriter.WriteElementString("averageDays" , this.averageDays_);
                    
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
            Control v = new SimpleRangeConstReturnTriggerView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTrigger serial_EventTrigger = serial_Class as FpmlSerializedCSharp.EventTrigger;
            FpmlSerializedCSharp.SimpleRangeConstReturnTrigger serial_SimpleRangeConstReturnTrigger = serial_EventTrigger.SimpleRangeConstReturnTrigger_;
        
            this.dateOrder_ = serial_SimpleRangeConstReturnTrigger.DateOrder_.ValueStr;
            
            FpmlSerializedCSharp.SimpleRangeEventCal serial_simpleRangeEventCal = serial_SimpleRangeConstReturnTrigger.SimpleRangeEventCal_;
            string simpleRangeEventCaltype = serial_simpleRangeEventCal.Excel_type_.ValueStr;
            this.simpleRangeEventCalViewModel_ = SimpleRangeEventCalViewModel.CreateSimpleRangeEventCal(simpleRangeEventCaltype);
            this.simpleRangeEventCalViewModel_.setFromSerial(serial_simpleRangeEventCal);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_SimpleRangeConstReturnTrigger.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
            this.constReturn_ = serial_SimpleRangeConstReturnTrigger.ConstReturn_.ValueStr;
            
            this.averageDays_ = serial_SimpleRangeConstReturnTrigger.AverageDays_.ValueStr;
            
            this.isExpired_ = serial_SimpleRangeConstReturnTrigger.IsExpired_.ValueStr;
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

