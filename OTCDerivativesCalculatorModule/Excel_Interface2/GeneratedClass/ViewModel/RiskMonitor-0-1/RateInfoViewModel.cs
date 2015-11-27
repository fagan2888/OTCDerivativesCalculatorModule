using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class RateInfoViewModel : IXmlData
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
        
        public RateInfoViewModel() { }
        
        #region Currency_
        private string currency_;
        public string Currency_
        {
            get { return this.currency_; }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                    this.NotifyPropertyChanged("Currency_");
                }
            }
        }
        #endregion
        
        #region IndexType_
        private string indexType_;
        public string IndexType_
        {
            get { return this.indexType_; }
            set
            {
                if (this.indexType_ != value)
                {
                    this.indexType_ = value;
                    this.NotifyPropertyChanged("IndexType_");
                }
            }
        }
        #endregion
        
        #region Tenor_
        private string tenor_;
        public string Tenor_
        {
            get { return this.tenor_; }
            set
            {
                if (this.tenor_ != value)
                {
                    this.tenor_ = value;
                    this.NotifyPropertyChanged("Tenor_");
                }
            }
        }
        #endregion
        
        #region LegTenor_
        private string legTenor_;
        public string LegTenor_
        {
            get { return this.legTenor_; }
            set
            {
                if (this.legTenor_ != value)
                {
                    this.legTenor_ = value;
                    this.NotifyPropertyChanged("LegTenor_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "rateInfo");
                xmlWriter.WriteStartElement("rateInfo");
                    xmlWriter.WriteElementString("currency" , this.currency_);
                    
                    xmlWriter.WriteElementString("indexType" , this.indexType_);
                    
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                    xmlWriter.WriteElementString("legTenor" , this.legTenor_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new RateInfoView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.RateInfo serial_RateInfo = serial_Class as FpmlSerializedCSharp.RateInfo;
        
            this.currency_ = serial_RateInfo.Currency_.ValueStr;
            
            this.indexType_ = serial_RateInfo.IndexType_.ValueStr;
            
            this.tenor_ = serial_RateInfo.Tenor_.ValueStr;
            
            this.legTenor_ = serial_RateInfo.LegTenor_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

