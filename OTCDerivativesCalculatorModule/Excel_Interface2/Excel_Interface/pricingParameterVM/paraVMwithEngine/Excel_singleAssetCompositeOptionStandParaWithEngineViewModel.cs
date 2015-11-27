using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace Excel_Interface
{
    public class Excel_singleAssetCompositeOptionStandParaWithEngineViewModel : Excel_standardParaViewModel 
    {
        public bool Separable_ { get; set; }

        public Excel_singleAssetCompositeOptionStandParaWithEngineViewModel()
        {
            this.Separable_ = false;
        }

        //public override void calculate(Excel_instrumentViewModel excel_inst)
        //{
        //    //#region Setting
		 
        //    //Excel_compositeOptionViewModel compOptionVM = excel_interface as Excel_compositeOptionViewModel;

        //    //if (compOptionVM == null)
        //    //{
        //    //    //error
        //    //}

        //    //Calendar calendar = new TARGET();

        //    //Date todaysDate = todaysDate = ProgramVariable.ReferenceDate_;

        //    //Date settlementDate = todaysDate;
            
        //    //Settings.setEvaluationDate(todaysDate);

        //    //DayCounter dayCounter = new Actual365Fixed();

        //    //if (this.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_.Count == 0)
        //    //{ 
        //    //    //error
        //    //}

        //    //Excel_geometricBMViewModel gbm = this.Excel_underlyingCalcInfo_paraViewModel_.Excel_underlyingInfo_paraViewModel_[0].Excel_underlyingModel_paraViewModel_ as Excel_geometricBMViewModel;

        //    //double currentValue = Convert.ToDouble(gbm.CurrentValue_);

        //    //SimpleQuote quote = new SimpleQuote(currentValue);
        //    //Handle<Quote> underlyingH = new Handle<Quote>(quote);

        //    //double drift = Convert.ToDouble(gbm.Drift_);
        //    //double dividendYield = Convert.ToDouble(gbm.Dividend_);

        //    //double volatility = Convert.ToDouble(gbm.Volatility_);

        //    //SimpleQuote volQuote = new SimpleQuote(volatility);
        //    //Handle<Quote> volH = new Handle<Quote>(volQuote);

        //    //var flatTermStructure = new Handle<YieldTermStructure>(new FlatForward(settlementDate, drift, dayCounter));
        //    //var flatDividendTS = new Handle<YieldTermStructure>(new FlatForward(settlementDate, dividendYield, dayCounter));
        //    //Handle<BlackVolTermStructure> flatVolTS = new Handle<BlackVolTermStructure>(new BlackConstantVol(settlementDate, calendar, volH, dayCounter));

        //    //BlackScholesMertonProcess bsmProcess = new BlackScholesMertonProcess(underlyingH, flatDividendTS, flatTermStructure, flatVolTS);

        //    //double value = 0.0;

        //    //DateTime exDate = compOptionVM.ExerciseDate_;

        //    //List<QLNet.OneAssetOption> optionList = new List<QLNet.OneAssetOption>();

        //    //foreach (Excel_compositeOption_subtypeViewModel item in compOptionVM.Excel_compositeOption_subtypeViewModelList_)
        //    //{
        //    //    optionList.Add(this.option(item, bsmProcess, exDate));
        //    //}
            
        //    ////------------------------------------------------

        //    //foreach (var item in optionList)
        //    //{
        //    //    value = value + item.NPV();
        //    //}

        //    //if (this.Separable_)
        //    //{
        //    //    double matrutiryPayAmt = 0.0;

        //    //    Excel_yieldCurveViewModel e_ycvm
        //    //        = this.Excel_discountCurve_paraViewModel_.discountYieldCurve("KRW");

        //    //    QLNet.YieldTermStructure yts = e_ycvm.yieldCurve();

        //    //    value += matrutiryPayAmt;
        //    //}
            
        //    //#endregion
            
        //    //#region Calculation

        //    //quote.setValue(currentValue*1.01);
        //    //double sup = optionList[0].NPV();

        //    //quote.setValue(currentValue * 0.99);
        //    //double sdown = optionList[0].NPV();

        //    //double delta = (sup - sdown) / (currentValue * 0.02);

        //    //double gamma = (sup * sup - 2 * value + sdown * sdown) / (currentValue * 0.01 * currentValue * 0.01);

        //    //quote.setValue(currentValue);

        //    //volQuote.setValue(volatility - 0.01);
        //    //double voldown = optionList[0].NPV();

        //    //volQuote.setValue(volatility + 0.01);
        //    //double volup = optionList[0].NPV();

        //    //double vega = (volup - voldown) / 2;

        //    //#endregion

        //    //#region Result

        //    //this.Excel_resultViewModel_.Price_ = value.ToString();

        //    //double baseUnderlyingValue = Convert.ToDouble(
        //    //    excel_interface.Excel_underlyingCalcInfoViewModel_.Excel_underlyingInfoViewModel_[0].BasePrice_);

        //    //this.Excel_resultViewModel_.PercentPrice_ = (100 * value / baseUnderlyingValue).ToString();

        //    //double notional = Convert.ToDouble(excel_interface.Excel_issueInfoViewModel_.Notional_);

        //    //this.Excel_resultViewModel_.EvalAmount_ = ( notional * ( value / baseUnderlyingValue) ).ToString();

        //    //#endregion

        //    //double gamma = optionList[0].gamma();
        //    //double vega = optionList[0].vega();
            
        //}

        private QLNet.OneAssetOption option(Excel_compositeOption_subtypeViewModel compositeOptionVM, 
                                        BlackScholesMertonProcess bsmProcess, 
                                        DateTime exDate)
        {

            Date exerciseDate = new Date(exDate);

            if (compositeOptionVM.Excel_Type_.ToUpper() == "EXCEL_VANILLACALLPUT")
            {
                Excel_vanillaCallPutViewModel e_vcpvm = compositeOptionVM as Excel_vanillaCallPutViewModel;

                QLNet.PlainVanillaPayoff payoff = new PlainVanillaPayoff(Option.Type.Call, e_vcpvm.StrikeValue_);

                QLNet.EuropeanExercise ex = new EuropeanExercise(exerciseDate);

                QLNet.VanillaOption vanillaOption = new VanillaOption(payoff, ex);
                
                return vanillaOption;

            }
            else if (compositeOptionVM.Excel_Type_.ToUpper() == "EXCEL_UPINOUTCALL" ||
                     compositeOptionVM.Excel_Type_.ToUpper() == "EXCEL_DOWNINOUTCALL" )
            {
                Excel_upInOutCallViewModel e_uiocvm = compositeOptionVM as Excel_upInOutCallViewModel;

                Barrier.Type type = Barrier.Type.UpOut;

                if (e_uiocvm.InOut_.ToString() == "IN")
                {
                    type = Barrier.Type.UpIn;
                }

                double strikeValue = e_uiocvm.StrikeValue_;
                double barrierValue = e_uiocvm.BarrierValue_;
                double partiRate = Convert.ToDouble(e_uiocvm.PartiRate_)/100.0;
                double rebateValue = Convert.ToDouble(e_uiocvm.RebateCouponValue_);

                QLNet.PlainVanillaPayoff payoff = new PlainVanillaPayoff(Option.Type.Call, strikeValue);

                QLNet.EuropeanExercise ex = new EuropeanExercise(exerciseDate);

                QLNet.BarrierOption barrierOption = new QLNet.BarrierOption(type, barrierValue, partiRate, rebateValue, payoff, ex);

                QLNet.AnalyticBarrierWithPartiRateEngine engine = new AnalyticBarrierWithPartiRateEngine(bsmProcess);

                barrierOption.setPricingEngine(engine);

                return barrierOption;
            }
            else if (compositeOptionVM.Excel_Type_.ToUpper() == "")
            {
                Barrier.Type type = Barrier.Type.DownOut;

                QLNet.PlainVanillaPayoff payoff = new PlainVanillaPayoff(Option.Type.Call, 261.4);

                QLNet.EuropeanExercise ex = new EuropeanExercise(exerciseDate);

                QLNet.BarrierOption barrierOption = new QLNet.BarrierOption(type, 313.68, 0.32, 0.0, payoff, ex);

                QLNet.AnalyticBarrierWithPartiRateEngine engine = new AnalyticBarrierWithPartiRateEngine(bsmProcess);

                barrierOption.setPricingEngine(engine);

                return barrierOption;
            }
            else
            {
                throw new Exception("unknown compositeOptionType");
            }
            

        }
        
    }
}
