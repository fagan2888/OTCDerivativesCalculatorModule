using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;

namespace ExcelAddInRibbonTest
{
    public class OptionViewModel_1928 : INotifyPropertyChanged
    {
        #region Event

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        public static OptionViewModel_1928 Sum(ObservableCollection<OptionViewModel_1928> ovmList)
        {
            OptionViewModel_1928 resultOvm_1928 = new OptionViewModel_1928();

            resultOvm_1928.name_ = "총계";

            foreach (var item in ovmList)
            {
                resultOvm_1928.unit_ += item.unit_;
                resultOvm_1928.evalAmt_ += item.evalAmt_;
                resultOvm_1928.deltaCal_ += item.deltaCal_;
                resultOvm_1928.gammaCal_ += item.gammaCal_;
                resultOvm_1928.vegaCal_ += item.vegaCal_;
                resultOvm_1928.deltaPosition_ += item.deltaPosition_;
                resultOvm_1928.totalRisk_ += item.totalRisk_;
                resultOvm_1928.deltaRisk_ += item.deltaRisk_;
                resultOvm_1928.gammaRisk_ += item.gammaRisk_;
                resultOvm_1928.vegaRisk_ += item.vegaRisk_;
                
            }

            return resultOvm_1928;
        }

        public OptionViewModel_1928()
        { 
        
        }

        #region CallPutEnum_
        private QLNet.Option.Type callPutEnum_;
        public QLNet.Option.Type CallPutEnum_
        {
            get { return this.callPutEnum_; }
            set
            {
                if (this.callPutEnum_ != value)
                {
                    this.callPutEnum_ = value;
                }
            }
        }
        #endregion

        #region Name_
        private string name_;
        public string Name_
        {
            get { return this.name_; }
            set
            {
                if (this.name_ != value)
                {
                    this.name_ = value;
                    this.NotifyPropertyChanged("Name_");
                }
            }
        }
        #endregion

        #region SellBuy_
        private string sellBuy_;
        public string SellBuy_
        {
            get { return this.sellBuy_; }
            set
            {
                if (this.sellBuy_ != value)
                {
                    this.sellBuy_ = value;
                    this.NotifyPropertyChanged("SellBuy_");
                }
            }
        }
        #endregion

        #region Unit_
        private int unit_;
        public int Unit_
        {
            get { return this.unit_; }
            set
            {
                if (this.unit_ != value)
                {
                    this.unit_ = value;
                    this.NotifyPropertyChanged("Unit_");
                }
            }
        }
        #endregion

        #region EvalAmt_
        private double evalAmt_;
        public double EvalAmt_
        {
            get { return this.evalAmt_; }
            set
            {
                if (this.evalAmt_ != value)
                {
                    this.evalAmt_ = value;
                    this.NotifyPropertyChanged("EvalAmt_");
                }
            }
        }
        #endregion

        #region GBMParaViewModel_
        private GBMParaViewModel gbmParaViewModel_;
        public GBMParaViewModel GBMParaViewModel_
        {
            get { return this.gbmParaViewModel_; }
            set
            {
                if (this.gbmParaViewModel_ != value)
                {
                    this.gbmParaViewModel_ = value;
                    this.NotifyPropertyChanged("GBMParaViewModel_");
                }
            }
        }
        #endregion

