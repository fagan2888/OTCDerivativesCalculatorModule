using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_floatingCouponScheduleViewModel : Excel_couponScheduleViewModel
    {
        #region View_
        protected Control view_;
        public Control View_
        {
            get { return this.view_; }
            set
            {
                if (this.view_ != value)
                {
                    this.view_ = value;
                    this.NotifyPropertyChanged("View_");
                }
            }
        }
        #endregion
    
        
        public Excel_floatingCouponScheduleViewModel() { }
    
        #region Gearing_
        private string gearing_;
        public string Gearing_
        {
            get { return this.gearing_; }
            set
            {
                if (this.gearing_ != value)
                {
                    this.gearing_ = value;
                    this.NotifyPropertyChanged("Gearing_");
                }
            }
        }
        #endregion
        
        #region Spread_
        private string spread_;
        public string Spread_
        {
            get { return this.spread_; }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                    this.NotifyPropertyChanged("Spread_");
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
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_couponSchedule");
                xmlWriter.WriteElementString("excel_type" , "excel_floatingCouponSchedule");

                base.buildXml(xmlWriter);

                xmlWriter.WriteStartElement("excel_floatingCouponSchedule");
            
                    xmlWriter.WriteElementString("eventDate", StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    xmlWriter.WriteElementString("calculationStartDate", StringConverter.xmlDateTimeToDateString(this.calculationStartDate_));
                    xmlWriter.WriteElementString("calculationEndDate", StringConverter.xmlDateTimeToDateString(this.calculationEndDate_));
                    xmlWriter.WriteElementString("payoffDate", StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    xmlWriter.WriteElementString("description", this.description_);
                    xmlWriter.WriteElementString("vba_description", this.vba_description_);

                    xmlWriter.WriteElementString("gearing" , this.gearing_);
                    
                    xmlWriter.WriteElementString("spread" , this.spread_);
                    
                    excel_returnCalcInfoViewModel_.buildXml(xmlWriter);
                    
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
            FpmlSerializedCSharp.Excel_floatingCouponSchedule serial_Excel_floatingCouponSchedule = serial_Excel_couponSchedule.Excel_floatingCouponSchedule_;

            base.setFromSerial(serial_Excel_couponSchedule.Excel_additionalOption_);

            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_floatingCouponSchedule.EventDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_floatingCouponSchedule.PayoffDate_.ValueStr);
            this.calculationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_floatingCouponSchedule.CalculationStartDate_.ValueStr);
            this.calculationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_floatingCouponSchedule.CalculationEndDate_.ValueStr);
            this.description_ = serial_Excel_floatingCouponSchedule.Description_.ValueStr;
            this.vba_description_ = serial_Excel_floatingCouponSchedule.Vba_description_.ValueStr;
            
            this.gearing_ = serial_Excel_floatingCouponSchedule.Gearing_.ValueStr;
            
            this.spread_ = serial_Excel_floatingCouponSchedule.Spread_.ValueStr;
            
            FpmlSerializedCSharp.Excel_returnCalcInfo serial_excel_returnCalcInfo = serial_Excel_floatingCouponSchedule.Excel_returnCalcInfo_;
            string excel_returnCalcInfotype = serial_excel_returnCalcInfo.Excel_type_.ValueStr;
            this.excel_returnCalcInfoViewModel_ = Excel_returnCalcInfoViewModel.CreateExcel_returnCalcInfo(excel_returnCalcInfotype);
            this.excel_returnCalcInfoViewModel_.setFromSerial(serial_excel_returnCalcInfo);
   
        }

        public override Control view()
        {
            Control v = new Excel_floatingCouponScheduleView();

            v.DataContext = this;

            return v;
        }

        public override void descriptionUpdate()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("test floatingCoupon");
            //sb.Append(this.excel_returnCalcInfo_CallViewModel_.Description_);

            this.Description_ = sb.ToString();
        }


        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel, EVENT_INFO_Table_DAO dao)
        {
            throw new NotImplementedException();
        }


    }
    
}

