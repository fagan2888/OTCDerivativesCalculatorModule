using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_rateInfoViewModel : IXmlData
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
        
        public Excel_rateInfoViewModel() { }
        
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
            xmlWriter.WriteStartElement("excel_rateInfo");
                xmlWriter.WriteElementString("currency" , this.currency_);
                    
                xmlWriter.WriteElementString("indexType" , this.indexType_);
                    
                xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                xmlWriter.WriteElementString("legTenor" , this.legTenor_);
                    
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_rateInfo serial_Excel_rateInfo = serial_Class as FpmlSerializedCSharp.Excel_rateInfo;
        
            this.currency_ = serial_Excel_rateInfo.Currency_.ValueStr;
            
            this.indexType_ = serial_Excel_rateInfo.IndexType_.ValueStr;
            
            this.tenor_ = serial_Excel_rateInfo.Tenor_.ValueStr;
            
            this.legTenor_ = serial_Excel_rateInfo.LegTenor_.ValueStr;
            
        }

        public Excel_rateInfoViewModel Clone()
        {
            Excel_rateInfoViewModel clone = new Excel_rateInfoViewModel();

            clone.LegTenor_ = this.legTenor_;
            clone.IndexType_ = this.indexType_;
            clone.Tenor_ = this.tenor_;
            clone.Currency_ = this.currency_;

            return clone;
        }
    }
    
}

