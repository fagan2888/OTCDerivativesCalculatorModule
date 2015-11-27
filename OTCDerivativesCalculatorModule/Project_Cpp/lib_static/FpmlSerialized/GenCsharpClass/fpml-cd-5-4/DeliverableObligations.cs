using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DeliverableObligations
    {
        public DeliverableObligations(XmlNode xmlNode)
        {
            XmlNodeList accruedInterestNodeList = xmlNode.SelectNodes("accruedInterest");
            if (accruedInterestNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accruedInterestNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accruedInterestIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(accruedInterestIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accruedInterestIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accruedInterest = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList categoryNodeList = xmlNode.SelectNodes("category");
            if (categoryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in categoryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        categoryIDRef = item.Attributes["id"].Name;
                        ObligationCategoryEnum ob = ObligationCategoryEnum();
                        IDManager.SetID(categoryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        categoryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        category = new ObligationCategoryEnum(item);
                    }
                }
            }
            
        
            XmlNodeList notSubordinatedNodeList = xmlNode.SelectNodes("notSubordinated");
            if (notSubordinatedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notSubordinatedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notSubordinatedIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(notSubordinatedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notSubordinatedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notSubordinated = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList specifiedCurrencyNodeList = xmlNode.SelectNodes("specifiedCurrency");
            if (specifiedCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in specifiedCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        specifiedCurrencyIDRef = item.Attributes["id"].Name;
                        SpecifiedCurrency ob = SpecifiedCurrency();
                        IDManager.SetID(specifiedCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        specifiedCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        specifiedCurrency = new SpecifiedCurrency(item);
                    }
                }
            }
            
        
            XmlNodeList notSovereignLenderNodeList = xmlNode.SelectNodes("notSovereignLender");
            if (notSovereignLenderNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notSovereignLenderNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notSovereignLenderIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(notSovereignLenderIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notSovereignLenderIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notSovereignLender = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList notDomesticCurrencyNodeList = xmlNode.SelectNodes("notDomesticCurrency");
            if (notDomesticCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notDomesticCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notDomesticCurrencyIDRef = item.Attributes["id"].Name;
                        NotDomesticCurrency ob = NotDomesticCurrency();
                        IDManager.SetID(notDomesticCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notDomesticCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notDomesticCurrency = new NotDomesticCurrency(item);
                    }
                }
            }
            
        
            XmlNodeList notDomesticLawNodeList = xmlNode.SelectNodes("notDomesticLaw");
            if (notDomesticLawNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notDomesticLawNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notDomesticLawIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(notDomesticLawIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notDomesticLawIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notDomesticLaw = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList listedNodeList = xmlNode.SelectNodes("listed");
            if (listedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in listedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        listedIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(listedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        listedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        listed = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList notContingentNodeList = xmlNode.SelectNodes("notContingent");
            if (notContingentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notContingentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notContingentIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(notContingentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notContingentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notContingent = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList notDomesticIssuanceNodeList = xmlNode.SelectNodes("notDomesticIssuance");
            if (notDomesticIssuanceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notDomesticIssuanceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notDomesticIssuanceIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(notDomesticIssuanceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notDomesticIssuanceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notDomesticIssuance = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList assignableLoanNodeList = xmlNode.SelectNodes("assignableLoan");
            if (assignableLoanNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in assignableLoanNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        assignableLoanIDRef = item.Attributes["id"].Name;
                        PCDeliverableObligationCharac ob = PCDeliverableObligationCharac();
                        IDManager.SetID(assignableLoanIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        assignableLoanIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        assignableLoan = new PCDeliverableObligationCharac(item);
                    }
                }
            }
            
        
            XmlNodeList consentRequiredLoanNodeList = xmlNode.SelectNodes("consentRequiredLoan");
            if (consentRequiredLoanNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in consentRequiredLoanNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        consentRequiredLoanIDRef = item.Attributes["id"].Name;
                        PCDeliverableObligationCharac ob = PCDeliverableObligationCharac();
                        IDManager.SetID(consentRequiredLoanIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        consentRequiredLoanIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        consentRequiredLoan = new PCDeliverableObligationCharac(item);
                    }
                }
            }
            
        
            XmlNodeList directLoanParticipationNodeList = xmlNode.SelectNodes("directLoanParticipation");
            if (directLoanParticipationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in directLoanParticipationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        directLoanParticipationIDRef = item.Attributes["id"].Name;
                        LoanParticipation ob = LoanParticipation();
                        IDManager.SetID(directLoanParticipationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        directLoanParticipationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        directLoanParticipation = new LoanParticipation(item);
                    }
                }
            }
            
        
            XmlNodeList transferableNodeList = xmlNode.SelectNodes("transferable");
            if (transferableNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in transferableNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        transferableIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(transferableIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        transferableIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        transferable = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList maximumMaturityNodeList = xmlNode.SelectNodes("maximumMaturity");
            if (maximumMaturityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumMaturityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumMaturityIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(maximumMaturityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumMaturityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumMaturity = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList acceleratedOrMaturedNodeList = xmlNode.SelectNodes("acceleratedOrMatured");
            if (acceleratedOrMaturedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in acceleratedOrMaturedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        acceleratedOrMaturedIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(acceleratedOrMaturedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        acceleratedOrMaturedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        acceleratedOrMatured = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList notBearerNodeList = xmlNode.SelectNodes("notBearer");
            if (notBearerNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in notBearerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        notBearerIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(notBearerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        notBearerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        notBearer = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList fullFaithAndCreditObLiabilityNodeList = xmlNode.SelectNodes("fullFaithAndCreditObLiability");
            if (fullFaithAndCreditObLiabilityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fullFaithAndCreditObLiabilityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fullFaithAndCreditObLiabilityIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(fullFaithAndCreditObLiabilityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fullFaithAndCreditObLiabilityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fullFaithAndCreditObLiability = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList generalFundObligationLiabilityNodeList = xmlNode.SelectNodes("generalFundObligationLiability");
            if (generalFundObligationLiabilityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in generalFundObligationLiabilityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        generalFundObligationLiabilityIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(generalFundObligationLiabilityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        generalFundObligationLiabilityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        generalFundObligationLiability = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList revenueObligationLiabilityNodeList = xmlNode.SelectNodes("revenueObligationLiability");
            if (revenueObligationLiabilityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in revenueObligationLiabilityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        revenueObligationLiabilityIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(revenueObligationLiabilityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        revenueObligationLiabilityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        revenueObligationLiability = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList indirectLoanParticipationNodeList = xmlNode.SelectNodes("indirectLoanParticipation");
            if (indirectLoanParticipationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indirectLoanParticipationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indirectLoanParticipationIDRef = item.Attributes["id"].Name;
                        LoanParticipation ob = LoanParticipation();
                        IDManager.SetID(indirectLoanParticipationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indirectLoanParticipationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indirectLoanParticipation = new LoanParticipation(item);
                    }
                }
            }
            
        
            XmlNodeList excludedNodeList = xmlNode.SelectNodes("excluded");
            if (excludedNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in excludedNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        excludedIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(excludedIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        excludedIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        excluded = new XsdTypeString(item);
                    }
                }
            }
            
        
            XmlNodeList othReferenceEntityObligationsNodeList = xmlNode.SelectNodes("othReferenceEntityObligations");
            if (othReferenceEntityObligationsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in othReferenceEntityObligationsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        othReferenceEntityObligationsIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = XsdTypeString();
                        IDManager.SetID(othReferenceEntityObligationsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        othReferenceEntityObligationsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        othReferenceEntityObligations = new XsdTypeString(item);
                    }
                }
            }
            
        
        }
        
    
        #region AccruedInterest
        private XsdTypeBoolean accruedInterest;
        public XsdTypeBoolean AccruedInterest
        {
            get
            {
                if (this.accruedInterest != null)
                {
                    return this.accruedInterest; 
                }
                else if (this.accruedInterestIDRef != null)
                {
                    accruedInterest = IDManager.getID(accruedInterestIDRef) as XsdTypeBoolean;
                    return this.accruedInterest; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accruedInterest != value)
                {
                    this.accruedInterest = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Category
        private ObligationCategoryEnum category;
        public ObligationCategoryEnum Category
        {
            get
            {
                if (this.category != null)
                {
                    return this.category; 
                }
                else if (this.categoryIDRef != null)
                {
                    category = IDManager.getID(categoryIDRef) as ObligationCategoryEnum;
                    return this.category; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.category != value)
                {
                    this.category = value;
                }
            }
        }
        #endregion
        
        public string ObligationCategoryEnumIDRef { get; set; }
        #region NotSubordinated
        private XsdTypeBoolean notSubordinated;
        public XsdTypeBoolean NotSubordinated
        {
            get
            {
                if (this.notSubordinated != null)
                {
                    return this.notSubordinated; 
                }
                else if (this.notSubordinatedIDRef != null)
                {
                    notSubordinated = IDManager.getID(notSubordinatedIDRef) as XsdTypeBoolean;
                    return this.notSubordinated; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notSubordinated != value)
                {
                    this.notSubordinated = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region SpecifiedCurrency
        private SpecifiedCurrency specifiedCurrency;
        public SpecifiedCurrency SpecifiedCurrency
        {
            get
            {
                if (this.specifiedCurrency != null)
                {
                    return this.specifiedCurrency; 
                }
                else if (this.specifiedCurrencyIDRef != null)
                {
                    specifiedCurrency = IDManager.getID(specifiedCurrencyIDRef) as SpecifiedCurrency;
                    return this.specifiedCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.specifiedCurrency != value)
                {
                    this.specifiedCurrency = value;
                }
            }
        }
        #endregion
        
        public string SpecifiedCurrencyIDRef { get; set; }
        #region NotSovereignLender
        private XsdTypeBoolean notSovereignLender;
        public XsdTypeBoolean NotSovereignLender
        {
            get
            {
                if (this.notSovereignLender != null)
                {
                    return this.notSovereignLender; 
                }
                else if (this.notSovereignLenderIDRef != null)
                {
                    notSovereignLender = IDManager.getID(notSovereignLenderIDRef) as XsdTypeBoolean;
                    return this.notSovereignLender; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notSovereignLender != value)
                {
                    this.notSovereignLender = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region NotDomesticCurrency
        private NotDomesticCurrency notDomesticCurrency;
        public NotDomesticCurrency NotDomesticCurrency
        {
            get
            {
                if (this.notDomesticCurrency != null)
                {
                    return this.notDomesticCurrency; 
                }
                else if (this.notDomesticCurrencyIDRef != null)
                {
                    notDomesticCurrency = IDManager.getID(notDomesticCurrencyIDRef) as NotDomesticCurrency;
                    return this.notDomesticCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notDomesticCurrency != value)
                {
                    this.notDomesticCurrency = value;
                }
            }
        }
        #endregion
        
        public string NotDomesticCurrencyIDRef { get; set; }
        #region NotDomesticLaw
        private XsdTypeBoolean notDomesticLaw;
        public XsdTypeBoolean NotDomesticLaw
        {
            get
            {
                if (this.notDomesticLaw != null)
                {
                    return this.notDomesticLaw; 
                }
                else if (this.notDomesticLawIDRef != null)
                {
                    notDomesticLaw = IDManager.getID(notDomesticLawIDRef) as XsdTypeBoolean;
                    return this.notDomesticLaw; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notDomesticLaw != value)
                {
                    this.notDomesticLaw = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Listed
        private XsdTypeBoolean listed;
        public XsdTypeBoolean Listed
        {
            get
            {
                if (this.listed != null)
                {
                    return this.listed; 
                }
                else if (this.listedIDRef != null)
                {
                    listed = IDManager.getID(listedIDRef) as XsdTypeBoolean;
                    return this.listed; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.listed != value)
                {
                    this.listed = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region NotContingent
        private XsdTypeBoolean notContingent;
        public XsdTypeBoolean NotContingent
        {
            get
            {
                if (this.notContingent != null)
                {
                    return this.notContingent; 
                }
                else if (this.notContingentIDRef != null)
                {
                    notContingent = IDManager.getID(notContingentIDRef) as XsdTypeBoolean;
                    return this.notContingent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notContingent != value)
                {
                    this.notContingent = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region NotDomesticIssuance
        private XsdTypeBoolean notDomesticIssuance;
        public XsdTypeBoolean NotDomesticIssuance
        {
            get
            {
                if (this.notDomesticIssuance != null)
                {
                    return this.notDomesticIssuance; 
                }
                else if (this.notDomesticIssuanceIDRef != null)
                {
                    notDomesticIssuance = IDManager.getID(notDomesticIssuanceIDRef) as XsdTypeBoolean;
                    return this.notDomesticIssuance; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notDomesticIssuance != value)
                {
                    this.notDomesticIssuance = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AssignableLoan
        private PCDeliverableObligationCharac assignableLoan;
        public PCDeliverableObligationCharac AssignableLoan
        {
            get
            {
                if (this.assignableLoan != null)
                {
                    return this.assignableLoan; 
                }
                else if (this.assignableLoanIDRef != null)
                {
                    assignableLoan = IDManager.getID(assignableLoanIDRef) as PCDeliverableObligationCharac;
                    return this.assignableLoan; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.assignableLoan != value)
                {
                    this.assignableLoan = value;
                }
            }
        }
        #endregion
        
        public string PCDeliverableObligationCharacIDRef { get; set; }
        #region ConsentRequiredLoan
        private PCDeliverableObligationCharac consentRequiredLoan;
        public PCDeliverableObligationCharac ConsentRequiredLoan
        {
            get
            {
                if (this.consentRequiredLoan != null)
                {
                    return this.consentRequiredLoan; 
                }
                else if (this.consentRequiredLoanIDRef != null)
                {
                    consentRequiredLoan = IDManager.getID(consentRequiredLoanIDRef) as PCDeliverableObligationCharac;
                    return this.consentRequiredLoan; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.consentRequiredLoan != value)
                {
                    this.consentRequiredLoan = value;
                }
            }
        }
        #endregion
        
        public string PCDeliverableObligationCharacIDRef { get; set; }
        #region DirectLoanParticipation
        private LoanParticipation directLoanParticipation;
        public LoanParticipation DirectLoanParticipation
        {
            get
            {
                if (this.directLoanParticipation != null)
                {
                    return this.directLoanParticipation; 
                }
                else if (this.directLoanParticipationIDRef != null)
                {
                    directLoanParticipation = IDManager.getID(directLoanParticipationIDRef) as LoanParticipation;
                    return this.directLoanParticipation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.directLoanParticipation != value)
                {
                    this.directLoanParticipation = value;
                }
            }
        }
        #endregion
        
        public string LoanParticipationIDRef { get; set; }
        #region Transferable
        private XsdTypeBoolean transferable;
        public XsdTypeBoolean Transferable
        {
            get
            {
                if (this.transferable != null)
                {
                    return this.transferable; 
                }
                else if (this.transferableIDRef != null)
                {
                    transferable = IDManager.getID(transferableIDRef) as XsdTypeBoolean;
                    return this.transferable; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.transferable != value)
                {
                    this.transferable = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region MaximumMaturity
        private Period maximumMaturity;
        public Period MaximumMaturity
        {
            get
            {
                if (this.maximumMaturity != null)
                {
                    return this.maximumMaturity; 
                }
                else if (this.maximumMaturityIDRef != null)
                {
                    maximumMaturity = IDManager.getID(maximumMaturityIDRef) as Period;
                    return this.maximumMaturity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumMaturity != value)
                {
                    this.maximumMaturity = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region AcceleratedOrMatured
        private XsdTypeBoolean acceleratedOrMatured;
        public XsdTypeBoolean AcceleratedOrMatured
        {
            get
            {
                if (this.acceleratedOrMatured != null)
                {
                    return this.acceleratedOrMatured; 
                }
                else if (this.acceleratedOrMaturedIDRef != null)
                {
                    acceleratedOrMatured = IDManager.getID(acceleratedOrMaturedIDRef) as XsdTypeBoolean;
                    return this.acceleratedOrMatured; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.acceleratedOrMatured != value)
                {
                    this.acceleratedOrMatured = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region NotBearer
        private XsdTypeBoolean notBearer;
        public XsdTypeBoolean NotBearer
        {
            get
            {
                if (this.notBearer != null)
                {
                    return this.notBearer; 
                }
                else if (this.notBearerIDRef != null)
                {
                    notBearer = IDManager.getID(notBearerIDRef) as XsdTypeBoolean;
                    return this.notBearer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.notBearer != value)
                {
                    this.notBearer = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region FullFaithAndCreditObLiability
        private XsdTypeBoolean fullFaithAndCreditObLiability;
        public XsdTypeBoolean FullFaithAndCreditObLiability
        {
            get
            {
                if (this.fullFaithAndCreditObLiability != null)
                {
                    return this.fullFaithAndCreditObLiability; 
                }
                else if (this.fullFaithAndCreditObLiabilityIDRef != null)
                {
                    fullFaithAndCreditObLiability = IDManager.getID(fullFaithAndCreditObLiabilityIDRef) as XsdTypeBoolean;
                    return this.fullFaithAndCreditObLiability; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fullFaithAndCreditObLiability != value)
                {
                    this.fullFaithAndCreditObLiability = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region GeneralFundObligationLiability
        private XsdTypeBoolean generalFundObligationLiability;
        public XsdTypeBoolean GeneralFundObligationLiability
        {
            get
            {
                if (this.generalFundObligationLiability != null)
                {
                    return this.generalFundObligationLiability; 
                }
                else if (this.generalFundObligationLiabilityIDRef != null)
                {
                    generalFundObligationLiability = IDManager.getID(generalFundObligationLiabilityIDRef) as XsdTypeBoolean;
                    return this.generalFundObligationLiability; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.generalFundObligationLiability != value)
                {
                    this.generalFundObligationLiability = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region RevenueObligationLiability
        private XsdTypeBoolean revenueObligationLiability;
        public XsdTypeBoolean RevenueObligationLiability
        {
            get
            {
                if (this.revenueObligationLiability != null)
                {
                    return this.revenueObligationLiability; 
                }
                else if (this.revenueObligationLiabilityIDRef != null)
                {
                    revenueObligationLiability = IDManager.getID(revenueObligationLiabilityIDRef) as XsdTypeBoolean;
                    return this.revenueObligationLiability; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.revenueObligationLiability != value)
                {
                    this.revenueObligationLiability = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region IndirectLoanParticipation
        private LoanParticipation indirectLoanParticipation;
        public LoanParticipation IndirectLoanParticipation
        {
            get
            {
                if (this.indirectLoanParticipation != null)
                {
                    return this.indirectLoanParticipation; 
                }
                else if (this.indirectLoanParticipationIDRef != null)
                {
                    indirectLoanParticipation = IDManager.getID(indirectLoanParticipationIDRef) as LoanParticipation;
                    return this.indirectLoanParticipation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indirectLoanParticipation != value)
                {
                    this.indirectLoanParticipation = value;
                }
            }
        }
        #endregion
        
        public string LoanParticipationIDRef { get; set; }
        #region Excluded
        private XsdTypeString excluded;
        public XsdTypeString Excluded
        {
            get
            {
                if (this.excluded != null)
                {
                    return this.excluded; 
                }
                else if (this.excludedIDRef != null)
                {
                    excluded = IDManager.getID(excludedIDRef) as XsdTypeString;
                    return this.excluded; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.excluded != value)
                {
                    this.excluded = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region OthReferenceEntityObligations
        private XsdTypeString othReferenceEntityObligations;
        public XsdTypeString OthReferenceEntityObligations
        {
            get
            {
                if (this.othReferenceEntityObligations != null)
                {
                    return this.othReferenceEntityObligations; 
                }
                else if (this.othReferenceEntityObligationsIDRef != null)
                {
                    othReferenceEntityObligations = IDManager.getID(othReferenceEntityObligationsIDRef) as XsdTypeString;
                    return this.othReferenceEntityObligations; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.othReferenceEntityObligations != value)
                {
                    this.othReferenceEntityObligations = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

