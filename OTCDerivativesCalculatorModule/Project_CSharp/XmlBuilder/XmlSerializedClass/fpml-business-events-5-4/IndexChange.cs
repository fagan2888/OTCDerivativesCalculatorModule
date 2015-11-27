using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class IndexChange : ChangeEvent
    {
        public IndexChange(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode indexFactorNode = xmlNode.SelectSingleNode("indexFactor");
            
            if (indexFactorNode != null)
            {
                if (indexFactorNode.Attributes["href"] != null || indexFactorNode.Attributes["id"] != null) 
                {
                    if (indexFactorNode.Attributes["id"] != null) 
                    {
                        indexFactorIDRef_ = indexFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(indexFactorNode);
                        IDManager.SetID(indexFactorIDRef_, ob);
                    }
                    else if (indexFactorNode.Attributes["href"] != null)
                    {
                        indexFactorIDRef_ = indexFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexFactor_ = new XsdTypeDecimal(indexFactorNode);
                    }
                }
                else
                {
                    indexFactor_ = new XsdTypeDecimal(indexFactorNode);
                }
            }
            
        
            XmlNode factoredCalculationAmountNode = xmlNode.SelectSingleNode("factoredCalculationAmount");
            
            if (factoredCalculationAmountNode != null)
            {
                if (factoredCalculationAmountNode.Attributes["href"] != null || factoredCalculationAmountNode.Attributes["id"] != null) 
                {
                    if (factoredCalculationAmountNode.Attributes["id"] != null) 
                    {
                        factoredCalculationAmountIDRef_ = factoredCalculationAmountNode.Attributes["id"].Value;
                        Money ob = new Money(factoredCalculationAmountNode);
                        IDManager.SetID(factoredCalculationAmountIDRef_, ob);
                    }
                    else if (factoredCalculationAmountNode.Attributes["href"] != null)
                    {
                        factoredCalculationAmountIDRef_ = factoredCalculationAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        factoredCalculationAmount_ = new Money(factoredCalculationAmountNode);
                    }
                }
                else
                {
                    factoredCalculationAmount_ = new Money(factoredCalculationAmountNode);
                }
            }
            
        
        }
        
    
        #region IndexFactor_
        private XsdTypeDecimal indexFactor_;
        public XsdTypeDecimal IndexFactor_
        {
            get
            {
                if (this.indexFactor_ != null)
                {
                    return this.indexFactor_; 
                }
                else if (this.indexFactorIDRef_ != null)
                {
                    indexFactor_ = IDManager.getID(indexFactorIDRef_) as XsdTypeDecimal;
                    return this.indexFactor_; 
                }
                else
                {
                      return this.indexFactor_; 
                }
            }
            set
            {
                if (this.indexFactor_ != value)
                {
                    this.indexFactor_ = value;
                }
            }
        }
        #endregion
        
        public string indexFactorIDRef_ { get; set; }
        #region FactoredCalculationAmount_
        private Money factoredCalculationAmount_;
        public Money FactoredCalculationAmount_
        {
            get
            {
                if (this.factoredCalculationAmount_ != null)
                {
                    return this.factoredCalculationAmount_; 
                }
                else if (this.factoredCalculationAmountIDRef_ != null)
                {
                    factoredCalculationAmount_ = IDManager.getID(factoredCalculationAmountIDRef_) as Money;
                    return this.factoredCalculationAmount_; 
                }
                else
                {
                      return this.factoredCalculationAmount_; 
                }
            }
            set
            {
                if (this.factoredCalculationAmount_ != value)
                {
                    this.factoredCalculationAmount_ = value;
                }
            }
        }
        #endregion
        
        public string factoredCalculationAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

