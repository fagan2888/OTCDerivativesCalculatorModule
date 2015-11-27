using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel : Excel_couponScheduleViewModel
    {
        public Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel() 
        {
            this.excel_multi_rangeNDViewModel_ = new ObservableCollection<Excel_multi_rangeNDViewModel>();
            this.excel_returnCalcInfoViewModel_ = new ObservableCollection<Excel_returnCalcInfoViewModel>();
        }
        
        #region Excel_multi_rangeNDViewModel_
        private ObservableCollection<Excel_multi_rangeNDViewModel> excel_multi_rangeNDViewModel_;
        public ObservableCollection<Excel_multi_rangeNDViewModel> Excel_multi_rangeNDViewModel_
        {
            get { return this.excel_multi_rangeNDViewModel_; }
            set
            {
                if (this.excel_multi_rangeNDViewModel_ != value)
                {
                    this.excel_multi_rangeNDViewModel_ = value;
                    this.NotifyPropertyChanged("Excel_multi_rangeNDViewModel_");
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
                xmlWriter.WriteElementString("excel_type" , "excel_multiCondi_multiRng_structuredAccrualCouponSchedule");
            
                base.buildXml(xmlWriter);

                xmlWriter.WriteStartElement("excel_multiCondi_multiRng_structuredAccrualCouponSchedule");

                    xmlWriter.WriteElementString("eventDate", StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    xmlWriter.WriteElementString("calculationStartDate", StringConverter.xmlDateTimeToDateString(this.calculationStartDate_));
                    xmlWriter.WriteElementString("calculationEndDate", StringConverter.xmlDateTimeToDateString(this.calculationEndDate_));
                    xmlWriter.WriteElementString("payoffDate", StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    xmlWriter.WriteElementString("description", this.description_);
                    xmlWriter.WriteElementString("vba_description", this.vba_description_);
                    
                    foreach (var item in excel_multi_rangeNDViewModel_)
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
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_couponSchedule serial_Excel_couponSchedule = serial_Class as FpmlSerializedCSharp.Excel_couponSchedule;
            FpmlSerializedCSharp.Excel_multiCondi_multiRng_structuredAccrualCouponSchedule serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule = serial_Excel_couponSchedule.Excel_multiCondi_multiRng_structuredAccrualCouponSchedule_;

            base.setFromSerial(serial_Excel_couponSchedule.Excel_additionalOption_);

            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.EventDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.PayoffDate_.ValueStr);
            this.calculationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.CalculationStartDate_.ValueStr);
            this.calculationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.CalculationEndDate_.ValueStr);
            this.description_ = serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.Description_.ValueStr;
            this.vba_description_ = serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.Vba_description_.ValueStr;

            List<FpmlSerializedCSharp.Excel_multi_rangeND> serial_excel_multi_rangeND = serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.Excel_multi_rangeND_;
            this.excel_multi_rangeNDViewModel_ = new ObservableCollection<Excel_multi_rangeNDViewModel>();
            foreach (var item in serial_excel_multi_rangeND)
            {
                Excel_multi_rangeNDViewModel viewModel = new Excel_multi_rangeNDViewModel();
                viewModel.setFromSerial(item);
                this.excel_multi_rangeNDViewModel_.Add(viewModel);
            }
            
            List<FpmlSerializedCSharp.Excel_returnCalcInfo> serial_excel_returnCalcInfo = serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.Excel_returnCalcInfo_;
            this.excel_returnCalcInfoViewModel_ = new ObservableCollection<Excel_returnCalcInfoViewModel>();
            foreach (var item in serial_excel_returnCalcInfo)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_returnCalcInfoViewModel viewModel = Excel_returnCalcInfoViewModel.CreateExcel_returnCalcInfo(type);
                viewModel.setFromSerial(item);
                this.excel_returnCalcInfoViewModel_.Add(viewModel);
            }
            
            this.dayCounter_ = serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.DayCounter_.ValueStr;
            this.detailScheduleType_ = serial_Excel_multiCondi_multiRng_structuredAccrualCouponSchedule.DetailScheduleType_.ValueStr;
            
        }

        public override void descriptionUpdate()
        {
            throw new NotImplementedException();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel, EVENT_INFO_Table_DAO dao)
        {
            throw new NotImplementedException();
        }
    }
    
}

