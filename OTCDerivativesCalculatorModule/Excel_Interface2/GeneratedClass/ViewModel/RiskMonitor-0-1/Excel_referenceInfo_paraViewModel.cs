using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_referenceInfo_paraViewModel : IXmlData
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
        
        public Excel_referenceInfo_paraViewModel() { }
        
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
        
        #region ReferenceName_
        private string referenceName_;
        public string ReferenceName_
        {
            get { return this.referenceName_; }
            set
            {
                if (this.referenceName_ != value)
                {
                    this.referenceName_ = value;
                    this.NotifyPropertyChanged("ReferenceName_");
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
        
        #region Excel_defaultCurveViewModel_
        private Excel_defaultCurveViewModel excel_defaultCurveViewModel_;
        public Excel_defaultCurveViewModel Excel_defaultCurveViewModel_
        {
            get { return this.excel_defaultCurveViewModel_; }
            set
            {
                if (this.excel_defaultCurveViewModel_ != value)
                {
                    this.excel_defaultCurveViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_defaultCurveViewModel_");
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
                xmlWriter.WriteElementString("excel_type" , "excel_referenceInfo_para");
                xmlWriter.WriteStartElement("excel_referenceInfo_para");
                    xmlWriter.WriteElementString("excel_type" , this.excel_type_);
                    
                    xmlWriter.WriteElementString("krCode" , this.krCode_);
                    
                    xmlWriter.WriteElementString("referenceName" , this.referenceName_);
                    
                    xmlWriter.WriteElementString("model" , this.model_);
                    
                    excel_defaultCurveViewModel_.buildXml(xmlWriter);
                    
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
            Control v = new Excel_referenceInfo_paraView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_referenceInfo_para serial_Excel_referenceInfo_para = serial_Class as FpmlSerializedCSharp.Excel_referenceInfo_para;
        
            this.excel_type_ = serial_Excel_referenceInfo_para.Excel_type_.ValueStr;
            
            this.krCode_ = serial_Excel_referenceInfo_para.KrCode_.ValueStr;
            
            this.referenceName_ = serial_Excel_referenceInfo_para.ReferenceName_.ValueStr;
            
            this.model_ = serial_Excel_referenceInfo_para.Model_.ValueStr;
            
            FpmlSerializedCSharp.Excel_defaultCurve serial_excel_defaultCurve = serial_Excel_referenceInfo_para.Excel_defaultCurve_;
            string excel_defaultCurvetype = serial_excel_defaultCurve.Excel_type_.ValueStr;
            this.excel_defaultCurveViewModel_ = Excel_defaultCurveViewModel.CreateExcel_defaultCurve(excel_defaultCurvetype);
            this.excel_defaultCurveViewModel_.setFromSerial(serial_excel_defaultCurve);
            
            this.description_ = serial_Excel_referenceInfo_para.Description_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}

