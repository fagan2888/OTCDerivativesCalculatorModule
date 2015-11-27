using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class VanillaRateCalculation : ISerialized
    {
        public VanillaRateCalculation() { }
        public VanillaRateCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode rateCouponCalculationNode = xmlNode.SelectSingleNode("rateCouponCalculation");
            
            if (rateCouponCalculationNode != null)
            {
                if (rateCouponCalculationNode.Attributes["href"] != null || rateCouponCalculationNode.Attributes["id"] != null) 
                {
                    if (rateCouponCalculationNode.Attributes["id"] != null) 
                    {
                        rateCouponCalculationIDRef_ = rateCouponCalculationNode.Attributes["id"].Value;
                        RateCouponCalculation ob = new RateCouponCalculation(rateCouponCalculationNode);
                        IDManager.SetID(rateCouponCalculationIDRef_, ob);
                    }
                    else if (rateCouponCalculationNode.Attributes["href"] != null)
                    {
                        rateCouponCalculationIDRef_ = rateCouponCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rateCouponCalculation_ = new RateCouponCalculation(rateCouponCalculationNode);
                    }
                }
                else
                {
                    rateCouponCalculation_ = new RateCouponCalculation(rateCouponCalculationNode);
                }
            }
            
        
        }
        
    
        #region RateCouponCalculation_
        private RateCouponCalculation rateCouponCalculation_;
        public RateCouponCalculation RateCouponCalculation_
        {
            get
            {
                if (this.rateCouponCalculation_ != null)
                {
                    return this.rateCouponCalculation_; 
                }
                else if (this.rateCouponCalculationIDRef_ != null)
                {
                    rateCouponCalculation_ = IDManager.getID(rateCouponCalculationIDRef_) as RateCouponCalculation;
                    return this.rateCouponCalculation_; 
                }
                else
                {
                    throw new Exception( "rateCouponCalculation_Node no exist!");
                }
            }
            set
            {
                if (this.rateCouponCalculation_ != value)
                {
                    this.rateCouponCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string rateCouponCalculationIDRef_ { get; set; }
        
    
        
    
    }
    
}

