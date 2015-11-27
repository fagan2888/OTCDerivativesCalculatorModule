using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class EquityOption : EquityDerivativeLongFormBase
    {
        public EquityOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode strikeNode = xmlNode.SelectSingleNode("strike");
            
            if (strikeNode != null)
            {
                if (strikeNode.Attributes["href"] != null || strikeNode.Attributes["id"] != null) 
                {
                    if (strikeNode.Attributes["id"] != null) 
                    {
                        strikeIDRef_ = strikeNode.Attributes["id"].Value;
                        EquityStrike ob = new EquityStrike(strikeNode);
                        IDManager.SetID(strikeIDRef_, ob);
                    }
                    else if (strikeNode.Attributes["href"] != null)
                    {
                        strikeIDRef_ = strikeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        strike_ = new EquityStrike(strikeNode);
                    }
                }
                else
                {
                    strike_ = new EquityStrike(strikeNode);
                }
            }
            
        
            XmlNode spotPriceNode = xmlNode.SelectSingleNode("spotPrice");
            
            if (spotPriceNode != null)
            {
                if (spotPriceNode.Attributes["href"] != null || spotPriceNode.Attributes["id"] != null) 
                {
                    if (spotPriceNode.Attributes["id"] != null) 
                    {
                        spotPriceIDRef_ = spotPriceNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(spotPriceNode);
                        IDManager.SetID(spotPriceIDRef_, ob);
                    }
                    else if (spotPriceNode.Attributes["href"] != null)
                    {
                        spotPriceIDRef_ = spotPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spotPrice_ = new NonNegativeDecimal(spotPriceNode);
                    }
                }
                else
                {
                    spotPrice_ = new NonNegativeDecimal(spotPriceNode);
                }
            }
            
        
            XmlNode numberOfOptionsNode = xmlNode.SelectSingleNode("numberOfOptions");
            
            if (numberOfOptionsNode != null)
            {
                if (numberOfOptionsNode.Attributes["href"] != null || numberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (numberOfOptionsNode.Attributes["id"] != null) 
                    {
                        numberOfOptionsIDRef_ = numberOfOptionsNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(numberOfOptionsNode);
                        IDManager.SetID(numberOfOptionsIDRef_, ob);
                    }
                    else if (numberOfOptionsNode.Attributes["href"] != null)
                    {
                        numberOfOptionsIDRef_ = numberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        numberOfOptions_ = new NonNegativeDecimal(numberOfOptionsNode);
                    }
                }
                else
                {
                    numberOfOptions_ = new NonNegativeDecimal(numberOfOptionsNode);
                }
            }
            
        
            XmlNode optionEntitlementNode = xmlNode.SelectSingleNode("optionEntitlement");
            
            if (optionEntitlementNode != null)
            {
                if (optionEntitlementNode.Attributes["href"] != null || optionEntitlementNode.Attributes["id"] != null) 
                {
                    if (optionEntitlementNode.Attributes["id"] != null) 
                    {
                        optionEntitlementIDRef_ = optionEntitlementNode.Attributes["id"].Value;
                        PositiveDecimal ob = new PositiveDecimal(optionEntitlementNode);
                        IDManager.SetID(optionEntitlementIDRef_, ob);
                    }
                    else if (optionEntitlementNode.Attributes["href"] != null)
                    {
                        optionEntitlementIDRef_ = optionEntitlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        optionEntitlement_ = new PositiveDecimal(optionEntitlementNode);
                    }
                }
                else
                {
                    optionEntitlement_ = new PositiveDecimal(optionEntitlementNode);
                }
            }
            
        
            XmlNode equityPremiumNode = xmlNode.SelectSingleNode("equityPremium");
            
            if (equityPremiumNode != null)
            {
                if (equityPremiumNode.Attributes["href"] != null || equityPremiumNode.Attributes["id"] != null) 
                {
                    if (equityPremiumNode.Attributes["id"] != null) 
                    {
                        equityPremiumIDRef_ = equityPremiumNode.Attributes["id"].Value;
                        EquityPremium ob = new EquityPremium(equityPremiumNode);
                        IDManager.SetID(equityPremiumIDRef_, ob);
                    }
                    else if (equityPremiumNode.Attributes["href"] != null)
                    {
                        equityPremiumIDRef_ = equityPremiumNode.Attributes["href"].Value;
                    }
                    else
                    {
                        equityPremium_ = new EquityPremium(equityPremiumNode);
                    }
                }
                else
                {
                    equityPremium_ = new EquityPremium(equityPremiumNode);
                }
            }
            
        
        }
        
    
        #region Strike_
        private EquityStrike strike_;
        public EquityStrike Strike_
        {
            get
            {
                if (this.strike_ != null)
                {
                    return this.strike_; 
                }
                else if (this.strikeIDRef_ != null)
                {
                    strike_ = IDManager.getID(strikeIDRef_) as EquityStrike;
                    return this.strike_; 
                }
                else
                {
                      return this.strike_; 
                }
            }
            set
            {
                if (this.strike_ != value)
                {
                    this.strike_ = value;
                }
            }
        }
        #endregion
        
        public string strikeIDRef_ { get; set; }
        #region SpotPrice_
        private NonNegativeDecimal spotPrice_;
        public NonNegativeDecimal SpotPrice_
        {
            get
            {
                if (this.spotPrice_ != null)
                {
                    return this.spotPrice_; 
                }
                else if (this.spotPriceIDRef_ != null)
                {
                    spotPrice_ = IDManager.getID(spotPriceIDRef_) as NonNegativeDecimal;
                    return this.spotPrice_; 
                }
                else
                {
                      return this.spotPrice_; 
                }
            }
            set
            {
                if (this.spotPrice_ != value)
                {
                    this.spotPrice_ = value;
                }
            }
        }
        #endregion
        
        public string spotPriceIDRef_ { get; set; }
        #region NumberOfOptions_
        private NonNegativeDecimal numberOfOptions_;
        public NonNegativeDecimal NumberOfOptions_
        {
            get
            {
                if (this.numberOfOptions_ != null)
                {
                    return this.numberOfOptions_; 
                }
                else if (this.numberOfOptionsIDRef_ != null)
                {
                    numberOfOptions_ = IDManager.getID(numberOfOptionsIDRef_) as NonNegativeDecimal;
                    return this.numberOfOptions_; 
                }
                else
                {
                      return this.numberOfOptions_; 
                }
            }
            set
            {
                if (this.numberOfOptions_ != value)
                {
                    this.numberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string numberOfOptionsIDRef_ { get; set; }
        #region OptionEntitlement_
        private PositiveDecimal optionEntitlement_;
        public PositiveDecimal OptionEntitlement_
        {
            get
            {
                if (this.optionEntitlement_ != null)
                {
                    return this.optionEntitlement_; 
                }
                else if (this.optionEntitlementIDRef_ != null)
                {
                    optionEntitlement_ = IDManager.getID(optionEntitlementIDRef_) as PositiveDecimal;
                    return this.optionEntitlement_; 
                }
                else
                {
                      return this.optionEntitlement_; 
                }
            }
            set
            {
                if (this.optionEntitlement_ != value)
                {
                    this.optionEntitlement_ = value;
                }
            }
        }
        #endregion
        
        public string optionEntitlementIDRef_ { get; set; }
        #region EquityPremium_
        private EquityPremium equityPremium_;
        public EquityPremium EquityPremium_
        {
            get
            {
                if (this.equityPremium_ != null)
                {
                    return this.equityPremium_; 
                }
                else if (this.equityPremiumIDRef_ != null)
                {
                    equityPremium_ = IDManager.getID(equityPremiumIDRef_) as EquityPremium;
                    return this.equityPremium_; 
                }
                else
                {
                      return this.equityPremium_; 
                }
            }
            set
            {
                if (this.equityPremium_ != value)
                {
                    this.equityPremium_ = value;
                }
            }
        }
        #endregion
        
        public string equityPremiumIDRef_ { get; set; }
        
    
        
    
    }
    
}

