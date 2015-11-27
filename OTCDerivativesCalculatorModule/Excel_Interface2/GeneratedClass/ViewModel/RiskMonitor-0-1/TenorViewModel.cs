using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class TenorViewModel : IXmlData
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
        
        public TenorViewModel() { }
        
        #region PeriodMultiplier_
        private string periodMultiplier_;
        public string PeriodMultiplier_
        {
            get { return this.periodMultiplier_; }
            set
            {
                if (this.periodMultiplier_ != value)
                {
                    this.periodMultiplier_ = value;
                    this.NotifyPropertyChanged("PeriodMultiplier_");
                }
            }
        }
        #endregion
        
        #region Period_
        private string period_;
        public string Period_
        {
            get { return this.period_; }
            set
            {
                if (this.period_ != value)
                {
                    this.period_ = value;
                    this.NotifyPropertyChanged("Period_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "tenor");
                xmlWriter.WriteStartElement("tenor");
                    xmlWriter.WriteElementString("periodMultiplier" , this.periodMultiplier_);
                    
                    xmlWriter.WriteElementString("period" , this.period_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new TenorView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Tenor serial_Tenor = serial_Class as FpmlSerializedCSharp.Tenor;
        
            this.periodMultiplier_ = serial_Tenor.PeriodMultiplier_.ValueStr;
            
            this.period_ = serial_Tenor.Period_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

