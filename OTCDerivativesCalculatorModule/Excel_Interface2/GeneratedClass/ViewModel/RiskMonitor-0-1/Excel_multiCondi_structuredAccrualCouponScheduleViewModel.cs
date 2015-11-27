using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_multiCondi_structuredAccrualCouponScheduleViewModel : Excel_couponScheduleViewModel
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
        
        public Excel_multiCondi_structuredAccrualCouponScheduleViewModel() { }
        
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
        
        #region CalculationStartDate_
        private DateTime calculationStartDate_;
        public DateTime CalculationStartDate_
        {
            get { return this.calculationStartDate_; }
            set
            {
                if (this.calculationStartDate_ != value)
                {
                    this.calculationStartDate_ = value;
                    this.NotifyPropertyChanged("CalculationStartDate_");
                }
            }
        }
        #endregion
        
        #region CalculationEndDate_
        private DateTime calculationEndDate_;
        public DateTime CalculationEndDate_
        {
            get { return this.calculationEndDate_; }
            set
            {
                if (this.calculationEndDate_ != value)
                {
                    this.calculationEndDate_ = value;
                    this.NotifyPropertyChanged("CalculationEndDate_");
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
        
        #region Range1DViewModel_
        private ObservableCollection<Range1DViewModel> range1DViewModel_;
        public ObservableCollection<Range1DViewModel> Range1DViewModel_
        {
            get { return this.range1DViewModel_; }
            set
            {
                if (this.range1DViewModel_ != value)
                {
                    this.range1DViewModel_ = value;
                    this.NotifyPropertyChanged("Range1DViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_underlyingCalcIDViewModel_
        private ObservableCollection<Excel_underlyingCalcIDViewModel> excel_underlyingCalcIDViewModel_;
        public ObservableCollection<Excel_underlyingCalcIDViewModel> Excel_underlyingCalcIDViewModel_
        {
            get { return this.excel_underlyingCalcIDViewModel_; }
            set
            {
                if (this.excel_underlyingCalcIDViewModel_ != value)
                {
                    this.excel_underlyingCalcIDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_underlyingCalcIDViewModel_");
                }
            }
        }
        #endregion
        
        #region Excel_returnCalcInfoViewModel_
        private ObservableCollection<Excel_returnCalcInfoViewModel> excel_returnCalcInfoViewModel_;
        public ObservableCollection<Excel_returnCalcInfoViewModel> Excel_returnCalcInfoViewModel_
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
        
        #region DayCounter_
        private string dayCounter_;
        public string DayCounter_
        {
            get { return this.dayCounter_; }
            set
            {
                if (this.dayCounter_ != value)
                {
                    this.dayCounter_ = value;
                    this.NotifyPropertyChanged("DayCounter_");
                }
            }
        }
        #endregion
        
        #region DetailScheduleType_
        private string detailScheduleType_;
        public string DetailScheduleType_
        {
            get { return this.detailScheduleType_; }
            set
            {
                if (this.detailScheduleType_ != value)
                {
                    this.detailScheduleType_ = value;
                    this.NotifyPropertyChanged("DetailScheduleType_");
                }
            }
        }
        #endregion
        
        
    
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_couponSchedule");
                xmlWriter.WriteElementString("excel_type" , "excel_multiCondi_structuredAccrualCouponSchedule");
                xmlWriter.WriteStartElement("excel_multiCondi_structuredAccrualCouponSchedule");
                    xmlWriter.WriteElementString("eventDate" , StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    
                    xmlWriter.WriteElementString("payoffDate" , StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    
                    xmlWriter.WriteElementString("calculationStartDate" , StringConverter.xmlDateTimeToDateString(this.calculationStartDate_));
                    
                    xmlWriter.WriteElementString("calculationEndDate" , StringConverter.xmlDateTimeToDateString(this.calculationEndDate_));
                    
                    xmlWriter.WriteElementString("description" , this.description_);
                    
                    xmlWriter.WriteElementString("vba_description" , this.vba_description_);
                    
                    foreach (var item in range1DViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    foreach (var item in excel_underlyingCalcIDViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    foreach (var item in excel_returnCalcInfoViewModel_)
                    {
                        item.buildXml(xmlWriter);
                    }
                    
                    xmlWriter.WriteElementString("dayCounter" , this.dayCounter_);
                    
                    xmlWriter.WriteElementString("detailScheduleType" , this.detailScheduleType_);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }
        
        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override Control view()
        {
            Control v = new Excel_multiCondi_structuredAccrualCouponScheduleView();
            v.DataContext = this;
            return v;
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_couponSchedule serial_Excel_couponSchedule = serial_Class as FpmlSerializedCSharp.Excel_couponSchedule;
            FpmlSerializedCSharp.Excel_multiCondi_structuredAccrualCouponSchedule serial_Excel_multiCondi_structuredAccrualCouponSchedule = serial_Excel_couponSchedule.Excel_multiCondi_structuredAccrualCouponSchedule_;
        
            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_structuredAccrualCouponSchedule.EventDate_.ValueStr);
            
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_structuredAccrualCouponSchedule.PayoffDate_.ValueStr);
            
            this.calculationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_structuredAccrualCouponSchedule.CalculationStartDate_.ValueStr);
            
            this.calculationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_structuredAccrualCouponSchedule.CalculationEndDate_.ValueStr);
            
            this.description_ = serial_Excel_multiCondi_structuredAccrualCouponSchedule.Description_.ValueStr;
            
            this.vba_description_ = serial_Excel_multiCondi_structuredAccrualCouponSchedule.Vba_description_.ValueStr;
            
            List<FpmlSerializedCSharp.Range1D> serial_range1D = serial_Excel_multiCondi_structuredAccrualCouponSchedule.Range1D_;
            this.range1DViewModel_ = new ObservableCollection<Range1DViewModel>();
            foreach (var item in serial_range1D)
            {
                string type = item.Excel_type_.ValueStr;
                Range1DViewModel viewModel = Range1DViewModel.CreateRange1D(type);
                viewModel.setFromSerial(item);
                this.range1DViewModel_.Add(viewModel);
            }
            
            List<FpmlSerializedCSharp.Excel_underlyingCalcID> serial_excel_underlyingCalcID = serial_Excel_multiCondi_structuredAccrualCouponSchedule.Excel_underlyingCalcID_;
            this.excel_underlyingCalcIDViewModel_ = new ObservableCollection<Excel_underlyingCalcIDViewModel>();
            foreach (var item in serial_excel_underlyingCalcID)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_underlyingCalcIDViewModel viewModel = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(type);
                viewModel.setFromSerial(item);
                this.excel_underlyingCalcIDViewModel_.Add(viewModel);
            }
            
            List<FpmlSerializedCSharp.Excel_returnCalcInfo> serial_excel_returnCalcInfo = serial_Excel_multiCondi_structuredAccrualCouponSchedule.Excel_returnCalcInfo_;
            this.excel_returnCalcInfoViewModel_ = new ObservableCollection<Excel_returnCalcInfoViewModel>();
            foreach (var item in serial_excel_returnCalcInfo)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_returnCalcInfoViewModel viewModel = Excel_returnCalcInfoViewModel.CreateExcel_returnCalcInfo(type);
                viewModel.setFromSerial(item);
                this.excel_returnCalcInfoViewModel_.Add(viewModel);
            }
            
            this.dayCounter_ = serial_Excel_multiCondi_structuredAccrualCouponSchedule.DayCounter_.ValueStr;
            
            this.detailScheduleType_ = serial_Excel_multiCondi_structuredAccrualCouponSchedule.DetailScheduleType_.ValueStr;
            
        }
        
        
    
            
            
            
            
            
            
        
    
        
    
    }
    
}

