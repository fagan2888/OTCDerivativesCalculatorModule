using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class AtMostEventCalViewModel : JointEventCalculationViewModel
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
        
        public AtMostEventCalViewModel() { }
        
        #region Num_
        private string num_;
        public string Num_
        {
            get { return this.num_; }
            set
            {
                if (this.num_ != value)
                {
                    this.num_ = value;
                    this.NotifyPropertyChanged("Num_");
                }
            }
        }
        #endregion
        
        #region EventCalculationListViewModel_
        private EventCalculationListViewModel eventCalculationListViewModel_;
        public EventCalculationListViewModel EventCalculationListViewModel_
        {
            get { return this.eventCalculationListViewModel_; }
            set
            {
                if (this.eventCalculationListViewModel_ != value)
                {
                    this.eventCalculationListViewModel_ = value;
                    this.NotifyPropertyChanged("EventCalculationListViewModel_");
                }
            }
        }
        #endregion
        
        #region Complement_
        private string complement_;
        public string Complement_
        {
            get { return this.complement_; }
            set
            {
                if (this.complement_ != value)
                {
                    this.complement_ = value;
                    this.NotifyPropertyChanged("Complement_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("jointEventCalculation");
                xmlWriter.WriteElementString("excel_type" , "atMostEventCal");
                xmlWriter.WriteStartElement("atMostEventCal");
                    xmlWriter.WriteElementString("num" , this.num_);
                    
                    eventCalculationListViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("complement" , this.complement_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new AtMostEventCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.JointEventCalculation serial_JointEventCalculation = serial_Class as FpmlSerializedCSharp.JointEventCalculation;
            FpmlSerializedCSharp.AtMostEventCal serial_AtMostEventCal = serial_JointEventCalculation.AtMostEventCal_;
        
            this.num_ = serial_AtMostEventCal.Num_.ValueStr;
            
            FpmlSerializedCSharp.EventCalculationList serial_eventCalculationList = serial_AtMostEventCal.EventCalculationList_;
            string eventCalculationListtype = serial_eventCalculationList.Excel_type_.ValueStr;
            this.eventCalculationListViewModel_ = EventCalculationListViewModel.CreateEventCalculationList(eventCalculationListtype);
            this.eventCalculationListViewModel_.setFromSerial(serial_eventCalculationList);
            
            this.complement_ = serial_AtMostEventCal.Complement_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}
