using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_simpleKiEventCalcViewModel : Excel_kiEventCalculationViewModel
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
        
        public Excel_simpleKiEventCalcViewModel() { }
        
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
        
        #region PayoffDate_
        private DateTime payoffDate_;
        public DateTime PayoffDate_
        {
            get { return this.payoffDate_; }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                    this.NotifyPropertyChanged("PayoffDate_");
                }
            }
        }
        #endregion
        
        #region Excel_eventCalcInfoViewModel_
        private Excel_eventCalcInfoViewModel excel_eventCalcInfoViewModel_;
        public Excel_eventCalcInfoViewModel Excel_eventCalcInfoViewModel_
        {
            get { return this.excel_eventCalcInfoViewModel_; }
            set
            {
                if (this.excel_eventCalcInfoViewModel_ != value)
                {
                    this.excel_eventCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_eventCalcInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_occReturnCalcInfoViewModel_
        private Excel_occReturnCalcInfoViewModel excel_occReturnCalcInfoViewModel_;
        public Excel_occReturnCalcInfoViewModel Excel_occReturnCalcInfoViewModel_
        {
            get { return this.excel_occReturnCalcInfoViewModel_; }
            set
            {
                if (this.excel_occReturnCalcInfoViewModel_ != value)
                {
                    this.excel_occReturnCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_occReturnCalcInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_noOccReturnCalcInfoViewModel_
        private Excel_noOccReturnCalcInfoViewModel excel_noOccReturnCalcInfoViewModel_;
        public Excel_noOccReturnCalcInfoViewModel Excel_noOccReturnCalcInfoViewModel_
        {
            get { return this.excel_noOccReturnCalcInfoViewModel_; }
            set
            {
                if (this.excel_noOccReturnCalcInfoViewModel_ != value)
                {
                    this.excel_noOccReturnCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_noOccReturnCalcInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_kiEventCalculation");
                xmlWriter.WriteElementString("type" , "excel_simpleKiEventCalc");
                xmlWriter.WriteStartElement("excel_simpleKiEventCalc");
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                    excel_eventCalcInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_occReturnCalcInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_noOccReturnCalcInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_simpleKiEventCalcView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_kiEventCalculation serial_Excel_kiEventCalculation = serial_Class as FpmlSerializedCSharp.Excel_kiEventCalculation;
            FpmlSerializedCSharp.Excel_simpleKiEventCalc serial_Excel_simpleKiEventCalc = serial_Excel_kiEventCalculation.Excel_simpleKiEventCalc_;
        
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_simpleKiEventCalc.EventDate_.ValueStr);
            
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_simpleKiEventCalc.PayoffDate_.ValueStr);
            
            FpmlSerializedCSharp.Excel_eventCalcInfo serial_excel_eventCalcInfo = serial_Excel_simpleKiEventCalc.Excel_eventCalcInfo_;
            string excel_eventCalcInfotype = serial_excel_eventCalcInfo.Excel_type_.ValueStr;
            this.excel_eventCalcInfoViewModel_ = Excel_eventCalcInfoViewModel.CreateExcel_eventCalcInfo(excel_eventCalcInfotype);
            this.excel_eventCalcInfoViewModel_.setFromSerial(serial_excel_eventCalcInfo);
            
            FpmlSerializedCSharp.Excel_occReturnCalcInfo serial_excel_occReturnCalcInfo = serial_Excel_simpleKiEventCalc.Excel_occReturnCalcInfo_;
            string excel_occReturnCalcInfotype = serial_excel_occReturnCalcInfo.Excel_type_.ValueStr;
            this.excel_occReturnCalcInfoViewModel_ = Excel_occReturnCalcInfoViewModel.CreateExcel_occReturnCalcInfo(excel_occReturnCalcInfotype);
            this.excel_occReturnCalcInfoViewModel_.setFromSerial(serial_excel_occReturnCalcInfo);
            
            FpmlSerializedCSharp.Excel_noOccReturnCalcInfo serial_excel_noOccReturnCalcInfo = serial_Excel_simpleKiEventCalc.Excel_noOccReturnCalcInfo_;
            string excel_noOccReturnCalcInfotype = serial_excel_noOccReturnCalcInfo.Excel_type_.ValueStr;
            this.excel_noOccReturnCalcInfoViewModel_ = Excel_noOccReturnCalcInfoViewModel.CreateExcel_noOccReturnCalcInfo(excel_noOccReturnCalcInfotype);
            this.excel_noOccReturnCalcInfoViewModel_.setFromSerial(serial_excel_noOccReturnCalcInfo);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

