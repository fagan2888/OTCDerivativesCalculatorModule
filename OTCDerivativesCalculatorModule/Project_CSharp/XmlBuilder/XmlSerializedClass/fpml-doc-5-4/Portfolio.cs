using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Portfolio : ISerialized
    {
        public Portfolio(XmlNode xmlNode)
        {
            XmlNode partyPortfolioNameNode = xmlNode.SelectSingleNode("partyPortfolioName");
            
            if (partyPortfolioNameNode != null)
            {
                if (partyPortfolioNameNode.Attributes["href"] != null || partyPortfolioNameNode.Attributes["id"] != null) 
                {
                    if (partyPortfolioNameNode.Attributes["id"] != null) 
                    {
                        partyPortfolioNameIDRef_ = partyPortfolioNameNode.Attributes["id"].Value;
                        PartyPortfolioName ob = new PartyPortfolioName(partyPortfolioNameNode);
                        IDManager.SetID(partyPortfolioNameIDRef_, ob);
                    }
                    else if (partyPortfolioNameNode.Attributes["href"] != null)
                    {
                        partyPortfolioNameIDRef_ = partyPortfolioNameNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyPortfolioName_ = new PartyPortfolioName(partyPortfolioNameNode);
                    }
                }
                else
                {
                    partyPortfolioName_ = new PartyPortfolioName(partyPortfolioNameNode);
                }
            }
            
        
            XmlNodeList tradeIdNodeList = xmlNode.SelectNodes("tradeId");
            
            if (tradeIdNodeList != null)
            {
                this.tradeId_ = new List<TradeId>();
                foreach (XmlNode item in tradeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            tradeIdIDRef_ = item.Attributes["id"].Value;
                            tradeId_.Add(new TradeId(item));
                            IDManager.SetID(tradeIdIDRef_, tradeId_[tradeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            tradeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        tradeId_.Add(new TradeId(item));
                        }
                    }
                    else
                    {
                        tradeId_.Add(new TradeId(item));
                    }
                }
            }
            
        
            XmlNodeList partyTradeIdentifierNodeList = xmlNode.SelectNodes("partyTradeIdentifier");
            
            if (partyTradeIdentifierNodeList != null)
            {
                this.partyTradeIdentifier_ = new List<PartyTradeIdentifier>();
                foreach (XmlNode item in partyTradeIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyTradeIdentifierIDRef_ = item.Attributes["id"].Value;
                            partyTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                            IDManager.SetID(partyTradeIdentifierIDRef_, partyTradeIdentifier_[partyTradeIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyTradeIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        partyTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                        }
                    }
                    else
                    {
                        partyTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList portfolioNodeList = xmlNode.SelectNodes("portfolio");
            
            if (portfolioNodeList != null)
            {
                this.portfolio_ = new List<Portfolio>();
                foreach (XmlNode item in portfolioNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            portfolioIDRef_ = item.Attributes["id"].Value;
                            portfolio_.Add(new Portfolio(item));
                            IDManager.SetID(portfolioIDRef_, portfolio_[portfolio_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            portfolioIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        portfolio_.Add(new Portfolio(item));
                        }
                    }
                    else
                    {
                        portfolio_.Add(new Portfolio(item));
                    }
                }
            }
            
        
        }
        
    
        #region PartyPortfolioName_
        private PartyPortfolioName partyPortfolioName_;
        public PartyPortfolioName PartyPortfolioName_
        {
            get
            {
                if (this.partyPortfolioName_ != null)
                {
                    return this.partyPortfolioName_; 
                }
                else if (this.partyPortfolioNameIDRef_ != null)
                {
                    partyPortfolioName_ = IDManager.getID(partyPortfolioNameIDRef_) as PartyPortfolioName;
                    return this.partyPortfolioName_; 
                }
                else
                {
                      return this.partyPortfolioName_; 
                }
            }
            set
            {
                if (this.partyPortfolioName_ != value)
                {
                    this.partyPortfolioName_ = value;
                }
            }
        }
        #endregion
        
        public string partyPortfolioNameIDRef_ { get; set; }
        #region TradeId_
        private List<TradeId> tradeId_;
        public List<TradeId> TradeId_
        {
            get
            {
                if (this.tradeId_ != null)
                {
                    return this.tradeId_; 
                }
                else if (this.tradeIdIDRef_ != null)
                {
                    return this.tradeId_; 
                }
                else
                {
                      return this.tradeId_; 
                }
            }
            set
            {
                if (this.tradeId_ != value)
                {
                    this.tradeId_ = value;
                }
            }
        }
        #endregion
        
        public string tradeIdIDRef_ { get; set; }
        #region PartyTradeIdentifier_
        private List<PartyTradeIdentifier> partyTradeIdentifier_;
        public List<PartyTradeIdentifier> PartyTradeIdentifier_
        {
            get
            {
                if (this.partyTradeIdentifier_ != null)
                {
                    return this.partyTradeIdentifier_; 
                }
                else if (this.partyTradeIdentifierIDRef_ != null)
                {
                    return this.partyTradeIdentifier_; 
                }
                else
                {
                      return this.partyTradeIdentifier_; 
                }
            }
            set
            {
                if (this.partyTradeIdentifier_ != value)
                {
                    this.partyTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string partyTradeIdentifierIDRef_ { get; set; }
        #region Portfolio_
        private List<Portfolio> portfolio_;
        public List<Portfolio> Portfolio_
        {
            get
            {
                if (this.portfolio_ != null)
                {
                    return this.portfolio_; 
                }
                else if (this.portfolioIDRef_ != null)
                {
                    return this.portfolio_; 
                }
                else
                {
                      return this.portfolio_; 
                }
            }
            set
            {
                if (this.portfolio_ != value)
                {
                    this.portfolio_ = value;
                }
            }
        }
        #endregion
        
        public string portfolioIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

