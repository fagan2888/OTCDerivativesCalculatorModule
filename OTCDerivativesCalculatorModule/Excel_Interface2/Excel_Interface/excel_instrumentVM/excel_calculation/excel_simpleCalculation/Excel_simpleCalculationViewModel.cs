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
        //public Excel_simpleCalculationViewModel(DateTime eventDate) 
        //: base(eventDate)
        //{
        //    //this.description_ = "testDescription";
        //}

        public Excel_simpleCalculationViewModel()
        {
            this.excel_type_ = "excel_simpleCalculation";
        }
    
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

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_schedule");

                xmlWriter.WriteElementString("excel_type" , "excel_simpleCalculation");
                
                base.buildXml(xmlWriter);

                xmlWriter.WriteStartElement("excel_simpleCalculation");

                    xmlWriter.WriteElementString("eventDate", this.eventDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("payoffDate", this.payoffDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("description", this.description_);
                    xmlWriter.WriteElementString("vba_description", this.vba_description_);
            
                    excel_eventCalcInfoViewModel_.buildXml(xmlWriter);
                    excel_returnCalcInfoViewModel_.buildXml(xmlWriter);

                    //if (this.excel_complementReturnCalcViewModel_ != null)
                    //{
                    excel_complementReturnCalcViewModel_.buildXml(xmlWriter);
                    //}
                    
                    excel_eventCalcInfo_CallViewModel_.buildXml(xmlWriter);
                    excel_returnCalcInfo_CallViewModel_.buildXml(xmlWriter);
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            // 원래 꺼 만드는 코드 부분
        }

        //public override void buildPricingXml(XmlWriter xmlWriter)
        //{
        //    this.vmBuildFromExcel_interface();

        //    this.eventTriggerViewModel_.buildXml(xmlWriter);
        //}

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_schedule serial_Excel_schedule = serial_Class as FpmlSerializedCSharp.Excel_schedule;
            FpmlSerializedCSharp.Excel_simpleCalculation serial_Excel_simpleCalculation = serial_Excel_schedule.Excel_simpleCalculation_;

            base.setFromSerial(serial_Excel_schedule.Excel_additionalOption_);

            // base 로 올림
            this.eventDate_ = serial_Excel_simpleCalculation.EventDate_.DateTimeValue();
            this.payoffDate_ = serial_Excel_simpleCalculation.PayoffDate_.DateTimeValue();
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
            this.excel_complementReturnCalcViewModel_ = new Excel_complementReturnCalcViewModel();
            this.excel_complementReturnCalcViewModel_.setFromSerial(serial_excel_complementReturnCalc);

            FpmlSerializedCSharp.Excel_eventCalcInfo_Call serial_excel_eventCalcInfo_Call = serial_Excel_simpleCalculation.Excel_eventCalcInfo_Call_;
            this.excel_eventCalcInfo_CallViewModel_ = new Excel_eventCalcInfo_CallViewModel();
            this.excel_eventCalcInfo_CallViewModel_.setFromSerial(serial_excel_eventCalcInfo_Call);

            FpmlSerializedCSharp.Excel_returnCalcInfo_Call serial_excel_returnCalcInfo_Call = serial_Excel_simpleCalculation.Excel_returnCalcInfo_Call_;
            string excel_returnCalcInfo_Calltype = serial_excel_returnCalcInfo_Call.Excel_returnCalcInfo_.Excel_type_.ValueStr;
            this.excel_returnCalcInfo_CallViewModel_ = new Excel_returnCalcInfo_CallViewModel();
            this.excel_returnCalcInfo_CallViewModel_.setFromSerial(serial_excel_returnCalcInfo_Call);

            //this.view_ = new Excel_simpleCalculationView();
            //this.view_.DataContext = this;
        }

        //public override void vmBuildFromExcel_interface()
        //{
        //    SimpleEventCouponTriggerViewModel sectvm = new SimpleEventCouponTriggerViewModel();

        //    sectvm.EventDate_ = this.EventDate_.ToString("yyyy-MM-dd");

        //    this.excel_eventCalcInfoViewModel_.ReferenceFixingDate_ = this.EventDate_;
        //    this.excel_returnCalcInfoViewModel_.ReferenceFixingDate_ = this.EventDate_;
            
        //    //if (this.excel_complementReturnCalcViewModel_ != null)
        //    //{
        //        this.excel_complementReturnCalcViewModel_.Excel_returnCalcInfoViewModel_.ReferenceFixingDate_ = this.EventDate_;
        //    //}

        //    this.excel_eventCalcInfo_CallViewModel_.Excel_eventCalcInfoViewModel_.ReferenceFixingDate_ = this.EventDate_;
        //    this.excel_returnCalcInfo_CallViewModel_.Excel_returnCalcInfoViewModel_.ReferenceFixingDate_ = this.EventDate_;

        //    sectvm.EventCalculationInfoViewModel_ = this.excel_eventCalcInfoViewModel_.eventCalcInfoVM();

        //    sectvm.ReturnCalculationInfoViewModel_ = this.excel_returnCalcInfoViewModel_.returnCalcInfoVM();

        //    sectvm.ComplementReturnCalculationViewModel_ = new ComplementReturnCalculationViewModel();

        //    sectvm.ComplementReturnCalculationViewModel_.ReturnCalculationInfoViewModel_ 
        //        = this.excel_complementReturnCalcViewModel_.returnCalcInfoVM();

        //    // payoffDateInfo
        //    {
        //        PayoffDateInfoViewModel pdvm = new PayoffDateInfoViewModel();

        //        FixedFixingDateInfoViewModel ffdvm = new FixedFixingDateInfoViewModel();

        //        ffdvm.Date_ = this.EventDate_.ToString("yyyy-MM-dd");
        //        pdvm.FixingDateInfoViewModel_ = ffdvm;

        //        sectvm.PayoffDateInfoViewModel_ = pdvm;
        //    }

        //    // --------------- autoCallTrigger
        //    {
        //        AutoTerminationTriggerViewModel attvm = new AutoTerminationTriggerViewModel();

        //        attvm.EventCalculationInfoViewModel_
        //            = this.excel_eventCalcInfo_CallViewModel_.eventCalcInfoVM();

        //        attvm.ReturnCalculationInfoViewModel_
        //            = this.excel_returnCalcInfo_CallViewModel_.returnCalcInfoVM();

        //        sectvm.AutoTerminationTriggerViewModel_ = attvm;
        //    }
        //    {
        //        PayoffDateInfoViewModel pdvm = new PayoffDateInfoViewModel();

        //        FixedFixingDateInfoViewModel ffdvm_call = new FixedFixingDateInfoViewModel();

        //        pdvm.FixingDateInfoViewModel_ = ffdvm_call;

        //        ffdvm_call.Date_ = this.EventDate_.ToString("yyyy-MM-dd");

        //        sectvm.AutoTerminationTriggerViewModel_.PayoffDateInfoViewModel_ = pdvm;
        //    }

        //    this.eventTriggerViewModel_ = sectvm;

        //}

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;

            this.excel_eventCalcInfoViewModel_.setUnderlying(excel_under);
            this.excel_returnCalcInfoViewModel_.setUnderlying(excel_under);
            this.excel_complementReturnCalcViewModel_.setUnderlying(excel_under);
            this.excel_eventCalcInfo_CallViewModel_.setUnderlying(excel_under);
            this.excel_returnCalcInfo_CallViewModel_.setUnderlying(excel_under);

        }

        public override Control view()
        {
            Control v = new Excel_simpleCalculationView();

            v.DataContext = this;

            return v;
        }

        public override void descriptionUpdate()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.excel_eventCalcInfoViewModel_.Description_);
            sb.Append(" ");
            sb.Append(this.excel_returnCalcInfoViewModel_.Description_);
            sb.Append(" ");
            sb.Append(this.excel_complementReturnCalcViewModel_.Description_);
            sb.Append(" ");
            sb.Append(this.excel_eventCalcInfo_CallViewModel_.Description_);
            sb.Append(" ");
            sb.Append(this.excel_returnCalcInfo_CallViewModel_.Description_);

            this.Description_ = sb.ToString();
        }

        public override void bookingEvent(MasterInformationViewModel masterInformationViewModel, EVENT_INFO_Table_DAO dao)
        {
            if (this.eventDAO_ == null)
            {
                //dao.EVENT_CODE_ = "testCode";
                dao.EVENT_DATE_ = this.eventDate_.ToString(StringFormat.DbDateFormat_);
                dao.EVENT_TYPE_ = "payment";
                dao.EVENT_SUBTYPE_ = "coupon";
                dao.EVENT_NAME_ = "simple coupon";
                dao.EVENT_DESCRIPTION_ = "simpleCalculation default";
                //dao.CURRENCY_ = item[6].ToString();
                //dao.NOTIONAL_ = item[7].ToString();
                //dao.REMAIN_NOTIONAL_ = item[8].ToString();
                dao.EVENT_AMOUNT_ = "";
                //dao.COUNTERPARTY_ = item[10].ToString();
                dao.FLOATING_FLAG_ = "true";
                dao.CALCULATION_TYPE_ = "simpleCalculation";

                foreach (var item in this.excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
                {
                    dao.FIXING_UNDERLYINGS_ += item.NameTrans_.Value_ + " ; ";
                }

                dao.FIXING_OBSERVATION_ = "empty";

                dao.FIXING_FLAG_ = "false";
                dao.EXPIRED_FLAG_ = "false";
                //dao.ITEM_CODE_ = item[17].ToString();
                //dao.ITEM_TYPE_ = item[18].ToString();
                //dao.ITEM_NAME_ = item[19].ToString();

            }


        }
    }
    
}

