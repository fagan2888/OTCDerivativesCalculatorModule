using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_singleBarrierEventCalViewModel : Excel_eventCalcInfoViewModel
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
        
        public Excel_singleBarrierEventCalViewModel() { }
        
        #region LowerTrigger_
        private string lowerTrigger_;
        public string LowerTrigger_
        {
            get { return this.lowerTrigger_; }
            set
            {
                if (this.lowerTrigger_ != value)
                {
                    this.lowerTrigger_ = value;
                    this.NotifyPropertyChanged("LowerTrigger_");
                }
            }
        }
        #endregion
        
        #region UpperTrigger_
        private string upperTrigger_;
        public string UpperTrigger_
        {
            get { return this.upperTrigger_; }
            set
            {
                if (this.upperTrigger_ != value)
                {
                    this.upperTrigger_ = value;
                    this.NotifyPropertyChanged("UpperTrigger_");
                }
            }
        }
        #endregion
        
        #region Excel_underlyingCalcIDViewModel_
        private Excel_underlyingCalcIDViewModel excel_underlyingCalcIDViewModel_;
        public Excel_underlyingCalcIDViewModel Excel_underlyingCalcIDViewModel_
        {
            get { return this.excel_underlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_underlyingCalcIDViewModel_ != value)
                {
                    this.excel_underlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcIDViewModel_");
                }
            }
        }
        #endregion
        
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
            xmlWriter.WriteStartElement("excel_eventCalcInfo");
                xmlWriter.WriteElementString("type" , "excel_singleBarrierEventCal");
                xmlWriter.WriteStartElement("excel_singleBarrierEventCal");
                    xmlWriter.WriteElementString("lowerTrigger" , this.lowerTrigger_);
                    
                    xmlWriter.WriteElementString("upperTrigger" , this.upperTrigger_);
                    
                    excel_underlyingCalcIDViewModel_.buildXml(xmlWriter);
                    
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
            Control v = new Excel_singleBarrierEventCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_eventCalcInfo serial_Excel_eventCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_eventCalcInfo;
            FpmlSerializedCSharp.Excel_singleBarrierEventCal serial_Excel_singleBarrierEventCal = serial_Excel_eventCalcInfo.Excel_singleBarrierEventCal_;
        
            this.lowerTrigger_ = serial_Excel_singleBarrierEventCal.LowerTrigger_.ValueStr;
            
            this.upperTrigger_ = serial_Excel_singleBarrierEventCal.UpperTrigger_.ValueStr;
            
            FpmlSerializedCSharp.Excel_underlyingCalcID serial_excel_underlyingCalcID = serial_Excel_singleBarrierEventCal.Excel_underlyingCalcID_;
            string excel_underlyingCalcIDtype = serial_excel_underlyingCalcID.Excel_type_.ValueStr;
            this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(excel_underlyingCalcIDtype);
            this.excel_underlyingCalcIDViewModel_.setFromSerial(serial_excel_underlyingCalcID);
            
            this.observationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_singleBarrierEventCal.ObservationStartDate_.ValueStr);
            
            this.observationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_singleBarrierEventCal.ObservationEndDate_.ValueStr);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

