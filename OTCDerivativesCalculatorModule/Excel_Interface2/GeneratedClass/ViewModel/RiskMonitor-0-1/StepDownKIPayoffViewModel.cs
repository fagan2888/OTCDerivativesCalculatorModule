using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class StepDownKIPayoffViewModel : PayoffInfoViewModel
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
        
        public StepDownKIPayoffViewModel() { }
        
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
        
        #region KiEventInfoViewModel_
        private KiEventInfoViewModel kiEventInfoViewModel_;
        public KiEventInfoViewModel KiEventInfoViewModel_
        {
            get { return this.kiEventInfoViewModel_; }
            set
            {
                if (this.kiEventInfoViewModel_ != value)
                {
                    this.kiEventInfoViewModel_ = value;
                    this.NotifyPropertyChanged("KiEventInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region NonKiEventInfoViewModel_
        private NonKiEventInfoViewModel nonKiEventInfoViewModel_;
        public NonKiEventInfoViewModel NonKiEventInfoViewModel_
        {
            get { return this.nonKiEventInfoViewModel_; }
            set
            {
                if (this.nonKiEventInfoViewModel_ != value)
                {
                    this.nonKiEventInfoViewModel_ = value;
                    this.NotifyPropertyChanged("NonKiEventInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("payoffInfo");
                xmlWriter.WriteElementString("excel_type" , "stepDownKIPayoff");
                xmlWriter.WriteStartElement("stepDownKIPayoff");
                    eventTriggerListViewModel_.buildXml(xmlWriter);
                    
                    kiEventInfoViewModel_.buildXml(xmlWriter);
                    
                    nonKiEventInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new StepDownKIPayoffView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.PayoffInfo serial_PayoffInfo = serial_Class as FpmlSerializedCSharp.PayoffInfo;
            FpmlSerializedCSharp.StepDownKIPayoff serial_StepDownKIPayoff = serial_PayoffInfo.StepDownKIPayoff_;
        
            FpmlSerializedCSharp.EventTriggerList serial_eventTriggerList = serial_StepDownKIPayoff.EventTriggerList_;
            string eventTriggerListtype = serial_eventTriggerList.Excel_type_.ValueStr;
            this.eventTriggerListViewModel_ = EventTriggerListViewModel.CreateEventTriggerList(eventTriggerListtype);
            this.eventTriggerListViewModel_.setFromSerial(serial_eventTriggerList);
            
            FpmlSerializedCSharp.KiEventInfo serial_kiEventInfo = serial_StepDownKIPayoff.KiEventInfo_;
            string kiEventInfotype = serial_kiEventInfo.Excel_type_.ValueStr;
            this.kiEventInfoViewModel_ = KiEventInfoViewModel.CreateKiEventInfo(kiEventInfotype);
            this.kiEventInfoViewModel_.setFromSerial(serial_kiEventInfo);
            
            FpmlSerializedCSharp.NonKiEventInfo serial_nonKiEventInfo = serial_StepDownKIPayoff.NonKiEventInfo_;
            string nonKiEventInfotype = serial_nonKiEventInfo.Excel_type_.ValueStr;
            this.nonKiEventInfoViewModel_ = NonKiEventInfoViewModel.CreateNonKiEventInfo(nonKiEventInfotype);
            this.nonKiEventInfoViewModel_.setFromSerial(serial_nonKiEventInfo);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

