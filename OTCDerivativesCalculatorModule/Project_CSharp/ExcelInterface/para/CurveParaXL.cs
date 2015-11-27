using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using RiskMonitor;

namespace ExcelInterface
{
    public abstract class CurveParaXL
    {
        #region CurveID_
        protected string curveID_;
        public string CurveID_
        {
            get { return this.curveID_; }
            set
            {
                if (this.curveID_ != value)
                {
                    this.curveID_ = value;
                }
            }
        }
        #endregion

        #region CurveName_
        protected string curveName_;
        public string CurveName_
        {
            get { return this.curveName_; }
            set
            {
                if (this.curveName_ != value)
                {
                    this.curveName_ = value;
                }
            }
        }
        #endregion

        #region DataType_
        protected string dataType_;
        public string DataType_
        {
            get { return this.dataType_; }
            set
            {
                if (this.dataType_ != value)
                {
                    this.dataType_ = value;
                }
            }
        }
        #endregion

        #region UsingType_
        protected string usingType_;
        public string UsingType_
        {
            get { return this.usingType_; }
            set
            {
                if (this.usingType_ != value)
                {
                    this.usingType_ = value;
                }
            }
        }
        #endregion



        public abstract void buildXml();
    }
}
