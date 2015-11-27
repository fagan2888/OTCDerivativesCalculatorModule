using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RiskMonitor;

namespace ExcelInterface
{
    public class GeometricBMParaXL : IndexParaXL
    {
        private string krCode_;
        private string underName_;
        private string currentValue_;
        private string drift_;
        private string dividend_;
        private string volatility_;

        public GeometricBMParaXL(string krCode, 
                                string underName, 
                                string currentValue, 
                                string drift, 
                                string dividend, 
                                string volatility)
        {
            // TODO: Complete member initialization
            this.krCode_ = krCode;
            this.underName_ = underName;
            this.currentValue_ = currentValue;
            this.drift_ = drift;
            this.dividend_ = dividend;
            this.volatility_ = volatility;
        }

        public override void buildXml()
        {
            
            GeometricBMViewModel gbmvm = new GeometricBMViewModel();

            gbmvm.KrCode_ = this.krCode_;
            gbmvm.UnderName_ = this.underName_;

            gbmvm.CurrentValue_ = this.currentValue_;
            gbmvm.Drift_ = this.drift_;
            gbmvm.Dividend_ = this.dividend_;
            gbmvm.Volatility_ = this.volatility_;

            //viewModel_.buildXml(xmlWriter);

            this.viewModel_ = gbmvm;


        }


    }
}
