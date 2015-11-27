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
        public Excel_geometricBMViewModel() 
        {
            this.Excel_type_ = "excel_geometricBM";
            this.underlyingModelComboString_ = "GBM";
            //this.view_ = new Excel_geometricBMView();
            //this.view_.DataContext = this;
        }
        
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
                xmlWriter.WriteElementString("excel_type" , "excel_geometricBM");
                xmlWriter.WriteStartElement("excel_geometricBM");

                    xmlWriter.WriteElementString("currentValue", this.currentValue_);
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
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_underlyingModel_para serial_Excel_underlyingModel_para = serial_Class as FpmlSerializedCSharp.Excel_underlyingModel_para;
            FpmlSerializedCSharp.Excel_geometricBM serial_Excel_geometricBM = serial_Excel_underlyingModel_para.Excel_geometricBM_;

            this.currentValue_ = serial_Excel_geometricBM.CurrentValue_.ValueStr;
            this.drift_ = serial_Excel_geometricBM.Drift_.ValueStr;
            this.dividend_ = serial_Excel_geometricBM.Dividend_.ValueStr;
            this.volatility_ = serial_Excel_geometricBM.Volatility_.ValueStr;
        }

        public override string description()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("drift : " + this.drift_ + " ");
            sb.Append("div : " + this.dividend_ + " ");
            sb.Append("v : " + this.volatility_);
            
            this.description_ = sb.ToString();

            return this.description_;
        }

        public override Excel_underlyingModel_paraViewModel Clone()
        {
            Excel_geometricBMViewModel e_gbmVM = new Excel_geometricBMViewModel();

            e_gbmVM.CurrentValue_ = this.CurrentValue_;
            e_gbmVM.drift_ = this.Drift_;
            e_gbmVM.dividend_ = this.dividend_;
            e_gbmVM.volatility_ = this.volatility_;

            return e_gbmVM;
        }

        public override Control view()
        {
            Control v = new Excel_geometricBMView();

            v.DataContext = this;

            return v;
        }

        public override void parameterLoad(ParameterSettingManager parameterSettingManager)
        {
            MarketDataLoader loader = new MarketDataLoader();

            //string code = "";

            //this.CurrentValue_ = (loader.loadData(this.code_, ProgramVariable.ReferenceDate_)).ToString();
            //this.Drift_ = parameterSettingManager.gbmSetting_.drift();
            //this.Dividend_ = parameterSettingManager.gbmSetting_.dividend();
            //this.Volatility_ = parameterSettingManager.gbmSetting_.volatility();
        }

        public override string vba_description()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("modelType=GBM;");

            //if (!(this.CurrentValue_ == null || this.CurrentValue_ == "")) str += "currentValue=" + this.CurrentValue_ + ";";
            //if (!(this.Drift_ == null || this.Drift_ == "")) str += "drift=" + this.Drift_ + ";";
            //if (!(this.Dividend_ == null || this.Dividend_ == "")) str += "dividend=" + this.Dividend_ + ";";
            //if (!(this.Volatility_ == null || this.Volatility_ == "")) str += "volatility=" + this.Volatility_ + ";";

            sb.Append("currentValue=" + this.CurrentValue_ + ";");
            sb.Append("drift=" + this.Drift_ + ";");
            sb.Append("dividend=" + this.Dividend_ + ";");
            sb.Append("volatility=" + this.Volatility_ + ";");


            return sb.ToString();
        }
    }
    
}

