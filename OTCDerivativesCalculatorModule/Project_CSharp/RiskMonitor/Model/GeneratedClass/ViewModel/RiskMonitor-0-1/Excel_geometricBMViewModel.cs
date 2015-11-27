using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_geometricBMViewModel : Excel_underlyingModel_paraViewModel
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
        
        public Excel_geometricBMViewModel() { }
        
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
        
        #region Drift_
        private string drift_;
        public string Drift_
        {
            get { return this.drift_; }
            set
            {
                if (this.drift_ != value)
                {
                    this.drift_ = value;
                    this.NotifyPropertyChanged("Drift_");
                }
            }
        }
        #endregion
        
        #region Dividend_
        private string dividend_;
        public string Dividend_
        {
            get { return this.dividend_; }
            set
            {
                if (this.dividend_ != value)
                {
                    this.dividend_ = value;
                    this.NotifyPropertyChanged("Dividend_");
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
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingModel_para");
                xmlWriter.WriteElementString("type" , "excel_geometricBM");
                xmlWriter.WriteStartElement("excel_geometricBM");
                    xmlWriter.WriteElementString("currentValue" , this.currentValue_);
                    
                    xmlWriter.WriteElementString("drift" , this.drift_);
                    
                    xmlWriter.WriteElementString("dividend" , this.dividend_);
                    
                    xmlWriter.WriteElementString("volatility" , this.volatility_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_geometricBMView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_Excel_underlyingModel_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingModel_para;
            FpmlSerializedCSharp.Excel_geometricBM serial_Excel_geometricBM = serial_Excel_underlyingModel_para.Excel_geometricBM_;
        
            this.currentValue_ = serial_Excel_geometricBM.CurrentValue_.ValueStr;
            
            this.drift_ = serial_Excel_geometricBM.Drift_.ValueStr;
            
            this.dividend_ = serial_Excel_geometricBM.Dividend_.ValueStr;
            
            this.volatility_ = serial_Excel_geometricBM.Volatility_.ValueStr;
            
        }
        
        
    
        
    
        
    
    }
    
}

