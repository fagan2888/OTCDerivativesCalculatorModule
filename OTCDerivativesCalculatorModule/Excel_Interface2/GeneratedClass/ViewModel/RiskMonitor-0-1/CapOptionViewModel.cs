using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class CapOptionViewModel : IXmlData
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
        
        public CapOptionViewModel() { }
        
        #region ReferenceStr_
        private string referenceStr_;
        public string ReferenceStr_
        {
            get { return this.referenceStr_; }
            set
            {
                if (this.referenceStr_ != value)
                {
                    this.referenceStr_ = value;
                    this.NotifyPropertyChanged("ReferenceStr_");
                }
            }
        }
        #endregion
        
        #region CapRate_
        private string capRate_;
        public string CapRate_
        {
            get { return this.capRate_; }
            set
            {
                if (this.capRate_ != value)
                {
                    this.capRate_ = value;
                    this.NotifyPropertyChanged("CapRate_");
                }
            }
        }
        #endregion
        
        #region Vol_
        private string vol_;
        public string Vol_
        {
            get { return this.vol_; }
            set
            {
                if (this.vol_ != value)
                {
                    this.vol_ = value;
                    this.NotifyPropertyChanged("Vol_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "capOption");
                xmlWriter.WriteStartElement("capOption");
                    xmlWriter.WriteElementString("referenceStr" , this.referenceStr_);
                    
                    xmlWriter.WriteElementString("capRate" , this.capRate_);
                    
                    xmlWriter.WriteElementString("vol" , this.vol_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new CapOptionView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.CapOption serial_CapOption = serial_Class as FpmlSerializedCSharp.CapOption;
        
            this.referenceStr_ = serial_CapOption.ReferenceStr_.ValueStr;
            
            this.capRate_ = serial_CapOption.CapRate_.ValueStr;
            
            this.vol_ = serial_CapOption.Vol_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

