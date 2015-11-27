using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class GrossCashflow
    {
        public GrossCashflow(XmlNode xmlNode)
        {
            XmlNodeList cashflowIdNodeList = xmlNode.SelectNodes("cashflowId");
            if (cashflowIdNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashflowIdNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashflowIdIDRef = item.Attributes["id"].Name;
                        CashflowId ob = CashflowId();
                        IDManager.SetID(cashflowIdIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashflowIdIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashflowId = new CashflowId(item);
                    }
                }
            }
            
        
            XmlNodeList partyTradeIdentifierReferenceNodeList = xmlNode.SelectNodes("partyTradeIdentifierReference");
            if (partyTradeIdentifierReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyTradeIdentifierReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyTradeIdentifierReferenceIDRef = item.Attributes["id"].Name;
                        PartyTradeIdentifierReference ob = PartyTradeIdentifierReference();
                        IDManager.SetID(partyTradeIdentifierReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyTradeIdentifierReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyTradeIdentifierReference = new PartyTradeIdentifierReference(item);
                    }
                }
            }
            
        
            XmlNodeList payerPartyReferenceNodeList = xmlNode.SelectNodes("payerPartyReference");
            if (payerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(payerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList payerAccountReferenceNodeList = xmlNode.SelectNodes("payerAccountReference");
            if (payerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in payerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        payerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(payerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        payerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList receiverPartyReferenceNodeList = xmlNode.SelectNodes("receiverPartyReference");
            if (receiverPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in receiverPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        receiverPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(receiverPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        receiverPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        receiverPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList receiverAccountReferenceNodeList = xmlNode.SelectNodes("receiverAccountReference");
            if (receiverAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in receiverAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        receiverAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(receiverAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        receiverAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        receiverAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList cashflowAmountNodeList = xmlNode.SelectNodes("cashflowAmount");
            if (cashflowAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashflowAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashflowAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(cashflowAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashflowAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashflowAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList cashflowTypeNodeList = xmlNode.SelectNodes("cashflowType");
            if (cashflowTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashflowTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashflowTypeIDRef = item.Attributes["id"].Name;
                        CashflowType ob = CashflowType();
                        IDManager.SetID(cashflowTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashflowTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashflowType = new CashflowType(item);
                    }
                }
            }
            
        
        }
        
    
        #region CashflowId
        private CashflowId cashflowId;
        public CashflowId CashflowId
        {
            get
            {
                if (this.cashflowId != null)
                {
                    return this.cashflowId; 
                }
                else if (this.cashflowIdIDRef != null)
                {
                    cashflowId = IDManager.getID(cashflowIdIDRef) as CashflowId;
                    return this.cashflowId; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashflowId != value)
                {
                    this.cashflowId = value;
                }
            }
        }
        #endregion
        
        public string CashflowIdIDRef { get; set; }
        #region PartyTradeIdentifierReference
        private PartyTradeIdentifierReference partyTradeIdentifierReference;
        public PartyTradeIdentifierReference PartyTradeIdentifierReference
        {
            get
            {
                if (this.partyTradeIdentifierReference != null)
                {
                    return this.partyTradeIdentifierReference; 
                }
                else if (this.partyTradeIdentifierReferenceIDRef != null)
                {
                    partyTradeIdentifierReference = IDManager.getID(partyTradeIdentifierReferenceIDRef) as PartyTradeIdentifierReference;
                    return this.partyTradeIdentifierReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyTradeIdentifierReference != value)
                {
                    this.partyTradeIdentifierReference = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierReferenceIDRef { get; set; }
        #region PayerPartyReference
        private PartyReference payerPartyReference;
        public PartyReference PayerPartyReference
        {
            get
            {
                if (this.payerPartyReference != null)
                {
                    return this.payerPartyReference; 
                }
                else if (this.payerPartyReferenceIDRef != null)
                {
                    payerPartyReference = IDManager.getID(payerPartyReferenceIDRef) as PartyReference;
                    return this.payerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payerPartyReference != value)
                {
                    this.payerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region PayerAccountReference
        private AccountReference payerAccountReference;
        public AccountReference PayerAccountReference
        {
            get
            {
                if (this.payerAccountReference != null)
                {
                    return this.payerAccountReference; 
                }
                else if (this.payerAccountReferenceIDRef != null)
                {
                    payerAccountReference = IDManager.getID(payerAccountReferenceIDRef) as AccountReference;
                    return this.payerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payerAccountReference != value)
                {
                    this.payerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region ReceiverPartyReference
        private PartyReference receiverPartyReference;
        public PartyReference ReceiverPartyReference
        {
            get
            {
                if (this.receiverPartyReference != null)
                {
                    return this.receiverPartyReference; 
                }
                else if (this.receiverPartyReferenceIDRef != null)
                {
                    receiverPartyReference = IDManager.getID(receiverPartyReferenceIDRef) as PartyReference;
                    return this.receiverPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.receiverPartyReference != value)
                {
                    this.receiverPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region ReceiverAccountReference
        private AccountReference receiverAccountReference;
        public AccountReference ReceiverAccountReference
        {
            get
            {
                if (this.receiverAccountReference != null)
                {
                    return this.receiverAccountReference; 
                }
                else if (this.receiverAccountReferenceIDRef != null)
                {
                    receiverAccountReference = IDManager.getID(receiverAccountReferenceIDRef) as AccountReference;
                    return this.receiverAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.receiverAccountReference != value)
                {
                    this.receiverAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region CashflowAmount
        private Money cashflowAmount;
        public Money CashflowAmount
        {
            get
            {
                if (this.cashflowAmount != null)
                {
                    return this.cashflowAmount; 
                }
                else if (this.cashflowAmountIDRef != null)
                {
                    cashflowAmount = IDManager.getID(cashflowAmountIDRef) as Money;
                    return this.cashflowAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashflowAmount != value)
                {
                    this.cashflowAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region CashflowType
        private CashflowType cashflowType;
        public CashflowType CashflowType
        {
            get
            {
                if (this.cashflowType != null)
                {
                    return this.cashflowType; 
                }
                else if (this.cashflowTypeIDRef != null)
                {
                    cashflowType = IDManager.getID(cashflowTypeIDRef) as CashflowType;
                    return this.cashflowType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashflowType != value)
                {
                    this.cashflowType = value;
                }
            }
        }
        #endregion
        
        public string CashflowTypeIDRef { get; set; }
        
    
        
    
    }
    
}

