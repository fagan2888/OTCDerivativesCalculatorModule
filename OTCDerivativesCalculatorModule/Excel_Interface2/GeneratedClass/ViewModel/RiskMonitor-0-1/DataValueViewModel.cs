using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class DataValueViewModel : IXmlData
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
        
        public DataValueViewModel() { }
        
        #region Date_
        private string date_;
        public string Date_
        {
            get { return this.date_; }
            set
            {
                if (this.date_ != value)
                {
                    this.date_ = value;
                    this.NotifyPropertyChanged("Date_");
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
                xmlWriter.WriteElementString("excel_type" , "dataValue");
                xmlWriter.WriteStartElement("dataValue");
                    xmlWriter.WriteElementString("date" , this.date_);
                    
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
            Control v = new DataValueView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.DataValue serial_DataValue = serial_Class as FpmlSerializedCSharp.DataValue;
        
            this.date_ = serial_DataValue.Date_.ValueStr;
            
            this.value_ = serial_DataValue.Value_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

