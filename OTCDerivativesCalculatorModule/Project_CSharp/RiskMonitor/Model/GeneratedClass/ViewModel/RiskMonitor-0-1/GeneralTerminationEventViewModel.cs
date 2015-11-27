using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class GeneralTerminationEventViewModel : IXmlData
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
        
        public GeneralTerminationEventViewModel() { }
        
        #region DetailTerminationType_
        private string detailTerminationType_;
        public string DetailTerminationType_
        {
            get { return this.detailTerminationType_; }
            set
            {
                if (this.detailTerminationType_ != value)
                {
                    this.detailTerminationType_ = value;
                    this.NotifyPropertyChanged("DetailTerminationType_");
                }
            }
        }
        #endregion
        
        #region EventDate_
        private DateTime eventDate_;
        public DateTime EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
                }
            }
        }
        #endregion
        
        #region GeneralTerminationEventDetailViewModel_
        private GeneralTerminationEventDetailViewModel generalTerminationEventDetailViewModel_;
        public GeneralTerminationEventDetailViewModel GeneralTerminationEventDetailViewModel_
        {
            get { return this.generalTerminationEventDetailViewModel_; }
            set
            {
                if (this.generalTerminationEventDetailViewModel_ != value)
                {
                    this.generalTerminationEventDetailViewModel_ = value;
                    this.NotifyPropertyChanged("GeneralTerminationEventDetailViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "generalTerminationEvent");
                xmlWriter.WriteStartElement("generalTerminationEvent");
                    xmlWriter.WriteElementString("detailTerminationType" , this.detailTerminationType_);
                    
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    generalTerminationEventDetailViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new GeneralTerminationEventView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.GeneralTerminationEvent serial_GeneralTerminationEvent = serial_Class as FpmlSerializedCSharp.GeneralTerminationEvent;
        
            this.detailTerminationType_ = serial_GeneralTerminationEvent.DetailTerminationType_.ValueStr;
            
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_GeneralTerminationEvent.EventDate_.ValueStr);
            
            FpmlSerializedCSharp.GeneralTerminationEventDetail serial_generalTerminationEventDetail = serial_GeneralTerminationEvent.GeneralTerminationEventDetail_;
            string generalTerminationEventDetailtype = serial_generalTerminationEventDetail.Excel_type_.ValueStr;
            this.generalTerminationEventDetailViewModel_ = GeneralTerminationEventDetailViewModel.CreateGeneralTerminationEventDetail(generalTerminationEventDetailtype);
            this.generalTerminationEventDetailViewModel_.setFromSerial(serial_generalTerminationEventDetail);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

