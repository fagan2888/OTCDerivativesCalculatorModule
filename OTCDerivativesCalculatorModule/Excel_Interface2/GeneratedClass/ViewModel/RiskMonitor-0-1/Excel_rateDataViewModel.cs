using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_rateDataViewModel : IXmlData
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
        
        public Excel_rateDataViewModel() { }
        
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
        
        #region RateType_
        private string rateType_;
        public string RateType_
        {
            get { return this.rateType_; }
            set
            {
                if (this.rateType_ != value)
                {
                    this.rateType_ = value;
                    this.NotifyPropertyChanged("RateType_");
                }
            }
        }
        #endregion
        
        #region Value_
        private string value_;
        public string Value_
        {
            get { return this.value_; }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                    this.NotifyPropertyChanged("Value_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_rateData");
                xmlWriter.WriteStartElement("excel_rateData");
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                    xmlWriter.WriteElementString("rateType" , this.rateType_);
                    
                    xmlWriter.WriteElementString("value" , this.value_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_rateDataView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_rateData serial_Excel_rateData = serial_Class as FpmlSerializedCSharp.Excel_rateData;
        
            this.tenor_ = serial_Excel_rateData.Tenor_.ValueStr;
            
            this.rateType_ = serial_Excel_rateData.RateType_.ValueStr;
            
            this.value_ = serial_Excel_rateData.Value_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

