using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class GeneralTerms : ISerialized
    {
        public GeneralTerms(XmlNode xmlNode)
        {
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        AdjustableDate2 ob = new AdjustableDate2(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new AdjustableDate2(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new AdjustableDate2(effectiveDateNode);
                }
            }
            
        
            XmlNode scheduledTerminationDateNode = xmlNode.SelectSingleNode("scheduledTerminationDate");
            
            if (scheduledTerminationDateNode != null)
            {
                if (scheduledTerminationDateNode.Attributes["href"] != null || scheduledTerminationDateNode.Attributes["id"] != null) 
                {
                    if (scheduledTerminationDateNode.Attributes["id"] != null) 
                    {
                        scheduledTerminationDateIDRef_ = scheduledTerminationDateNode.Attributes["id"].Value;
                        AdjustableDate2 ob = new AdjustableDate2(scheduledTerminationDateNode);
                        IDManager.SetID(scheduledTerminationDateIDRef_, ob);
                    }
                    else if (scheduledTerminationDateNode.Attributes["href"] != null)
                    {
                        scheduledTerminationDateIDRef_ = scheduledTerminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        scheduledTerminationDate_ = new AdjustableDate2(scheduledTerminationDateNode);
                    }
                }
                else
                {
                    scheduledTerminationDate_ = new AdjustableDate2(scheduledTerminationDateNode);
                }
            }
            
        
            XmlNode buyerPartyReferenceNode = xmlNode.SelectSingleNode("buyerPartyReference");
            
            if (buyerPartyReferenceNode != null)
            {
                if (buyerPartyReferenceNode.Attributes["href"] != null || buyerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(buyerPartyReferenceNode);
                        IDManager.SetID(buyerPartyReferenceIDRef_, ob);
                    }
                    else if (buyerPartyReferenceNode.Attributes["href"] != null)
                    {
                        buyerPartyReferenceIDRef_ = buyerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                    }
                }
                else
                {
                    buyerPartyReference_ = new PartyReference(buyerPartyReferenceNode);
                }
            }
            
        
            XmlNode buyerAccountReferenceNode = xmlNode.SelectSingleNode("buyerAccountReference");
            
            if (buyerAccountReferenceNode != null)
            {
                if (buyerAccountReferenceNode.Attributes["href"] != null || buyerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (buyerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(buyerAccountReferenceNode);
                        IDManager.SetID(buyerAccountReferenceIDRef_, ob);
                    }
                    else if (buyerAccountReferenceNode.Attributes["href"] != null)
                    {
                        buyerAccountReferenceIDRef_ = buyerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                    }
                }
                else
                {
                    buyerAccountReference_ = new AccountReference(buyerAccountReferenceNode);
                }
            }
            
        
            XmlNode sellerPartyReferenceNode = xmlNode.SelectSingleNode("sellerPartyReference");
            
            if (sellerPartyReferenceNode != null)
            {
                if (sellerPartyReferenceNode.Attributes["href"] != null || sellerPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerPartyReferenceNode.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(sellerPartyReferenceNode);
                        IDManager.SetID(sellerPartyReferenceIDRef_, ob);
                    }
                    else if (sellerPartyReferenceNode.Attributes["href"] != null)
                    {
                        sellerPartyReferenceIDRef_ = sellerPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                    }
                }
                else
                {
                    sellerPartyReference_ = new PartyReference(sellerPartyReferenceNode);
                }
            }
            
        
            XmlNode sellerAccountReferenceNode = xmlNode.SelectSingleNode("sellerAccountReference");
            
            if (sellerAccountReferenceNode != null)
            {
                if (sellerAccountReferenceNode.Attributes["href"] != null || sellerAccountReferenceNode.Attributes["id"] != null) 
                {
                    if (sellerAccountReferenceNode.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(sellerAccountReferenceNode);
                        IDManager.SetID(sellerAccountReferenceIDRef_, ob);
                    }
                    else if (sellerAccountReferenceNode.Attributes["href"] != null)
                    {
                        sellerAccountReferenceIDRef_ = sellerAccountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                    }
                }
                else
                {
                    sellerAccountReference_ = new AccountReference(sellerAccountReferenceNode);
                }
            }
            
        
            XmlNode dateAdjustmentsNode = xmlNode.SelectSingleNode("dateAdjustments");
            
            if (dateAdjustmentsNode != null)
            {
                if (dateAdjustmentsNode.Attributes["href"] != null || dateAdjustmentsNode.Attributes["id"] != null) 
                {
                    if (dateAdjustmentsNode.Attributes["id"] != null) 
                    {
                        dateAdjustmentsIDRef_ = dateAdjustmentsNode.Attributes["id"].Value;
                        BusinessDayAdjustments ob = new BusinessDayAdjustments(dateAdjustmentsNode);
                        IDManager.SetID(dateAdjustmentsIDRef_, ob);
                    }
                    else if (dateAdjustmentsNode.Attributes["href"] != null)
                    {
                        dateAdjustmentsIDRef_ = dateAdjustmentsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dateAdjustments_ = new BusinessDayAdjustments(dateAdjustmentsNode);
                    }
                }
                else
                {
                    dateAdjustments_ = new BusinessDayAdjustments(dateAdjustmentsNode);
                }
            }
            
        
            XmlNode referenceInformationNode = xmlNode.SelectSingleNode("referenceInformation");
            
            if (referenceInformationNode != null)
            {
                if (referenceInformationNode.Attributes["href"] != null || referenceInformationNode.Attributes["id"] != null) 
                {
                    if (referenceInformationNode.Attributes["id"] != null) 
                    {
                        referenceInformationIDRef_ = referenceInformationNode.Attributes["id"].Value;
                        ReferenceInformation ob = new ReferenceInformation(referenceInformationNode);
                        IDManager.SetID(referenceInformationIDRef_, ob);
                    }
                    else if (referenceInformationNode.Attributes["href"] != null)
                    {
                        referenceInformationIDRef_ = referenceInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        referenceInformation_ = new ReferenceInformation(referenceInformationNode);
                    }
                }
                else
                {
                    referenceInformation_ = new ReferenceInformation(referenceInformationNode);
                }
            }
            
        
            XmlNode indexReferenceInformationNode = xmlNode.SelectSingleNode("indexReferenceInformation");
            
            if (indexReferenceInformationNode != null)
            {
                if (indexReferenceInformationNode.Attributes["href"] != null || indexReferenceInformationNode.Attributes["id"] != null) 
                {
                    if (indexReferenceInformationNode.Attributes["id"] != null) 
                    {
                        indexReferenceInformationIDRef_ = indexReferenceInformationNode.Attributes["id"].Value;
                        IndexReferenceInformation ob = new IndexReferenceInformation(indexReferenceInformationNode);
                        IDManager.SetID(indexReferenceInformationIDRef_, ob);
                    }
                    else if (indexReferenceInformationNode.Attributes["href"] != null)
                    {
                        indexReferenceInformationIDRef_ = indexReferenceInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        indexReferenceInformation_ = new IndexReferenceInformation(indexReferenceInformationNode);
                    }
                }
                else
                {
                    indexReferenceInformation_ = new IndexReferenceInformation(indexReferenceInformationNode);
                }
            }
            
        
            XmlNode basketReferenceInformationNode = xmlNode.SelectSingleNode("basketReferenceInformation");
            
            if (basketReferenceInformationNode != null)
            {
                if (basketReferenceInformationNode.Attributes["href"] != null || basketReferenceInformationNode.Attributes["id"] != null) 
                {
                    if (basketReferenceInformationNode.Attributes["id"] != null) 
                    {
                        basketReferenceInformationIDRef_ = basketReferenceInformationNode.Attributes["id"].Value;
                        BasketReferenceInformation ob = new BasketReferenceInformation(basketReferenceInformationNode);
                        IDManager.SetID(basketReferenceInformationIDRef_, ob);
                    }
                    else if (basketReferenceInformationNode.Attributes["href"] != null)
                    {
                        basketReferenceInformationIDRef_ = basketReferenceInformationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        basketReferenceInformation_ = new BasketReferenceInformation(basketReferenceInformationNode);
                    }
                }
                else
                {
                    basketReferenceInformation_ = new BasketReferenceInformation(basketReferenceInformationNode);
                }
            }
            
        
            XmlNodeList additionalTermNodeList = xmlNode.SelectNodes("additionalTerm");
            
            if (additionalTermNodeList != null)
            {
                this.additionalTerm_ = new List<AdditionalTerm>();
                foreach (XmlNode item in additionalTermNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            additionalTermIDRef_ = item.Attributes["id"].Value;
                            additionalTerm_.Add(new AdditionalTerm(item));
                            IDManager.SetID(additionalTermIDRef_, additionalTerm_[additionalTerm_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            additionalTermIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        additionalTerm_.Add(new AdditionalTerm(item));
                        }
                    }
                    else
                    {
                        additionalTerm_.Add(new AdditionalTerm(item));
                    }
                }
            }
            
        
            XmlNode substitutionNode = xmlNode.SelectSingleNode("substitution");
            
            if (substitutionNode != null)
            {
                if (substitutionNode.Attributes["href"] != null || substitutionNode.Attributes["id"] != null) 
                {
                    if (substitutionNode.Attributes["id"] != null) 
                    {
                        substitutionIDRef_ = substitutionNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(substitutionNode);
                        IDManager.SetID(substitutionIDRef_, ob);
                    }
                    else if (substitutionNode.Attributes["href"] != null)
                    {
                        substitutionIDRef_ = substitutionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        substitution_ = new XsdTypeBoolean(substitutionNode);
                    }
                }
                else
                {
                    substitution_ = new XsdTypeBoolean(substitutionNode);
                }
            }
            
        
            XmlNode modifiedEquityDeliveryNode = xmlNode.SelectSingleNode("modifiedEquityDelivery");
            
            if (modifiedEquityDeliveryNode != null)
            {
                if (modifiedEquityDeliveryNode.Attributes["href"] != null || modifiedEquityDeliveryNode.Attributes["id"] != null) 
                {
                    if (modifiedEquityDeliveryNode.Attributes["id"] != null) 
                    {
                        modifiedEquityDeliveryIDRef_ = modifiedEquityDeliveryNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(modifiedEquityDeliveryNode);
                        IDManager.SetID(modifiedEquityDeliveryIDRef_, ob);
                    }
                    else if (modifiedEquityDeliveryNode.Attributes["href"] != null)
                    {
                        modifiedEquityDeliveryIDRef_ = modifiedEquityDeliveryNode.Attributes["href"].Value;
                    }
                    else
                    {
                        modifiedEquityDelivery_ = new XsdTypeBoolean(modifiedEquityDeliveryNode);
                    }
                }
                else
                {
                    modifiedEquityDelivery_ = new XsdTypeBoolean(modifiedEquityDeliveryNode);
                }
            }
            
        
        }
        
    
        #region EffectiveDate_
        private AdjustableDate2 effectiveDate_;
        public AdjustableDate2 EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as AdjustableDate2;
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
        #region ScheduledTerminationDate_
        private AdjustableDate2 scheduledTerminationDate_;
        public AdjustableDate2 ScheduledTerminationDate_
        {
            get
            {
                if (this.scheduledTerminationDate_ != null)
                {
                    return this.scheduledTerminationDate_; 
                }
                else if (this.scheduledTerminationDateIDRef_ != null)
                {
                    scheduledTerminationDate_ = IDManager.getID(scheduledTerminationDateIDRef_) as AdjustableDate2;
                    return this.scheduledTerminationDate_; 
                }
                else
                {
                      return this.scheduledTerminationDate_; 
                }
            }
            set
            {
                if (this.scheduledTerminationDate_ != value)
                {
                    this.scheduledTerminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string scheduledTerminationDateIDRef_ { get; set; }
        #region BuyerPartyReference_
        private PartyReference buyerPartyReference_;
        public PartyReference BuyerPartyReference_
        {
            get
            {
                if (this.buyerPartyReference_ != null)
                {
                    return this.buyerPartyReference_; 
                }
                else if (this.buyerPartyReferenceIDRef_ != null)
                {
                    buyerPartyReference_ = IDManager.getID(buyerPartyReferenceIDRef_) as PartyReference;
                    return this.buyerPartyReference_; 
                }
                else
                {
                      return this.buyerPartyReference_; 
                }
            }
            set
            {
                if (this.buyerPartyReference_ != value)
                {
                    this.buyerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerPartyReferenceIDRef_ { get; set; }
        #region BuyerAccountReference_
        private AccountReference buyerAccountReference_;
        public AccountReference BuyerAccountReference_
        {
            get
            {
                if (this.buyerAccountReference_ != null)
                {
                    return this.buyerAccountReference_; 
                }
                else if (this.buyerAccountReferenceIDRef_ != null)
                {
                    buyerAccountReference_ = IDManager.getID(buyerAccountReferenceIDRef_) as AccountReference;
                    return this.buyerAccountReference_; 
                }
                else
                {
                      return this.buyerAccountReference_; 
                }
            }
            set
            {
                if (this.buyerAccountReference_ != value)
                {
                    this.buyerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string buyerAccountReferenceIDRef_ { get; set; }
        #region SellerPartyReference_
        private PartyReference sellerPartyReference_;
        public PartyReference SellerPartyReference_
        {
            get
            {
                if (this.sellerPartyReference_ != null)
                {
                    return this.sellerPartyReference_; 
                }
                else if (this.sellerPartyReferenceIDRef_ != null)
                {
                    sellerPartyReference_ = IDManager.getID(sellerPartyReferenceIDRef_) as PartyReference;
                    return this.sellerPartyReference_; 
                }
                else
                {
                      return this.sellerPartyReference_; 
                }
            }
            set
            {
                if (this.sellerPartyReference_ != value)
                {
                    this.sellerPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerPartyReferenceIDRef_ { get; set; }
        #region SellerAccountReference_
        private AccountReference sellerAccountReference_;
        public AccountReference SellerAccountReference_
        {
            get
            {
                if (this.sellerAccountReference_ != null)
                {
                    return this.sellerAccountReference_; 
                }
                else if (this.sellerAccountReferenceIDRef_ != null)
                {
                    sellerAccountReference_ = IDManager.getID(sellerAccountReferenceIDRef_) as AccountReference;
                    return this.sellerAccountReference_; 
                }
                else
                {
                      return this.sellerAccountReference_; 
                }
            }
            set
            {
                if (this.sellerAccountReference_ != value)
                {
                    this.sellerAccountReference_ = value;
                }
            }
        }
        #endregion
        
        public string sellerAccountReferenceIDRef_ { get; set; }
        #region DateAdjustments_
        private BusinessDayAdjustments dateAdjustments_;
        public BusinessDayAdjustments DateAdjustments_
        {
            get
            {
                if (this.dateAdjustments_ != null)
                {
                    return this.dateAdjustments_; 
                }
                else if (this.dateAdjustmentsIDRef_ != null)
                {
                    dateAdjustments_ = IDManager.getID(dateAdjustmentsIDRef_) as BusinessDayAdjustments;
                    return this.dateAdjustments_; 
                }
                else
                {
                      return this.dateAdjustments_; 
                }
            }
            set
            {
                if (this.dateAdjustments_ != value)
                {
                    this.dateAdjustments_ = value;
                }
            }
        }
        #endregion
        
        public string dateAdjustmentsIDRef_ { get; set; }
        #region ReferenceInformation_
        private ReferenceInformation referenceInformation_;
        public ReferenceInformation ReferenceInformation_
        {
            get
            {
                if (this.referenceInformation_ != null)
                {
                    return this.referenceInformation_; 
                }
                else if (this.referenceInformationIDRef_ != null)
                {
                    referenceInformation_ = IDManager.getID(referenceInformationIDRef_) as ReferenceInformation;
                    return this.referenceInformation_; 
                }
                else
                {
                      return this.referenceInformation_; 
                }
            }
            set
            {
                if (this.referenceInformation_ != value)
                {
                    this.referenceInformation_ = value;
                }
            }
        }
        #endregion
        
        public string referenceInformationIDRef_ { get; set; }
        #region IndexReferenceInformation_
        private IndexReferenceInformation indexReferenceInformation_;
        public IndexReferenceInformation IndexReferenceInformation_
        {
            get
            {
                if (this.indexReferenceInformation_ != null)
                {
                    return this.indexReferenceInformation_; 
                }
                else if (this.indexReferenceInformationIDRef_ != null)
                {
                    indexReferenceInformation_ = IDManager.getID(indexReferenceInformationIDRef_) as IndexReferenceInformation;
                    return this.indexReferenceInformation_; 
                }
                else
                {
                      return this.indexReferenceInformation_; 
                }
            }
            set
            {
                if (this.indexReferenceInformation_ != value)
                {
                    this.indexReferenceInformation_ = value;
                }
            }
        }
        #endregion
        
        public string indexReferenceInformationIDRef_ { get; set; }
        #region BasketReferenceInformation_
        private BasketReferenceInformation basketReferenceInformation_;
        public BasketReferenceInformation BasketReferenceInformation_
        {
            get
            {
                if (this.basketReferenceInformation_ != null)
                {
                    return this.basketReferenceInformation_; 
                }
                else if (this.basketReferenceInformationIDRef_ != null)
                {
                    basketReferenceInformation_ = IDManager.getID(basketReferenceInformationIDRef_) as BasketReferenceInformation;
                    return this.basketReferenceInformation_; 
                }
                else
                {
                      return this.basketReferenceInformation_; 
                }
            }
            set
            {
                if (this.basketReferenceInformation_ != value)
                {
                    this.basketReferenceInformation_ = value;
                }
            }
        }
        #endregion
        
        public string basketReferenceInformationIDRef_ { get; set; }
        #region AdditionalTerm_
        private List<AdditionalTerm> additionalTerm_;
        public List<AdditionalTerm> AdditionalTerm_
        {
            get
            {
                if (this.additionalTerm_ != null)
                {
                    return this.additionalTerm_; 
                }
                else if (this.additionalTermIDRef_ != null)
                {
                    return this.additionalTerm_; 
                }
                else
                {
                      return this.additionalTerm_; 
                }
            }
            set
            {
                if (this.additionalTerm_ != value)
                {
                    this.additionalTerm_ = value;
                }
            }
        }
        #endregion
        
        public string additionalTermIDRef_ { get; set; }
        #region Substitution_
        private XsdTypeBoolean substitution_;
        public XsdTypeBoolean Substitution_
        {
            get
            {
                if (this.substitution_ != null)
                {
                    return this.substitution_; 
                }
                else if (this.substitutionIDRef_ != null)
                {
                    substitution_ = IDManager.getID(substitutionIDRef_) as XsdTypeBoolean;
                    return this.substitution_; 
                }
                else
                {
                      return this.substitution_; 
                }
            }
            set
            {
                if (this.substitution_ != value)
                {
                    this.substitution_ = value;
                }
            }
        }
        #endregion
        
        public string substitutionIDRef_ { get; set; }
        #region ModifiedEquityDelivery_
        private XsdTypeBoolean modifiedEquityDelivery_;
        public XsdTypeBoolean ModifiedEquityDelivery_
        {
            get
            {
                if (this.modifiedEquityDelivery_ != null)
                {
                    return this.modifiedEquityDelivery_; 
                }
                else if (this.modifiedEquityDeliveryIDRef_ != null)
                {
                    modifiedEquityDelivery_ = IDManager.getID(modifiedEquityDeliveryIDRef_) as XsdTypeBoolean;
                    return this.modifiedEquityDelivery_; 
                }
                else
                {
                      return this.modifiedEquityDelivery_; 
                }
            }
            set
            {
                if (this.modifiedEquityDelivery_ != value)
                {
                    this.modifiedEquityDelivery_ = value;
                }
            }
        }
        #endregion
        
        public string modifiedEquityDeliveryIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

