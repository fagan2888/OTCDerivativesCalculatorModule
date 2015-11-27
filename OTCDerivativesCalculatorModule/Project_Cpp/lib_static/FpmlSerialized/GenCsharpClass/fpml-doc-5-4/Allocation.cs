using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Allocation
    {
        public Allocation(XmlNode xmlNode)
        {
            XmlNodeList allocationTradeIdNodeList = xmlNode.SelectNodes("allocationTradeId");
            
            foreach (XmlNode item in allocationTradeIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocationTradeIdIDRef = item.Attributes["id"].Name;
                        List<TradeIdentifier> ob = new List<TradeIdentifier>();
                        ob.Add(new TradeIdentifier(item));
                        IDManager.SetID(allocationTradeIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocationTradeIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    allocationTradeId.Add(new TradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList partyReferenceNodeList = xmlNode.SelectNodes("partyReference");
            if (partyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(partyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList accountReferenceNodeList = xmlNode.SelectNodes("accountReference");
            if (accountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(accountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList allocatedFractionNodeList = xmlNode.SelectNodes("allocatedFraction");
            if (allocatedFractionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allocatedFractionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocatedFractionIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(allocatedFractionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocatedFractionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allocatedFraction = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList allocatedNotionalNodeList = xmlNode.SelectNodes("allocatedNotional");
            
            foreach (XmlNode item in allocatedNotionalNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocatedNotionalIDRef = item.Attributes["id"].Name;
                        List<Money> ob = new List<Money>();
                        ob.Add(new Money(item));
                        IDManager.SetID(allocatedNotionalIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocatedNotionalIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    allocatedNotional.Add(new Money(item));
                    }
                }
            }
            
        
            XmlNodeList collateralNodeList = xmlNode.SelectNodes("collateral");
            if (collateralNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in collateralNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        collateralIDRef = item.Attributes["id"].Name;
                        Collateral ob = Collateral();
                        IDManager.SetID(collateralIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        collateralIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        collateral = new Collateral(item);
                    }
                }
            }
            
        
            XmlNodeList creditChargeAmountNodeList = xmlNode.SelectNodes("creditChargeAmount");
            if (creditChargeAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditChargeAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditChargeAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(creditChargeAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditChargeAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditChargeAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList approvalsNodeList = xmlNode.SelectNodes("approvals");
            if (approvalsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in approvalsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        approvalsIDRef = item.Attributes["id"].Name;
                        Approvals ob = Approvals();
                        IDManager.SetID(approvalsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        approvalsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        approvals = new Approvals(item);
                    }
                }
            }
            
        
            XmlNodeList masterConfirmationDateNodeList = xmlNode.SelectNodes("masterConfirmationDate");
            if (masterConfirmationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in masterConfirmationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        masterConfirmationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(masterConfirmationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        masterConfirmationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        masterConfirmationDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList relatedPartyNodeList = xmlNode.SelectNodes("relatedParty");
            
            foreach (XmlNode item in relatedPartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relatedPartyIDRef = item.Attributes["id"].Name;
                        List<RelatedParty> ob = new List<RelatedParty>();
                        ob.Add(new RelatedParty(item));
                        IDManager.SetID(relatedPartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relatedPartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    relatedParty.Add(new RelatedParty(item));
                    }
                }
            }
            
        
        }
        
    
        #region AllocationTradeId
        private List<TradeIdentifier> allocationTradeId;
        public List<TradeIdentifier> AllocationTradeId
        {
            get
            {
                if (this.allocationTradeId != null)
                {
                    return this.allocationTradeId; 
                }
                else if (this.allocationTradeIdIDRef != null)
                {
                    allocationTradeId = IDManager.getID(allocationTradeIdIDRef) as List<TradeIdentifier>;
                    return this.allocationTradeId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocationTradeId != value)
                {
                    this.allocationTradeId = value;
                }
            }
        }
        #endregion
        
        public string TradeIdentifierIDRef { get; set; }
        #region PartyReference
        private PartyReference partyReference;
        public PartyReference PartyReference
        {
            get
            {
                if (this.partyReference != null)
                {
                    return this.partyReference; 
                }
                else if (this.partyReferenceIDRef != null)
                {
                    partyReference = IDManager.getID(partyReferenceIDRef) as PartyReference;
                    return this.partyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyReference != value)
                {
                    this.partyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region AccountReference
        private AccountReference accountReference;
        public AccountReference AccountReference
        {
            get
            {
                if (this.accountReference != null)
                {
                    return this.accountReference; 
                }
                else if (this.accountReferenceIDRef != null)
                {
                    accountReference = IDManager.getID(accountReferenceIDRef) as AccountReference;
                    return this.accountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accountReference != value)
                {
                    this.accountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region AllocatedFraction
        private XsdTypeDecimal allocatedFraction;
        public XsdTypeDecimal AllocatedFraction
        {
            get
            {
                if (this.allocatedFraction != null)
                {
                    return this.allocatedFraction; 
                }
                else if (this.allocatedFractionIDRef != null)
                {
                    allocatedFraction = IDManager.getID(allocatedFractionIDRef) as XsdTypeDecimal;
                    return this.allocatedFraction; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocatedFraction != value)
                {
                    this.allocatedFraction = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region AllocatedNotional
        private List<Money> allocatedNotional;
        public List<Money> AllocatedNotional
        {
            get
            {
                if (this.allocatedNotional != null)
                {
                    return this.allocatedNotional; 
                }
                else if (this.allocatedNotionalIDRef != null)
                {
                    allocatedNotional = IDManager.getID(allocatedNotionalIDRef) as List<Money>;
                    return this.allocatedNotional; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocatedNotional != value)
                {
                    this.allocatedNotional = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region Collateral
        private Collateral collateral;
        public Collateral Collateral
        {
            get
            {
                if (this.collateral != null)
                {
                    return this.collateral; 
                }
                else if (this.collateralIDRef != null)
                {
                    collateral = IDManager.getID(collateralIDRef) as Collateral;
                    return this.collateral; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.collateral != value)
                {
                    this.collateral = value;
                }
            }
        }
        #endregion
        
        public string CollateralIDRef { get; set; }
        #region CreditChargeAmount
        private Money creditChargeAmount;
        public Money CreditChargeAmount
        {
            get
            {
                if (this.creditChargeAmount != null)
                {
                    return this.creditChargeAmount; 
                }
                else if (this.creditChargeAmountIDRef != null)
                {
                    creditChargeAmount = IDManager.getID(creditChargeAmountIDRef) as Money;
                    return this.creditChargeAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditChargeAmount != value)
                {
                    this.creditChargeAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region Approvals
        private Approvals approvals;
        public Approvals Approvals
        {
            get
            {
                if (this.approvals != null)
                {
                    return this.approvals; 
                }
                else if (this.approvalsIDRef != null)
                {
                    approvals = IDManager.getID(approvalsIDRef) as Approvals;
                    return this.approvals; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.approvals != value)
                {
                    this.approvals = value;
                }
            }
        }
        #endregion
        
        public string ApprovalsIDRef { get; set; }
        #region MasterConfirmationDate
        private XsdTypeDate masterConfirmationDate;
        public XsdTypeDate MasterConfirmationDate
        {
            get
            {
                if (this.masterConfirmationDate != null)
                {
                    return this.masterConfirmationDate; 
                }
                else if (this.masterConfirmationDateIDRef != null)
                {
                    masterConfirmationDate = IDManager.getID(masterConfirmationDateIDRef) as XsdTypeDate;
                    return this.masterConfirmationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.masterConfirmationDate != value)
                {
                    this.masterConfirmationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region RelatedParty
        private List<RelatedParty> relatedParty;
        public List<RelatedParty> RelatedParty
        {
            get
            {
                if (this.relatedParty != null)
                {
                    return this.relatedParty; 
                }
                else if (this.relatedPartyIDRef != null)
                {
                    relatedParty = IDManager.getID(relatedPartyIDRef) as List<RelatedParty>;
                    return this.relatedParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relatedParty != value)
                {
                    this.relatedParty = value;
                }
            }
        }
        #endregion
        
        public string RelatedPartyIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

