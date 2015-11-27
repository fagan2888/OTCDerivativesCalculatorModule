using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class Obligations : ISerialized
    {
        public Obligations(XmlNode xmlNode)
        {
            XmlNode categoryNode = xmlNode.SelectSingleNode("category");
            
            if (categoryNode != null)
            {
                if (categoryNode.Attributes["href"] != null || categoryNode.Attributes["id"] != null) 
                {
                    if (categoryNode.Attributes["id"] != null) 
                    {
                        categoryIDRef_ = categoryNode.Attributes["id"].Value;
                        ObligationCategoryEnum ob = new ObligationCategoryEnum(categoryNode);
                        IDManager.SetID(categoryIDRef_, ob);
                    }
                    else if (categoryNode.Attributes["href"] != null)
                    {
                        categoryIDRef_ = categoryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        category_ = new ObligationCategoryEnum(categoryNode);
                    }
                }
                else
                {
                    category_ = new ObligationCategoryEnum(categoryNode);
                }
            }
            
        
            XmlNode notSubordinatedNode = xmlNode.SelectSingleNode("notSubordinated");
            
            if (notSubordinatedNode != null)
            {
                if (notSubordinatedNode.Attributes["href"] != null || notSubordinatedNode.Attributes["id"] != null) 
                {
                    if (notSubordinatedNode.Attributes["id"] != null) 
                    {
                        notSubordinatedIDRef_ = notSubordinatedNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(notSubordinatedNode);
                        IDManager.SetID(notSubordinatedIDRef_, ob);
                    }
                    else if (notSubordinatedNode.Attributes["href"] != null)
                    {
                        notSubordinatedIDRef_ = notSubordinatedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notSubordinated_ = new XsdTypeBoolean(notSubordinatedNode);
                    }
                }
                else
                {
                    notSubordinated_ = new XsdTypeBoolean(notSubordinatedNode);
                }
            }
            
        
            XmlNode specifiedCurrencyNode = xmlNode.SelectSingleNode("specifiedCurrency");
            
            if (specifiedCurrencyNode != null)
            {
                if (specifiedCurrencyNode.Attributes["href"] != null || specifiedCurrencyNode.Attributes["id"] != null) 
                {
                    if (specifiedCurrencyNode.Attributes["id"] != null) 
                    {
                        specifiedCurrencyIDRef_ = specifiedCurrencyNode.Attributes["id"].Value;
                        SpecifiedCurrency ob = new SpecifiedCurrency(specifiedCurrencyNode);
                        IDManager.SetID(specifiedCurrencyIDRef_, ob);
                    }
                    else if (specifiedCurrencyNode.Attributes["href"] != null)
                    {
                        specifiedCurrencyIDRef_ = specifiedCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        specifiedCurrency_ = new SpecifiedCurrency(specifiedCurrencyNode);
                    }
                }
                else
                {
                    specifiedCurrency_ = new SpecifiedCurrency(specifiedCurrencyNode);
                }
            }
            
        
            XmlNode notSovereignLenderNode = xmlNode.SelectSingleNode("notSovereignLender");
            
            if (notSovereignLenderNode != null)
            {
                if (notSovereignLenderNode.Attributes["href"] != null || notSovereignLenderNode.Attributes["id"] != null) 
                {
                    if (notSovereignLenderNode.Attributes["id"] != null) 
                    {
                        notSovereignLenderIDRef_ = notSovereignLenderNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(notSovereignLenderNode);
                        IDManager.SetID(notSovereignLenderIDRef_, ob);
                    }
                    else if (notSovereignLenderNode.Attributes["href"] != null)
                    {
                        notSovereignLenderIDRef_ = notSovereignLenderNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notSovereignLender_ = new XsdTypeBoolean(notSovereignLenderNode);
                    }
                }
                else
                {
                    notSovereignLender_ = new XsdTypeBoolean(notSovereignLenderNode);
                }
            }
            
        
            XmlNode notDomesticCurrencyNode = xmlNode.SelectSingleNode("notDomesticCurrency");
            
            if (notDomesticCurrencyNode != null)
            {
                if (notDomesticCurrencyNode.Attributes["href"] != null || notDomesticCurrencyNode.Attributes["id"] != null) 
                {
                    if (notDomesticCurrencyNode.Attributes["id"] != null) 
                    {
                        notDomesticCurrencyIDRef_ = notDomesticCurrencyNode.Attributes["id"].Value;
                        NotDomesticCurrency ob = new NotDomesticCurrency(notDomesticCurrencyNode);
                        IDManager.SetID(notDomesticCurrencyIDRef_, ob);
                    }
                    else if (notDomesticCurrencyNode.Attributes["href"] != null)
                    {
                        notDomesticCurrencyIDRef_ = notDomesticCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notDomesticCurrency_ = new NotDomesticCurrency(notDomesticCurrencyNode);
                    }
                }
                else
                {
                    notDomesticCurrency_ = new NotDomesticCurrency(notDomesticCurrencyNode);
                }
            }
            
        
            XmlNode notDomesticLawNode = xmlNode.SelectSingleNode("notDomesticLaw");
            
            if (notDomesticLawNode != null)
            {
                if (notDomesticLawNode.Attributes["href"] != null || notDomesticLawNode.Attributes["id"] != null) 
                {
                    if (notDomesticLawNode.Attributes["id"] != null) 
                    {
                        notDomesticLawIDRef_ = notDomesticLawNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(notDomesticLawNode);
                        IDManager.SetID(notDomesticLawIDRef_, ob);
                    }
                    else if (notDomesticLawNode.Attributes["href"] != null)
                    {
                        notDomesticLawIDRef_ = notDomesticLawNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notDomesticLaw_ = new XsdTypeBoolean(notDomesticLawNode);
                    }
                }
                else
                {
                    notDomesticLaw_ = new XsdTypeBoolean(notDomesticLawNode);
                }
            }
            
        
            XmlNode listedNode = xmlNode.SelectSingleNode("listed");
            
            if (listedNode != null)
            {
                if (listedNode.Attributes["href"] != null || listedNode.Attributes["id"] != null) 
                {
                    if (listedNode.Attributes["id"] != null) 
                    {
                        listedIDRef_ = listedNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(listedNode);
                        IDManager.SetID(listedIDRef_, ob);
                    }
                    else if (listedNode.Attributes["href"] != null)
                    {
                        listedIDRef_ = listedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        listed_ = new XsdTypeBoolean(listedNode);
                    }
                }
                else
                {
                    listed_ = new XsdTypeBoolean(listedNode);
                }
            }
            
        
            XmlNode notDomesticIssuanceNode = xmlNode.SelectSingleNode("notDomesticIssuance");
            
            if (notDomesticIssuanceNode != null)
            {
                if (notDomesticIssuanceNode.Attributes["href"] != null || notDomesticIssuanceNode.Attributes["id"] != null) 
                {
                    if (notDomesticIssuanceNode.Attributes["id"] != null) 
                    {
                        notDomesticIssuanceIDRef_ = notDomesticIssuanceNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(notDomesticIssuanceNode);
                        IDManager.SetID(notDomesticIssuanceIDRef_, ob);
                    }
                    else if (notDomesticIssuanceNode.Attributes["href"] != null)
                    {
                        notDomesticIssuanceIDRef_ = notDomesticIssuanceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notDomesticIssuance_ = new XsdTypeBoolean(notDomesticIssuanceNode);
                    }
                }
                else
                {
                    notDomesticIssuance_ = new XsdTypeBoolean(notDomesticIssuanceNode);
                }
            }
            
        
            XmlNode fullFaithAndCreditObLiabilityNode = xmlNode.SelectSingleNode("fullFaithAndCreditObLiability");
            
            if (fullFaithAndCreditObLiabilityNode != null)
            {
                if (fullFaithAndCreditObLiabilityNode.Attributes["href"] != null || fullFaithAndCreditObLiabilityNode.Attributes["id"] != null) 
                {
                    if (fullFaithAndCreditObLiabilityNode.Attributes["id"] != null) 
                    {
                        fullFaithAndCreditObLiabilityIDRef_ = fullFaithAndCreditObLiabilityNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(fullFaithAndCreditObLiabilityNode);
                        IDManager.SetID(fullFaithAndCreditObLiabilityIDRef_, ob);
                    }
                    else if (fullFaithAndCreditObLiabilityNode.Attributes["href"] != null)
                    {
                        fullFaithAndCreditObLiabilityIDRef_ = fullFaithAndCreditObLiabilityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fullFaithAndCreditObLiability_ = new XsdTypeBoolean(fullFaithAndCreditObLiabilityNode);
                    }
                }
                else
                {
                    fullFaithAndCreditObLiability_ = new XsdTypeBoolean(fullFaithAndCreditObLiabilityNode);
                }
            }
            
        
            XmlNode generalFundObligationLiabilityNode = xmlNode.SelectSingleNode("generalFundObligationLiability");
            
            if (generalFundObligationLiabilityNode != null)
            {
                if (generalFundObligationLiabilityNode.Attributes["href"] != null || generalFundObligationLiabilityNode.Attributes["id"] != null) 
                {
                    if (generalFundObligationLiabilityNode.Attributes["id"] != null) 
                    {
                        generalFundObligationLiabilityIDRef_ = generalFundObligationLiabilityNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(generalFundObligationLiabilityNode);
                        IDManager.SetID(generalFundObligationLiabilityIDRef_, ob);
                    }
                    else if (generalFundObligationLiabilityNode.Attributes["href"] != null)
                    {
                        generalFundObligationLiabilityIDRef_ = generalFundObligationLiabilityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        generalFundObligationLiability_ = new XsdTypeBoolean(generalFundObligationLiabilityNode);
                    }
                }
                else
                {
                    generalFundObligationLiability_ = new XsdTypeBoolean(generalFundObligationLiabilityNode);
                }
            }
            
        
            XmlNode revenueObligationLiabilityNode = xmlNode.SelectSingleNode("revenueObligationLiability");
            
            if (revenueObligationLiabilityNode != null)
            {
                if (revenueObligationLiabilityNode.Attributes["href"] != null || revenueObligationLiabilityNode.Attributes["id"] != null) 
                {
                    if (revenueObligationLiabilityNode.Attributes["id"] != null) 
                    {
                        revenueObligationLiabilityIDRef_ = revenueObligationLiabilityNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(revenueObligationLiabilityNode);
                        IDManager.SetID(revenueObligationLiabilityIDRef_, ob);
                    }
                    else if (revenueObligationLiabilityNode.Attributes["href"] != null)
                    {
                        revenueObligationLiabilityIDRef_ = revenueObligationLiabilityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        revenueObligationLiability_ = new XsdTypeBoolean(revenueObligationLiabilityNode);
                    }
                }
                else
                {
                    revenueObligationLiability_ = new XsdTypeBoolean(revenueObligationLiabilityNode);
                }
            }
            
        
            XmlNode notContingentNode = xmlNode.SelectSingleNode("notContingent");
            
            if (notContingentNode != null)
            {
                if (notContingentNode.Attributes["href"] != null || notContingentNode.Attributes["id"] != null) 
                {
                    if (notContingentNode.Attributes["id"] != null) 
                    {
                        notContingentIDRef_ = notContingentNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(notContingentNode);
                        IDManager.SetID(notContingentIDRef_, ob);
                    }
                    else if (notContingentNode.Attributes["href"] != null)
                    {
                        notContingentIDRef_ = notContingentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        notContingent_ = new XsdTypeBoolean(notContingentNode);
                    }
                }
                else
                {
                    notContingent_ = new XsdTypeBoolean(notContingentNode);
                }
            }
            
        
            XmlNode excludedNode = xmlNode.SelectSingleNode("excluded");
            
            if (excludedNode != null)
            {
                if (excludedNode.Attributes["href"] != null || excludedNode.Attributes["id"] != null) 
                {
                    if (excludedNode.Attributes["id"] != null) 
                    {
                        excludedIDRef_ = excludedNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(excludedNode);
                        IDManager.SetID(excludedIDRef_, ob);
                    }
                    else if (excludedNode.Attributes["href"] != null)
                    {
                        excludedIDRef_ = excludedNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excluded_ = new XsdTypeString(excludedNode);
                    }
                }
                else
                {
                    excluded_ = new XsdTypeString(excludedNode);
                }
            }
            
        
            XmlNode othReferenceEntityObligationsNode = xmlNode.SelectSingleNode("othReferenceEntityObligations");
            
            if (othReferenceEntityObligationsNode != null)
            {
                if (othReferenceEntityObligationsNode.Attributes["href"] != null || othReferenceEntityObligationsNode.Attributes["id"] != null) 
                {
                    if (othReferenceEntityObligationsNode.Attributes["id"] != null) 
                    {
                        othReferenceEntityObligationsIDRef_ = othReferenceEntityObligationsNode.Attributes["id"].Value;
                        XsdTypeString ob = new XsdTypeString(othReferenceEntityObligationsNode);
                        IDManager.SetID(othReferenceEntityObligationsIDRef_, ob);
                    }
                    else if (othReferenceEntityObligationsNode.Attributes["href"] != null)
                    {
                        othReferenceEntityObligationsIDRef_ = othReferenceEntityObligationsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        othReferenceEntityObligations_ = new XsdTypeString(othReferenceEntityObligationsNode);
                    }
                }
                else
                {
                    othReferenceEntityObligations_ = new XsdTypeString(othReferenceEntityObligationsNode);
                }
            }
            
        
            XmlNode designatedPriorityNode = xmlNode.SelectSingleNode("designatedPriority");
            
            if (designatedPriorityNode != null)
            {
                if (designatedPriorityNode.Attributes["href"] != null || designatedPriorityNode.Attributes["id"] != null) 
                {
                    if (designatedPriorityNode.Attributes["id"] != null) 
                    {
                        designatedPriorityIDRef_ = designatedPriorityNode.Attributes["id"].Value;
                        Lien ob = new Lien(designatedPriorityNode);
                        IDManager.SetID(designatedPriorityIDRef_, ob);
                    }
                    else if (designatedPriorityNode.Attributes["href"] != null)
                    {
                        designatedPriorityIDRef_ = designatedPriorityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        designatedPriority_ = new Lien(designatedPriorityNode);
                    }
                }
                else
                {
                    designatedPriority_ = new Lien(designatedPriorityNode);
                }
            }
            
        
            XmlNode cashSettlementOnlyNode = xmlNode.SelectSingleNode("cashSettlementOnly");
            
            if (cashSettlementOnlyNode != null)
            {
                if (cashSettlementOnlyNode.Attributes["href"] != null || cashSettlementOnlyNode.Attributes["id"] != null) 
                {
                    if (cashSettlementOnlyNode.Attributes["id"] != null) 
                    {
                        cashSettlementOnlyIDRef_ = cashSettlementOnlyNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(cashSettlementOnlyNode);
                        IDManager.SetID(cashSettlementOnlyIDRef_, ob);
                    }
                    else if (cashSettlementOnlyNode.Attributes["href"] != null)
                    {
                        cashSettlementOnlyIDRef_ = cashSettlementOnlyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlementOnly_ = new XsdTypeBoolean(cashSettlementOnlyNode);
                    }
                }
                else
                {
                    cashSettlementOnly_ = new XsdTypeBoolean(cashSettlementOnlyNode);
                }
            }
            
        
            XmlNode deliveryOfCommitmentsNode = xmlNode.SelectSingleNode("deliveryOfCommitments");
            
            if (deliveryOfCommitmentsNode != null)
            {
                if (deliveryOfCommitmentsNode.Attributes["href"] != null || deliveryOfCommitmentsNode.Attributes["id"] != null) 
                {
                    if (deliveryOfCommitmentsNode.Attributes["id"] != null) 
                    {
                        deliveryOfCommitmentsIDRef_ = deliveryOfCommitmentsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(deliveryOfCommitmentsNode);
                        IDManager.SetID(deliveryOfCommitmentsIDRef_, ob);
                    }
                    else if (deliveryOfCommitmentsNode.Attributes["href"] != null)
                    {
                        deliveryOfCommitmentsIDRef_ = deliveryOfCommitmentsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        deliveryOfCommitments_ = new XsdTypeBoolean(deliveryOfCommitmentsNode);
                    }
                }
                else
                {
                    deliveryOfCommitments_ = new XsdTypeBoolean(deliveryOfCommitmentsNode);
                }
            }
            
        
            XmlNode continuityNode = xmlNode.SelectSingleNode("continuity");
            
            if (continuityNode != null)
            {
                if (continuityNode.Attributes["href"] != null || continuityNode.Attributes["id"] != null) 
                {
                    if (continuityNode.Attributes["id"] != null) 
                    {
                        continuityIDRef_ = continuityNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(continuityNode);
                        IDManager.SetID(continuityIDRef_, ob);
                    }
                    else if (continuityNode.Attributes["href"] != null)
                    {
                        continuityIDRef_ = continuityNode.Attributes["href"].Value;
                    }
                    else
                    {
                        continuity_ = new XsdTypeBoolean(continuityNode);
                    }
                }
                else
                {
                    continuity_ = new XsdTypeBoolean(continuityNode);
                }
            }
            
        
        }
        
    
        #region Category_
        private ObligationCategoryEnum category_;
        public ObligationCategoryEnum Category_
        {
            get
            {
                if (this.category_ != null)
                {
                    return this.category_; 
                }
                else if (this.categoryIDRef_ != null)
                {
                    category_ = IDManager.getID(categoryIDRef_) as ObligationCategoryEnum;
                    return this.category_; 
                }
                else
                {
                      return this.category_; 
                }
            }
            set
            {
                if (this.category_ != value)
                {
                    this.category_ = value;
                }
            }
        }
        #endregion
        
        public string categoryIDRef_ { get; set; }
        #region NotSubordinated_
        private XsdTypeBoolean notSubordinated_;
        public XsdTypeBoolean NotSubordinated_
        {
            get
            {
                if (this.notSubordinated_ != null)
                {
                    return this.notSubordinated_; 
                }
                else if (this.notSubordinatedIDRef_ != null)
                {
                    notSubordinated_ = IDManager.getID(notSubordinatedIDRef_) as XsdTypeBoolean;
                    return this.notSubordinated_; 
                }
                else
                {
                      return this.notSubordinated_; 
                }
            }
            set
            {
                if (this.notSubordinated_ != value)
                {
                    this.notSubordinated_ = value;
                }
            }
        }
        #endregion
        
        public string notSubordinatedIDRef_ { get; set; }
        #region SpecifiedCurrency_
        private SpecifiedCurrency specifiedCurrency_;
        public SpecifiedCurrency SpecifiedCurrency_
        {
            get
            {
                if (this.specifiedCurrency_ != null)
                {
                    return this.specifiedCurrency_; 
                }
                else if (this.specifiedCurrencyIDRef_ != null)
                {
                    specifiedCurrency_ = IDManager.getID(specifiedCurrencyIDRef_) as SpecifiedCurrency;
                    return this.specifiedCurrency_; 
                }
                else
                {
                      return this.specifiedCurrency_; 
                }
            }
            set
            {
                if (this.specifiedCurrency_ != value)
                {
                    this.specifiedCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string specifiedCurrencyIDRef_ { get; set; }
        #region NotSovereignLender_
        private XsdTypeBoolean notSovereignLender_;
        public XsdTypeBoolean NotSovereignLender_
        {
            get
            {
                if (this.notSovereignLender_ != null)
                {
                    return this.notSovereignLender_; 
                }
                else if (this.notSovereignLenderIDRef_ != null)
                {
                    notSovereignLender_ = IDManager.getID(notSovereignLenderIDRef_) as XsdTypeBoolean;
                    return this.notSovereignLender_; 
                }
                else
                {
                      return this.notSovereignLender_; 
                }
            }
            set
            {
                if (this.notSovereignLender_ != value)
                {
                    this.notSovereignLender_ = value;
                }
            }
        }
        #endregion
        
        public string notSovereignLenderIDRef_ { get; set; }
        #region NotDomesticCurrency_
        private NotDomesticCurrency notDomesticCurrency_;
        public NotDomesticCurrency NotDomesticCurrency_
        {
            get
            {
                if (this.notDomesticCurrency_ != null)
                {
                    return this.notDomesticCurrency_; 
                }
                else if (this.notDomesticCurrencyIDRef_ != null)
                {
                    notDomesticCurrency_ = IDManager.getID(notDomesticCurrencyIDRef_) as NotDomesticCurrency;
                    return this.notDomesticCurrency_; 
                }
                else
                {
                      return this.notDomesticCurrency_; 
                }
            }
            set
            {
                if (this.notDomesticCurrency_ != value)
                {
                    this.notDomesticCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string notDomesticCurrencyIDRef_ { get; set; }
        #region NotDomesticLaw_
        private XsdTypeBoolean notDomesticLaw_;
        public XsdTypeBoolean NotDomesticLaw_
        {
            get
            {
                if (this.notDomesticLaw_ != null)
                {
                    return this.notDomesticLaw_; 
                }
                else if (this.notDomesticLawIDRef_ != null)
                {
                    notDomesticLaw_ = IDManager.getID(notDomesticLawIDRef_) as XsdTypeBoolean;
                    return this.notDomesticLaw_; 
                }
                else
                {
                      return this.notDomesticLaw_; 
                }
            }
            set
            {
                if (this.notDomesticLaw_ != value)
                {
                    this.notDomesticLaw_ = value;
                }
            }
        }
        #endregion
        
        public string notDomesticLawIDRef_ { get; set; }
        #region Listed_
        private XsdTypeBoolean listed_;
        public XsdTypeBoolean Listed_
        {
            get
            {
                if (this.listed_ != null)
                {
                    return this.listed_; 
                }
                else if (this.listedIDRef_ != null)
                {
                    listed_ = IDManager.getID(listedIDRef_) as XsdTypeBoolean;
                    return this.listed_; 
                }
                else
                {
                      return this.listed_; 
                }
            }
            set
            {
                if (this.listed_ != value)
                {
                    this.listed_ = value;
                }
            }
        }
        #endregion
        
        public string listedIDRef_ { get; set; }
        #region NotDomesticIssuance_
        private XsdTypeBoolean notDomesticIssuance_;
        public XsdTypeBoolean NotDomesticIssuance_
        {
            get
            {
                if (this.notDomesticIssuance_ != null)
                {
                    return this.notDomesticIssuance_; 
                }
                else if (this.notDomesticIssuanceIDRef_ != null)
                {
                    notDomesticIssuance_ = IDManager.getID(notDomesticIssuanceIDRef_) as XsdTypeBoolean;
                    return this.notDomesticIssuance_; 
                }
                else
                {
                      return this.notDomesticIssuance_; 
                }
            }
            set
            {
                if (this.notDomesticIssuance_ != value)
                {
                    this.notDomesticIssuance_ = value;
                }
            }
        }
        #endregion
        
        public string notDomesticIssuanceIDRef_ { get; set; }
        #region FullFaithAndCreditObLiability_
        private XsdTypeBoolean fullFaithAndCreditObLiability_;
        public XsdTypeBoolean FullFaithAndCreditObLiability_
        {
            get
            {
                if (this.fullFaithAndCreditObLiability_ != null)
                {
                    return this.fullFaithAndCreditObLiability_; 
                }
                else if (this.fullFaithAndCreditObLiabilityIDRef_ != null)
                {
                    fullFaithAndCreditObLiability_ = IDManager.getID(fullFaithAndCreditObLiabilityIDRef_) as XsdTypeBoolean;
                    return this.fullFaithAndCreditObLiability_; 
                }
                else
                {
                      return this.fullFaithAndCreditObLiability_; 
                }
            }
            set
            {
                if (this.fullFaithAndCreditObLiability_ != value)
                {
                    this.fullFaithAndCreditObLiability_ = value;
                }
            }
        }
        #endregion
        
        public string fullFaithAndCreditObLiabilityIDRef_ { get; set; }
        #region GeneralFundObligationLiability_
        private XsdTypeBoolean generalFundObligationLiability_;
        public XsdTypeBoolean GeneralFundObligationLiability_
        {
            get
            {
                if (this.generalFundObligationLiability_ != null)
                {
                    return this.generalFundObligationLiability_; 
                }
                else if (this.generalFundObligationLiabilityIDRef_ != null)
                {
                    generalFundObligationLiability_ = IDManager.getID(generalFundObligationLiabilityIDRef_) as XsdTypeBoolean;
                    return this.generalFundObligationLiability_; 
                }
                else
                {
                      return this.generalFundObligationLiability_; 
                }
            }
            set
            {
                if (this.generalFundObligationLiability_ != value)
                {
                    this.generalFundObligationLiability_ = value;
                }
            }
        }
        #endregion
        
        public string generalFundObligationLiabilityIDRef_ { get; set; }
        #region RevenueObligationLiability_
        private XsdTypeBoolean revenueObligationLiability_;
        public XsdTypeBoolean RevenueObligationLiability_
        {
            get
            {
                if (this.revenueObligationLiability_ != null)
                {
                    return this.revenueObligationLiability_; 
                }
                else if (this.revenueObligationLiabilityIDRef_ != null)
                {
                    revenueObligationLiability_ = IDManager.getID(revenueObligationLiabilityIDRef_) as XsdTypeBoolean;
                    return this.revenueObligationLiability_; 
                }
                else
                {
                      return this.revenueObligationLiability_; 
                }
            }
            set
            {
                if (this.revenueObligationLiability_ != value)
                {
                    this.revenueObligationLiability_ = value;
                }
            }
        }
        #endregion
        
        public string revenueObligationLiabilityIDRef_ { get; set; }
        #region NotContingent_
        private XsdTypeBoolean notContingent_;
        public XsdTypeBoolean NotContingent_
        {
            get
            {
                if (this.notContingent_ != null)
                {
                    return this.notContingent_; 
                }
                else if (this.notContingentIDRef_ != null)
                {
                    notContingent_ = IDManager.getID(notContingentIDRef_) as XsdTypeBoolean;
                    return this.notContingent_; 
                }
                else
                {
                      return this.notContingent_; 
                }
            }
            set
            {
                if (this.notContingent_ != value)
                {
                    this.notContingent_ = value;
                }
            }
        }
        #endregion
        
        public string notContingentIDRef_ { get; set; }
        #region Excluded_
        private XsdTypeString excluded_;
        public XsdTypeString Excluded_
        {
            get
            {
                if (this.excluded_ != null)
                {
                    return this.excluded_; 
                }
                else if (this.excludedIDRef_ != null)
                {
                    excluded_ = IDManager.getID(excludedIDRef_) as XsdTypeString;
                    return this.excluded_; 
                }
                else
                {
                      return this.excluded_; 
                }
            }
            set
            {
                if (this.excluded_ != value)
                {
                    this.excluded_ = value;
                }
            }
        }
        #endregion
        
        public string excludedIDRef_ { get; set; }
        #region OthReferenceEntityObligations_
        private XsdTypeString othReferenceEntityObligations_;
        public XsdTypeString OthReferenceEntityObligations_
        {
            get
            {
                if (this.othReferenceEntityObligations_ != null)
                {
                    return this.othReferenceEntityObligations_; 
                }
                else if (this.othReferenceEntityObligationsIDRef_ != null)
                {
                    othReferenceEntityObligations_ = IDManager.getID(othReferenceEntityObligationsIDRef_) as XsdTypeString;
                    return this.othReferenceEntityObligations_; 
                }
                else
                {
                      return this.othReferenceEntityObligations_; 
                }
            }
            set
            {
                if (this.othReferenceEntityObligations_ != value)
                {
                    this.othReferenceEntityObligations_ = value;
                }
            }
        }
        #endregion
        
        public string othReferenceEntityObligationsIDRef_ { get; set; }
        #region DesignatedPriority_
        private Lien designatedPriority_;
        public Lien DesignatedPriority_
        {
            get
            {
                if (this.designatedPriority_ != null)
                {
                    return this.designatedPriority_; 
                }
                else if (this.designatedPriorityIDRef_ != null)
                {
                    designatedPriority_ = IDManager.getID(designatedPriorityIDRef_) as Lien;
                    return this.designatedPriority_; 
                }
                else
                {
                      return this.designatedPriority_; 
                }
            }
            set
            {
                if (this.designatedPriority_ != value)
                {
                    this.designatedPriority_ = value;
                }
            }
        }
        #endregion
        
        public string designatedPriorityIDRef_ { get; set; }
        #region CashSettlementOnly_
        private XsdTypeBoolean cashSettlementOnly_;
        public XsdTypeBoolean CashSettlementOnly_
        {
            get
            {
                if (this.cashSettlementOnly_ != null)
                {
                    return this.cashSettlementOnly_; 
                }
                else if (this.cashSettlementOnlyIDRef_ != null)
                {
                    cashSettlementOnly_ = IDManager.getID(cashSettlementOnlyIDRef_) as XsdTypeBoolean;
                    return this.cashSettlementOnly_; 
                }
                else
                {
                      return this.cashSettlementOnly_; 
                }
            }
            set
            {
                if (this.cashSettlementOnly_ != value)
                {
                    this.cashSettlementOnly_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementOnlyIDRef_ { get; set; }
        #region DeliveryOfCommitments_
        private XsdTypeBoolean deliveryOfCommitments_;
        public XsdTypeBoolean DeliveryOfCommitments_
        {
            get
            {
                if (this.deliveryOfCommitments_ != null)
                {
                    return this.deliveryOfCommitments_; 
                }
                else if (this.deliveryOfCommitmentsIDRef_ != null)
                {
                    deliveryOfCommitments_ = IDManager.getID(deliveryOfCommitmentsIDRef_) as XsdTypeBoolean;
                    return this.deliveryOfCommitments_; 
                }
                else
                {
                      return this.deliveryOfCommitments_; 
                }
            }
            set
            {
                if (this.deliveryOfCommitments_ != value)
                {
                    this.deliveryOfCommitments_ = value;
                }
            }
        }
        #endregion
        
        public string deliveryOfCommitmentsIDRef_ { get; set; }
        #region Continuity_
        private XsdTypeBoolean continuity_;
        public XsdTypeBoolean Continuity_
        {
            get
            {
                if (this.continuity_ != null)
                {
                    return this.continuity_; 
                }
                else if (this.continuityIDRef_ != null)
                {
                    continuity_ = IDManager.getID(continuityIDRef_) as XsdTypeBoolean;
                    return this.continuity_; 
                }
                else
                {
                      return this.continuity_; 
                }
            }
            set
            {
                if (this.continuity_ != value)
                {
                    this.continuity_ = value;
                }
            }
        }
        #endregion
        
        public string continuityIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

