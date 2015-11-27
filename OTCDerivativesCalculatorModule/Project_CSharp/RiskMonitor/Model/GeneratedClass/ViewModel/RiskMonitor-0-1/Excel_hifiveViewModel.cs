using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_hifiveViewModel : Excel_interfaceViewModel
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
        
        public Excel_hifiveViewModel() { }
        
        #region Excel_issueInfoViewModel_
        private Excel_issueInfoViewModel excel_issueInfoViewModel_;
        public Excel_issueInfoViewModel Excel_issueInfoViewModel_
        {
            get { return this.excel_issueInfoViewModel_; }
            set
            {
                if (this.excel_issueInfoViewModel_ != value)
                {
                    this.excel_issueInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_issueInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_underlyingCalcInfoViewModel_
        private Excel_underlyingCalcInfoViewModel excel_underlyingCalcInfoViewModel_;
        public Excel_underlyingCalcInfoViewModel Excel_underlyingCalcInfoViewModel_
        {
            get { return this.excel_underlyingCalcInfoViewModel_; }
            set
            {
                if (this.excel_underlyingCalcInfoViewModel_ != value)
                {
                    this.excel_underlyingCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_hifive_subtypeViewModel_
        private Excel_hifive_subtypeViewModel excel_hifive_subtypeViewModel_;
        public Excel_hifive_subtypeViewModel Excel_hifive_subtypeViewModel_
        {
            get { return this.excel_hifive_subtypeViewModel_; }
            set
            {
                if (this.excel_hifive_subtypeViewModel_ != value)
                {
                    this.excel_hifive_subtypeViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_hifive_subtypeViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_scheduleListViewModel_
        private Excel_scheduleListViewModel excel_scheduleListViewModel_;
        public Excel_scheduleListViewModel Excel_scheduleListViewModel_
        {
            get { return this.excel_scheduleListViewModel_; }
            set
            {
                if (this.excel_scheduleListViewModel_ != value)
                {
                    this.excel_scheduleListViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_scheduleListViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_kiEventCalculationViewModel_
        private Excel_kiEventCalculationViewModel excel_kiEventCalculationViewModel_;
        public Excel_kiEventCalculationViewModel Excel_kiEventCalculationViewModel_
        {
            get { return this.excel_kiEventCalculationViewModel_; }
            set
            {
                if (this.excel_kiEventCalculationViewModel_ != value)
                {
                    this.excel_kiEventCalculationViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_kiEventCalculationViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("type" , "excel_hifive");
                xmlWriter.WriteStartElement("excel_hifive");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_hifive_subtypeViewModel_.buildXml(xmlWriter);
                    
                    excel_scheduleListViewModel_.buildXml(xmlWriter);
                    
                    excel_kiEventCalculationViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_hifiveView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_hifive serial_Excel_hifive = serial_Excel_interface.Excel_hifive_;
        
            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_hifive.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);
            
            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_hifive.Excel_underlyingCalcInfo_;
            string excel_underlyingCalcInfotype = serial_excel_underlyingCalcInfo.Excel_type_.ValueStr;
            this.excel_underlyingCalcInfoViewModel_ = Excel_underlyingCalcInfoViewModel.CreateExcel_underlyingCalcInfo(excel_underlyingCalcInfotype);
            this.excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);
            
            FpmlSerializedCSharp.Excel_hifive_subtype serial_excel_hifive_subtype = serial_Excel_hifive.Excel_hifive_subtype_;
            string excel_hifive_subtypetype = serial_excel_hifive_subtype.Excel_type_.ValueStr;
            this.excel_hifive_subtypeViewModel_ = Excel_hifive_subtypeViewModel.CreateExcel_hifive_subtype(excel_hifive_subtypetype);
            this.excel_hifive_subtypeViewModel_.setFromSerial(serial_excel_hifive_subtype);
            
            FpmlSerializedCSharp.Excel_scheduleList serial_excel_scheduleList = serial_Excel_hifive.Excel_scheduleList_;
            string excel_scheduleListtype = serial_excel_scheduleList.Excel_type_.ValueStr;
            this.excel_scheduleListViewModel_ = Excel_scheduleListViewModel.CreateExcel_scheduleList(excel_scheduleListtype);
            this.excel_scheduleListViewModel_.setFromSerial(serial_excel_scheduleList);
            
            FpmlSerializedCSharp.Excel_kiEventCalculation serial_excel_kiEventCalculation = serial_Excel_hifive.Excel_kiEventCalculation_;
            string excel_kiEventCalculationtype = serial_excel_kiEventCalculation.Excel_type_.ValueStr;
            this.excel_kiEventCalculationViewModel_ = Excel_kiEventCalculationViewModel.CreateExcel_kiEventCalculation(excel_kiEventCalculationtype);
            this.excel_kiEventCalculationViewModel_.setFromSerial(serial_excel_kiEventCalculation);
            
        }
        
        
    
            
            
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

