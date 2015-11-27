using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Portfolio
    {
        public Portfolio(XmlNode xmlNode)
        {
            XmlNodeList partyPortfolioNameNodeList = xmlNode.SelectNodes("partyPortfolioName");
            if (partyPortfolioNameNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyPortfolioNameNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyPortfolioNameIDRef = item.Attributes["id"].Name;
                        PartyPortfolioName ob = PartyPortfolioName();
                        IDManager.SetID(partyPortfolioNameIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyPortfolioNameIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyPortfolioName = new PartyPortfolioName(item);
                    }
                }
            }
            
        
            XmlNodeList tradeIdNodeList = xmlNode.SelectNodes("tradeId");
            
            foreach (XmlNode item in tradeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        tradeIdIDRef = item.Attributes["id"].Name;
                        List<TradeId> ob = new List<TradeId>();
                        ob.Add(new TradeId(item));
                        IDManager.SetID(tradeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        tradeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    tradeId.Add(new TradeId(item));
                    }
                }
            }
            
        
            XmlNodeList partyTradeIdentifierNodeList = xmlNode.SelectNodes("partyTradeIdentifier");
            
            foreach (XmlNode item in partyTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyTradeIdentifierIDRef = item.Attributes["id"].Name;
                        List<PartyTradeIdentifier> ob = new List<PartyTradeIdentifier>();
                        ob.Add(new PartyTradeIdentifier(item));
                        IDManager.SetID(partyTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    partyTradeIdentifier.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList portfolioNodeList = xmlNode.SelectNodes("portfolio");
            
            foreach (XmlNode item in portfolioNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        portfolioIDRef = item.Attributes["id"].Name;
                        List<Portfolio> ob = new List<Portfolio>();
                        ob.Add(new Portfolio(item));
                        IDManager.SetID(portfolioIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        portfolioIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    portfolio.Add(new Portfolio(item));
                    }
                }
            }
            
        
        }
        
    
        #region PartyPortfolioName
        private PartyPortfolioName partyPortfolioName;
        public PartyPortfolioName PartyPortfolioName
        {
            get
            {
                if (this.partyPortfolioName != null)
                {
                    return this.partyPortfolioName; 
                }
                else if (this.partyPortfolioNameIDRef != null)
                {
                    partyPortfolioName = IDManager.getID(partyPortfolioNameIDRef) as PartyPortfolioName;
                    return this.partyPortfolioName; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyPortfolioName != value)
                {
                    this.partyPortfolioName = value;
                }
            }
        }
        #endregion
        
        public string PartyPortfolioNameIDRef { get; set; }
        #region TradeId
        private List<TradeId> tradeId;
        public List<TradeId> TradeId
        {
            get
            {
                if (this.tradeId != null)
                {
                    return this.tradeId; 
                }
                else if (this.tradeIdIDRef != null)
                {
                    tradeId = IDManager.getID(tradeIdIDRef) as List<TradeId>;
                    return this.tradeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.tradeId != value)
                {
                    this.tradeId = value;
                }
            }
        }
        #endregion
        
        public string TradeIdIDRef { get; set; }
        #region PartyTradeIdentifier
        private List<PartyTradeIdentifier> partyTradeIdentifier;
        public List<PartyTradeIdentifier> PartyTradeIdentifier
        {
            get
            {
                if (this.partyTradeIdentifier != null)
                {
                    return this.partyTradeIdentifier; 
                }
                else if (this.partyTradeIdentifierIDRef != null)
                {
                    partyTradeIdentifier = IDManager.getID(partyTradeIdentifierIDRef) as List<PartyTradeIdentifier>;
                    return this.partyTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyTradeIdentifier != value)
                {
                    this.partyTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        #region Portfolio
        private List<Portfolio> portfolio;
        public List<Portfolio> Portfolio
        {
            get
            {
                if (this.portfolio != null)
                {
                    return this.portfolio; 
                }
                else if (this.portfolioIDRef != null)
                {
                    portfolio = IDManager.getID(portfolioIDRef) as List<Portfolio>;
                    return this.portfolio; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.portfolio != value)
                {
                    this.portfolio = value;
                }
            }
        }
        #endregion
        
        public string PortfolioIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

