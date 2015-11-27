using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using QLNet;

namespace Excel_Interface
{
    public class Excel_hifive_stepDown_kiViewModel : Excel_hifive_subtypeViewModel
    {
        public Excel_hifive_stepDown_kiViewModel(bool btnVisible = true) 
        {
            this.Excel_Type_ = "excel_hifive_stepDown_ki";

            this.subScheduleDataList_ = new ObservableCollection<Excel_stepDownKI_subScheduleViewModel>();
            //this.excel_underlyingCalcIDVMList_ = new ObservableCollection<Excel_underlyingCalcIDViewModel>();

            //this.view_ = new Excel_hifive_StepDownKI_View();
            //this.view_.DataContext = this;

            this.excel_calendarViewModel = new Excel_calendarViewModel("KOR");

            if (btnVisible)
            {
                this.makeBtnVisibility_ = Visibility.Visible;
            }
            else
            {
                this.makeBtnVisibility_ = Visibility.Collapsed;
            }
            
        }

        #region MakeBtnVisibility_
        private Visibility makeBtnVisibility_;
        public Visibility MakeBtnVisibility_
        {
            get { return this.makeBtnVisibility_; }
            set
            {
                if (this.makeBtnVisibility_ != value)
                {
                    this.makeBtnVisibility_ = value;
                    this.NotifyPropertyChanged("MakeBtnVisibility_");
                }
            }
        }
        #endregion

        #region UnderlyingCalcType_
        private string underlyingCalcType_;
        public string UnderlyingCalcType_
        {
            get { return this.underlyingCalcType_; }
            set
            {
                if (this.underlyingCalcType_ != value)
                {
                    this.underlyingCalcType_ = value;
                    this.NotifyPropertyChanged("UnderlyingCalcType_");
                }
            }
        }
        #endregion

        #region Maturity_
        private string maturity_;
        public string Maturity_
        {
            get { return this.maturity_; }
            set
            {
                if (this.maturity_ != value)
                {
                    this.maturity_ = value;
                    this.NotifyPropertyChanged("Maturity_");
                }
            }
        }
        #endregion

        #region MaturityPeriod_
        private string maturityPeriod_;
        public string MaturityPeriod_
        {
            get { return this.maturityPeriod_; }
            set
            {
                if (this.maturityPeriod_ != value)
                {
                    this.maturityPeriod_ = value;
                    this.NotifyPropertyChanged("MaturityPeriod_");
                }
            }
        }
        #endregion

        #region Excel_calendarViewModel_
        private Excel_calendarViewModel excel_calendarViewModel;
        public Excel_calendarViewModel Excel_calendarViewModel_
        {
            get { return this.excel_calendarViewModel; }
            set
            {
                if (this.excel_calendarViewModel != value)
                {
                    this.excel_calendarViewModel = value;
                    this.NotifyPropertyChanged("Excel_calendarViewModel_");
                }
            }
        }
        #endregion

        #region AutoCallTrigger_
        private ObservableCollection<string> autoCallTrigger_;
        public ObservableCollection<string> AutoCallTrigger_
        {
            get { return this.autoCallTrigger_; }
            set
            {
                if (this.autoCallTrigger_ != value)
                {
                    this.autoCallTrigger_ = value;
                    this.NotifyPropertyChanged("AutoCallTrigger_");
                }
            }
        }
        #endregion

        #region CouponTenor_
        private string couponTenor_;
        public string CouponTenor_
        {
            get { return this.couponTenor_; }
            set
            {
                if (this.couponTenor_ != value)
                {
                    this.couponTenor_ = value;
                    this.NotifyPropertyChanged("CouponTenor_");
                }
            }
        }
        #endregion

        #region CouponTenorPeriod_
        private string couponTenorPeriod_;
        public string CouponTenorPeriod_
        {
            get { return this.couponTenorPeriod_; }
            set
            {
                if (this.couponTenorPeriod_ != value)
                {
                    this.couponTenorPeriod_ = value;
                    this.NotifyPropertyChanged("CouponTenorPeriod_");
                }
            }
        }
        #endregion

