using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class GeneralTerms
    {
        public GeneralTerms(XmlNode xmlNode)
        {
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate2 ob = AdjustableDate2();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new AdjustableDate2(item);
                    }
                }
            }
            
        
            XmlNodeList scheduledTerminationDateNodeList = xmlNode.SelectNodes("scheduledTerminationDate");
            if (scheduledTerminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in scheduledTerminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        scheduledTerminationDateIDRef = item.Attributes["id"].Name;
                        AdjustableDate2 ob = AdjustableDate2();
                        IDManager.SetID(scheduledTerminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        scheduledTerminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        scheduledTerminationDate = new AdjustableDate2(item);
                    }
                }
            }
            
        
            XmlNodeList buyerPartyReferenceNodeList = xmlNode.SelectNodes("buyerPartyReference");
            if (buyerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(buyerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList buyerAccountReferenceNodeList = xmlNode.SelectNodes("buyerAccountReference");
            if (buyerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in buyerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        buyerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(buyerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        buyerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        buyerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerPartyReferenceNodeList = xmlNode.SelectNodes("sellerPartyReference");
            if (sellerPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(sellerPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList sellerAccountReferenceNodeList = xmlNode.SelectNodes("sellerAccountReference");
            if (sellerAccountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in sellerAccountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        sellerAccountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(sellerAccountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        sellerAccountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        sellerAccountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList dateAdjustmentsNodeList = xmlNode.SelectNodes("dateAdjustments");
            if (dateAdjustmentsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dateAdjustmentsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dateAdjustmentsIDRef = item.Attributes["id"].Name;
                        BusinessDayAdjustments ob = BusinessDayAdjustments();
                        IDManager.SetID(dateAdjustmentsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dateAdjustmentsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dateAdjustments = new BusinessDayAdjustments(item);
                    }
                }
            }
            
        
            XmlNodeList referenceInformationNodeList = xmlNode.SelectNodes("referenceInformation");
            if (referenceInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceInformationIDRef = item.Attributes["id"].Name;
                        ReferenceInformation ob = ReferenceInformation();
                        IDManager.SetID(referenceInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceInformation = new ReferenceInformation(item);
                    }
                }
            }
            
        
            XmlNodeList indexReferenceInformationNodeList = xmlNode.SelectNodes("indexReferenceInformation");
            if (indexReferenceInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in indexReferenceInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        indexReferenceInformationIDRef = item.Attributes["id"].Name;
                        IndexReferenceInformation ob = IndexReferenceInformation();
                        IDManager.SetID(indexReferenceInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        indexReferenceInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        indexReferenceInformation = new IndexReferenceInformation(item);
                    }
                }
            }
            
        
            XmlNodeList basketReferenceInformationNodeList = xmlNode.SelectNodes("basketReferenceInformation");
            if (basketReferenceInformationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in basketReferenceInformationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        basketReferenceInformationIDRef = item.Attributes["id"].Name;
                        BasketReferenceInformation ob = BasketReferenceInformation();
                        IDManager.SetID(basketReferenceInformationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        basketReferenceInformationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        basketReferenceInformation = new BasketReferenceInformation(item);
                    }
                }
            }
            
        
            XmlNodeList additionalTermNodeList = xmlNode.SelectNodes("additionalTerm");
            
            foreach (XmlNode item in additionalTermNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        additionalTermIDRef = item.Attributes["id"].Name;
                        List<AdditionalTerm> ob = new List<AdditionalTerm>();
                        ob.Add(new AdditionalTerm(item));
                        IDManager.SetID(additionalTermIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        additionalTermIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    additionalTerm.Add(new AdditionalTerm(item));
                    }
                }
            }
            
        
            XmlNodeList substitutionNodeList = xmlNode.SelectNodes("substitution");
            if (substitutionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in substitutionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        substitutionIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(substitutionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        substitutionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        substitution = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList modifiedEquityDeliveryNodeList = xmlNode.SelectNodes("modifiedEquityDelivery");
            if (modifiedEquityDeliveryNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in modifiedEquityDeliveryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        modifiedEquityDeliveryIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(modifiedEquityDeliveryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        modifiedEquityDeliveryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        modifiedEquityDelivery = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region EffectiveDate
        private AdjustableDate2 effectiveDate;
        public AdjustableDate2 EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as AdjustableDate2;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDate2IDRef { get; set; }
        #region ScheduledTerminationDate
        private AdjustableDate2 scheduledTerminationDate;
        public AdjustableDate2 ScheduledTerminationDate
        {
            get
            {
                if (this.scheduledTerminationDate != null)
                {
                    return this.scheduledTerminationDate; 
                }
                else if (this.scheduledTerminationDateIDRef != null)
                {
                    scheduledTerminationDate = IDManager.getID(scheduledTerminationDateIDRef) as AdjustableDate2;
                    return this.scheduledTerminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.scheduledTerminationDate != value)
                {
                    this.scheduledTerminationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableDate2IDRef { get; set; }
        #region BuyerPartyReference
        private PartyReference buyerPartyReference;
        public PartyReference BuyerPartyReference
        {
            get
            {
                if (this.buyerPartyReference != null)
                {
                    return this.buyerPartyReference; 
                }
                else if (this.buyerPartyReferenceIDRef != null)
                {
                    buyerPartyReference = IDManager.getID(buyerPartyReferenceIDRef) as PartyReference;
                    return this.buyerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerPartyReference != value)
                {
                    this.buyerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region BuyerAccountReference
        private AccountReference buyerAccountReference;
        public AccountReference BuyerAccountReference
        {
            get
            {
                if (this.buyerAccountReference != null)
                {
                    return this.buyerAccountReference; 
                }
                else if (this.buyerAccountReferenceIDRef != null)
                {
                    buyerAccountReference = IDManager.getID(buyerAccountReferenceIDRef) as AccountReference;
                    return this.buyerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.buyerAccountReference != value)
                {
                    this.buyerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region SellerPartyReference
        private PartyReference sellerPartyReference;
        public PartyReference SellerPartyReference
        {
            get
            {
                if (this.sellerPartyReference != null)
                {
                    return this.sellerPartyReference; 
                }
                else if (this.sellerPartyReferenceIDRef != null)
                {
                    sellerPartyReference = IDManager.getID(sellerPartyReferenceIDRef) as PartyReference;
                    return this.sellerPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerPartyReference != value)
                {
                    this.sellerPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region SellerAccountReference
        private AccountReference sellerAccountReference;
        public AccountReference SellerAccountReference
        {
            get
            {
                if (this.sellerAccountReference != null)
                {
                    return this.sellerAccountReference; 
                }
                else if (this.sellerAccountReferenceIDRef != null)
                {
                    sellerAccountReference = IDManager.getID(sellerAccountReferenceIDRef) as AccountReference;
                    return this.sellerAccountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.sellerAccountReference != value)
                {
                    this.sellerAccountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region DateAdjustments
        private BusinessDayAdjustments dateAdjustments;
        public BusinessDayAdjustments DateAdjustments
        {
            get
            {
                if (this.dateAdjustments != null)
                {
                    return this.dateAdjustments; 
                }
                else if (this.dateAdjustmentsIDRef != null)
                {
                    dateAdjustments = IDManager.getID(dateAdjustmentsIDRef) as BusinessDayAdjustments;
                    return this.dateAdjustments; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dateAdjustments != value)
                {
                    this.dateAdjustments = value;
                }
            }
        }
        #endregion
        
        public string BusinessDayAdjustmentsIDRef { get; set; }
        #region ReferenceInformation
        private ReferenceInformation referenceInformation;
        public ReferenceInformation ReferenceInformation
        {
            get
            {
                if (this.referenceInformation != null)
                {
                    return this.referenceInformation; 
                }
                else if (this.referenceInformationIDRef != null)
                {
                    referenceInformation = IDManager.getID(referenceInformationIDRef) as ReferenceInformation;
                    return this.referenceInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceInformation != value)
                {
                    this.referenceInformation = value;
                }
            }
        }
        #endregion
        
        public string ReferenceInformationIDRef { get; set; }
        #region IndexReferenceInformation
        private IndexReferenceInformation indexReferenceInformation;
        public IndexReferenceInformation IndexReferenceInformation
        {
            get
            {
                if (this.indexReferenceInformation != null)
                {
                    return this.indexReferenceInformation; 
                }
                else if (this.indexReferenceInformationIDRef != null)
                {
                    indexReferenceInformation = IDManager.getID(indexReferenceInformationIDRef) as IndexReferenceInformation;
                    return this.indexReferenceInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.indexReferenceInformation != value)
                {
                    this.indexReferenceInformation = value;
                }
            }
        }
        #endregion
        
        public string IndexReferenceInformationIDRef { get; set; }
        #region BasketReferenceInformation
        private BasketReferenceInformation basketReferenceInformation;
        public BasketReferenceInformation BasketReferenceInformation
        {
            get
            {
                if (this.basketReferenceInformation != null)
                {
                    return this.basketReferenceInformation; 
                }
                else if (this.basketReferenceInformationIDRef != null)
                {
                    basketReferenceInformation = IDManager.getID(basketReferenceInformationIDRef) as BasketReferenceInformation;
                    return this.basketReferenceInformation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.basketReferenceInformation != value)
                {
                    this.basketReferenceInformation = value;
                }
            }
        }
        #endregion
        
        public string BasketReferenceInformationIDRef { get; set; }
        #region AdditionalTerm
        private List<AdditionalTerm> additionalTerm;
        public List<AdditionalTerm> AdditionalTerm
        {
            get
            {
                if (this.additionalTerm != null)
                {
                    return this.additionalTerm; 
                }
                else if (this.additionalTermIDRef != null)
                {
                    additionalTerm = IDManager.getID(additionalTermIDRef) as List<AdditionalTerm>;
                    return this.additionalTerm; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.additionalTerm != value)
                {
                    this.additionalTerm = value;
                }
            }
        }
        #endregion
        
        public string AdditionalTermIDRef { get; set; }
        #region Substitution
        private XsdTypeBoolean substitution;
        public XsdTypeBoolean Substitution
        {
            get
            {
                if (this.substitution != null)
                {
                    return this.substitution; 
                }
                else if (this.substitutionIDRef != null)
                {
                    substitution = IDManager.getID(substitutionIDRef) as XsdTypeBoolean;
                    return this.substitution; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.substitution != value)
                {
                    this.substitution = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ModifiedEquityDelivery
        private XsdTypeBoolean modifiedEquityDelivery;
        public XsdTypeBoolean ModifiedEquityDelivery
        {
            get
            {
                if (this.modifiedEquityDelivery != null)
                {
                    return this.modifiedEquityDelivery; 
                }
                else if (this.modifiedEquityDeliveryIDRef != null)
                {
                    modifiedEquityDelivery = IDManager.getID(modifiedEquityDeliveryIDRef) as XsdTypeBoolean;
                    return this.modifiedEquityDelivery; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.modifiedEquityDelivery != value)
                {
                    this.modifiedEquityDelivery = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

