using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class EventTriggerList_AViewModel : IXmlData
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
        
        public EventTriggerList_AViewModel() { }
        
        #region EventTrigger_AViewModel_
        private ObservableCollection<EventTrigger_AViewModel> eventTrigger_AViewModel_;
        public ObservableCollection<EventTrigger_AViewModel> EventTrigger_AViewModel_
        {
            get { return this.eventTrigger_AViewModel_; }
            set
            {
                if (this.eventTrigger_AViewModel_ != value)
                {
                    this.eventTrigger_AViewModel_ = value;
                    this.NotifyPropertyChanged("EventTrigger_AViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "eventTriggerList_A");
                xmlWriter.WriteStartElement("eventTriggerList_A");
                    foreach (var item in eventTrigger_AViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new EventTriggerList_AView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTriggerList_A serial_EventTriggerList_A = serial_Class as FpmlSerializedCSharp.EventTriggerList_A;
        
            List<FpmlSerializedCSharp.EventTrigger_A> serial_eventTrigger_A = serial_EventTriggerList_A.EventTrigger_A_;
            this.eventTrigger_AViewModel_ = new ObservableCollection<EventTrigger_AViewModel>();
            foreach (var item in serial_eventTrigger_A)
            {
                string type = item.Excel_type_.ValueStr;
                EventTrigger_AViewModel viewModel = EventTrigger_AViewModel.CreateEventTrigger_A(type);
                viewModel.setFromSerial(item);
                this.eventTrigger_AViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

