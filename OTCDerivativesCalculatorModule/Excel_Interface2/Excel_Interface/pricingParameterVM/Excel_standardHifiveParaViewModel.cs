using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_standardHifiveParaViewModel : Excel_parameterViewModel
    {
        public Excel_standardHifiveParaViewModel() 
        {
            this.excel_underlyingCalcInfo_paraViewModel_ = new Excel_underlyingCalcInfo_paraViewModel();
            this.excel_discountCurve_paraViewModel_ = new Excel_discountCurve_paraViewModel();
            this.Excel_resultViewModel_ = new Excel_resultViewModel();
        }
        
        #region Excel_underlyingCalcInfo_paraViewModel_
        private Excel_underlyingCalcInfo_paraViewModel excel_underlyingCalcInfo_paraViewModel_;
        public Excel_underlyingCalcInfo_paraViewModel Excel_underlyingCalcInfo_paraViewModel_
        {
            get { return this.excel_underlyingCalcInfo_paraViewModel_; }
            set
            {
                if (this.excel_underlyingCalcInfo_paraViewModel_ != value)
                {
                    this.excel_underlyingCalcInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcInfo_paraViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_discountCurve_paraViewModel_
        private Excel_discountCurve_paraViewModel excel_discountCurve_paraViewModel_;
        public Excel_discountCurve_paraViewModel Excel_discountCurve_paraViewModel_
        {
            get { return this.excel_discountCurve_paraViewModel_; }
            set
            {
                if (this.excel_discountCurve_paraViewModel_ != value)
                {
                    this.excel_discountCurve_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_discountCurve_paraViewModel_");
                }
            }
        }
        #endregion
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_parameter");
                xmlWriter.WriteElementString("excel_type" , "excel_standardHifivePara");
                xmlWriter.WriteStartElement("excel_standardHifivePara");
                    xmlWriter.WriteElementString("referenceDate" , this.referenceDate_.ToString(StringFormat.XmlDateFormat_));
                    
                    xmlWriter.WriteElementString("simulationNum" , this.simulationNum_);
                    
                    this.excel_underlyingCalcInfo_paraViewModel_.buildXml(xmlWriter);

                    this.excel_discountCurve_paraViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_standardHifiveParaView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_parameter serial_Excel_parameter = serial_Class as FpmlSerializedCSharp.Excel_parameter;
            FpmlSerializedCSharp.Excel_standardHifivePara serial_Excel_standardHifivePara = serial_Excel_parameter.Excel_standardHifivePara_;
        
            this.referenceDate_ = StringConverter.xmlDateToDateTime(serial_Excel_standardHifivePara.ReferenceDate_.ValueStr);

            this.simulationNum_ = serial_Excel_standardHifivePara.SimulationNum_.ValueStr;
            
            FpmlSerializedCSharp.Excel_underlyingCalcInfo_para serial_excel_underlyingCalcInfo_para = serial_Excel_standardHifivePara.Excel_underlyingCalcInfo_para_;
            this.excel_underlyingCalcInfo_paraViewModel_ = new Excel_underlyingCalcInfo_paraViewModel();
            this.excel_underlyingCalcInfo_paraViewModel_.setFromSerial(serial_excel_underlyingCalcInfo_para);
            
            FpmlSerializedCSharp.Excel_discountCurve_para serial_excel_discountCurve_para = serial_Excel_standardHifivePara.Excel_discountCurve_para_;
            this.excel_discountCurve_paraViewModel_ = new Excel_discountCurve_paraViewModel();
            this.excel_discountCurve_paraViewModel_.setFromSerial(serial_excel_discountCurve_para);
            
        }

        public override void instrumentEventObserver(object sender, PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void masterEventObserver(object sender, PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void buildPricingXml(XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        //public override string historyUnderData(DateTime startDate , bool bodyOnly = false)
        //{
        //    //Dictionary<string, QLNet.TimeSeries<string>> dataList = new Dictionary<string, QLNet.TimeSeries<string>>();

        //    StringBuilder sb = new StringBuilder();
        //    XmlWriterSettings setting = new XmlWriterSettings();

        //    setting.Indent = true;
        //    //setting.Encoding = Encoding.UTF8;
            
        //    if (bodyOnly == true)
        //        setting.OmitXmlDeclaration = true;

        //    XmlWriter xmlWriter = XmlWriter.Create(sb, setting);
            
        //    xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

        //    xmlWriter.WriteStartElement("hisoryData");

        //    this.excel_underlyingCalcInfo_paraViewModel_
        //        .historyUnderData(xmlWriter, startDate, this.ReferenceDate_);

        //    xmlWriter.WriteEndElement();

        //    xmlWriter.Close();

        //    return sb.ToString();
        //}

        public override void loadMarketData(DateTime referenceDate)
        {
            this.excel_underlyingCalcInfo_paraViewModel_.loadMarketData(referenceDate);
            this.excel_discountCurve_paraViewModel_.loadMarketData(referenceDate);
        }

        public override void buildParaSetting(ParameterSettingManager paraSettingManager)
        {
            this.simulationNum_ = paraSettingManager.SimulationNumber_.ToString();

            this.excel_underlyingCalcInfo_paraViewModel_.buildParaSetting(paraSettingManager);
            this.excel_discountCurve_paraViewModel_.buildParaSetting(paraSettingManager);
        }

    }
    
}

