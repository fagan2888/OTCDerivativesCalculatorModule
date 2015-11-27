using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_forwardModelViewModel : Excel_underlyingModel_paraViewModel
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
        
        public Excel_forwardModelViewModel() { }
        
        #region CurrentValue_
        private string currentValue_;
        public string CurrentValue_
        {
            get { return this.currentValue_; }
            set
            {
                if (this.currentValue_ != value)
                {
                    this.currentValue_ = value;
                    this.NotifyPropertyChanged("CurrentValue_");
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
        
        #region LinkedCurveCode_
        private string linkedCurveCode_;
        public string LinkedCurveCode_
        {
            get { return this.linkedCurveCode_; }
            set
            {
                if (this.linkedCurveCode_ != value)
                {
                    this.linkedCurveCode_ = value;
                    this.NotifyPropertyChanged("LinkedCurveCode_");
                }
            }
        }
        #endregion
        
        #region Excel_yieldCurveViewModel_
        private Excel_yieldCurveViewModel excel_yieldCurveViewModel_;
        public Excel_yieldCurveViewModel Excel_yieldCurveViewModel_
        {
            get { return this.excel_yieldCurveViewModel_; }
            set
            {
                if (this.excel_yieldCurveViewModel_ != value)
                {
                    this.excel_yieldCurveViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_yieldCurveViewModel_");
                }
            }
        }
        #endregion
        
        #region Vba_description_
        private string vba_description_;
        public string Vba_description_
        {
            get { return this.vba_description_; }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                    this.NotifyPropertyChanged("Vba_description_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingModel_para");
                xmlWriter.WriteElementString("excel_type" , "excel_forwardModel");
                xmlWriter.WriteStartElement("excel_forwardModel");
                    xmlWriter.WriteElementString("currentValue" , this.currentValue_);
                    
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                    xmlWriter.WriteElementString("linkedCurveCode" , this.linkedCurveCode_);
                    
                    excel_yieldCurveViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("vba_description" , this.vba_description_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_forwardModelView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_Excel_underlyingModel_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingModel_para;
            FpmlSerializedCSharp.Excel_forwardModel serial_Excel_forwardModel = serial_Excel_underlyingModel_para.Excel_forwardModel_;
        
            this.currentValue_ = serial_Excel_forwardModel.CurrentValue_.ValueStr;
            
            this.tenor_ = serial_Excel_forwardModel.Tenor_.ValueStr;
            
            this.linkedCurveCode_ = serial_Excel_forwardModel.LinkedCurveCode_.ValueStr;
            
            FpmlSerializedCSharp.Excel_yieldCurve serial_excel_yieldCurve = serial_Excel_forwardModel.Excel_yieldCurve_;
            string excel_yieldCurvetype = serial_excel_yieldCurve.Excel_type_.ValueStr;
            this.excel_yieldCurveViewModel_ = Excel_yieldCurveViewModel.CreateExcel_yieldCurve(excel_yieldCurvetype);
            this.excel_yieldCurveViewModel_.setFromSerial(serial_excel_yieldCurve);
            
            this.vba_description_ = serial_Excel_forwardModel.Vba_description_.ValueStr;
            
        }
        
        
    
            
            
        
    
        
    
    }
    
}
