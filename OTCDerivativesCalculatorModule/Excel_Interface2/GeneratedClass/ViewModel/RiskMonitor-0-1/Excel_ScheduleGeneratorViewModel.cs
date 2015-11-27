using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_ScheduleGeneratorViewModel : IXmlData
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
        
        public Excel_ScheduleGeneratorViewModel() { }
        
        #region EffectiveDate_
        private DateTime effectiveDate_;
        public DateTime EffectiveDate_
        {
            get { return this.effectiveDate_; }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                    this.NotifyPropertyChanged("EffectiveDate_");
                }
            }
        }
        #endregion
        
        #region MaturityDate_
        private DateTime maturityDate_;
        public DateTime MaturityDate_
        {
            get { return this.maturityDate_; }
            set
            {
                if (this.maturityDate_ != value)
                {
                    this.maturityDate_ = value;
                    this.NotifyPropertyChanged("MaturityDate_");
                }
            }
        }
        #endregion
        
        #region Tenor_
        private string tenor_;
        public string Tenor_
        {
            get { return this.tenor_; }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                    this.NotifyPropertyChanged("Tenor_");
                }
            }
        }
        #endregion
        
        #region PaymentDays_
        private string paymentDays_;
        public string PaymentDays_
        {
            get { return this.paymentDays_; }
            set
            {
                if (this.paymentDays_ != value)
                {
                    this.paymentDays_ = value;
                    this.NotifyPropertyChanged("PaymentDays_");
                }
            }
        }
        #endregion
        
        #region Calendars_
        private ObservableCollection<string> calendars_;
        public ObservableCollection<string> Calendars_
        {
            get { return this.calendars_; }
            set
            {
                if (this.calendars_ != value)
                {
                    this.calendars_ = value;
                    this.NotifyPropertyChanged("Calendars_");
                }
            }
        }
        #endregion
        
        #region BusinessDayConvention_
        private string businessDayConvention_;
        public string BusinessDayConvention_
        {
            get { return this.businessDayConvention_; }
            set
            {
                if (this.businessDayConvention_ != value)
                {
                    this.businessDayConvention_ = value;
                    this.NotifyPropertyChanged("BusinessDayConvention_");
                }
            }
        }
        #endregion
        
        #region DateGeneration_
        private string dateGeneration_;
        public string DateGeneration_
        {
            get { return this.dateGeneration_; }
            set
            {
                if (this.dateGeneration_ != value)
                {
                    this.dateGeneration_ = value;
                    this.NotifyPropertyChanged("DateGeneration_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_ScheduleGenerator");
                xmlWriter.WriteStartElement("excel_ScheduleGenerator");
                    xmlWriter.WriteElementString("effectiveDate" , StringConverter.xmlDateTimeToDateString(this.effectiveDate_));
                    
                    xmlWriter.WriteElementString("maturityDate" , StringConverter.xmlDateTimeToDateString(this.maturityDate_));
                    
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                    xmlWriter.WriteElementString("paymentDays" , this.paymentDays_);
                    
                    xmlWriter.WriteElementString("calendars" , this.calendars_);
                    
                    xmlWriter.WriteElementString("businessDayConvention" , this.businessDayConvention_);
                    
                    xmlWriter.WriteElementString("dateGeneration" , this.dateGeneration_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_ScheduleGeneratorView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_ScheduleGenerator serial_Excel_ScheduleGenerator = serial_Class as FpmlSerializedCSharp.Excel_ScheduleGenerator;
        
            this.effectiveDate_ = StringConverter.xmlDateToDateTime(serial_Excel_ScheduleGenerator.EffectiveDate_.ValueStr);
            
            this.maturityDate_ = StringConverter.xmlDateToDateTime(serial_Excel_ScheduleGenerator.MaturityDate_.ValueStr);
            
            this.tenor_ = serial_Excel_ScheduleGenerator.Tenor_.ValueStr;
            
            this.paymentDays_ = serial_Excel_ScheduleGenerator.PaymentDays_.ValueStr;
            
            this.calendarsViewModel_ = new ObservableCollection<CalendarsViewModel>();
            foreach (var item in serial_Excel_ScheduleGenerator.Calendars_)
            {
                this.value_.Add(item.ValueStr);
            }
            
            this.businessDayConvention_ = serial_Excel_ScheduleGenerator.BusinessDayConvention_.ValueStr;
            
            this.dateGeneration_ = serial_Excel_ScheduleGenerator.DateGeneration_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