        #region Strike_
        private double strike_;
        public double Strike_
        {
            get { return this.strike_; }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                    this.NotifyPropertyChanged("Strike_");
                }
            }
        }
        #endregion

        #region Maturity_
        private DateTime maturiry_;
        public DateTime Maturity_
        {
            get { return this.maturiry_; }
            set
            {
                if (this.maturiry_ != value)
                {
                    this.maturiry_ = value;
                    this.NotifyPropertyChanged("Maturity_");
                }
            }
        }
        #endregion

        #region CurrPrice_
        private double currPrice_;
        public double CurrPrice_
        {
            get { return this.currPrice_; }
            set
            {
                if (this.currPrice_ != value)
                {
                    this.currPrice_ = value;
                    this.NotifyPropertyChanged("CurrPrice_");
                }
            }
        }
        #endregion

        #region ImVol_
        private double imVol_;
        public double ImVol_
        {
            get { return this.imVol_; }
            set
            {
                if (this.imVol_ != value)
                {
                    this.imVol_ = value;
                    this.NotifyPropertyChanged("ImVol_");
                }
            }
        }
        #endregion

        #region Koscom Greek

        #region Delta_
        private double delta_;
        public double Delta_
        {
            get { return this.delta_; }
            set
            {
                if (this.delta_ != value)
                {
                    this.delta_ = value;
                    this.NotifyPropertyChanged("Delta_");
                }
            }
        }
        #endregion

        #region Gamma_
        private double gamma_;
        public double Gamma_
        {
            get { return this.gamma_; }
            set
            {
                if (this.gamma_ != value)
                {
                    this.gamma_ = value;
                    this.NotifyPropertyChanged("Gamma_");
                }
            }
        }
        #endregion

        #region Vega_
        private double vega_;
        public double Vega_
        {
            get { return this.vega_; }
            set
            {
                if (this.vega_ != value)
                {
                    this.vega_ = value;
                    this.NotifyPropertyChanged("Vega_");
                }
            }
        }
        #endregion

        //#region Theta_
        //private double theta_;
        //public double Theta_
        //{
        //    get { return this.theta_; }
        //    set
        //    {
        //        if (this.theta_ != value)
        //        {
        //            this.theta_ = value;
        //            this.NotifyPropertyChanged("Theta_");
        //        }
        //    }
        //}
        //#endregion

        //#region Rho_
        //private double rho_;
        //public double Rho_
        //{
        //    get { return this.rho_; }
        //    set
        //    {
        //        if (this.rho_ != value)
        //        {
        //            this.rho_ = value;
        //            this.NotifyPropertyChanged("Rho_");
        //        }
        //    }
        //}
        //#endregion

        #endregion

        #region Calc Greek And Position And Risk

        #region DeltaCal_
        private double deltaCal_;
        public double DeltaCal_
        {
            get { return this.deltaCal_; }
            set
            {
                if (this.deltaCal_ != value)
                {
                    this.deltaCal_ = value;
                    this.NotifyPropertyChanged("DeltaCal_");
                }
            }
        }
        #endregion

        #region GammaCal_
        private double gammaCal_;
        public double GammaCal_
        {
            get { return this.gammaCal_; }
            set
            {
                if (this.gammaCal_ != value)
                {
                    this.gammaCal_ = value;
                    this.NotifyPropertyChanged("GammaCal_");
                }
            }
        }
        #endregion

        #region VegaCal_
        private double vegaCal_;
        public double VegaCal_
        {
            get { return this.vegaCal_; }
            set
            {
                if (this.vegaCal_ != value)
                {
                    this.vegaCal_ = value;
                    this.NotifyPropertyChanged("VegaCal_");
                }
            }
        }
        #endregion

        #region ThetaCal_
        private double thetaCal_;
        public double ThetaCal_
        {
            get { return this.thetaCal_; }
            set
            {
                if (this.thetaCal_ != value)
                {
                    this.thetaCal_ = value;
                    this.NotifyPropertyChanged("ThetaCal_");
                }
            }
        }
        #endregion

        #region RhoCal_
        private double rhoCal_;
        public double RhoCal_
        {
            get { return this.rhoCal_; }
            set
            {
                if (this.rhoCal_ != value)
                {
                    this.rhoCal_ = value;
                    this.NotifyPropertyChanged("RhoCal_");
                }
            }
        }
        #endregion

        #region DeltaPosition_
        private double deltaPosition_;
        public double DeltaPosition_
        {
            get { return this.deltaPosition_; }
            set
            {
                if (this.deltaPosition_ != value)
                {
                    this.deltaPosition_ = value;
                    this.NotifyPropertyChanged("DeltaPosition_");
                }
            }
        }
        #endregion

        #region TotalRisk_
        private double totalRisk_;
        public double TotalRisk_
        {
            get { return this.totalRisk_; }
            set
            {
                if (this.totalRisk_ != value)
                {
                    this.totalRisk_ = value;
                    this.NotifyPropertyChanged("TotalRisk_");
                }
            }
        }
        #endregion

        #region DeltaRisk_
        private double deltaRisk_;
        public double DeltaRisk_
        {
            get { return this.deltaRisk_; }
            set
            {
                if (this.deltaRisk_ != value)
                {
                    this.deltaRisk_ = value;
                    this.NotifyPropertyChanged("DeltaRisk_");
                }
            }
        }
        #endregion

        #region GammaRisk_
        private double gammaRisk_;
        public double GammaRisk_
        {
            get { return this.gammaRisk_; }
            set
            {
                if (this.gammaRisk_ != value)
                {
                    this.gammaRisk_ = value;
                    this.NotifyPropertyChanged("GammaRisk_");
                }
            }
        }
        #endregion

        #region VegaRisk_
        private double vegaRisk_;
        public double VegaRisk_
        {
            get { return this.vegaRisk_; }
            set
            {
                if (this.vegaRisk_ != value)
                {
                    this.vegaRisk_ = value;
                    this.NotifyPropertyChanged("VegaRisk_");
                }
            }
        }
        #endregion

        #region DeepOTM_
        private double deepOTM_;
        public double DeepOTM_
        {
            get { return this.deepOTM_; }
            set
            {
                if (this.deepOTM_ != value)
                {
                    this.deepOTM_ = value;
                    this.NotifyPropertyChanged("DeepOTM_");
                }
            }
        }
        #endregion

        #endregion

        #region NPV_
        private double npv_;
        public double NPV_
        {
            get { return this.npv_; }
            set
            {
                if (this.npv_ != value)
                {
                    this.npv_ = value;
                    this.NotifyPropertyChanged("NPV_");
                }
            }
        }
        #endregion

        #region RemainDays_
        private int remainDays_;
        public int RemainDays_
        {
            get { return this.remainDays_; }
            set
            {
                if (this.remainDays_ != value)
                {
                    this.remainDays_ = value;
                    this.NotifyPropertyChanged("RemainDays_");
                }
            }
        }
        #endregion

        public void build(OPTION_POSITION_1928_Table_DAO dao)
        {
            this.nameParsing(dao.POSITIONNAME_);

            this.sellBuy_ = dao.SELLBUY_;
            this.unit_ = Convert.ToInt32(dao.UNIT_);
            this.evalAmt_ = Convert.ToDouble(dao.EVALAMT_);
            this.currPrice_ = this.evalAmt_ / (this.unit_ * 500000);

            //this.delta_ = Convert.ToDouble(dao.DELTA_);
            //this.gamma_ = Convert.ToDouble(dao.GAMMA_);
            //this.vega_ = Convert.ToDouble(dao.VEGA_);
            double v = Convert.ToDouble(dao.IMVOL_);

            this.imVol_ = v;

        }

        private void nameParsing(string koscomPositionName)
        {
            string trim = koscomPositionName.Trim();

            string optionType = trim.Substring(0, 1);
            string strikeValue = "";

            if (optionType.ToUpper() == "C")
            {
                this.callPutEnum_ = QLNet.Option.Type.Call;

                strikeValue = trim.Substring(7, 5);
                this.strike_ = Convert.ToDouble(strikeValue);

                this.name_ = optionType + " " + strikeValue;

            }
            else if (optionType.ToUpper() == "P")
            {
                this.callPutEnum_ = QLNet.Option.Type.Put;

                strikeValue = trim.Substring(7, 5);
                this.strike_ = Convert.ToDouble(strikeValue);

                this.name_ = optionType + " " + strikeValue;

            }
            else if (optionType.ToUpper() == "F")
            {
                this.strike_ = 0.0;
            }

            //-------------------------

            string yearStr = trim.Substring(2, 2);
            string monthStr = trim.Substring(4, 2);

            int year = Convert.ToInt32(yearStr) + 2000;
            int month = Convert.ToInt32(monthStr);

            this.name_ = optionType + " " + yearStr + monthStr + " " + strikeValue;

            this.secondThursday(year, month);

        }

        private void secondThursday(int year, int month)
        {
            DateTime initialDate = new DateTime(year, month, 1);
            int dayOfWeek = (int)initialDate.DayOfWeek;

            if (dayOfWeek < 4)
            {
                int addDays = (4 - dayOfWeek) + 7;

                this.maturiry_ = initialDate.AddDays(addDays);
            }
            else 
            {
                int addDays = (4 - dayOfWeek) + 14;

                this.maturiry_ = initialDate.AddDays(addDays);            
            }

            DateTime d = new DateTime(2014,10,9);

            if (this.maturiry_ == d)
            {
                this.maturiry_ = this.maturiry_.AddDays(-1);
            }
            

        }

        public void calculate(double[] p, GBMParaViewModel para)
        {

            this.xData_ = p;
            this.yData_ = new double[p.Length];

            double sellBuySign = 1.0;

            if (this.sellBuy_ == "매도")
            {
                sellBuySign = -1.0;
            }
            else
            { 
            }

            // set up dates
            Calendar calendar = new TARGET();
            //Date todaysDate = new Date(DateTime.Now);
            Date settlementDate = new Date(para.ReferenceDate_);
            Settings.setEvaluationDate(settlementDate);

            // our options
            Option.Type type = this.callPutEnum_;

            double underlying = para.CurrentPrice_;
            double strike = this.strike_;
            double dividendYield = para.Dividend_ / 100;
            double riskFreeRate = para.Drift_ / 100;

            if (this.callPutEnum_ == Option.Type.Call)
            {
                this.imVol_ = para.Call_Interpolation_.value(this.strike_);
            }
            else if (this.callPutEnum_ == Option.Type.Put)
            {
                this.imVol_ = para.Put_Interpolation_.value(this.strike_);
            }

            double volatility = (this.imVol_ ) / 100;

            Date maturity = new Date(this.maturiry_.AddDays(1));
            

            if (this.callPutEnum_ == 0)
            {
                this.deltaCal_ = 1.0;
                this.gammaCal_ = 0.0;
                this.vegaCal_ = 0.0;
                this.thetaCal_ = 0.0;
                this.rhoCal_ = 0.0;

                this.deltaPosition_ = sellBuySign * this.unit_ * 500000 * underlying;

                this.deltaRisk_ = this.deltaPosition_ * 0.09;
                this.gammaRisk_ = 0.0;
                this.vegaRisk_ = 0.0;

                this.totalRisk_ = this.deltaRisk_ + this.gammaRisk_ + this.vegaRisk_;
                this.deepOTM_ = 0.0;

                //this.remainDays_ = maturity - settlementDate;
                this.remainDays_ = (this.maturiry_ - para.ReferenceDate_).Days + 1;

                return;
            }

            DayCounter dayCounter = new Actual365Fixed();

            Exercise europeanExercise = new EuropeanExercise(maturity);

            SimpleQuote quote = new SimpleQuote(underlying);

            Handle<Quote> underlyingH = new Handle<Quote>(quote);

            // bootstrap the yield/dividend/vol curves
            var flatTermStructure = new Handle<YieldTermStructure>(new FlatForward(settlementDate, riskFreeRate, dayCounter));
            var flatDividendTS = new Handle<YieldTermStructure>(new FlatForward(settlementDate, dividendYield, dayCounter));
            var flatVolTS = new Handle<BlackVolTermStructure>(new BlackConstantVol(settlementDate, calendar, volatility, dayCounter));
            StrikedTypePayoff payoff = new PlainVanillaPayoff(type, strike);
            var bsmProcess = new BlackScholesMertonProcess(underlyingH, flatDividendTS, flatTermStructure, flatVolTS);

            // options
            VanillaOption europeanOption = new VanillaOption(payoff, europeanExercise);

            // Analytic formulas:
            // Black-Scholes for European
            europeanOption.setPricingEngine(new AnalyticEuropeanEngine(bsmProcess));

            this.npv_ = Math.Round(europeanOption.NPV(), 6);
            this.deltaCal_ = sellBuySign * Math.Round(europeanOption.delta(), 6);
            this.gammaCal_ = sellBuySign * Math.Round(europeanOption.gamma(), 6);
            this.vegaCal_ = sellBuySign * Math.Round(europeanOption.vega() / 100, 6);
            this.thetaCal_ = sellBuySign * Math.Round(europeanOption.theta() / 365, 6);
            this.rhoCal_ = sellBuySign * Math.Round(europeanOption.rho() / 100, 6);

            this.deltaPosition_ = Math.Round(this.deltaCal_ * this.unit_ * 500000 * underlying,0);
            this.deltaRisk_ = Math.Round(this.deltaPosition_ * 0.09,0);
            this.gammaRisk_ = Math.Round(0.5 * this.gammaCal_ * (underlying * underlying * 0.08 * 0.08) * this.unit_ * 500000, 0);
            this.vegaRisk_ = Math.Round(this.vegaCal_ * this.imVol_ * 0.25 * this.unit_ * 500000, 0);
            
            this.totalRisk_ = this.deltaRisk_ + this.gammaRisk_ + this.vegaRisk_;

            this.deepOTM_ = 0.0;
            //this.remainDays_ = maturity - settlementDate;
            this.remainDays_ = (this.maturiry_ - para.ReferenceDate_).Days + 1;


            for (int i = 0; i < this.xData_.Length; i++)
			{
                quote.setValue(this.xData_[i]);
                this.yData_[i] = 500000.0 * (double)this.unit_ * europeanOption.NPV();
			}
        }

        public double[] xData_ { get; set; }
        public double[] yData_ { get; set; }

        public System.Windows.Media.Brush Brush_ { get; set; }

        public void convertAbs()
        {
            this.totalRisk_ = Math.Abs(this.totalRisk_);
            this.deltaRisk_ = Math.Abs(this.deltaRisk_);
            this.gammaRisk_ = Math.Abs(this.gammaRisk_);
            this.vegaRisk_ = Math.Abs(this.vegaRisk_);
        }
    }
}
