using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class AdditionalDisruptionEvents
    {
        public AdditionalDisruptionEvents(XmlNode xmlNode)
        {
            XmlNodeList changeInLawNodeList = xmlNode.SelectNodes("changeInLaw");
            if (changeInLawNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in changeInLawNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        changeInLawIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(changeInLawIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        changeInLawIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        changeInLaw = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList failureToDeliverNodeList = xmlNode.SelectNodes("failureToDeliver");
            if (failureToDeliverNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in failureToDeliverNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        failureToDeliverIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(failureToDeliverIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        failureToDeliverIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        failureToDeliver = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList insolvencyFilingNodeList = xmlNode.SelectNodes("insolvencyFiling");
            if (insolvencyFilingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in insolvencyFilingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        insolvencyFilingIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(insolvencyFilingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        insolvencyFilingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        insolvencyFiling = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList hedgingDisruptionNodeList = xmlNode.SelectNodes("hedgingDisruption");
            if (hedgingDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in hedgingDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        hedgingDisruptionIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(hedgingDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        hedgingDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        hedgingDisruption = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList lossOfStockBorrowNodeList = xmlNode.SelectNodes("lossOfStockBorrow");
            if (lossOfStockBorrowNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in lossOfStockBorrowNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        lossOfStockBorrowIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(lossOfStockBorrowIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        lossOfStockBorrowIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        lossOfStockBorrow = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList maximumStockLoanRateNodeList = xmlNode.SelectNodes("maximumStockLoanRate");
            if (maximumStockLoanRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumStockLoanRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumStockLoanRateIDRef = item.Attributes["id"].Name;
                        RestrictedPercentage ob = RestrictedPercentage();
                        IDManager.SetID(maximumStockLoanRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumStockLoanRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumStockLoanRate = new RestrictedPercentage(item);
                    }
                }
            }
            
        
            XmlNodeList increasedCostOfStockBorrowNodeList = xmlNode.SelectNodes("increasedCostOfStockBorrow");
            if (increasedCostOfStockBorrowNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in increasedCostOfStockBorrowNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        increasedCostOfStockBorrowIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(increasedCostOfStockBorrowIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        increasedCostOfStockBorrowIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        increasedCostOfStockBorrow = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList initialStockLoanRateNodeList = xmlNode.SelectNodes("initialStockLoanRate");
            if (initialStockLoanRateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in initialStockLoanRateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        initialStockLoanRateIDRef = item.Attributes["id"].Name;
                        RestrictedPercentage ob = RestrictedPercentage();
                        IDManager.SetID(initialStockLoanRateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        initialStockLoanRateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        initialStockLoanRate = new RestrictedPercentage(item);
                    }
                }
            }
            
        
            XmlNodeList increasedCostOfHedgingNodeList = xmlNode.SelectNodes("increasedCostOfHedging");
            if (increasedCostOfHedgingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in increasedCostOfHedgingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        increasedCostOfHedgingIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(increasedCostOfHedgingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        increasedCostOfHedgingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        increasedCostOfHedging = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList determiningPartyReferenceNodeList = xmlNode.SelectNodes("determiningPartyReference");
            if (determiningPartyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in determiningPartyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        determiningPartyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(determiningPartyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        determiningPartyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        determiningPartyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList foreignOwnershipEventNodeList = xmlNode.SelectNodes("foreignOwnershipEvent");
            if (foreignOwnershipEventNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in foreignOwnershipEventNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        foreignOwnershipEventIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(foreignOwnershipEventIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        foreignOwnershipEventIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        foreignOwnershipEvent = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
        }
        
    
        #region ChangeInLaw
        private XsdTypeBoolean changeInLaw;
        public XsdTypeBoolean ChangeInLaw
        {
            get
            {
                if (this.changeInLaw != null)
                {
                    return this.changeInLaw; 
                }
                else if (this.changeInLawIDRef != null)
                {
                    changeInLaw = IDManager.getID(changeInLawIDRef) as XsdTypeBoolean;
                    return this.changeInLaw; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.changeInLaw != value)
                {
                    this.changeInLaw = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region FailureToDeliver
        private XsdTypeBoolean failureToDeliver;
        public XsdTypeBoolean FailureToDeliver
        {
            get
            {
                if (this.failureToDeliver != null)
                {
                    return this.failureToDeliver; 
                }
                else if (this.failureToDeliverIDRef != null)
                {
                    failureToDeliver = IDManager.getID(failureToDeliverIDRef) as XsdTypeBoolean;
                    return this.failureToDeliver; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.failureToDeliver != value)
                {
                    this.failureToDeliver = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region InsolvencyFiling
        private XsdTypeBoolean insolvencyFiling;
        public XsdTypeBoolean InsolvencyFiling
        {
            get
            {
                if (this.insolvencyFiling != null)
                {
                    return this.insolvencyFiling; 
                }
                else if (this.insolvencyFilingIDRef != null)
                {
                    insolvencyFiling = IDManager.getID(insolvencyFilingIDRef) as XsdTypeBoolean;
                    return this.insolvencyFiling; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.insolvencyFiling != value)
                {
                    this.insolvencyFiling = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region HedgingDisruption
        private XsdTypeBoolean hedgingDisruption;
        public XsdTypeBoolean HedgingDisruption
        {
            get
            {
                if (this.hedgingDisruption != null)
                {
                    return this.hedgingDisruption; 
                }
                else if (this.hedgingDisruptionIDRef != null)
                {
                    hedgingDisruption = IDManager.getID(hedgingDisruptionIDRef) as XsdTypeBoolean;
                    return this.hedgingDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.hedgingDisruption != value)
                {
                    this.hedgingDisruption = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region LossOfStockBorrow
        private XsdTypeBoolean lossOfStockBorrow;
        public XsdTypeBoolean LossOfStockBorrow
        {
            get
            {
                if (this.lossOfStockBorrow != null)
                {
                    return this.lossOfStockBorrow; 
                }
                else if (this.lossOfStockBorrowIDRef != null)
                {
                    lossOfStockBorrow = IDManager.getID(lossOfStockBorrowIDRef) as XsdTypeBoolean;
                    return this.lossOfStockBorrow; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.lossOfStockBorrow != value)
                {
                    this.lossOfStockBorrow = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region MaximumStockLoanRate
        private RestrictedPercentage maximumStockLoanRate;
        public RestrictedPercentage MaximumStockLoanRate
        {
            get
            {
                if (this.maximumStockLoanRate != null)
                {
                    return this.maximumStockLoanRate; 
                }
                else if (this.maximumStockLoanRateIDRef != null)
                {
                    maximumStockLoanRate = IDManager.getID(maximumStockLoanRateIDRef) as RestrictedPercentage;
                    return this.maximumStockLoanRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumStockLoanRate != value)
                {
                    this.maximumStockLoanRate = value;
                }
            }
        }
        #endregion
        
        public string RestrictedPercentageIDRef { get; set; }
        #region IncreasedCostOfStockBorrow
        private XsdTypeBoolean increasedCostOfStockBorrow;
        public XsdTypeBoolean IncreasedCostOfStockBorrow
        {
            get
            {
                if (this.increasedCostOfStockBorrow != null)
                {
                    return this.increasedCostOfStockBorrow; 
                }
                else if (this.increasedCostOfStockBorrowIDRef != null)
                {
                    increasedCostOfStockBorrow = IDManager.getID(increasedCostOfStockBorrowIDRef) as XsdTypeBoolean;
                    return this.increasedCostOfStockBorrow; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.increasedCostOfStockBorrow != value)
                {
                    this.increasedCostOfStockBorrow = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region InitialStockLoanRate
        private RestrictedPercentage initialStockLoanRate;
        public RestrictedPercentage InitialStockLoanRate
        {
            get
            {
                if (this.initialStockLoanRate != null)
                {
                    return this.initialStockLoanRate; 
                }
                else if (this.initialStockLoanRateIDRef != null)
                {
                    initialStockLoanRate = IDManager.getID(initialStockLoanRateIDRef) as RestrictedPercentage;
                    return this.initialStockLoanRate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.initialStockLoanRate != value)
                {
                    this.initialStockLoanRate = value;
                }
            }
        }
        #endregion
        
        public string RestrictedPercentageIDRef { get; set; }
        #region IncreasedCostOfHedging
        private XsdTypeBoolean increasedCostOfHedging;
        public XsdTypeBoolean IncreasedCostOfHedging
        {
            get
            {
                if (this.increasedCostOfHedging != null)
                {
                    return this.increasedCostOfHedging; 
                }
                else if (this.increasedCostOfHedgingIDRef != null)
                {
                    increasedCostOfHedging = IDManager.getID(increasedCostOfHedgingIDRef) as XsdTypeBoolean;
                    return this.increasedCostOfHedging; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.increasedCostOfHedging != value)
                {
                    this.increasedCostOfHedging = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region DeterminingPartyReference
        private PartyReference determiningPartyReference;
        public PartyReference DeterminingPartyReference
        {
            get
            {
                if (this.determiningPartyReference != null)
                {
                    return this.determiningPartyReference; 
                }
                else if (this.determiningPartyReferenceIDRef != null)
                {
                    determiningPartyReference = IDManager.getID(determiningPartyReferenceIDRef) as PartyReference;
                    return this.determiningPartyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.determiningPartyReference != value)
                {
                    this.determiningPartyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region ForeignOwnershipEvent
        private XsdTypeBoolean foreignOwnershipEvent;
        public XsdTypeBoolean ForeignOwnershipEvent
        {
            get
            {
                if (this.foreignOwnershipEvent != null)
                {
                    return this.foreignOwnershipEvent; 
                }
                else if (this.foreignOwnershipEventIDRef != null)
                {
                    foreignOwnershipEvent = IDManager.getID(foreignOwnershipEventIDRef) as XsdTypeBoolean;
                    return this.foreignOwnershipEvent; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.foreignOwnershipEvent != value)
                {
                    this.foreignOwnershipEvent = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        
    
        
    
    }
    
}

