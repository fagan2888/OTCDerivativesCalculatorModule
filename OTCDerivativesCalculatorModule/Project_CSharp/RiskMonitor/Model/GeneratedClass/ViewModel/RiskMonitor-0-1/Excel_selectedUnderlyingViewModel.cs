using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_selectedUnderlyingViewModel : IXmlData
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
        
        public Excel_selectedUnderlyingViewModel() { }
        
        #region Code_
        private string code_;
        public string Code_
        {
            get { return this.code_; }
            set
            {
                if (this.code_ != value)
                {
                    this.code_ = value;
                    this.NotifyPropertyChanged("Code_");
                }
            }
        }
        #endregion
        
        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion
        
        #region Checked_
        private string checked_;
        public string Checked_
        {
            get { return this.checked_; }
            set
            {
                if (this.checked_ != value)
                {
                    this.checked_ = value;
                    this.NotifyPropertyChanged("Checked_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "excel_selectedUnderlying");
                xmlWriter.WriteStartElement("excel_selectedUnderlying");
                    xmlWriter.WriteElementString("code" , this.code_);
                    
                    xmlWriter.WriteElementString("name" , this.name_);
                    
                    xmlWriter.WriteElementString("checked" , this.checked_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_selectedUnderlyingView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_selectedUnderlying serial_Excel_selectedUnderlying = serial_Class as FpmlSerializedCSharp.Excel_selectedUnderlying;
        
            this.code_ = serial_Excel_selectedUnderlying.Code_.ValueStr;
            
            this.name_ = serial_Excel_selectedUnderlying.Name_.ValueStr;
            
            this.checked_ = serial_Excel_selectedUnderlying.Checked_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

