using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AllocationApproved : ResponseMessage
    {
        public AllocationApproved(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode blockTradeIdentifierNode = xmlNode.SelectSingleNode("blockTradeIdentifier");
            
            if (blockTradeIdentifierNode != null)
            {
                if (blockTradeIdentifierNode.Attributes["href"] != null || blockTradeIdentifierNode.Attributes["id"] != null) 
                {
                    if (blockTradeIdentifierNode.Attributes["id"] != null) 
                    {
                        blockTradeIdentifierIDRef_ = blockTradeIdentifierNode.Attributes["id"].Value;
                        TradeIdentifier ob = new TradeIdentifier(blockTradeIdentifierNode);
                        IDManager.SetID(blockTradeIdentifierIDRef_, ob);
                    }
                    else if (blockTradeIdentifierNode.Attributes["href"] != null)
                    {
                        blockTradeIdentifierIDRef_ = blockTradeIdentifierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        blockTradeIdentifier_ = new TradeIdentifier(blockTradeIdentifierNode);
                    }
                }
                else
                {
                    blockTradeIdentifier_ = new TradeIdentifier(blockTradeIdentifierNode);
                }
            }
            
        
            XmlNode allocationsNode = xmlNode.SelectSingleNode("allocations");
            
            if (allocationsNode != null)
            {
                if (allocationsNode.Attributes["href"] != null || allocationsNode.Attributes["id"] != null) 
                {
                    if (allocationsNode.Attributes["id"] != null) 
                    {
                        allocationsIDRef_ = allocationsNode.Attributes["id"].Value;
                        Allocations ob = new Allocations(allocationsNode);
                        IDManager.SetID(allocationsIDRef_, ob);
                    }
                    else if (allocationsNode.Attributes["href"] != null)
                    {
                        allocationsIDRef_ = allocationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allocations_ = new Allocations(allocationsNode);
                    }
                }
                else
                {
                    allocations_ = new Allocations(allocationsNode);
                }
            }
            
        
            XmlNodeList partyNodeList = xmlNode.SelectNodes("party");
            
            if (partyNodeList != null)
            {
                this.party_ = new List<Party>();
                foreach (XmlNode item in partyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            partyIDRef_ = item.Attributes["id"].Value;
                            party_.Add(new Party(item));
                            IDManager.SetID(partyIDRef_, party_[party_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            partyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        party_.Add(new Party(item));
                        }
                    }
                    else
                    {
                        party_.Add(new Party(item));
                    }
                }
            }
            
        
            XmlNodeList accountNodeList = xmlNode.SelectNodes("account");
            
            if (accountNodeList != null)
            {
                this.account_ = new List<Account>();
                foreach (XmlNode item in accountNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            accountIDRef_ = item.Attributes["id"].Value;
                            account_.Add(new Account(item));
                            IDManager.SetID(accountIDRef_, account_[account_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            accountIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        account_.Add(new Account(item));
                        }
                    }
                    else
                    {
                        account_.Add(new Account(item));
                    }
                }
            }
            
        
        }
        
    
        #region BlockTradeIdentifier_
        private TradeIdentifier blockTradeIdentifier_;
        public TradeIdentifier BlockTradeIdentifier_
        {
            get
            {
                if (this.blockTradeIdentifier_ != null)
                {
                    return this.blockTradeIdentifier_; 
                }
                else if (this.blockTradeIdentifierIDRef_ != null)
                {
                    blockTradeIdentifier_ = IDManager.getID(blockTradeIdentifierIDRef_) as TradeIdentifier;
                    return this.blockTradeIdentifier_; 
                }
                else
                {
                      return this.blockTradeIdentifier_; 
                }
            }
            set
            {
                if (this.blockTradeIdentifier_ != value)
                {
                    this.blockTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string blockTradeIdentifierIDRef_ { get; set; }
        #region Allocations_
        private Allocations allocations_;
        public Allocations Allocations_
        {
            get
            {
                if (this.allocations_ != null)
                {
                    return this.allocations_; 
                }
                else if (this.allocationsIDRef_ != null)
                {
                    allocations_ = IDManager.getID(allocationsIDRef_) as Allocations;
                    return this.allocations_; 
                }
                else
                {
                      return this.allocations_; 
                }
            }
            set
            {
                if (this.allocations_ != value)
                {
                    this.allocations_ = value;
                }
            }
        }
        #endregion
        
        public string allocationsIDRef_ { get; set; }
        #region Party_
        private List<Party> party_;
        public List<Party> Party_
        {
            get
            {
                if (this.party_ != null)
                {
                    return this.party_; 
                }
                else if (this.partyIDRef_ != null)
                {
                    return this.party_; 
                }
                else
                {
                      return this.party_; 
                }
            }
            set
            {
                if (this.party_ != value)
                {
                    this.party_ = value;
                }
            }
        }
        #endregion
        
        public string partyIDRef_ { get; set; }
        #region Account_
        private List<Account> account_;
        public List<Account> Account_
        {
            get
            {
                if (this.account_ != null)
                {
                    return this.account_; 
                }
                else if (this.accountIDRef_ != null)
                {
                    return this.account_; 
                }
                else
                {
                      return this.account_; 
                }
            }
            set
            {
                if (this.account_ != value)
                {
                    this.account_ = value;
                }
            }
        }
        #endregion
        
        public string accountIDRef_ { get; set; }
        
    
        
    
    }
    
}

