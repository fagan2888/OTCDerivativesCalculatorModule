using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class StandardPayoff_AViewModel : PayoffInfoAnalyticViewModel
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
        
        public StandardPayoff_AViewModel() { }
        
        #region EventTriggerList_AViewModel_
        private EventTriggerList_AViewModel eventTriggerList_AViewModel_;
        public EventTriggerList_AViewModel EventTriggerList_AViewModel_
        {
            get { return this.eventTriggerList_AViewModel_; }
            set
            {
                if (this.eventTriggerList_AViewModel_ != value)
                {
                    this.eventTriggerList_AViewModel_ = value;
                    this.NotifyPropertyChanged("EventTriggerList_AViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("payoffInfoAnalytic");
                xmlWriter.WriteElementString("type" , "standardPayoff_A");
                xmlWriter.WriteStartElement("standardPayoff_A");
                    eventTriggerList_AViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new StandardPayoff_AView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffInfoAnalytic serial_PayoffInfoAnalytic = serial_Class as FpmlSerializedCSharp.PayoffInfoAnalytic;
            FpmlSerializedCSharp.StandardPayoff_A serial_StandardPayoff_A = serial_PayoffInfoAnalytic.StandardPayoff_A_;
        
            FpmlSerializedCSharp.EventTriggerList_A serial_eventTriggerList_A = serial_StandardPayoff_A.EventTriggerList_A_;
            string eventTriggerList_Atype = serial_eventTriggerList_A.Excel_type_.ValueStr;
            this.eventTriggerList_AViewModel_ = EventTriggerList_AViewModel.CreateEventTriggerList_A(eventTriggerList_Atype);
            this.eventTriggerList_AViewModel_.setFromSerial(serial_eventTriggerList_A);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

