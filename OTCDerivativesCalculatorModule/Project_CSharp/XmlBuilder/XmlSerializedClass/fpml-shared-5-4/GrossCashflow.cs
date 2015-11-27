using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GrossCashflow : ISerialized
    {
        public GrossCashflow(XmlNode xmlNode)
        {
            XmlNode cashflowIdNode = xmlNode.SelectSingleNode("cashflowId");
            
            if (cashflowIdNode != null)
            {
                if (cashflowIdNode.Attributes["href"] != null || cashflowIdNode.Attributes["id"] != null) 
                {
                    if (cashflowIdNode.Attributes["id"] != null) 
                    {
                        cashflowIdIDRef_ = cashflowIdNode.Attributes["id"].Value;
                        CashflowId ob = new CashflowId(cashflowIdNode);
                        IDManager.SetID(cashflowIdIDRef_, ob);
                    }
                    else if (cashflowIdNode.Attributes["href"] != null)
                    {
                        cashflowIdIDRef_ = cashflowIdNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashflowId_ = new CashflowId(cashflowIdNode);
                    }
                }
                else
                {
                    cashflowId_ = new CashflowId(cashflowIdNode);
                }
            }
            
        
            XmlNode partyTradeIdentifierReferenceNode = xmlNode.SelectSingleNode("partyTradeIdentifierReference");
            
            if (partyTradeIdentifierReferenceNode != null)
            {
                if (partyTradeIdentifierReferenceNode.Attributes["href"] != null || partyTradeIdentifierReferenceNode.Attributes["id"] != null) 
                {
                    if (partyTradeIdentifierReferenceNode.Attributes["id"] != null) 
                    {
                        partyTradeIdentifierReferenceIDRef_ = partyTradeIdentifierReferenceNode.Attributes["id"].Value;
                        PartyTradeIdentifierReference ob = new PartyTradeIdentifierReference(partyTradeIdentifierReferenceNode);
                        IDManager.SetID(partyTradeIdentifierReferenceIDRef_, ob);
                    }
                    else if (partyTradeIdentifierReferenceNode.Attributes["href"] != null)
                    {
                        partyTradeIdentifierReferenceIDRef_ = partyTradeIdentifierReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyTradeIdentifierReference_ = new PartyTradeIdentifierReference(partyTradeIdentifierReferenceNode);
                    }
                }
                else
                {
                    partyTradeIdentifierReference_ = new PartyTradeIdentifierReference(partyTradeIdentifierReferenceNode);
                }
            }
            
        
            XmlNode payerPartyReferenceNode = xmlNode.SelectSingleNode("payerPartyReference");
            
            if (payerPartyReferenceNode != null)
            {
                if (payerPartyReferenceNode.Attributes["href"] != null || payerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (payerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        payerPartyReferenceIDRef_ = payerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(payerPartyReferenceNode);
                        IDManager.SetID(payerPartyReferenceIDRef_, ob);
                    }
                    else if (payerPartyReferenceNode.Attributes["href"] != null)
                    {
                        payerPartyReferenceIDRef_ = payerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payerPartyReference_ = new PartyReference(payerPartyReferenceNode);
                    }
                }
                else
                {
                    payerPartyReference_ = new PartyReference(payerPartyReferenceNode);
                }
            }
            
        
            XmlNode payerAccountReferenceNode = xmlNode.SelectSingleNode("payerAccountReference");
            
            if (payerAccountReferenceNode != null)
            {
                if (payerAccountReferenceNode.Attributes["href"] != null || payerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (payerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        payerAccountReferenceIDRef_ = payerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(payerAccountReferenceNode);
                        IDManager.SetID(payerAccountReferenceIDRef_, ob);
                    }
                    else if (payerAccountReferenceNode.Attributes["href"] != null)
                    {
                        payerAccountReferenceIDRef_ = payerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payerAccountReference_ = new AccountReference(payerAccountReferenceNode);
                    }
                }
                else
                {
                    payerAccountReference_ = new AccountReference(payerAccountReferenceNode);
                }
            }
            
        
            XmlNode receiverPartyReferenceNode = xmlNode.SelectSingleNode("receiverPartyReference");
            
            if (receiverPartyReferenceNode != null)
            {
                if (receiverPartyReferenceNode.Attributes["href"] != null || receiverPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (receiverPartyReferenceNode.Attributes["id"] != null) 
                    {
                        receiverPartyReferenceIDRef_ = receiverPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(receiverPartyReferenceNode);
                        IDManager.SetID(receiverPartyReferenceIDRef_, ob);
                    }
                    else if (receiverPartyReferenceNode.Attributes["href"] != null)
                    {
                        receiverPartyReferenceIDRef_ = receiverPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        receiverPartyReference_ = new PartyReference(receiverPartyReferenceNode);
                    }
                }
                else
                {
                    receiverPartyReference_ = new PartyReference(receiverPartyReferenceNode);
                }
            }
            
        
            XmlNode receiverAccountReferenceNode = xmlNode.SelectSingleNode("receiverAccountReference");
            
            if (receiverAccountReferenceNode != null)
            {
                if (receiverAccountReferenceNode.Attributes["href"] != null || receiverAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (receiverAccountReferenceNode.Attributes["id"] != null) 
                    {
                        receiverAccountReferenceIDRef_ = receiverAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(receiverAccountReferenceNode);
                        IDManager.SetID(receiverAccountReferenceIDRef_, ob);
                    }
                    else if (receiverAccountReferenceNode.Attributes["href"] != null)
                    {
                        receiverAccountReferenceIDRef_ = receiverAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        receiverAccountReference_ = new AccountReference(receiverAccountReferenceNode);
                    }
                }
                else
                {
                    receiverAccountReference_ = new AccountReference(receiverAccountReferenceNode);
                }
            }
            
        
            XmlNode cashflowAmountNode = xmlNode.SelectSingleNode("cashflowAmount");
            
            if (cashflowAmountNode != null)
            {
                if (cashflowAmountNode.Attributes["href"] != null || cashflowAmountNode.Attributes["id"] != null) 
                {
                    if (cashflowAmountNode.Attributes["id"] != null) 
                    {
                        cashflowAmountIDRef_ = cashflowAmountNode.Attributes["id"].Value;
                        Money ob = new Money(cashflowAmountNode);
                        IDManager.SetID(cashflowAmountIDRef_, ob);
                    }
                    else if (cashflowAmountNode.Attributes["href"] != null)
                    {
                        cashflowAmountIDRef_ = cashflowAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashflowAmount_ = new Money(cashflowAmountNode);
                    }
                }
                else
                {
                    cashflowAmount_ = new Money(cashflowAmountNode);
                }
            }
            
        
            XmlNode cashflowTypeNode = xmlNode.SelectSingleNode("cashflowType");
            
            if (cashflowTypeNode != null)
            {
                if (cashflowTypeNode.Attributes["href"] != null || cashflowTypeNode.Attributes["id"] != null) 
                {
                    if (cashflowTypeNode.Attributes["id"] != null) 
                    {
                        cashflowTypeIDRef_ = cashflowTypeNode.Attributes["id"].Value;
                        CashflowType ob = new CashflowType(cashflowTypeNode);
                        IDManager.SetID(cashflowTypeIDRef_, ob);
                    }
                    else if (cashflowTypeNode.Attributes["href"] != null)
                    {
                        cashflowTypeIDRef_ = cashflowTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashflowType_ = new CashflowType(cashflowTypeNode);
                    }
                }
                else
                {
                    cashflowType_ = new CashflowType(cashflowTypeNode);
                }
            }
            
        
        }
        
    
        #region CashflowId_
        private CashflowId cashflowId_;
        public CashflowId CashflowId_
        {
            get
            {
                if (this.cashflowId_ != null)
                {
                    return this.cashflowId_; 
                }
                else if (this.cashflowIdIDRef_ != null)
                {
                    cashflowId_ = IDManager.getID(cashflowIdIDRef_) as CashflowId;
                    return this.cashflowId_; 
                }
                else
                {
                      return this.cashflowId_; 
                }
            }
            set
            {
                if (this.cashflowId_ != value)
                {
                    this.cashflowId_ = value;
                }
            }
        }
        #endregion
        
        public string cashflowIdIDRef_ { get; set; }
        #region PartyTradeIdentifierReference_
        private PartyTradeIdentifierReference partyTradeIdentifierReference_;
        public PartyTradeIdentifierReference PartyTradeIdentifierReference_
        {
            get
            {
                if (this.partyTradeIdentifierReference_ != null)
                {
                    return this.partyTradeIdentifierReference_; 
                }
                else if (this.partyTradeIdentifierReferenceIDRef_ != null)
                {
                    partyTradeIdentifierReference_ = IDManager.getID(partyTradeIdentifierReferenceIDRef_) as PartyTradeIdentifierReference;
                    return this.partyTradeIdentifierReference_; 
                }
                else
                {
                      return this.partyTradeIdentifierReference_; 
                }
            }
            set
            {
                if (this.partyTradeIdentifierReference_ != value)
                {
                    this.partyTradeIdentifierReference_ = value;
                }
            }
        }
        #endregion
        
        public string partyTradeIdentifierReferenceIDRef_ { get; set; }
        #region PayerPartyReference_
        private PartyReference payerPartyReference_;
        public PartyReference PayerPartyReference_
        {
            get
            {
                if (this.payerPartyReference_ != null)
                {
                    return this.payerPartyReference_; 
                }
                else if (this.payerPartyReferenceIDRef_ != null)
                {
                    payerPartyReference_ = IDManager.getID(payerPartyReferenceIDRef_) as PartyReference;
                    return this.payerPartyReference_; 
                }
                else
                {
                      return this.payerPartyReference_; 
                }
            }
            set
            {
                if (this.payerPartyReference_ != value)
                {
                    this.payerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string payerPartyReferenceIDRef_ { get; set; }
        #region PayerAccountReference_
        private AccountReference payerAccountReference_;
        public AccountReference PayerAccountReference_
        {
            get
            {
                if (this.payerAccountReference_ != null)
                {
                    return this.payerAccountReference_; 
                }
                else if (this.payerAccountReferenceIDRef_ != null)
                {
                    payerAccountReference_ = IDManager.getID(payerAccountReferenceIDRef_) as AccountReference;
                    return this.payerAccountReference_; 
                }
                else
                {
                      return this.payerAccountReference_; 
                }
            }
            set
            {
                if (this.payerAccountReference_ != value)
                {
                    this.payerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string payerAccountReferenceIDRef_ { get; set; }
        #region ReceiverPartyReference_
        private PartyReference receiverPartyReference_;
        public PartyReference ReceiverPartyReference_
        {
            get
            {
                if (this.receiverPartyReference_ != null)
                {
                    return this.receiverPartyReference_; 
                }
                else if (this.receiverPartyReferenceIDRef_ != null)
                {
                    receiverPartyReference_ = IDManager.getID(receiverPartyReferenceIDRef_) as PartyReference;
                    return this.receiverPartyReference_; 
                }
                else
                {
                      return this.receiverPartyReference_; 
                }
            }
            set
            {
                if (this.receiverPartyReference_ != value)
                {
                    this.receiverPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string receiverPartyReferenceIDRef_ { get; set; }
        #region ReceiverAccountReference_
        private AccountReference receiverAccountReference_;
        public AccountReference ReceiverAccountReference_
        {
            get
            {
                if (this.receiverAccountReference_ != null)
                {
                    return this.receiverAccountReference_; 
                }
                else if (this.receiverAccountReferenceIDRef_ != null)
                {
                    receiverAccountReference_ = IDManager.getID(receiverAccountReferenceIDRef_) as AccountReference;
                    return this.receiverAccountReference_; 
                }
                else
                {
                      return this.receiverAccountReference_; 
                }
            }
            set
            {
                if (this.receiverAccountReference_ != value)
                {
                    this.receiverAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string receiverAccountReferenceIDRef_ { get; set; }
        #region CashflowAmount_
        private Money cashflowAmount_;
        public Money CashflowAmount_
        {
            get
            {
                if (this.cashflowAmount_ != null)
                {
                    return this.cashflowAmount_; 
                }
                else if (this.cashflowAmountIDRef_ != null)
                {
                    cashflowAmount_ = IDManager.getID(cashflowAmountIDRef_) as Money;
                    return this.cashflowAmount_; 
                }
                else
                {
                      return this.cashflowAmount_; 
                }
            }
            set
            {
                if (this.cashflowAmount_ != value)
                {
                    this.cashflowAmount_ = value;
                }
            }
        }
        #endregion
        
        public string cashflowAmountIDRef_ { get; set; }
        #region CashflowType_
        private CashflowType cashflowType_;
        public CashflowType CashflowType_
        {
            get
            {
                if (this.cashflowType_ != null)
                {
                    return this.cashflowType_; 
                }
                else if (this.cashflowTypeIDRef_ != null)
                {
                    cashflowType_ = IDManager.getID(cashflowTypeIDRef_) as CashflowType;
                    return this.cashflowType_; 
                }
                else
                {
                      return this.cashflowType_; 
                }
            }
            set
            {
                if (this.cashflowType_ != value)
                {
                    this.cashflowType_ = value;
                }
            }
        }
        #endregion
        
        public string cashflowTypeIDRef_ { get; set; }
        
    
        
    
    }
    
}

