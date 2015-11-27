using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_standardParaViewModel : Excel_parameterViewModel
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
        
        public Excel_standardParaViewModel() { }
        
        #region ReferenceDate_
        private DateTime referenceDate_;
        public DateTime ReferenceDate_
        {
            get { return this.referenceDate_; }
            set
            {
                if (this.referenceDate_ != value)
                {
                    this.referenceDate_ = value;
                    this.NotifyPropertyChanged("ReferenceDate_");
                }
            }
        }
        #endregion
        
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
                xmlWriter.WriteElementString("type" , "excel_standardPara");
                xmlWriter.WriteStartElement("excel_standardPara");
                    xmlWriter.WriteElementString("referenceDate" , StringConverter.xmlDateTimeToDateString(this.referenceDate_));
                    
                    xmlWriter.WriteElementString("simulationNum" , this.simulationNum_);
                    
                    excel_underlyingCalcInfo_paraViewModel_.buildXml(xmlWriter);
                    
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
            Control v = new Excel_standardParaView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_parameter serial_Excel_parameter = serial_Class as FpmlSerializedCSharp.Excel_parameter;
            FpmlSerializedCSharp.Excel_standardPara serial_Excel_standardPara = serial_Excel_parameter.Excel_standardPara_;
        
            this.referenceDate_ = StringConverter.xmlDateToDateTime(serial_Excel_standardPara.ReferenceDate_.ValueStr);
            
            this.simulationNum_ = serial_Excel_standardPara.SimulationNum_.ValueStr;
            
            FpmlSerializedCSharp.Excel_underlyingCalcInfo_para serial_excel_underlyingCalcInfo_para = serial_Excel_standardPara.Excel_underlyingCalcInfo_para_;
            string excel_underlyingCalcInfo_paratype = serial_excel_underlyingCalcInfo_para.Excel_type_.ValueStr;
            this.excel_underlyingCalcInfo_paraViewModel_ = Excel_underlyingCalcInfo_paraViewModel.CreateExcel_underlyingCalcInfo_para(excel_underlyingCalcInfo_paratype);
            this.excel_underlyingCalcInfo_paraViewModel_.setFromSerial(serial_excel_underlyingCalcInfo_para);
            
            FpmlSerializedCSharp.Excel_discountCurve_para serial_excel_discountCurve_para = serial_Excel_standardPara.Excel_discountCurve_para_;
            string excel_discountCurve_paratype = serial_excel_discountCurve_para.Excel_type_.ValueStr;
            this.excel_discountCurve_paraViewModel_ = Excel_discountCurve_paraViewModel.CreateExcel_discountCurve_para(excel_discountCurve_paratype);
            this.excel_discountCurve_paraViewModel_.setFromSerial(serial_excel_discountCurve_para);
            
        }
        
        
    
            
            
            
            
        
    
        
    
    }
    
}

