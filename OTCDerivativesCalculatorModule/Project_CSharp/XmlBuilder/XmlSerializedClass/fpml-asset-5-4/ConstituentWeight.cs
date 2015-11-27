using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class ConstituentWeight : ISerialized
    {
        public ConstituentWeight(XmlNode xmlNode)
        {
            XmlNode openUnitsNode = xmlNode.SelectSingleNode("openUnits");
            
            if (openUnitsNode != null)
            {
                if (openUnitsNode.Attributes["href"] != null || openUnitsNode.Attributes["id"] != null) 
                {
                    if (openUnitsNode.Attributes["id"] != null) 
                    {
                        openUnitsIDRef_ = openUnitsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(openUnitsNode);
                        IDManager.SetID(openUnitsIDRef_, ob);
                    }
                    else if (openUnitsNode.Attributes["href"] != null)
                    {
                        openUnitsIDRef_ = openUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        openUnits_ = new XsdTypeDecimal(openUnitsNode);
                    }
                }
                else
                {
                    openUnits_ = new XsdTypeDecimal(openUnitsNode);
                }
            }
            
        
            XmlNode basketPercentageNode = xmlNode.SelectSingleNode("basketPercentage");
            
            if (basketPercentageNode != null)
            {
                if (basketPercentageNode.Attributes["href"] != null || basketPercentageNode.Attributes["id"] != null) 
                {
                    if (basketPercentageNode.Attributes["id"] != null) 
                    {
                        basketPercentageIDRef_ = basketPercentageNode.Attributes["id"].Value;
                        RestrictedPercentage ob = new RestrictedPercentage(basketPercentageNode);
                        IDManager.SetID(basketPercentageIDRef_, ob);
                    }
                    else if (basketPercentageNode.Attributes["href"] != null)
                    {
                        basketPercentageIDRef_ = basketPercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basketPercentage_ = new RestrictedPercentage(basketPercentageNode);
                    }
                }
                else
                {
                    basketPercentage_ = new RestrictedPercentage(basketPercentageNode);
                }
            }
            
        
            XmlNode basketAmountNode = xmlNode.SelectSingleNode("basketAmount");
            
            if (basketAmountNode != null)
            {
                if (basketAmountNode.Attributes["href"] != null || basketAmountNode.Attributes["id"] != null) 
                {
                    if (basketAmountNode.Attributes["id"] != null) 
                    {
                        basketAmountIDRef_ = basketAmountNode.Attributes["id"].Value;
                        Money ob = new Money(basketAmountNode);
                        IDManager.SetID(basketAmountIDRef_, ob);
                    }
                    else if (basketAmountNode.Attributes["href"] != null)
                    {
                        basketAmountIDRef_ = basketAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basketAmount_ = new Money(basketAmountNode);
                    }
                }
                else
                {
                    basketAmount_ = new Money(basketAmountNode);
                }
            }
            
        
        }
        
    
        #region OpenUnits_
        private XsdTypeDecimal openUnits_;
        public XsdTypeDecimal OpenUnits_
        {
            get
            {
                if (this.openUnits_ != null)
                {
                    return this.openUnits_; 
                }
                else if (this.openUnitsIDRef_ != null)
                {
                    openUnits_ = IDManager.getID(openUnitsIDRef_) as XsdTypeDecimal;
                    return this.openUnits_; 
                }
                else
                {
                      return this.openUnits_; 
                }
            }
            set
            {
                if (this.openUnits_ != value)
                {
                    this.openUnits_ = value;
                }
            }
        }
        #endregion
        
        public string openUnitsIDRef_ { get; set; }
        #region BasketPercentage_
        private RestrictedPercentage basketPercentage_;
        public RestrictedPercentage BasketPercentage_
        {
            get
            {
                if (this.basketPercentage_ != null)
                {
                    return this.basketPercentage_; 
                }
                else if (this.basketPercentageIDRef_ != null)
                {
                    basketPercentage_ = IDManager.getID(basketPercentageIDRef_) as RestrictedPercentage;
                    return this.basketPercentage_; 
                }
                else
                {
                      return this.basketPercentage_; 
                }
            }
            set
            {
                if (this.basketPercentage_ != value)
                {
                    this.basketPercentage_ = value;
                }
            }
        }
        #endregion
        
        public string basketPercentageIDRef_ { get; set; }
        #region BasketAmount_
        private Money basketAmount_;
        public Money BasketAmount_
        {
            get
            {
                if (this.basketAmount_ != null)
                {
                    return this.basketAmount_; 
                }
                else if (this.basketAmountIDRef_ != null)
                {
                    basketAmount_ = IDManager.getID(basketAmountIDRef_) as Money;
                    return this.basketAmount_; 
                }
                else
                {
                      return this.basketAmount_; 
                }
            }
            set
            {
                if (this.basketAmount_ != value)
                {
                    this.basketAmount_ = value;
                }
            }
        }
        #endregion
        
        public string basketAmountIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

