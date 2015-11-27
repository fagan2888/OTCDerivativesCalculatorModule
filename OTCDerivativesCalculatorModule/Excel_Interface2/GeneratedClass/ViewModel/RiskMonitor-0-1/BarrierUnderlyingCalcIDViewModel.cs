using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class BarrierUnderlyingCalcIDViewModel : IXmlData
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
        
    
        public BarrierUnderlyingCalcIDViewModel() { }
        
    
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "barrierUnderlyingCalcID");
                xmlWriter.WriteStartElement("barrierUnderlyingCalcID");
                    excel_underlyingCalcIDViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.BarrierUnderlyingCalcID serial_BarrierUnderlyingCalcID = serial_Class as FpmlSerializedCSharp.BarrierUnderlyingCalcID;
        
            FpmlSerializedCSharp.Excel_underlyingCalcID serial_excel_underlyingCalcID = serial_BarrierUnderlyingCalcID.Excel_underlyingCalcID_;
            string excel_underlyingCalcIDtype = serial_excel_underlyingCalcID.Type_.ValueStr;
            this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(excel_underlyingCalcIDtype);
            this.excel_underlyingCalcIDViewModel_.setFromSerial(serial_excel_underlyingCalcID);
            
            this.view_ = new BarrierUnderlyingCalcIDView();
            this.view_.DataContext = this;
        }
        
        
    
            #region SelectExcel_underlyingCalcIDInfo_
            private string selectExcel_underlyingCalcIDInfo_;
            public string SelectExcel_underlyingCalcIDInfo_
            {
                get { return this.selectExcel_underlyingCalcIDInfo_; }
                set
                {
                    if (this.selectExcel_underlyingCalcIDInfo_ != value)
                    {
                        this.selectExcel_underlyingCalcIDInfo_ = value;
                        this.NotifyPropertyChanged("SelectExcel_underlyingCalcIDInfo_");
                    }
                }
            }
            #endregion
            
            public void selectExcel_underlyingCalcIDInfo(string typeStr)
            {
                this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(typeStr);
                this.view_.DataContext = this;
            }
            
        
    
        
    
    }
    
}

