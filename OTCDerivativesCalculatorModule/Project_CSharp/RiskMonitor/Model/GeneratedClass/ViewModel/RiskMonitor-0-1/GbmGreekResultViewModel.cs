using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class GbmGreekResultViewModel : IXmlData
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
        
        public GbmGreekResultViewModel() { }
        
        #region UnderlyingName_
        private string underlyingName_;
        public string UnderlyingName_
        {
            get { return this.underlyingName_; }
            set
            {
                if (this.underlyingName_ != value)
                {
                    this.underlyingName_ = value;
                    this.NotifyPropertyChanged("UnderlyingName_");
                }
            }
        }
        #endregion
        
        #region Delta_
        private string delta_;
        public string Delta_
        {
            get { return this.delta_; }
            set
            {
                if (this.delta_ != value)
                {
                    this.delta_ = value;
                    this.NotifyPropertyChanged("Delta_");
                }
            }
        }
        #endregion
        
        #region Gamma_
        private string gamma_;
        public string Gamma_
        {
            get { return this.gamma_; }
            set
            {
                if (this.gamma_ != value)
                {
                    this.gamma_ = value;
                    this.NotifyPropertyChanged("Gamma_");
                }
            }
        }
        #endregion
        
        #region Vega_
        private string vega_;
        public string Vega_
        {
            get { return this.vega_; }
            set
            {
                if (this.vega_ != value)
                {
                    this.vega_ = value;
                    this.NotifyPropertyChanged("Vega_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("type" , "gbmGreekResult");
                xmlWriter.WriteStartElement("gbmGreekResult");
                    xmlWriter.WriteElementString("underlyingName" , this.underlyingName_);
                    
                    xmlWriter.WriteElementString("delta" , this.delta_);
                    
                    xmlWriter.WriteElementString("gamma" , this.gamma_);
                    
                    xmlWriter.WriteElementString("vega" , this.vega_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new GbmGreekResultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.GbmGreekResult serial_GbmGreekResult = serial_Class as FpmlSerializedCSharp.GbmGreekResult;
        
            this.underlyingName_ = serial_GbmGreekResult.UnderlyingName_.ValueStr;
            
            this.delta_ = serial_GbmGreekResult.Delta_.ValueStr;
            
            this.gamma_ = serial_GbmGreekResult.Gamma_.ValueStr;
            
            this.vega_ = serial_GbmGreekResult.Vega_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

