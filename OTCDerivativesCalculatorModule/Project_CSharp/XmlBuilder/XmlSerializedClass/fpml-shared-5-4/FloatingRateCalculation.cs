using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FloatingRateCalculation : FloatingRate
    {
        public FloatingRateCalculation(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode initialRateNode = xmlNode.SelectSingleNode("initialRate");
            
            if (initialRateNode != null)
            {
                if (initialRateNode.Attributes["href"] != null || initialRateNode.Attributes["id"] != null) 
                {
                    if (initialRateNode.Attributes["id"] != null) 
                    {
                        initialRateIDRef_ = initialRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(initialRateNode);
                        IDManager.SetID(initialRateIDRef_, ob);
                    }
                    else if (initialRateNode.Attributes["href"] != null)
                    {
                        initialRateIDRef_ = initialRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialRate_ = new XsdTypeDecimal(initialRateNode);
                    }
                }
                else
                {
                    initialRate_ = new XsdTypeDecimal(initialRateNode);
                }
            }
            
        
            XmlNode finalRateRoundingNode = xmlNode.SelectSingleNode("finalRateRounding");
            
            if (finalRateRoundingNode != null)
            {
                if (finalRateRoundingNode.Attributes["href"] != null || finalRateRoundingNode.Attributes["id"] != null) 
                {
                    if (finalRateRoundingNode.Attributes["id"] != null) 
                    {
                        finalRateRoundingIDRef_ = finalRateRoundingNode.Attributes["id"].Value;
                        Rounding ob = new Rounding(finalRateRoundingNode);
                        IDManager.SetID(finalRateRoundingIDRef_, ob);
                    }
                    else if (finalRateRoundingNode.Attributes["href"] != null)
                    {
                        finalRateRoundingIDRef_ = finalRateRoundingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        finalRateRounding_ = new Rounding(finalRateRoundingNode);
                    }
                }
                else
                {
                    finalRateRounding_ = new Rounding(finalRateRoundingNode);
                }
            }
            
        
            XmlNode averagingMethodNode = xmlNode.SelectSingleNode("averagingMethod");
            
            if (averagingMethodNode != null)
            {
                if (averagingMethodNode.Attributes["href"] != null || averagingMethodNode.Attributes["id"] != null) 
                {
                    if (averagingMethodNode.Attributes["id"] != null) 
                    {
                        averagingMethodIDRef_ = averagingMethodNode.Attributes["id"].Value;
                        AveragingMethodEnum ob = new AveragingMethodEnum(averagingMethodNode);
                        IDManager.SetID(averagingMethodIDRef_, ob);
                    }
                    else if (averagingMethodNode.Attributes["href"] != null)
                    {
                        averagingMethodIDRef_ = averagingMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagingMethod_ = new AveragingMethodEnum(averagingMethodNode);
                    }
                }
                else
                {
                    averagingMethod_ = new AveragingMethodEnum(averagingMethodNode);
                }
            }
            
        
            XmlNode negativeInterestRateTreatmentNode = xmlNode.SelectSingleNode("negativeInterestRateTreatment");
            
            if (negativeInterestRateTreatmentNode != null)
            {
                if (negativeInterestRateTreatmentNode.Attributes["href"] != null || negativeInterestRateTreatmentNode.Attributes["id"] != null) 
                {
                    if (negativeInterestRateTreatmentNode.Attributes["id"] != null) 
                    {
                        negativeInterestRateTreatmentIDRef_ = negativeInterestRateTreatmentNode.Attributes["id"].Value;
                        NegativeInterestRateTreatmentEnum ob = new NegativeInterestRateTreatmentEnum(negativeInterestRateTreatmentNode);
                        IDManager.SetID(negativeInterestRateTreatmentIDRef_, ob);
                    }
                    else if (negativeInterestRateTreatmentNode.Attributes["href"] != null)
                    {
                        negativeInterestRateTreatmentIDRef_ = negativeInterestRateTreatmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        negativeInterestRateTreatment_ = new NegativeInterestRateTreatmentEnum(negativeInterestRateTreatmentNode);
                    }
                }
                else
                {
                    negativeInterestRateTreatment_ = new NegativeInterestRateTreatmentEnum(negativeInterestRateTreatmentNode);
                }
            }
            
        
        }
        
    
        #region InitialRate_
        private XsdTypeDecimal initialRate_;
        public XsdTypeDecimal InitialRate_
        {
            get
            {
                if (this.initialRate_ != null)
                {
                    return this.initialRate_; 
                }
                else if (this.initialRateIDRef_ != null)
                {
                    initialRate_ = IDManager.getID(initialRateIDRef_) as XsdTypeDecimal;
                    return this.initialRate_; 
                }
                else
                {
                      return this.initialRate_; 
                }
            }
            set
            {
                if (this.initialRate_ != value)
                {
                    this.initialRate_ = value;
                }
            }
        }
        #endregion
        
        public string initialRateIDRef_ { get; set; }
        #region FinalRateRounding_
        private Rounding finalRateRounding_;
        public Rounding FinalRateRounding_
        {
            get
            {
                if (this.finalRateRounding_ != null)
                {
                    return this.finalRateRounding_; 
                }
                else if (this.finalRateRoundingIDRef_ != null)
                {
                    finalRateRounding_ = IDManager.getID(finalRateRoundingIDRef_) as Rounding;
                    return this.finalRateRounding_; 
                }
                else
                {
                      return this.finalRateRounding_; 
                }
            }
            set
            {
                if (this.finalRateRounding_ != value)
                {
                    this.finalRateRounding_ = value;
                }
            }
        }
        #endregion
        
        public string finalRateRoundingIDRef_ { get; set; }
        #region AveragingMethod_
        private AveragingMethodEnum averagingMethod_;
        public AveragingMethodEnum AveragingMethod_
        {
            get
            {
                if (this.averagingMethod_ != null)
                {
                    return this.averagingMethod_; 
                }
                else if (this.averagingMethodIDRef_ != null)
                {
                    averagingMethod_ = IDManager.getID(averagingMethodIDRef_) as AveragingMethodEnum;
                    return this.averagingMethod_; 
                }
                else
                {
                      return this.averagingMethod_; 
                }
            }
            set
            {
                if (this.averagingMethod_ != value)
                {
                    this.averagingMethod_ = value;
                }
            }
        }
        #endregion
        
        public string averagingMethodIDRef_ { get; set; }
        #region NegativeInterestRateTreatment_
        private NegativeInterestRateTreatmentEnum negativeInterestRateTreatment_;
        public NegativeInterestRateTreatmentEnum NegativeInterestRateTreatment_
        {
            get
            {
                if (this.negativeInterestRateTreatment_ != null)
                {
                    return this.negativeInterestRateTreatment_; 
                }
                else if (this.negativeInterestRateTreatmentIDRef_ != null)
                {
                    negativeInterestRateTreatment_ = IDManager.getID(negativeInterestRateTreatmentIDRef_) as NegativeInterestRateTreatmentEnum;
                    return this.negativeInterestRateTreatment_; 
                }
                else
                {
                      return this.negativeInterestRateTreatment_; 
                }
            }
            set
            {
                if (this.negativeInterestRateTreatment_ != value)
                {
                    this.negativeInterestRateTreatment_ = value;
                }
            }
        }
        #endregion
        
        public string negativeInterestRateTreatmentIDRef_ { get; set; }
        
    
        
    
    }
    
}

