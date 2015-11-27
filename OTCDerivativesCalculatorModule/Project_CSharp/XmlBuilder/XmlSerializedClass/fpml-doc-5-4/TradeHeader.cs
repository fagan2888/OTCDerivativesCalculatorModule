using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeHeader : ISerialized
    {
        public TradeHeader(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList partyTradeInformationNodeList = xmlNode.SelectNodes("partyTradeInformation");
            
            if (partyTradeInformationNodeList != null)
            {
                this.partyTradeInformation_ = new List<PartyTradeInformation>();
                foreach (XmlNode item in partyTradeInformationNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyTradeInformationIDRef_ = item.Attributes["id"].Value;
                            partyTradeInformation_.Add(new PartyTradeInformation(item));
                            IDManager.SetID(partyTradeInformationIDRef_, partyTradeInformation_[partyTradeInformation_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyTradeInformationIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        partyTradeInformation_.Add(new PartyTradeInformation(item));
                        }
                    }
                    else
                    {
                        partyTradeInformation_.Add(new PartyTradeInformation(item));
                    }
                }
            }
            
        
            XmlNode tradeDateNode = xmlNode.SelectSingleNode("tradeDate");
            
            if (tradeDateNode != null)
            {
                if (tradeDateNode.Attributes["href"] != null || tradeDateNode.Attributes["id"] != null) 
                {
                    if (tradeDateNode.Attributes["id"] != null) 
                    {
                        tradeDateIDRef_ = tradeDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(tradeDateNode);
                        IDManager.SetID(tradeDateIDRef_, ob);
                    }
                    else if (tradeDateNode.Attributes["href"] != null)
                    {
                        tradeDateIDRef_ = tradeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeDate_ = new IdentifiedDate(tradeDateNode);
                    }
                }
                else
                {
                    tradeDate_ = new IdentifiedDate(tradeDateNode);
                }
            }
            
        
            XmlNode clearedDateNode = xmlNode.SelectSingleNode("clearedDate");
            
            if (clearedDateNode != null)
            {
                if (clearedDateNode.Attributes["href"] != null || clearedDateNode.Attributes["id"] != null) 
                {
                    if (clearedDateNode.Attributes["id"] != null) 
                    {
                        clearedDateIDRef_ = clearedDateNode.Attributes["id"].Value;
                        IdentifiedDate ob = new IdentifiedDate(clearedDateNode);
                        IDManager.SetID(clearedDateIDRef_, ob);
                    }
                    else if (clearedDateNode.Attributes["href"] != null)
                    {
                        clearedDateIDRef_ = clearedDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        clearedDate_ = new IdentifiedDate(clearedDateNode);
                    }
                }
                else
                {
                    clearedDate_ = new IdentifiedDate(clearedDateNode);
                }
            }
            
        
        }
        
    
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
        #region PartyTradeInformation_
        private List<PartyTradeInformation> partyTradeInformation_;
        public List<PartyTradeInformation> PartyTradeInformation_
        {
            get
            {
                if (this.partyTradeInformation_ != null)
                {
                    return this.partyTradeInformation_; 
                }
                else if (this.partyTradeInformationIDRef_ != null)
                {
                    return this.partyTradeInformation_; 
                }
                else
                {
                      return this.partyTradeInformation_; 
                }
            }
            set
            {
                if (this.partyTradeInformation_ != value)
                {
                    this.partyTradeInformation_ = value;
                }
            }
        }
        #endregion
        
        public string partyTradeInformationIDRef_ { get; set; }
        #region TradeDate_
        private IdentifiedDate tradeDate_;
        public IdentifiedDate TradeDate_
        {
            get
            {
                if (this.tradeDate_ != null)
                {
                    return this.tradeDate_; 
                }
                else if (this.tradeDateIDRef_ != null)
                {
                    tradeDate_ = IDManager.getID(tradeDateIDRef_) as IdentifiedDate;
                    return this.tradeDate_; 
                }
                else
                {
                      return this.tradeDate_; 
                }
            }
            set
            {
                if (this.tradeDate_ != value)
                {
                    this.tradeDate_ = value;
                }
            }
        }
        #endregion
        
        public string tradeDateIDRef_ { get; set; }
        #region ClearedDate_
        private IdentifiedDate clearedDate_;
        public IdentifiedDate ClearedDate_
        {
            get
            {
                if (this.clearedDate_ != null)
                {
                    return this.clearedDate_; 
                }
                else if (this.clearedDateIDRef_ != null)
                {
                    clearedDate_ = IDManager.getID(clearedDateIDRef_) as IdentifiedDate;
                    return this.clearedDate_; 
                }
                else
                {
                      return this.clearedDate_; 
                }
            }
            set
            {
                if (this.clearedDate_ != value)
                {
                    this.clearedDate_ = value;
                }
            }
        }
        #endregion
        
        public string clearedDateIDRef_ { get; set; }
        
    
        
    
    }
    
}

