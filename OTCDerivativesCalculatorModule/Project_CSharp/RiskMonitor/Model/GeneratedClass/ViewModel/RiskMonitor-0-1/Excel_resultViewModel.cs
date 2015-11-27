using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_resultViewModel : IXmlData
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
        
        public Excel_resultViewModel() { }
        
        #region Type_
        private string type_;
        public string Type_
        {
            get { return this.type_; }
            set
            {
                if (this.type_ != value)
                {
                    this.type_ = value;
                    this.NotifyPropertyChanged("Type_");
                }
            }
        }
        #endregion
        
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
                xmlWriter.WriteElementString("type" , "excel_result");
                xmlWriter.WriteStartElement("excel_result");
                    xmlWriter.WriteElementString("type" , this.type_);
                    
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
            Control v = new Excel_resultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_result serial_Excel_result = serial_Class as FpmlSerializedCSharp.Excel_result;
        
            this.type_ = serial_Excel_result.Type_.ValueStr;
            
            this.price_ = serial_Excel_result.Price_.ValueStr;
            
            this.unitPrice_ = serial_Excel_result.UnitPrice_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

