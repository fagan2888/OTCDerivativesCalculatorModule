using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class MonthlyAutoCallRedemViewModel : RedemptionInfoViewModel
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
        
        public MonthlyAutoCallRedemViewModel() { }
        
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("redemptionInfo");
                xmlWriter.WriteElementString("type" , "monthlyAutoCallRedem");
                xmlWriter.WriteStartElement("monthlyAutoCallRedem");
                    foreach (var item in eventTriggerViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new MonthlyAutoCallRedemView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RedemptionInfo serial_RedemptionInfo = serial_Class as FpmlSerializedCSharp.RedemptionInfo;
            FpmlSerializedCSharp.MonthlyAutoCallRedem serial_MonthlyAutoCallRedem = serial_RedemptionInfo.MonthlyAutoCallRedem_;
        
            List<FpmlSerializedCSharp.EventTrigger> serial_eventTrigger = serial_MonthlyAutoCallRedem.EventTrigger_;
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

