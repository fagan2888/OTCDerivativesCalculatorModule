using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Withdrawal : ISerialized
    {
        public Withdrawal(XmlNode xmlNode)
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
            
        
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new XsdTypeDate(effectiveDateNode);
                }
            }
            
        
            XmlNode requestedActionNode = xmlNode.SelectSingleNode("requestedAction");
            
            if (requestedActionNode != null)
            {
                if (requestedActionNode.Attributes["href"] != null || requestedActionNode.Attributes["id"] != null) 
                {
                    if (requestedActionNode.Attributes["id"] != null) 
                    {
                        requestedActionIDRef_ = requestedActionNode.Attributes["id"].Value;
                        RequestedWithdrawalAction ob = new RequestedWithdrawalAction(requestedActionNode);
                        IDManager.SetID(requestedActionIDRef_, ob);
                    }
                    else if (requestedActionNode.Attributes["href"] != null)
                    {
                        requestedActionIDRef_ = requestedActionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        requestedAction_ = new RequestedWithdrawalAction(requestedActionNode);
                    }
                }
                else
                {
                    requestedAction_ = new RequestedWithdrawalAction(requestedActionNode);
                }
            }
            
        
            XmlNodeList reasonNodeList = xmlNode.SelectNodes("reason");
            
            if (reasonNodeList != null)
            {
                this.reason_ = new List<WithdrawalReason>();
                foreach (XmlNode item in reasonNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            reasonIDRef_ = item.Attributes["id"].Value;
                            reason_.Add(new WithdrawalReason(item));
                            IDManager.SetID(reasonIDRef_, reason_[reason_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            reasonIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        reason_.Add(new WithdrawalReason(item));
                        }
                    }
                    else
                    {
                        reason_.Add(new WithdrawalReason(item));
                    }
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
        #region EffectiveDate_
        private XsdTypeDate effectiveDate_;
        public XsdTypeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as XsdTypeDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region RequestedAction_
        private RequestedWithdrawalAction requestedAction_;
        public RequestedWithdrawalAction RequestedAction_
        {
            get
            {
                if (this.requestedAction_ != null)
                {
                    return this.requestedAction_; 
                }
                else if (this.requestedActionIDRef_ != null)
                {
                    requestedAction_ = IDManager.getID(requestedActionIDRef_) as RequestedWithdrawalAction;
                    return this.requestedAction_; 
                }
                else
                {
                      return this.requestedAction_; 
                }
            }
            set
            {
                if (this.requestedAction_ != value)
                {
                    this.requestedAction_ = value;
                }
            }
        }
        #endregion
        
        public string requestedActionIDRef_ { get; set; }
        #region Reason_
        private List<WithdrawalReason> reason_;
        public List<WithdrawalReason> Reason_
        {
            get
            {
                if (this.reason_ != null)
                {
                    return this.reason_; 
                }
                else if (this.reasonIDRef_ != null)
                {
                    return this.reason_; 
                }
                else
                {
                      return this.reason_; 
                }
            }
            set
            {
                if (this.reason_ != value)
                {
                    this.reason_ = value;
                }
            }
        }
        #endregion
        
        public string reasonIDRef_ { get; set; }
        
    
        
    
    }
    
}

