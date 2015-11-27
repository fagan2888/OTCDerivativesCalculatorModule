using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class DailyIntervalViewModel : DateInformationViewModel
    {

        
    
        public DailyIntervalViewModel() { }
        
    
        #region ObservationStartDate_
        private string observationStartDate_;
        public string ObservationStartDate_
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
        private string observationEndDate_;
        public string ObservationEndDate_
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
                    xmlWriter.WriteElementString("observationStartDate" , this.observationStartDate_);
                    
                    xmlWriter.WriteElementString("observationEndDate" , this.observationEndDate_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.DateInformation serial_DateInformation = serial_Class as FpmlSerializedCSharp.DateInformation;
            FpmlSerializedCSharp.DailyInterval serial_DailyInterval = serial_DateInformation.DailyInterval_;
        
            this.observationStartDate_ = serial_DailyInterval.ObservationStartDate_.ValueStr;
            
            this.observationEndDate_ = serial_DailyInterval.ObservationEndDate_.ValueStr;

            //this.view_ = new DailyIntervalView();
            //this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

