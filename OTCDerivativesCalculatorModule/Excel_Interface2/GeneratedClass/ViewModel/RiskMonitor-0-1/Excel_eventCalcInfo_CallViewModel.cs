using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_eventCalcInfo_CallViewModel : IXmlData
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
        
        public Excel_eventCalcInfo_CallViewModel() { }
        
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
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_eventCalcInfo_Call");
                xmlWriter.WriteStartElement("excel_eventCalcInfo_Call");
                    excel_eventCalcInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_eventCalcInfo_CallView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_eventCalcInfo_Call serial_Excel_eventCalcInfo_Call = serial_Class as FpmlSerializedCSharp.Excel_eventCalcInfo_Call;
        
            FpmlSerializedCSharp.Excel_eventCalcInfo serial_excel_eventCalcInfo = serial_Excel_eventCalcInfo_Call.Excel_eventCalcInfo_;
            string excel_eventCalcInfotype = serial_excel_eventCalcInfo.Excel_type_.ValueStr;
            this.excel_eventCalcInfoViewModel_ = Excel_eventCalcInfoViewModel.CreateExcel_eventCalcInfo(excel_eventCalcInfotype);
            this.excel_eventCalcInfoViewModel_.setFromSerial(serial_excel_eventCalcInfo);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

