using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class AdditionalDisruptionEvents : ISerialized
    {
        public AdditionalDisruptionEvents(XmlNode xmlNode)
        {
            XmlNode changeInLawNode = xmlNode.SelectSingleNode("changeInLaw");
            
            if (changeInLawNode != null)
            {
                if (changeInLawNode.Attributes["href"] != null || changeInLawNode.Attributes["id"] != null) 
                {
                    if (changeInLawNode.Attributes["id"] != null) 
                    {
                        changeInLawIDRef_ = changeInLawNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(changeInLawNode);
                        IDManager.SetID(changeInLawIDRef_, ob);
                    }
                    else if (changeInLawNode.Attributes["href"] != null)
                    {
                        changeInLawIDRef_ = changeInLawNode.Attributes["href"].Value;
                    }
                    else
                    {
                        changeInLaw_ = new XsdTypeBoolean(changeInLawNode);
                    }
                }
                else
                {
                    changeInLaw_ = new XsdTypeBoolean(changeInLawNode);
                }
            }
            
        
            XmlNode failureToDeliverNode = xmlNode.SelectSingleNode("failureToDeliver");
            
            if (failureToDeliverNode != null)
            {
                if (failureToDeliverNode.Attributes["href"] != null || failureToDeliverNode.Attributes["id"] != null) 
                {
                    if (failureToDeliverNode.Attributes["id"] != null) 
                    {
                        failureToDeliverIDRef_ = failureToDeliverNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(failureToDeliverNode);
                        IDManager.SetID(failureToDeliverIDRef_, ob);
                    }
                    else if (failureToDeliverNode.Attributes["href"] != null)
                    {
                        failureToDeliverIDRef_ = failureToDeliverNode.Attributes["href"].Value;
                    }
                    else
                    {
                        failureToDeliver_ = new XsdTypeBoolean(failureToDeliverNode);
                    }
                }
                else
                {
                    failureToDeliver_ = new XsdTypeBoolean(failureToDeliverNode);
                }
            }
            
        
            XmlNode insolvencyFilingNode = xmlNode.SelectSingleNode("insolvencyFiling");
            
            if (insolvencyFilingNode != null)
            {
                if (insolvencyFilingNode.Attributes["href"] != null || insolvencyFilingNode.Attributes["id"] != null) 
                {
                    if (insolvencyFilingNode.Attributes["id"] != null) 
                    {
                        insolvencyFilingIDRef_ = insolvencyFilingNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(insolvencyFilingNode);
                        IDManager.SetID(insolvencyFilingIDRef_, ob);
                    }
                    else if (insolvencyFilingNode.Attributes["href"] != null)
                    {
                        insolvencyFilingIDRef_ = insolvencyFilingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        insolvencyFiling_ = new XsdTypeBoolean(insolvencyFilingNode);
                    }
                }
                else
                {
                    insolvencyFiling_ = new XsdTypeBoolean(insolvencyFilingNode);
                }
            }
            
        
            XmlNode hedgingDisruptionNode = xmlNode.SelectSingleNode("hedgingDisruption");
            
            if (hedgingDisruptionNode != null)
            {
                if (hedgingDisruptionNode.Attributes["href"] != null || hedgingDisruptionNode.Attributes["id"] != null) 
                {
                    if (hedgingDisruptionNode.Attributes["id"] != null) 
                    {
                        hedgingDisruptionIDRef_ = hedgingDisruptionNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(hedgingDisruptionNode);
                        IDManager.SetID(hedgingDisruptionIDRef_, ob);
                    }
                    else if (hedgingDisruptionNode.Attributes["href"] != null)
                    {
                        hedgingDisruptionIDRef_ = hedgingDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        hedgingDisruption_ = new XsdTypeBoolean(hedgingDisruptionNode);
                    }
                }
                else
                {
                    hedgingDisruption_ = new XsdTypeBoolean(hedgingDisruptionNode);
                }
            }
            
        
            XmlNode lossOfStockBorrowNode = xmlNode.SelectSingleNode("lossOfStockBorrow");
            
            if (lossOfStockBorrowNode != null)
            {
                if (lossOfStockBorrowNode.Attributes["href"] != null || lossOfStockBorrowNode.Attributes["id"] != null) 
                {
                    if (lossOfStockBorrowNode.Attributes["id"] != null) 
                    {
                        lossOfStockBorrowIDRef_ = lossOfStockBorrowNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(lossOfStockBorrowNode);
                        IDManager.SetID(lossOfStockBorrowIDRef_, ob);
                    }
                    else if (lossOfStockBorrowNode.Attributes["href"] != null)
                    {
                        lossOfStockBorrowIDRef_ = lossOfStockBorrowNode.Attributes["href"].Value;
                    }
                    else
                    {
                        lossOfStockBorrow_ = new XsdTypeBoolean(lossOfStockBorrowNode);
                    }
                }
                else
                {
                    lossOfStockBorrow_ = new XsdTypeBoolean(lossOfStockBorrowNode);
                }
            }
            
        
            XmlNode maximumStockLoanRateNode = xmlNode.SelectSingleNode("maximumStockLoanRate");
            
            if (maximumStockLoanRateNode != null)
            {
                if (maximumStockLoanRateNode.Attributes["href"] != null || maximumStockLoanRateNode.Attributes["id"] != null) 
                {
                    if (maximumStockLoanRateNode.Attributes["id"] != null) 
                    {
                        maximumStockLoanRateIDRef_ = maximumStockLoanRateNode.Attributes["id"].Value;
                        RestrictedPercentage ob = new RestrictedPercentage(maximumStockLoanRateNode);
                        IDManager.SetID(maximumStockLoanRateIDRef_, ob);
                    }
                    else if (maximumStockLoanRateNode.Attributes["href"] != null)
                    {
                        maximumStockLoanRateIDRef_ = maximumStockLoanRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        maximumStockLoanRate_ = new RestrictedPercentage(maximumStockLoanRateNode);
                    }
                }
                else
                {
                    maximumStockLoanRate_ = new RestrictedPercentage(maximumStockLoanRateNode);
                }
            }
            
        
            XmlNode increasedCostOfStockBorrowNode = xmlNode.SelectSingleNode("increasedCostOfStockBorrow");
            
            if (increasedCostOfStockBorrowNode != null)
            {
                if (increasedCostOfStockBorrowNode.Attributes["href"] != null || increasedCostOfStockBorrowNode.Attributes["id"] != null) 
                {
                    if (increasedCostOfStockBorrowNode.Attributes["id"] != null) 
                    {
                        increasedCostOfStockBorrowIDRef_ = increasedCostOfStockBorrowNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(increasedCostOfStockBorrowNode);
                        IDManager.SetID(increasedCostOfStockBorrowIDRef_, ob);
                    }
                    else if (increasedCostOfStockBorrowNode.Attributes["href"] != null)
                    {
                        increasedCostOfStockBorrowIDRef_ = increasedCostOfStockBorrowNode.Attributes["href"].Value;
                    }
                    else
                    {
                        increasedCostOfStockBorrow_ = new XsdTypeBoolean(increasedCostOfStockBorrowNode);
                    }
                }
                else
                {
                    increasedCostOfStockBorrow_ = new XsdTypeBoolean(increasedCostOfStockBorrowNode);
                }
            }
            
        
            XmlNode initialStockLoanRateNode = xmlNode.SelectSingleNode("initialStockLoanRate");
            
            if (initialStockLoanRateNode != null)
            {
                if (initialStockLoanRateNode.Attributes["href"] != null || initialStockLoanRateNode.Attributes["id"] != null) 
                {
                    if (initialStockLoanRateNode.Attributes["id"] != null) 
                    {
                        initialStockLoanRateIDRef_ = initialStockLoanRateNode.Attributes["id"].Value;
                        RestrictedPercentage ob = new RestrictedPercentage(initialStockLoanRateNode);
                        IDManager.SetID(initialStockLoanRateIDRef_, ob);
                    }
                    else if (initialStockLoanRateNode.Attributes["href"] != null)
                    {
                        initialStockLoanRateIDRef_ = initialStockLoanRateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        initialStockLoanRate_ = new RestrictedPercentage(initialStockLoanRateNode);
                    }
                }
                else
                {
                    initialStockLoanRate_ = new RestrictedPercentage(initialStockLoanRateNode);
                }
            }
            
        
            XmlNode increasedCostOfHedgingNode = xmlNode.SelectSingleNode("increasedCostOfHedging");
            
            if (increasedCostOfHedgingNode != null)
            {
                if (increasedCostOfHedgingNode.Attributes["href"] != null || increasedCostOfHedgingNode.Attributes["id"] != null) 
                {
                    if (increasedCostOfHedgingNode.Attributes["id"] != null) 
                    {
                        increasedCostOfHedgingIDRef_ = increasedCostOfHedgingNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(increasedCostOfHedgingNode);
                        IDManager.SetID(increasedCostOfHedgingIDRef_, ob);
                    }
                    else if (increasedCostOfHedgingNode.Attributes["href"] != null)
                    {
                        increasedCostOfHedgingIDRef_ = increasedCostOfHedgingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        increasedCostOfHedging_ = new XsdTypeBoolean(increasedCostOfHedgingNode);
                    }
                }
                else
                {
                    increasedCostOfHedging_ = new XsdTypeBoolean(increasedCostOfHedgingNode);
                }
            }
            
        
            XmlNode determiningPartyReferenceNode = xmlNode.SelectSingleNode("determiningPartyReference");
            
            if (determiningPartyReferenceNode != null)
            {
                if (determiningPartyReferenceNode.Attributes["href"] != null || determiningPartyReferenceNode.Attributes["id"] != null) 
                {
                    if (determiningPartyReferenceNode.Attributes["id"] != null) 
                    {
                        determiningPartyReferenceIDRef_ = determiningPartyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(determiningPartyReferenceNode);
                        IDManager.SetID(determiningPartyReferenceIDRef_, ob);
                    }
                    else if (determiningPartyReferenceNode.Attributes["href"] != null)
                    {
                        determiningPartyReferenceIDRef_ = determiningPartyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        determiningPartyReference_ = new PartyReference(determiningPartyReferenceNode);
                    }
                }
                else
                {
                    determiningPartyReference_ = new PartyReference(determiningPartyReferenceNode);
                }
            }
            
        
            XmlNode foreignOwnershipEventNode = xmlNode.SelectSingleNode("foreignOwnershipEvent");
            
            if (foreignOwnershipEventNode != null)
            {
                if (foreignOwnershipEventNode.Attributes["href"] != null || foreignOwnershipEventNode.Attributes["id"] != null) 
                {
                    if (foreignOwnershipEventNode.Attributes["id"] != null) 
                    {
                        foreignOwnershipEventIDRef_ = foreignOwnershipEventNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(foreignOwnershipEventNode);
                        IDManager.SetID(foreignOwnershipEventIDRef_, ob);
                    }
                    else if (foreignOwnershipEventNode.Attributes["href"] != null)
                    {
                        foreignOwnershipEventIDRef_ = foreignOwnershipEventNode.Attributes["href"].Value;
                    }
                    else
                    {
                        foreignOwnershipEvent_ = new XsdTypeBoolean(foreignOwnershipEventNode);
                    }
                }
                else
                {
                    foreignOwnershipEvent_ = new XsdTypeBoolean(foreignOwnershipEventNode);
                }
            }
            
        
        }
        
    
        #region ChangeInLaw_
        private XsdTypeBoolean changeInLaw_;
        public XsdTypeBoolean ChangeInLaw_
        {
            get
            {
                if (this.changeInLaw_ != null)
                {
                    return this.changeInLaw_; 
                }
                else if (this.changeInLawIDRef_ != null)
                {
                    changeInLaw_ = IDManager.getID(changeInLawIDRef_) as XsdTypeBoolean;
                    return this.changeInLaw_; 
                }
                else
                {
                      return this.changeInLaw_; 
                }
            }
            set
            {
                if (this.changeInLaw_ != value)
                {
                    this.changeInLaw_ = value;
                }
            }
        }
        #endregion
        
        public string changeInLawIDRef_ { get; set; }
        #region FailureToDeliver_
        private XsdTypeBoolean failureToDeliver_;
        public XsdTypeBoolean FailureToDeliver_
        {
            get
            {
                if (this.failureToDeliver_ != null)
                {
                    return this.failureToDeliver_; 
                }
                else if (this.failureToDeliverIDRef_ != null)
                {
                    failureToDeliver_ = IDManager.getID(failureToDeliverIDRef_) as XsdTypeBoolean;
                    return this.failureToDeliver_; 
                }
                else
                {
                      return this.failureToDeliver_; 
                }
            }
            set
            {
                if (this.failureToDeliver_ != value)
                {
                    this.failureToDeliver_ = value;
                }
            }
        }
        #endregion
        
        public string failureToDeliverIDRef_ { get; set; }
        #region InsolvencyFiling_
        private XsdTypeBoolean insolvencyFiling_;
        public XsdTypeBoolean InsolvencyFiling_
        {
            get
            {
                if (this.insolvencyFiling_ != null)
                {
                    return this.insolvencyFiling_; 
                }
                else if (this.insolvencyFilingIDRef_ != null)
                {
                    insolvencyFiling_ = IDManager.getID(insolvencyFilingIDRef_) as XsdTypeBoolean;
                    return this.insolvencyFiling_; 
                }
                else
                {
                      return this.insolvencyFiling_; 
                }
            }
            set
            {
                if (this.insolvencyFiling_ != value)
                {
                    this.insolvencyFiling_ = value;
                }
            }
        }
        #endregion
        
        public string insolvencyFilingIDRef_ { get; set; }
        #region HedgingDisruption_
        private XsdTypeBoolean hedgingDisruption_;
        public XsdTypeBoolean HedgingDisruption_
        {
            get
            {
                if (this.hedgingDisruption_ != null)
                {
                    return this.hedgingDisruption_; 
                }
                else if (this.hedgingDisruptionIDRef_ != null)
                {
                    hedgingDisruption_ = IDManager.getID(hedgingDisruptionIDRef_) as XsdTypeBoolean;
                    return this.hedgingDisruption_; 
                }
                else
                {
                      return this.hedgingDisruption_; 
                }
            }
            set
            {
                if (this.hedgingDisruption_ != value)
                {
                    this.hedgingDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string hedgingDisruptionIDRef_ { get; set; }
        #region LossOfStockBorrow_
        private XsdTypeBoolean lossOfStockBorrow_;
        public XsdTypeBoolean LossOfStockBorrow_
        {
            get
            {
                if (this.lossOfStockBorrow_ != null)
                {
                    return this.lossOfStockBorrow_; 
                }
                else if (this.lossOfStockBorrowIDRef_ != null)
                {
                    lossOfStockBorrow_ = IDManager.getID(lossOfStockBorrowIDRef_) as XsdTypeBoolean;
                    return this.lossOfStockBorrow_; 
                }
                else
                {
                      return this.lossOfStockBorrow_; 
                }
            }
            set
            {
                if (this.lossOfStockBorrow_ != value)
                {
                    this.lossOfStockBorrow_ = value;
                }
            }
        }
        #endregion
        
        public string lossOfStockBorrowIDRef_ { get; set; }
        #region MaximumStockLoanRate_
        private RestrictedPercentage maximumStockLoanRate_;
        public RestrictedPercentage MaximumStockLoanRate_
        {
            get
            {
                if (this.maximumStockLoanRate_ != null)
                {
                    return this.maximumStockLoanRate_; 
                }
                else if (this.maximumStockLoanRateIDRef_ != null)
                {
                    maximumStockLoanRate_ = IDManager.getID(maximumStockLoanRateIDRef_) as RestrictedPercentage;
                    return this.maximumStockLoanRate_; 
                }
                else
                {
                      return this.maximumStockLoanRate_; 
                }
            }
            set
            {
                if (this.maximumStockLoanRate_ != value)
                {
                    this.maximumStockLoanRate_ = value;
                }
            }
        }
        #endregion
        
        public string maximumStockLoanRateIDRef_ { get; set; }
        #region IncreasedCostOfStockBorrow_
        private XsdTypeBoolean increasedCostOfStockBorrow_;
        public XsdTypeBoolean IncreasedCostOfStockBorrow_
        {
            get
            {
                if (this.increasedCostOfStockBorrow_ != null)
                {
                    return this.increasedCostOfStockBorrow_; 
                }
                else if (this.increasedCostOfStockBorrowIDRef_ != null)
                {
                    increasedCostOfStockBorrow_ = IDManager.getID(increasedCostOfStockBorrowIDRef_) as XsdTypeBoolean;
                    return this.increasedCostOfStockBorrow_; 
                }
                else
                {
                      return this.increasedCostOfStockBorrow_; 
                }
            }
            set
            {
                if (this.increasedCostOfStockBorrow_ != value)
                {
                    this.increasedCostOfStockBorrow_ = value;
                }
            }
        }
        #endregion
        
        public string increasedCostOfStockBorrowIDRef_ { get; set; }
        #region InitialStockLoanRate_
        private RestrictedPercentage initialStockLoanRate_;
        public RestrictedPercentage InitialStockLoanRate_
        {
            get
            {
                if (this.initialStockLoanRate_ != null)
                {
                    return this.initialStockLoanRate_; 
                }
                else if (this.initialStockLoanRateIDRef_ != null)
                {
                    initialStockLoanRate_ = IDManager.getID(initialStockLoanRateIDRef_) as RestrictedPercentage;
                    return this.initialStockLoanRate_; 
                }
                else
                {
                      return this.initialStockLoanRate_; 
                }
            }
            set
            {
                if (this.initialStockLoanRate_ != value)
                {
                    this.initialStockLoanRate_ = value;
                }
            }
        }
        #endregion
        
        public string initialStockLoanRateIDRef_ { get; set; }
        #region IncreasedCostOfHedging_
        private XsdTypeBoolean increasedCostOfHedging_;
        public XsdTypeBoolean IncreasedCostOfHedging_
        {
            get
            {
                if (this.increasedCostOfHedging_ != null)
                {
                    return this.increasedCostOfHedging_; 
                }
                else if (this.increasedCostOfHedgingIDRef_ != null)
                {
                    increasedCostOfHedging_ = IDManager.getID(increasedCostOfHedgingIDRef_) as XsdTypeBoolean;
                    return this.increasedCostOfHedging_; 
                }
                else
                {
                      return this.increasedCostOfHedging_; 
                }
            }
            set
            {
                if (this.increasedCostOfHedging_ != value)
                {
                    this.increasedCostOfHedging_ = value;
                }
            }
        }
        #endregion
        
        public string increasedCostOfHedgingIDRef_ { get; set; }
        #region DeterminingPartyReference_
        private PartyReference determiningPartyReference_;
        public PartyReference DeterminingPartyReference_
        {
            get
            {
                if (this.determiningPartyReference_ != null)
                {
                    return this.determiningPartyReference_; 
                }
                else if (this.determiningPartyReferenceIDRef_ != null)
                {
                    determiningPartyReference_ = IDManager.getID(determiningPartyReferenceIDRef_) as PartyReference;
                    return this.determiningPartyReference_; 
                }
                else
                {
                      return this.determiningPartyReference_; 
                }
            }
            set
            {
                if (this.determiningPartyReference_ != value)
                {
                    this.determiningPartyReference_ = value;
                }
            }
        }
        #endregion
        
        public string determiningPartyReferenceIDRef_ { get; set; }
        #region ForeignOwnershipEvent_
        private XsdTypeBoolean foreignOwnershipEvent_;
        public XsdTypeBoolean ForeignOwnershipEvent_
        {
            get
            {
                if (this.foreignOwnershipEvent_ != null)
                {
                    return this.foreignOwnershipEvent_; 
                }
                else if (this.foreignOwnershipEventIDRef_ != null)
                {
                    foreignOwnershipEvent_ = IDManager.getID(foreignOwnershipEventIDRef_) as XsdTypeBoolean;
                    return this.foreignOwnershipEvent_; 
                }
                else
                {
                      return this.foreignOwnershipEvent_; 
                }
            }
            set
            {
                if (this.foreignOwnershipEvent_ != value)
                {
                    this.foreignOwnershipEvent_ = value;
                }
            }
        }
        #endregion
        
        public string foreignOwnershipEventIDRef_ { get; set; }
        
    
        
    
    }
    
}

