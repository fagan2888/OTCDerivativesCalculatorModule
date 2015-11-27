using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CompoundingRate : ISerialized
    {
        public CompoundingRate(XmlNode xmlNode)
        {
            XmlNode interestLegRateNode = xmlNode.SelectSingleNode("interestLegRate");
            
            if (interestLegRateNode != null)
            {
                if (interestLegRateNode.Attributes["href"] != null || interestLegRateNode.Attributes["id"] != null) 
                {
                    if (interestLegRateNode.Attributes["id"] != null) 
                    {
                        interestLegRateIDRef_ = interestLegRateNode.Attributes["id"].Value;
                        FloatingRateCalculationReference ob = new FloatingRateCalculationReference(interestLegRateNode);
                        IDManager.SetID(interestLegRateIDRef_, ob);
                    }
                    else if (interestLegRateNode.Attributes["href"] != null)
                    {
                        interestLegRateIDRef_ = interestLegRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestLegRate_ = new FloatingRateCalculationReference(interestLegRateNode);
                    }
                }
                else
                {
                    interestLegRate_ = new FloatingRateCalculationReference(interestLegRateNode);
                }
            }
            
        
            XmlNode specificRateNode = xmlNode.SelectSingleNode("specificRate");
            
            if (specificRateNode != null)
            {
                if (specificRateNode.Attributes["href"] != null || specificRateNode.Attributes["id"] != null) 
                {
                    if (specificRateNode.Attributes["id"] != null) 
                    {
                        specificRateIDRef_ = specificRateNode.Attributes["id"].Value;
                        InterestAccrualsMethod ob = new InterestAccrualsMethod(specificRateNode);
                        IDManager.SetID(specificRateIDRef_, ob);
                    }
                    else if (specificRateNode.Attributes["href"] != null)
                    {
                        specificRateIDRef_ = specificRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        specificRate_ = new InterestAccrualsMethod(specificRateNode);
                    }
                }
                else
                {
                    specificRate_ = new InterestAccrualsMethod(specificRateNode);
                }
            }
            
        
        }
        
    
        #region InterestLegRate_
        private FloatingRateCalculationReference interestLegRate_;
        public FloatingRateCalculationReference InterestLegRate_
        {
            get
            {
                if (this.interestLegRate_ != null)
                {
                    return this.interestLegRate_; 
                }
                else if (this.interestLegRateIDRef_ != null)
                {
                    interestLegRate_ = IDManager.getID(interestLegRateIDRef_) as FloatingRateCalculationReference;
                    return this.interestLegRate_; 
                }
                else
                {
                      return this.interestLegRate_; 
                }
            }
            set
            {
                if (this.interestLegRate_ != value)
                {
                    this.interestLegRate_ = value;
                }
            }
        }
        #endregion
        
        public string interestLegRateIDRef_ { get; set; }
        #region SpecificRate_
        private InterestAccrualsMethod specificRate_;
        public InterestAccrualsMethod SpecificRate_
        {
            get
            {
                if (this.specificRate_ != null)
                {
                    return this.specificRate_; 
                }
                else if (this.specificRateIDRef_ != null)
                {
                    specificRate_ = IDManager.getID(specificRateIDRef_) as InterestAccrualsMethod;
                    return this.specificRate_; 
                }
                else
                {
                      return this.specificRate_; 
                }
            }
            set
            {
                if (this.specificRate_ != value)
                {
                    this.specificRate_ = value;
                }
            }
        }
        #endregion
        
        public string specificRateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

