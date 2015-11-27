using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_singleRangeEventCalViewModel : Excel_eventCalcInfoViewModel
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_eventCalcInfo");
                xmlWriter.WriteElementString("type" , "excel_singleRangeEventCal");
                xmlWriter.WriteStartElement("excel_singleRangeEventCal");
                    xmlWriter.WriteElementString("lowerRng" , this.lowerRng_);
                    
                    xmlWriter.WriteElementString("upperRng" , this.upperRng_);
                    
                    excel_underlyingCalcIDViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_singleRangeEventCalView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_eventCalcInfo serial_Excel_eventCalcInfo = serial_Class as FpmlSerializedCSharp.Excel_eventCalcInfo;
            FpmlSerializedCSharp.Excel_singleRangeEventCal serial_Excel_singleRangeEventCal = serial_Excel_eventCalcInfo.Excel_singleRangeEventCal_;
        
            this.lowerRng_ = serial_Excel_singleRangeEventCal.LowerRng_.ValueStr;
            
            this.upperRng_ = serial_Excel_singleRangeEventCal.UpperRng_.ValueStr;
            
            FpmlSerializedCSharp.Excel_underlyingCalcID serial_excel_underlyingCalcID = serial_Excel_singleRangeEventCal.Excel_underlyingCalcID_;
            string excel_underlyingCalcIDtype = serial_excel_underlyingCalcID.Excel_type_.ValueStr;
            this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(excel_underlyingCalcIDtype);
            this.excel_underlyingCalcIDViewModel_.setFromSerial(serial_excel_underlyingCalcID);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

