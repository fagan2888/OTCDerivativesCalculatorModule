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

        public Excel_forwardModelViewModel() 
        {
            this.Excel_type_ = "excel_forwardModel";
            this.underlyingModelComboString_ = "Forward";
        }
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_underlyingModel_para");
                xmlWriter.WriteElementString("excel_type" , "excel_forwardModel");
                xmlWriter.WriteStartElement("excel_forwardModel");
                    xmlWriter.WriteElementString("currentValue", this.currentValue_);

                    xmlWriter.WriteElementString("tenor", this.tenor_);

                    excel_yieldCurveViewModel_.buildXml(xmlWriter);

                    //xmlWriter.WriteElementString("vba_description", this.vba_description_);

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
            FpmlSerializedCSharp.Excel_forwardModel serial_Excel_forwardModel = serial_Excel_underlyingModel_para.Excel_forwardModel_;

            this.currentValue_ = serial_Excel_forwardModel.CurrentValue_.ValueStr;

            this.tenor_ = serial_Excel_forwardModel.Tenor_.ValueStr;

            FpmlSerializedCSharp.Excel_yieldCurve serial_excel_yieldCurve = serial_Excel_forwardModel.Excel_yieldCurve_;
            this.excel_yieldCurveViewModel_.setFromSerial(serial_excel_yieldCurve);

            //this.vba_description_ = serial_Excel_forwardModel.Vba_description_.ValueStr;
            
        }

        public override string description()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("tenor : " + this.tenor_);

            return sb.ToString();
        }

        public override Excel_underlyingModel_paraViewModel Clone()
        {
            Excel_forwardModelViewModel clone = new Excel_forwardModelViewModel();

            return clone;
        }

        public override Control view()
        {
            throw new NotImplementedException();
        }

        public override void parameterLoad(ParameterSettingManager parameterSettingManager)
        {
            throw new NotImplementedException();
        }

        public override string vba_description()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("modelType=forward;");

            sb.Append("currentValue=" + this.CurrentValue_ + ";");
            //sb.Append("linkedCurveCode=" + this.LinkedCurveCode_ + ";");

            return sb.ToString();

        }
    }
    
}

