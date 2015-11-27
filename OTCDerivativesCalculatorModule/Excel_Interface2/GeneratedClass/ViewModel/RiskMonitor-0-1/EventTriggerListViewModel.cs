using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class EventTriggerListViewModel : IXmlData
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
        
        public EventTriggerListViewModel() { }
        
        #region EventTriggerViewModel_
        private ObservableCollection<EventTriggerViewModel> eventTriggerViewModel_;
        public ObservableCollection<EventTriggerViewModel> EventTriggerViewModel_
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
                xmlWriter.WriteElementString("excel_type" , "eventTriggerList");
                xmlWriter.WriteStartElement("eventTriggerList");
                    foreach (var item in eventTriggerViewModel_)
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
            Control v = new EventTriggerListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTriggerList serial_EventTriggerList = serial_Class as FpmlSerializedCSharp.EventTriggerList;
        
            List<FpmlSerializedCSharp.EventTrigger> serial_eventTrigger = serial_EventTriggerList.EventTrigger_;
            this.eventTriggerViewModel_ = new ObservableCollection<EventTriggerViewModel>();
            foreach (var item in serial_eventTrigger)
            {
                string type = item.Excel_type_.ValueStr;
                EventTriggerViewModel viewModel = EventTriggerViewModel.CreateEventTrigger(type);
                viewModel.setFromSerial(item);
                this.eventTriggerViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

