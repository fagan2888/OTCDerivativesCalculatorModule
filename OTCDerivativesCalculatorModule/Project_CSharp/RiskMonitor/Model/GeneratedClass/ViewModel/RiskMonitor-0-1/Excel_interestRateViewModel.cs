using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_interestRateViewModel : Excel_underlyingInfoViewModel
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
        
        public Excel_interestRateViewModel() { }
        
        #region KrCode_
        private string krCode_;
        public string KrCode_
        {
            get { return this.krCode_; }
            set
            {
                if (this.krCode_ != value)
                {
                    this.krCode_ = value;
                    this.NotifyPropertyChanged("KrCode_");
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
        
        #region BasePrice_
        private string basePrice_;
        public string BasePrice_
        {
            get { return this.basePrice_; }
            set
            {
                if (this.basePrice_ != value)
                {
                    this.basePrice_ = value;
                    this.NotifyPropertyChanged("BasePrice_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingInfo");
                xmlWriter.WriteElementString("type" , "excel_interestRate");
                xmlWriter.WriteStartElement("excel_interestRate");
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
                    xmlWriter.WriteElementString("name" , this.name_);
                    
                    xmlWriter.WriteElementString("basePrice" , this.basePrice_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_interestRateView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingInfo serial_Excel_underlyingInfo = serial_Class as FpmlSerializedCSharp.Excel_underlyingInfo;
            FpmlSerializedCSharp.Excel_interestRate serial_Excel_interestRate = serial_Excel_underlyingInfo.Excel_interestRate_;
        
            this.krCode_ = serial_Excel_interestRate.KrCode_.ValueStr;
            
            this.name_ = serial_Excel_interestRate.Name_.ValueStr;
            
            this.basePrice_ = serial_Excel_interestRate.BasePrice_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