        #region Coupon_
        private string coupon_;
        public string Coupon_
        {
            get { return this.coupon_; }
            set
            {
                if (this.coupon_ != value)
                {
                    this.coupon_ = value;
                    this.NotifyPropertyChanged("Coupon_");
                }
            }
        }
        #endregion

        #region Ki_
        private string ki_;
        public string Ki_
        {
            get { return this.ki_; }
            set
            {
                if (this.ki_ != value)
                {
                    this.ki_ = value;
                    this.NotifyPropertyChanged("Ki_");
                }
            }
        }
        #endregion

        #region KiObStartDate_
        private DateTime kiObStartDate_;
        public DateTime KiObStartDate_
        {
            get { return this.kiObStartDate_; }
            set
            {
                if (this.kiObStartDate_ != value)
                {
                    this.kiObStartDate_ = value;
                    this.NotifyPropertyChanged("KiObStartDate_");
                }
            }
        }
        #endregion

        #region KiObEndDate_
        private DateTime kiObEndDate_;
        public DateTime KiObEndDate_
        {
            get { return this.kiObEndDate_; }
            set
            {
                if (this.kiObEndDate_ != value)
                {
                    this.kiObEndDate_ = value;
                    this.NotifyPropertyChanged("KiObEndDate_");
                }
            }
        }
        #endregion

        #region SubScheduleDataList_
        private ObservableCollection<Excel_stepDownKI_subScheduleViewModel> subScheduleDataList_;
        public ObservableCollection<Excel_stepDownKI_subScheduleViewModel> SubScheduleDataList_
        {
            get { return this.subScheduleDataList_; }
            set
            {
                if (this.subScheduleDataList_ != value)
                {
                    this.subScheduleDataList_ = value;
                    this.NotifyPropertyChanged("SubScheduleDataList_");
                }
            }
        }
        #endregion

        #region SettlementDays_
        private int settlementDays_;
        public int SettlementDays_
        {
            get { return this.settlementDays_; }
            set
            {
                if (this.settlementDays_ != value)
                {
                    this.settlementDays_ = value;
                    this.NotifyPropertyChanged("SettlementDays_");
                }
            }
        }
        #endregion

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("excel_hifive_subtype");
                xmlWriter.WriteElementString("excel_type" , "excel_hifive_stepDown_ki");
                xmlWriter.WriteStartElement("excel_hifive_stepDown_ki");
                    xmlWriter.WriteElementString("underlyingCalcType", this.underlyingCalcType_);
                    xmlWriter.WriteElementString("maturity", this.maturity_);
                    xmlWriter.WriteElementString("maturityPeriod", this.maturityPeriod_);
                    xmlWriter.WriteElementString("couponTenor", this.couponTenor_);
                    xmlWriter.WriteElementString("couponTenorPeriod", this.couponTenorPeriod_);

                    foreach (var item in this.subScheduleDataList_)
                    {
                        item.buildXml(xmlWriter);
                    }

                    xmlWriter.WriteElementString("coupon", this.coupon_);
                    xmlWriter.WriteElementString("ki", this.ki_);
                    xmlWriter.WriteElementString("kiObStartDate", this.kiObStartDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("kiObEndDate", this.kiObEndDate_.ToString(StringFormat.XmlDateFormat_));
                    xmlWriter.WriteElementString("settlementDays", this.settlementDays_.ToString());
                    
                xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();
        }

        //public override void buildPricingXml(XmlWriter xmlWriter)
        //{
        //    xmlWriter.WriteStartElement("payoffInfo");
        //        xmlWriter.WriteElementString("type", "autoCallablePayoff");
        //        xmlWriter.WriteStartElement("autoCallablePayoff");

        //        this.Excel_scheduleListViewModel_.buildPricingXml(xmlWriter);
        //        //this.Excel_kiScheduleListViewModel_.buildPricingXml(xmlWriter);
                    
