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
        
        #region RateType_
        private string rateType_;
        public string RateType_
        {
            get { return this.rateType_; }
            set
            {
                if (this.rateType_ != value)
                {
                    this.rateType_ = value;
                    this.NotifyPropertyChanged("RateType_");
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
        
        #region LinkedCurve_
        private string linkedCurve_;
        public string LinkedCurve_
        {
            get { return this.linkedCurve_; }
            set
            {
                if (this.linkedCurve_ != value)
                {
                    this.linkedCurve_ = value;
                    this.NotifyPropertyChanged("LinkedCurve_");
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
                xmlWriter.WriteElementString("excel_type" , "excel_interestRate");
                xmlWriter.WriteStartElement("excel_interestRate");
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
                    xmlWriter.WriteElementString("name" , this.name_);
                    
                    xmlWriter.WriteElementString("currency" , this.currency_);
                    
                    xmlWriter.WriteElementString("rateType" , this.rateType_);
                    
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                    xmlWriter.WriteElementString("legTenor" , this.legTenor_);
                    
                    xmlWriter.WriteElementString("linkedCurve" , this.linkedCurve_);
                    
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
            
            this.currency_ = serial_Excel_interestRate.Currency_.ValueStr;
            
            this.rateType_ = serial_Excel_interestRate.RateType_.ValueStr;
            
            this.tenor_ = serial_Excel_interestRate.Tenor_.ValueStr;
            
            this.legTenor_ = serial_Excel_interestRate.LegTenor_.ValueStr;
            
            this.linkedCurve_ = serial_Excel_interestRate.LinkedCurve_.ValueStr;
            
            this.basePrice_ = serial_Excel_interestRate.BasePrice_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

