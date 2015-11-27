using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Excel_Interface;

namespace Ahn_OTCBookCOMLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Instrument_structuredBond
    {
        [ComVisible(false)]
        public Excel_instrument_structuredBondViewModel InstVM_ { get; set; }

        public Instrument_structuredBond()
        {
            this.InstVM_ = new Excel_instrument_structuredBondViewModel(true);
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

                List<string> member = new List<string>() { "instType", "type", "notional", "effDate", "matDate", "currency" };
                List<string> value = new List<string>() { "hifive", "issueInfo", notional.ToString(), StringConverter.xmlDateTimeToDateString(effDate), StringConverter.xmlDateTimeToDateString(matDate), currency.ToString() };

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

                    Excel_standardParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

                    Excel_underlyingInfo_paraViewModel e_ui_pvm = new Excel_underlyingInfo_paraViewModel();

                    e_ui_pvm.buildParaSetting(e_uivm);

                    e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Add(e_ui_pvm);

                    e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.addDiagonal(e_ui_pvm);
                }

            }

            return;

        }

        public string add_underlying(string underCode, double basePrice)
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

            Excel_standardParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

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
                Excel_standardParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

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
                Excel_standardParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

                // under 에서 tenor를 가져옴
                string tenor = "3M"; // defaultrrrr

                Excel_rateInfoViewModel e_rateInfoVM = new Excel_rateInfoViewModel();

                foreach (var item in this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
                {
                    if (underCode == item.KrCode_)
                    {
                        Excel_interestRateViewModel e_irvm = item as Excel_interestRateViewModel;

                        e_rateInfoVM.Tenor_ = e_irvm.Tenor_;
                        e_rateInfoVM.LegTenor_ = e_irvm.LegTenor_;
                        e_rateInfoVM.IndexType_ = e_irvm.RateType_;
                        e_rateInfoVM.Currency_ = e_irvm.Currency_;
                        
                    }
                }

                bool setFlag = false;

                foreach (var item in e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_)
                {
                    if (underCode == item.KrCode_)
                    {
                        Excel_hullWhiteOneFactorViewModel e_hwvm = new Excel_hullWhiteOneFactorViewModel();

                        e_hwvm.CurrentValue_ = currentValue.ToString();

                        e_hwvm.Excel_rateInfoViewModel_ = e_rateInfoVM;

                        e_hwvm.Alpha_ = alpha.ToString();
                        e_hwvm.Volatility_ = sigma.ToString();

                        e_hwvm.Excel_yieldCurveViewModel_ = fittingCurve.Excel_yieldCurveViewModel_;

                        item.Excel_underlyingModel_paraViewModel_ = e_hwvm;

                        setFlag = true;

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

        public string set_forwardModel(string underCode, double currentValue, string tenor,YieldTermStructure fittingCurve)
        {
            try
            {
                Excel_standardParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

                // under 에서 tenor를 가져옴
                //string tenor = "3M"; // defaultrrrr
                if (e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Count == 0)
                    throw new Exception("underlying parameter is empty");

                bool findFlag = false;

                foreach (var item in e_sphvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_)
                //foreach (var item in InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
                {

                    if (underCode.ToUpper() == item.KrCode_.ToUpper())
                    {
                        Excel_forwardModelViewModel e_fmvm = new Excel_forwardModelViewModel();

                        e_fmvm.CurrentValue_ = currentValue.ToString();
                        e_fmvm.Tenor_ = tenor;
                        
                        e_fmvm.Excel_yieldCurveViewModel_ = fittingCurve.Excel_yieldCurveViewModel_;

                        item.Excel_underlyingModel_paraViewModel_ = e_fmvm;

                        findFlag = true;

                    }
                }

                if ( !findFlag )
                    throw new Exception(underCode + " does not exist");

                return "load complete";
            }
            catch (Exception e)
            {
                return "load fail : " + e.Message;
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

        // info

        public string get_couponTypeInfo(string couponType, InfoType infoType)
        {

            if (couponType.ToUpper() == "FIXED" ||
                couponType.ToUpper() == "FIXEDCOUPON" ||
                couponType.ToUpper() == "FIXEDCPN_SCH" )
            {
                List<string> member = fixedCpnMember_;
                List<string> value = new List<string>() { "structuredBond", "fixedCpn_sch", "1", "2014-01-02", "2014-04-02", "2014-04-02", "0.035" };

                return this.infoParsing(this.vba_description(member, value), infoType);
            }
            else if (couponType.ToUpper() == "VANILLA" ||
                     couponType.ToUpper() == "VANILLACOUPON" ||
                     couponType.ToUpper() == "VANILLACPN_SCH")
            {
                List<string> member = vanillaFloatingCpnMember_;
                List<string> value = new List<string>() { "structuredBond", "vanillaCpn_sch", "1", "2014-01-02", "2014-04-02", "2014-04-02", "1.0", "0.035", "CD91" };

                return this.infoParsing(this.vba_description(member, value), infoType);
            }
            else
            {
                return "unknownType , " + "availableType List [ FIXED , VANILLA ]" ;
            }
        }


        // coupon
        private List<string> fixedCpnMember_ = new List<string>() { "instType", "type", "schNum", "calcStartDate", "calcEndDate", "payoffDate", "fixedRate" };
        public string addFixedCoupon(DateTime calculationStartDate,
                                     DateTime calculationEndDate,
                                     DateTime payoffDate,
                                     double fixedRate)
        {
            try
            {
                #region CheckParameter

                if (calculationStartDate >= calculationEndDate)
                    throw new Exception("startDate must be earlier than endDate");

                #endregion

                Excel_fixedCouponScheduleViewModel e_fcsvm = new Excel_fixedCouponScheduleViewModel();

                e_fcsvm.EventDate_ = payoffDate;

                e_fcsvm.CalculationStartDate_ = calculationStartDate;
                e_fcsvm.CalculationEndDate_ = calculationEndDate;
                e_fcsvm.PayoffDate_ = payoffDate;
                e_fcsvm.FixedRate_ = fixedRate.ToString();

                Excel_structuredBondViewModel e_sbvm = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

                e_sbvm.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_.Add(e_fcsvm);

                int schNum = e_sbvm.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_.Count - 1;

                //this.instVM_.Excel_interfaceViewModel_ = e_sbvm;

                List<string> member = fixedCpnMember_;
                List<string> value = new List<string>() { "structuredBond", "fixedCpn_sch", schNum.ToString(), 
                                                           StringConverter.xmlDateTimeToDateString(calculationStartDate), 
                                                           StringConverter.xmlDateTimeToDateString(calculationEndDate),
                                                           StringConverter.xmlDateTimeToDateString(payoffDate),
                                                           fixedRate.ToString() };

                e_fcsvm.VBA_description_ = this.vba_description(member, value);

                return "OK";
            }
            catch (Exception)
            {
                return "fixedCpn Add Fail";
            }

        }

        private List<string> vanillaFloatingCpnMember_ = new List<string>() { "instType", "type", "schNum", "calcStartDate", "calcEndDate", "payoffDate", "gearing", "sperad", "underlyingCode" };
        public string addVanillaCoupon(DateTime calculationStartDate,
                                        DateTime calculationEndDate,
                                        DateTime payoffDate,
                                        double gearing,
                                        double spread,
                                        string underlyingCode)
        {
            try
            {
                #region CheckParameter

                if (calculationStartDate >= calculationEndDate)
                    throw new Exception("startDate must be earlier than endDate");

                // check underlying 
                if ( !this.hasUnderlyings(underlyingCode) )
                    throw new Exception(underlyingCode + " does not exist. add underlying first.");


                #endregion

                Excel_vanillaFloatingCouponScheduleViewModel e_vfcsvm = new Excel_vanillaFloatingCouponScheduleViewModel();

                // ---------------- underlying part

                //this.addUnderlying(underlyingCode);

                Excel_underlyingCalcInfoViewModel e_ucivm = this.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_;

                e_vfcsvm.Excel_underlyingCalcInfoViewModel_ = e_ucivm;

                Excel_underlyingCalcIDViewModel e_mucidvm =
                    Excel_underlyingCalcIDViewModel.CreateExcel_underlyingCalcID("CHOICE");

                e_mucidvm.EventDate_ = payoffDate;

                e_mucidvm.setUnderlying(e_ucivm);
                e_mucidvm.selectUnderlyings(underlyingCode);

                e_vfcsvm.Excel_underlyingCalcIDViewModel_ = e_mucidvm;

                // ----------------- coupon part

                e_vfcsvm.EventDate_ = payoffDate;

                e_vfcsvm.CalculationStartDate_ = calculationStartDate;
                e_vfcsvm.CalculationEndDate_ = calculationEndDate;
                e_vfcsvm.PayoffDate_ = payoffDate;

                e_vfcsvm.Gearing_ = gearing.ToString();
                e_vfcsvm.Spread_ = spread.ToString();
                e_vfcsvm.OutGearing_ = "1.0";
                e_vfcsvm.OutSpread_ = "0.0";
                e_vfcsvm.Cap_ = "99.0";
                e_vfcsvm.Floor_ = "-99.0";

                Excel_structuredBondViewModel e_sbvm = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

                e_sbvm.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_.Add(e_vfcsvm);

                int schNum = e_sbvm.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_.Count - 1;

                //this.instVM_.Excel_interfaceViewModel_ = e_sbvm;

                List<string> member = vanillaFloatingCpnMember_;
                List<string> value = new List<string>() { "structuredBond", "vanillaCpn_sch", schNum.ToString(), 
                                                           StringConverter.xmlDateTimeToDateString(calculationStartDate), 
                                                           StringConverter.xmlDateTimeToDateString(calculationEndDate),
                                                           StringConverter.xmlDateTimeToDateString(payoffDate),
                                                           gearing.ToString(),
                                                           spread.ToString(),
                                                           underlyingCode };

                e_vfcsvm.VBA_description_ = this.vba_description(member, value);

                return "OK";
            }
            catch (Exception)
            {
                return "vanillaCpn Add Fail";
                throw;
            }
            
        }

        public string addSingleConditionDualRangAccrualFixedCoupon(DateTime calculationStartDate,
                                                DateTime calculationEndDate,
                                                DateTime payoffDate,
                                                List<double> lowerRngList,
                                                List<string> referenceUnderCodeList,
                                                List<double> upperRngList,
                                                double fixedRate)
        {
            try
            {
                #region CheckParameter

                if (calculationStartDate >= calculationEndDate)
                    throw new Exception("startDate must be earlier than endDate");

                //// check underlying 
                //if ( !this.hasUnderlyings(underlyings))
                //    throw new Exception(underlyings + " does not exist. add underlying first.");


                #endregion

                Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel e_mc_mr_sacsvm
                        = new Excel_multiCondi_multiRng_structuredAccrualCouponScheduleViewModel();

                e_mc_mr_sacsvm.EventDate_ = payoffDate;

                e_mc_mr_sacsvm.CalculationStartDate_ = calculationStartDate;
                e_mc_mr_sacsvm.CalculationEndDate_ = calculationEndDate;
                e_mc_mr_sacsvm.PayoffDate_ = payoffDate;

                int rangeCount = lowerRngList.Count;

                Excel_multi_rangeNDViewModel e_m_rngNDVM = new Excel_multi_rangeNDViewModel();

                for (int i = 0; i < rangeCount; i++)
                {
                    Range1DViewModel accRng1D = new Range1DViewModel();

                    accRng1D.LowerBound_ = lowerRngList[i].ToString();

                    DateTime effDate = this.InstVM_.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;

                    //this.addUnderlying(Excel_loaderViewModel.loadUnderInfo2(effDate, referenceUnderCodeList[i]));
                    this.addUnderlying(referenceUnderCodeList[i]);

                    Excel_choiceUnderlyingCalcIDViewModel choiceUnderCalcIDVM = new Excel_choiceUnderlyingCalcIDViewModel();

                    choiceUnderCalcIDVM.EventDate_ = payoffDate;

                    Excel_selectedUnderlyingViewModel selectedUnder = new Excel_selectedUnderlyingViewModel();
                    selectedUnder.Code_ = referenceUnderCodeList[i];
                    selectedUnder.NameTrans_ = new NameTrans(referenceUnderCodeList[i]);
                    selectedUnder.Checked_ = true;

                    choiceUnderCalcIDVM.Excel_selectedUnderlyingViewModel_.Add(selectedUnder);

                    accRng1D.UpperBound_ = upperRngList[i].ToString();

                    e_m_rngNDVM.Range1DViewModel_.Add(accRng1D);
                    e_m_rngNDVM.Excel_underlyingCalcIDViewModel_.Add(choiceUnderCalcIDVM);
                }

                e_mc_mr_sacsvm.Excel_multi_rangeNDViewModel_.Add(e_m_rngNDVM);

                Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                e_crcvm.ConstReturn_ = fixedRate.ToString();

                e_mc_mr_sacsvm.Excel_returnCalcInfoViewModel_.Add(e_crcvm);

                //e_mc_sacsvm.FixedRate_ = fixedRate.ToString();

                Excel_structuredBondViewModel e_sbvm = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

                e_sbvm.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_.Add(e_mc_mr_sacsvm);

                //this.instVM_.Excel_interfaceViewModel_ = e_sbvm;

                return "OK";
            }
            catch (Exception)
            {
                return "singleConditionDualRangAccrualFixedCoupon Add Fail";
            }
        }

        public string addConditionMultiRangAccrualFixedCoupon(DateTime calculationStartDate,
                                                DateTime calculationEndDate,
                                                DateTime payoffDate,
                                                List<double> lowerRngList,
                                                List<string> referenceUnderCodeList,
                                                List<double> upperRngList,
                                                double fixedRate)
        {
            try
            {
                Excel_multiCondi_structuredAccrualCouponScheduleViewModel e_mc_sacsvm
                = new Excel_multiCondi_structuredAccrualCouponScheduleViewModel();

                e_mc_sacsvm.EventDate_ = payoffDate;

                e_mc_sacsvm.CalculationStartDate_ = calculationStartDate;
                e_mc_sacsvm.CalculationEndDate_ = calculationEndDate;
                e_mc_sacsvm.PaymentDate_ = payoffDate;

                int rangeCount = lowerRngList.Count;

                for (int i = 0; i < rangeCount; i++)
                {
                    Range1DViewModel accRng1D = new Range1DViewModel();

                    accRng1D.LowerBound_ = lowerRngList[i].ToString();

                    DateTime effDate = this.InstVM_.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;
                    //this.addUnderlying(Excel_loaderViewModel.loadUnderInfo2(effDate, referenceUnderCodeList[i]));
                    this.addUnderlying(referenceUnderCodeList[i]);

                    Excel_choiceUnderlyingCalcIDViewModel choiceUnderCalcIDVM = new Excel_choiceUnderlyingCalcIDViewModel();

                    choiceUnderCalcIDVM.EventDate_ = payoffDate;

                    Excel_selectedUnderlyingViewModel selectedUnder = new Excel_selectedUnderlyingViewModel();
                    selectedUnder.Code_ = referenceUnderCodeList[i];
                    selectedUnder.NameTrans_ = new NameTrans(referenceUnderCodeList[i]);
                    selectedUnder.Checked_ = true;

                    choiceUnderCalcIDVM.Excel_selectedUnderlyingViewModel_.Add(selectedUnder);

                    accRng1D.UpperBound_ = upperRngList[i].ToString();

                    e_mc_sacsvm.Range1DViewModel_.Add(accRng1D);
                    e_mc_sacsvm.Excel_underlyingCalcIDViewModel_.Add(choiceUnderCalcIDVM);
                }


                Excel_constReturnCalViewModel e_crcvm = new Excel_constReturnCalViewModel();

                e_crcvm.ConstReturn_ = fixedRate.ToString();

                e_mc_sacsvm.Excel_returnCalcInfoViewModel_.Add(e_crcvm);

                //e_mc_sacsvm.FixedRate_ = fixedRate.ToString();

                Excel_structuredBondViewModel e_sbvm = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

                e_sbvm.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_.Add(e_mc_sacsvm);

                //this.instVM_.Excel_interfaceViewModel_ = e_sbvm;

                return "OK";
            }
            catch (Exception)
            {
                return "conditionMultiRangAccrualFixedCoupon add Fail.";
                throw;
            }


        }






        public string set_discountCurve(string currency, YieldTermStructure discountCurve)
        {
            try
            {
                Excel_standardParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

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

        public string set_correlation(string first, string second, double corr)
        {
            try
            {
                Excel_standardParaViewModel e_sphvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

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

                return "set corr complete : " + first + " " + second;
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

        public string save_instrumentXml(string name)
        {
            try
            {
                XMLFileLoader.SaveInstrument(name, this.InstVM_.Excel_interfaceViewModel_.productXml());

                return "save complete";
            }
            catch (Exception e)
            {
                string errStr = "instXml save fail: " + e.Message;

                return errStr;
            }
        }

        public string save_parameterXml(string name, DateTime refDate)
        {
            try
            {
                InstVM_.Excel_parameterViewModel_.ReferenceDate_ = refDate;

                XMLFileLoader.SaveParameter(name, this.InstVM_.Excel_parameterViewModel_.paraXml(), refDate);

                return "save complete";
            }
            catch (Exception e)
            {
                string errStr = "paraXml save fail: " + e.Message;

                return errStr;
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

        public string get_issueInfo_value(string filter)
        {
            try
            {
                return "not implemented";
            }
            catch (Exception e)
            {
                return "not implemented : " + e.Message;
            }

        }

        public string get_sch_info(int scheduleNum, InfoType infoType)
        {
            try
            {
                Excel_structuredBondViewModel e_structuredBondVM = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

                string vba_desc = e_structuredBondVM.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_[scheduleNum].VBA_description_;

                return this.infoParsing(vba_desc, infoType);

            }
            catch (Exception e)
            {
                string errStr = "get couponSchdule info fail: " + e.Message;

                return errStr;
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
                Excel_standardParaViewModel e_spvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

                string vba_desc = e_spvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_[underCount].vba_desciption();

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
                Excel_standardParaViewModel e_spvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

                string vba_desc = e_spvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_[corrCount].vba_desciption();

                return this.infoParsing(vba_desc, infoType);
            }
            catch (Exception e)
            {
                return "not implemented : " + e.Message;
            }
        }

        public int get_correlationNum()
        {
            try
            {
                Excel_standardParaViewModel e_spvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

                int count = e_spvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_.Count;

                return count;
            }
            catch (Exception)
            {
                return 0;
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
                Excel_standardParaViewModel e_spvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;

                int count = e_spvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Count;

                return count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int get_scheduleNum()
        {
            try
            {
                Excel_structuredBondViewModel e_structuredBondVM = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

                return e_structuredBondVM.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_.Count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public string load_instrument(string itemCode)
        {
            try
            {
                Excel_instrumentViewModel e_i_hvm = MasterInformationViewModel.loadInstrumentVM(itemCode);

                //this.InstVM_ = new Excel_instrument_hifiveViewModel();
                this.InstVM_ = e_i_hvm as Excel_instrument_structuredBondViewModel;

                if (this.InstVM_ == null)
                    throw new Exception("instrument is not structuredBond type");

                this.InstVM_.loadInterfaceVMFromXml(XMLFileLoader.LoadInstrument(itemCode));

                //
                Excel_standardParaViewModel e_spvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardParaViewModel;
                //

                foreach (var item in InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
                {
                    Excel_underlyingInfo_paraViewModel e_u_pvm = new Excel_underlyingInfo_paraViewModel();

                    e_u_pvm.buildParaSetting(item);

                    e_spvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Add(e_u_pvm);
                    e_spvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.addDiagonal(e_u_pvm);

                }

                return "load complete";
            }
            catch (Exception e)
            {
                return "load err : " + e.Message;
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
            if (simulNum < 1)
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
                Excel_structuredBondViewModel e_structuredBondVM = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

                if (optionType.ToUpper() == "NONE")
                {
                    e_structuredBondVM.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_[scheduleNum].Excel_additionalOptionViewModel_
                        = new Excel_noneOptionViewModel();
                }
                else if (optionType.ToUpper() == "CALLABLE" || optionType.ToUpper() == "CALL")
                {
                    e_structuredBondVM.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_[scheduleNum].Excel_additionalOptionViewModel_
                        = new Excel_callableOptionViewModel();
                }
                else if (optionType.ToUpper() == "PUTTABLE" || optionType.ToUpper() == "PUT")
                {
                    e_structuredBondVM.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_[scheduleNum].Excel_additionalOptionViewModel_
                        = new Excel_puttableOptionViewModel();
                }
                else
                {
                    throw new Exception();
                }

                return "set option complete : " + optionType + " , type : [ none , callable , puttable ]";
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

                Excel_structuredBondViewModel e_structuredBondVM = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredBondViewModel;

                string vba_desc = e_structuredBondVM.Excel_couponScheduleListViewModel_.Excel_couponScheduleViewModel_[scheduleNum]
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
