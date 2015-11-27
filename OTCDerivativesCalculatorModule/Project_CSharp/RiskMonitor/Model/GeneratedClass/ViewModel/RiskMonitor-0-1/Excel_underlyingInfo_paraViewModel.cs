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
        
        #region Model_
        private string model_;
        public string Model_
        {
            get { return this.model_; }
            set
            {
                if (this.model_ != value)
                {
                    this.model_ = value;
                    this.NotifyPropertyChanged("Model_");
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
                xmlWriter.WriteElementString("type" , "excel_underlyingInfo_para");
                xmlWriter.WriteStartElement("excel_underlyingInfo_para");
                    xmlWriter.WriteElementString("excel_type" , this.excel_type_);
                    
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
                    xmlWriter.WriteElementString("underName" , this.underName_);
                    
                    xmlWriter.WriteElementString("model" , this.model_);
                    
                    xmlWriter.WriteElementString("basePrice" , this.basePrice_);
                    
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
            
            this.underName_ = serial_Excel_underlyingInfo_para.UnderName_.ValueStr;
            
            this.model_ = serial_Excel_underlyingInfo_para.Model_.ValueStr;
            
            this.basePrice_ = serial_Excel_underlyingInfo_para.BasePrice_.ValueStr;
            
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_excel_underlyingModel_para = serial_Excel_underlyingInfo_para.Excel_underlyingModel_para_;
            string excel_underlyingModel_paratype = serial_excel_underlyingModel_para.Excel_type_.ValueStr;
            this.excel_underlyingModel_paraViewModel_ = Excel_underlyingModel_paraViewModel.CreateExcel_underlyingModel_para(excel_underlyingModel_paratype);
            this.excel_underlyingModel_paraViewModel_.setFromSerial(serial_excel_underlyingModel_para);
            
            this.value_ = serial_Excel_underlyingInfo_para.Value_.ValueStr;
            
            this.description_ = serial_Excel_underlyingInfo_para.Description_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

