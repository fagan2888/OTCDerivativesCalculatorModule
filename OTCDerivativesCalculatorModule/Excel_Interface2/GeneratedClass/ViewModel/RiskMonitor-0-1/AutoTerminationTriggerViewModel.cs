using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class AutoTerminationTriggerViewModel : IXmlData
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
        
        public AutoTerminationTriggerViewModel() { }
        
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "autoTerminationTrigger");
                xmlWriter.WriteStartElement("autoTerminationTrigger");
                    eventCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    returnCalculationInfoViewModel_.buildXml(xmlWriter);
                    
                    payoffDateInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new AutoTerminationTriggerView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.AutoTerminationTrigger serial_AutoTerminationTrigger = serial_Class as FpmlSerializedCSharp.AutoTerminationTrigger;
        
            FpmlSerializedCSharp.EventCalculationInfo serial_eventCalculationInfo = serial_AutoTerminationTrigger.EventCalculationInfo_;
            string eventCalculationInfotype = serial_eventCalculationInfo.Excel_type_.ValueStr;
            this.eventCalculationInfoViewModel_ = EventCalculationInfoViewModel.CreateEventCalculationInfo(eventCalculationInfotype);
            this.eventCalculationInfoViewModel_.setFromSerial(serial_eventCalculationInfo);
            
            FpmlSerializedCSharp.ReturnCalculationInfo serial_returnCalculationInfo = serial_AutoTerminationTrigger.ReturnCalculationInfo_;
            string returnCalculationInfotype = serial_returnCalculationInfo.Excel_type_.ValueStr;
            this.returnCalculationInfoViewModel_ = ReturnCalculationInfoViewModel.CreateReturnCalculationInfo(returnCalculationInfotype);
            this.returnCalculationInfoViewModel_.setFromSerial(serial_returnCalculationInfo);
            
            FpmlSerializedCSharp.PayoffDateInfo serial_payoffDateInfo = serial_AutoTerminationTrigger.PayoffDateInfo_;
            string payoffDateInfotype = serial_payoffDateInfo.Excel_type_.ValueStr;
            this.payoffDateInfoViewModel_ = PayoffDateInfoViewModel.CreatePayoffDateInfo(payoffDateInfotype);
            this.payoffDateInfoViewModel_.setFromSerial(serial_payoffDateInfo);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

