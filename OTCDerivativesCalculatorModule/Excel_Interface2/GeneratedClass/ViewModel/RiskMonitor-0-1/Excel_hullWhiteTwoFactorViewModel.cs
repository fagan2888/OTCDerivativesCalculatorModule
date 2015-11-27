using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_hullWhiteTwoFactorViewModel : Excel_underlyingModel_paraViewModel
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
        
        public Excel_hullWhiteTwoFactorViewModel() { }
        
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
        
        #region Alpha_
        private string alpha_;
        public string Alpha_
        {
            get { return this.alpha_; }
            set
            {
                if (this.alpha_ != value)
                {
                    this.alpha_ = value;
                    this.NotifyPropertyChanged("Alpha_");
                }
            }
        }
        #endregion
        
        #region Volatility_
        private string volatility_;
        public string Volatility_
        {
            get { return this.volatility_; }
            set
            {
                if (this.volatility_ != value)
                {
                    this.volatility_ = value;
                    this.NotifyPropertyChanged("Volatility_");
                }
            }
        }
        #endregion
        
        #region Excel_rateInfoViewModel_
        private Excel_rateInfoViewModel excel_rateInfoViewModel_;
        public Excel_rateInfoViewModel Excel_rateInfoViewModel_
        {
            get { return this.excel_rateInfoViewModel_; }
            set
            {
                if (this.excel_rateInfoViewModel_ != value)
                {
                    this.excel_rateInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_rateInfoViewModel_");
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
                xmlWriter.WriteElementString("excel_type" , "excel_hullWhiteTwoFactor");
                xmlWriter.WriteStartElement("excel_hullWhiteTwoFactor");
                    xmlWriter.WriteElementString("currentValue" , this.currentValue_);
                    
                    xmlWriter.WriteElementString("alpha" , this.alpha_);
                    
                    xmlWriter.WriteElementString("volatility" , this.volatility_);
                    
                    excel_rateInfoViewModel_.buildXml(xmlWriter);
                    
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
            Control v = new Excel_hullWhiteTwoFactorView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_Excel_underlyingModel_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingModel_para;
            FpmlSerializedCSharp.Excel_hullWhiteTwoFactor serial_Excel_hullWhiteTwoFactor = serial_Excel_underlyingModel_para.Excel_hullWhiteTwoFactor_;
        
            this.currentValue_ = serial_Excel_hullWhiteTwoFactor.CurrentValue_.ValueStr;
            
            this.alpha_ = serial_Excel_hullWhiteTwoFactor.Alpha_.ValueStr;
            
            this.volatility_ = serial_Excel_hullWhiteTwoFactor.Volatility_.ValueStr;
            
            FpmlSerializedCSharp.Excel_rateInfo serial_excel_rateInfo = serial_Excel_hullWhiteTwoFactor.Excel_rateInfo_;
            string excel_rateInfotype = serial_excel_rateInfo.Excel_type_.ValueStr;
            this.excel_rateInfoViewModel_ = Excel_rateInfoViewModel.CreateExcel_rateInfo(excel_rateInfotype);
            this.excel_rateInfoViewModel_.setFromSerial(serial_excel_rateInfo);
            
            this.linkedCurveCode_ = serial_Excel_hullWhiteTwoFactor.LinkedCurveCode_.ValueStr;
            
            FpmlSerializedCSharp.Excel_yieldCurve serial_excel_yieldCurve = serial_Excel_hullWhiteTwoFactor.Excel_yieldCurve_;
            string excel_yieldCurvetype = serial_excel_yieldCurve.Excel_type_.ValueStr;
            this.excel_yieldCurveViewModel_ = Excel_yieldCurveViewModel.CreateExcel_yieldCurve(excel_yieldCurvetype);
            this.excel_yieldCurveViewModel_.setFromSerial(serial_excel_yieldCurve);
            
            this.vba_description_ = serial_Excel_hullWhiteTwoFactor.Vba_description_.ValueStr;
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

