using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class InterestRateStream
    {
        public InterestRateStream(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNodeList calculationPeriodDatesNodeList = xmlNode.SelectNodes("calculationPeriodDates");
            if (calculationPeriodDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesIDRef = item.Attributes["id"].Name;
                        CalculationPeriodDates ob = CalculationPeriodDates();
                        IDManager.SetID(calculationPeriodDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodDates = new CalculationPeriodDates(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDatesNodeList = xmlNode.SelectNodes("paymentDates");
            if (paymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef = item.Attributes["id"].Name;
                        PaymentDates ob = PaymentDates();
                        IDManager.SetID(paymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDates = new PaymentDates(item);
                    }
                }
            }
            
        
            XmlNodeList resetDatesNodeList = xmlNode.SelectNodes("resetDates");
            if (resetDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in resetDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        resetDatesIDRef = item.Attributes["id"].Name;
                        ResetDates ob = ResetDates();
                        IDManager.SetID(resetDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        resetDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        resetDates = new ResetDates(item);
                    }
                }
            }
            
        
            XmlNodeList calculationPeriodAmountNodeList = xmlNode.SelectNodes("calculationPeriodAmount");
            if (calculationPeriodAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationPeriodAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationPeriodAmountIDRef = item.Attributes["id"].Name;
                        CalculationPeriodAmount ob = CalculationPeriodAmount();
                        IDManager.SetID(calculationPeriodAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationPeriodAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationPeriodAmount = new CalculationPeriodAmount(item);
                    }
                }
            }
            
        
            XmlNodeList stubCalculationPeriodAmountNodeList = xmlNode.SelectNodes("stubCalculationPeriodAmount");
            if (stubCalculationPeriodAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in stubCalculationPeriodAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        stubCalculationPeriodAmountIDRef = item.Attributes["id"].Name;
                        StubCalculationPeriodAmount ob = StubCalculationPeriodAmount();
                        IDManager.SetID(stubCalculationPeriodAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        stubCalculationPeriodAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        stubCalculationPeriodAmount = new StubCalculationPeriodAmount(item);
                    }
                }
            }
            
        
            XmlNodeList principalExchangesNodeList = xmlNode.SelectNodes("principalExchanges");
            if (principalExchangesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in principalExchangesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        principalExchangesIDRef = item.Attributes["id"].Name;
                        PrincipalExchanges ob = PrincipalExchanges();
                        IDManager.SetID(principalExchangesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        principalExchangesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        principalExchanges = new PrincipalExchanges(item);
                    }
                }
            }
            
        
            XmlNodeList cashflowsNodeList = xmlNode.SelectNodes("cashflows");
            if (cashflowsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashflowsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashflowsIDRef = item.Attributes["id"].Name;
                        Cashflows ob = Cashflows();
                        IDManager.SetID(cashflowsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashflowsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashflows = new Cashflows(item);
                    }
                }
            }
            
        
            XmlNodeList settlementProvisionNodeList = xmlNode.SelectNodes("settlementProvision");
            if (settlementProvisionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementProvisionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementProvisionIDRef = item.Attributes["id"].Name;
                        SettlementProvision ob = SettlementProvision();
                        IDManager.SetID(settlementProvisionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementProvisionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementProvision = new SettlementProvision(item);
                    }
                }
            }
            
        
            XmlNodeList formulaNodeList = xmlNode.SelectNodes("formula");
            if (formulaNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in formulaNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        formulaIDRef = item.Attributes["id"].Name;
                        Formula ob = Formula();
                        IDManager.SetID(formulaIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        formulaIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        formula = new Formula(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region CalculationPeriodDates
        private CalculationPeriodDates calculationPeriodDates;
        public CalculationPeriodDates CalculationPeriodDates
        {
            get
            {
                if (this.calculationPeriodDates != null)
                {
                    return this.calculationPeriodDates; 
                }
                else if (this.calculationPeriodDatesIDRef != null)
                {
                    calculationPeriodDates = IDManager.getID(calculationPeriodDatesIDRef) as CalculationPeriodDates;
                    return this.calculationPeriodDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodDates != value)
                {
                    this.calculationPeriodDates = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodDatesIDRef { get; set; }
        #region PaymentDates
        private PaymentDates paymentDates;
        public PaymentDates PaymentDates
        {
            get
            {
                if (this.paymentDates != null)
                {
                    return this.paymentDates; 
                }
                else if (this.paymentDatesIDRef != null)
                {
                    paymentDates = IDManager.getID(paymentDatesIDRef) as PaymentDates;
                    return this.paymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDates != value)
                {
                    this.paymentDates = value;
                }
            }
        }
        #endregion
        
        public string PaymentDatesIDRef { get; set; }
        #region ResetDates
        private ResetDates resetDates;
        public ResetDates ResetDates
        {
            get
            {
                if (this.resetDates != null)
                {
                    return this.resetDates; 
                }
                else if (this.resetDatesIDRef != null)
                {
                    resetDates = IDManager.getID(resetDatesIDRef) as ResetDates;
                    return this.resetDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.resetDates != value)
                {
                    this.resetDates = value;
                }
            }
        }
        #endregion
        
        public string ResetDatesIDRef { get; set; }
        #region CalculationPeriodAmount
        private CalculationPeriodAmount calculationPeriodAmount;
        public CalculationPeriodAmount CalculationPeriodAmount
        {
            get
            {
                if (this.calculationPeriodAmount != null)
                {
                    return this.calculationPeriodAmount; 
                }
                else if (this.calculationPeriodAmountIDRef != null)
                {
                    calculationPeriodAmount = IDManager.getID(calculationPeriodAmountIDRef) as CalculationPeriodAmount;
                    return this.calculationPeriodAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationPeriodAmount != value)
                {
                    this.calculationPeriodAmount = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodAmountIDRef { get; set; }
        #region StubCalculationPeriodAmount
        private StubCalculationPeriodAmount stubCalculationPeriodAmount;
        public StubCalculationPeriodAmount StubCalculationPeriodAmount
        {
            get
            {
                if (this.stubCalculationPeriodAmount != null)
                {
                    return this.stubCalculationPeriodAmount; 
                }
                else if (this.stubCalculationPeriodAmountIDRef != null)
                {
                    stubCalculationPeriodAmount = IDManager.getID(stubCalculationPeriodAmountIDRef) as StubCalculationPeriodAmount;
                    return this.stubCalculationPeriodAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.stubCalculationPeriodAmount != value)
                {
                    this.stubCalculationPeriodAmount = value;
                }
            }
        }
        #endregion
        
        public string StubCalculationPeriodAmountIDRef { get; set; }
        #region PrincipalExchanges
        private PrincipalExchanges principalExchanges;
        public PrincipalExchanges PrincipalExchanges
        {
            get
            {
                if (this.principalExchanges != null)
                {
                    return this.principalExchanges; 
                }
                else if (this.principalExchangesIDRef != null)
                {
                    principalExchanges = IDManager.getID(principalExchangesIDRef) as PrincipalExchanges;
                    return this.principalExchanges; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.principalExchanges != value)
                {
                    this.principalExchanges = value;
                }
            }
        }
        #endregion
        
        public string PrincipalExchangesIDRef { get; set; }
        #region Cashflows
        private Cashflows cashflows;
        public Cashflows Cashflows
        {
            get
            {
                if (this.cashflows != null)
                {
                    return this.cashflows; 
                }
                else if (this.cashflowsIDRef != null)
                {
                    cashflows = IDManager.getID(cashflowsIDRef) as Cashflows;
                    return this.cashflows; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashflows != value)
                {
                    this.cashflows = value;
                }
            }
        }
        #endregion
        
        public string CashflowsIDRef { get; set; }
        #region SettlementProvision
        private SettlementProvision settlementProvision;
        public SettlementProvision SettlementProvision
        {
            get
            {
                if (this.settlementProvision != null)
                {
                    return this.settlementProvision; 
                }
                else if (this.settlementProvisionIDRef != null)
                {
                    settlementProvision = IDManager.getID(settlementProvisionIDRef) as SettlementProvision;
                    return this.settlementProvision; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementProvision != value)
                {
                    this.settlementProvision = value;
                }
            }
        }
        #endregion
        
        public string SettlementProvisionIDRef { get; set; }
        #region Formula
        private Formula formula;
        public Formula Formula
        {
            get
            {
                if (this.formula != null)
                {
                    return this.formula; 
                }
                else if (this.formulaIDRef != null)
                {
                    formula = IDManager.getID(formulaIDRef) as Formula;
                    return this.formula; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.formula != value)
                {
                    this.formula = value;
                }
            }
        }
        #endregion
        
        public string FormulaIDRef { get; set; }
        
    
        
    
    }
    
}

