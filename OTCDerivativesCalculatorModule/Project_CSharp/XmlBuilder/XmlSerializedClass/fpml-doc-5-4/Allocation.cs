using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Allocation : ISerialized
    {
        public Allocation(XmlNode xmlNode)
        {
            XmlNodeList allocationTradeIdNodeList = xmlNode.SelectNodes("allocationTradeId");
            
            if (allocationTradeIdNodeList != null)
            {
                this.allocationTradeId_ = new List<TradeIdentifier>();
                foreach (XmlNode item in allocationTradeIdNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            allocationTradeIdIDRef_ = item.Attributes["id"].Value;
                            allocationTradeId_.Add(new TradeIdentifier(item));
                            IDManager.SetID(allocationTradeIdIDRef_, allocationTradeId_[allocationTradeId_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            allocationTradeIdIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        allocationTradeId_.Add(new TradeIdentifier(item));
                        }
                    }
                    else
                    {
                        allocationTradeId_.Add(new TradeIdentifier(item));
                    }
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
            
        
            XmlNode allocatedFractionNode = xmlNode.SelectSingleNode("allocatedFraction");
            
            if (allocatedFractionNode != null)
            {
                if (allocatedFractionNode.Attributes["href"] != null || allocatedFractionNode.Attributes["id"] != null) 
                {
                    if (allocatedFractionNode.Attributes["id"] != null) 
                    {
                        allocatedFractionIDRef_ = allocatedFractionNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(allocatedFractionNode);
                        IDManager.SetID(allocatedFractionIDRef_, ob);
                    }
                    else if (allocatedFractionNode.Attributes["href"] != null)
                    {
                        allocatedFractionIDRef_ = allocatedFractionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allocatedFraction_ = new XsdTypeDecimal(allocatedFractionNode);
                    }
                }
                else
                {
                    allocatedFraction_ = new XsdTypeDecimal(allocatedFractionNode);
                }
            }
            
        
            XmlNodeList allocatedNotionalNodeList = xmlNode.SelectNodes("allocatedNotional");
            
            if (allocatedNotionalNodeList != null)
            {
                this.allocatedNotional_ = new List<Money>();
                foreach (XmlNode item in allocatedNotionalNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            allocatedNotionalIDRef_ = item.Attributes["id"].Value;
                            allocatedNotional_.Add(new Money(item));
                            IDManager.SetID(allocatedNotionalIDRef_, allocatedNotional_[allocatedNotional_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            allocatedNotionalIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        allocatedNotional_.Add(new Money(item));
                        }
                    }
                    else
                    {
                        allocatedNotional_.Add(new Money(item));
                    }
                }
            }
            
        
            XmlNode collateralNode = xmlNode.SelectSingleNode("collateral");
            
            if (collateralNode != null)
            {
                if (collateralNode.Attributes["href"] != null || collateralNode.Attributes["id"] != null) 
                {
                    if (collateralNode.Attributes["id"] != null) 
                    {
                        collateralIDRef_ = collateralNode.Attributes["id"].Value;
                        Collateral ob = new Collateral(collateralNode);
                        IDManager.SetID(collateralIDRef_, ob);
                    }
                    else if (collateralNode.Attributes["href"] != null)
                    {
                        collateralIDRef_ = collateralNode.Attributes["href"].Value;
                    }
                    else
                    {
                        collateral_ = new Collateral(collateralNode);
                    }
                }
                else
                {
                    collateral_ = new Collateral(collateralNode);
                }
            }
            
        
            XmlNode creditChargeAmountNode = xmlNode.SelectSingleNode("creditChargeAmount");
            
            if (creditChargeAmountNode != null)
            {
                if (creditChargeAmountNode.Attributes["href"] != null || creditChargeAmountNode.Attributes["id"] != null) 
                {
                    if (creditChargeAmountNode.Attributes["id"] != null) 
                    {
                        creditChargeAmountIDRef_ = creditChargeAmountNode.Attributes["id"].Value;
                        Money ob = new Money(creditChargeAmountNode);
                        IDManager.SetID(creditChargeAmountIDRef_, ob);
                    }
                    else if (creditChargeAmountNode.Attributes["href"] != null)
                    {
                        creditChargeAmountIDRef_ = creditChargeAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditChargeAmount_ = new Money(creditChargeAmountNode);
                    }
                }
                else
                {
                    creditChargeAmount_ = new Money(creditChargeAmountNode);
                }
            }
            
        
            XmlNode approvalsNode = xmlNode.SelectSingleNode("approvals");
            
            if (approvalsNode != null)
            {
                if (approvalsNode.Attributes["href"] != null || approvalsNode.Attributes["id"] != null) 
                {
                    if (approvalsNode.Attributes["id"] != null) 
                    {
                        approvalsIDRef_ = approvalsNode.Attributes["id"].Value;
                        Approvals ob = new Approvals(approvalsNode);
                        IDManager.SetID(approvalsIDRef_, ob);
                    }
                    else if (approvalsNode.Attributes["href"] != null)
                    {
                        approvalsIDRef_ = approvalsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        approvals_ = new Approvals(approvalsNode);
                    }
                }
                else
                {
                    approvals_ = new Approvals(approvalsNode);
                }
            }
            
        
            XmlNode masterConfirmationDateNode = xmlNode.SelectSingleNode("masterConfirmationDate");
            
            if (masterConfirmationDateNode != null)
            {
                if (masterConfirmationDateNode.Attributes["href"] != null || masterConfirmationDateNode.Attributes["id"] != null) 
                {
                    if (masterConfirmationDateNode.Attributes["id"] != null) 
                    {
                        masterConfirmationDateIDRef_ = masterConfirmationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(masterConfirmationDateNode);
                        IDManager.SetID(masterConfirmationDateIDRef_, ob);
                    }
                    else if (masterConfirmationDateNode.Attributes["href"] != null)
                    {
                        masterConfirmationDateIDRef_ = masterConfirmationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        masterConfirmationDate_ = new XsdTypeDate(masterConfirmationDateNode);
                    }
                }
                else
                {
                    masterConfirmationDate_ = new XsdTypeDate(masterConfirmationDateNode);
                }
            }
            
        
            XmlNodeList relatedPartyNodeList = xmlNode.SelectNodes("relatedParty");
            
            if (relatedPartyNodeList != null)
            {
                this.relatedParty_ = new List<RelatedParty>();
                foreach (XmlNode item in relatedPartyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            relatedPartyIDRef_ = item.Attributes["id"].Value;
                            relatedParty_.Add(new RelatedParty(item));
                            IDManager.SetID(relatedPartyIDRef_, relatedParty_[relatedParty_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            relatedPartyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        relatedParty_.Add(new RelatedParty(item));
                        }
                    }
                    else
                    {
                        relatedParty_.Add(new RelatedParty(item));
                    }
                }
            }
            
        
        }
        
    
        #region AllocationTradeId_
        private List<TradeIdentifier> allocationTradeId_;
        public List<TradeIdentifier> AllocationTradeId_
        {
            get
            {
                if (this.allocationTradeId_ != null)
                {
                    return this.allocationTradeId_; 
                }
                else if (this.allocationTradeIdIDRef_ != null)
                {
                    return this.allocationTradeId_; 
                }
                else
                {
                      return this.allocationTradeId_; 
                }
            }
            set
            {
                if (this.allocationTradeId_ != value)
                {
                    this.allocationTradeId_ = value;
                }
            }
        }
        #endregion
        
        public string allocationTradeIdIDRef_ { get; set; }
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
        #region AllocatedFraction_
        private XsdTypeDecimal allocatedFraction_;
        public XsdTypeDecimal AllocatedFraction_
        {
            get
            {
                if (this.allocatedFraction_ != null)
                {
                    return this.allocatedFraction_; 
                }
                else if (this.allocatedFractionIDRef_ != null)
                {
                    allocatedFraction_ = IDManager.getID(allocatedFractionIDRef_) as XsdTypeDecimal;
                    return this.allocatedFraction_; 
                }
                else
                {
                      return this.allocatedFraction_; 
                }
            }
            set
            {
                if (this.allocatedFraction_ != value)
                {
                    this.allocatedFraction_ = value;
                }
            }
        }
        #endregion
        
        public string allocatedFractionIDRef_ { get; set; }
        #region AllocatedNotional_
        private List<Money> allocatedNotional_;
        public List<Money> AllocatedNotional_
        {
            get
            {
                if (this.allocatedNotional_ != null)
                {
                    return this.allocatedNotional_; 
                }
                else if (this.allocatedNotionalIDRef_ != null)
                {
                    return this.allocatedNotional_; 
                }
                else
                {
                      return this.allocatedNotional_; 
                }
            }
            set
            {
                if (this.allocatedNotional_ != value)
                {
                    this.allocatedNotional_ = value;
                }
            }
        }
        #endregion
        
        public string allocatedNotionalIDRef_ { get; set; }
        #region Collateral_
        private Collateral collateral_;
        public Collateral Collateral_
        {
            get
            {
                if (this.collateral_ != null)
                {
                    return this.collateral_; 
                }
                else if (this.collateralIDRef_ != null)
                {
                    collateral_ = IDManager.getID(collateralIDRef_) as Collateral;
                    return this.collateral_; 
                }
                else
                {
                      return this.collateral_; 
                }
            }
            set
            {
                if (this.collateral_ != value)
                {
                    this.collateral_ = value;
                }
            }
        }
        #endregion
        
        public string collateralIDRef_ { get; set; }
        #region CreditChargeAmount_
        private Money creditChargeAmount_;
        public Money CreditChargeAmount_
        {
            get
            {
                if (this.creditChargeAmount_ != null)
                {
                    return this.creditChargeAmount_; 
                }
                else if (this.creditChargeAmountIDRef_ != null)
                {
                    creditChargeAmount_ = IDManager.getID(creditChargeAmountIDRef_) as Money;
                    return this.creditChargeAmount_; 
                }
                else
                {
                      return this.creditChargeAmount_; 
                }
            }
            set
            {
                if (this.creditChargeAmount_ != value)
                {
                    this.creditChargeAmount_ = value;
                }
            }
        }
        #endregion
        
        public string creditChargeAmountIDRef_ { get; set; }
        #region Approvals_
        private Approvals approvals_;
        public Approvals Approvals_
        {
            get
            {
                if (this.approvals_ != null)
                {
                    return this.approvals_; 
                }
                else if (this.approvalsIDRef_ != null)
                {
                    approvals_ = IDManager.getID(approvalsIDRef_) as Approvals;
                    return this.approvals_; 
                }
                else
                {
                      return this.approvals_; 
                }
            }
            set
            {
                if (this.approvals_ != value)
                {
                    this.approvals_ = value;
                }
            }
        }
        #endregion
        
        public string approvalsIDRef_ { get; set; }
        #region MasterConfirmationDate_
        private XsdTypeDate masterConfirmationDate_;
        public XsdTypeDate MasterConfirmationDate_
        {
            get
            {
                if (this.masterConfirmationDate_ != null)
                {
                    return this.masterConfirmationDate_; 
                }
                else if (this.masterConfirmationDateIDRef_ != null)
                {
                    masterConfirmationDate_ = IDManager.getID(masterConfirmationDateIDRef_) as XsdTypeDate;
                    return this.masterConfirmationDate_; 
                }
                else
                {
                      return this.masterConfirmationDate_; 
                }
            }
            set
            {
                if (this.masterConfirmationDate_ != value)
                {
                    this.masterConfirmationDate_ = value;
                }
            }
        }
        #endregion
        
        public string masterConfirmationDateIDRef_ { get; set; }
        #region RelatedParty_
        private List<RelatedParty> relatedParty_;
        public List<RelatedParty> RelatedParty_
        {
            get
            {
                if (this.relatedParty_ != null)
                {
                    return this.relatedParty_; 
                }
                else if (this.relatedPartyIDRef_ != null)
                {
                    return this.relatedParty_; 
                }
                else
                {
                      return this.relatedParty_; 
                }
            }
            set
            {
                if (this.relatedParty_ != value)
                {
                    this.relatedParty_ = value;
                }
            }
        }
        #endregion
        
        public string relatedPartyIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

