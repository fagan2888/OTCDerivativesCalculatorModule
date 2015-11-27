using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class EventTriggerListViewModel : IXmlData
    {
        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion
    
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
                xmlWriter.WriteElementString("type" , "eventTriggerList");
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
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventTriggerList serial_EventTriggerList = serial_Class as FpmlSerializedCSharp.EventTriggerList;
        
            List<FpmlSerializedCSharp.EventTrigger> serial_eventTrigger = serial_EventTriggerList.EventTrigger_;
            this.eventTriggerViewModel_ = new ObservableCollection<EventTriggerViewModel>();
            foreach (var item in serial_eventTrigger)
            {
                string type = item.Type_.ValueStr;
                EventTriggerViewModel viewModel = EventTriggerViewModel.CreateEventTrigger(type);
                viewModel.setFromSerial(item);
                this.eventTriggerViewModel_.Add(viewModel);
            }
            
            //this.view_ = new EventTriggerListView();
            this.view_.DataContext = this;
        }
        
        
    
            //#region SelectEventTriggerInfo_
            //private string selectEventTriggerInfo_;
            //public string SelectEventTriggerInfo_
            //{
            //    get { return this.selectEventTriggerInfo_; }
            //    set
            //    {
            //        if (this.selectEventTriggerInfo_ != value)
            //        {
            //            this.selectEventTriggerInfo_ = value;
            //            this.NotifyPropertyChanged("SelectEventTriggerInfo_");
            //        }
            //    }
            //}
            //#endregion
            
            //public void selectEventTriggerInfo(string typeStr)
            //{
            //    this.eventTriggerViewModel_ = EventTriggerViewModel.CreateEventTrigger(typeStr);
            //    this.view_.DataContext = this;
            //}
            
        
    
        
    
    }
    
}

