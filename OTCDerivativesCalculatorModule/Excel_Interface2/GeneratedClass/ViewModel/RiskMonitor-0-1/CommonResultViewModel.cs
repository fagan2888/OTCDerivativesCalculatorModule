using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using RiskMonitor;

namespace Excel_Interface
{
    public class CommonResultViewModel : IXmlData
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
        
        public CommonResultViewModel() { }
        
        #region Price_
        private string price_;
        public string Price_
        {
            get { return this.price_; }
            set
            {
                if (this.price_ != value)
                {
                    this.price_ = value;
                    this.NotifyPropertyChanged("Price_");
                }
            }
        }
        #endregion
        
        #region UnitPrice_
        private string unitPrice_;
        public string UnitPrice_
        {
            get { return this.unitPrice_; }
            set
            {
                if (this.unitPrice_ != value)
                {
                    this.unitPrice_ = value;
                    this.NotifyPropertyChanged("UnitPrice_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "commonResult");
                xmlWriter.WriteStartElement("commonResult");
                    xmlWriter.WriteElementString("price" , this.price_);
                    
                    xmlWriter.WriteElementString("unitPrice" , this.unitPrice_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CommonResultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CommonResult serial_CommonResult = serial_Class as FpmlSerializedCSharp.CommonResult;
        
            this.price_ = serial_CommonResult.Price_.ValueStr;
            
            this.unitPrice_ = serial_CommonResult.UnitPrice_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

