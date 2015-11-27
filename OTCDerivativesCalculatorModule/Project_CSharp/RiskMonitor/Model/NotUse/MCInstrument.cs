//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using QLNet;

//namespace RiskMonitor
//{
//    public class MCInstrument : Instrument
//    {
//        public InstrumentInformation instInfo_ {get; set;}
//        public UnderlyingInfo underInfo_ { get; set; }

//        protected MCPricer pricer_;
//        protected MCEngine mcEngine_;

//        protected List<double> DsPlusValue_;
//        protected List<double> DsMinusValue_;
//        protected List<double> DvolPlusValue_;
//        protected List<double> DvolMinusValue_;
//        protected double DtPlusValue_;

//        public List<double> Delta_ { get; set; }
//        public List<double> Gamma_ { get; set; }
//        public List<double> Vega_ { get; set; }

//        public double Theta_ { get; set; }
//        public double Value_ { get; set; }

//        public MCInstrument() { }
//        public MCInstrument(InstrumentInformation instInfo,
//                            UnderlyingInfo underInfo,
//                            MCPricer pricer,
//                            MCEngine mcEngine)
//        {
//            this.instInfo_ = instInfo;
//            this.underInfo_ = underInfo;
//            this.pricer_ = pricer;
//            this.mcEngine_ = mcEngine;
//        }
                               

//        protected void setting()
//        {

//            this.mcEngine_.settlementDate = new Date();
//            this.mcEngine_.maturity = new Date();
//            this.mcEngine_.dayCounter = new DayCounter();
//            this.mcEngine_.calendar = new Calendar();

//            this.mcEngine_.setUnderlying(this.underInfo_);

//            this.pricer_.discountTS_ = mcEngine_.disCountTS_;

//        }

//        public override void calculate()
//        {
//            //pricer_.setsetPosition(grid, dayCounter, calendar);

//            int simulNum = mcEngine_.simulationNumber();
//            int assetNum = pricer_.assetNumber();

//            Value_ = 0.0;

//            for (int i = 0; i < simulNum; i++)
//            {
//                Value_ = Value_ + this.pricer_.value(mcEngine_.multiPath());

//                for (int j = 0; j < assetNum; j++)
//                {
//                    DsPlusValue_[j] = DsPlusValue_[j] + this.pricer_.value(mcEngine_.multiPathDsPlus(j));
//                    DsMinusValue_[j] = DsMinusValue_[j] + this.pricer_.value(mcEngine_.multiPathDsMinus(j));
//                    DvolPlusValue_[j] = DvolPlusValue_[j] + this.pricer_.value(mcEngine_.multiPathDvolPlus(j));
//                    DvolMinusValue_[j] = DvolMinusValue_[j] + this.pricer_.value(mcEngine_.multiPathDvolMinus(j));

//                }

//                DtPlusValue_ = DtPlusValue_ + this.pricer_.value(mcEngine_.multiPathDtPlus());

//                Console.WriteLine(i);
//            }

//            PerturbationSetting perturbationSetting = new PerturbationSetting();

//            for (int j = 0; j < assetNum; j++)
//            {
//                double Ds = perturbationSetting.Ds(underInfo_[j]);
//                double Dvol = perturbationSetting.Dvol(underInfo_[j]);

//                this.Delta_[j] = (DsPlusValue_[j] - DsMinusValue_[j]) / (2.0 * Ds);
//                this.Gamma_[j] = (DsPlusValue_[j] - 2 * Value_ + DsMinusValue_[j]) / (Ds * Ds);
//                this.Vega_[j] = (DvolPlusValue_[j] - DvolMinusValue_[j]) / (2 * Dvol);
//            }

//            this.Theta_ = (DtPlusValue_ - Value_);


//        }


//        public override string buildXml()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
