using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class BoundedVariance : ISerialized
    {
        public BoundedVariance(XmlNode xmlNode)
        {
            XmlNode realisedVarianceMethodNode = xmlNode.SelectSingleNode("realisedVarianceMethod");
            
            if (realisedVarianceMethodNode != null)
            {
                if (realisedVarianceMethodNode.Attributes["href"] != null || realisedVarianceMethodNode.Attributes["id"] != null) 
                {
                    if (realisedVarianceMethodNode.Attributes["id"] != null) 
                    {
                        realisedVarianceMethodIDRef_ = realisedVarianceMethodNode.Attributes["id"].Value;
                        RealisedVarianceMethodEnum ob = new RealisedVarianceMethodEnum(realisedVarianceMethodNode);
                        IDManager.SetID(realisedVarianceMethodIDRef_, ob);
                    }
                    else if (realisedVarianceMethodNode.Attributes["href"] != null)
                    {
                        realisedVarianceMethodIDRef_ = realisedVarianceMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        realisedVarianceMethod_ = new RealisedVarianceMethodEnum(realisedVarianceMethodNode);
                    }
                }
                else
                {
                    realisedVarianceMethod_ = new RealisedVarianceMethodEnum(realisedVarianceMethodNode);
                }
            }
            
        
            XmlNode daysInRangeAdjustmentNode = xmlNode.SelectSingleNode("daysInRangeAdjustment");
            
            if (daysInRangeAdjustmentNode != null)
            {
                if (daysInRangeAdjustmentNode.Attributes["href"] != null || daysInRangeAdjustmentNode.Attributes["id"] != null) 
                {
                    if (daysInRangeAdjustmentNode.Attributes["id"] != null) 
                    {
                        daysInRangeAdjustmentIDRef_ = daysInRangeAdjustmentNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(daysInRangeAdjustmentNode);
                        IDManager.SetID(daysInRangeAdjustmentIDRef_, ob);
                    }
                    else if (daysInRangeAdjustmentNode.Attributes["href"] != null)
                    {
                        daysInRangeAdjustmentIDRef_ = daysInRangeAdjustmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        daysInRangeAdjustment_ = new XsdTypeBoolean(daysInRangeAdjustmentNode);
                    }
                }
                else
                {
                    daysInRangeAdjustment_ = new XsdTypeBoolean(daysInRangeAdjustmentNode);
                }
            }
            
        
            XmlNode upperBarrierNode = xmlNode.SelectSingleNode("upperBarrier");
            
            if (upperBarrierNode != null)
            {
                if (upperBarrierNode.Attributes["href"] != null || upperBarrierNode.Attributes["id"] != null) 
                {
                    if (upperBarrierNode.Attributes["id"] != null) 
                    {
                        upperBarrierIDRef_ = upperBarrierNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(upperBarrierNode);
                        IDManager.SetID(upperBarrierIDRef_, ob);
                    }
                    else if (upperBarrierNode.Attributes["href"] != null)
                    {
                        upperBarrierIDRef_ = upperBarrierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        upperBarrier_ = new NonNegativeDecimal(upperBarrierNode);
                    }
                }
                else
                {
                    upperBarrier_ = new NonNegativeDecimal(upperBarrierNode);
                }
            }
            
        
            XmlNode lowerBarrierNode = xmlNode.SelectSingleNode("lowerBarrier");
            
            if (lowerBarrierNode != null)
            {
                if (lowerBarrierNode.Attributes["href"] != null || lowerBarrierNode.Attributes["id"] != null) 
                {
                    if (lowerBarrierNode.Attributes["id"] != null) 
                    {
                        lowerBarrierIDRef_ = lowerBarrierNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(lowerBarrierNode);
                        IDManager.SetID(lowerBarrierIDRef_, ob);
                    }
                    else if (lowerBarrierNode.Attributes["href"] != null)
                    {
                        lowerBarrierIDRef_ = lowerBarrierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lowerBarrier_ = new NonNegativeDecimal(lowerBarrierNode);
                    }
                }
                else
                {
                    lowerBarrier_ = new NonNegativeDecimal(lowerBarrierNode);
                }
            }
            
        
        }
        
    
        #region RealisedVarianceMethod_
        private RealisedVarianceMethodEnum realisedVarianceMethod_;
        public RealisedVarianceMethodEnum RealisedVarianceMethod_
        {
            get
            {
                if (this.realisedVarianceMethod_ != null)
                {
                    return this.realisedVarianceMethod_; 
                }
                else if (this.realisedVarianceMethodIDRef_ != null)
                {
                    realisedVarianceMethod_ = IDManager.getID(realisedVarianceMethodIDRef_) as RealisedVarianceMethodEnum;
                    return this.realisedVarianceMethod_; 
                }
                else
                {
                      return this.realisedVarianceMethod_; 
                }
            }
            set
            {
                if (this.realisedVarianceMethod_ != value)
                {
                    this.realisedVarianceMethod_ = value;
                }
            }
        }
        #endregion
        
        public string realisedVarianceMethodIDRef_ { get; set; }
        #region DaysInRangeAdjustment_
        private XsdTypeBoolean daysInRangeAdjustment_;
        public XsdTypeBoolean DaysInRangeAdjustment_
        {
            get
            {
                if (this.daysInRangeAdjustment_ != null)
                {
                    return this.daysInRangeAdjustment_; 
                }
                else if (this.daysInRangeAdjustmentIDRef_ != null)
                {
                    daysInRangeAdjustment_ = IDManager.getID(daysInRangeAdjustmentIDRef_) as XsdTypeBoolean;
                    return this.daysInRangeAdjustment_; 
                }
                else
                {
                      return this.daysInRangeAdjustment_; 
                }
            }
            set
            {
                if (this.daysInRangeAdjustment_ != value)
                {
                    this.daysInRangeAdjustment_ = value;
                }
            }
        }
        #endregion
        
        public string daysInRangeAdjustmentIDRef_ { get; set; }
        #region UpperBarrier_
        private NonNegativeDecimal upperBarrier_;
        public NonNegativeDecimal UpperBarrier_
        {
            get
            {
                if (this.upperBarrier_ != null)
                {
                    return this.upperBarrier_; 
                }
                else if (this.upperBarrierIDRef_ != null)
                {
                    upperBarrier_ = IDManager.getID(upperBarrierIDRef_) as NonNegativeDecimal;
                    return this.upperBarrier_; 
                }
                else
                {
                      return this.upperBarrier_; 
                }
            }
            set
            {
                if (this.upperBarrier_ != value)
                {
                    this.upperBarrier_ = value;
                }
            }
        }
        #endregion
        
        public string upperBarrierIDRef_ { get; set; }
        #region LowerBarrier_
        private NonNegativeDecimal lowerBarrier_;
        public NonNegativeDecimal LowerBarrier_
        {
            get
            {
                if (this.lowerBarrier_ != null)
                {
                    return this.lowerBarrier_; 
                }
                else if (this.lowerBarrierIDRef_ != null)
                {
                    lowerBarrier_ = IDManager.getID(lowerBarrierIDRef_) as NonNegativeDecimal;
                    return this.lowerBarrier_; 
                }
                else
                {
                      return this.lowerBarrier_; 
                }
            }
            set
            {
                if (this.lowerBarrier_ != value)
                {
                    this.lowerBarrier_ = value;
                }
            }
        }
        #endregion
        
        public string lowerBarrierIDRef_ { get; set; }
        
    
        
    
    }
    
}

