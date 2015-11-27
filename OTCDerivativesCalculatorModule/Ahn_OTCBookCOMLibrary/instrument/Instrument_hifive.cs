using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using Excel_Interface;
using System.Runtime.InteropServices;

namespace Ahn_OTCBookCOMLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Instrument_hifive
    {

        [ComVisible(false)]
        public Excel_instrument_hifiveViewModel InstVM_ { get; set; }

        private ErrLog ErrLog_;
        //private DateTime referenceDate_;

        public Instrument_hifive()
        {
            this.InstVM_ = new Excel_instrument_hifiveViewModel(true);
            this.ErrLog_ = new ErrLog();
        }

        public string set_issueInfo(double notional,
                                    DateTime effDate,
                                    DateTime matDate,
                                    string currency,
                                    double notionalPayment,
                                    bool overwrite = true)
        {
            try
            {
                if (effDate == null || effDate.Year == 1899)
                    throw new Exception("effectiveDate empty");

                if (matDate == null || matDate.Year == 1899)
                    throw new Exception("maturityDate empty");

                if (effDate >= matDate)
                    throw new Exception("maturity must be later than effective");

                Excel_noteInfoViewModel e_noteInfo = new Excel_noteInfoViewModel();

                e_noteInfo.Notional_ = notional.ToString();
                e_noteInfo.EffectiveDate_ = effDate;
                e_noteInfo.MaturityDate_ = matDate;
                e_noteInfo.Currency_ = new CurrencyViewModel(currency, currency);
                e_noteInfo.IncludeNotionalPayment_ = notionalPayment.ToString();

                this.InstVM_.Excel_interfaceViewModel_.Excel_issueInfoViewModel_ = e_noteInfo;

                List<string> member = new List<string>() {"instType", "type", "notional", "effDate", "matDate", "currency"};
                List<string> value = new List<string>() { "hifive","issueInfo", notional.ToString(), StringConverter.xmlDateTimeToDateString(effDate), StringConverter.xmlDateTimeToDateString(matDate), currency.ToString() };

                e_noteInfo.VBA_description_ = this.vba_description(member, value);

                return "set complete";
            }
            catch (Exception e)
            {
                return "add fail : " + e.Message;
            }
        }

        private void addUnderlying(string underCodes)
        {
            string[] underCodeList = underCodes.Split(',', '|');

            foreach (var item2 in underCodeList)
            {
                bool existFlag = false;

                foreach (var item in this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
                {
                    if (item2.Trim().ToUpper() == item.KrCode_.ToUpper())
                    {
                        existFlag = true;
                    }    
                }

                if (!existFlag)
                {
                    Excel_underlyingInfoViewModel e_uivm = Excel_loaderViewModel.loadUnderInfoWithoutBasePrice(item2);

                    this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.
                        Excel_underlyingInfoViewModel_.Add(e_uivm);

                    Excel_standardHifiveParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;
                    
                    Excel_underlyingInfo_paraViewModel e_ui_pvm = new Excel_underlyingInfo_paraViewModel();

                    e_ui_pvm.buildParaSetting(e_uivm);

                    e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Add(e_ui_pvm);

                    e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.addDiagonal(e_ui_pvm);
                }

            }

            return;

        }

        public string add_underlying(string underCode,double basePrice)
        {
            try
            {
                this.addUnderlying(underCode);
                this.set_basePrice(underCode, basePrice);

                return "add underlying complete";
            }
            catch (Exception e)
            {
                return "add underlying fail : " + e.Message;
            }
        }

        private bool hasUnderlyings(string underlyings)
        {
            string[] underCodeList = underlyings.Split(',', '|');

            bool existFlag = true;

            foreach (var item in underCodeList)
            {
                existFlag = existFlag &&
                    this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.hasUnderlying(item);

            }

            return existFlag;

        }

        public string set_basePrice(string underCode, double basePrice)
        {

            string errLog = "";

            foreach (var item in this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
            {
                if (underCode.Trim().ToUpper() == item.KrCode_.ToUpper())
                {
                    item.BasePrice_ = basePrice.ToString();
                    
                    errLog = errLog + "inst under complete ";  
                }
            }

            Excel_standardHifiveParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;

            foreach (var item in e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_)
            {
                if (underCode.Trim().ToUpper() == item.KrCode_.ToUpper())
                {
                    item.BasePrice_ = basePrice.ToString();

                    errLog = errLog + "para under complete";  
                }
            }

            if (errLog == "")
            {
                return "set fail";
            }

            return "set complete";
        }

        public string underlyingInfo()
        {
            try
            {
                return this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.getUnderlyingString(); ;
            }
            catch (Exception e)
            {
                return "load fail : " + e.Message;
            }
        }

        public string set_gbmModel(string underCode, double currentValue, double drift, double dividend, double constVol)
        {
            try
            {
                Excel_standardHifiveParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;

                bool setFlag = false;

                foreach (var item in e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_)
                //foreach (var item in InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
                {
                    if (underCode.ToUpper() == item.KrCode_.ToUpper())
                    {
                        Excel_geometricBMViewModel e_gbmvm = new Excel_geometricBMViewModel();

                        e_gbmvm.CurrentValue_ = currentValue.ToString();
                        e_gbmvm.Drift_ = drift.ToString();
                        e_gbmvm.Dividend_ = dividend.ToString();
                        e_gbmvm.Volatility_ = constVol.ToString();

                        item.Excel_underlyingModel_paraViewModel_ = e_gbmvm;

                    }
                }


                if (!setFlag)
                {
                    throw new Exception(underCode + " doesn't exist");
                }

                return "set gbm_model complete : " + underCode;
            }
            catch (Exception e)
            {
                string errStr = "set fail: " + e.Message;

                return errStr;
            }
        }

        public string set_hullWhiteModel(string underCode, double currentValue, double alpha, double sigma, YieldTermStructure fittingCurve)
        {
            try
            {
                Excel_standardHifiveParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;

                // under 에서 tenor를 가져옴
                string tenor = "3M"; // defaultrrrr

                bool setFlag = false;

                Excel_hullWhiteOneFactorViewModel e_hwvm = new Excel_hullWhiteOneFactorViewModel();

                foreach (var item in e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_)
                {
                    if (underCode == item.KrCode_)
                    {
                        e_hwvm.CurrentValue_ = currentValue.ToString();

                        e_hwvm.Alpha_ = alpha.ToString();
                        e_hwvm.Volatility_ = sigma.ToString();

                        e_hwvm.Excel_yieldCurveViewModel_ = fittingCurve.Excel_yieldCurveViewModel_;

                        item.Excel_underlyingModel_paraViewModel_ = e_hwvm;

                        setFlag = true;

                    }
                }

                Excel_rateInfoViewModel e_rateInfoVM = new Excel_rateInfoViewModel();

                foreach (var item in this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
                {
                    if (underCode == item.KrCode_)
                    {
                        Excel_interestRateViewModel e_irvm = item as Excel_interestRateViewModel;

                        e_hwvm.setInterestRateInfo(e_irvm);
                    }
                }



                if (!setFlag)
                {
                    throw new Exception(underCode + " doesn't exist");
                }

                return "set hullWhit_model complete : " + underCode;
            }
            catch (Exception e)
            {
                return "set fail : " + e.Message;
            }
        }

        public string add_autoCall_sch(DateTime eventDate,
                                       DateTime payoffDate,
                                       double lowerTrigger,
                                       double upperTrigger,
                                       //CalculationEnum underCalcType,
                                       string underCalcType,
                                       string underlyings,
                                       double constCoupon)
        {
            try
            {
                #region CheckParameter

                if (underlyings == "")
                    throw new Exception("underlying input is empty");

                // check underlying 
                if ( !this.hasUnderlyings(underlyings))
                    throw new Exception(underlyings + " does not exist. add underlying first.");

                #endregion

                Excel_simpleCalculationViewModel e_scvm = new Excel_simpleCalculationViewModel();
                
                //this.addUnderlying(underlyings);

                Excel_underlyingCalcInfoViewModel e_ucivm = this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_;

                e_scvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                e_scvm.EventDate_ = eventDate;

                e_scvm.PayoffDate_ = payoffDate;

                #region EventCal
                //---------------------------------------------------------------
                {
                    //Excel_eventCalcInfoViewModel e_ecivm = new Excel_eventCalcInfoViewModel();

                    Excel_singleRangeEventCalViewModel e_srecvm = new Excel_singleRangeEventCalViewModel();

                    e_srecvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                    e_srecvm.LowerRng_ = lowerTrigger.ToString();
                    e_srecvm.UpperRng_ = upperTrigger.ToString();

                    // 우선 max를 사용함
                    Excel_underlyingCalcIDViewModel e_mucidvm = 
                        Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(underCalcType);

                    e_mucidvm.EventDate_ = eventDate;

                    e_mucidvm.setUnderlying(e_ucivm);
                    e_mucidvm.selectUnderlyings(underlyings);

                    e_srecvm.Excel_underlyingCalcIDViewModel_ = e_mucidvm;

                    //e_ecivm.Excel_eventCalcViewModel_.Add(e_srecvm);

                    e_scvm.Excel_eventCalcInfoViewModel_ = e_srecvm;

                    //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

                }

                #endregion

                #region ReturnCal
                //---------------------------------------------------------------
                {
                    //Excel_returnCalcInfoViewModel e_rcivm = new Excel_returnCalcInfoViewModel();

                    Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                    e_crcvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                    e_crcvm.ConstReturn_ = constCoupon.ToString();

                    //e_rcivm.Excel_returnCalcViewModel_.Add(e_crcvm);

                    e_scvm.Excel_returnCalcInfoViewModel_ = e_crcvm;

                    //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

                }
                #endregion

                #region ComplementReturnCal
                {
                    Excel_complementReturnCalcViewModel e_comp_rcvm = new Excel_complementReturnCalcViewModel();

                    Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                    e_crcvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                    e_crcvm.ConstReturn_ = "0.0";

                    e_comp_rcvm.Excel_returnCalcInfoViewModel_ = e_crcvm;

                    e_scvm.Excel_complementReturnCalcViewModel_ = e_comp_rcvm;
                }
                #endregion

                #region AutoCall_Event

                //---------------------------------------------------------------
                {
                    Excel_eventCalcInfo_CallViewModel e_ecicvm = new Excel_eventCalcInfo_CallViewModel();

                    Excel_singleRangeEventCalViewModel e_srecvm = new Excel_singleRangeEventCalViewModel();

                    e_srecvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                    e_srecvm.LowerRng_ = lowerTrigger.ToString();
                    e_srecvm.UpperRng_ = upperTrigger.ToString();;

                    //처음꺼만 사용함
                    Excel_underlyingCalcIDViewModel e_mucidvm = 
                        Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(underCalcType);

                    e_mucidvm.EventDate_ = eventDate;

                    e_mucidvm.setUnderlying(e_ucivm);
                    e_mucidvm.selectUnderlyings(underlyings);

                    e_srecvm.Excel_underlyingCalcIDViewModel_ = e_mucidvm;

                    e_ecicvm.Excel_eventCalcInfoViewModel_ = e_srecvm;

                    e_scvm.Excel_eventCalcInfo_CallViewModel_ = e_ecicvm;

                    //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

                }

                #endregion

                #region AutoCall_ReturnCal

                //---------------------------------------------------------------
                {
                    Excel_returnCalcInfo_CallViewModel e_rcicvm = new Excel_returnCalcInfo_CallViewModel();

                    Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                    e_crcvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                    e_crcvm.ConstReturn_ = "0.0"; // 원금

                    e_rcicvm.Excel_returnCalcInfoViewModel_ = e_crcvm;

                    e_scvm.Excel_returnCalcInfo_CallViewModel_ = e_rcicvm;

                    //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

                }

                #endregion

                Excel_hifiveViewModel e_hvm = this.InstVM_.Excel_interfaceViewModel_ as Excel_hifiveViewModel;

                e_hvm.Excel_scheduleListViewModel_.Excel_scheduleViewModel_.Add(e_scvm);

                int schNum = e_hvm.Excel_scheduleListViewModel_.Excel_scheduleViewModel_.Count -1;
                //Type type = this. GetType();
                //MethodInfo methodInfo = type.GetMethod("add_autoCall_sch");
                //ParameterInfo[] paraList = methodInfo.GetParameters();

                List<string> member = new List<string>() { "instType", "type" , "schNum", "eventDate", "payoffDate", "lowerTrigger", "upperTrigger", "underCalcType", "underlyings", "constCoupon" };
                List<string> value = new List<string>() { "hifive", "autoCall_sch", schNum.ToString() , StringConverter.xmlDateTimeToDateString(eventDate), StringConverter.xmlDateTimeToDateString(payoffDate), lowerTrigger.ToString(), upperTrigger.ToString(), underCalcType, underlyings, constCoupon.ToString() };

                e_scvm.VBA_description_ = this.vba_description(member, value);

                return "add complete";
            }
            catch (Exception e)
            {
                return "add fail : " + e.Message;
            }
        }

        private string vba_description(List<string> member, List<string> value)
        {
            StringBuilder sb = new StringBuilder();

            if (member.Count != value.Count)
            {
                sb.Append("para num is not same to value");
            }


            for (int i = 0; i < member.Count; i++)
            {
                sb.Append(member[i] + "=" + value[i] + ";");
            }

            return sb.ToString();
        }

        public string add_monthlyCoupon_sch(DateTime eventDate,
                                       DateTime payoffDate,
                                       double lowerTrigger,
                                       double upperTrigger,
                                       //CalculationEnum underCalcType, 
                                       string underCalcType,
                                       string underlyings,
                                       double constCoupon)
        {
            try
            {
                #region CheckParameter

                if (underlyings == "")
                    throw new Exception("underlying input is empty");

                // check underlying 
                if ( !this.hasUnderlyings(underlyings))
                    throw new Exception(underlyings + " does not exist. add underlying first.");


                #endregion

                Excel_simpleCalculationViewModel e_scvm = new Excel_simpleCalculationViewModel();

                //this.addUnderlying(underlyings);

                Excel_underlyingCalcInfoViewModel e_ucivm = this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_;

                e_scvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                e_scvm.EventDate_ = eventDate;

                e_scvm.PayoffDate_ = payoffDate;

                #region EventCal
                //---------------------------------------------------------------
                {
                    //Excel_eventCalcInfoViewModel e_ecivm = new Excel_eventCalcInfoViewModel();

                    Excel_singleRangeEventCalViewModel e_srecvm = new Excel_singleRangeEventCalViewModel();

                    e_srecvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                    e_srecvm.LowerRng_ = lowerTrigger.ToString();
                    e_srecvm.UpperRng_ = upperTrigger.ToString();

                    // 우선 max를 사용함
                    Excel_underlyingCalcIDViewModel e_mucidvm = 
                        Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID(underCalcType);

                    e_mucidvm.EventDate_ = eventDate;

                    e_mucidvm.setUnderlying(e_ucivm);
                    e_mucidvm.selectUnderlyings(underlyings);

                    e_srecvm.Excel_underlyingCalcIDViewModel_ = e_mucidvm;

                    //e_ecivm.Excel_eventCalcViewModel_.Add(e_srecvm);

                    e_scvm.Excel_eventCalcInfoViewModel_ = e_srecvm;

                    //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

                }

                #endregion

                #region ReturnCal
                //---------------------------------------------------------------
                {
                    //Excel_returnCalcInfoViewModel e_rcivm = new Excel_returnCalcInfoViewModel();

                    Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                    e_crcvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                    e_crcvm.ConstReturn_ = constCoupon.ToString();

                    //e_rcivm.Excel_returnCalcViewModel_.Add(e_crcvm);

                    e_scvm.Excel_returnCalcInfoViewModel_ = e_crcvm;

                    //info 에 드가는 곱하기라던지 floor라던지 postCalculation 같은게 붙어야함

                }
                #endregion

                #region ComplementReturnCal
                {
                    Excel_complementReturnCalcViewModel e_comp_rcvm = new Excel_complementReturnCalcViewModel();

                    Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                    e_crcvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                    e_crcvm.ConstReturn_ = "0.0";

                    e_comp_rcvm.Excel_returnCalcInfoViewModel_ = e_crcvm;

                    e_scvm.Excel_complementReturnCalcViewModel_ = e_comp_rcvm;
                }
                #endregion

                Excel_hifiveViewModel e_hvm = this.InstVM_.Excel_interfaceViewModel_ as Excel_hifiveViewModel;

                e_hvm.Excel_scheduleListViewModel_.Excel_scheduleViewModel_.Add(e_scvm);

                return "add complete";
            }
            catch (Exception e)
            {
                return "add fail : " + e.Message;
            }
        }

        // ki 계열
        public string set_constKI_sch(double lowerTrigger,
                                       double upperTrigger,
                                       //CalculationEnum kiCheckType,
                                       string kiCheckType,
                                       string underlyings,
                                       //LossType lossType,
                                       string lossType, // 이거 구분 아직 안함
                                       double noKICoupon,
                                       DateTime obStartDate,
                                       DateTime obEndDate)
        {
            try
            {
                #region CheckParameter

                if (underlyings == "")
                    throw new Exception("underlying input is empty");
                
                // check underlying 
                if ( !this.hasUnderlyings(underlyings))
                    throw new Exception(underlyings + " does not exist. add underlying first.");

                #endregion

                Excel_simpleKiEventCalcViewModel e_simpleKiEvent = new Excel_simpleKiEventCalcViewModel();

                //this.addUnderlying(underlyings);

                Excel_underlyingCalcInfoViewModel e_ucivm = this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_;

                e_simpleKiEvent.Excel_underlyingCalcInfoViewModel_ = e_ucivm;
                
                e_simpleKiEvent.EventDate_ = obEndDate;
                e_simpleKiEvent.PayoffDate_ = obEndDate;

                #region EventCal
                {
                    Excel_singleBarrierEventCalViewModel e_singleBarrierEvent = new Excel_singleBarrierEventCalViewModel();

                    e_singleBarrierEvent.UpperTrigger_ = upperTrigger.ToString();
                    e_singleBarrierEvent.LowerTrigger_ = lowerTrigger.ToString(); 

                    // 우선 max를 사용함

                    Excel_minimumUnderlyingCalcIDViewModel e_mucidvm = new Excel_minimumUnderlyingCalcIDViewModel();

                    e_mucidvm.EventDate_ = obEndDate;

                    e_mucidvm.setUnderlying(e_ucivm);
                    e_mucidvm.selectUnderlyings(underlyings);

                    e_singleBarrierEvent.Excel_underlyingCalcIDViewModel_ = e_mucidvm;

                    //e_singleBarrierEvent.setUnderlying(e_ucivm);
                    
                    e_singleBarrierEvent.ObservationStartDate_ = obStartDate;
                    e_singleBarrierEvent.ObservationEndDate_ = obEndDate;

                    e_simpleKiEvent.Excel_eventCalcInfoViewModel_ = e_singleBarrierEvent;
                }
                #endregion

                #region OccReturn
                {
                    Excel_vanillaReturnCalViewModel e_vanillaReturn = new Excel_vanillaReturnCalViewModel();

                    e_vanillaReturn.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                    //e_vanillaReturn.Gearing_ = "-1";
                    //e_vanillaReturn.Spread_ = "-0.2";

                    e_vanillaReturn.Gearing_ = "1.0";
                    e_vanillaReturn.Spread_ = "-1.0";

                    Excel_minimumUnderlyingCalcIDViewModel e_mucidvm = new Excel_minimumUnderlyingCalcIDViewModel();

                    e_mucidvm.EventDate_ = obEndDate;
                    e_mucidvm.setUnderlying(e_ucivm);
                    e_mucidvm.selectUnderlyings(underlyings);

                    e_vanillaReturn.ReturnUnderlyingCalcIDViewModel_ = e_mucidvm;

                    e_simpleKiEvent.Excel_occReturnCalcInfoViewModel_ = new Excel_occReturnCalcInfoViewModel();
                    e_simpleKiEvent.Excel_occReturnCalcInfoViewModel_.Excel_returnCalcInfoViewModel_ = e_vanillaReturn;
                }
                #endregion

                #region noOccReturn
                {
                    Excel_constReturnCalViewModel e_constReturnCalc = new Excel_constReturnCalViewModel();
                    
                    e_constReturnCalc.ConstReturn_ = noKICoupon.ToString();

                    e_constReturnCalc.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                    e_simpleKiEvent.Excel_noOccReturnCalcInfoViewModel_ = new Excel_noOccReturnCalcInfoViewModel();
                    e_simpleKiEvent.Excel_noOccReturnCalcInfoViewModel_.Excel_returnCalcInfoViewModel_ = e_constReturnCalc;

                    e_simpleKiEvent.Excel_noOccReturnCalcInfoViewModel_.setUnderlying(e_ucivm);
                }
                #endregion

                Excel_hifiveViewModel e_hvm = this.InstVM_.Excel_interfaceViewModel_ as Excel_hifiveViewModel;

                e_hvm.Excel_kiEventCalculationViewModel_ = e_simpleKiEvent;

                List<string> member = new List<string>() {"instType", "schtype","lowerTrigger", "upperTrigger", "kiCheckType", "underlyings", "lossType", "noKICoupon", "obStartDate", "obEndDate" };
                List<string> value = new List<string>() { "hifive" ,"constKI",lowerTrigger.ToString(), upperTrigger.ToString(), kiCheckType.ToString(), underlyings.ToString(), lossType.ToString(), noKICoupon.ToString(), StringConverter.xmlDateTimeToDateString(obStartDate), StringConverter.xmlDateTimeToDateString(obEndDate) };

                e_simpleKiEvent.VBA_description_ = this.vba_description(member, value);

                return "set complete";
            }
            catch (Exception e)
            {
                return "set fail : " + e.Message;
            }
        }

        public string set_discountCurve(string currency, YieldTermStructure discountCurve)
        {
            try
            {
                Excel_standardHifiveParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;

                int count = e_sphvm.Excel_discountCurve_paraViewModel_.hasCurrencysYieldCurve(currency);

                discountCurve.Excel_yieldCurveViewModel_.Currency_ = currency;

                if (count == -1)
                {
                    e_sphvm.Excel_discountCurve_paraViewModel_.Excel_yieldCurveViewModel_
                        .Add(discountCurve.Excel_yieldCurveViewModel_);
                }
                else
                {
                    e_sphvm.Excel_discountCurve_paraViewModel_.Excel_yieldCurveViewModel_[count]
                        = discountCurve.Excel_yieldCurveViewModel_;
                }

                return "set discountCurve complete : " + currency;
            }
            catch (Exception e)
            {
                string errStr = "set fail: " + e.Message;

                return errStr;
            }
        }

        public string get_instrumentXml()
        {
            try
            {
                return this.InstVM_.Excel_interfaceViewModel_.productXml();
            }
            catch (Exception e)
            {
                string errStr = "xml inst build fail: " + e.Message;

                return errStr;
            }
        }

        public void save_instrumentXml(string name)
        {
            try
            {
                XMLFileLoader.SaveInstrument(name, this.InstVM_.Excel_interfaceViewModel_.productXml());
                
                this.ErrLog_.add("save complete");
            }
            catch (Exception e)
            {
                string errStr = "instXml save fail: " + e.Message;

                this.ErrLog_.add(errStr);
            }
        }

        public void save_parameterXml(string name, DateTime refDate)
        {
            try
            {
                InstVM_.Excel_parameterViewModel_.ReferenceDate_ = refDate;

                XMLFileLoader.SaveParameter(name, this.InstVM_.Excel_parameterViewModel_.paraXml(), refDate);

                this.ErrLog_.add("save complete");
            }
            catch (Exception e)
            {
                string errStr = "paraXml save fail: " + e.Message;

                this.ErrLog_.add(errStr);
            }
        }

        public string get_parameterXml()
        {
            try
            {
                return this.InstVM_.Excel_parameterViewModel_.paraXml();
            }
            catch (Exception e)
            {
                string errStr = "xml parameter build fail: " + e.Message;

                return errStr;
            }
        }
        
        public string get_issueInfo(InfoType infoType)
        {
            try
            {
                string vba_desc = this.InstVM_.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.VBA_description_;

                return this.infoParsing(vba_desc, infoType);
            }
            catch (Exception e)
            {
                return "get issueInfo fail : " + e.Message;
            }
        }

        public string get_sch_info(int scheduleNum,InfoType infoType)
        {
            try
            {
                Excel_hifiveViewModel e_hifiveVM = this.InstVM_.Excel_interfaceViewModel_ as Excel_hifiveViewModel;

                string vba_desc = e_hifiveVM.Excel_scheduleListViewModel_.Excel_scheduleViewModel_[scheduleNum].VBA_description_;

                return this.infoParsing(vba_desc, infoType);
                
            }
            catch (Exception e)
            {
                string errStr = "get schdule info fail: " + e.Message;

                return errStr;
            }
        }

        private string infoParsing(string str, InfoType infoType)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (infoType == InfoType.Header)
                {
                    string[] split = str.Split(';');

                    foreach (var item in split)
                    {
                        int equalCount = item.IndexOf('=');

                        if (item != "")
                        {
                            sb.Append(item.Substring(0, equalCount) + ";");
                        }

                    }

                }
                else if (infoType == InfoType.Value)
                {
                    string[] split = str.Split(';');

                    foreach (var item in split)
                    {
                        int equalCount = item.IndexOf('=');

                        if (item != "")
                        {

                            sb.Append(item.Substring(equalCount + 1, item.Length - (equalCount + 1)) + ";");
                        }

                    }
                }
                else if (infoType == InfoType.Header_Value)
                {
                    sb.Append(str);
                }
                else
                {

                }

                return sb.ToString();

            }
            catch (Exception e)
            {
                return "add fail : " + e.Message;
            }
        }

        public int get_underlyingNum()
        {
            try
            {
                int count = this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_.Count;

                return count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int get_underlyingParaNum()
        {
            try
            {
                Excel_standardHifiveParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;

                int count = e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Count;

                return count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public string get_underlyingInfo(int underCount, InfoType infoType)
        {
            try
            {
                string vba_desc = this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_[underCount].vba_desciption();

                return this.infoParsing(vba_desc, infoType);
            }
            catch (Exception e)
            {
                return "not implemented : " + e.Message;
            }
        }

        public string get_underlyingParaInfo(int underCount, InfoType infoType)
        {
            try
            {
                Excel_standardHifiveParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;

                string vba_desc = e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_[underCount].vba_desciption();

                return this.infoParsing(vba_desc, infoType);
            }
            catch (Exception e)
            {
                return "not implemented : " + e.Message;
            }
        }

        public string get_correlationInfo(int corrCount, InfoType infoType)
        {
            try
            {
                Excel_standardHifiveParaViewModel e_shpvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;

                string vba_desc = e_shpvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_[corrCount].vba_desciption();

                return this.infoParsing(vba_desc, infoType);
            }
            catch (Exception e)
            {
                return "not implemented : " + e.Message;
            }
        }

        public int get_scheduleNum()
        {
            try
            {
                Excel_hifiveViewModel e_hifiveVM = this.InstVM_.Excel_interfaceViewModel_ as Excel_hifiveViewModel;

                return e_hifiveVM.Excel_scheduleListViewModel_.Excel_scheduleViewModel_.Count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public string get_ki_sch_info(InfoType infoType)
        {
            try
            {
                Excel_hifiveViewModel e_hifiveVM = this.InstVM_.Excel_interfaceViewModel_ as Excel_hifiveViewModel;
                
                string vba_desc = e_hifiveVM.Excel_kiEventCalculationViewModel_.VBA_description_;
                
                return this.infoParsing(vba_desc, infoType);
            }
            catch (Exception e)
            {
                return "get kischedule fail : " + e.Message;
            }
        }

        public int get_correlationNum()
        {
            try
            {
                Excel_standardHifiveParaViewModel e_shpvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;

                int count = e_shpvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_.Count;

                return count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public string set_correlation(string first, string second, double corr)
        {
            try
            {
                Excel_standardHifiveParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;

                //if (first == second)
                //    throw new Exception("underlying code is same");

                if (!e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.hasUnderlying(first))
                    throw new Exception("underlying code doesn't exist : " + first);

                if (!e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.hasUnderlying(second))
                    throw new Exception("underlying code doesn't exist : " + second);

                if (corr > 1.0 || corr < -1.0)
                    throw new Exception("corr must be contained in [ -1.0 , 1.0 ] : " + corr);

                e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.
                    setCorrelation(first, second, corr);


                //Excel_correlation_paraViewModel e_corrvm = new Excel_correlation_paraViewModel();

                //e_corrvm.First_ = first;
                //e_corrvm.Second_ = second;
                //e_corrvm.Value_ = corr.ToString();

                //e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_.Add(e_corrvm);

                //Excel_correlation_paraViewModel e_corrvm_converse = new Excel_correlation_paraViewModel();

                //e_corrvm_converse.First_ = second;
                //e_corrvm_converse.Second_ = first;
                //e_corrvm_converse.Value_ = corr.ToString();

                //e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_.Add(e_corrvm_converse);



                return "set corr complete : " + first + " " + second;
            }
            catch (Exception e)
            {
                string errStr = "set fail: " + e.Message;

                return errStr;
            }
        }

        public void load_instrument(string itemCode)
        {
            try
            {
                Excel_instrumentViewModel e_i_hvm = MasterInformationViewModel.loadInstrumentVM(itemCode);

                //this.InstVM_ = new Excel_instrument_hifiveViewModel();
                this.InstVM_ = e_i_hvm as Excel_instrument_hifiveViewModel;

                if (this.InstVM_ == null)
                    throw new Exception("instrument is not hifive type");

                this.InstVM_.loadInterfaceVMFromXml(XMLFileLoader.LoadInstrument(itemCode));
                
                ////
                //Excel_standardHifiveParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardHifiveParaViewModel;
                ////

                //foreach (var item in InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
                //{
                //    Excel_underlyingInfo_paraViewModel e_u_pvm = new Excel_underlyingInfo_paraViewModel();
                        
                //    e_u_pvm.buildParaSetting(item);

                //    e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Add(e_u_pvm);
                //    e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.addDiagonal(e_u_pvm);

                //}

                this.ErrLog_.add("load complete");
            }
            catch (Exception e)
            {
                this.ErrLog_.add("load err : " + e.Message);
            }
        }

        public string get_itemCode()
        {
            return this.InstVM_.Item_code_;
        }

        public string get_itemName()
        {
            return this.InstVM_.MasterInformationViewModel_.Item_name_;
        }

        public string set_itemName(string itemName)
        {
            this.InstVM_.MasterInformationViewModel_.Item_name_ = itemName;

            return "itemName set complete";
        }

        public string build_parameter(DateTime refDate, ParameterBuildType pbt)
        {
            try
            {
                this.InstVM_.buildParameterFromInstrument(refDate);

                return "para build OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }


        }

        public string calculate(DateTime refDate)
        {
            string result = "";

            try
            {
                //this.InstVM_.calculate(InstVM_.Item_code_, refDate);
                this.InstVM_.Excel_parameterViewModel_.ReferenceDate_ = refDate;

                this.InstVM_.calculate();
                
                result = this.InstVM_.Excel_parameterViewModel_.Excel_resultViewModel_.calcValue();

                return result;
            }
            catch (Exception e)
            {
                string errStr = "calculation fail : " + e.Message;

                return errStr;
            }

        }

        public Result get_result()
        {
            try
            {
                Result r = new Result(this.InstVM_.Excel_parameterViewModel_.Excel_resultViewModel_);

                return r;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string set_simulationNum(int simulNum)
        {
            if ( simulNum < 1 )
                return "simulationNum must be positive";

            if (simulNum > 999999)
                return "simulationNum should not exceed 1,000,000";    

            this.InstVM_.Excel_parameterViewModel_.SimulationNum_ = simulNum.ToString();

            return "simulationNum set complete ";
        }

        public string get_simulationNum()
        {
            try
            {
                return this.InstVM_.Excel_parameterViewModel_.SimulationNum_;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // additional option

        public string set_option(int scheduleNum, string optionType)
        {
            try
            {
                Excel_hifiveViewModel e_hifiveVM = this.InstVM_.Excel_interfaceViewModel_ as Excel_hifiveViewModel;

                if (optionType.ToUpper() == "NONE" 
                   || optionType.ToUpper() == "NONEOPTION" )
                {
                    e_hifiveVM.Excel_scheduleListViewModel_.Excel_scheduleViewModel_[scheduleNum].Excel_additionalOptionViewModel_
                        = new Excel_noneOptionViewModel();
                }
                else if (optionType.ToUpper() == "CALLABLE" 
                        || optionType.ToUpper() == "CALL" 
                        || optionType.ToUpper() == "CALLABLEOPTION"
                        || optionType.ToUpper() == "CALLOPTION")
                {
                    e_hifiveVM.Excel_scheduleListViewModel_.Excel_scheduleViewModel_[scheduleNum].Excel_additionalOptionViewModel_
                        = new Excel_callableOptionViewModel();
                }
                else if (optionType.ToUpper() == "PUTTABLE" 
                        || optionType.ToUpper() == "PUT"
                        || optionType.ToUpper() == "PUTTABLEOPTION"
                        || optionType.ToUpper() == "PUTOPTION")
                {
                    e_hifiveVM.Excel_scheduleListViewModel_.Excel_scheduleViewModel_[scheduleNum].Excel_additionalOptionViewModel_
                        = new Excel_puttableOptionViewModel();

                }
                else
                {
                    throw new Exception();
                }

                return "set option complete : " + optionType;
            }
            catch (Exception)
            {
                return "set fail , " + optionType + " , type : [ none , callable , puttable ] , default setting is none";
            }
        }

        public string get_optionInfo(int scheduleNum, InfoType infoType)
        {
            try
            {

                Excel_hifiveViewModel e_hifiveVM = this.InstVM_.Excel_interfaceViewModel_ as Excel_hifiveViewModel;

                string vba_desc = e_hifiveVM.Excel_scheduleListViewModel_.Excel_scheduleViewModel_[scheduleNum]
                                        .Excel_additionalOptionViewModel_.vba_desciption(scheduleNum);

                return this.infoParsing(vba_desc, infoType);

            }
            catch (Exception e)
            {
                return "not implemented : " + e.Message;
            }
        }
        
    }

}
