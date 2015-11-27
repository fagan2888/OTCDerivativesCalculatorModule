using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_jointProbabilityTraitViewModel : IXmlData
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
        
        public Excel_jointProbabilityTraitViewModel() { }
        
        #region Nth_
        private string nth_;
        public string Nth_
        {
            get { return this.nth_; }
            set
            {
                if (this.nth_ != value)
                {
                    this.nth_ = value;
                    this.NotifyPropertyChanged("Nth_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_jointProbabilityTrait");
                xmlWriter.WriteStartElement("excel_jointProbabilityTrait");
                    xmlWriter.WriteElementString("nth" , this.nth_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_jointProbabilityTraitView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_jointProbabilityTrait serial_Excel_jointProbabilityTrait = serial_Class as FpmlSerializedCSharp.Excel_jointProbabilityTrait;
        
            this.nth_ = serial_Excel_jointProbabilityTrait.Nth_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

