using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class InterestRateStream : Leg
    {
        public InterestRateStream(XmlNode xmlNode)
        : base(xmlNode)
        {
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
            
        
            XmlNode calculationPeriodDatesNode = xmlNode.SelectSingleNode("calculationPeriodDates");
            
            if (calculationPeriodDatesNode != null)
            {
                if (calculationPeriodDatesNode.Attributes["href"] != null || calculationPeriodDatesNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodDatesNode.Attributes["id"] != null) 
                    {
                        calculationPeriodDatesIDRef_ = calculationPeriodDatesNode.Attributes["id"].Value;
                        CalculationPeriodDates ob = new CalculationPeriodDates(calculationPeriodDatesNode);
                        IDManager.SetID(calculationPeriodDatesIDRef_, ob);
                    }
                    else if (calculationPeriodDatesNode.Attributes["href"] != null)
                    {
                        calculationPeriodDatesIDRef_ = calculationPeriodDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodDates_ = new CalculationPeriodDates(calculationPeriodDatesNode);
                    }
                }
                else
                {
                    calculationPeriodDates_ = new CalculationPeriodDates(calculationPeriodDatesNode);
                }
            }
            
        
            XmlNode paymentDatesNode = xmlNode.SelectSingleNode("paymentDates");
            
            if (paymentDatesNode != null)
            {
                if (paymentDatesNode.Attributes["href"] != null || paymentDatesNode.Attributes["id"] != null) 
                {
                    if (paymentDatesNode.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["id"].Value;
                        PaymentDates ob = new PaymentDates(paymentDatesNode);
                        IDManager.SetID(paymentDatesIDRef_, ob);
                    }
                    else if (paymentDatesNode.Attributes["href"] != null)
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDates_ = new PaymentDates(paymentDatesNode);
                    }
                }
                else
                {
                    paymentDates_ = new PaymentDates(paymentDatesNode);
                }
            }
            
        
            XmlNode resetDatesNode = xmlNode.SelectSingleNode("resetDates");
            
            if (resetDatesNode != null)
            {
                if (resetDatesNode.Attributes["href"] != null || resetDatesNode.Attributes["id"] != null) 
                {
                    if (resetDatesNode.Attributes["id"] != null) 
                    {
                        resetDatesIDRef_ = resetDatesNode.Attributes["id"].Value;
                        ResetDates ob = new ResetDates(resetDatesNode);
                        IDManager.SetID(resetDatesIDRef_, ob);
                    }
                    else if (resetDatesNode.Attributes["href"] != null)
                    {
                        resetDatesIDRef_ = resetDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        resetDates_ = new ResetDates(resetDatesNode);
                    }
                }
                else
                {
                    resetDates_ = new ResetDates(resetDatesNode);
                }
            }
            
        
            XmlNode calculationPeriodAmountNode = xmlNode.SelectSingleNode("calculationPeriodAmount");
            
            if (calculationPeriodAmountNode != null)
            {
                if (calculationPeriodAmountNode.Attributes["href"] != null || calculationPeriodAmountNode.Attributes["id"] != null) 
                {
                    if (calculationPeriodAmountNode.Attributes["id"] != null) 
                    {
                        calculationPeriodAmountIDRef_ = calculationPeriodAmountNode.Attributes["id"].Value;
                        CalculationPeriodAmount ob = new CalculationPeriodAmount(calculationPeriodAmountNode);
                        IDManager.SetID(calculationPeriodAmountIDRef_, ob);
                    }
                    else if (calculationPeriodAmountNode.Attributes["href"] != null)
                    {
                        calculationPeriodAmountIDRef_ = calculationPeriodAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculationPeriodAmount_ = new CalculationPeriodAmount(calculationPeriodAmountNode);
                    }
                }
                else
                {
                    calculationPeriodAmount_ = new CalculationPeriodAmount(calculationPeriodAmountNode);
                }
            }
            
        
            XmlNode stubCalculationPeriodAmountNode = xmlNode.SelectSingleNode("stubCalculationPeriodAmount");
            
            if (stubCalculationPeriodAmountNode != null)
            {
                if (stubCalculationPeriodAmountNode.Attributes["href"] != null || stubCalculationPeriodAmountNode.Attributes["id"] != null) 
                {
                    if (stubCalculationPeriodAmountNode.Attributes["id"] != null) 
                    {
                        stubCalculationPeriodAmountIDRef_ = stubCalculationPeriodAmountNode.Attributes["id"].Value;
                        StubCalculationPeriodAmount ob = new StubCalculationPeriodAmount(stubCalculationPeriodAmountNode);
                        IDManager.SetID(stubCalculationPeriodAmountIDRef_, ob);
                    }
                    else if (stubCalculationPeriodAmountNode.Attributes["href"] != null)
                    {
                        stubCalculationPeriodAmountIDRef_ = stubCalculationPeriodAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        stubCalculationPeriodAmount_ = new StubCalculationPeriodAmount(stubCalculationPeriodAmountNode);
                    }
                }
                else
                {
                    stubCalculationPeriodAmount_ = new StubCalculationPeriodAmount(stubCalculationPeriodAmountNode);
                }
            }
            
        
            XmlNode principalExchangesNode = xmlNode.SelectSingleNode("principalExchanges");
            
            if (principalExchangesNode != null)
            {
                if (principalExchangesNode.Attributes["href"] != null || principalExchangesNode.Attributes["id"] != null) 
                {
                    if (principalExchangesNode.Attributes["id"] != null) 
                    {
                        principalExchangesIDRef_ = principalExchangesNode.Attributes["id"].Value;
                        PrincipalExchanges ob = new PrincipalExchanges(principalExchangesNode);
                        IDManager.SetID(principalExchangesIDRef_, ob);
                    }
                    else if (principalExchangesNode.Attributes["href"] != null)
                    {
                        principalExchangesIDRef_ = principalExchangesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        principalExchanges_ = new PrincipalExchanges(principalExchangesNode);
                    }
                }
                else
                {
                    principalExchanges_ = new PrincipalExchanges(principalExchangesNode);
                }
            }
            
        
            XmlNode cashflowsNode = xmlNode.SelectSingleNode("cashflows");
            
            if (cashflowsNode != null)
            {
                if (cashflowsNode.Attributes["href"] != null || cashflowsNode.Attributes["id"] != null) 
                {
                    if (cashflowsNode.Attributes["id"] != null) 
                    {
                        cashflowsIDRef_ = cashflowsNode.Attributes["id"].Value;
                        Cashflows ob = new Cashflows(cashflowsNode);
                        IDManager.SetID(cashflowsIDRef_, ob);
                    }
                    else if (cashflowsNode.Attributes["href"] != null)
                    {
                        cashflowsIDRef_ = cashflowsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashflows_ = new Cashflows(cashflowsNode);
                    }
                }
                else
                {
                    cashflows_ = new Cashflows(cashflowsNode);
                }
            }
            
        
            XmlNode settlementProvisionNode = xmlNode.SelectSingleNode("settlementProvision");
            
            if (settlementProvisionNode != null)
            {
                if (settlementProvisionNode.Attributes["href"] != null || settlementProvisionNode.Attributes["id"] != null) 
                {
                    if (settlementProvisionNode.Attributes["id"] != null) 
                    {
                        settlementProvisionIDRef_ = settlementProvisionNode.Attributes["id"].Value;
                        SettlementProvision ob = new SettlementProvision(settlementProvisionNode);
                        IDManager.SetID(settlementProvisionIDRef_, ob);
                    }
                    else if (settlementProvisionNode.Attributes["href"] != null)
                    {
                        settlementProvisionIDRef_ = settlementProvisionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementProvision_ = new SettlementProvision(settlementProvisionNode);
                    }
                }
                else
                {
                    settlementProvision_ = new SettlementProvision(settlementProvisionNode);
                }
            }
            
        
            XmlNode formulaNode = xmlNode.SelectSingleNode("formula");
            
            if (formulaNode != null)
            {
                if (formulaNode.Attributes["href"] != null || formulaNode.Attributes["id"] != null) 
                {
                    if (formulaNode.Attributes["id"] != null) 
                    {
                        formulaIDRef_ = formulaNode.Attributes["id"].Value;
                        Formula ob = new Formula(formulaNode);
                        IDManager.SetID(formulaIDRef_, ob);
                    }
                    else if (formulaNode.Attributes["href"] != null)
                    {
                        formulaIDRef_ = formulaNode.Attributes["href"].Value;
                    }
                    else
                    {
                        formula_ = new Formula(formulaNode);
                    }
                }
                else
                {
                    formula_ = new Formula(formulaNode);
                }
            }
            
        
        }
        
    
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
        #region CalculationPeriodDates_
        private CalculationPeriodDates calculationPeriodDates_;
        public CalculationPeriodDates CalculationPeriodDates_
        {
            get
            {
                if (this.calculationPeriodDates_ != null)
                {
                    return this.calculationPeriodDates_; 
                }
                else if (this.calculationPeriodDatesIDRef_ != null)
                {
                    calculationPeriodDates_ = IDManager.getID(calculationPeriodDatesIDRef_) as CalculationPeriodDates;
                    return this.calculationPeriodDates_; 
                }
                else
                {
                      return this.calculationPeriodDates_; 
                }
            }
            set
            {
                if (this.calculationPeriodDates_ != value)
                {
                    this.calculationPeriodDates_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodDatesIDRef_ { get; set; }
        #region PaymentDates_
        private PaymentDates paymentDates_;
        public PaymentDates PaymentDates_
        {
            get
            {
                if (this.paymentDates_ != null)
                {
                    return this.paymentDates_; 
                }
                else if (this.paymentDatesIDRef_ != null)
                {
                    paymentDates_ = IDManager.getID(paymentDatesIDRef_) as PaymentDates;
                    return this.paymentDates_; 
                }
                else
                {
                      return this.paymentDates_; 
                }
            }
            set
            {
                if (this.paymentDates_ != value)
                {
                    this.paymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDatesIDRef_ { get; set; }
        #region ResetDates_
        private ResetDates resetDates_;
        public ResetDates ResetDates_
        {
            get
            {
                if (this.resetDates_ != null)
                {
                    return this.resetDates_; 
                }
                else if (this.resetDatesIDRef_ != null)
                {
                    resetDates_ = IDManager.getID(resetDatesIDRef_) as ResetDates;
                    return this.resetDates_; 
                }
                else
                {
                      return this.resetDates_; 
                }
            }
            set
            {
                if (this.resetDates_ != value)
                {
                    this.resetDates_ = value;
                }
            }
        }
        #endregion
        
        public string resetDatesIDRef_ { get; set; }
        #region CalculationPeriodAmount_
        private CalculationPeriodAmount calculationPeriodAmount_;
        public CalculationPeriodAmount CalculationPeriodAmount_
        {
            get
            {
                if (this.calculationPeriodAmount_ != null)
                {
                    return this.calculationPeriodAmount_; 
                }
                else if (this.calculationPeriodAmountIDRef_ != null)
                {
                    calculationPeriodAmount_ = IDManager.getID(calculationPeriodAmountIDRef_) as CalculationPeriodAmount;
                    return this.calculationPeriodAmount_; 
                }
                else
                {
                      return this.calculationPeriodAmount_; 
                }
            }
            set
            {
                if (this.calculationPeriodAmount_ != value)
                {
                    this.calculationPeriodAmount_ = value;
                }
            }
        }
        #endregion
        
        public string calculationPeriodAmountIDRef_ { get; set; }
        #region StubCalculationPeriodAmount_
        private StubCalculationPeriodAmount stubCalculationPeriodAmount_;
        public StubCalculationPeriodAmount StubCalculationPeriodAmount_
        {
            get
            {
                if (this.stubCalculationPeriodAmount_ != null)
                {
                    return this.stubCalculationPeriodAmount_; 
                }
                else if (this.stubCalculationPeriodAmountIDRef_ != null)
                {
                    stubCalculationPeriodAmount_ = IDManager.getID(stubCalculationPeriodAmountIDRef_) as StubCalculationPeriodAmount;
                    return this.stubCalculationPeriodAmount_; 
                }
                else
                {
                      return this.stubCalculationPeriodAmount_; 
                }
            }
            set
            {
                if (this.stubCalculationPeriodAmount_ != value)
                {
                    this.stubCalculationPeriodAmount_ = value;
                }
            }
        }
        #endregion
        
        public string stubCalculationPeriodAmountIDRef_ { get; set; }
        #region PrincipalExchanges_
        private PrincipalExchanges principalExchanges_;
        public PrincipalExchanges PrincipalExchanges_
        {
            get
            {
                if (this.principalExchanges_ != null)
                {
                    return this.principalExchanges_; 
                }
                else if (this.principalExchangesIDRef_ != null)
                {
                    principalExchanges_ = IDManager.getID(principalExchangesIDRef_) as PrincipalExchanges;
                    return this.principalExchanges_; 
                }
                else
                {
                      return this.principalExchanges_; 
                }
            }
            set
            {
                if (this.principalExchanges_ != value)
                {
                    this.principalExchanges_ = value;
                }
            }
        }
        #endregion
        
        public string principalExchangesIDRef_ { get; set; }
        #region Cashflows_
        private Cashflows cashflows_;
        public Cashflows Cashflows_
        {
            get
            {
                if (this.cashflows_ != null)
                {
                    return this.cashflows_; 
                }
                else if (this.cashflowsIDRef_ != null)
                {
                    cashflows_ = IDManager.getID(cashflowsIDRef_) as Cashflows;
                    return this.cashflows_; 
                }
                else
                {
                      return this.cashflows_; 
                }
            }
            set
            {
                if (this.cashflows_ != value)
                {
                    this.cashflows_ = value;
                }
            }
        }
        #endregion
        
        public string cashflowsIDRef_ { get; set; }
        #region SettlementProvision_
        private SettlementProvision settlementProvision_;
        public SettlementProvision SettlementProvision_
        {
            get
            {
                if (this.settlementProvision_ != null)
                {
                    return this.settlementProvision_; 
                }
                else if (this.settlementProvisionIDRef_ != null)
                {
                    settlementProvision_ = IDManager.getID(settlementProvisionIDRef_) as SettlementProvision;
                    return this.settlementProvision_; 
                }
                else
                {
                      return this.settlementProvision_; 
                }
            }
            set
            {
                if (this.settlementProvision_ != value)
                {
                    this.settlementProvision_ = value;
                }
            }
        }
        #endregion
        
        public string settlementProvisionIDRef_ { get; set; }
        #region Formula_
        private Formula formula_;
        public Formula Formula_
        {
            get
            {
                if (this.formula_ != null)
                {
                    return this.formula_; 
                }
                else if (this.formulaIDRef_ != null)
                {
                    formula_ = IDManager.getID(formulaIDRef_) as Formula;
                    return this.formula_; 
                }
                else
                {
                      return this.formula_; 
                }
            }
            set
            {
                if (this.formula_ != value)
                {
                    this.formula_ = value;
                }
            }
        }
        #endregion
        
        public string formulaIDRef_ { get; set; }
        
    
        
    
    }
    
}

