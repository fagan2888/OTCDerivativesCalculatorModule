using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_standardSwapParaViewModel : Excel_parameterViewModel
    {
        public Excel_standardSwapParaViewModel() 
        {
            //this.excel_underlyingCalcInfo_paraViewModel_ = new ObservableCollection<Excel_underlyingCalcInfo_paraViewModel>();
            //this.excel_discountCurve_paraViewModel_ = new ObservableCollection<Excel_discountCurve_paraViewModel>();

            this.excel_underlyingCalcInfo_paraViewModel_ = new Excel_underlyingCalcInfo_paraViewModel();
            this.excel_discountCurve_paraViewModel_ = new Excel_discountCurve_paraViewModel();

            this.Excel_resultViewModel_ = new Excel_resultViewModel();
        }
        
        //#region Excel_underlyingCalcInfo_paraViewModel_
        //private ObservableCollection<Excel_underlyingCalcInfo_paraViewModel> excel_underlyingCalcInfo_paraViewModel_;
        //public ObservableCollection<Excel_underlyingCalcInfo_paraViewModel> Excel_underlyingCalcInfo_paraViewModel_
        //{
        //    get { return this.excel_underlyingCalcInfo_paraViewModel_; }
        //    set
        //    {
        //        if (this.excel_underlyingCalcInfo_paraViewModel_ != value)
        //        {
        //            this.excel_underlyingCalcInfo_paraViewModel_ = value;
        //            this.NotifyPropertyChanged("Excel_underlyingCalcInfo_paraViewModel_");
        //        }
        //    }
        //}
        //#endregion
        
        //#region Excel_discountCurve_paraViewModel_
        //private ObservableCollection<Excel_discountCurve_paraViewModel> excel_discountCurve_paraViewModel_;
        //public ObservableCollection<Excel_discountCurve_paraViewModel> Excel_discountCurve_paraViewModel_
        //{
        //    get { return this.excel_discountCurve_paraViewModel_; }
        //    set
        //    {
        //        if (this.excel_discountCurve_paraViewModel_ != value)
        //        {
        //            this.excel_discountCurve_paraViewModel_ = value;
        //            this.NotifyPropertyChanged("Excel_discountCurve_paraViewModel_");
        //        }
        //    }
        //}
        //#endregion

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
                xmlWriter.WriteStartElement("method");
                    //xmlWriter.WriteStartElement("monte");
                    //    xmlWriter.WriteElementString("simulationNum", "10000");
                    //xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

                xmlWriter.WriteElementString("excel_type" , "excel_standardSwapPara");
                xmlWriter.WriteStartElement("excel_standardSwapPara");
                    xmlWriter.WriteElementString("referenceDate" , this.referenceDate_.ToString(StringFormat.XmlDateFormat_));
                    
                    xmlWriter.WriteElementString("simulationNum" , this.simulationNum_);
                    excel_underlyingCalcInfo_paraViewModel_.buildXml(xmlWriter);

                    excel_discountCurve_paraViewModel_.buildXml(xmlWriter);

                    //foreach (var item in this.excel_underlyingCalcInfo_paraViewModel_)
                    //{
                    //    item.buildXml(xmlWriter);    
                    //}

                    //foreach (var item in this.excel_discountCurve_paraViewModel_)
                    //{
                    //    item.buildXml(xmlWriter);    
                    //}        

                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_standardSwapParaView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_parameter serial_Excel_parameter = serial_Class as FpmlSerializedCSharp.Excel_parameter;
            FpmlSerializedCSharp.Excel_standardSwapPara serial_Excel_standardSwapPara = serial_Excel_parameter.Excel_standardSwapPara_;

            this.referenceDate_ = StringConverter.xmlDateToDateTime(serial_Excel_standardSwapPara.ReferenceDate_.ValueStr);
            
            this.simulationNum_ = serial_Excel_standardSwapPara.SimulationNum_.ValueStr;

            FpmlSerializedCSharp.Excel_underlyingCalcInfo_para serial_excel_underlyingCalcInfo_para = serial_Excel_standardSwapPara.Excel_underlyingCalcInfo_para_;
            //string excel_underlyingCalcInfo_paratype = serial_excel_underlyingCalcInfo_para.Excel_type_.ValueStr;
            this.excel_underlyingCalcInfo_paraViewModel_ = new Excel_underlyingCalcInfo_paraViewModel();
            this.excel_underlyingCalcInfo_paraViewModel_.setFromSerial(serial_excel_underlyingCalcInfo_para);

            FpmlSerializedCSharp.Excel_discountCurve_para serial_excel_discountCurve_para = serial_Excel_standardSwapPara.Excel_discountCurve_para_;
            //string excel_discountCurve_paratype = serial_excel_discountCurve_para.Excel_type_.ValueStr;
            this.excel_discountCurve_paraViewModel_ = new Excel_discountCurve_paraViewModel();
            this.excel_discountCurve_paraViewModel_.setFromSerial(serial_excel_discountCurve_para);

            //List<FpmlSerializedCSharp.Excel_underlyingCalcInfo_para> serial_excel_underlyingCalcInfo_para = serial_Excel_standardSwapPara.Excel_underlyingCalcInfo_para_;
            //this.excel_underlyingCalcInfo_paraViewModel_ = new ObservableCollection<Excel_underlyingCalcInfo_paraViewModel>();
            //foreach (var item in serial_excel_underlyingCalcInfo_para)
            //{
            //    //string type = item.Excel_type_.ValueStr;
            //    Excel_underlyingCalcInfo_paraViewModel viewModel = new Excel_underlyingCalcInfo_paraViewModel();
            //    viewModel.setFromSerial(item);
            //    this.excel_underlyingCalcInfo_paraViewModel_.Add(viewModel);
            //}
            
            //List<FpmlSerializedCSharp.Excel_discountCurve_para> serial_excel_discountCurve_para = serial_Excel_standardSwapPara.Excel_discountCurve_para_;
            //this.excel_discountCurve_paraViewModel_ = new ObservableCollection<Excel_discountCurve_paraViewModel>();
            //foreach (var item in serial_excel_discountCurve_para)
            //{
            //    //string type = item.Excel_type_.ValueStr;
            //    Excel_discountCurve_paraViewModel viewModel = new Excel_discountCurve_paraViewModel();
            //    viewModel.setFromSerial(item);
            //    this.excel_discountCurve_paraViewModel_.Add(viewModel);
            //}
            
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

        //public override string historyUnderData(DateTime startDate, bool bodyOnly = false)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    XmlWriterSettings setting = new XmlWriterSettings();

        //    setting.Indent = true;
        //    //setting.Encoding = Encoding.UTF8;
        //    if (bodyOnly)
        //        setting.OmitXmlDeclaration = true;

        //    XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

        //    this.excel_underlyingCalcInfo_paraViewModel_.historyUnderData(xmlWriter, this.issueDate_, this.referenceDate_);

        //    return sb.ToString();

        //}

        public override void loadMarketData(DateTime referenceDate)
        {
            this.excel_underlyingCalcInfo_paraViewModel_.loadMarketData(referenceDate);
            this.excel_underlyingCalcInfo_paraViewModel_.loadMarketData(referenceDate);
        }

        public override void buildParaSetting(ParameterSettingManager paraSettingManager)
        {
            this.excel_underlyingCalcInfo_paraViewModel_.buildParaSetting(paraSettingManager);
            this.excel_discountCurve_paraViewModel_.buildParaSetting(paraSettingManager);
        }
    }
    
}

