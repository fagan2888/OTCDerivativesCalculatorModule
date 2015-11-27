using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_compositeOptionViewModel : Excel_interfaceViewModel
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
        
        public Excel_compositeOptionViewModel() { }
        
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
        
        #region ExerciseDate_
        private DateTime exerciseDate_;
        public DateTime ExerciseDate_
        {
            get { return this.exerciseDate_; }
            set
            {
                if (this.exerciseDate_ != value)
                {
                    this.exerciseDate_ = value;
                    this.NotifyPropertyChanged("ExerciseDate_");
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
        
        #region NotionalMaturityPayment_
        private string notionalMaturityPayment_;
        public string NotionalMaturityPayment_
        {
            get { return this.notionalMaturityPayment_; }
            set
            {
                if (this.notionalMaturityPayment_ != value)
                {
                    this.notionalMaturityPayment_ = value;
                    this.NotifyPropertyChanged("NotionalMaturityPayment_");
                }
            }
        }
        #endregion
        
        #region Excel_compositeOption_subtypeViewModel_
        private ObservableCollection<Excel_compositeOption_subtypeViewModel> excel_compositeOption_subtypeViewModel_;
        public ObservableCollection<Excel_compositeOption_subtypeViewModel> Excel_compositeOption_subtypeViewModel_
        {
            get { return this.excel_compositeOption_subtypeViewModel_; }
            set
            {
                if (this.excel_compositeOption_subtypeViewModel_ != value)
                {
                    this.excel_compositeOption_subtypeViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_compositeOption_subtypeViewModel_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_interface");
                xmlWriter.WriteElementString("excel_type" , "excel_compositeOption");
                xmlWriter.WriteStartElement("excel_compositeOption");
                    excel_issueInfoViewModel_.buildXml(xmlWriter);
                    
                    excel_underlyingCalcInfoViewModel_.buildXml(xmlWriter);
                    
                    xmlWriter.WriteElementString("exerciseDate" , StringConverter.xmlDateTimeToDateString(this.exerciseDate_));
                    
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                    xmlWriter.WriteElementString("notionalMaturityPayment" , this.notionalMaturityPayment_);
                    
                    foreach (var item in excel_compositeOption_subtypeViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_compositeOptionView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_interface serial_Excel_interface = serial_Class as FpmlSerializedCSharp.Excel_interface;
            FpmlSerializedCSharp.Excel_compositeOption serial_Excel_compositeOption = serial_Excel_interface.Excel_compositeOption_;
        
            FpmlSerializedCSharp.Excel_issueInfo serial_excel_issueInfo = serial_Excel_compositeOption.Excel_issueInfo_;
            string excel_issueInfotype = serial_excel_issueInfo.Excel_type_.ValueStr;
            this.excel_issueInfoViewModel_ = Excel_issueInfoViewModel.CreateExcel_issueInfo(excel_issueInfotype);
            this.excel_issueInfoViewModel_.setFromSerial(serial_excel_issueInfo);
            
            FpmlSerializedCSharp.Excel_underlyingCalcInfo serial_excel_underlyingCalcInfo = serial_Excel_compositeOption.Excel_underlyingCalcInfo_;
            string excel_underlyingCalcInfotype = serial_excel_underlyingCalcInfo.Excel_type_.ValueStr;
            this.excel_underlyingCalcInfoViewModel_ = Excel_underlyingCalcInfoViewModel.CreateExcel_underlyingCalcInfo(excel_underlyingCalcInfotype);
            this.excel_underlyingCalcInfoViewModel_.setFromSerial(serial_excel_underlyingCalcInfo);
            
            this.exerciseDate_ = StringConverter.xmlDateToDateTime(serial_Excel_compositeOption.ExerciseDate_.ValueStr);
            
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_compositeOption.PayoffDate_.ValueStr);
            
            this.notionalMaturityPayment_ = serial_Excel_compositeOption.NotionalMaturityPayment_.ValueStr;
            
            List<FpmlSerializedCSharp.Excel_compositeOption_subtype> serial_excel_compositeOption_subtype = serial_Excel_compositeOption.Excel_compositeOption_subtype_;
            this.excel_compositeOption_subtypeViewModel_ = new ObservableCollection<Excel_compositeOption_subtypeViewModel>();
            foreach (var item in serial_excel_compositeOption_subtype)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_compositeOption_subtypeViewModel viewModel = Excel_compositeOption_subtypeViewModel.CreateExcel_compositeOption_subtype(type);
                viewModel.setFromSerial(item);
                this.excel_compositeOption_subtypeViewModel_.Add(viewModel);
            }
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

