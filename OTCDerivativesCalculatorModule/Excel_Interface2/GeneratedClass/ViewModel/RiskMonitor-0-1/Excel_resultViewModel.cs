using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_resultViewModel : IXmlData
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
        
        public Excel_resultViewModel() { }
        
        #region CalculationDate_
        private DateTime calculationDate_;
        public DateTime CalculationDate_
        {
            get { return this.calculationDate_; }
            set
            {
                if (this.calculationDate_ != value)
                {
                    this.calculationDate_ = value;
                    this.NotifyPropertyChanged("CalculationDate_");
                }
            }
        }
        #endregion
        
        #region Excel_valueResultViewModel_
        private Excel_valueResultViewModel excel_valueResultViewModel_;
        public Excel_valueResultViewModel Excel_valueResultViewModel_
        {
            get { return this.excel_valueResultViewModel_; }
            set
            {
                if (this.excel_valueResultViewModel_ != value)
                {
                    this.excel_valueResultViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_valueResultViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_greekResultViewModel_
        private Excel_greekResultViewModel excel_greekResultViewModel_;
        public Excel_greekResultViewModel Excel_greekResultViewModel_
        {
            get { return this.excel_greekResultViewModel_; }
            set
            {
                if (this.excel_greekResultViewModel_ != value)
                {
                    this.excel_greekResultViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_greekResultViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_cashFlowsResultViewModel_
        private Excel_cashFlowsResultViewModel excel_cashFlowsResultViewModel_;
        public Excel_cashFlowsResultViewModel Excel_cashFlowsResultViewModel_
        {
            get { return this.excel_cashFlowsResultViewModel_; }
            set
            {
                if (this.excel_cashFlowsResultViewModel_ != value)
                {
                    this.excel_cashFlowsResultViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_cashFlowsResultViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public  void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("iXmlData");
                xmlWriter.WriteElementString("excel_type" , "excel_result");
                xmlWriter.WriteStartElement("excel_result");
                    xmlWriter.WriteElementString("calculationDate" , StringConverter.xmlDateTimeToDateString(this.calculationDate_));
                    
                    excel_valueResultViewModel_.buildXml(xmlWriter);
                    
                    excel_greekResultViewModel_.buildXml(xmlWriter);
                    
                    excel_cashFlowsResultViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public  void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public  Control view()
        {
            Control v = new Excel_resultView();
            v.DataContext = this;
            return v;
        }
        
        public  void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_result serial_Excel_result = serial_Class as FpmlSerializedCSharp.Excel_result;
        
            this.calculationDate_ = StringConverter.xmlDateToDateTime(serial_Excel_result.CalculationDate_.ValueStr);
            
            FpmlSerializedCSharp.Excel_valueResult serial_excel_valueResult = serial_Excel_result.Excel_valueResult_;
            string excel_valueResulttype = serial_excel_valueResult.Excel_type_.ValueStr;
            this.excel_valueResultViewModel_ = Excel_valueResultViewModel.CreateExcel_valueResult(excel_valueResulttype);
            this.excel_valueResultViewModel_.setFromSerial(serial_excel_valueResult);
            
            FpmlSerializedCSharp.Excel_greekResult serial_excel_greekResult = serial_Excel_result.Excel_greekResult_;
            string excel_greekResulttype = serial_excel_greekResult.Excel_type_.ValueStr;
            this.excel_greekResultViewModel_ = Excel_greekResultViewModel.CreateExcel_greekResult(excel_greekResulttype);
            this.excel_greekResultViewModel_.setFromSerial(serial_excel_greekResult);
            
            FpmlSerializedCSharp.Excel_cashFlowsResult serial_excel_cashFlowsResult = serial_Excel_result.Excel_cashFlowsResult_;
            string excel_cashFlowsResulttype = serial_excel_cashFlowsResult.Excel_type_.ValueStr;
            this.excel_cashFlowsResultViewModel_ = Excel_cashFlowsResultViewModel.CreateExcel_cashFlowsResult(excel_cashFlowsResulttype);
            this.excel_cashFlowsResultViewModel_.setFromSerial(serial_excel_cashFlowsResult);
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

