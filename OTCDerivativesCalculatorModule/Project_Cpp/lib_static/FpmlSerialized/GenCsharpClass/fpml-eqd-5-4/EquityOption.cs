using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class EquityOption
    {
        public EquityOption(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList strikeNodeList = xmlNode.SelectNodes("strike");
            if (strikeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in strikeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        strikeIDRef = item.Attributes["id"].Name;
                        EquityStrike ob = EquityStrike();
                        IDManager.SetID(strikeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        strikeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        strike = new EquityStrike(item);
                    }
                }
            }
            
        
            XmlNodeList spotPriceNodeList = xmlNode.SelectNodes("spotPrice");
            if (spotPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spotPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spotPriceIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(spotPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spotPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spotPrice = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList numberOfOptionsNodeList = xmlNode.SelectNodes("numberOfOptions");
            if (numberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in numberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        numberOfOptionsIDRef = item.Attributes["id"].Name;
                        NonNegativeDecimal ob = NonNegativeDecimal();
                        IDManager.SetID(numberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        numberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        numberOfOptions = new NonNegativeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList optionEntitlementNodeList = xmlNode.SelectNodes("optionEntitlement");
            if (optionEntitlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionEntitlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionEntitlementIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(optionEntitlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionEntitlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionEntitlement = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList equityPremiumNodeList = xmlNode.SelectNodes("equityPremium");
            if (equityPremiumNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityPremiumNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityPremiumIDRef = item.Attributes["id"].Name;
                        EquityPremium ob = EquityPremium();
                        IDManager.SetID(equityPremiumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityPremiumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityPremium = new EquityPremium(item);
                    }
                }
            }
            
        
        }
        
    
        #region Strike
        private EquityStrike strike;
        public EquityStrike Strike
        {
            get
            {
                if (this.strike != null)
                {
                    return this.strike; 
                }
                else if (this.strikeIDRef != null)
                {
                    strike = IDManager.getID(strikeIDRef) as EquityStrike;
                    return this.strike; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.strike != value)
                {
                    this.strike = value;
                }
            }
        }
        #endregion
        
        public string EquityStrikeIDRef { get; set; }
        #region SpotPrice
        private NonNegativeDecimal spotPrice;
        public NonNegativeDecimal SpotPrice
        {
            get
            {
                if (this.spotPrice != null)
                {
                    return this.spotPrice; 
                }
                else if (this.spotPriceIDRef != null)
                {
                    spotPrice = IDManager.getID(spotPriceIDRef) as NonNegativeDecimal;
                    return this.spotPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spotPrice != value)
                {
                    this.spotPrice = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region NumberOfOptions
        private NonNegativeDecimal numberOfOptions;
        public NonNegativeDecimal NumberOfOptions
        {
            get
            {
                if (this.numberOfOptions != null)
                {
                    return this.numberOfOptions; 
                }
                else if (this.numberOfOptionsIDRef != null)
                {
                    numberOfOptions = IDManager.getID(numberOfOptionsIDRef) as NonNegativeDecimal;
                    return this.numberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.numberOfOptions != value)
                {
                    this.numberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeDecimalIDRef { get; set; }
        #region OptionEntitlement
        private PositiveDecimal optionEntitlement;
        public PositiveDecimal OptionEntitlement
        {
            get
            {
                if (this.optionEntitlement != null)
                {
                    return this.optionEntitlement; 
                }
                else if (this.optionEntitlementIDRef != null)
                {
                    optionEntitlement = IDManager.getID(optionEntitlementIDRef) as PositiveDecimal;
                    return this.optionEntitlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionEntitlement != value)
                {
                    this.optionEntitlement = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region EquityPremium
        private EquityPremium equityPremium;
        public EquityPremium EquityPremium
        {
            get
            {
                if (this.equityPremium != null)
                {
                    return this.equityPremium; 
                }
                else if (this.equityPremiumIDRef != null)
                {
                    equityPremium = IDManager.getID(equityPremiumIDRef) as EquityPremium;
                    return this.equityPremium; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityPremium != value)
                {
                    this.equityPremium = value;
                }
            }
        }
        #endregion
        
        public string EquityPremiumIDRef { get; set; }
        
    
        
    
    }
    
}

