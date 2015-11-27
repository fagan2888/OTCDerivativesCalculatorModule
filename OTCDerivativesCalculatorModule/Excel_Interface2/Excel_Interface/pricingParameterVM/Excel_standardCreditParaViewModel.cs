using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_standardCreditParaViewModel : Excel_parameterViewModel
    {
        public Excel_standardCreditParaViewModel() 
        {
            this.excel_underlyingCalcInfo_paraViewModel_ = new Excel_underlyingCalcInfo_paraViewModel();
            this.excel_referenceCalcInfo_paraViewModel_ = new Excel_referenceCalcInfo_paraViewModel();
            this.excel_discountCurve_paraViewModel_ = new Excel_discountCurve_paraViewModel();
            this.Excel_resultViewModel_ = new Excel_resultViewModel();
        }

        #region SimulationNum_
        private string simulationNum_;
        public string SimulationNum_
        {
            get { return this.simulationNum_; }
            set
            {
                if (this.simulationNum_ != value)
                {
                    this.simulationNum_ = value;
                    this.NotifyPropertyChanged("SimulationNum_");
                }
            }
        }
        #endregion

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

        #region Excel_referenceCalcInfo_paraViewModel_
        private Excel_referenceCalcInfo_paraViewModel excel_referenceCalcInfo_paraViewModel_;
        public Excel_referenceCalcInfo_paraViewModel Excel_referenceCalcInfo_paraViewModel_
        {
            get { return this.excel_referenceCalcInfo_paraViewModel_; }
            set
            {
                if (this.excel_referenceCalcInfo_paraViewModel_ != value)
                {
                    this.excel_referenceCalcInfo_paraViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_referenceCalcInfo_paraViewModel_");
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

        //#region Excel_defaultCurve_paraViewModel_
        //private Excel_defaultCurve_paraViewModel excel_defaultCurve_paraViewModel_;
        //public Excel_defaultCurve_paraViewModel Excel_defaultCurve_paraViewModel_
        //{
        //    get { return this.excel_defaultCurve_paraViewModel_; }
        //    set
        //    {
        //        if (this.excel_defaultCurve_paraViewModel_ != value)
        //        {
        //            this.excel_defaultCurve_paraViewModel_ = value;
        //            this.NotifyPropertyChanged("Excel_defaultCurve_paraViewModel_");
        //        }
        //    }
        //}
        //#endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_parameter");
                xmlWriter.WriteElementString("excel_type", "excel_standardCreditPara");
                xmlWriter.WriteStartElement("excel_standardCreditPara");
                xmlWriter.WriteElementString("referenceDate", this.referenceDate_.ToString("yyyy-MM-dd"));

                xmlWriter.WriteElementString("simulationNum", this.simulationNum_);

                excel_underlyingCalcInfo_paraViewModel_.buildXml(xmlWriter);

                excel_referenceCalcInfo_paraViewModel_.buildXml(xmlWriter);

                excel_discountCurve_paraViewModel_.buildXml(xmlWriter);


                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public override Control view()
        {
            Control v = new Excel_standardCreditParaView();
            v.DataContext = this;
            return v;
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_parameter serial_Excel_parameter = serial_Class as FpmlSerializedCSharp.Excel_parameter;
            FpmlSerializedCSharp.Excel_standardCreditPara serial_Excel_standardCreditPara = serial_Excel_parameter.Excel_standardCreditPara_;

            this.referenceDate_ = StringConverter.xmlDateToDateTime(serial_Excel_standardCreditPara.ReferenceDate_.ValueStr);

            this.simulationNum_ = serial_Excel_standardCreditPara.SimulationNum_.ValueStr;

            FpmlSerializedCSharp.Excel_underlyingCalcInfo_para serial_excel_underlyingCalcInfo_para = serial_Excel_standardCreditPara.Excel_underlyingCalcInfo_para_;
            //string excel_underlyingCalcInfo_paratype = serial_excel_underlyingCalcInfo_para.Excel_type_.ValueStr;
            this.excel_underlyingCalcInfo_paraViewModel_ = new Excel_underlyingCalcInfo_paraViewModel();//.CreateExcel_underlyingCalcInfo_para(excel_underlyingCalcInfo_paratype);
            this.excel_underlyingCalcInfo_paraViewModel_.setFromSerial(serial_excel_underlyingCalcInfo_para);

            FpmlSerializedCSharp.Excel_referenceCalcInfo_para serial_excel_referenceCalcInfo_para = serial_Excel_standardCreditPara.Excel_referenceCalcInfo_para_;
            //string excel_referenceCalcInfo_paratype = serial_excel_referenceCalcInfo_para.Excel_type_.ValueStr;
            this.excel_referenceCalcInfo_paraViewModel_ = new Excel_referenceCalcInfo_paraViewModel();//.CreateExcel_referenceCalcInfo_para(excel_referenceCalcInfo_paratype);
            this.excel_referenceCalcInfo_paraViewModel_.setFromSerial(serial_excel_referenceCalcInfo_para);

            FpmlSerializedCSharp.Excel_discountCurve_para serial_excel_discountCurve_para = serial_Excel_standardCreditPara.Excel_discountCurve_para_;
            //string excel_discountCurve_paratype = serial_excel_discountCurve_para.Excel_type_.ValueStr;
            this.excel_discountCurve_paraViewModel_ = new Excel_discountCurve_paraViewModel();//.CreateExcel_discountCurve_para(excel_discountCurve_paratype);
            this.excel_discountCurve_paraViewModel_.setFromSerial(serial_excel_discountCurve_para);

            //FpmlSerializedCSharp.Excel_defaultCurve_para serial_excel_defaultCurve_para = serial_Excel_standardCreditPara.Excel_defaultCurve_para_;
            ////string excel_defaultCurve_paratype = serial_excel_defaultCurve_para.Excel_type_.ValueStr;
            //this.excel_defaultCurve_paraViewModel_ = new Excel_defaultCurve_paraViewModel();
            //this.excel_defaultCurve_paraViewModel_.setFromSerial(serial_excel_defaultCurve_para);

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
            //throw new NotImplementedException();
        }

        public override void dicountCurveEventObserver(object sender, PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void loadMarketData(DateTime referenceDate)
        {
            throw new NotImplementedException();
        }

        public override void buildParaSetting(ParameterSettingManager paraSettingManager)
        {
            throw new NotImplementedException();
        }
    }

}

