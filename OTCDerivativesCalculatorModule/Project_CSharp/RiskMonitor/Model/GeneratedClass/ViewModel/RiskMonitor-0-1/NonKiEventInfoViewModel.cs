using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class NonKiEventInfoViewModel : IXmlData
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
        
        public NonKiEventInfoViewModel() { }
        
        #region EventTriggerViewModel_
        private EventTriggerViewModel eventTriggerViewModel_;
        public EventTriggerViewModel EventTriggerViewModel_
        {
            get { return this.eventTriggerViewModel_; }
            set
            {
                if (this.eventTriggerViewModel_ != value)
                {
                    this.eventTriggerViewModel_ = value;
                    this.NotifyPropertyChanged("EventTriggerViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "nonKiEventInfo");
                xmlWriter.WriteStartElement("nonKiEventInfo");
                    eventTriggerViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new NonKiEventInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.NonKiEventInfo serial_NonKiEventInfo = serial_Class as FpmlSerializedCSharp.NonKiEventInfo;
        
            FpmlSerializedCSharp.EventTrigger serial_eventTrigger = serial_NonKiEventInfo.EventTrigger_;
            string eventTriggertype = serial_eventTrigger.Excel_type_.ValueStr;
            this.eventTriggerViewModel_ = EventTriggerViewModel.CreateEventTrigger(eventTriggertype);
            this.eventTriggerViewModel_.setFromSerial(serial_eventTrigger);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

