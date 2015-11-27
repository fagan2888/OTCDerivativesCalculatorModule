using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Excel_Interface;

namespace Ahn_OTCBookCOMLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Instrument_swap
    {
        [ComVisible(false)]
        public Excel_instrument_structuredSwapViewModel InstVM_ { get; set; }
        private Excel_structuredSwapViewModel swapInterfaceVM_;

        public Instrument_swap()
        {
            this.InstVM_ = new Excel_instrument_structuredSwapViewModel(true);
            this.swapInterfaceVM_ = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredSwapViewModel;

            this.swapInterfaceVM_.Excel_swapLegViewModel_.Add(new Excel_structuredSwapLegViewModel());
            this.swapInterfaceVM_.Excel_swapLegViewModel_.Add(new Excel_hifiveSwapLegViewModel());

            this.ErrLog_ = new ErrLog();
        }

        private ErrLog ErrLog_;

        public string set_issueInfo(double notional,
                                        DateTime effDate,
                                        DateTime matDate,
                                        string currency,
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

                //Excel_swapInfoViewModel e_swapInfo = new Excel_swapInfoViewModel();
                Excel_noteInfoViewModel e_noteInfo = new Excel_noteInfoViewModel();

                e_noteInfo.Notional_ = notional.ToString();
                e_noteInfo.EffectiveDate_ = effDate;
                e_noteInfo.MaturityDate_ = matDate;
                e_noteInfo.Currency_ = new CurrencyViewModel(currency, currency);

                this.InstVM_.Excel_interfaceViewModel_.Excel_issueInfoViewModel_ = e_noteInfo;

                List<string> member = new List<string>() { "instType", "type", "notional", "effDate", "matDate", "currency" };
                List<string> value = new List<string>() { "structuredSwap", "issueInfo", notional.ToString(), StringConverter.xmlDateTimeToDateString(effDate), StringConverter.xmlDateTimeToDateString(matDate), currency.ToString() };

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

                // ir part A
                foreach (var item in this.swapInterfaceVM_.Excel_swapLegViewModel_[0].getExcel_underlyingCalcInfoViewModel().Excel_underlyingInfoViewModel_)
                {
                    if (item2.Trim().ToUpper() == item.KrCode_.ToUpper())
                    {
                        existFlag = true;
                    }
                }

                // hifive part B
                foreach (var item in this.swapInterfaceVM_.Excel_swapLegViewModel_[1].getExcel_underlyingCalcInfoViewModel().Excel_underlyingInfoViewModel_)
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

                    Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                    Excel_underlyingInfo_paraViewModel e_ui_pvm = new Excel_underlyingInfo_paraViewModel();

                    e_ui_pvm.buildParaSetting(e_uivm);

                    e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Add(e_ui_pvm);

                    e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.addDiagonal(e_ui_pvm);
                }

            }

            return;

        }

        public string underlyingInfo()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                
                sb.AppendLine("structuredBond Part" + this.swapInterfaceVM_.Excel_swapLegViewModel_[0].getExcel_underlyingCalcInfoViewModel().getUnderlyingString());
                sb.AppendLine("hifive         Part" + this.swapInterfaceVM_.Excel_swapLegViewModel_[1].getExcel_underlyingCalcInfoViewModel().getUnderlyingString());
                
                return sb.ToString();

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
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                bool setFlag = false;

                foreach (var item in e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_)
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
                    throw new Exception( underCode + " doesn't exist");
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
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                // under 에서 tenor를 가져옴
                string tenor = "3M"; // defaultrrrr
                
                bool setFlag = false;

                Excel_hullWhiteOneFactorViewModel e_hwvm = new Excel_hullWhiteOneFactorViewModel();

                foreach (var item in e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_)
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

        public string set_forwardModel(string underCode, double currentValue, string tenor, YieldTermStructure fittingCurve)
        {
            try
            {
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                // under 에서 tenor를 가져옴
                //string tenor = "3M"; // defaultrrrr
                if (e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Count == 0)
                    throw new Exception("underlying parameter is empty");

                bool findFlag = false;

                foreach (var item in e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_)
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

                if (!findFlag)
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

        // Leg ------------------------------------------------------------------------------------

        public string set_structuredBondLeg(SwapSide swapSide, Instrument_structuredBond inst_structuredBond)
        {
            try
            {
                Excel_structuredSwapLegViewModel e_structuredSwapLegVM = new Excel_structuredSwapLegViewModel();
                e_structuredSwapLegVM.Excel_interfaceViewModel_ = inst_structuredBond.InstVM_.Excel_interfaceViewModel_;// as Excel_structuredBondViewModel;

                this.swapInterfaceVM_.Excel_swapLegViewModel_[0] = e_structuredSwapLegVM;

                // para under add part
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                foreach (var item in inst_structuredBond.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
	            {
                    this.addUnderlying(item.KrCode_);
	            }

                return "OK";
            }
            catch (Exception e)
            {

                return "set fail : " + e.Message;
            }
        }

        public Instrument_structuredBond get_structuredBondLeg(SwapSide swapSide)
        {
            Excel_structuredSwapLegViewModel structuredSwapLegViewModel = this.swapInterfaceVM_.Excel_swapLegViewModel_[0] as Excel_structuredSwapLegViewModel;

            try
            {
                if (structuredSwapLegViewModel != null)
                {
                    Instrument_structuredBond inst_structuredBond = new Instrument_structuredBond();

                    inst_structuredBond.InstVM_.Excel_interfaceViewModel_ = structuredSwapLegViewModel.Excel_interfaceViewModel_;

                    return inst_structuredBond;

                }
                else
                {
                    throw new Exception("type is not valid");
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public string set_hifiveLeg(SwapSide swapSide, Instrument_hifive inst_hifive)
        {
            try
            {
                Excel_hifiveSwapLegViewModel e_hifiveSwapLegVM = new Excel_hifiveSwapLegViewModel();
                e_hifiveSwapLegVM.Excel_hifiveViewModel_ = inst_hifive.InstVM_.Excel_interfaceViewModel_ as Excel_hifiveViewModel;

                this.swapInterfaceVM_.Excel_swapLegViewModel_[1] = e_hifiveSwapLegVM;

                // para under add part
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                foreach (var item in inst_hifive.InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
                {
                    this.addUnderlying(item.KrCode_);
                }

                return "OK";
            }
            catch (Exception e)
            {

                return "set fail : " + e.Message;
            }

        }

        public Instrument_hifive get_hifiveLeg(SwapSide swapSide)
        {
            Excel_hifiveSwapLegViewModel e_hifiveSwapLegVM = this.swapInterfaceVM_.Excel_swapLegViewModel_[1] as Excel_hifiveSwapLegViewModel;

            try
            {
                if (e_hifiveSwapLegVM != null)
                {
                    Instrument_hifive inst_hifive = new Instrument_hifive();

                    inst_hifive.InstVM_.Excel_interfaceViewModel_ = e_hifiveSwapLegVM.Excel_hifiveViewModel_;

                    return inst_hifive;

                }
                else
                {
                    throw new Exception("type is not valid");
                }
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public string set_discountCurve(string currency, YieldTermStructure discountCurve)
        {
            try
            {
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                int count = e_sspvm.Excel_discountCurve_paraViewModel_.hasCurrencysYieldCurve(currency);

                discountCurve.Excel_yieldCurveViewModel_.Currency_ = currency;

                if (count == -1)
                {
                    e_sspvm.Excel_discountCurve_paraViewModel_.Excel_yieldCurveViewModel_
                        .Add(discountCurve.Excel_yieldCurveViewModel_);
                }
                else 
                {
                    e_sspvm.Excel_discountCurve_paraViewModel_.Excel_yieldCurveViewModel_[count]
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
                int count = this.swapInterfaceVM_.getExcel_underlyingCalcInfoViewModel().Excel_underlyingInfoViewModel_.Count;

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
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                int count = e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Count;

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
                string vba_desc = this.swapInterfaceVM_.getExcel_underlyingCalcInfoViewModel().Excel_underlyingInfoViewModel_[underCount].vba_desciption();

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
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                string vba_desc = e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_[underCount].vba_desciption();

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
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                string vba_desc = e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_[corrCount].vba_desciption();

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
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                int count = e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_.Count;

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
                Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;

                //if (first == second)
                //    throw new Exception("underlying code is same");

                if (!e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.hasUnderlying(first))
                    throw new Exception("underlying code doesn't exist : " + first);

                if (!e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.hasUnderlying(second))
                    throw new Exception("underlying code doesn't exist : " + second);

                if (corr > 1.0 || corr < -1.0)
                    throw new Exception("corr must be contained in [ -1.0 , 1.0 ] : " + corr);

                e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.
                    setCorrelation(first, second, corr);

                //Excel_correlation_paraViewModel e_corrvm = new Excel_correlation_paraViewModel();

                //e_corrvm.First_ = first;
                //e_corrvm.Second_ = second;
                //e_corrvm.Value_ = corr.ToString();

                //e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_.Add(e_corrvm);

                //Excel_correlation_paraViewModel e_corrvm_converse = new Excel_correlation_paraViewModel();

                //e_corrvm_converse.First_ = second;
                //e_corrvm_converse.Second_ = first;
                //e_corrvm_converse.Value_ = corr.ToString();

                //e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.Excel_correlation_paraViewModel_.Add(e_corrvm_converse);

                return "set corr complete : " + first + " , " + second + " : " + corr;
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
                this.InstVM_ = e_i_hvm as Excel_instrument_structuredSwapViewModel;

                if (this.InstVM_ == null)
                    throw new Exception("instrument is not structuredSwap type");

                this.InstVM_.loadInterfaceVMFromXml(XMLFileLoader.LoadInstrument(itemCode));

                this.swapInterfaceVM_ = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredSwapViewModel;

                // parameter load는 나중에 하자으.

                ////
                //Excel_standardSwapParaViewModel e_sspvm = this.InstVM_.Excel_parameterViewModel_ as Excel_standardSwapParaViewModel;
                ////

                //foreach (var item in InstVM_.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_)
                //{
                //    Excel_underlyingInfo_paraViewModel e_u_pvm = new Excel_underlyingInfo_paraViewModel();

                //    e_u_pvm.buildParaSetting(item);

                //    e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Add(e_u_pvm);
                //    e_sspvm.Excel_underlyingCalcInfo_paraViewModel_.Excel_correlationInfo_paraViewModel_.addDiagonal(e_u_pvm);

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

        public string build_parameter(DateTime refDate,ParameterBuildType pbt)
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



    }
}
