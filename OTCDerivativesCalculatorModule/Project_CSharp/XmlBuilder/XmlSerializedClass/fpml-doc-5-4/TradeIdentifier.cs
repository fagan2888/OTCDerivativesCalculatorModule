using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeIdentifier : ISerialized
    {
        public TradeIdentifier(XmlNode xmlNode)
        {
            XmlNode issuerNode = xmlNode.SelectSingleNode("issuer");
            
            if (issuerNode != null)
            {
                if (issuerNode.Attributes["href"] != null || issuerNode.Attributes["id"] != null) 
                {
                    if (issuerNode.Attributes["id"] != null) 
                    {
                        issuerIDRef_ = issuerNode.Attributes["id"].Value;
                        IssuerId ob = new IssuerId(issuerNode);
                        IDManager.SetID(issuerIDRef_, ob);
                    }
                    else if (issuerNode.Attributes["href"] != null)
                    {
                        issuerIDRef_ = issuerNode.Attributes["href"].Value;
                    }
                    else
                    {
                        issuer_ = new IssuerId(issuerNode);
                    }
                }
                else
                {
                    issuer_ = new IssuerId(issuerNode);
                }
            }
            
        
            XmlNode tradeIdNode = xmlNode.SelectSingleNode("tradeId");
            
            if (tradeIdNode != null)
            {
                if (tradeIdNode.Attributes["href"] != null || tradeIdNode.Attributes["id"] != null) 
                {
                    if (tradeIdNode.Attributes["id"] != null) 
                    {
                        tradeIdIDRef_ = tradeIdNode.Attributes["id"].Value;
                        TradeId ob = new TradeId(tradeIdNode);
                        IDManager.SetID(tradeIdIDRef_, ob);
                    }
                    else if (tradeIdNode.Attributes["href"] != null)
                    {
                        tradeIdIDRef_ = tradeIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        tradeId_ = new TradeId(tradeIdNode);
                    }
                }
                else
                {
                    tradeId_ = new TradeId(tradeIdNode);
                }
            }
            
        
            XmlNode partyReferenceNode = xmlNode.SelectSingleNode("partyReference");
            
            if (partyReferenceNode != null)
            {
                if (partyReferenceNode.Attributes["href"] != null || partyReferenceNode.Attributes["id"] != null) 
                {
                    if (partyReferenceNode.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(partyReferenceNode);
                        IDManager.SetID(partyReferenceIDRef_, ob);
                    }
                    else if (partyReferenceNode.Attributes["href"] != null)
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyReference_ = new PartyReference(partyReferenceNode);
                    }
                }
                else
                {
                    partyReference_ = new PartyReference(partyReferenceNode);
                }
            }
            
        
            XmlNode accountReferenceNode = xmlNode.SelectSingleNode("accountReference");
            
            if (accountReferenceNode != null)
            {
                if (accountReferenceNode.Attributes["href"] != null || accountReferenceNode.Attributes["id"] != null) 
                {
                    if (accountReferenceNode.Attributes["id"] != null) 
                    {
                        accountReferenceIDRef_ = accountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(accountReferenceNode);
                        IDManager.SetID(accountReferenceIDRef_, ob);
                    }
                    else if (accountReferenceNode.Attributes["href"] != null)
                    {
                        accountReferenceIDRef_ = accountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accountReference_ = new AccountReference(accountReferenceNode);
                    }
                }
                else
                {
                    accountReference_ = new AccountReference(accountReferenceNode);
                }
            }
            
        
            XmlNode versionedTradeIdNode = xmlNode.SelectSingleNode("versionedTradeId");
            
            if (versionedTradeIdNode != null)
            {
                if (versionedTradeIdNode.Attributes["href"] != null || versionedTradeIdNode.Attributes["id"] != null) 
                {
                    if (versionedTradeIdNode.Attributes["id"] != null) 
                    {
                        versionedTradeIdIDRef_ = versionedTradeIdNode.Attributes["id"].Value;
                        VersionedTradeId ob = new VersionedTradeId(versionedTradeIdNode);
                        IDManager.SetID(versionedTradeIdIDRef_, ob);
                    }
                    else if (versionedTradeIdNode.Attributes["href"] != null)
                    {
                        versionedTradeIdIDRef_ = versionedTradeIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        versionedTradeId_ = new VersionedTradeId(versionedTradeIdNode);
                    }
                }
                else
                {
                    versionedTradeId_ = new VersionedTradeId(versionedTradeIdNode);
                }
            }
            
        
        }
        
    
        #region Issuer_
        private IssuerId issuer_;
        public IssuerId Issuer_
        {
            get
            {
                if (this.issuer_ != null)
                {
                    return this.issuer_; 
                }
                else if (this.issuerIDRef_ != null)
                {
                    issuer_ = IDManager.getID(issuerIDRef_) as IssuerId;
                    return this.issuer_; 
                }
                else
                {
                      return this.issuer_; 
                }
            }
            set
            {
                if (this.issuer_ != value)
                {
                    this.issuer_ = value;
                }
            }
        }
        #endregion
        
        public string issuerIDRef_ { get; set; }
        #region TradeId_
        private TradeId tradeId_;
        public TradeId TradeId_
        {
            get
            {
                if (this.tradeId_ != null)
                {
                    return this.tradeId_; 
                }
                else if (this.tradeIdIDRef_ != null)
                {
                    tradeId_ = IDManager.getID(tradeIdIDRef_) as TradeId;
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
        #region PartyReference_
        private PartyReference partyReference_;
        public PartyReference PartyReference_
        {
            get
            {
                if (this.partyReference_ != null)
                {
                    return this.partyReference_; 
                }
                else if (this.partyReferenceIDRef_ != null)
                {
                    partyReference_ = IDManager.getID(partyReferenceIDRef_) as PartyReference;
                    return this.partyReference_; 
                }
                else
                {
                      return this.partyReference_; 
                }
            }
            set
            {
                if (this.partyReference_ != value)
                {
                    this.partyReference_ = value;
                }
            }
        }
        #endregion
        
        public string partyReferenceIDRef_ { get; set; }
        #region AccountReference_
        private AccountReference accountReference_;
        public AccountReference AccountReference_
        {
            get
            {
                if (this.accountReference_ != null)
                {
                    return this.accountReference_; 
                }
                else if (this.accountReferenceIDRef_ != null)
                {
                    accountReference_ = IDManager.getID(accountReferenceIDRef_) as AccountReference;
                    return this.accountReference_; 
                }
                else
                {
                      return this.accountReference_; 
                }
            }
            set
            {
                if (this.accountReference_ != value)
                {
                    this.accountReference_ = value;
                }
            }
        }
        #endregion
        
        public string accountReferenceIDRef_ { get; set; }
        #region VersionedTradeId_
        private VersionedTradeId versionedTradeId_;
        public VersionedTradeId VersionedTradeId_
        {
            get
            {
                if (this.versionedTradeId_ != null)
                {
                    return this.versionedTradeId_; 
                }
                else if (this.versionedTradeIdIDRef_ != null)
                {
                    versionedTradeId_ = IDManager.getID(versionedTradeIdIDRef_) as VersionedTradeId;
                    return this.versionedTradeId_; 
                }
                else
                {
                      return this.versionedTradeId_; 
                }
            }
            set
            {
                if (this.versionedTradeId_ != value)
                {
                    this.versionedTradeId_ = value;
                }
            }
        }
        #endregion
        
        public string versionedTradeIdIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

