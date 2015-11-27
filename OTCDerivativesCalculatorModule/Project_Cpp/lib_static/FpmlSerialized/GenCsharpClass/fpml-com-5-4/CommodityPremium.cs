using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommodityPremium
    {
        public CommodityPremium(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList premiumPerUnitNodeList = xmlNode.SelectNodes("premiumPerUnit");
            if (premiumPerUnitNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in premiumPerUnitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        premiumPerUnitIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(premiumPerUnitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        premiumPerUnitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        premiumPerUnit = new NonNegativeMoney(item);
                    }
                }
            }
            
        
        }
        
    
        #region PremiumPerUnit
        private NonNegativeMoney premiumPerUnit;
        public NonNegativeMoney PremiumPerUnit
        {
            get
            {
                if (this.premiumPerUnit != null)
                {
                    return this.premiumPerUnit; 
                }
                else if (this.premiumPerUnitIDRef != null)
                {
                    premiumPerUnit = IDManager.getID(premiumPerUnitIDRef) as NonNegativeMoney;
                    return this.premiumPerUnit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.premiumPerUnit != value)
                {
                    this.premiumPerUnit = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        
    
        
    
    }
    
}

