using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class GeneralScheduleViewModel : IXmlData
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
        
        public GeneralScheduleViewModel() { }
        
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
        
        #region DetailScheduleType_
        private string detailScheduleType_;
        public string DetailScheduleType_
        {
            get { return this.detailScheduleType_; }
            set
            {
                if (this.detailScheduleType_ != value)
                {
                    this.detailScheduleType_ = value;
                    this.NotifyPropertyChanged("DetailScheduleType_");
                }
            }
        }
        #endregion
        
        #region GeneralScheduleDeatilViewModel_
        private GeneralScheduleDeatilViewModel generalScheduleDeatilViewModel_;
        public GeneralScheduleDeatilViewModel GeneralScheduleDeatilViewModel_
        {
            get { return this.generalScheduleDeatilViewModel_; }
            set
            {
                if (this.generalScheduleDeatilViewModel_ != value)
                {
                    this.generalScheduleDeatilViewModel_ = value;
                    this.NotifyPropertyChanged("GeneralScheduleDeatilViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "generalSchedule");
                xmlWriter.WriteStartElement("generalSchedule");
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("detailScheduleType" , this.detailScheduleType_);
                    
                    generalScheduleDeatilViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new GeneralScheduleView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.GeneralSchedule serial_GeneralSchedule = serial_Class as FpmlSerializedCSharp.GeneralSchedule;
        
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_GeneralSchedule.EventDate_.ValueStr);
            
            this.detailScheduleType_ = serial_GeneralSchedule.DetailScheduleType_.ValueStr;
            
            FpmlSerializedCSharp.GeneralScheduleDeatil serial_generalScheduleDeatil = serial_GeneralSchedule.GeneralScheduleDeatil_;
            string generalScheduleDeatiltype = serial_generalScheduleDeatil.Excel_type_.ValueStr;
            this.generalScheduleDeatilViewModel_ = GeneralScheduleDeatilViewModel.CreateGeneralScheduleDeatil(generalScheduleDeatiltype);
            this.generalScheduleDeatilViewModel_.setFromSerial(serial_generalScheduleDeatil);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

