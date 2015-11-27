using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FxOptionPremium
    {
        public FxOptionPremium(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList settlementInformationNodeList = xmlNode.SelectNodes("settlementInformation");
            if (settlementInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementInformationIDRef = item.Attributes["id"].Name;
                        SettlementInformation ob = SettlementInformation();
                        IDManager.SetID(settlementInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementInformation = new SettlementInformation(item);
                    }
                }
            }
            
        
            XmlNodeList quoteNodeList = xmlNode.SelectNodes("quote");
            if (quoteNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quoteNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quoteIDRef = item.Attributes["id"].Name;
                        PremiumQuote ob = PremiumQuote();
                        IDManager.SetID(quoteIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quoteIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quote = new PremiumQuote(item);
                    }
                }
            }
            
        
        }
        
    
        #region SettlementInformation
        private SettlementInformation settlementInformation;
        public SettlementInformation SettlementInformation
        {
            get
            {
                if (this.settlementInformation != null)
                {
                    return this.settlementInformation; 
                }
                else if (this.settlementInformationIDRef != null)
                {
                    settlementInformation = IDManager.getID(settlementInformationIDRef) as SettlementInformation;
                    return this.settlementInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementInformation != value)
                {
                    this.settlementInformation = value;
                }
            }
        }
        #endregion
        
        public string SettlementInformationIDRef { get; set; }
        #region Quote
        private PremiumQuote quote;
        public PremiumQuote Quote
        {
            get
            {
                if (this.quote != null)
                {
                    return this.quote; 
                }
                else if (this.quoteIDRef != null)
                {
                    quote = IDManager.getID(quoteIDRef) as PremiumQuote;
                    return this.quote; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quote != value)
                {
                    this.quote = value;
                }
            }
        }
        #endregion
        
        public string PremiumQuoteIDRef { get; set; }
        
    
        
    
    }
    
}

