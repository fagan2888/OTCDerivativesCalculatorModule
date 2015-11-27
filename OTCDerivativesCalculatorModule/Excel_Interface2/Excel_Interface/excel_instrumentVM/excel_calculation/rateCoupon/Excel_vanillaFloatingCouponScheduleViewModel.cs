using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace Excel_Interface
{
    public class Excel_vanillaFloatingCouponScheduleViewModel : Excel_couponScheduleViewModel
    {
        public Excel_vanillaFloatingCouponScheduleViewModel() { }
    
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

        #region OutGearing_
        private string outGearing_;
        public string OutGearing_
        {
            get { return this.outGearing_; }
            set
            {
                if (this.outGearing_ != value)
                {
                    this.outGearing_ = value;
                    this.NotifyPropertyChanged("OutGearing_");
                }
            }
        }
        #endregion

        #region OutSpread_
        private string outSpread_;
        public string OutSpread_
        {
            get { return this.outSpread_; }
            set
            {
                if (this.outSpread_ != value)
                {
                    this.outSpread_ = value;
                    this.NotifyPropertyChanged("OutSpread_");
                }
            }
        }
        #endregion

        #region Cap_
        private string cap_;
        public string Cap_
        {
            get { return this.cap_; }
            set
            {
                if (this.cap_ != value)
                {
                    this.cap_ = value;
                    this.NotifyPropertyChanged("Cap_");
                }
            }
        }
        #endregion

        #region Floor_
        private string floor_;
        public string Floor_
        {
            get { return this.floor_; }
            set
            {
                if (this.floor_ != value)
                {
                    this.floor_ = value;
                    this.NotifyPropertyChanged("Floor_");
                }
            }
        }
        #endregion

        #region Excel_underlyingCalcIDViewModel_
        private Excel_underlyingCalcIDViewModel excel_underlyingCalcIDViewModel_;
        public Excel_underlyingCalcIDViewModel Excel_underlyingCalcIDViewModel_
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
        
        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_couponSchedule");
                xmlWriter.WriteElementString("excel_type" , "excel_vanillaFloatingCouponSchedule");
            
                base.buildXml(xmlWriter);

                xmlWriter.WriteStartElement("excel_vanillaFloatingCouponSchedule");

                    xmlWriter.WriteElementString("eventDate", StringConverter.xmlDateTimeToDateString(this.eventDate_));
                    xmlWriter.WriteElementString("calculationStartDate", StringConverter.xmlDateTimeToDateString(this.calculationStartDate_));
                    xmlWriter.WriteElementString("calculationEndDate", StringConverter.xmlDateTimeToDateString(this.calculationEndDate_));
                    xmlWriter.WriteElementString("payoffDate", StringConverter.xmlDateTimeToDateString(this.payoffDate_));
                    xmlWriter.WriteElementString("description", this.description_);
                    xmlWriter.WriteElementString("vba_description", this.vba_description_);

                    xmlWriter.WriteElementString("gearing" , this.gearing_);
                    xmlWriter.WriteElementString("spread" , this.spread_);
                    xmlWriter.WriteElementString("outGearing", this.outGearing_);
                    xmlWriter.WriteElementString("outSpread", this.outSpread_);
                    xmlWriter.WriteElementString("cap", this.cap_);
                    xmlWriter.WriteElementString("floor", this.floor_);
                    
                    excel_underlyingCalcIDViewModel_.buildXml(xmlWriter);
                    
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
            FpmlSerializedCSharp.Excel_vanillaFloatingCouponSchedule serial_Excel_vanillaFloatingCouponSchedule = serial_Excel_couponSchedule.Excel_vanillaFloatingCouponSchedule_;
            
            base.setFromSerial(serial_Excel_couponSchedule.Excel_additionalOption_);

            this.eventDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaFloatingCouponSchedule.EventDate_.ValueStr);
            this.payoffDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaFloatingCouponSchedule.PayoffDate_.ValueStr);
            this.calculationStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaFloatingCouponSchedule.CalculationStartDate_.ValueStr);
            this.calculationEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_vanillaFloatingCouponSchedule.CalculationEndDate_.ValueStr);
            this.description_ = serial_Excel_vanillaFloatingCouponSchedule.Description_.ValueStr;
            this.vba_description_ = serial_Excel_vanillaFloatingCouponSchedule.Vba_description_.ValueStr;

            this.gearing_ = serial_Excel_vanillaFloatingCouponSchedule.Gearing_.ValueStr;
            this.spread_ = serial_Excel_vanillaFloatingCouponSchedule.Spread_.ValueStr;
            this.outGearing_ = serial_Excel_vanillaFloatingCouponSchedule.OutGearing_.ValueStr;
            this.outSpread_ = serial_Excel_vanillaFloatingCouponSchedule.OutSpread_.ValueStr;
            this.cap_ = serial_Excel_vanillaFloatingCouponSchedule.Cap_.ValueStr;
            this.floor_ = serial_Excel_vanillaFloatingCouponSchedule.Floor_.ValueStr;

            FpmlSerializedCSharp.Excel_underlyingCalcID serial_excel_underlyingCalcID = serial_Excel_vanillaFloatingCouponSchedule.Excel_underlyingCalcID_;
            string excel_underlyingCalcIDtype = serial_excel_underlyingCalcID.Excel_type_.ValueStr;
            this.excel_underlyingCalcIDViewModel_ = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(excel_underlyingCalcIDtype);
            this.excel_underlyingCalcIDViewModel_.setFromSerial(serial_excel_underlyingCalcID);
            
        }

        public override Control view()
        {
            Control v = new Excel_vanillaFloatingCouponScheduleView();

            v.DataContext = this;

            return v;
        }

        public override void descriptionUpdate()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("test vanillaFloatingCoupon");
            //sb.Append(this.excel_returnCalcInfo_CallViewModel_.Description_);

            this.Description_ = sb.ToString();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel, EVENT_INFO_Table_DAO dao)
        {
            dao.CALCULATION_TYPE_ = "vanilla floating Coupon";
            dao.EVENT_AMOUNT_ = "unCalculated";
            dao.EVENT_DATE_ = this.eventDate_.ToString(StringFormat.DbDateFormat_);
            dao.EVENT_DESCRIPTION_ = "floating coupon description";
            dao.EVENT_NAME_ = "floating coupon name";
            dao.EVENT_TYPE_ = "payment";
            dao.EVENT_SUBTYPE_ = "floating_interest";
            //dao.EXPIRED_FLAG_ = "false";
            dao.FIXING_FLAG_ = "need calculation"; 
            dao.FIXING_OBSERVATION_ = "undefined";

            foreach (var item in excel_underlyingCalcIDViewModel_.Excel_selectedUnderlyingViewModel_)
	        {
                if (item.Checked_)
                {
                    dao.FIXING_UNDERLYINGS_ = item.NameTrans_.Value_ + ";";
                }
	        }

            dao.FLOATING_FLAG_ = "true";
            //dao.NOTIONAL_ = this.excel_issueInfoViewModel_.Notional_;
            //dao.REMAIN_NOTIONAL_ = "undefined";
        }


    }
    
}

