using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class StepDownNoKIPayoffViewModel : PayoffInfoViewModel
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
        
        public StepDownNoKIPayoffViewModel() { }
        
        #region EventTriggerListViewModel_
        private EventTriggerListViewModel eventTriggerListViewModel_;
        public EventTriggerListViewModel EventTriggerListViewModel_
        {
            get { return this.eventTriggerListViewModel_; }
            set
            {
                if (this.eventTriggerListViewModel_ != value)
                {
                    this.eventTriggerListViewModel_ = value;
                    this.NotifyPropertyChanged("EventTriggerListViewModel_");
                }
            }
        }
        #endregion
        
        #region NoAutoCallReturnTriggerViewModel_
        private NoAutoCallReturnTriggerViewModel noAutoCallReturnTriggerViewModel_;
        public NoAutoCallReturnTriggerViewModel NoAutoCallReturnTriggerViewModel_
        {
            get { return this.noAutoCallReturnTriggerViewModel_; }
            set
            {
                if (this.noAutoCallReturnTriggerViewModel_ != value)
                {
                    this.noAutoCallReturnTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("NoAutoCallReturnTriggerViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("payoffInfo");
                xmlWriter.WriteElementString("type" , "stepDownNoKIPayoff");
                xmlWriter.WriteStartElement("stepDownNoKIPayoff");
                    eventTriggerListViewModel_.buildXml(xmlWriter);
                    
                    noAutoCallReturnTriggerViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new StepDownNoKIPayoffView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffInfo serial_PayoffInfo = serial_Class as FpmlSerializedCSharp.PayoffInfo;
            FpmlSerializedCSharp.StepDownNoKIPayoff serial_StepDownNoKIPayoff = serial_PayoffInfo.StepDownNoKIPayoff_;
        
            FpmlSerializedCSharp.EventTriggerList serial_eventTriggerList = serial_StepDownNoKIPayoff.EventTriggerList_;
            string eventTriggerListtype = serial_eventTriggerList.Excel_type_.ValueStr;
            this.eventTriggerListViewModel_ = EventTriggerListViewModel.CreateEventTriggerList(eventTriggerListtype);
            this.eventTriggerListViewModel_.setFromSerial(serial_eventTriggerList);
            
            FpmlSerializedCSharp.NoAutoCallReturnTrigger serial_noAutoCallReturnTrigger = serial_StepDownNoKIPayoff.NoAutoCallReturnTrigger_;
            string noAutoCallReturnTriggertype = serial_noAutoCallReturnTrigger.Excel_type_.ValueStr;
            this.noAutoCallReturnTriggerViewModel_ = NoAutoCallReturnTriggerViewModel.CreateNoAutoCallReturnTrigger(noAutoCallReturnTriggertype);
            this.noAutoCallReturnTriggerViewModel_.setFromSerial(serial_noAutoCallReturnTrigger);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

