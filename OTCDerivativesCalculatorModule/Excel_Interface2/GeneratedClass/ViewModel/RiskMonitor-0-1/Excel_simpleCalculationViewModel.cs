using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_simpleCalculationViewModel : Excel_scheduleViewModel
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
        
        public Excel_simpleCalculationViewModel() { }
        
        #region EventDate_
        private DateTime eventDate_;
        public DateTime EventDate_
        {
            get { return this.eventDate_; }
            set
            {
                if (this.eventDate_ != value)
                {
                    this.eventDate_ = value;
                    this.NotifyPropertyChanged("EventDate_");
                }
            }
        }
        #endregion
        
        #region PayoffDate_
        private DateTime payoffDate_;
        public DateTime PayoffDate_
        {
            get { return this.payoffDate_; }
            set
            {
                if (this.payoffDate_ != value)
                {
                    this.payoffDate_ = value;
                    this.NotifyPropertyChanged("PayoffDate_");
                }
            }
        }
        #endregion
        
        #region Description_
        private string description_;
        public string Description_
        {
            get { return this.description_; }
            set
            {
                if (this.description_ != value)
                {
                    this.description_ = value;
                    this.NotifyPropertyChanged("Description_");
                }
            }
        }
        #endregion
        
        #region Vba_description_
        private string vba_description_;
        public string Vba_description_
        {
            get { return this.vba_description_; }
            set
            {
                if (this.vba_description_ != value)
                {
                    this.vba_description_ = value;
                    this.NotifyPropertyChanged("Vba_description_");
                }
            }
        }
        #endregion
        
        #region Excel_eventCalcInfoViewModel_
        private Excel_eventCalcInfoViewModel excel_eventCalcInfoViewModel_;
        public Excel_eventCalcInfoViewModel Excel_eventCalcInfoViewModel_
        {
            get { return this.excel_eventCalcInfoViewModel_; }
            set
            {
                if (this.excel_eventCalcInfoViewModel_ != value)
                {
                    this.excel_eventCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_eventCalcInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_returnCalcInfoViewModel_
        private Excel_returnCalcInfoViewModel excel_returnCalcInfoViewModel_;
        public Excel_returnCalcInfoViewModel Excel_returnCalcInfoViewModel_
        {
            get { return this.excel_returnCalcInfoViewModel_; }
            set
            {
                if (this.excel_returnCalcInfoViewModel_ != value)
                {
                    this.excel_returnCalcInfoViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_returnCalcInfoViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_complementReturnCalcViewModel_
        private Excel_complementReturnCalcViewModel excel_complementReturnCalcViewModel_;
        public Excel_complementReturnCalcViewModel Excel_complementReturnCalcViewModel_
        {
            get { return this.excel_complementReturnCalcViewModel_; }
            set
            {
                if (this.excel_complementReturnCalcViewModel_ != value)
                {
                    this.excel_complementReturnCalcViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_complementReturnCalcViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_eventCalcInfo_CallViewModel_
        private Excel_eventCalcInfo_CallViewModel excel_eventCalcInfo_CallViewModel_;
        public Excel_eventCalcInfo_CallViewModel Excel_eventCalcInfo_CallViewModel_
        {
            get { return this.excel_eventCalcInfo_CallViewModel_; }
            set
            {
                if (this.excel_eventCalcInfo_CallViewModel_ != value)
                {
                    this.excel_eventCalcInfo_CallViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_eventCalcInfo_CallViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_returnCalcInfo_CallViewModel_
        private Excel_returnCalcInfo_CallViewModel excel_returnCalcInfo_CallViewModel_;
        public Excel_returnCalcInfo_CallViewModel Excel_returnCalcInfo_CallViewModel_
        {
            get { return this.excel_returnCalcInfo_CallViewModel_; }
            set
            {
                if (this.excel_returnCalcInfo_CallViewModel_ != value)
                {
                    this.excel_returnCalcInfo_CallViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_returnCalcInfo_CallViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_complementReturnCalc_CallViewModel_
        private Excel_complementReturnCalc_CallViewModel excel_complementReturnCalc_CallViewModel_;
        public Excel_complementReturnCalc_CallViewModel Excel_complementReturnCalc_CallViewModel_
        {
            get { return this.excel_complementReturnCalc_CallViewModel_; }
            set
            {
                if (this.excel_complementReturnCalc_CallViewModel_ != value)
                {
                    this.excel_complementReturnCalc_CallViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_complementReturnCalc_CallViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_returnCalcInfo_CallableOptionViewModel_
        private Excel_returnCalcInfo_CallableOptionViewModel excel_returnCalcInfo_CallableOptionViewModel_;
        public Excel_returnCalcInfo_CallableOptionViewModel Excel_returnCalcInfo_CallableOptionViewModel_
        {
            get { return this.excel_returnCalcInfo_CallableOptionViewModel_; }
            set
            {
                if (this.excel_returnCalcInfo_CallableOptionViewModel_ != value)
                {
                    this.excel_returnCalcInfo_CallableOptionViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_returnCalcInfo_CallableOptionViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_schedule");
                xmlWriter.WriteElementString("excel_type" , "excel_simpleCalculation");
                xmlWriter.WriteStartElement("excel_simpleCalculation");
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                    xmlWriter.WriteElementString("description" , this.description_);
                    
                    xmlWriter.WriteElementString("vba_description" , this.vba_description_);
                    
                    excel_eventCalcInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_returnCalcInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_complementReturnCalcViewModel_.buildXml(xmlWriter);
                    
                    excel_eventCalcInfo_CallViewModel_.buildXml(xmlWriter);
                    
                    excel_returnCalcInfo_CallViewModel_.buildXml(xmlWriter);
                    
                    excel_complementReturnCalc_CallViewModel_.buildXml(xmlWriter);
                    
                    excel_returnCalcInfo_CallableOptionViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_simpleCalculationView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_schedule serial_Excel_schedule = serial_Class as FpmlSerializedCSharp.Excel_schedule;
            FpmlSerializedCSharp.Excel_simpleCalculation serial_Excel_simpleCalculation = serial_Excel_schedule.Excel_simpleCalculation_;
        
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_simpleCalculation.EventDate_.ValueStr);
            
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_simpleCalculation.PayoffDate_.ValueStr);
            
            this.description_ = serial_Excel_simpleCalculation.Description_.ValueStr;
            
            this.vba_description_ = serial_Excel_simpleCalculation.Vba_description_.ValueStr;
            
            FpmlSerializedCSharp.Excel_eventCalcInfo serial_excel_eventCalcInfo = serial_Excel_simpleCalculation.Excel_eventCalcInfo_;
            string excel_eventCalcInfotype = serial_excel_eventCalcInfo.Excel_type_.ValueStr;
            this.excel_eventCalcInfoViewModel_ = Excel_eventCalcInfoViewModel.CreateExcel_eventCalcInfo(excel_eventCalcInfotype);
            this.excel_eventCalcInfoViewModel_.setFromSerial(serial_excel_eventCalcInfo);
            
            FpmlSerializedCSharp.Excel_returnCalcInfo serial_excel_returnCalcInfo = serial_Excel_simpleCalculation.Excel_returnCalcInfo_;
            string excel_returnCalcInfotype = serial_excel_returnCalcInfo.Excel_type_.ValueStr;
            this.excel_returnCalcInfoViewModel_ = Excel_returnCalcInfoViewModel.CreateExcel_returnCalcInfo(excel_returnCalcInfotype);
            this.excel_returnCalcInfoViewModel_.setFromSerial(serial_excel_returnCalcInfo);
            
            FpmlSerializedCSharp.Excel_complementReturnCalc serial_excel_complementReturnCalc = serial_Excel_simpleCalculation.Excel_complementReturnCalc_;
            string excel_complementReturnCalctype = serial_excel_complementReturnCalc.Excel_type_.ValueStr;
            this.excel_complementReturnCalcViewModel_ = Excel_complementReturnCalcViewModel.CreateExcel_complementReturnCalc(excel_complementReturnCalctype);
            this.excel_complementReturnCalcViewModel_.setFromSerial(serial_excel_complementReturnCalc);
            
            FpmlSerializedCSharp.Excel_eventCalcInfo_Call serial_excel_eventCalcInfo_Call = serial_Excel_simpleCalculation.Excel_eventCalcInfo_Call_;
            string excel_eventCalcInfo_Calltype = serial_excel_eventCalcInfo_Call.Excel_type_.ValueStr;
            this.excel_eventCalcInfo_CallViewModel_ = Excel_eventCalcInfo_CallViewModel.CreateExcel_eventCalcInfo_Call(excel_eventCalcInfo_Calltype);
            this.excel_eventCalcInfo_CallViewModel_.setFromSerial(serial_excel_eventCalcInfo_Call);
            
            FpmlSerializedCSharp.Excel_returnCalcInfo_Call serial_excel_returnCalcInfo_Call = serial_Excel_simpleCalculation.Excel_returnCalcInfo_Call_;
            string excel_returnCalcInfo_Calltype = serial_excel_returnCalcInfo_Call.Excel_type_.ValueStr;
            this.excel_returnCalcInfo_CallViewModel_ = Excel_returnCalcInfo_CallViewModel.CreateExcel_returnCalcInfo_Call(excel_returnCalcInfo_Calltype);
            this.excel_returnCalcInfo_CallViewModel_.setFromSerial(serial_excel_returnCalcInfo_Call);
            
            FpmlSerializedCSharp.Excel_complementReturnCalc_Call serial_excel_complementReturnCalc_Call = serial_Excel_simpleCalculation.Excel_complementReturnCalc_Call_;
            string excel_complementReturnCalc_Calltype = serial_excel_complementReturnCalc_Call.Excel_type_.ValueStr;
            this.excel_complementReturnCalc_CallViewModel_ = Excel_complementReturnCalc_CallViewModel.CreateExcel_complementReturnCalc_Call(excel_complementReturnCalc_Calltype);
            this.excel_complementReturnCalc_CallViewModel_.setFromSerial(serial_excel_complementReturnCalc_Call);
            
            FpmlSerializedCSharp.Excel_returnCalcInfo_CallableOption serial_excel_returnCalcInfo_CallableOption = serial_Excel_simpleCalculation.Excel_returnCalcInfo_CallableOption_;
            string excel_returnCalcInfo_CallableOptiontype = serial_excel_returnCalcInfo_CallableOption.Excel_type_.ValueStr;
            this.excel_returnCalcInfo_CallableOptionViewModel_ = Excel_returnCalcInfo_CallableOptionViewModel.CreateExcel_returnCalcInfo_CallableOption(excel_returnCalcInfo_CallableOptiontype);
            this.excel_returnCalcInfo_CallableOptionViewModel_.setFromSerial(serial_excel_returnCalcInfo_CallableOption);
            
        }
        
        
    
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        
    
        
    
    }
    
}

