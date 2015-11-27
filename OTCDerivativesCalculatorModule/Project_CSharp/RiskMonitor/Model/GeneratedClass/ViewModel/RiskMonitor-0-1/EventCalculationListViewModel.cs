using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class EventCalculationListViewModel : IXmlData
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
        
        public EventCalculationListViewModel() { }
        
        #region EventCalculationViewModel_
        private ObservableCollection<EventCalculationViewModel> eventCalculationViewModel_;
        public ObservableCollection<EventCalculationViewModel> EventCalculationViewModel_
        {
            get { return this.eventCalculationViewModel_; }
            set
            {
                if (this.eventCalculationViewModel_ != value)
                {
                    this.eventCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("EventCalculationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "eventCalculationList");
                xmlWriter.WriteStartElement("eventCalculationList");
                    foreach (var item in eventCalculationViewModel_)
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
            Control v = new EventCalculationListView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.EventCalculationList serial_EventCalculationList = serial_Class as FpmlSerializedCSharp.EventCalculationList;
        
            List<FpmlSerializedCSharp.EventCalculation> serial_eventCalculation = serial_EventCalculationList.EventCalculation_;
            this.eventCalculationViewModel_ = new ObservableCollection<EventCalculationViewModel>();
            foreach (var item in serial_eventCalculation)
            {
                string type = item.Excel_type_.ValueStr;
                EventCalculationViewModel viewModel = EventCalculationViewModel.CreateEventCalculation(type);
                viewModel.setFromSerial(item);
                this.eventCalculationViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

