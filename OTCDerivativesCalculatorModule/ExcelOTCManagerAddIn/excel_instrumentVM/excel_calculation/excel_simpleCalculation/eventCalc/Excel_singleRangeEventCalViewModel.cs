using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class Excel_singleRangeEventCalViewModel : Excel_eventCalcViewModel
    {
        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion
        
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
        
        public Excel_singleRangeEventCalViewModel() { }
        
        #region LowerRng_
        private string lowerRng_;
        public string LowerRng_
        {
            get { return this.lowerRng_; }
            set
            {
                if (this.lowerRng_ != value)
                {
                    this.lowerRng_ = value;
                    this.NotifyPropertyChanged("LowerRng_");
                }
            }
        }
        #endregion

        #region Excel_underlyingCalcID_
        private Excel_underlyingCalcIDViewModel excel_underlyingCalcID_;
        public Excel_underlyingCalcIDViewModel Excel_underlyingCalcID_
        {
            get { return this.excel_underlyingCalcID_; }
            set
            {
                if (this.excel_underlyingCalcID_ != value)
                {
                    this.excel_underlyingCalcID_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcID_");
                }
            }
        }
        #endregion

        #region UpperRng_
        private string upperRng_;
        public string UpperRng_
        {
            get { return this.upperRng_; }
            set
            {
                if (this.upperRng_ != value)
                {
                    this.upperRng_ = value;
                    this.NotifyPropertyChanged("UpperRng_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_eventCal");
                xmlWriter.WriteElementString("type" , "excel_singleRangeEventCal");
                xmlWriter.WriteStartElement("excel_singleRangeEventCal");
                    xmlWriter.WriteElementString("lowerRng" , this.lowerRng_);
                    
                    xmlWriter.WriteElementString("upperRng" , this.upperRng_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_eventCal serial_Excel_eventCal = serial_Class as FpmlSerializedCSharp.Excel_eventCal;
            FpmlSerializedCSharp.Excel_singleRangeEventCal serial_Excel_singleRangeEventCal = serial_Excel_eventCal.Excel_singleRangeEventCal_;
        
            this.lowerRng_ = serial_Excel_singleRangeEventCal.LowerRng_.ValueStr;
            
            this.upperRng_ = serial_Excel_singleRangeEventCal.UpperRng_.ValueStr;
            
            //this.view_ = new Excel_singleRangeEventCalcView();
            this.view_.DataContext = this;
        }
    
    }
    
}

