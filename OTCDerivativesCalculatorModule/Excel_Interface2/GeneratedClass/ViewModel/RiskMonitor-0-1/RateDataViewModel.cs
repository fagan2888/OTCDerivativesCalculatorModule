using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class RateDataViewModel : IXmlData
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
        
        public RateDataViewModel() { }
        
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
        
        #region Data_
        private string data_;
        public string Data_
        {
            get { return this.data_; }
            set
            {
                if (this.data_ != value)
                {
                    this.data_ = value;
                    this.NotifyPropertyChanged("Data_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "rateData");
                xmlWriter.WriteStartElement("rateData");
                    xmlWriter.WriteElementString("periodMultiplier" , this.periodMultiplier_);
                    
                    xmlWriter.WriteElementString("period" , this.period_);
                    
                    xmlWriter.WriteElementString("data" , this.data_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new RateDataView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RateData serial_RateData = serial_Class as FpmlSerializedCSharp.RateData;
        
            this.periodMultiplier_ = serial_RateData.PeriodMultiplier_.ValueStr;
            
            this.period_ = serial_RateData.Period_.ValueStr;
            
            this.data_ = serial_RateData.Data_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

