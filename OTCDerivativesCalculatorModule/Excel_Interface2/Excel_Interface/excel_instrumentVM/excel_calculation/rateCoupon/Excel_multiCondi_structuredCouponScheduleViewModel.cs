using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class Excel_multiCondi_structuredCouponScheduleViewModel : Excel_couponScheduleViewModel
    {
        public Excel_multiCondi_structuredCouponScheduleViewModel() 
        {
            this.excel_eventCalcInfoViewModel_ = new ObservableCollection<Excel_eventCalcInfoViewModel>();
            this.excel_returnCalcInfoViewModel_ = new ObservableCollection<Excel_returnCalcInfoViewModel>();

        }
        
        #region Excel_eventCalcInfoViewModel_
        private ObservableCollection<Excel_eventCalcInfoViewModel> excel_eventCalcInfoViewModel_;
        public ObservableCollection<Excel_eventCalcInfoViewModel> Excel_eventCalcInfoViewModel_
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
        
        #region PaymentDate_
        private DateTime paymentDate_;
        public DateTime PaymentDate_
        {
            get { return this.paymentDate_; }
            set
            {
                if (this.paymentDate_ != value)
                {
                    this.paymentDate_ = value;
                    this.NotifyPropertyChanged("PaymentDate_");
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
                xmlWriter.WriteElementString("excel_type", "excel_multiCondi_structuredCouponSchedule");

                base.buildXml(xmlWriter);

                xmlWriter.WriteStartElement("excel_multiCondi_structuredCouponSchedule");

                    xmlWriter.WriteElementString("eventDate", StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    xmlWriter.WriteElementString("calculationStartDate", StringConverter.xmlDateTimeToDateString(this.calculationStartDate_));
                    xmlWriter.WriteElementString("calculationEndDate", StringConverter.xmlDateTimeToDateString(this.calculationEndDate_));
                    xmlWriter.WriteElementString("payoffDate", StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    xmlWriter.WriteElementString("description", this.description_);
                    xmlWriter.WriteElementString("vba_description", this.vba_description_);

                    foreach (var item in excel_eventCalcInfoViewModel_)
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
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {

            FpmlSerializedCSharp.Excel_couponSchedule serial_Excel_couponSchedule = serial_Class as FpmlSerializedCSharp.Excel_couponSchedule;
            FpmlSerializedCSharp.Excel_multiCondi_structuredCouponSchedule serial_Excel_multiCondi_structuredCouponSchedule = serial_Excel_couponSchedule.Excel_multiCondi_structuredCouponSchedule_;
            
            base.setFromSerial(serial_Excel_couponSchedule.Excel_additionalOption_);

            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_structuredCouponSchedule.EventDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_structuredCouponSchedule.PayoffDate_.ValueStr);
            this.calculationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_structuredCouponSchedule.CalculationStartDate_.ValueStr);
            this.calculationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_multiCondi_structuredCouponSchedule.CalculationEndDate_.ValueStr);
            this.description_ = serial_Excel_multiCondi_structuredCouponSchedule.Description_.ValueStr;
            this.vba_description_ = serial_Excel_multiCondi_structuredCouponSchedule.Vba_description_.ValueStr;

            List<FpmlSerializedCSharp.Excel_eventCalcInfo> serial_excel_eventCalcInfo = serial_Excel_multiCondi_structuredCouponSchedule.Excel_eventCalcInfo_;
            this.excel_eventCalcInfoViewModel_ = new ObservableCollection<Excel_eventCalcInfoViewModel>();
            foreach (var item in serial_excel_eventCalcInfo)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_eventCalcInfoViewModel viewModel = Excel_eventCalcInfoViewModel.CreateExcel_eventCalcInfo(type);
                viewModel.setFromSerial(item);
                this.excel_eventCalcInfoViewModel_.Add(viewModel);
            }
            
            List<FpmlSerializedCSharp.Excel_returnCalcInfo> serial_excel_returnCalcInfo = serial_Excel_multiCondi_structuredCouponSchedule.Excel_returnCalcInfo_;
            this.excel_returnCalcInfoViewModel_ = new ObservableCollection<Excel_returnCalcInfoViewModel>();
            foreach (var item in serial_excel_returnCalcInfo)
            {
                string type = item.Excel_type_.ValueStr;
                Excel_returnCalcInfoViewModel viewModel = Excel_returnCalcInfoViewModel.CreateExcel_returnCalcInfo(type);
                viewModel.setFromSerial(item);
                this.excel_returnCalcInfoViewModel_.Add(viewModel);
            }
            
            this.dayCounter_ = serial_Excel_multiCondi_structuredCouponSchedule.DayCounter_.ValueStr;
            this.detailScheduleType_ = serial_Excel_multiCondi_structuredCouponSchedule.DetailScheduleType_.ValueStr;
            
        }

        public override Control view()
        {
            throw new NotImplementedException();
        }

        public override void descriptionUpdate()
        {
            throw new NotImplementedException();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel, EVENT_INFO_Table_DAO dao)
        {
            
        }


    }
    
}

