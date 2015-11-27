using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class GeometricBMViewModel : Underlying_paraViewModel
    {

        public GeometricBMViewModel() { }

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
            // 계산 방법을 결정함.

            // 필요한 것

            // 기초자산, type , 상품을 던져야함

            xmlWriter.WriteStartElement("underlying_para");

                xmlWriter.WriteElementString("type", "geometricBM");
                xmlWriter.WriteElementString("krCode", this.krCode_);
                xmlWriter.WriteElementString("underName", this.underName_);

                xmlWriter.WriteStartElement("geometricBM");

                    xmlWriter.WriteElementString("currentValue", this.currentValue_);
                    xmlWriter.WriteElementString("drift", this.drift_);
                    xmlWriter.WriteElementString("dividend", this.dividend_);
                    xmlWriter.WriteElementString("volatility", this.volatility_);

                xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            this.type_ = "GeometricBM";

            FpmlSerializedCSharp.Underlying_para serial_Underlying_para = serial_Class as FpmlSerializedCSharp.Underlying_para;
            FpmlSerializedCSharp.GeometricBM serial_GeometricBM = serial_Underlying_para.GeometricBM_;

            this.krCode_ = serial_Underlying_para.KrCode_.ValueStr;
            this.underName_ = serial_Underlying_para.UnderName_.ValueStr;

            this.currentValue_ = serial_GeometricBM.CurrentValue_.ValueStr;
            
            this.drift_ = serial_GeometricBM.Drift_.ValueStr;
            
            this.dividend_ = serial_GeometricBM.Dividend_.ValueStr;
            
            this.volatility_ = serial_GeometricBM.Volatility_.ValueStr;
            
            this.view_ = new GeometricBMView();
            this.view_.DataContext = this;
        }
        
        
    
        
    
        
    
    }
    
}