        //        xmlWriter.WriteEndElement();
        //    xmlWriter.WriteEndElement();
        //}

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }
        
        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            FpmlSerializedCSharp.Excel_hifive_subtype serial_Excel_hifive_subtype = serial_Class as FpmlSerializedCSharp.Excel_hifive_subtype;
            FpmlSerializedCSharp.Excel_hifive_stepDown_ki serial_Excel_hifive_stepDown_ki = serial_Excel_hifive_subtype.Excel_hifive_stepDown_ki_;

            this.underlyingCalcType_ = serial_Excel_hifive_stepDown_ki.UnderlyingCalcType_.ValueStr;

            this.maturity_ = serial_Excel_hifive_stepDown_ki.Maturity_.ValueStr;

            this.maturityPeriod_ = serial_Excel_hifive_stepDown_ki.MaturityPeriod_.ValueStr;

            this.couponTenor_ = serial_Excel_hifive_stepDown_ki.CouponTenor_.ValueStr;

            this.couponTenorPeriod_ = serial_Excel_hifive_stepDown_ki.CouponTenorPeriod_.ValueStr;

            List<FpmlSerializedCSharp.Excel_stepDownKI_subSchedule> serial_excel_stepDownKI_subSchedule = serial_Excel_hifive_stepDown_ki.Excel_stepDownKI_subSchedule_;
            this.subScheduleDataList_ = new ObservableCollection<Excel_stepDownKI_subScheduleViewModel>();
            foreach (var item in serial_excel_stepDownKI_subSchedule)
            {
                //string type = item.Type_.ValueStr;
                Excel_stepDownKI_subScheduleViewModel viewModel = new Excel_stepDownKI_subScheduleViewModel();
                viewModel.setFromSerial(item);
                this.subScheduleDataList_.Add(viewModel);
            }

            this.coupon_ = serial_Excel_hifive_stepDown_ki.Coupon_.ValueStr;
            this.ki_ = serial_Excel_hifive_stepDown_ki.Ki_.ValueStr;

            this.kiObStartDate_ = StringConverter.xmlDateToDateTime(serial_Excel_hifive_stepDown_ki.KiObStartDate_.ValueStr);
            this.kiObEndDate_ = StringConverter.xmlDateToDateTime(serial_Excel_hifive_stepDown_ki.KiObEndDate_.ValueStr);

            this.settlementDays_ =serial_Excel_hifive_stepDown_ki.SettlementDays_.IntValue();

