using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InterestAccrualsMethod : ISerialized
    {
        public InterestAccrualsMethod(XmlNode xmlNode)
        {
            XmlNode floatingRateCalculationNode = xmlNode.SelectSingleNode("floatingRateCalculation");
            
            if (floatingRateCalculationNode != null)
            {
                if (floatingRateCalculationNode.Attributes["href"] != null || floatingRateCalculationNode.Attributes["id"] != null) 
                {
                    if (floatingRateCalculationNode.Attributes["id"] != null) 
                    {
                        floatingRateCalculationIDRef_ = floatingRateCalculationNode.Attributes["id"].Value;
                        FloatingRateCalculation ob = new FloatingRateCalculation(floatingRateCalculationNode);
                        IDManager.SetID(floatingRateCalculationIDRef_, ob);
                    }
                    else if (floatingRateCalculationNode.Attributes["href"] != null)
                    {
                        floatingRateCalculationIDRef_ = floatingRateCalculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingRateCalculation_ = new FloatingRateCalculation(floatingRateCalculationNode);
                    }
                }
                else
                {
                    floatingRateCalculation_ = new FloatingRateCalculation(floatingRateCalculationNode);
                }
            }
            
        
            XmlNode fixedRateNode = xmlNode.SelectSingleNode("fixedRate");
            
            if (fixedRateNode != null)
            {
                if (fixedRateNode.Attributes["href"] != null || fixedRateNode.Attributes["id"] != null) 
                {
                    if (fixedRateNode.Attributes["id"] != null) 
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(fixedRateNode);
                        IDManager.SetID(fixedRateIDRef_, ob);
                    }
                    else if (fixedRateNode.Attributes["href"] != null)
                    {
                        fixedRateIDRef_ = fixedRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedRate_ = new XsdTypeDecimal(fixedRateNode);
                    }
                }
                else
                {
                    fixedRate_ = new XsdTypeDecimal(fixedRateNode);
                }
            }
            
        
        }
        
    
        #region FloatingRateCalculation_
        private FloatingRateCalculation floatingRateCalculation_;
        public FloatingRateCalculation FloatingRateCalculation_
        {
            get
            {
                if (this.floatingRateCalculation_ != null)
                {
                    return this.floatingRateCalculation_; 
                }
                else if (this.floatingRateCalculationIDRef_ != null)
                {
                    floatingRateCalculation_ = IDManager.getID(floatingRateCalculationIDRef_) as FloatingRateCalculation;
                    return this.floatingRateCalculation_; 
                }
                else
                {
                      return this.floatingRateCalculation_; 
                }
            }
            set
            {
                if (this.floatingRateCalculation_ != value)
                {
                    this.floatingRateCalculation_ = value;
                }
            }
        }
        #endregion
        
        public string floatingRateCalculationIDRef_ { get; set; }
        #region FixedRate_
        private XsdTypeDecimal fixedRate_;
        public XsdTypeDecimal FixedRate_
        {
            get
            {
                if (this.fixedRate_ != null)
                {
                    return this.fixedRate_; 
                }
                else if (this.fixedRateIDRef_ != null)
                {
                    fixedRate_ = IDManager.getID(fixedRateIDRef_) as XsdTypeDecimal;
                    return this.fixedRate_; 
                }
                else
                {
                      return this.fixedRate_; 
                }
            }
            set
            {
                if (this.fixedRate_ != value)
                {
                    this.fixedRate_ = value;
                }
            }
        }
        #endregion
        
        public string fixedRateIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

