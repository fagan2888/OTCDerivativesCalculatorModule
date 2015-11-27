using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace RiskMonitor
{
    public partial class CreditDefaultSwapPricing : ISerialized
    {
        public CreditDefaultSwapPricing() { }
        public CreditDefaultSwapPricing(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode calculationAmountNode = xmlNode.SelectSingleNode("calculationAmount");
            
            if (calculationAmountNode != null)
            {
                if (calculationAmountNode.Attributes["href"] != null || calculationAmountNode.Attributes["id"] != null) 
                {
                    if (calculationAmountNode.Attributes["id"] != null) 
                    {
                        calculationAmountIDRef_ = calculationAmountNode.Attributes["id"].Value;
                        CalculationAmount ob = new CalculationAmount(calculationAmountNode);
                        IDManager.SetID(calculationAmountIDRef_, ob);
                    }
                    else if (calculationAmountNode.Attributes["href"] != null)
                    {
                        calculationAmountIDRef_ = calculationAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationAmount_ = new CalculationAmount(calculationAmountNode);
                    }
                }
                else
                {
                    calculationAmount_ = new CalculationAmount(calculationAmountNode);
                }
            }
            
        
            XmlNode referenceEntityInfoNode = xmlNode.SelectSingleNode("referenceEntityInfo");
            
            if (referenceEntityInfoNode != null)
            {
                if (referenceEntityInfoNode.Attributes["href"] != null || referenceEntityInfoNode.Attributes["id"] != null) 
                {
                    if (referenceEntityInfoNode.Attributes["id"] != null) 
                    {
                        referenceEntityInfoIDRef_ = referenceEntityInfoNode.Attributes["id"].Value;
                        ReferenceEntityInfo ob = new ReferenceEntityInfo(referenceEntityInfoNode);
                        IDManager.SetID(referenceEntityInfoIDRef_, ob);
                    }
                    else if (referenceEntityInfoNode.Attributes["href"] != null)
                    {
                        referenceEntityInfoIDRef_ = referenceEntityInfoNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceEntityInfo_ = new ReferenceEntityInfo(referenceEntityInfoNode);
                    }
                }
                else
                {
                    referenceEntityInfo_ = new ReferenceEntityInfo(referenceEntityInfoNode);
                }
            }
            
        
            XmlNode evaluationCurvesNode = xmlNode.SelectSingleNode("evaluationCurves");
            
            if (evaluationCurvesNode != null)
            {
                if (evaluationCurvesNode.Attributes["href"] != null || evaluationCurvesNode.Attributes["id"] != null) 
                {
                    if (evaluationCurvesNode.Attributes["id"] != null) 
                    {
                        evaluationCurvesIDRef_ = evaluationCurvesNode.Attributes["id"].Value;
                        EvaluationCurves ob = new EvaluationCurves(evaluationCurvesNode);
                        IDManager.SetID(evaluationCurvesIDRef_, ob);
                    }
                    else if (evaluationCurvesNode.Attributes["href"] != null)
                    {
                        evaluationCurvesIDRef_ = evaluationCurvesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        evaluationCurves_ = new EvaluationCurves(evaluationCurvesNode);
                    }
                }
                else
                {
                    evaluationCurves_ = new EvaluationCurves(evaluationCurvesNode);
                }
            }
            
        
            XmlNode discountCurveNode = xmlNode.SelectSingleNode("discountCurve");
            
            if (discountCurveNode != null)
            {
                if (discountCurveNode.Attributes["href"] != null || discountCurveNode.Attributes["id"] != null) 
                {
                    if (discountCurveNode.Attributes["id"] != null) 
                    {
                        discountCurveIDRef_ = discountCurveNode.Attributes["id"].Value;
                        DiscountCurve ob = new DiscountCurve(discountCurveNode);
                        IDManager.SetID(discountCurveIDRef_, ob);
                    }
                    else if (discountCurveNode.Attributes["href"] != null)
                    {
                        discountCurveIDRef_ = discountCurveNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountCurve_ = new DiscountCurve(discountCurveNode);
                    }
                }
                else
                {
                    discountCurve_ = new DiscountCurve(discountCurveNode);
                }
            }
            
        
            XmlNode recoveryRateNode = xmlNode.SelectSingleNode("recoveryRate");
            
            if (recoveryRateNode != null)
            {
                if (recoveryRateNode.Attributes["href"] != null || recoveryRateNode.Attributes["id"] != null) 
                {
                    if (recoveryRateNode.Attributes["id"] != null) 
                    {
                        recoveryRateIDRef_ = recoveryRateNode.Attributes["id"].Value;
                        XsdTypeDouble ob = new XsdTypeDouble(recoveryRateNode);
                        IDManager.SetID(recoveryRateIDRef_, ob);
                    }
                    else if (recoveryRateNode.Attributes["href"] != null)
                    {
                        recoveryRateIDRef_ = recoveryRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        recoveryRate_ = new XsdTypeDouble(recoveryRateNode);
                    }
                }
                else
                {
                    recoveryRate_ = new XsdTypeDouble(recoveryRateNode);
                }
            }
            
        
        }
        
    
        #region CalculationAmount_
        private CalculationAmount calculationAmount_;
        public CalculationAmount CalculationAmount_
        {
            get
            {
                if (this.calculationAmount_ != null)
                {
                    return this.calculationAmount_; 
                }
                else if (this.calculationAmountIDRef_ != null)
                {
                    calculationAmount_ = IDManager.getID(calculationAmountIDRef_) as CalculationAmount;
                    return this.calculationAmount_; 
                }
                else
                {
                      return this.calculationAmount_; 
                }
            }
            set
            {
                if (this.calculationAmount_ != value)
                {
                    this.calculationAmount_ = value;
                }
            }
        }
        #endregion
        
        public string calculationAmountIDRef_ { get; set; }
        #region ReferenceEntityInfo_
        private ReferenceEntityInfo referenceEntityInfo_;
        public ReferenceEntityInfo ReferenceEntityInfo_
        {
            get
            {
                if (this.referenceEntityInfo_ != null)
                {
                    return this.referenceEntityInfo_; 
                }
                else if (this.referenceEntityInfoIDRef_ != null)
                {
                    referenceEntityInfo_ = IDManager.getID(referenceEntityInfoIDRef_) as ReferenceEntityInfo;
                    return this.referenceEntityInfo_; 
                }
                else
                {
                      return this.referenceEntityInfo_; 
                }
            }
            set
            {
                if (this.referenceEntityInfo_ != value)
                {
                    this.referenceEntityInfo_ = value;
                }
            }
        }
        #endregion
        
        public string referenceEntityInfoIDRef_ { get; set; }
        #region EvaluationCurves_
        private EvaluationCurves evaluationCurves_;
        public EvaluationCurves EvaluationCurves_
        {
            get
            {
                if (this.evaluationCurves_ != null)
                {
                    return this.evaluationCurves_; 
                }
                else if (this.evaluationCurvesIDRef_ != null)
                {
                    evaluationCurves_ = IDManager.getID(evaluationCurvesIDRef_) as EvaluationCurves;
                    return this.evaluationCurves_; 
                }
                else
                {
                      return this.evaluationCurves_; 
                }
            }
            set
            {
                if (this.evaluationCurves_ != value)
                {
                    this.evaluationCurves_ = value;
                }
            }
        }
        #endregion
        
        public string evaluationCurvesIDRef_ { get; set; }
        #region DiscountCurve_
        private DiscountCurve discountCurve_;
        public DiscountCurve DiscountCurve_
        {
            get
            {
                if (this.discountCurve_ != null)
                {
                    return this.discountCurve_; 
                }
                else if (this.discountCurveIDRef_ != null)
                {
                    discountCurve_ = IDManager.getID(discountCurveIDRef_) as DiscountCurve;
                    return this.discountCurve_; 
                }
                else
                {
                      return this.discountCurve_; 
                }
            }
            set
            {
                if (this.discountCurve_ != value)
                {
                    this.discountCurve_ = value;
                }
            }
        }
        #endregion
        
        public string discountCurveIDRef_ { get; set; }
        #region RecoveryRate_
        private XsdTypeDouble recoveryRate_;
        public XsdTypeDouble RecoveryRate_
        {
            get
            {
                if (this.recoveryRate_ != null)
                {
                    return this.recoveryRate_; 
                }
                else if (this.recoveryRateIDRef_ != null)
                {
                    recoveryRate_ = IDManager.getID(recoveryRateIDRef_) as XsdTypeDouble;
                    return this.recoveryRate_; 
                }
                else
                {
                      return this.recoveryRate_; 
                }
            }
            set
            {
                if (this.recoveryRate_ != value)
                {
                    this.recoveryRate_ = value;
                }
            }
        }
        #endregion
        
        public string recoveryRateIDRef_ { get; set; }
        
    
        
    
    }
    
}

