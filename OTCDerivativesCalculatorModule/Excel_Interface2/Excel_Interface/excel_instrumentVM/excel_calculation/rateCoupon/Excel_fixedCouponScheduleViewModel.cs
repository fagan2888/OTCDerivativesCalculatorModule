using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_fixedCouponScheduleViewModel : Excel_couponScheduleViewModel
    {
        public Excel_fixedCouponScheduleViewModel() 
        {
            this.Excel_type_ = "excel_fixedCouponSchedule";
        }

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
        
        #region FixedRate_
        private string fixedRate_;
        public string FixedRate_
        {
            get { return this.fixedRate_; }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                    this.NotifyPropertyChanged("FixedRate_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_couponSchedule");
                xmlWriter.WriteElementString("excel_type" , "excel_fixedCouponSchedule");

                base.buildXml(xmlWriter);

                xmlWriter.WriteStartElement("excel_fixedCouponSchedule");

                    xmlWriter.WriteElementString("eventDate", StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    xmlWriter.WriteElementString("calculationStartDate", StringConverter.xmlDateTimeToDateString(this.calculationStartDate_));
                    xmlWriter.WriteElementString("calculationEndDate", StringConverter.xmlDateTimeToDateString(this.calculationEndDate_));
                    xmlWriter.WriteElementString("payoffDate", StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    xmlWriter.WriteElementString("description", this.description_);
                    xmlWriter.WriteElementString("vba_description", this.vba_description_);

                    //xmlWriter.WriteElementString("maturityDate" , StringConverter.xmlDateTimeToDateString(this.maturityDate_));
                    xmlWriter.WriteElementString("fixedRate", this.fixedRate_);

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
            FpmlSerializedCSharp.Excel_fixedCouponSchedule serial_Excel_fixedCouponSchedule = serial_Excel_couponSchedule.Excel_fixedCouponSchedule_;

            base.setFromSerial(serial_Excel_couponSchedule.Excel_additionalOption_);

            //this.scheduleInitialDate_ = serial_Excel_fixedCouponSchedule.ScheduleInitialDate_.ValueStr;
            //this.maturityDate_ = serial_Excel_fixedCouponSchedule.MaturityDate_.ValueStr;

            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_fixedCouponSchedule.EventDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_fixedCouponSchedule.PayoffDate_.ValueStr);
            this.calculationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_fixedCouponSchedule.CalculationStartDate_.ValueStr);
            this.calculationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_fixedCouponSchedule.CalculationEndDate_.ValueStr);
            this.description_ = serial_Excel_fixedCouponSchedule.Description_.ValueStr;
            this.vba_description_ = serial_Excel_fixedCouponSchedule.Vba_description_.ValueStr;

            this.fixedRate_ = serial_Excel_fixedCouponSchedule.FixedRate_.ValueStr;
            this.detailScheduleType_ = serial_Excel_fixedCouponSchedule.DetailScheduleType_.ValueStr;
            
            
        }

        public override Control view()
        {
            Control v = new Excel_fixedCouponScheduleView();

            v.DataContext = this;

            return v;
        }

        public override void descriptionUpdate()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("test fixedCoupon");
            //sb.Append(this.excel_returnCalcInfo_CallViewModel_.Description_);

            this.Description_ = sb.ToString();
        }
        
        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel, EVENT_INFO_Table_DAO dao)
        {
            dao.CALCULATION_TYPE_ = "fixedCoupon";
            dao.EVENT_AMOUNT_ = "unCalculated";
            dao.EVENT_DATE_ = this.eventDate_.ToString(StringFormat.DbDateFormat_);
            dao.EVENT_DESCRIPTION_ = "fixed coupon description";
            dao.EVENT_NAME_ = "fixed coupon name";
            dao.EVENT_TYPE_ = "payment";
            dao.EVENT_SUBTYPE_= "fixed_interest";
            //dao.EXPIRED_FLAG_ = "false";
            dao.FIXING_FLAG_ = "true";
            dao.FIXING_OBSERVATION_ = "undefined";
            dao.FIXING_UNDERLYINGS_ = "";
            dao.FLOATING_FLAG_ = "false";
            //dao.NOTIONAL_ = this.excel_issueInfoViewModel_.Notional_;
            //dao.REMAIN_NOTIONAL_ = "undefined";
            
        }

    }
    
}