            //this.view_ = new Excel_hifive_StepDownKI_View();
            //this.view_.DataContext = this;

        }

        public override void scheduleDataGenerateFromProductStr(TradeString ts)
        {
            this.subScheduleDataList_.Clear();

            StepDownKI_TradeString tsm = ts as StepDownKI_TradeString;

            this.CouponTenor_ = tsm.ObTenor_;
            this.Maturity_ = tsm.MaturiryYear_;
            this.Ki_ = tsm.KI_;
            this.Coupon_ = tsm.Coupon_;

            if (tsm.EffectiveDate_ != "")
            {
                this.EffectiveDate_ = StringConverter.xmlDateToDateTime(tsm.EffectiveDate_);
            }

            int stepMonth = Convert.ToInt32(this.CouponTenor_.Substring(0, this.CouponTenor_.Length - 1));

            int legCount = (12 / stepMonth) * Convert.ToInt32(this.Maturity_.Substring(0, this.Maturity_.Length - 1));

            double couponPerStep = (Convert.ToDouble(this.Coupon_) / 12) * Convert.ToDouble(stepMonth);

            for (int i = 0; i < legCount; i++)
            {
                Excel_stepDownKI_subScheduleViewModel data = new Excel_stepDownKI_subScheduleViewModel();

                data.Type_ = "AutoCall";
                //data.EventDate_ = this.scheduleGeneratorVM_.Dates_[i + 1];
                data.EventDate_ = this.effectiveDate_.AddMonths(stepMonth * (i + 1));

                data.UnderCalcType_ = "Minimum";
                data.AverageDays_ = "1";
                data.Coupon_ = (couponPerStep * (i + 1)).ToString();
                data.Trigger_ = tsm.TriggerList_[i];

                //try { data.Trigger_ = tsm.TriggerList_[i - 1]; }
                //catch (Exception) { }

                //double count_i = Convert.ToDouble(i);
                ////data.Coupon_ = (Convert.ToDouble(this.coupon_) * (count_i * couponMultiplier)).ToString();
                //double couponMultiplier = Convert.ToDouble(scheduleGeneratorVM_.FrequencyEnum_);
                //data.Coupon_ = (count_i * Convert.ToDouble(this.coupon_) / couponMultiplier).ToString();

                this.subScheduleDataList_.Add(data);
            }

            this.KiObStartDate_ = this.effectiveDate_;
            //this.KiObStartDate_ = this.subScheduleDataList_[0].EventDate_;
            this.KiObEndDate_ = this.subScheduleDataList_[this.subScheduleDataList_.Count - 1].EventDate_;
        }

        // 버튼을 누르면 schedule을 만들어줌
        public override void scheduleDataGenerate()
        {
            this.scheduleBuild();
        }

        ////underlying 이 바뀌면
        //public void underCalcBuild()
        //{
        //    this.excel_underlyingCalcIDVMList_ = new ObservableCollection<Excel_underlyingCalcIDViewModel>();

        //    ObservableCollection<string> selectedUnderName = new ObservableCollection<string>();

        //    foreach (var item in this.excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
        //    {
        //        selectedUnderName.Add(item.Name_);
        //    }

        //    Excel_underlyingCalcIDViewModel e_ucidvm
        //        = Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(this.underlyingCalcType_.ToUpper());

        //    //if (this.underlyingCalcType_.ToUpper() == "MAXIMUM")
        //    //{

        //    //    e_ucidvm.CalcID_ = "max0001";
        //    //    e_ucidvm.ReferenceType_ = "Maximum";
        //    //    e_ucidvm.SelectedUnderlyingName_ = selectedUnderName;
        //    //    e_ucidvm.Nth_ = "1";
        //    //}
        //    //else if (this.underlyingCalcType_.ToUpper() == "MINIMUM")
        //    //{

        //    //    e_ucidvm.CalcID_ = "min0001";
        //    //    e_ucidvm.ReferenceType_ = "Minimum";
        //    //    e_ucidvm.SelectedUnderlyingName_ = selectedUnderName;
        //    //    e_ucidvm.Nth_ = "1";
        //    //}
        //    //else
        //    //{
        //    //    throw new NotImplementedException();
        //    //}

        //    this.excel_underlyingCalcIDVMList_.Add(e_ucidvm);
            
        //}

        //이제 좀 정교하게 짜야함.

        private void scheduleBuild()
        {
            this.subScheduleDataList_.Clear();
            
            int stepMonth = Convert.ToInt32(this.CouponTenor_.Substring(0, this.CouponTenor_.Length - 1));

            int legCount = (12 / stepMonth) * Convert.ToInt32(this.Maturity_.Substring(0, this.Maturity_.Length - 1));

            double couponPerStep = ( Convert.ToDouble(this.Coupon_) / 12 ) * Convert.ToDouble(stepMonth) ;
            
            #region comment
            
            //this.subScheduleDataList_.Clear();

            //this.scheduleGeneratorVM_.InitialDate_ = this.effectiveDate_;

            ////QLNet.Period maturityPeriod = new Period(maturityTenor, tu);
            //QLNet.Period maturityPeriod = new Period(this.maturity_);

            //// Y 말고 M도 처리해야함 // 우선은 int로 하자 1.5Y이런거는 잠시 대기
            //int maturityTenor = maturityPeriod.length();

            //TimeUnit tu = maturityPeriod.units(); //TimeUnit.Years;

            //this.scheduleGeneratorVM_.EndDate_ = this.effectiveDate_.AddYears(maturityTenor);

            //QLNet.Period couponPeriod = new Period(this.couponTenor_); //new Period(couponTenor, tu);

            //// coupon
            //int couponTenor = couponPeriod.length();
            //double couponMultiplier = Convert.ToDouble(couponPeriod.frequency());//1.0;

            //this.scheduleGeneratorVM_.Tenor_ = couponPeriod.ToShortString();

            //int addingDays = 0;

            //this.scheduleGeneratorVM_.genDates(addingDays);

            //ObservableCollection<DateTime> eventDates = this.scheduleGeneratorVM_.Dates_;

            //int scheduleLength = eventDates.Count;

            //this.SettlementDays_ = Convert.ToInt32(tsm.SettlementDays_);

            #endregion

            for (int i = 0; i < legCount ; i++)
            {
                Excel_stepDownKI_subScheduleViewModel data = new Excel_stepDownKI_subScheduleViewModel();

                data.Type_ = "AutoCall";
                data.EventDate_ = this.effectiveDate_.AddMonths(stepMonth*(i+1));
                
                data.UnderCalcType_ = "Minimum";
                data.AverageDays_ = "1";
                data.Coupon_ = ( couponPerStep * (i+1)).ToString();
                data.Trigger_ = "100.0";

                this.subScheduleDataList_.Add(data);
            }

            this.KiObStartDate_ = this.effectiveDate_;
            this.KiObEndDate_ = this.subScheduleDataList_[this.subScheduleDataList_.Count - 1].EventDate_;
        }

        private Excel_simpleCalculationViewModel excel_simpleCalculationVMBuild(Excel_stepDownKI_subScheduleViewModel scheduleData)
        {
            Excel_simpleCalculationViewModel e_cvm = new Excel_simpleCalculationViewModel();

            e_cvm.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

            e_cvm.EventDate_ = scheduleData.EventDate_;

            e_cvm.PayoffDate_ = this.scheduleGeneratorVM_.addDays(scheduleData.EventDate_,this.settlementDays_);
            
            #region EventCal
            //---------------------------------------------------------------
            {
                //Excel_eventCalcInfoViewModel e_ecivm = new Excel_eventCalcInfoViewModel();

                Excel_singleRangeEventCalViewModel e_srecvm = new Excel_singleRangeEventCalViewModel();

                e_srecvm.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

                e_srecvm.LowerRng_ = (Convert.ToDouble(scheduleData.Trigger_) /100.0).ToString();
                e_srecvm.UpperRng_ = "1000";

                // 우선 max를 사용함
                Excel_underlyingCalcIDViewModel e_mucidvm = Excel_stepDownKI_subScheduleViewModel.CreateExcel_underlyingCalcID(scheduleData);

                e_mucidvm.setUnderlying(this.Excel_underlyingCalcInfoViewModel_);

                e_srecvm.Excel_underlyingCalcIDViewModel_ = e_mucidvm;

                //e_ecivm.Excel_eventCalcViewModel_.Add(e_srecvm);

                e_cvm.Excel_eventCalcInfoViewModel_ = e_srecvm;

                //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

            }

            #endregion

            #region ReturnCal
            //---------------------------------------------------------------
            {
                //Excel_returnCalcInfoViewModel e_rcivm = new Excel_returnCalcInfoViewModel();

                Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                e_crcvm.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

                e_crcvm.ConstReturn_ = (Convert.ToDouble(scheduleData.Coupon_) / 100).ToString();

                //e_rcivm.Excel_returnCalcViewModel_.Add(e_crcvm);

                e_cvm.Excel_returnCalcInfoViewModel_ = e_crcvm;

                //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

            }
            #endregion

            #region ComplementReturnCal
            {
                Excel_complementReturnCalcViewModel e_comp_rcvm = new Excel_complementReturnCalcViewModel();

                Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                e_crcvm.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

                e_crcvm.ConstReturn_ = "0.0";

                e_comp_rcvm.Excel_returnCalcInfoViewModel_ = e_crcvm;

                e_cvm.Excel_complementReturnCalcViewModel_ = e_comp_rcvm;
            }
            #endregion

            #region AutoCall_Event

            //---------------------------------------------------------------
            {
                Excel_eventCalcInfo_CallViewModel e_ecicvm = new Excel_eventCalcInfo_CallViewModel();

                Excel_singleRangeEventCalViewModel e_srecvm = new Excel_singleRangeEventCalViewModel();
                
                e_srecvm.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

                e_srecvm.LowerRng_ = (Convert.ToDouble(scheduleData.Trigger_) / 100.0).ToString();
                e_srecvm.UpperRng_ = "1000";

                //처음꺼만 사용함
                Excel_underlyingCalcIDViewModel e_mucidvm = Excel_stepDownKI_subScheduleViewModel.CreateExcel_underlyingCalcID(scheduleData);

                e_mucidvm.setUnderlying(this.Excel_underlyingCalcInfoViewModel_);

                e_srecvm.Excel_underlyingCalcIDViewModel_ = e_mucidvm;

                e_ecicvm.Excel_eventCalcInfoViewModel_ = e_srecvm;

                e_cvm.Excel_eventCalcInfo_CallViewModel_ = e_ecicvm;

                //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

            }

            #endregion

            #region AutoCall_ReturnCal

            //---------------------------------------------------------------
            {
                Excel_returnCalcInfo_CallViewModel e_rcicvm = new Excel_returnCalcInfo_CallViewModel();

                Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                e_crcvm.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

                e_crcvm.ConstReturn_ = "1.0"; // 원금

                e_rcicvm.Excel_returnCalcInfoViewModel_ = e_crcvm;

                e_cvm.Excel_returnCalcInfo_CallViewModel_ = e_rcicvm;

                //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

            }

            #endregion

            return e_cvm;
        }

        public override void excel_scheduleListVMBuild()
        {
            int scheduleNum = this.subScheduleDataList_.Count; ;

            Excel_scheduleListViewModel e_slvm = new Excel_scheduleListViewModel();

            for (int i = 0; i < scheduleNum; i++)
            {
                e_slvm.Excel_scheduleViewModel_.Add(
                    this.excel_simpleCalculationVMBuild(this.subScheduleDataList_[i]));
            }

            this.Excel_scheduleListViewModel_ = e_slvm;
        }

        public override void excel_kiEventCalculationBuild()
        {
            Excel_simpleKiEventCalcViewModel e_simpleKiEvent = new Excel_simpleKiEventCalcViewModel();

            e_simpleKiEvent.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

            e_simpleKiEvent.EventDate_ = this.KiObEndDate_;
            e_simpleKiEvent.PayoffDate_ = this.KiObEndDate_;

            #region EventCal
            {
                Excel_singleBarrierEventCalViewModel e_singleBarrierEvent = new Excel_singleBarrierEventCalViewModel();

                e_singleBarrierEvent.UpperTrigger_ = "1000";
                e_singleBarrierEvent.LowerTrigger_ = ( Convert.ToDouble(this.Ki_) /100.0 ).ToString();

                // 우선 max를 사용함

                Excel_minimumUnderlyingCalcIDViewModel e_mucidvm = new Excel_minimumUnderlyingCalcIDViewModel();

                e_mucidvm.EventDate_ = this.KiObEndDate_;

                e_mucidvm.setUnderlying(this.Excel_underlyingCalcInfoViewModel_);

                e_singleBarrierEvent.Excel_underlyingCalcIDViewModel_ = e_mucidvm;

                e_singleBarrierEvent.setUnderlying(this.Excel_underlyingCalcInfoViewModel_);

                e_singleBarrierEvent.ObservationStartDate_ = this.KiObStartDate_;
                e_singleBarrierEvent.ObservationEndDate_ = this.KiObEndDate_;

                e_simpleKiEvent.Excel_eventCalcInfoViewModel_ = e_singleBarrierEvent;
            }
            #endregion

            #region OccReturn
            {
                Excel_vanillaReturnCalViewModel e_vanillaReturn = new Excel_vanillaReturnCalViewModel();

                e_vanillaReturn.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

                //e_vanillaReturn.Gearing_ = "-1";
                //e_vanillaReturn.Spread_ = "-0.2";

                e_vanillaReturn.Gearing_ = "1.0";
                e_vanillaReturn.Spread_ = "0.0";

                Excel_minimumUnderlyingCalcIDViewModel e_mucidvm = new Excel_minimumUnderlyingCalcIDViewModel();

                e_mucidvm.EventDate_ = this.KiObEndDate_;
                e_mucidvm.setUnderlying(this.Excel_underlyingCalcInfoViewModel_);

                e_vanillaReturn.ReturnUnderlyingCalcIDViewModel_ = e_mucidvm;

                e_simpleKiEvent.Excel_occReturnCalcInfoViewModel_ = new Excel_occReturnCalcInfoViewModel();
                e_simpleKiEvent.Excel_occReturnCalcInfoViewModel_.Excel_returnCalcInfoViewModel_ = e_vanillaReturn;
            }
            #endregion

            #region noOccReturn
            {
                Excel_constReturnCalViewModel e_constReturnCalc = new Excel_constReturnCalViewModel();
                int count = this.subScheduleDataList_.Count;

                //입력으로 받아도 대는데 지금은 마지막껄로함.
                e_constReturnCalc.ConstReturn_ = (1.0 + Convert.ToDouble(this.subScheduleDataList_[count - 1].Coupon_) / 100.0).ToString();

                e_constReturnCalc.Excel_underlyingCalcInfoViewModel_ = this.Excel_underlyingCalcInfoViewModel_;

                e_simpleKiEvent.Excel_noOccReturnCalcInfoViewModel_ = new Excel_noOccReturnCalcInfoViewModel();
                e_simpleKiEvent.Excel_noOccReturnCalcInfoViewModel_.Excel_returnCalcInfoViewModel_ = e_constReturnCalc;

                e_simpleKiEvent.Excel_noOccReturnCalcInfoViewModel_.setUnderlying(this.Excel_underlyingCalcInfoViewModel_);
            }
            #endregion

            this.Excel_kiEventCalculationViewModel_ = e_simpleKiEvent;
        }

        public override void buildProduct()
        {
            //this.underCalcBuild();
            //this.scheduleBuild();

            this.excel_scheduleListVMBuild();
            this.excel_kiEventCalculationBuild();
        }

        public override Control view()
        {
            Control v = new Excel_hifive_StepDownKI_View();

            v.DataContext = this;

            return v;
        }

        public override void setUnderlying(Excel_underlyingCalcInfoViewModel excel_under)
        {
            this.excel_underlyingCalcInfoViewModel_ = excel_under;
        }

        //public override string productStringGenerate()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.Append("Type = 2 Stock Step Down Double Callable;");

        //    string unders = this.excel_underlyingCalcInfoViewModel_.getUnderlyingString();

        //    sb.Append("Underlyings=" + unders + ";");
        //    sb.Append("Tenor=" + this.maturity_ + ";");
        //    sb.Append("Observation period=" + this.couponTenor_ + ";");

        //    sb.Append("Trigger level=;");

        //    sb.Append("Knock In barrier=;");
        //    sb.Append("Coupon(p.a)=11.3;");
        //    sb.Append("EffectiveDate=2013-07-08;");
        //    sb.Append("ExportCode=50507A3709S0;");
        //    sb.Append("Notional=300000000;");
        //    sb.Append("Name=IBK 제882회 사모ELS;");

            

        //    return sb.ToString();
        //}


        public override void DefaultSetting(Excel_hifiveViewModel e_hvm)
        {
            this.Coupon_ = "4.0";
            this.CouponTenor_ = "6m";
            this.Maturity_ = "3y";

            this.Ki_ = "55.0";

            this.KiObStartDate_ = e_hvm.Excel_issueInfoViewModel_.EffectiveDate_;
            this.KiObEndDate_ = e_hvm.Excel_issueInfoViewModel_.MaturityDate_;
        }
    }
    
}

