using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_stepDownKI_subScheduleViewModel : IXmlData
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
        
        public Excel_stepDownKI_subScheduleViewModel() { }
        
        #region Excel_type_
        private string excel_type_;
        public string Excel_type_
        {
            get { return this.excel_type_; }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                    this.NotifyPropertyChanged("Excel_type_");
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
        
        #region Trigger_
        private string trigger_;
        public string Trigger_
        {
            get { return this.trigger_; }
            set
            {
                if (this.trigger_ != value)
                {
                    this.trigger_ = value;
                    this.NotifyPropertyChanged("Trigger_");
                }
            }
        }
        #endregion
        
        #region Coupon_
        private string coupon_;
        public string Coupon_
        {
            get { return this.coupon_; }
            set
            {
                if (this.coupon_ != value)
                {
                    this.coupon_ = value;
                    this.NotifyPropertyChanged("Coupon_");
                }
            }
        }
        #endregion
        
        #region AverageDays_
        private string averageDays_;
        public string AverageDays_
        {
            get { return this.averageDays_; }
            set
            {
                if (this.averageDays_ != value)
                {
                    this.averageDays_ = value;
                    this.NotifyPropertyChanged("AverageDays_");
                }
            }
        }
        #endregion
        
        #region UnderCalcType_
        private string underCalcType_;
        public string UnderCalcType_
        {
            get { return this.underCalcType_; }
            set
            {
                if (this.underCalcType_ != value)
                {
                    this.underCalcType_ = value;
                    this.NotifyPropertyChanged("UnderCalcType_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_stepDownKI_subSchedule");
                xmlWriter.WriteStartElement("excel_stepDownKI_subSchedule");
                    xmlWriter.WriteElementString("excel_type" , this.excel_type_);
                    
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("trigger" , this.trigger_);
                    
                    xmlWriter.WriteElementString("coupon" , this.coupon_);
                    
                    xmlWriter.WriteElementString("averageDays" , this.averageDays_);
                    
                    xmlWriter.WriteElementString("underCalcType" , this.underCalcType_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_stepDownKI_subScheduleView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_stepDownKI_subSchedule serial_Excel_stepDownKI_subSchedule = serial_Class as FpmlSerializedCSharp.Excel_stepDownKI_subSchedule;
        
            this.excel_type_ = serial_Excel_stepDownKI_subSchedule.Excel_type_.ValueStr;
            
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_stepDownKI_subSchedule.EventDate_.ValueStr);
            
            this.trigger_ = serial_Excel_stepDownKI_subSchedule.Trigger_.ValueStr;
            
            this.coupon_ = serial_Excel_stepDownKI_subSchedule.Coupon_.ValueStr;
            
            this.averageDays_ = serial_Excel_stepDownKI_subSchedule.AverageDays_.ValueStr;
            
            this.underCalcType_ = serial_Excel_stepDownKI_subSchedule.UnderCalcType_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

