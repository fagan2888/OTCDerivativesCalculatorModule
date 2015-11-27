using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DenominatorTerm : ISerialized
    {
        public DenominatorTerm(XmlNode xmlNode)
        {
            XmlNode weightedPartialNode = xmlNode.SelectSingleNode("weightedPartial");
            
            if (weightedPartialNode != null)
            {
                if (weightedPartialNode.Attributes["href"] != null || weightedPartialNode.Attributes["id"] != null) 
                {
                    if (weightedPartialNode.Attributes["id"] != null) 
                    {
                        weightedPartialIDRef_ = weightedPartialNode.Attributes["id"].Value;
                        WeightedPartialDerivative ob = new WeightedPartialDerivative(weightedPartialNode);
                        IDManager.SetID(weightedPartialIDRef_, ob);
                    }
                    else if (weightedPartialNode.Attributes["href"] != null)
                    {
                        weightedPartialIDRef_ = weightedPartialNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weightedPartial_ = new WeightedPartialDerivative(weightedPartialNode);
                    }
                }
                else
                {
                    weightedPartial_ = new WeightedPartialDerivative(weightedPartialNode);
                }
            }
            
        
            XmlNode powerNode = xmlNode.SelectSingleNode("power");
            
            if (powerNode != null)
            {
                if (powerNode.Attributes["href"] != null || powerNode.Attributes["id"] != null) 
                {
                    if (powerNode.Attributes["id"] != null) 
                    {
                        powerIDRef_ = powerNode.Attributes["id"].Value;
                        XsdTypePositiveInteger ob = new XsdTypePositiveInteger(powerNode);
                        IDManager.SetID(powerIDRef_, ob);
                    }
                    else if (powerNode.Attributes["href"] != null)
                    {
                        powerIDRef_ = powerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        power_ = new XsdTypePositiveInteger(powerNode);
                    }
                }
                else
                {
                    power_ = new XsdTypePositiveInteger(powerNode);
                }
            }
            
        
        }
        
    
        #region WeightedPartial_
        private WeightedPartialDerivative weightedPartial_;
        public WeightedPartialDerivative WeightedPartial_
        {
            get
            {
                if (this.weightedPartial_ != null)
                {
                    return this.weightedPartial_; 
                }
                else if (this.weightedPartialIDRef_ != null)
                {
                    weightedPartial_ = IDManager.getID(weightedPartialIDRef_) as WeightedPartialDerivative;
                    return this.weightedPartial_; 
                }
                else
                {
                      return this.weightedPartial_; 
                }
            }
            set
            {
                if (this.weightedPartial_ != value)
                {
                    this.weightedPartial_ = value;
                }
            }
        }
        #endregion
        
        public string weightedPartialIDRef_ { get; set; }
        #region Power_
        private XsdTypePositiveInteger power_;
        public XsdTypePositiveInteger Power_
        {
            get
            {
                if (this.power_ != null)
                {
                    return this.power_; 
                }
                else if (this.powerIDRef_ != null)
                {
                    power_ = IDManager.getID(powerIDRef_) as XsdTypePositiveInteger;
                    return this.power_; 
                }
                else
                {
                      return this.power_; 
                }
            }
            set
            {
                if (this.power_ != value)
                {
                    this.power_ = value;
                }
            }
        }
        #endregion
        
        public string powerIDRef_ { get; set; }
        
    
        
    
    }
    
}

