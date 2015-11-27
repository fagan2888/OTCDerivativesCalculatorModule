using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_underlyingInfo_paraViewModel : IXmlData
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
        
        public Excel_underlyingInfo_paraViewModel() { }
        
        #region Excel_type_
        private string excel_type_;
        public string Excel_type_
        {
            get { return this.excel_type_; }
            set
            {
                if (this.excel_type_ != value)
                {
                    this.excel_type_ = value;
                    this.NotifyPropertyChanged("Excel_type_");
                }
            }
        }
        #endregion
        
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
        
        #region UnderName_
        private string underName_;
        public string UnderName_
        {
            get { return this.underName_; }
            set
            {
                if (this.underName_ != value)
                {
                    this.underName_ = value;
                    this.NotifyPropertyChanged("UnderName_");
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
        
        #region Sub_type_
        private string sub_type_;
        public string Sub_type_
        {
            get { return this.sub_type_; }
            set
            {
                if (this.sub_type_ != value)
                {
                    this.sub_type_ = value;
                    this.NotifyPropertyChanged("Sub_type_");
                }
            }
        }
        #endregion
        
        #region Rate_type_
        private string rate_type_;
        public string Rate_type_
        {
            get { return this.rate_type_; }
            set
            {
                if (this.rate_type_ != value)
                {
                    this.rate_type_ = value;
                    this.NotifyPropertyChanged("Rate_type_");
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
        
        #region Excel_underlyingModel_paraViewModel_
        private Excel_underlyingModel_paraViewModel excel_underlyingModel_paraViewModel_;
        public Excel_underlyingModel_paraViewModel Excel_underlyingModel_paraViewModel_
        {
            get { return this.excel_underlyingModel_paraViewModel_; }
            set
            {
                if (this.excel_underlyingModel_paraViewModel_ != value)
                {
                    this.excel_underlyingModel_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingModel_paraViewModel_");
                }
            }
        }
        #endregion
        
        #region Value_
        private string value_;
        public string Value_
        {
            get { return this.value_; }
            set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                    this.NotifyPropertyChanged("Value_");
                }
            }
        }
        #endregion
        
        #region Description_
        private string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_underlyingInfo_para");
                xmlWriter.WriteStartElement("excel_underlyingInfo_para");
                    xmlWriter.WriteElementString("excel_type" , this.excel_type_);
                    
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
                    xmlWriter.WriteElementString("currency" , this.currency_);
                    
                    xmlWriter.WriteElementString("underName" , this.underName_);
                    
                    xmlWriter.WriteElementString("basePrice" , this.basePrice_);
                    
                    xmlWriter.WriteElementString("sub_type" , this.sub_type_);
                    
                    xmlWriter.WriteElementString("rate_type" , this.rate_type_);
                    
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                    xmlWriter.WriteElementString("legTenor" , this.legTenor_);
                    
                    xmlWriter.WriteElementString("linkedCurve" , this.linkedCurve_);
                    
                    excel_underlyingModel_paraViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("value" , this.value_);
                    
                    xmlWriter.WriteElementString("description" , this.description_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_underlyingInfo_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingInfo_para serial_Excel_underlyingInfo_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingInfo_para;
        
            this.excel_type_ = serial_Excel_underlyingInfo_para.Excel_type_.ValueStr;
            
            this.krCode_ = serial_Excel_underlyingInfo_para.KrCode_.ValueStr;
            
            this.currency_ = serial_Excel_underlyingInfo_para.Currency_.ValueStr;
            
            this.underName_ = serial_Excel_underlyingInfo_para.UnderName_.ValueStr;
            
            this.basePrice_ = serial_Excel_underlyingInfo_para.BasePrice_.ValueStr;
            
            this.sub_type_ = serial_Excel_underlyingInfo_para.Sub_type_.ValueStr;
            
            this.rate_type_ = serial_Excel_underlyingInfo_para.Rate_type_.ValueStr;
            
            this.tenor_ = serial_Excel_underlyingInfo_para.Tenor_.ValueStr;
            
            this.legTenor_ = serial_Excel_underlyingInfo_para.LegTenor_.ValueStr;
            
            this.linkedCurve_ = serial_Excel_underlyingInfo_para.LinkedCurve_.ValueStr;
            
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_excel_underlyingModel_para = serial_Excel_underlyingInfo_para.Excel_underlyingModel_para_;
            string excel_underlyingModel_paratype = serial_excel_underlyingModel_para.Excel_type_.ValueStr;
            this.excel_underlyingModel_paraViewModel_ = Excel_underlyingModel_paraViewModel.CreateExcel_underlyingModel_para(excel_underlyingModel_paratype);
            this.excel_underlyingModel_paraViewModel_.setFromSerial(serial_excel_underlyingModel_para);
            
            this.value_ = serial_Excel_underlyingInfo_para.Value_.ValueStr;
            
            this.description_ = serial_Excel_underlyingInfo_para.Description_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

