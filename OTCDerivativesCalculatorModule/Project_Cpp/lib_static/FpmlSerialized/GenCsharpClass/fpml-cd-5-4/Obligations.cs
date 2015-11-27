using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class Obligations
    {
        public Obligations(XmlNode xmlNode)
        {
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
            
        
            XmlNodeList designatedPriorityNodeList = xmlNode.SelectNodes("designatedPriority");
            if (designatedPriorityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in designatedPriorityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        designatedPriorityIDRef = item.Attributes["id"].Name;
                        Lien ob = Lien();
                        IDManager.SetID(designatedPriorityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        designatedPriorityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        designatedPriority = new Lien(item);
                    }
                }
            }
            
        
            XmlNodeList cashSettlementOnlyNodeList = xmlNode.SelectNodes("cashSettlementOnly");
            if (cashSettlementOnlyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementOnlyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementOnlyIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(cashSettlementOnlyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementOnlyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlementOnly = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList deliveryOfCommitmentsNodeList = xmlNode.SelectNodes("deliveryOfCommitments");
            if (deliveryOfCommitmentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in deliveryOfCommitmentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        deliveryOfCommitmentsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(deliveryOfCommitmentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        deliveryOfCommitmentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        deliveryOfCommitments = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList continuityNodeList = xmlNode.SelectNodes("continuity");
            if (continuityNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in continuityNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        continuityIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(continuityIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        continuityIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        continuity = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
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
        #region DesignatedPriority
        private Lien designatedPriority;
        public Lien DesignatedPriority
        {
            get
            {
                if (this.designatedPriority != null)
                {
                    return this.designatedPriority; 
                }
                else if (this.designatedPriorityIDRef != null)
                {
                    designatedPriority = IDManager.getID(designatedPriorityIDRef) as Lien;
                    return this.designatedPriority; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.designatedPriority != value)
                {
                    this.designatedPriority = value;
                }
            }
        }
        #endregion
        
        public string LienIDRef { get; set; }
        #region CashSettlementOnly
        private XsdTypeBoolean cashSettlementOnly;
        public XsdTypeBoolean CashSettlementOnly
        {
            get
            {
                if (this.cashSettlementOnly != null)
                {
                    return this.cashSettlementOnly; 
                }
                else if (this.cashSettlementOnlyIDRef != null)
                {
                    cashSettlementOnly = IDManager.getID(cashSettlementOnlyIDRef) as XsdTypeBoolean;
                    return this.cashSettlementOnly; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlementOnly != value)
                {
                    this.cashSettlementOnly = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region DeliveryOfCommitments
        private XsdTypeBoolean deliveryOfCommitments;
        public XsdTypeBoolean DeliveryOfCommitments
        {
            get
            {
                if (this.deliveryOfCommitments != null)
                {
                    return this.deliveryOfCommitments; 
                }
                else if (this.deliveryOfCommitmentsIDRef != null)
                {
                    deliveryOfCommitments = IDManager.getID(deliveryOfCommitmentsIDRef) as XsdTypeBoolean;
                    return this.deliveryOfCommitments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.deliveryOfCommitments != value)
                {
                    this.deliveryOfCommitments = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Continuity
        private XsdTypeBoolean continuity;
        public XsdTypeBoolean Continuity
        {
            get
            {
                if (this.continuity != null)
                {
                    return this.continuity; 
                }
                else if (this.continuityIDRef != null)
                {
                    continuity = IDManager.getID(continuityIDRef) as XsdTypeBoolean;
                    return this.continuity; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.continuity != value)
                {
                    this.continuity = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

