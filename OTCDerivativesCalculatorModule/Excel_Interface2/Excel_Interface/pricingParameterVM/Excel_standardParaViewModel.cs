using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;


namespace Excel_Interface
{
    public class Excel_standardParaViewModel : Excel_parameterViewModel
    {
        public Excel_standardParaViewModel() 
        {
            this.excel_underlyingCalcInfo_paraViewModel_ = new Excel_underlyingCalcInfo_paraViewModel();
            this.excel_discountCurve_paraViewModel_ = new Excel_discountCurve_paraViewModel();
            this.Excel_resultViewModel_ = new Excel_resultViewModel();

            //this.view_ = new Excel_standardParaView();
            //this.view_.DataContext = this;
            //this.referenceDate_ = DateTime.Now;
            //this.simulationNum_ = "10000";
        }
        
        
        
        #region Excel_underlyingCalcInfo_paraViewModel_
        protected Excel_underlyingCalcInfo_paraViewModel excel_underlyingCalcInfo_paraViewModel_;
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
        protected Excel_discountCurve_paraViewModel excel_discountCurve_paraViewModel_;
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
                //xmlWriter.WriteStartElement("method");
                //    xmlWriter.WriteStartElement("monte");
                //        xmlWriter.WriteElementString("simulationNum", "10000");
                //    xmlWriter.WriteEndElement();
                //xmlWriter.WriteEndElement();
 
                xmlWriter.WriteElementString("excel_type" , "excel_standardPara");
                xmlWriter.WriteStartElement("excel_standardPara");
                
                    xmlWriter.WriteElementString("referenceDate", this.referenceDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("simulationNum" , this.simulationNum_);
                    
                    excel_underlyingCalcInfo_paraViewModel_.buildXml(xmlWriter);
                    
                    excel_discountCurve_paraViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void buildPricingXml(XmlWriter xmlWriter)
        {
            //xmlWriter.WriteStartElement("pricingParameter");
            //    xmlWriter.WriteElementString("excel_type", "standard_para");

            //        xmlWriter.WriteStartElement("method");
            //            xmlWriter.WriteStartElement("monte");
            //                xmlWriter.WriteElementString("simulationNum", this.simulationNum_);
            //            xmlWriter.WriteEndElement();
            //        xmlWriter.WriteEndElement();

            //        xmlWriter.WriteStartElement("standard_para");

            //        //xmlWriter.WriteElementString("simulationNum", this.simulationNum_);

            //        excel_underlyingCalcInfo_paraViewModel_.buildPricingXml(xmlWriter);

            //        excel_discountCurve_paraViewModel_.buildPricingXml(xmlWriter);

            //    xmlWriter.WriteEndElement();
            //xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_parameter serial_Excel_parameter = serial_Class as FpmlSerializedCSharp.Excel_parameter;
            FpmlSerializedCSharp.Excel_standardPara serial_Excel_standardPara = serial_Excel_parameter.Excel_standardPara_;

            this.referenceDate_ = StringConverter.xmlDateToDateTime(serial_Excel_standardPara.ReferenceDate_.ValueStr);

            this.simulationNum_ = serial_Excel_standardPara.SimulationNum_.ValueStr;

            FpmlSerializedCSharp.Excel_underlyingCalcInfo_para serial_excel_underlyingCalcInfo_para = serial_Excel_standardPara.Excel_underlyingCalcInfo_para_;
            this.excel_underlyingCalcInfo_paraViewModel_ = new Excel_underlyingCalcInfo_paraViewModel();
            this.excel_underlyingCalcInfo_paraViewModel_.setFromSerial(serial_excel_underlyingCalcInfo_para);

            FpmlSerializedCSharp.Excel_discountCurve_para serial_excel_discountCurve_para = serial_Excel_standardPara.Excel_discountCurve_para_;
            //string excel_discountCurve_paratype = serial_excel_discountCurve_para.Type_.ValueStr;
            //this.excel_discountCurve_paraViewModel_ = Excel_discountCurve_paraViewModel.CreateExcel_discountCurve_para(excel_discountCurve_paratype);
            this.excel_discountCurve_paraViewModel_ = new Excel_discountCurve_paraViewModel();
            this.excel_discountCurve_paraViewModel_.setFromSerial(serial_excel_discountCurve_para);


        }

        // product 화면에 underlying이 추가댔을 경우 그 이벤트를 받는 놈.
        public override void instrumentEventObserver(object sender, PropertyChangedEventArgs e)
        {
            Excel_underlyingCalcInfoViewModel senderVM = sender as Excel_underlyingCalcInfoViewModel;

            int count = senderVM.Excel_underlyingInfoViewModel_.Count;

            if (count > 0)
            {
                Excel_underlyingInfoViewModel e_uivm = senderVM.Excel_underlyingInfoViewModel_[count - 1];

                //// model associated type defined class
                //UnderlyingModelSetting ums = new UnderlyingModelSetting();

                // 원래 setting 해논 놈을 씀 UnderlyingModelSetting_
                Excel_underlyingInfo_paraViewModel e_uipvm =
                    this.UnderlyingModelSetting_.getUnderlyingParameterModel(e_uivm);

                this.excel_underlyingCalcInfo_paraViewModel_.
                    Excel_underlyingInfo_paraViewModel_.Add(e_uipvm);

                this.excel_underlyingCalcInfo_paraViewModel_.
                    Excel_correlationInfo_paraViewModel_.addUnderlying(e_uipvm.UnderNameTrans_.Value_);
            }
            else
            {
                OutputLogViewModel.addResult("input underlying num is 0");
            }
        }

        public override void masterEventObserver(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        // -> underlyingCalcInfoVM 으로 옮겼음 ( 2014-12-02 )
        //public override string historyUnderData(DateTime startDate, bool bodyOnly = false)
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

        public override Control view()
        {
            Control v = new Excel_standardParaView();

            //this.referenceDate_ = DateTime.Now;
            //this.simulationNum_ = "10000";

            v.DataContext = this;

            return v;
        }

        public override void loadMarketData(DateTime referenceDate)
        {
            this.excel_underlyingCalcInfo_paraViewModel_.loadMarketData(referenceDate);
            this.excel_discountCurve_paraViewModel_.loadMarketData(referenceDate);
        }

        public override void buildParaSetting(ParameterSettingManager paraSettingManager)
        {
            this.excel_underlyingCalcInfo_paraViewModel_.buildParaSetting(paraSettingManager);
            this.excel_discountCurve_paraViewModel_.buildParaSetting(paraSettingManager);
        }
    }
    
}

