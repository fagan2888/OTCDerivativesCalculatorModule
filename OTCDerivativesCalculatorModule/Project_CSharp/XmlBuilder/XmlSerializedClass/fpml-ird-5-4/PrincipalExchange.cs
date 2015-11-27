using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PrincipalExchange : ISerialized
    {
        public PrincipalExchange(XmlNode xmlNode)
        {
            XmlNode unadjustedPrincipalExchangeDateNode = xmlNode.SelectSingleNode("unadjustedPrincipalExchangeDate");
            
            if (unadjustedPrincipalExchangeDateNode != null)
            {
                if (unadjustedPrincipalExchangeDateNode.Attributes["href"] != null || unadjustedPrincipalExchangeDateNode.Attributes["id"] != null) 
                {
                    if (unadjustedPrincipalExchangeDateNode.Attributes["id"] != null) 
                    {
                        unadjustedPrincipalExchangeDateIDRef_ = unadjustedPrincipalExchangeDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(unadjustedPrincipalExchangeDateNode);
                        IDManager.SetID(unadjustedPrincipalExchangeDateIDRef_, ob);
                    }
                    else if (unadjustedPrincipalExchangeDateNode.Attributes["href"] != null)
                    {
                        unadjustedPrincipalExchangeDateIDRef_ = unadjustedPrincipalExchangeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        unadjustedPrincipalExchangeDate_ = new XsdTypeDate(unadjustedPrincipalExchangeDateNode);
                    }
                }
                else
                {
                    unadjustedPrincipalExchangeDate_ = new XsdTypeDate(unadjustedPrincipalExchangeDateNode);
                }
            }
            
        
            XmlNode adjustedPrincipalExchangeDateNode = xmlNode.SelectSingleNode("adjustedPrincipalExchangeDate");
            
            if (adjustedPrincipalExchangeDateNode != null)
            {
                if (adjustedPrincipalExchangeDateNode.Attributes["href"] != null || adjustedPrincipalExchangeDateNode.Attributes["id"] != null) 
                {
                    if (adjustedPrincipalExchangeDateNode.Attributes["id"] != null) 
                    {
                        adjustedPrincipalExchangeDateIDRef_ = adjustedPrincipalExchangeDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(adjustedPrincipalExchangeDateNode);
                        IDManager.SetID(adjustedPrincipalExchangeDateIDRef_, ob);
                    }
                    else if (adjustedPrincipalExchangeDateNode.Attributes["href"] != null)
                    {
                        adjustedPrincipalExchangeDateIDRef_ = adjustedPrincipalExchangeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        adjustedPrincipalExchangeDate_ = new XsdTypeDate(adjustedPrincipalExchangeDateNode);
                    }
                }
                else
                {
                    adjustedPrincipalExchangeDate_ = new XsdTypeDate(adjustedPrincipalExchangeDateNode);
                }
            }
            
        
            XmlNode principalExchangeAmountNode = xmlNode.SelectSingleNode("principalExchangeAmount");
            
            if (principalExchangeAmountNode != null)
            {
                if (principalExchangeAmountNode.Attributes["href"] != null || principalExchangeAmountNode.Attributes["id"] != null) 
                {
                    if (principalExchangeAmountNode.Attributes["id"] != null) 
                    {
                        principalExchangeAmountIDRef_ = principalExchangeAmountNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(principalExchangeAmountNode);
                        IDManager.SetID(principalExchangeAmountIDRef_, ob);
                    }
                    else if (principalExchangeAmountNode.Attributes["href"] != null)
                    {
                        principalExchangeAmountIDRef_ = principalExchangeAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        principalExchangeAmount_ = new XsdTypeDecimal(principalExchangeAmountNode);
                    }
                }
                else
                {
                    principalExchangeAmount_ = new XsdTypeDecimal(principalExchangeAmountNode);
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
            
        
            XmlNode presentValuePrincipalExchangeAmountNode = xmlNode.SelectSingleNode("presentValuePrincipalExchangeAmount");
            
            if (presentValuePrincipalExchangeAmountNode != null)
            {
                if (presentValuePrincipalExchangeAmountNode.Attributes["href"] != null || presentValuePrincipalExchangeAmountNode.Attributes["id"] != null) 
                {
                    if (presentValuePrincipalExchangeAmountNode.Attributes["id"] != null) 
                    {
                        presentValuePrincipalExchangeAmountIDRef_ = presentValuePrincipalExchangeAmountNode.Attributes["id"].Value;
                        Money ob = new Money(presentValuePrincipalExchangeAmountNode);
                        IDManager.SetID(presentValuePrincipalExchangeAmountIDRef_, ob);
                    }
                    else if (presentValuePrincipalExchangeAmountNode.Attributes["href"] != null)
                    {
                        presentValuePrincipalExchangeAmountIDRef_ = presentValuePrincipalExchangeAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        presentValuePrincipalExchangeAmount_ = new Money(presentValuePrincipalExchangeAmountNode);
                    }
                }
                else
                {
                    presentValuePrincipalExchangeAmount_ = new Money(presentValuePrincipalExchangeAmountNode);
                }
            }
            
        
        }
        
    
        #region UnadjustedPrincipalExchangeDate_
        private XsdTypeDate unadjustedPrincipalExchangeDate_;
        public XsdTypeDate UnadjustedPrincipalExchangeDate_
        {
            get
            {
                if (this.unadjustedPrincipalExchangeDate_ != null)
                {
                    return this.unadjustedPrincipalExchangeDate_; 
                }
                else if (this.unadjustedPrincipalExchangeDateIDRef_ != null)
                {
                    unadjustedPrincipalExchangeDate_ = IDManager.getID(unadjustedPrincipalExchangeDateIDRef_) as XsdTypeDate;
                    return this.unadjustedPrincipalExchangeDate_; 
                }
                else
                {
                      return this.unadjustedPrincipalExchangeDate_; 
                }
            }
            set
            {
                if (this.unadjustedPrincipalExchangeDate_ != value)
                {
                    this.unadjustedPrincipalExchangeDate_ = value;
                }
            }
        }
        #endregion
        
        public string unadjustedPrincipalExchangeDateIDRef_ { get; set; }
        #region AdjustedPrincipalExchangeDate_
        private XsdTypeDate adjustedPrincipalExchangeDate_;
        public XsdTypeDate AdjustedPrincipalExchangeDate_
        {
            get
            {
                if (this.adjustedPrincipalExchangeDate_ != null)
                {
                    return this.adjustedPrincipalExchangeDate_; 
                }
                else if (this.adjustedPrincipalExchangeDateIDRef_ != null)
                {
                    adjustedPrincipalExchangeDate_ = IDManager.getID(adjustedPrincipalExchangeDateIDRef_) as XsdTypeDate;
                    return this.adjustedPrincipalExchangeDate_; 
                }
                else
                {
                      return this.adjustedPrincipalExchangeDate_; 
                }
            }
            set
            {
                if (this.adjustedPrincipalExchangeDate_ != value)
                {
                    this.adjustedPrincipalExchangeDate_ = value;
                }
            }
        }
        #endregion
        
        public string adjustedPrincipalExchangeDateIDRef_ { get; set; }
        #region PrincipalExchangeAmount_
        private XsdTypeDecimal principalExchangeAmount_;
        public XsdTypeDecimal PrincipalExchangeAmount_
        {
            get
            {
                if (this.principalExchangeAmount_ != null)
                {
                    return this.principalExchangeAmount_; 
                }
                else if (this.principalExchangeAmountIDRef_ != null)
                {
                    principalExchangeAmount_ = IDManager.getID(principalExchangeAmountIDRef_) as XsdTypeDecimal;
                    return this.principalExchangeAmount_; 
                }
                else
                {
                      return this.principalExchangeAmount_; 
                }
            }
            set
            {
                if (this.principalExchangeAmount_ != value)
                {
                    this.principalExchangeAmount_ = value;
                }
            }
        }
        #endregion
        
        public string principalExchangeAmountIDRef_ { get; set; }
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
        #region PresentValuePrincipalExchangeAmount_
        private Money presentValuePrincipalExchangeAmount_;
        public Money PresentValuePrincipalExchangeAmount_
        {
            get
            {
                if (this.presentValuePrincipalExchangeAmount_ != null)
                {
                    return this.presentValuePrincipalExchangeAmount_; 
                }
                else if (this.presentValuePrincipalExchangeAmountIDRef_ != null)
                {
                    presentValuePrincipalExchangeAmount_ = IDManager.getID(presentValuePrincipalExchangeAmountIDRef_) as Money;
                    return this.presentValuePrincipalExchangeAmount_; 
                }
                else
                {
                      return this.presentValuePrincipalExchangeAmount_; 
                }
            }
            set
            {
                if (this.presentValuePrincipalExchangeAmount_ != value)
                {
                    this.presentValuePrincipalExchangeAmount_ = value;
                }
            }
        }
        #endregion
        
        public string presentValuePrincipalExchangeAmountIDRef_ { get; set; }
        
    
        
    
    }
    
}

