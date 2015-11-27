using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RiskMonitor;

namespace ExcelInterface
{
    public class YieldTermstructureXL : CurveParaXL
    {

        private string detailType_;
        private string curveType_;
        private string interpolation_;
        private string daycounter_;
        private string calendar_;
        private string businessDC_;

        private string[] tenorArr_;
        private string[] dataArr_;

        #region YieldCurveVM_
        private YieldTermstructureViewModel yieldCurveVM_;
        public YieldTermstructureViewModel YieldCurveVM_
        {
            get { return this.yieldCurveVM_; }
            set
            {
                if (this.yieldCurveVM_ != value)
                {
                    this.yieldCurveVM_ = value;
                }
            }
        }
        #endregion

        public YieldTermstructureXL(string curveID, string curveName, string dataType, string usingType, string detailType, string curveType, string interpolation, string daycounter, string calendar, string businessDC, 
                                    string[] tenorArr, string[] dataArr)
        {
            // TODO: Complete member initialization
            this.curveID_ = curveID;
            this.curveName_ = curveName;
            this.dataType_ = dataType;
            this.usingType_ = usingType;
            this.detailType_ = detailType;
            this.curveType_ = curveType;
            this.interpolation_ = interpolation;
            this.daycounter_ = daycounter;
            this.calendar_ = calendar;
            this.businessDC_ = businessDC;
            this.tenorArr_ = tenorArr;
            this.dataArr_ = dataArr;
        }

        public override void buildXml()
        {

            YieldTermstructureViewModel ytvm = new YieldTermstructureViewModel();
            ytvm.CurveType_ = this.curveType_;
            ytvm.Interpolation_ = this.interpolation_;
            ytvm.Daycounter_ = this.daycounter_;
            ytvm.Calendar_ = this.calendar_;
            ytvm.BusinessDayConvention_ = this.businessDC_;

            for (int i = 0; i < tenorArr_.Length ; i++)
            {
                RateDataViewModel rdvm = new RateDataViewModel();
                rdvm.PeriodMultiplier_ = this.tenorArr_[i].Substring(0,this.tenorArr_[i].Length - 1);
                rdvm.Period_ = this.tenorArr_[i].Substring(this.tenorArr_[i].Length - 1);
                rdvm.Data_ = this.dataArr_[i];

                ytvm.RateDataViewModel_.Add(rdvm);

            }

            this.yieldCurveVM_ = ytvm;
            //ytvm.buildXml();
        }
    }
}
