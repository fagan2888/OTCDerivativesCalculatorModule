using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Premium : SimplePayment
    {
        public Premium(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode premiumTypeNode = xmlNode.SelectSingleNode("premiumType");
            
            if (premiumTypeNode != null)
            {
                if (premiumTypeNode.Attributes["href"] != null || premiumTypeNode.Attributes["id"] != null) 
                {
                    if (premiumTypeNode.Attributes["id"] != null) 
                    {
                        premiumTypeIDRef_ = premiumTypeNode.Attributes["id"].Value;
                        PremiumTypeEnum ob = new PremiumTypeEnum(premiumTypeNode);
                        IDManager.SetID(premiumTypeIDRef_, ob);
                    }
                    else if (premiumTypeNode.Attributes["href"] != null)
                    {
                        premiumTypeIDRef_ = premiumTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        premiumType_ = new PremiumTypeEnum(premiumTypeNode);
                    }
                }
                else
                {
                    premiumType_ = new PremiumTypeEnum(premiumTypeNode);
                }
            }
            
        
            XmlNode pricePerOptionNode = xmlNode.SelectSingleNode("pricePerOption");
            
            if (pricePerOptionNode != null)
            {
                if (pricePerOptionNode.Attributes["href"] != null || pricePerOptionNode.Attributes["id"] != null) 
                {
                    if (pricePerOptionNode.Attributes["id"] != null) 
                    {
                        pricePerOptionIDRef_ = pricePerOptionNode.Attributes["id"].Value;
                        Money ob = new Money(pricePerOptionNode);
                        IDManager.SetID(pricePerOptionIDRef_, ob);
                    }
                    else if (pricePerOptionNode.Attributes["href"] != null)
                    {
                        pricePerOptionIDRef_ = pricePerOptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricePerOption_ = new Money(pricePerOptionNode);
                    }
                }
                else
                {
                    pricePerOption_ = new Money(pricePerOptionNode);
                }
            }
            
        
            XmlNode percentageOfNotionalNode = xmlNode.SelectSingleNode("percentageOfNotional");
            
            if (percentageOfNotionalNode != null)
            {
                if (percentageOfNotionalNode.Attributes["href"] != null || percentageOfNotionalNode.Attributes["id"] != null) 
                {
                    if (percentageOfNotionalNode.Attributes["id"] != null) 
                    {
                        percentageOfNotionalIDRef_ = percentageOfNotionalNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(percentageOfNotionalNode);
                        IDManager.SetID(percentageOfNotionalIDRef_, ob);
                    }
                    else if (percentageOfNotionalNode.Attributes["href"] != null)
                    {
                        percentageOfNotionalIDRef_ = percentageOfNotionalNode.Attributes["href"].Value;
                    }
                    else
                    {
                        percentageOfNotional_ = new XsdTypeDecimal(percentageOfNotionalNode);
                    }
                }
                else
                {
                    percentageOfNotional_ = new XsdTypeDecimal(percentageOfNotionalNode);
                }
            }
            
        
            XmlNode discountFactorNode = xmlNode.SelectSingleNode("discountFactor");
            
            if (discountFactorNode != null)
            {
                if (discountFactorNode.Attributes["href"] != null || discountFactorNode.Attributes["id"] != null) 
                {
                    if (discountFactorNode.Attributes["id"] != null) 
                    {
                        discountFactorIDRef_ = discountFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(discountFactorNode);
                        IDManager.SetID(discountFactorIDRef_, ob);
                    }
                    else if (discountFactorNode.Attributes["href"] != null)
                    {
                        discountFactorIDRef_ = discountFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        discountFactor_ = new XsdTypeDecimal(discountFactorNode);
                    }
                }
                else
                {
                    discountFactor_ = new XsdTypeDecimal(discountFactorNode);
                }
            }
            
        
            XmlNode presentValueAmountNode = xmlNode.SelectSingleNode("presentValueAmount");
            
            if (presentValueAmountNode != null)
            {
                if (presentValueAmountNode.Attributes["href"] != null || presentValueAmountNode.Attributes["id"] != null) 
                {
                    if (presentValueAmountNode.Attributes["id"] != null) 
                    {
                        presentValueAmountIDRef_ = presentValueAmountNode.Attributes["id"].Value;
                        Money ob = new Money(presentValueAmountNode);
                        IDManager.SetID(presentValueAmountIDRef_, ob);
                    }
                    else if (presentValueAmountNode.Attributes["href"] != null)
                    {
                        presentValueAmountIDRef_ = presentValueAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        presentValueAmount_ = new Money(presentValueAmountNode);
                    }
                }
                else
                {
                    presentValueAmount_ = new Money(presentValueAmountNode);
                }
            }
            
        
        }
        
    
        #region PremiumType_
        private PremiumTypeEnum premiumType_;
        public PremiumTypeEnum PremiumType_
        {
            get
            {
                if (this.premiumType_ != null)
                {
                    return this.premiumType_; 
                }
                else if (this.premiumTypeIDRef_ != null)
                {
                    premiumType_ = IDManager.getID(premiumTypeIDRef_) as PremiumTypeEnum;
                    return this.premiumType_; 
                }
                else
                {
                      return this.premiumType_; 
                }
            }
            set
            {
                if (this.premiumType_ != value)
                {
                    this.premiumType_ = value;
                }
            }
        }
        #endregion
        
        public string premiumTypeIDRef_ { get; set; }
        #region PricePerOption_
        private Money pricePerOption_;
        public Money PricePerOption_
        {
            get
            {
                if (this.pricePerOption_ != null)
                {
                    return this.pricePerOption_; 
                }
                else if (this.pricePerOptionIDRef_ != null)
                {
                    pricePerOption_ = IDManager.getID(pricePerOptionIDRef_) as Money;
                    return this.pricePerOption_; 
                }
                else
                {
                      return this.pricePerOption_; 
                }
            }
            set
            {
                if (this.pricePerOption_ != value)
                {
                    this.pricePerOption_ = value;
                }
            }
        }
        #endregion
        
        public string pricePerOptionIDRef_ { get; set; }
        #region PercentageOfNotional_
        private XsdTypeDecimal percentageOfNotional_;
        public XsdTypeDecimal PercentageOfNotional_
        {
            get
            {
                if (this.percentageOfNotional_ != null)
                {
                    return this.percentageOfNotional_; 
                }
                else if (this.percentageOfNotionalIDRef_ != null)
                {
                    percentageOfNotional_ = IDManager.getID(percentageOfNotionalIDRef_) as XsdTypeDecimal;
                    return this.percentageOfNotional_; 
                }
                else
                {
                      return this.percentageOfNotional_; 
                }
            }
            set
            {
                if (this.percentageOfNotional_ != value)
                {
                    this.percentageOfNotional_ = value;
                }
            }
        }
        #endregion
        
        public string percentageOfNotionalIDRef_ { get; set; }
        #region DiscountFactor_
        private XsdTypeDecimal discountFactor_;
        public XsdTypeDecimal DiscountFactor_
        {
            get
            {
                if (this.discountFactor_ != null)
                {
                    return this.discountFactor_; 
                }
                else if (this.discountFactorIDRef_ != null)
                {
                    discountFactor_ = IDManager.getID(discountFactorIDRef_) as XsdTypeDecimal;
                    return this.discountFactor_; 
                }
                else
                {
                      return this.discountFactor_; 
                }
            }
            set
            {
                if (this.discountFactor_ != value)
                {
                    this.discountFactor_ = value;
                }
            }
        }
        #endregion
        
        public string discountFactorIDRef_ { get; set; }
        #region PresentValueAmount_
        private Money presentValueAmount_;
        public Money PresentValueAmount_
        {
            get
            {
                if (this.presentValueAmount_ != null)
                {
                    return this.presentValueAmount_; 
                }
                else if (this.presentValueAmountIDRef_ != null)
                {
                    presentValueAmount_ = IDManager.getID(presentValueAmountIDRef_) as Money;
                    return this.presentValueAmount_; 
                }
                else
                {
                      return this.presentValueAmount_; 
                }
            }
            set
            {
                if (this.presentValueAmount_ != value)
                {
                    this.presentValueAmount_ = value;
                }
            }
        }
        #endregion
        
        public string presentValueAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

