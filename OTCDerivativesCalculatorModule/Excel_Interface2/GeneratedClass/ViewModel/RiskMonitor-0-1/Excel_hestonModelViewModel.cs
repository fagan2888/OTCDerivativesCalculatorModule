using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_hestonModelViewModel : Excel_underlyingModel_paraViewModel
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
        
        public Excel_hestonModelViewModel() { }
        
        #region CurrentValue_
        private string currentValue_;
        public string CurrentValue_
        {
            get { return this.currentValue_; }
            set
            {
                if (this.currentValue_ != value)
                {
                    this.currentValue_ = value;
                    this.NotifyPropertyChanged("CurrentValue_");
                }
            }
        }
        #endregion
        
        #region Vba_description_
        private string vba_description_;
        public string Vba_description_
        {
            get { return this.vba_description_; }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                    this.NotifyPropertyChanged("Vba_description_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingModel_para");
                xmlWriter.WriteElementString("excel_type" , "excel_hestonModel");
                xmlWriter.WriteStartElement("excel_hestonModel");
                    xmlWriter.WriteElementString("currentValue" , this.currentValue_);
                    
                    xmlWriter.WriteElementString("vba_description" , this.vba_description_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_hestonModelView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_Excel_underlyingModel_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingModel_para;
            FpmlSerializedCSharp.Excel_hestonModel serial_Excel_hestonModel = serial_Excel_underlyingModel_para.Excel_hestonModel_;
        
            this.currentValue_ = serial_Excel_hestonModel.CurrentValue_.ValueStr;
            
            this.vba_description_ = serial_Excel_hestonModel.Vba_description_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

