using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_hullWhiteOneFactorViewModel : Excel_underlyingModel_paraViewModel
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
        
        public Excel_hullWhiteOneFactorViewModel() { }
        
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
        
        #region FittingYieldCurveName_
        private string fittingYieldCurveName_;
        public string FittingYieldCurveName_
        {
            get { return this.fittingYieldCurveName_; }
            set
            {
                if (this.fittingYieldCurveName_ != value)
                {
                    this.fittingYieldCurveName_ = value;
                    this.NotifyPropertyChanged("FittingYieldCurveName_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingModel_para");
                xmlWriter.WriteElementString("type" , "excel_hullWhiteOneFactor");
                xmlWriter.WriteStartElement("excel_hullWhiteOneFactor");
                    xmlWriter.WriteElementString("currentValue" , this.currentValue_);
                    
                    xmlWriter.WriteElementString("alpha" , this.alpha_);
                    
                    xmlWriter.WriteElementString("volatility" , this.volatility_);
                    
                    xmlWriter.WriteElementString("tenor" , this.tenor_);
                    
                    xmlWriter.WriteElementString("fittingYieldCurveName" , this.fittingYieldCurveName_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_hullWhiteOneFactorView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_Excel_underlyingModel_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingModel_para;
            FpmlSerializedCSharp.Excel_hullWhiteOneFactor serial_Excel_hullWhiteOneFactor = serial_Excel_underlyingModel_para.Excel_hullWhiteOneFactor_;
        
            this.currentValue_ = serial_Excel_hullWhiteOneFactor.CurrentValue_.ValueStr;
            
            this.alpha_ = serial_Excel_hullWhiteOneFactor.Alpha_.ValueStr;
            
            this.volatility_ = serial_Excel_hullWhiteOneFactor.Volatility_.ValueStr;
            
            this.tenor_ = serial_Excel_hullWhiteOneFactor.Tenor_.ValueStr;
            
            this.fittingYieldCurveName_ = serial_Excel_hullWhiteOneFactor.FittingYieldCurveName_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

