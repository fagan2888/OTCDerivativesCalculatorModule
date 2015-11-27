using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using QLNet;

namespace ExcelAddInRibbonTest
{
    public class OptionViewModel : INotifyPropertyChanged
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

        public OptionViewModel()
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

        #region ImVolCal_
        private double imVolCal_;
        public double ImVolCal_
        {
            get { return this.imVolCal_; }
            set
            {
                if (this.imVolCal_ != value)
                {
                    this.imVolCal_ = value;
                    this.NotifyPropertyChanged("ImVolCal_");
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

        #region Theta_
        private double theta_;
        public double Theta_
        {
            get { return this.theta_; }
            set
            {
                if (this.theta_ != value)
                {
                    this.theta_ = value;
                    this.NotifyPropertyChanged("Theta_");
                }
            }
        }
        #endregion

        #region Rho_
        private double rho_;
        public double Rho_
        {
            get { return this.rho_; }
            set
            {
                if (this.rho_ != value)
                {
                    this.rho_ = value;
                    this.NotifyPropertyChanged("Rho_");
                }
            }
        }
        #endregion

        #endregion

        #region Calc Greek

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

        public void build(OPTION_POSITION_Table_DAO dao)
        {
            this.nameParsing(dao.POSITIONNAME_);

            this.currPrice_ = Convert.ToDouble(dao.CURRPRICE_);

            this.delta_ = Convert.ToDouble(dao.GREEK_DELTA_);
            this.gamma_ = Convert.ToDouble(dao.GREEK_GAMMA_);
            this.vega_ = Convert.ToDouble(dao.GREEK_VEGA_);
            this.theta_ = Convert.ToDouble(dao.GREEK_THETA_);
            this.rho_ = Convert.ToDouble(dao.GREEK_RHO_);

            this.imVol_ = Convert.ToDouble(dao.IMVOL_);

        }

        private void nameParsing(string koscomPositionName)
        {
            string trim = koscomPositionName.Trim();
            
            string optionType = trim.Substring(13, 1);

            if (optionType.ToUpper() == "C") 
            {
                this.callPutEnum_ = QLNet.Option.Type.Call;
            }
            else if (optionType.ToUpper() == "P")
            {
                this.callPutEnum_ = QLNet.Option.Type.Put;
            }
            else
            {
                throw new Exception("type doesn't valid , input : " + optionType);
            }
            
            string strikeValue = trim.Substring(14, 5);
            this.strike_ = Convert.ToDouble(strikeValue);

            this.name_ = optionType + " " + strikeValue;

            //-------------------------

            string yearStr = trim.Substring(8, 2);
            string monthStr = trim.Substring(10, 2);

            int year = Convert.ToInt32(yearStr) + 2000;
            int month = Convert.ToInt32(monthStr);

            this.secondThursday(year,month);

        }

        private void secondThursday(int year,int month)
        {
            DateTime initialDate = new DateTime(year, month, 1);

            int addDays = (4 - (int)initialDate.DayOfWeek) + 14;

            this.maturiry_ = initialDate.AddDays(addDays);

            
        }

        public void calculate(GBMParaViewModel para)
        {
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
            double volatility = 0.0;

            if (this.callPutEnum_ == Option.Type.Call)
            {
                try
                {
                    volatility = para.Call_Interpolation_.value(this.strike_) / 100;
                    this.imVolCal_ = Math.Round(para.Call_Interpolation_.value(this.strike_), 1);
                }
                catch (Exception)
                {
                    volatility = para.Call_Interpolation_.value(this.strike_, true) / 100;
                    this.imVolCal_ = Math.Round(para.Call_Interpolation_.value(this.strike_,true), 1);
                }
                
            }
            else if (this.callPutEnum_ == Option.Type.Put)
            {
                try
                {
                    volatility = para.Call_Interpolation_.value(this.strike_) / 100;
                    this.imVolCal_ = Math.Round(para.Put_Interpolation_.value(this.strike_), 1);
                }
                catch (Exception)
                {
                    volatility = para.Call_Interpolation_.value(this.strike_, true) / 100;
                    this.imVolCal_ = Math.Round(para.Put_Interpolation_.value(this.strike_,true), 1);
                }
                
            }

            

            Date maturity = new Date(this.maturiry_);

            DayCounter dayCounter = new Actual365Fixed();

            //// write column headings
            //int[] widths = new int[] { 35, 14, 14, 14 };
            //Console.Write("{0,-" + widths[0] + "}", "Method");
            //Console.Write("{0,-" + widths[1] + "}", "European");
            //Console.Write("{0,-" + widths[2] + "}", "Bermudan");
            //Console.WriteLine("{0,-" + widths[3] + "}", "American");

            //List<Date> exerciseDates = new List<Date>(); ;
            //for (int i = 1; i <= 4; i++)
            //    exerciseDates.Add(settlementDate + new Period(3 * i, TimeUnit.Months));

            Exercise europeanExercise = new EuropeanExercise(maturity);
            //Exercise bermudanExercise = new BermudanExercise(exerciseDates);
            //Exercise americanExercise = new AmericanExercise(settlementDate, maturity);

            Handle<Quote> underlyingH = new Handle<Quote>(new SimpleQuote(underlying));

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
            
            this.npv_ = Math.Round(europeanOption.NPV(),6);
            this.deltaCal_ = Math.Round(europeanOption.delta(),6);
            this.gammaCal_= Math.Round(europeanOption.gamma(),6);
            this.vegaCal_ = Math.Round(europeanOption.vega()/ 100, 6);
            this.thetaCal_= Math.Round(europeanOption.theta()/ 365,6) ;
            this.rhoCal_ = Math.Round(europeanOption.rho() / 100, 6);

        }
        
    }
}
