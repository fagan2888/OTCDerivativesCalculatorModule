using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class DailyIntervalViewModel : DateInformationViewModel
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
        
        public DailyIntervalViewModel() { }
        
        #region ObservationStartDate_
        private DateTime observationStartDate_;
        public DateTime ObservationStartDate_
        {
            get { return this.observationStartDate_; }
            set
            {
                if (this.observationStartDate_ != value)
                {
                    this.observationStartDate_ = value;
                    this.NotifyPropertyChanged("ObservationStartDate_");
                }
            }
        }
        #endregion
        
        #region ObservationEndDate_
        private DateTime observationEndDate_;
        public DateTime ObservationEndDate_
        {
            get { return this.observationEndDate_; }
            set
            {
                if (this.observationEndDate_ != value)
                {
                    this.observationEndDate_ = value;
                    this.NotifyPropertyChanged("ObservationEndDate_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("dateInformation");
                xmlWriter.WriteElementString("type" , "dailyInterval");
                xmlWriter.WriteStartElement("dailyInterval");
                    xmlWriter.WriteElementString("observationStartDate" , StringConverter.xmlDateTimeToDateString(this.observationStartDate_));
                    
                    xmlWriter.WriteElementString("observationEndDate" , StringConverter.xmlDateTimeToDateString(this.observationEndDate_));
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new DailyIntervalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.DateInformation serial_DateInformation = serial_Class as FpmlSerializedCSharp.DateInformation;
            FpmlSerializedCSharp.DailyInterval serial_DailyInterval = serial_DateInformation.DailyInterval_;
        
            this.observationStartDate_ = StringConverter.xmlDateToDateTime(serial_DailyInterval.ObservationStartDate_.ValueStr);
            
            this.observationEndDate_ = StringConverter.xmlDateToDateTime(serial_DailyInterval.ObservationEndDate_.ValueStr);
            
        }
        
        
    
        
    
        
    
    }
    
}

