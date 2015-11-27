using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class HeaderViewModel : IXmlData
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
        
        public HeaderViewModel() { }
        
        #region ProductName_
        private string productName_;
        public string ProductName_
        {
            get { return this.productName_; }
            set
            {
                if (this.productName_ != value)
                {
                    this.productName_ = value;
                    this.NotifyPropertyChanged("ProductName_");
                }
            }
        }
        #endregion
        
        #region ProductType_
        private string productType_;
        public string ProductType_
        {
            get { return this.productType_; }
            set
            {
                if (this.productType_ != value)
                {
                    this.productType_ = value;
                    this.NotifyPropertyChanged("ProductType_");
                }
            }
        }
        #endregion
        
        #region KrCode_
        private string krCode_;
        public string KrCode_
        {
            get { return this.krCode_; }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                    this.NotifyPropertyChanged("KrCode_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "header");
                xmlWriter.WriteStartElement("header");
                    xmlWriter.WriteElementString("productName" , this.productName_);
                    
                    xmlWriter.WriteElementString("productType" , this.productType_);
                    
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new HeaderView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Header serial_Header = serial_Class as FpmlSerializedCSharp.Header;
        
            this.productName_ = serial_Header.ProductName_.ValueStr;
            
            this.productType_ = serial_Header.ProductType_.ValueStr;
            
            this.krCode_ = serial_Header.KrCode_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

