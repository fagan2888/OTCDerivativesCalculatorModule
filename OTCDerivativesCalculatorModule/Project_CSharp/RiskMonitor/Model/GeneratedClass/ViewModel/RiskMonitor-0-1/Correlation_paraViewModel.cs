using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Correlation_paraViewModel : IXmlData
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
        
        public Correlation_paraViewModel() { }
        
        #region First_
        private string first_;
        public string First_
        {
            get { return this.first_; }
            set
            {
                if (this.first_ != value)
                {
                    this.first_ = value;
                    this.NotifyPropertyChanged("First_");
                }
            }
        }
        #endregion
        
        #region Second_
        private string second_;
        public string Second_
        {
            get { return this.second_; }
            set
            {
                if (this.second_ != value)
                {
                    this.second_ = value;
                    this.NotifyPropertyChanged("Second_");
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
                xmlWriter.WriteElementString("type" , "correlation_para");
                xmlWriter.WriteStartElement("correlation_para");
                    xmlWriter.WriteElementString("first" , this.first_);
                    
                    xmlWriter.WriteElementString("second" , this.second_);
                    
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
            Control v = new Correlation_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Correlation_para serial_Correlation_para = serial_Class as FpmlSerializedCSharp.Correlation_para;
        
            this.first_ = serial_Correlation_para.First_.ValueStr;
            
            this.second_ = serial_Correlation_para.Second_.ValueStr;
            
            this.value_ = serial_Correlation_para.Value_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

