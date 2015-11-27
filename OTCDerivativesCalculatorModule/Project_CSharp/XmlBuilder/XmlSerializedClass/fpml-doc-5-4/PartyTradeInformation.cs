using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class PartyTradeInformation : ISerialized
    {
        public PartyTradeInformation(XmlNode xmlNode)
        {
            XmlNode partyReferenceNode = xmlNode.SelectSingleNode("partyReference");
            
            if (partyReferenceNode != null)
            {
                if (partyReferenceNode.Attributes["href"] != null || partyReferenceNode.Attributes["id"] != null) 
                {
                    if (partyReferenceNode.Attributes["id"] != null) 
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(partyReferenceNode);
                        IDManager.SetID(partyReferenceIDRef_, ob);
                    }
                    else if (partyReferenceNode.Attributes["href"] != null)
                    {
                        partyReferenceIDRef_ = partyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        partyReference_ = new PartyReference(partyReferenceNode);
                    }
                }
                else
                {
                    partyReference_ = new PartyReference(partyReferenceNode);
                }
            }
            
        
            XmlNode accountReferenceNode = xmlNode.SelectSingleNode("accountReference");
            
            if (accountReferenceNode != null)
            {
                if (accountReferenceNode.Attributes["href"] != null || accountReferenceNode.Attributes["id"] != null) 
                {
                    if (accountReferenceNode.Attributes["id"] != null) 
                    {
                        accountReferenceIDRef_ = accountReferenceNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(accountReferenceNode);
                        IDManager.SetID(accountReferenceIDRef_, ob);
                    }
                    else if (accountReferenceNode.Attributes["href"] != null)
                    {
                        accountReferenceIDRef_ = accountReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accountReference_ = new AccountReference(accountReferenceNode);
                    }
                }
                else
                {
                    accountReference_ = new AccountReference(accountReferenceNode);
                }
            }
            
        
            XmlNodeList relatedPartyNodeList = xmlNode.SelectNodes("relatedParty");
            
            if (relatedPartyNodeList != null)
            {
                this.relatedParty_ = new List<RelatedParty>();
                foreach (XmlNode item in relatedPartyNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            relatedPartyIDRef_ = item.Attributes["id"].Value;
                            relatedParty_.Add(new RelatedParty(item));
                            IDManager.SetID(relatedPartyIDRef_, relatedParty_[relatedParty_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            relatedPartyIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        relatedParty_.Add(new RelatedParty(item));
                        }
                    }
                    else
                    {
                        relatedParty_.Add(new RelatedParty(item));
                    }
                }
            }
            
        
            XmlNode reportingRoleNode = xmlNode.SelectSingleNode("reportingRole");
            
            if (reportingRoleNode != null)
            {
                if (reportingRoleNode.Attributes["href"] != null || reportingRoleNode.Attributes["id"] != null) 
                {
                    if (reportingRoleNode.Attributes["id"] != null) 
                    {
                        reportingRoleIDRef_ = reportingRoleNode.Attributes["id"].Value;
                        ReportingRole ob = new ReportingRole(reportingRoleNode);
                        IDManager.SetID(reportingRoleIDRef_, ob);
                    }
                    else if (reportingRoleNode.Attributes["href"] != null)
                    {
                        reportingRoleIDRef_ = reportingRoleNode.Attributes["href"].Value;
                    }
                    else
                    {
                        reportingRole_ = new ReportingRole(reportingRoleNode);
                    }
                }
                else
                {
                    reportingRole_ = new ReportingRole(reportingRoleNode);
                }
            }
            
        
            XmlNodeList unitNodeList = xmlNode.SelectNodes("unit");
            
            if (unitNodeList != null)
            {
                this.unit_ = new List<Unit>();
                foreach (XmlNode item in unitNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            unitIDRef_ = item.Attributes["id"].Value;
                            unit_.Add(new Unit(item));
                            IDManager.SetID(unitIDRef_, unit_[unit_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            unitIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        unit_.Add(new Unit(item));
                        }
                    }
                    else
                    {
                        unit_.Add(new Unit(item));
                    }
                }
            }
            
        
            XmlNodeList relatedBusinessUnitNodeList = xmlNode.SelectNodes("relatedBusinessUnit");
            
            if (relatedBusinessUnitNodeList != null)
            {
                this.relatedBusinessUnit_ = new List<RelatedBusinessUnit>();
                foreach (XmlNode item in relatedBusinessUnitNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            relatedBusinessUnitIDRef_ = item.Attributes["id"].Value;
                            relatedBusinessUnit_.Add(new RelatedBusinessUnit(item));
                            IDManager.SetID(relatedBusinessUnitIDRef_, relatedBusinessUnit_[relatedBusinessUnit_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            relatedBusinessUnitIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        relatedBusinessUnit_.Add(new RelatedBusinessUnit(item));
                        }
                    }
                    else
                    {
                        relatedBusinessUnit_.Add(new RelatedBusinessUnit(item));
                    }
                }
            }
            
        
            XmlNodeList relatedPersonNodeList = xmlNode.SelectNodes("relatedPerson");
            
            if (relatedPersonNodeList != null)
            {
                this.relatedPerson_ = new List<RelatedPerson>();
                foreach (XmlNode item in relatedPersonNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            relatedPersonIDRef_ = item.Attributes["id"].Value;
                            relatedPerson_.Add(new RelatedPerson(item));
                            IDManager.SetID(relatedPersonIDRef_, relatedPerson_[relatedPerson_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            relatedPersonIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        relatedPerson_.Add(new RelatedPerson(item));
                        }
                    }
                    else
                    {
                        relatedPerson_.Add(new RelatedPerson(item));
                    }
                }
            }
            
        
            XmlNode isAccountingHedgeNode = xmlNode.SelectSingleNode("isAccountingHedge");
            
            if (isAccountingHedgeNode != null)
            {
                if (isAccountingHedgeNode.Attributes["href"] != null || isAccountingHedgeNode.Attributes["id"] != null) 
                {
                    if (isAccountingHedgeNode.Attributes["id"] != null) 
                    {
                        isAccountingHedgeIDRef_ = isAccountingHedgeNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(isAccountingHedgeNode);
                        IDManager.SetID(isAccountingHedgeIDRef_, ob);
                    }
                    else if (isAccountingHedgeNode.Attributes["href"] != null)
                    {
                        isAccountingHedgeIDRef_ = isAccountingHedgeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        isAccountingHedge_ = new XsdTypeBoolean(isAccountingHedgeNode);
                    }
                }
                else
                {
                    isAccountingHedge_ = new XsdTypeBoolean(isAccountingHedgeNode);
                }
            }
            
        
            XmlNodeList categoryNodeList = xmlNode.SelectNodes("category");
            
            if (categoryNodeList != null)
            {
                this.category_ = new List<TradeCategory>();
                foreach (XmlNode item in categoryNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            categoryIDRef_ = item.Attributes["id"].Value;
                            category_.Add(new TradeCategory(item));
                            IDManager.SetID(categoryIDRef_, category_[category_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            categoryIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        category_.Add(new TradeCategory(item));
                        }
                    }
                    else
                    {
                        category_.Add(new TradeCategory(item));
                    }
                }
            }
            
        
            XmlNodeList traderNodeList = xmlNode.SelectNodes("trader");
            
            if (traderNodeList != null)
            {
                this.trader_ = new List<Trader>();
                foreach (XmlNode item in traderNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            traderIDRef_ = item.Attributes["id"].Value;
                            trader_.Add(new Trader(item));
                            IDManager.SetID(traderIDRef_, trader_[trader_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            traderIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        trader_.Add(new Trader(item));
                        }
                    }
                    else
                    {
                        trader_.Add(new Trader(item));
                    }
                }
            }
            
        
            XmlNode executionDateTimeNode = xmlNode.SelectSingleNode("executionDateTime");
            
            if (executionDateTimeNode != null)
            {
                if (executionDateTimeNode.Attributes["href"] != null || executionDateTimeNode.Attributes["id"] != null) 
                {
                    if (executionDateTimeNode.Attributes["id"] != null) 
                    {
                        executionDateTimeIDRef_ = executionDateTimeNode.Attributes["id"].Value;
                        ExecutionDateTime ob = new ExecutionDateTime(executionDateTimeNode);
                        IDManager.SetID(executionDateTimeIDRef_, ob);
                    }
                    else if (executionDateTimeNode.Attributes["href"] != null)
                    {
                        executionDateTimeIDRef_ = executionDateTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        executionDateTime_ = new ExecutionDateTime(executionDateTimeNode);
                    }
                }
                else
                {
                    executionDateTime_ = new ExecutionDateTime(executionDateTimeNode);
                }
            }
            
        
            XmlNode timestampsNode = xmlNode.SelectSingleNode("timestamps");
            
            if (timestampsNode != null)
            {
                if (timestampsNode.Attributes["href"] != null || timestampsNode.Attributes["id"] != null) 
                {
                    if (timestampsNode.Attributes["id"] != null) 
                    {
                        timestampsIDRef_ = timestampsNode.Attributes["id"].Value;
                        TradeProcessingTimestamps ob = new TradeProcessingTimestamps(timestampsNode);
                        IDManager.SetID(timestampsIDRef_, ob);
                    }
                    else if (timestampsNode.Attributes["href"] != null)
                    {
                        timestampsIDRef_ = timestampsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        timestamps_ = new TradeProcessingTimestamps(timestampsNode);
                    }
                }
                else
                {
                    timestamps_ = new TradeProcessingTimestamps(timestampsNode);
                }
            }
            
        
            XmlNode intentToAllocateNode = xmlNode.SelectSingleNode("intentToAllocate");
            
            if (intentToAllocateNode != null)
            {
                if (intentToAllocateNode.Attributes["href"] != null || intentToAllocateNode.Attributes["id"] != null) 
                {
                    if (intentToAllocateNode.Attributes["id"] != null) 
                    {
                        intentToAllocateIDRef_ = intentToAllocateNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(intentToAllocateNode);
                        IDManager.SetID(intentToAllocateIDRef_, ob);
                    }
                    else if (intentToAllocateNode.Attributes["href"] != null)
                    {
                        intentToAllocateIDRef_ = intentToAllocateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        intentToAllocate_ = new XsdTypeBoolean(intentToAllocateNode);
                    }
                }
                else
                {
                    intentToAllocate_ = new XsdTypeBoolean(intentToAllocateNode);
                }
            }
            
        
            XmlNode allocationStatusNode = xmlNode.SelectSingleNode("allocationStatus");
            
            if (allocationStatusNode != null)
            {
                if (allocationStatusNode.Attributes["href"] != null || allocationStatusNode.Attributes["id"] != null) 
                {
                    if (allocationStatusNode.Attributes["id"] != null) 
                    {
                        allocationStatusIDRef_ = allocationStatusNode.Attributes["id"].Value;
                        AllocationReportingStatus ob = new AllocationReportingStatus(allocationStatusNode);
                        IDManager.SetID(allocationStatusIDRef_, ob);
                    }
                    else if (allocationStatusNode.Attributes["href"] != null)
                    {
                        allocationStatusIDRef_ = allocationStatusNode.Attributes["href"].Value;
                    }
                    else
                    {
                        allocationStatus_ = new AllocationReportingStatus(allocationStatusNode);
                    }
                }
                else
                {
                    allocationStatus_ = new AllocationReportingStatus(allocationStatusNode);
                }
            }
            
        
            XmlNode intentToClearNode = xmlNode.SelectSingleNode("intentToClear");
            
            if (intentToClearNode != null)
            {
                if (intentToClearNode.Attributes["href"] != null || intentToClearNode.Attributes["id"] != null) 
                {
                    if (intentToClearNode.Attributes["id"] != null) 
                    {
                        intentToClearIDRef_ = intentToClearNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(intentToClearNode);
                        IDManager.SetID(intentToClearIDRef_, ob);
                    }
                    else if (intentToClearNode.Attributes["href"] != null)
                    {
                        intentToClearIDRef_ = intentToClearNode.Attributes["href"].Value;
                    }
                    else
                    {
                        intentToClear_ = new XsdTypeBoolean(intentToClearNode);
                    }
                }
                else
                {
                    intentToClear_ = new XsdTypeBoolean(intentToClearNode);
                }
            }
            
        
            XmlNode clearingStatusNode = xmlNode.SelectSingleNode("clearingStatus");
            
            if (clearingStatusNode != null)
            {
                if (clearingStatusNode.Attributes["href"] != null || clearingStatusNode.Attributes["id"] != null) 
                {
                    if (clearingStatusNode.Attributes["id"] != null) 
                    {
                        clearingStatusIDRef_ = clearingStatusNode.Attributes["id"].Value;
                        ClearingStatusValue ob = new ClearingStatusValue(clearingStatusNode);
                        IDManager.SetID(clearingStatusIDRef_, ob);
                    }
                    else if (clearingStatusNode.Attributes["href"] != null)
                    {
                        clearingStatusIDRef_ = clearingStatusNode.Attributes["href"].Value;
                    }
                    else
                    {
                        clearingStatus_ = new ClearingStatusValue(clearingStatusNode);
                    }
                }
                else
                {
                    clearingStatus_ = new ClearingStatusValue(clearingStatusNode);
                }
            }
            
        
            XmlNode collateralizationTypeNode = xmlNode.SelectSingleNode("collateralizationType");
            
            if (collateralizationTypeNode != null)
            {
                if (collateralizationTypeNode.Attributes["href"] != null || collateralizationTypeNode.Attributes["id"] != null) 
                {
                    if (collateralizationTypeNode.Attributes["id"] != null) 
                    {
                        collateralizationTypeIDRef_ = collateralizationTypeNode.Attributes["id"].Value;
                        CollateralizationType ob = new CollateralizationType(collateralizationTypeNode);
                        IDManager.SetID(collateralizationTypeIDRef_, ob);
                    }
                    else if (collateralizationTypeNode.Attributes["href"] != null)
                    {
                        collateralizationTypeIDRef_ = collateralizationTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        collateralizationType_ = new CollateralizationType(collateralizationTypeNode);
                    }
                }
                else
                {
                    collateralizationType_ = new CollateralizationType(collateralizationTypeNode);
                }
            }
            
        
            XmlNodeList reportingRegimeNodeList = xmlNode.SelectNodes("reportingRegime");
            
            if (reportingRegimeNodeList != null)
            {
                this.reportingRegime_ = new List<ReportingRegime>();
                foreach (XmlNode item in reportingRegimeNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            reportingRegimeIDRef_ = item.Attributes["id"].Value;
                            reportingRegime_.Add(new ReportingRegime(item));
                            IDManager.SetID(reportingRegimeIDRef_, reportingRegime_[reportingRegime_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            reportingRegimeIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        reportingRegime_.Add(new ReportingRegime(item));
                        }
                    }
                    else
                    {
                        reportingRegime_.Add(new ReportingRegime(item));
                    }
                }
            }
            
        
            XmlNode endUserExceptionNode = xmlNode.SelectSingleNode("endUserException");
            
            if (endUserExceptionNode != null)
            {
                if (endUserExceptionNode.Attributes["href"] != null || endUserExceptionNode.Attributes["id"] != null) 
                {
                    if (endUserExceptionNode.Attributes["id"] != null) 
                    {
                        endUserExceptionIDRef_ = endUserExceptionNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(endUserExceptionNode);
                        IDManager.SetID(endUserExceptionIDRef_, ob);
                    }
                    else if (endUserExceptionNode.Attributes["href"] != null)
                    {
                        endUserExceptionIDRef_ = endUserExceptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        endUserException_ = new XsdTypeBoolean(endUserExceptionNode);
                    }
                }
                else
                {
                    endUserException_ = new XsdTypeBoolean(endUserExceptionNode);
                }
            }
            
        
            XmlNode endUserExceptionDeclarationNode = xmlNode.SelectSingleNode("endUserExceptionDeclaration");
            
            if (endUserExceptionDeclarationNode != null)
            {
                if (endUserExceptionDeclarationNode.Attributes["href"] != null || endUserExceptionDeclarationNode.Attributes["id"] != null) 
                {
                    if (endUserExceptionDeclarationNode.Attributes["id"] != null) 
                    {
                        endUserExceptionDeclarationIDRef_ = endUserExceptionDeclarationNode.Attributes["id"].Value;
                        EndUserExceptionDeclaration ob = new EndUserExceptionDeclaration(endUserExceptionDeclarationNode);
                        IDManager.SetID(endUserExceptionDeclarationIDRef_, ob);
                    }
                    else if (endUserExceptionDeclarationNode.Attributes["href"] != null)
                    {
                        endUserExceptionDeclarationIDRef_ = endUserExceptionDeclarationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        endUserExceptionDeclaration_ = new EndUserExceptionDeclaration(endUserExceptionDeclarationNode);
                    }
                }
                else
                {
                    endUserExceptionDeclaration_ = new EndUserExceptionDeclaration(endUserExceptionDeclarationNode);
                }
            }
            
        
            XmlNode nonStandardTermsNode = xmlNode.SelectSingleNode("nonStandardTerms");
            
            if (nonStandardTermsNode != null)
            {
                if (nonStandardTermsNode.Attributes["href"] != null || nonStandardTermsNode.Attributes["id"] != null) 
                {
                    if (nonStandardTermsNode.Attributes["id"] != null) 
                    {
                        nonStandardTermsIDRef_ = nonStandardTermsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(nonStandardTermsNode);
                        IDManager.SetID(nonStandardTermsIDRef_, ob);
                    }
                    else if (nonStandardTermsNode.Attributes["href"] != null)
                    {
                        nonStandardTermsIDRef_ = nonStandardTermsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonStandardTerms_ = new XsdTypeBoolean(nonStandardTermsNode);
                    }
                }
                else
                {
                    nonStandardTerms_ = new XsdTypeBoolean(nonStandardTermsNode);
                }
            }
            
        
            XmlNode offMarketPriceNode = xmlNode.SelectSingleNode("offMarketPrice");
            
            if (offMarketPriceNode != null)
            {
                if (offMarketPriceNode.Attributes["href"] != null || offMarketPriceNode.Attributes["id"] != null) 
                {
                    if (offMarketPriceNode.Attributes["id"] != null) 
                    {
                        offMarketPriceIDRef_ = offMarketPriceNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(offMarketPriceNode);
                        IDManager.SetID(offMarketPriceIDRef_, ob);
                    }
                    else if (offMarketPriceNode.Attributes["href"] != null)
                    {
                        offMarketPriceIDRef_ = offMarketPriceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        offMarketPrice_ = new XsdTypeBoolean(offMarketPriceNode);
                    }
                }
                else
                {
                    offMarketPrice_ = new XsdTypeBoolean(offMarketPriceNode);
                }
            }
            
        
            XmlNode largeSizeTradeNode = xmlNode.SelectSingleNode("largeSizeTrade");
            
            if (largeSizeTradeNode != null)
            {
                if (largeSizeTradeNode.Attributes["href"] != null || largeSizeTradeNode.Attributes["id"] != null) 
                {
                    if (largeSizeTradeNode.Attributes["id"] != null) 
                    {
                        largeSizeTradeIDRef_ = largeSizeTradeNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(largeSizeTradeNode);
                        IDManager.SetID(largeSizeTradeIDRef_, ob);
                    }
                    else if (largeSizeTradeNode.Attributes["href"] != null)
                    {
                        largeSizeTradeIDRef_ = largeSizeTradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        largeSizeTrade_ = new XsdTypeBoolean(largeSizeTradeNode);
                    }
                }
                else
                {
                    largeSizeTrade_ = new XsdTypeBoolean(largeSizeTradeNode);
                }
            }
            
        
            XmlNode executionTypeNode = xmlNode.SelectSingleNode("executionType");
            
            if (executionTypeNode != null)
            {
                if (executionTypeNode.Attributes["href"] != null || executionTypeNode.Attributes["id"] != null) 
                {
                    if (executionTypeNode.Attributes["id"] != null) 
                    {
                        executionTypeIDRef_ = executionTypeNode.Attributes["id"].Value;
                        ExecutionType ob = new ExecutionType(executionTypeNode);
                        IDManager.SetID(executionTypeIDRef_, ob);
                    }
                    else if (executionTypeNode.Attributes["href"] != null)
                    {
                        executionTypeIDRef_ = executionTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        executionType_ = new ExecutionType(executionTypeNode);
                    }
                }
                else
                {
                    executionType_ = new ExecutionType(executionTypeNode);
                }
            }
            
        
            XmlNode executionVenueTypeNode = xmlNode.SelectSingleNode("executionVenueType");
            
            if (executionVenueTypeNode != null)
            {
                if (executionVenueTypeNode.Attributes["href"] != null || executionVenueTypeNode.Attributes["id"] != null) 
                {
                    if (executionVenueTypeNode.Attributes["id"] != null) 
                    {
                        executionVenueTypeIDRef_ = executionVenueTypeNode.Attributes["id"].Value;
                        ExecutionVenueType ob = new ExecutionVenueType(executionVenueTypeNode);
                        IDManager.SetID(executionVenueTypeIDRef_, ob);
                    }
                    else if (executionVenueTypeNode.Attributes["href"] != null)
                    {
                        executionVenueTypeIDRef_ = executionVenueTypeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        executionVenueType_ = new ExecutionVenueType(executionVenueTypeNode);
                    }
                }
                else
                {
                    executionVenueType_ = new ExecutionVenueType(executionVenueTypeNode);
                }
            }
            
        
            XmlNode verificationMethodNode = xmlNode.SelectSingleNode("verificationMethod");
            
            if (verificationMethodNode != null)
            {
                if (verificationMethodNode.Attributes["href"] != null || verificationMethodNode.Attributes["id"] != null) 
                {
                    if (verificationMethodNode.Attributes["id"] != null) 
                    {
                        verificationMethodIDRef_ = verificationMethodNode.Attributes["id"].Value;
                        VerificationMethod ob = new VerificationMethod(verificationMethodNode);
                        IDManager.SetID(verificationMethodIDRef_, ob);
                    }
                    else if (verificationMethodNode.Attributes["href"] != null)
                    {
                        verificationMethodIDRef_ = verificationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        verificationMethod_ = new VerificationMethod(verificationMethodNode);
                    }
                }
                else
                {
                    verificationMethod_ = new VerificationMethod(verificationMethodNode);
                }
            }
            
        
            XmlNode confirmationMethodNode = xmlNode.SelectSingleNode("confirmationMethod");
            
            if (confirmationMethodNode != null)
            {
                if (confirmationMethodNode.Attributes["href"] != null || confirmationMethodNode.Attributes["id"] != null) 
                {
                    if (confirmationMethodNode.Attributes["id"] != null) 
                    {
                        confirmationMethodIDRef_ = confirmationMethodNode.Attributes["id"].Value;
                        ConfirmationMethod ob = new ConfirmationMethod(confirmationMethodNode);
                        IDManager.SetID(confirmationMethodIDRef_, ob);
                    }
                    else if (confirmationMethodNode.Attributes["href"] != null)
                    {
                        confirmationMethodIDRef_ = confirmationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        confirmationMethod_ = new ConfirmationMethod(confirmationMethodNode);
                    }
                }
                else
                {
                    confirmationMethod_ = new ConfirmationMethod(confirmationMethodNode);
                }
            }
            
        
        }
        
    
        #region PartyReference_
        private PartyReference partyReference_;
        public PartyReference PartyReference_
        {
            get
            {
                if (this.partyReference_ != null)
                {
                    return this.partyReference_; 
                }
                else if (this.partyReferenceIDRef_ != null)
                {
                    partyReference_ = IDManager.getID(partyReferenceIDRef_) as PartyReference;
                    return this.partyReference_; 
                }
                else
                {
                      return this.partyReference_; 
                }
            }
            set
            {
                if (this.partyReference_ != value)
                {
                    this.partyReference_ = value;
                }
            }
        }
        #endregion
        
        public string partyReferenceIDRef_ { get; set; }
        #region AccountReference_
        private AccountReference accountReference_;
        public AccountReference AccountReference_
        {
            get
            {
                if (this.accountReference_ != null)
                {
                    return this.accountReference_; 
                }
                else if (this.accountReferenceIDRef_ != null)
                {
                    accountReference_ = IDManager.getID(accountReferenceIDRef_) as AccountReference;
                    return this.accountReference_; 
                }
                else
                {
                      return this.accountReference_; 
                }
            }
            set
            {
                if (this.accountReference_ != value)
                {
                    this.accountReference_ = value;
                }
            }
        }
        #endregion
        
        public string accountReferenceIDRef_ { get; set; }
        #region RelatedParty_
        private List<RelatedParty> relatedParty_;
        public List<RelatedParty> RelatedParty_
        {
            get
            {
                if (this.relatedParty_ != null)
                {
                    return this.relatedParty_; 
                }
                else if (this.relatedPartyIDRef_ != null)
                {
                    return this.relatedParty_; 
                }
                else
                {
                      return this.relatedParty_; 
                }
            }
            set
            {
                if (this.relatedParty_ != value)
                {
                    this.relatedParty_ = value;
                }
            }
        }
        #endregion
        
        public string relatedPartyIDRef_ { get; set; }
        #region ReportingRole_
        private ReportingRole reportingRole_;
        public ReportingRole ReportingRole_
        {
            get
            {
                if (this.reportingRole_ != null)
                {
                    return this.reportingRole_; 
                }
                else if (this.reportingRoleIDRef_ != null)
                {
                    reportingRole_ = IDManager.getID(reportingRoleIDRef_) as ReportingRole;
                    return this.reportingRole_; 
                }
                else
                {
                      return this.reportingRole_; 
                }
            }
            set
            {
                if (this.reportingRole_ != value)
                {
                    this.reportingRole_ = value;
                }
            }
        }
        #endregion
        
        public string reportingRoleIDRef_ { get; set; }
        #region Unit_
        private List<Unit> unit_;
        public List<Unit> Unit_
        {
            get
            {
                if (this.unit_ != null)
                {
                    return this.unit_; 
                }
                else if (this.unitIDRef_ != null)
                {
                    return this.unit_; 
                }
                else
                {
                      return this.unit_; 
                }
            }
            set
            {
                if (this.unit_ != value)
                {
                    this.unit_ = value;
                }
            }
        }
        #endregion
        
        public string unitIDRef_ { get; set; }
        #region RelatedBusinessUnit_
        private List<RelatedBusinessUnit> relatedBusinessUnit_;
        public List<RelatedBusinessUnit> RelatedBusinessUnit_
        {
            get
            {
                if (this.relatedBusinessUnit_ != null)
                {
                    return this.relatedBusinessUnit_; 
                }
                else if (this.relatedBusinessUnitIDRef_ != null)
                {
                    return this.relatedBusinessUnit_; 
                }
                else
                {
                      return this.relatedBusinessUnit_; 
                }
            }
            set
            {
                if (this.relatedBusinessUnit_ != value)
                {
                    this.relatedBusinessUnit_ = value;
                }
            }
        }
        #endregion
        
        public string relatedBusinessUnitIDRef_ { get; set; }
        #region RelatedPerson_
        private List<RelatedPerson> relatedPerson_;
        public List<RelatedPerson> RelatedPerson_
        {
            get
            {
                if (this.relatedPerson_ != null)
                {
                    return this.relatedPerson_; 
                }
                else if (this.relatedPersonIDRef_ != null)
                {
                    return this.relatedPerson_; 
                }
                else
                {
                      return this.relatedPerson_; 
                }
            }
            set
            {
                if (this.relatedPerson_ != value)
                {
                    this.relatedPerson_ = value;
                }
            }
        }
        #endregion
        
        public string relatedPersonIDRef_ { get; set; }
        #region IsAccountingHedge_
        private XsdTypeBoolean isAccountingHedge_;
        public XsdTypeBoolean IsAccountingHedge_
        {
            get
            {
                if (this.isAccountingHedge_ != null)
                {
                    return this.isAccountingHedge_; 
                }
                else if (this.isAccountingHedgeIDRef_ != null)
                {
                    isAccountingHedge_ = IDManager.getID(isAccountingHedgeIDRef_) as XsdTypeBoolean;
                    return this.isAccountingHedge_; 
                }
                else
                {
                      return this.isAccountingHedge_; 
                }
            }
            set
            {
                if (this.isAccountingHedge_ != value)
                {
                    this.isAccountingHedge_ = value;
                }
            }
        }
        #endregion
        
        public string isAccountingHedgeIDRef_ { get; set; }
        #region Category_
        private List<TradeCategory> category_;
        public List<TradeCategory> Category_
        {
            get
            {
                if (this.category_ != null)
                {
                    return this.category_; 
                }
                else if (this.categoryIDRef_ != null)
                {
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
        #region Trader_
        private List<Trader> trader_;
        public List<Trader> Trader_
        {
            get
            {
                if (this.trader_ != null)
                {
                    return this.trader_; 
                }
                else if (this.traderIDRef_ != null)
                {
                    return this.trader_; 
                }
                else
                {
                      return this.trader_; 
                }
            }
            set
            {
                if (this.trader_ != value)
                {
                    this.trader_ = value;
                }
            }
        }
        #endregion
        
        public string traderIDRef_ { get; set; }
        #region ExecutionDateTime_
        private ExecutionDateTime executionDateTime_;
        public ExecutionDateTime ExecutionDateTime_
        {
            get
            {
                if (this.executionDateTime_ != null)
                {
                    return this.executionDateTime_; 
                }
                else if (this.executionDateTimeIDRef_ != null)
                {
                    executionDateTime_ = IDManager.getID(executionDateTimeIDRef_) as ExecutionDateTime;
                    return this.executionDateTime_; 
                }
                else
                {
                      return this.executionDateTime_; 
                }
            }
            set
            {
                if (this.executionDateTime_ != value)
                {
                    this.executionDateTime_ = value;
                }
            }
        }
        #endregion
        
        public string executionDateTimeIDRef_ { get; set; }
        #region Timestamps_
        private TradeProcessingTimestamps timestamps_;
        public TradeProcessingTimestamps Timestamps_
        {
            get
            {
                if (this.timestamps_ != null)
                {
                    return this.timestamps_; 
                }
                else if (this.timestampsIDRef_ != null)
                {
                    timestamps_ = IDManager.getID(timestampsIDRef_) as TradeProcessingTimestamps;
                    return this.timestamps_; 
                }
                else
                {
                      return this.timestamps_; 
                }
            }
            set
            {
                if (this.timestamps_ != value)
                {
                    this.timestamps_ = value;
                }
            }
        }
        #endregion
        
        public string timestampsIDRef_ { get; set; }
        #region IntentToAllocate_
        private XsdTypeBoolean intentToAllocate_;
        public XsdTypeBoolean IntentToAllocate_
        {
            get
            {
                if (this.intentToAllocate_ != null)
                {
                    return this.intentToAllocate_; 
                }
                else if (this.intentToAllocateIDRef_ != null)
                {
                    intentToAllocate_ = IDManager.getID(intentToAllocateIDRef_) as XsdTypeBoolean;
                    return this.intentToAllocate_; 
                }
                else
                {
                      return this.intentToAllocate_; 
                }
            }
            set
            {
                if (this.intentToAllocate_ != value)
                {
                    this.intentToAllocate_ = value;
                }
            }
        }
        #endregion
        
        public string intentToAllocateIDRef_ { get; set; }
        #region AllocationStatus_
        private AllocationReportingStatus allocationStatus_;
        public AllocationReportingStatus AllocationStatus_
        {
            get
            {
                if (this.allocationStatus_ != null)
                {
                    return this.allocationStatus_; 
                }
                else if (this.allocationStatusIDRef_ != null)
                {
                    allocationStatus_ = IDManager.getID(allocationStatusIDRef_) as AllocationReportingStatus;
                    return this.allocationStatus_; 
                }
                else
                {
                      return this.allocationStatus_; 
                }
            }
            set
            {
                if (this.allocationStatus_ != value)
                {
                    this.allocationStatus_ = value;
                }
            }
        }
        #endregion
        
        public string allocationStatusIDRef_ { get; set; }
        #region IntentToClear_
        private XsdTypeBoolean intentToClear_;
        public XsdTypeBoolean IntentToClear_
        {
            get
            {
                if (this.intentToClear_ != null)
                {
                    return this.intentToClear_; 
                }
                else if (this.intentToClearIDRef_ != null)
                {
                    intentToClear_ = IDManager.getID(intentToClearIDRef_) as XsdTypeBoolean;
                    return this.intentToClear_; 
                }
                else
                {
                      return this.intentToClear_; 
                }
            }
            set
            {
                if (this.intentToClear_ != value)
                {
                    this.intentToClear_ = value;
                }
            }
        }
        #endregion
        
        public string intentToClearIDRef_ { get; set; }
        #region ClearingStatus_
        private ClearingStatusValue clearingStatus_;
        public ClearingStatusValue ClearingStatus_
        {
            get
            {
                if (this.clearingStatus_ != null)
                {
                    return this.clearingStatus_; 
                }
                else if (this.clearingStatusIDRef_ != null)
                {
                    clearingStatus_ = IDManager.getID(clearingStatusIDRef_) as ClearingStatusValue;
                    return this.clearingStatus_; 
                }
                else
                {
                      return this.clearingStatus_; 
                }
            }
            set
            {
                if (this.clearingStatus_ != value)
                {
                    this.clearingStatus_ = value;
                }
            }
        }
        #endregion
        
        public string clearingStatusIDRef_ { get; set; }
        #region CollateralizationType_
        private CollateralizationType collateralizationType_;
        public CollateralizationType CollateralizationType_
        {
            get
            {
                if (this.collateralizationType_ != null)
                {
                    return this.collateralizationType_; 
                }
                else if (this.collateralizationTypeIDRef_ != null)
                {
                    collateralizationType_ = IDManager.getID(collateralizationTypeIDRef_) as CollateralizationType;
                    return this.collateralizationType_; 
                }
                else
                {
                      return this.collateralizationType_; 
                }
            }
            set
            {
                if (this.collateralizationType_ != value)
                {
                    this.collateralizationType_ = value;
                }
            }
        }
        #endregion
        
        public string collateralizationTypeIDRef_ { get; set; }
        #region ReportingRegime_
        private List<ReportingRegime> reportingRegime_;
        public List<ReportingRegime> ReportingRegime_
        {
            get
            {
                if (this.reportingRegime_ != null)
                {
                    return this.reportingRegime_; 
                }
                else if (this.reportingRegimeIDRef_ != null)
                {
                    return this.reportingRegime_; 
                }
                else
                {
                      return this.reportingRegime_; 
                }
            }
            set
            {
                if (this.reportingRegime_ != value)
                {
                    this.reportingRegime_ = value;
                }
            }
        }
        #endregion
        
        public string reportingRegimeIDRef_ { get; set; }
        #region EndUserException_
        private XsdTypeBoolean endUserException_;
        public XsdTypeBoolean EndUserException_
        {
            get
            {
                if (this.endUserException_ != null)
                {
                    return this.endUserException_; 
                }
                else if (this.endUserExceptionIDRef_ != null)
                {
                    endUserException_ = IDManager.getID(endUserExceptionIDRef_) as XsdTypeBoolean;
                    return this.endUserException_; 
                }
                else
                {
                      return this.endUserException_; 
                }
            }
            set
            {
                if (this.endUserException_ != value)
                {
                    this.endUserException_ = value;
                }
            }
        }
        #endregion
        
        public string endUserExceptionIDRef_ { get; set; }
        #region EndUserExceptionDeclaration_
        private EndUserExceptionDeclaration endUserExceptionDeclaration_;
        public EndUserExceptionDeclaration EndUserExceptionDeclaration_
        {
            get
            {
                if (this.endUserExceptionDeclaration_ != null)
                {
                    return this.endUserExceptionDeclaration_; 
                }
                else if (this.endUserExceptionDeclarationIDRef_ != null)
                {
                    endUserExceptionDeclaration_ = IDManager.getID(endUserExceptionDeclarationIDRef_) as EndUserExceptionDeclaration;
                    return this.endUserExceptionDeclaration_; 
                }
                else
                {
                      return this.endUserExceptionDeclaration_; 
                }
            }
            set
            {
                if (this.endUserExceptionDeclaration_ != value)
                {
                    this.endUserExceptionDeclaration_ = value;
                }
            }
        }
        #endregion
        
        public string endUserExceptionDeclarationIDRef_ { get; set; }
        #region NonStandardTerms_
        private XsdTypeBoolean nonStandardTerms_;
        public XsdTypeBoolean NonStandardTerms_
        {
            get
            {
                if (this.nonStandardTerms_ != null)
                {
                    return this.nonStandardTerms_; 
                }
                else if (this.nonStandardTermsIDRef_ != null)
                {
                    nonStandardTerms_ = IDManager.getID(nonStandardTermsIDRef_) as XsdTypeBoolean;
                    return this.nonStandardTerms_; 
                }
                else
                {
                      return this.nonStandardTerms_; 
                }
            }
            set
            {
                if (this.nonStandardTerms_ != value)
                {
                    this.nonStandardTerms_ = value;
                }
            }
        }
        #endregion
        
        public string nonStandardTermsIDRef_ { get; set; }
        #region OffMarketPrice_
        private XsdTypeBoolean offMarketPrice_;
        public XsdTypeBoolean OffMarketPrice_
        {
            get
            {
                if (this.offMarketPrice_ != null)
                {
                    return this.offMarketPrice_; 
                }
                else if (this.offMarketPriceIDRef_ != null)
                {
                    offMarketPrice_ = IDManager.getID(offMarketPriceIDRef_) as XsdTypeBoolean;
                    return this.offMarketPrice_; 
                }
                else
                {
                      return this.offMarketPrice_; 
                }
            }
            set
            {
                if (this.offMarketPrice_ != value)
                {
                    this.offMarketPrice_ = value;
                }
            }
        }
        #endregion
        
        public string offMarketPriceIDRef_ { get; set; }
        #region LargeSizeTrade_
        private XsdTypeBoolean largeSizeTrade_;
        public XsdTypeBoolean LargeSizeTrade_
        {
            get
            {
                if (this.largeSizeTrade_ != null)
                {
                    return this.largeSizeTrade_; 
                }
                else if (this.largeSizeTradeIDRef_ != null)
                {
                    largeSizeTrade_ = IDManager.getID(largeSizeTradeIDRef_) as XsdTypeBoolean;
                    return this.largeSizeTrade_; 
                }
                else
                {
                      return this.largeSizeTrade_; 
                }
            }
            set
            {
                if (this.largeSizeTrade_ != value)
                {
                    this.largeSizeTrade_ = value;
                }
            }
        }
        #endregion
        
        public string largeSizeTradeIDRef_ { get; set; }
        #region ExecutionType_
        private ExecutionType executionType_;
        public ExecutionType ExecutionType_
        {
            get
            {
                if (this.executionType_ != null)
                {
                    return this.executionType_; 
                }
                else if (this.executionTypeIDRef_ != null)
                {
                    executionType_ = IDManager.getID(executionTypeIDRef_) as ExecutionType;
                    return this.executionType_; 
                }
                else
                {
                      return this.executionType_; 
                }
            }
            set
            {
                if (this.executionType_ != value)
                {
                    this.executionType_ = value;
                }
            }
        }
        #endregion
        
        public string executionTypeIDRef_ { get; set; }
        #region ExecutionVenueType_
        private ExecutionVenueType executionVenueType_;
        public ExecutionVenueType ExecutionVenueType_
        {
            get
            {
                if (this.executionVenueType_ != null)
                {
                    return this.executionVenueType_; 
                }
                else if (this.executionVenueTypeIDRef_ != null)
                {
                    executionVenueType_ = IDManager.getID(executionVenueTypeIDRef_) as ExecutionVenueType;
                    return this.executionVenueType_; 
                }
                else
                {
                      return this.executionVenueType_; 
                }
            }
            set
            {
                if (this.executionVenueType_ != value)
                {
                    this.executionVenueType_ = value;
                }
            }
        }
        #endregion
        
        public string executionVenueTypeIDRef_ { get; set; }
        #region VerificationMethod_
        private VerificationMethod verificationMethod_;
        public VerificationMethod VerificationMethod_
        {
            get
            {
                if (this.verificationMethod_ != null)
                {
                    return this.verificationMethod_; 
                }
                else if (this.verificationMethodIDRef_ != null)
                {
                    verificationMethod_ = IDManager.getID(verificationMethodIDRef_) as VerificationMethod;
                    return this.verificationMethod_; 
                }
                else
                {
                      return this.verificationMethod_; 
                }
            }
            set
            {
                if (this.verificationMethod_ != value)
                {
                    this.verificationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string verificationMethodIDRef_ { get; set; }
        #region ConfirmationMethod_
        private ConfirmationMethod confirmationMethod_;
        public ConfirmationMethod ConfirmationMethod_
        {
            get
            {
                if (this.confirmationMethod_ != null)
                {
                    return this.confirmationMethod_; 
                }
                else if (this.confirmationMethodIDRef_ != null)
                {
                    confirmationMethod_ = IDManager.getID(confirmationMethodIDRef_) as ConfirmationMethod;
                    return this.confirmationMethod_; 
                }
                else
                {
                      return this.confirmationMethod_; 
                }
            }
            set
            {
                if (this.confirmationMethod_ != value)
                {
                    this.confirmationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string confirmationMethodIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

