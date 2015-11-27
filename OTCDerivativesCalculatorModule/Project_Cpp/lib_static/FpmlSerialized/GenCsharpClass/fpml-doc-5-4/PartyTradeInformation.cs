using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class PartyTradeInformation
    {
        public PartyTradeInformation(XmlNode xmlNode)
        {
            XmlNodeList partyReferenceNodeList = xmlNode.SelectNodes("partyReference");
            if (partyReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in partyReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(partyReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        partyReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        partyReference = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList accountReferenceNodeList = xmlNode.SelectNodes("accountReference");
            if (accountReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accountReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accountReferenceIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(accountReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accountReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accountReference = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList relatedPartyNodeList = xmlNode.SelectNodes("relatedParty");
            
            foreach (XmlNode item in relatedPartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relatedPartyIDRef = item.Attributes["id"].Name;
                        List<RelatedParty> ob = new List<RelatedParty>();
                        ob.Add(new RelatedParty(item));
                        IDManager.SetID(relatedPartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relatedPartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    relatedParty.Add(new RelatedParty(item));
                    }
                }
            }
            
        
            XmlNodeList reportingRoleNodeList = xmlNode.SelectNodes("reportingRole");
            if (reportingRoleNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in reportingRoleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reportingRoleIDRef = item.Attributes["id"].Name;
                        ReportingRole ob = ReportingRole();
                        IDManager.SetID(reportingRoleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reportingRoleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        reportingRole = new ReportingRole(item);
                    }
                }
            }
            
        
            XmlNodeList unitNodeList = xmlNode.SelectNodes("unit");
            
            foreach (XmlNode item in unitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        unitIDRef = item.Attributes["id"].Name;
                        List<Unit> ob = new List<Unit>();
                        ob.Add(new Unit(item));
                        IDManager.SetID(unitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        unitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    unit.Add(new Unit(item));
                    }
                }
            }
            
        
            XmlNodeList relatedBusinessUnitNodeList = xmlNode.SelectNodes("relatedBusinessUnit");
            
            foreach (XmlNode item in relatedBusinessUnitNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relatedBusinessUnitIDRef = item.Attributes["id"].Name;
                        List<RelatedBusinessUnit> ob = new List<RelatedBusinessUnit>();
                        ob.Add(new RelatedBusinessUnit(item));
                        IDManager.SetID(relatedBusinessUnitIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relatedBusinessUnitIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    relatedBusinessUnit.Add(new RelatedBusinessUnit(item));
                    }
                }
            }
            
        
            XmlNodeList relatedPersonNodeList = xmlNode.SelectNodes("relatedPerson");
            
            foreach (XmlNode item in relatedPersonNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        relatedPersonIDRef = item.Attributes["id"].Name;
                        List<RelatedPerson> ob = new List<RelatedPerson>();
                        ob.Add(new RelatedPerson(item));
                        IDManager.SetID(relatedPersonIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        relatedPersonIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    relatedPerson.Add(new RelatedPerson(item));
                    }
                }
            }
            
        
            XmlNodeList isAccountingHedgeNodeList = xmlNode.SelectNodes("isAccountingHedge");
            if (isAccountingHedgeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in isAccountingHedgeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        isAccountingHedgeIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(isAccountingHedgeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        isAccountingHedgeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        isAccountingHedge = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList categoryNodeList = xmlNode.SelectNodes("category");
            
            foreach (XmlNode item in categoryNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        categoryIDRef = item.Attributes["id"].Name;
                        List<TradeCategory> ob = new List<TradeCategory>();
                        ob.Add(new TradeCategory(item));
                        IDManager.SetID(categoryIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        categoryIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    category.Add(new TradeCategory(item));
                    }
                }
            }
            
        
            XmlNodeList traderNodeList = xmlNode.SelectNodes("trader");
            
            foreach (XmlNode item in traderNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        traderIDRef = item.Attributes["id"].Name;
                        List<Trader> ob = new List<Trader>();
                        ob.Add(new Trader(item));
                        IDManager.SetID(traderIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        traderIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    trader.Add(new Trader(item));
                    }
                }
            }
            
        
            XmlNodeList executionDateTimeNodeList = xmlNode.SelectNodes("executionDateTime");
            if (executionDateTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in executionDateTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        executionDateTimeIDRef = item.Attributes["id"].Name;
                        ExecutionDateTime ob = ExecutionDateTime();
                        IDManager.SetID(executionDateTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        executionDateTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        executionDateTime = new ExecutionDateTime(item);
                    }
                }
            }
            
        
            XmlNodeList timestampsNodeList = xmlNode.SelectNodes("timestamps");
            if (timestampsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in timestampsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        timestampsIDRef = item.Attributes["id"].Name;
                        TradeProcessingTimestamps ob = TradeProcessingTimestamps();
                        IDManager.SetID(timestampsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        timestampsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        timestamps = new TradeProcessingTimestamps(item);
                    }
                }
            }
            
        
            XmlNodeList intentToAllocateNodeList = xmlNode.SelectNodes("intentToAllocate");
            if (intentToAllocateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in intentToAllocateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        intentToAllocateIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(intentToAllocateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        intentToAllocateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        intentToAllocate = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList allocationStatusNodeList = xmlNode.SelectNodes("allocationStatus");
            if (allocationStatusNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in allocationStatusNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        allocationStatusIDRef = item.Attributes["id"].Name;
                        AllocationReportingStatus ob = AllocationReportingStatus();
                        IDManager.SetID(allocationStatusIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        allocationStatusIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        allocationStatus = new AllocationReportingStatus(item);
                    }
                }
            }
            
        
            XmlNodeList intentToClearNodeList = xmlNode.SelectNodes("intentToClear");
            if (intentToClearNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in intentToClearNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        intentToClearIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(intentToClearIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        intentToClearIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        intentToClear = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList clearingStatusNodeList = xmlNode.SelectNodes("clearingStatus");
            if (clearingStatusNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in clearingStatusNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        clearingStatusIDRef = item.Attributes["id"].Name;
                        ClearingStatusValue ob = ClearingStatusValue();
                        IDManager.SetID(clearingStatusIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        clearingStatusIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        clearingStatus = new ClearingStatusValue(item);
                    }
                }
            }
            
        
            XmlNodeList collateralizationTypeNodeList = xmlNode.SelectNodes("collateralizationType");
            if (collateralizationTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in collateralizationTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        collateralizationTypeIDRef = item.Attributes["id"].Name;
                        CollateralizationType ob = CollateralizationType();
                        IDManager.SetID(collateralizationTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        collateralizationTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        collateralizationType = new CollateralizationType(item);
                    }
                }
            }
            
        
            XmlNodeList reportingRegimeNodeList = xmlNode.SelectNodes("reportingRegime");
            
            foreach (XmlNode item in reportingRegimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        reportingRegimeIDRef = item.Attributes["id"].Name;
                        List<ReportingRegime> ob = new List<ReportingRegime>();
                        ob.Add(new ReportingRegime(item));
                        IDManager.SetID(reportingRegimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        reportingRegimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    reportingRegime.Add(new ReportingRegime(item));
                    }
                }
            }
            
        
            XmlNodeList endUserExceptionNodeList = xmlNode.SelectNodes("endUserException");
            if (endUserExceptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in endUserExceptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        endUserExceptionIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(endUserExceptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        endUserExceptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        endUserException = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList endUserExceptionDeclarationNodeList = xmlNode.SelectNodes("endUserExceptionDeclaration");
            if (endUserExceptionDeclarationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in endUserExceptionDeclarationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        endUserExceptionDeclarationIDRef = item.Attributes["id"].Name;
                        EndUserExceptionDeclaration ob = EndUserExceptionDeclaration();
                        IDManager.SetID(endUserExceptionDeclarationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        endUserExceptionDeclarationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        endUserExceptionDeclaration = new EndUserExceptionDeclaration(item);
                    }
                }
            }
            
        
            XmlNodeList nonStandardTermsNodeList = xmlNode.SelectNodes("nonStandardTerms");
            if (nonStandardTermsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nonStandardTermsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nonStandardTermsIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(nonStandardTermsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nonStandardTermsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nonStandardTerms = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList offMarketPriceNodeList = xmlNode.SelectNodes("offMarketPrice");
            if (offMarketPriceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in offMarketPriceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        offMarketPriceIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(offMarketPriceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        offMarketPriceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        offMarketPrice = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList largeSizeTradeNodeList = xmlNode.SelectNodes("largeSizeTrade");
            if (largeSizeTradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in largeSizeTradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        largeSizeTradeIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(largeSizeTradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        largeSizeTradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        largeSizeTrade = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList executionTypeNodeList = xmlNode.SelectNodes("executionType");
            if (executionTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in executionTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        executionTypeIDRef = item.Attributes["id"].Name;
                        ExecutionType ob = ExecutionType();
                        IDManager.SetID(executionTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        executionTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        executionType = new ExecutionType(item);
                    }
                }
            }
            
        
            XmlNodeList executionVenueTypeNodeList = xmlNode.SelectNodes("executionVenueType");
            if (executionVenueTypeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in executionVenueTypeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        executionVenueTypeIDRef = item.Attributes["id"].Name;
                        ExecutionVenueType ob = ExecutionVenueType();
                        IDManager.SetID(executionVenueTypeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        executionVenueTypeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        executionVenueType = new ExecutionVenueType(item);
                    }
                }
            }
            
        
            XmlNodeList verificationMethodNodeList = xmlNode.SelectNodes("verificationMethod");
            if (verificationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in verificationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        verificationMethodIDRef = item.Attributes["id"].Name;
                        VerificationMethod ob = VerificationMethod();
                        IDManager.SetID(verificationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        verificationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        verificationMethod = new VerificationMethod(item);
                    }
                }
            }
            
        
            XmlNodeList confirmationMethodNodeList = xmlNode.SelectNodes("confirmationMethod");
            if (confirmationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in confirmationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        confirmationMethodIDRef = item.Attributes["id"].Name;
                        ConfirmationMethod ob = ConfirmationMethod();
                        IDManager.SetID(confirmationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        confirmationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        confirmationMethod = new ConfirmationMethod(item);
                    }
                }
            }
            
        
        }
        
    
        #region PartyReference
        private PartyReference partyReference;
        public PartyReference PartyReference
        {
            get
            {
                if (this.partyReference != null)
                {
                    return this.partyReference; 
                }
                else if (this.partyReferenceIDRef != null)
                {
                    partyReference = IDManager.getID(partyReferenceIDRef) as PartyReference;
                    return this.partyReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.partyReference != value)
                {
                    this.partyReference = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region AccountReference
        private AccountReference accountReference;
        public AccountReference AccountReference
        {
            get
            {
                if (this.accountReference != null)
                {
                    return this.accountReference; 
                }
                else if (this.accountReferenceIDRef != null)
                {
                    accountReference = IDManager.getID(accountReferenceIDRef) as AccountReference;
                    return this.accountReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accountReference != value)
                {
                    this.accountReference = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region RelatedParty
        private List<RelatedParty> relatedParty;
        public List<RelatedParty> RelatedParty
        {
            get
            {
                if (this.relatedParty != null)
                {
                    return this.relatedParty; 
                }
                else if (this.relatedPartyIDRef != null)
                {
                    relatedParty = IDManager.getID(relatedPartyIDRef) as List<RelatedParty>;
                    return this.relatedParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relatedParty != value)
                {
                    this.relatedParty = value;
                }
            }
        }
        #endregion
        
        public string RelatedPartyIDRef { get; set; }
        #region ReportingRole
        private ReportingRole reportingRole;
        public ReportingRole ReportingRole
        {
            get
            {
                if (this.reportingRole != null)
                {
                    return this.reportingRole; 
                }
                else if (this.reportingRoleIDRef != null)
                {
                    reportingRole = IDManager.getID(reportingRoleIDRef) as ReportingRole;
                    return this.reportingRole; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reportingRole != value)
                {
                    this.reportingRole = value;
                }
            }
        }
        #endregion
        
        public string ReportingRoleIDRef { get; set; }
        #region Unit
        private List<Unit> unit;
        public List<Unit> Unit
        {
            get
            {
                if (this.unit != null)
                {
                    return this.unit; 
                }
                else if (this.unitIDRef != null)
                {
                    unit = IDManager.getID(unitIDRef) as List<Unit>;
                    return this.unit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.unit != value)
                {
                    this.unit = value;
                }
            }
        }
        #endregion
        
        public string UnitIDRef { get; set; }
        #region RelatedBusinessUnit
        private List<RelatedBusinessUnit> relatedBusinessUnit;
        public List<RelatedBusinessUnit> RelatedBusinessUnit
        {
            get
            {
                if (this.relatedBusinessUnit != null)
                {
                    return this.relatedBusinessUnit; 
                }
                else if (this.relatedBusinessUnitIDRef != null)
                {
                    relatedBusinessUnit = IDManager.getID(relatedBusinessUnitIDRef) as List<RelatedBusinessUnit>;
                    return this.relatedBusinessUnit; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relatedBusinessUnit != value)
                {
                    this.relatedBusinessUnit = value;
                }
            }
        }
        #endregion
        
        public string RelatedBusinessUnitIDRef { get; set; }
        #region RelatedPerson
        private List<RelatedPerson> relatedPerson;
        public List<RelatedPerson> RelatedPerson
        {
            get
            {
                if (this.relatedPerson != null)
                {
                    return this.relatedPerson; 
                }
                else if (this.relatedPersonIDRef != null)
                {
                    relatedPerson = IDManager.getID(relatedPersonIDRef) as List<RelatedPerson>;
                    return this.relatedPerson; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.relatedPerson != value)
                {
                    this.relatedPerson = value;
                }
            }
        }
        #endregion
        
        public string RelatedPersonIDRef { get; set; }
        #region IsAccountingHedge
        private XsdTypeBoolean isAccountingHedge;
        public XsdTypeBoolean IsAccountingHedge
        {
            get
            {
                if (this.isAccountingHedge != null)
                {
                    return this.isAccountingHedge; 
                }
                else if (this.isAccountingHedgeIDRef != null)
                {
                    isAccountingHedge = IDManager.getID(isAccountingHedgeIDRef) as XsdTypeBoolean;
                    return this.isAccountingHedge; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.isAccountingHedge != value)
                {
                    this.isAccountingHedge = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region Category
        private List<TradeCategory> category;
        public List<TradeCategory> Category
        {
            get
            {
                if (this.category != null)
                {
                    return this.category; 
                }
                else if (this.categoryIDRef != null)
                {
                    category = IDManager.getID(categoryIDRef) as List<TradeCategory>;
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
        
        public string TradeCategoryIDRef { get; set; }
        #region Trader
        private List<Trader> trader;
        public List<Trader> Trader
        {
            get
            {
                if (this.trader != null)
                {
                    return this.trader; 
                }
                else if (this.traderIDRef != null)
                {
                    trader = IDManager.getID(traderIDRef) as List<Trader>;
                    return this.trader; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.trader != value)
                {
                    this.trader = value;
                }
            }
        }
        #endregion
        
        public string TraderIDRef { get; set; }
        #region ExecutionDateTime
        private ExecutionDateTime executionDateTime;
        public ExecutionDateTime ExecutionDateTime
        {
            get
            {
                if (this.executionDateTime != null)
                {
                    return this.executionDateTime; 
                }
                else if (this.executionDateTimeIDRef != null)
                {
                    executionDateTime = IDManager.getID(executionDateTimeIDRef) as ExecutionDateTime;
                    return this.executionDateTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.executionDateTime != value)
                {
                    this.executionDateTime = value;
                }
            }
        }
        #endregion
        
        public string ExecutionDateTimeIDRef { get; set; }
        #region Timestamps
        private TradeProcessingTimestamps timestamps;
        public TradeProcessingTimestamps Timestamps
        {
            get
            {
                if (this.timestamps != null)
                {
                    return this.timestamps; 
                }
                else if (this.timestampsIDRef != null)
                {
                    timestamps = IDManager.getID(timestampsIDRef) as TradeProcessingTimestamps;
                    return this.timestamps; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.timestamps != value)
                {
                    this.timestamps = value;
                }
            }
        }
        #endregion
        
        public string TradeProcessingTimestampsIDRef { get; set; }
        #region IntentToAllocate
        private XsdTypeBoolean intentToAllocate;
        public XsdTypeBoolean IntentToAllocate
        {
            get
            {
                if (this.intentToAllocate != null)
                {
                    return this.intentToAllocate; 
                }
                else if (this.intentToAllocateIDRef != null)
                {
                    intentToAllocate = IDManager.getID(intentToAllocateIDRef) as XsdTypeBoolean;
                    return this.intentToAllocate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.intentToAllocate != value)
                {
                    this.intentToAllocate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AllocationStatus
        private AllocationReportingStatus allocationStatus;
        public AllocationReportingStatus AllocationStatus
        {
            get
            {
                if (this.allocationStatus != null)
                {
                    return this.allocationStatus; 
                }
                else if (this.allocationStatusIDRef != null)
                {
                    allocationStatus = IDManager.getID(allocationStatusIDRef) as AllocationReportingStatus;
                    return this.allocationStatus; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.allocationStatus != value)
                {
                    this.allocationStatus = value;
                }
            }
        }
        #endregion
        
        public string AllocationReportingStatusIDRef { get; set; }
        #region IntentToClear
        private XsdTypeBoolean intentToClear;
        public XsdTypeBoolean IntentToClear
        {
            get
            {
                if (this.intentToClear != null)
                {
                    return this.intentToClear; 
                }
                else if (this.intentToClearIDRef != null)
                {
                    intentToClear = IDManager.getID(intentToClearIDRef) as XsdTypeBoolean;
                    return this.intentToClear; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.intentToClear != value)
                {
                    this.intentToClear = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ClearingStatus
        private ClearingStatusValue clearingStatus;
        public ClearingStatusValue ClearingStatus
        {
            get
            {
                if (this.clearingStatus != null)
                {
                    return this.clearingStatus; 
                }
                else if (this.clearingStatusIDRef != null)
                {
                    clearingStatus = IDManager.getID(clearingStatusIDRef) as ClearingStatusValue;
                    return this.clearingStatus; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.clearingStatus != value)
                {
                    this.clearingStatus = value;
                }
            }
        }
        #endregion
        
        public string ClearingStatusValueIDRef { get; set; }
        #region CollateralizationType
        private CollateralizationType collateralizationType;
        public CollateralizationType CollateralizationType
        {
            get
            {
                if (this.collateralizationType != null)
                {
                    return this.collateralizationType; 
                }
                else if (this.collateralizationTypeIDRef != null)
                {
                    collateralizationType = IDManager.getID(collateralizationTypeIDRef) as CollateralizationType;
                    return this.collateralizationType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.collateralizationType != value)
                {
                    this.collateralizationType = value;
                }
            }
        }
        #endregion
        
        public string CollateralizationTypeIDRef { get; set; }
        #region ReportingRegime
        private List<ReportingRegime> reportingRegime;
        public List<ReportingRegime> ReportingRegime
        {
            get
            {
                if (this.reportingRegime != null)
                {
                    return this.reportingRegime; 
                }
                else if (this.reportingRegimeIDRef != null)
                {
                    reportingRegime = IDManager.getID(reportingRegimeIDRef) as List<ReportingRegime>;
                    return this.reportingRegime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.reportingRegime != value)
                {
                    this.reportingRegime = value;
                }
            }
        }
        #endregion
        
        public string ReportingRegimeIDRef { get; set; }
        #region EndUserException
        private XsdTypeBoolean endUserException;
        public XsdTypeBoolean EndUserException
        {
            get
            {
                if (this.endUserException != null)
                {
                    return this.endUserException; 
                }
                else if (this.endUserExceptionIDRef != null)
                {
                    endUserException = IDManager.getID(endUserExceptionIDRef) as XsdTypeBoolean;
                    return this.endUserException; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.endUserException != value)
                {
                    this.endUserException = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region EndUserExceptionDeclaration
        private EndUserExceptionDeclaration endUserExceptionDeclaration;
        public EndUserExceptionDeclaration EndUserExceptionDeclaration
        {
            get
            {
                if (this.endUserExceptionDeclaration != null)
                {
                    return this.endUserExceptionDeclaration; 
                }
                else if (this.endUserExceptionDeclarationIDRef != null)
                {
                    endUserExceptionDeclaration = IDManager.getID(endUserExceptionDeclarationIDRef) as EndUserExceptionDeclaration;
                    return this.endUserExceptionDeclaration; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.endUserExceptionDeclaration != value)
                {
                    this.endUserExceptionDeclaration = value;
                }
            }
        }
        #endregion
        
        public string EndUserExceptionDeclarationIDRef { get; set; }
        #region NonStandardTerms
        private XsdTypeBoolean nonStandardTerms;
        public XsdTypeBoolean NonStandardTerms
        {
            get
            {
                if (this.nonStandardTerms != null)
                {
                    return this.nonStandardTerms; 
                }
                else if (this.nonStandardTermsIDRef != null)
                {
                    nonStandardTerms = IDManager.getID(nonStandardTermsIDRef) as XsdTypeBoolean;
                    return this.nonStandardTerms; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nonStandardTerms != value)
                {
                    this.nonStandardTerms = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region OffMarketPrice
        private XsdTypeBoolean offMarketPrice;
        public XsdTypeBoolean OffMarketPrice
        {
            get
            {
                if (this.offMarketPrice != null)
                {
                    return this.offMarketPrice; 
                }
                else if (this.offMarketPriceIDRef != null)
                {
                    offMarketPrice = IDManager.getID(offMarketPriceIDRef) as XsdTypeBoolean;
                    return this.offMarketPrice; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.offMarketPrice != value)
                {
                    this.offMarketPrice = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region LargeSizeTrade
        private XsdTypeBoolean largeSizeTrade;
        public XsdTypeBoolean LargeSizeTrade
        {
            get
            {
                if (this.largeSizeTrade != null)
                {
                    return this.largeSizeTrade; 
                }
                else if (this.largeSizeTradeIDRef != null)
                {
                    largeSizeTrade = IDManager.getID(largeSizeTradeIDRef) as XsdTypeBoolean;
                    return this.largeSizeTrade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.largeSizeTrade != value)
                {
                    this.largeSizeTrade = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ExecutionType
        private ExecutionType executionType;
        public ExecutionType ExecutionType
        {
            get
            {
                if (this.executionType != null)
                {
                    return this.executionType; 
                }
                else if (this.executionTypeIDRef != null)
                {
                    executionType = IDManager.getID(executionTypeIDRef) as ExecutionType;
                    return this.executionType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.executionType != value)
                {
                    this.executionType = value;
                }
            }
        }
        #endregion
        
        public string ExecutionTypeIDRef { get; set; }
        #region ExecutionVenueType
        private ExecutionVenueType executionVenueType;
        public ExecutionVenueType ExecutionVenueType
        {
            get
            {
                if (this.executionVenueType != null)
                {
                    return this.executionVenueType; 
                }
                else if (this.executionVenueTypeIDRef != null)
                {
                    executionVenueType = IDManager.getID(executionVenueTypeIDRef) as ExecutionVenueType;
                    return this.executionVenueType; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.executionVenueType != value)
                {
                    this.executionVenueType = value;
                }
            }
        }
        #endregion
        
        public string ExecutionVenueTypeIDRef { get; set; }
        #region VerificationMethod
        private VerificationMethod verificationMethod;
        public VerificationMethod VerificationMethod
        {
            get
            {
                if (this.verificationMethod != null)
                {
                    return this.verificationMethod; 
                }
                else if (this.verificationMethodIDRef != null)
                {
                    verificationMethod = IDManager.getID(verificationMethodIDRef) as VerificationMethod;
                    return this.verificationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.verificationMethod != value)
                {
                    this.verificationMethod = value;
                }
            }
        }
        #endregion
        
        public string VerificationMethodIDRef { get; set; }
        #region ConfirmationMethod
        private ConfirmationMethod confirmationMethod;
        public ConfirmationMethod ConfirmationMethod
        {
            get
            {
                if (this.confirmationMethod != null)
                {
                    return this.confirmationMethod; 
                }
                else if (this.confirmationMethodIDRef != null)
                {
                    confirmationMethod = IDManager.getID(confirmationMethodIDRef) as ConfirmationMethod;
                    return this.confirmationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.confirmationMethod != value)
                {
                    this.confirmationMethod = value;
                }
            }
        }
        #endregion
        
        public string ConfirmationMethodIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

