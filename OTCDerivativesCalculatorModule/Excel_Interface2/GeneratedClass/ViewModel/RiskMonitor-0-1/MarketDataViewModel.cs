using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class MarketDataViewModel : IXmlData
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
        
        public MarketDataViewModel() { }
        
        #region Krcode_
        private string krcode_;
        public string Krcode_
        {
            get { return this.krcode_; }
            set
            {
                if (this.krcode_ != value)
                {
                    this.krcode_ = value;
                    this.NotifyPropertyChanged("Krcode_");
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
        
        #region DataValueInfoViewModel_
        private DataValueInfoViewModel dataValueInfoViewModel_;
        public DataValueInfoViewModel DataValueInfoViewModel_
        {
            get { return this.dataValueInfoViewModel_; }
            set
            {
                if (this.dataValueInfoViewModel_ != value)
                {
                    this.dataValueInfoViewModel_ = value;
                    this.NotifyPropertyChanged("DataValueInfoViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "marketData");
                xmlWriter.WriteStartElement("marketData");
                    xmlWriter.WriteElementString("krcode" , this.krcode_);
                    
                    xmlWriter.WriteElementString("name" , this.name_);
                    
                    dataValueInfoViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new MarketDataView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.MarketData serial_MarketData = serial_Class as FpmlSerializedCSharp.MarketData;
        
            this.krcode_ = serial_MarketData.Krcode_.ValueStr;
            
            this.name_ = serial_MarketData.Name_.ValueStr;
            
            FpmlSerializedCSharp.DataValueInfo serial_dataValueInfo = serial_MarketData.DataValueInfo_;
            string dataValueInfotype = serial_dataValueInfo.Excel_type_.ValueStr;
            this.dataValueInfoViewModel_ = DataValueInfoViewModel.CreateDataValueInfo(dataValueInfotype);
            this.dataValueInfoViewModel_.setFromSerial(serial_dataValueInfo);
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

