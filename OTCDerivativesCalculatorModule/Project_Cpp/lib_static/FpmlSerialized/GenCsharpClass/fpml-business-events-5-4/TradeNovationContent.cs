using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class TradeNovationContent
    {
        public TradeNovationContent(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList newTradeIdentifierNodeList = xmlNode.SelectNodes("newTradeIdentifier");
            
            foreach (XmlNode item in newTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        newTradeIdentifierIDRef = item.Attributes["id"].Name;
                        List<PartyTradeIdentifier> ob = new List<PartyTradeIdentifier>();
                        ob.Add(new PartyTradeIdentifier(item));
                        IDManager.SetID(newTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        newTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    newTradeIdentifier.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList newTradeNodeList = xmlNode.SelectNodes("newTrade");
            if (newTradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in newTradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        newTradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(newTradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        newTradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        newTrade = new Trade(item);
                    }
                }
            }
            
        
            XmlNodeList oldTradeIdentifierNodeList = xmlNode.SelectNodes("oldTradeIdentifier");
            
            foreach (XmlNode item in oldTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        oldTradeIdentifierIDRef = item.Attributes["id"].Name;
                        List<PartyTradeIdentifier> ob = new List<PartyTradeIdentifier>();
                        ob.Add(new PartyTradeIdentifier(item));
                        IDManager.SetID(oldTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        oldTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    oldTradeIdentifier.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNodeList oldTradeNodeList = xmlNode.SelectNodes("oldTrade");
            if (oldTradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in oldTradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        oldTradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(oldTradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        oldTradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        oldTrade = new Trade(item);
                    }
                }
            }
            
        
            XmlNodeList feeTradeIdentifierNodeList = xmlNode.SelectNodes("feeTradeIdentifier");
            if (feeTradeIdentifierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in feeTradeIdentifierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        feeTradeIdentifierIDRef = item.Attributes["id"].Name;
                        PartyTradeIdentifier ob = PartyTradeIdentifier();
                        IDManager.SetID(feeTradeIdentifierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        feeTradeIdentifierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        feeTradeIdentifier = new PartyTradeIdentifier(item);
                    }
                }
            }
            
        
            XmlNodeList feeTradeNodeList = xmlNode.SelectNodes("feeTrade");
            if (feeTradeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in feeTradeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        feeTradeIDRef = item.Attributes["id"].Name;
                        Trade ob = Trade();
                        IDManager.SetID(feeTradeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        feeTradeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        feeTrade = new Trade(item);
                    }
                }
            }
            
        
            XmlNodeList transferorNodeList = xmlNode.SelectNodes("transferor");
            if (transferorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in transferorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        transferorIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(transferorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        transferorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        transferor = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList transferorAccountNodeList = xmlNode.SelectNodes("transferorAccount");
            if (transferorAccountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in transferorAccountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        transferorAccountIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(transferorAccountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        transferorAccountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        transferorAccount = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList transfereeNodeList = xmlNode.SelectNodes("transferee");
            if (transfereeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in transfereeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        transfereeIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(transfereeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        transfereeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        transferee = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList otherTransfereeNodeList = xmlNode.SelectNodes("otherTransferee");
            if (otherTransfereeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in otherTransfereeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        otherTransfereeIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(otherTransfereeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        otherTransfereeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        otherTransferee = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList transfereeAccountNodeList = xmlNode.SelectNodes("transfereeAccount");
            if (transfereeAccountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in transfereeAccountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        transfereeAccountIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(transfereeAccountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        transfereeAccountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        transfereeAccount = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList otherTransfereeAccountNodeList = xmlNode.SelectNodes("otherTransfereeAccount");
            if (otherTransfereeAccountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in otherTransfereeAccountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        otherTransfereeAccountIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(otherTransfereeAccountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        otherTransfereeAccountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        otherTransfereeAccount = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList remainingPartyNodeList = xmlNode.SelectNodes("remainingParty");
            if (remainingPartyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in remainingPartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        remainingPartyIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(remainingPartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        remainingPartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        remainingParty = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList remainingPartyAccountNodeList = xmlNode.SelectNodes("remainingPartyAccount");
            if (remainingPartyAccountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in remainingPartyAccountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        remainingPartyAccountIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(remainingPartyAccountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        remainingPartyAccountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        remainingPartyAccount = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList otherRemainingPartyNodeList = xmlNode.SelectNodes("otherRemainingParty");
            if (otherRemainingPartyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in otherRemainingPartyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        otherRemainingPartyIDRef = item.Attributes["id"].Name;
                        PartyReference ob = PartyReference();
                        IDManager.SetID(otherRemainingPartyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        otherRemainingPartyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        otherRemainingParty = new PartyReference(item);
                    }
                }
            }
            
        
            XmlNodeList otherRemainingPartyAccountNodeList = xmlNode.SelectNodes("otherRemainingPartyAccount");
            if (otherRemainingPartyAccountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in otherRemainingPartyAccountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        otherRemainingPartyAccountIDRef = item.Attributes["id"].Name;
                        AccountReference ob = AccountReference();
                        IDManager.SetID(otherRemainingPartyAccountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        otherRemainingPartyAccountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        otherRemainingPartyAccount = new AccountReference(item);
                    }
                }
            }
            
        
            XmlNodeList novationDateNodeList = xmlNode.SelectNodes("novationDate");
            if (novationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in novationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        novationDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(novationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        novationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        novationDate = new XsdTypeDate(item);
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
            
        
            XmlNodeList novationTradeDateNodeList = xmlNode.SelectNodes("novationTradeDate");
            if (novationTradeDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in novationTradeDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        novationTradeDateIDRef = item.Attributes["id"].Name;
                        XsdTypeDate ob = XsdTypeDate();
                        IDManager.SetID(novationTradeDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        novationTradeDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        novationTradeDate = new XsdTypeDate(item);
                    }
                }
            }
            
        
            XmlNodeList novatedAmountNodeList = xmlNode.SelectNodes("novatedAmount");
            
            foreach (XmlNode item in novatedAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        novatedAmountIDRef = item.Attributes["id"].Name;
                        List<Money> ob = new List<Money>();
                        ob.Add(new Money(item));
                        IDManager.SetID(novatedAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        novatedAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    novatedAmount.Add(new Money(item));
                    }
                }
            }
            
        
            XmlNodeList remainingAmountNodeList = xmlNode.SelectNodes("remainingAmount");
            
            foreach (XmlNode item in remainingAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        remainingAmountIDRef = item.Attributes["id"].Name;
                        List<Money> ob = new List<Money>();
                        ob.Add(new Money(item));
                        IDManager.SetID(remainingAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        remainingAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    remainingAmount.Add(new Money(item));
                    }
                }
            }
            
        
            XmlNodeList novatedNumberOfOptionsNodeList = xmlNode.SelectNodes("novatedNumberOfOptions");
            if (novatedNumberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in novatedNumberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        novatedNumberOfOptionsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(novatedNumberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        novatedNumberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        novatedNumberOfOptions = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList remainingNumberOfOptionsNodeList = xmlNode.SelectNodes("remainingNumberOfOptions");
            if (remainingNumberOfOptionsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in remainingNumberOfOptionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        remainingNumberOfOptionsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(remainingNumberOfOptionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        remainingNumberOfOptionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        remainingNumberOfOptions = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList novatedNumberOfUnitsNodeList = xmlNode.SelectNodes("novatedNumberOfUnits");
            if (novatedNumberOfUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in novatedNumberOfUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        novatedNumberOfUnitsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(novatedNumberOfUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        novatedNumberOfUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        novatedNumberOfUnits = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList remainingNumberOfUnitsNodeList = xmlNode.SelectNodes("remainingNumberOfUnits");
            if (remainingNumberOfUnitsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in remainingNumberOfUnitsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        remainingNumberOfUnitsIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(remainingNumberOfUnitsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        remainingNumberOfUnitsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        remainingNumberOfUnits = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList fullFirstCalculationPeriodNodeList = xmlNode.SelectNodes("fullFirstCalculationPeriod");
            if (fullFirstCalculationPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fullFirstCalculationPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fullFirstCalculationPeriodIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(fullFirstCalculationPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fullFirstCalculationPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fullFirstCalculationPeriod = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList firstPeriodStartDateNodeList = xmlNode.SelectNodes("firstPeriodStartDate");
            
            foreach (XmlNode item in firstPeriodStartDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        firstPeriodStartDateIDRef = item.Attributes["id"].Name;
                        List<FirstPeriodStartDate> ob = new List<FirstPeriodStartDate>();
                        ob.Add(new FirstPeriodStartDate(item));
                        IDManager.SetID(firstPeriodStartDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        firstPeriodStartDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    firstPeriodStartDate.Add(new FirstPeriodStartDate(item));
                    }
                }
            }
            
        
            XmlNodeList nonRelianceNodeList = xmlNode.SelectNodes("nonReliance");
            if (nonRelianceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in nonRelianceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        nonRelianceIDRef = item.Attributes["id"].Name;
                        Empty ob = Empty();
                        IDManager.SetID(nonRelianceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        nonRelianceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        nonReliance = new Empty(item);
                    }
                }
            }
            
        
            XmlNodeList creditDerivativesNoticesNodeList = xmlNode.SelectNodes("creditDerivativesNotices");
            if (creditDerivativesNoticesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in creditDerivativesNoticesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        creditDerivativesNoticesIDRef = item.Attributes["id"].Name;
                        CreditDerivativesNotices ob = CreditDerivativesNotices();
                        IDManager.SetID(creditDerivativesNoticesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        creditDerivativesNoticesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        creditDerivativesNotices = new CreditDerivativesNotices(item);
                    }
                }
            }
            
        
            XmlNodeList contractualDefinitionsNodeList = xmlNode.SelectNodes("contractualDefinitions");
            
            foreach (XmlNode item in contractualDefinitionsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contractualDefinitionsIDRef = item.Attributes["id"].Name;
                        List<ContractualDefinitions> ob = new List<ContractualDefinitions>();
                        ob.Add(new ContractualDefinitions(item));
                        IDManager.SetID(contractualDefinitionsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contractualDefinitionsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    contractualDefinitions.Add(new ContractualDefinitions(item));
                    }
                }
            }
            
        
            XmlNodeList contractualTermsSupplementNodeList = xmlNode.SelectNodes("contractualTermsSupplement");
            
            foreach (XmlNode item in contractualTermsSupplementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        contractualTermsSupplementIDRef = item.Attributes["id"].Name;
                        List<ContractualTermsSupplement> ob = new List<ContractualTermsSupplement>();
                        ob.Add(new ContractualTermsSupplement(item));
                        IDManager.SetID(contractualTermsSupplementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        contractualTermsSupplementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    contractualTermsSupplement.Add(new ContractualTermsSupplement(item));
                    }
                }
            }
            
        
            XmlNodeList paymentNodeList = xmlNode.SelectNodes("payment");
            if (paymentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentIDRef = item.Attributes["id"].Name;
                        Payment ob = Payment();
                        IDManager.SetID(paymentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        payment = new Payment(item);
                    }
                }
            }
            
        
        }
        
    
        #region NewTradeIdentifier
        private List<PartyTradeIdentifier> newTradeIdentifier;
        public List<PartyTradeIdentifier> NewTradeIdentifier
        {
            get
            {
                if (this.newTradeIdentifier != null)
                {
                    return this.newTradeIdentifier; 
                }
                else if (this.newTradeIdentifierIDRef != null)
                {
                    newTradeIdentifier = IDManager.getID(newTradeIdentifierIDRef) as List<PartyTradeIdentifier>;
                    return this.newTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.newTradeIdentifier != value)
                {
                    this.newTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        #region NewTrade
        private Trade newTrade;
        public Trade NewTrade
        {
            get
            {
                if (this.newTrade != null)
                {
                    return this.newTrade; 
                }
                else if (this.newTradeIDRef != null)
                {
                    newTrade = IDManager.getID(newTradeIDRef) as Trade;
                    return this.newTrade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.newTrade != value)
                {
                    this.newTrade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
        #region OldTradeIdentifier
        private List<PartyTradeIdentifier> oldTradeIdentifier;
        public List<PartyTradeIdentifier> OldTradeIdentifier
        {
            get
            {
                if (this.oldTradeIdentifier != null)
                {
                    return this.oldTradeIdentifier; 
                }
                else if (this.oldTradeIdentifierIDRef != null)
                {
                    oldTradeIdentifier = IDManager.getID(oldTradeIdentifierIDRef) as List<PartyTradeIdentifier>;
                    return this.oldTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.oldTradeIdentifier != value)
                {
                    this.oldTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        #region OldTrade
        private Trade oldTrade;
        public Trade OldTrade
        {
            get
            {
                if (this.oldTrade != null)
                {
                    return this.oldTrade; 
                }
                else if (this.oldTradeIDRef != null)
                {
                    oldTrade = IDManager.getID(oldTradeIDRef) as Trade;
                    return this.oldTrade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.oldTrade != value)
                {
                    this.oldTrade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
        #region FeeTradeIdentifier
        private PartyTradeIdentifier feeTradeIdentifier;
        public PartyTradeIdentifier FeeTradeIdentifier
        {
            get
            {
                if (this.feeTradeIdentifier != null)
                {
                    return this.feeTradeIdentifier; 
                }
                else if (this.feeTradeIdentifierIDRef != null)
                {
                    feeTradeIdentifier = IDManager.getID(feeTradeIdentifierIDRef) as PartyTradeIdentifier;
                    return this.feeTradeIdentifier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.feeTradeIdentifier != value)
                {
                    this.feeTradeIdentifier = value;
                }
            }
        }
        #endregion
        
        public string PartyTradeIdentifierIDRef { get; set; }
        #region FeeTrade
        private Trade feeTrade;
        public Trade FeeTrade
        {
            get
            {
                if (this.feeTrade != null)
                {
                    return this.feeTrade; 
                }
                else if (this.feeTradeIDRef != null)
                {
                    feeTrade = IDManager.getID(feeTradeIDRef) as Trade;
                    return this.feeTrade; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.feeTrade != value)
                {
                    this.feeTrade = value;
                }
            }
        }
        #endregion
        
        public string TradeIDRef { get; set; }
        #region Transferor
        private PartyReference transferor;
        public PartyReference Transferor
        {
            get
            {
                if (this.transferor != null)
                {
                    return this.transferor; 
                }
                else if (this.transferorIDRef != null)
                {
                    transferor = IDManager.getID(transferorIDRef) as PartyReference;
                    return this.transferor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.transferor != value)
                {
                    this.transferor = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region TransferorAccount
        private AccountReference transferorAccount;
        public AccountReference TransferorAccount
        {
            get
            {
                if (this.transferorAccount != null)
                {
                    return this.transferorAccount; 
                }
                else if (this.transferorAccountIDRef != null)
                {
                    transferorAccount = IDManager.getID(transferorAccountIDRef) as AccountReference;
                    return this.transferorAccount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.transferorAccount != value)
                {
                    this.transferorAccount = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region Transferee
        private PartyReference transferee;
        public PartyReference Transferee
        {
            get
            {
                if (this.transferee != null)
                {
                    return this.transferee; 
                }
                else if (this.transfereeIDRef != null)
                {
                    transferee = IDManager.getID(transfereeIDRef) as PartyReference;
                    return this.transferee; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.transferee != value)
                {
                    this.transferee = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region OtherTransferee
        private PartyReference otherTransferee;
        public PartyReference OtherTransferee
        {
            get
            {
                if (this.otherTransferee != null)
                {
                    return this.otherTransferee; 
                }
                else if (this.otherTransfereeIDRef != null)
                {
                    otherTransferee = IDManager.getID(otherTransfereeIDRef) as PartyReference;
                    return this.otherTransferee; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.otherTransferee != value)
                {
                    this.otherTransferee = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region TransfereeAccount
        private AccountReference transfereeAccount;
        public AccountReference TransfereeAccount
        {
            get
            {
                if (this.transfereeAccount != null)
                {
                    return this.transfereeAccount; 
                }
                else if (this.transfereeAccountIDRef != null)
                {
                    transfereeAccount = IDManager.getID(transfereeAccountIDRef) as AccountReference;
                    return this.transfereeAccount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.transfereeAccount != value)
                {
                    this.transfereeAccount = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region OtherTransfereeAccount
        private AccountReference otherTransfereeAccount;
        public AccountReference OtherTransfereeAccount
        {
            get
            {
                if (this.otherTransfereeAccount != null)
                {
                    return this.otherTransfereeAccount; 
                }
                else if (this.otherTransfereeAccountIDRef != null)
                {
                    otherTransfereeAccount = IDManager.getID(otherTransfereeAccountIDRef) as AccountReference;
                    return this.otherTransfereeAccount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.otherTransfereeAccount != value)
                {
                    this.otherTransfereeAccount = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region RemainingParty
        private PartyReference remainingParty;
        public PartyReference RemainingParty
        {
            get
            {
                if (this.remainingParty != null)
                {
                    return this.remainingParty; 
                }
                else if (this.remainingPartyIDRef != null)
                {
                    remainingParty = IDManager.getID(remainingPartyIDRef) as PartyReference;
                    return this.remainingParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.remainingParty != value)
                {
                    this.remainingParty = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region RemainingPartyAccount
        private AccountReference remainingPartyAccount;
        public AccountReference RemainingPartyAccount
        {
            get
            {
                if (this.remainingPartyAccount != null)
                {
                    return this.remainingPartyAccount; 
                }
                else if (this.remainingPartyAccountIDRef != null)
                {
                    remainingPartyAccount = IDManager.getID(remainingPartyAccountIDRef) as AccountReference;
                    return this.remainingPartyAccount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.remainingPartyAccount != value)
                {
                    this.remainingPartyAccount = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region OtherRemainingParty
        private PartyReference otherRemainingParty;
        public PartyReference OtherRemainingParty
        {
            get
            {
                if (this.otherRemainingParty != null)
                {
                    return this.otherRemainingParty; 
                }
                else if (this.otherRemainingPartyIDRef != null)
                {
                    otherRemainingParty = IDManager.getID(otherRemainingPartyIDRef) as PartyReference;
                    return this.otherRemainingParty; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.otherRemainingParty != value)
                {
                    this.otherRemainingParty = value;
                }
            }
        }
        #endregion
        
        public string PartyReferenceIDRef { get; set; }
        #region OtherRemainingPartyAccount
        private AccountReference otherRemainingPartyAccount;
        public AccountReference OtherRemainingPartyAccount
        {
            get
            {
                if (this.otherRemainingPartyAccount != null)
                {
                    return this.otherRemainingPartyAccount; 
                }
                else if (this.otherRemainingPartyAccountIDRef != null)
                {
                    otherRemainingPartyAccount = IDManager.getID(otherRemainingPartyAccountIDRef) as AccountReference;
                    return this.otherRemainingPartyAccount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.otherRemainingPartyAccount != value)
                {
                    this.otherRemainingPartyAccount = value;
                }
            }
        }
        #endregion
        
        public string AccountReferenceIDRef { get; set; }
        #region NovationDate
        private XsdTypeDate novationDate;
        public XsdTypeDate NovationDate
        {
            get
            {
                if (this.novationDate != null)
                {
                    return this.novationDate; 
                }
                else if (this.novationDateIDRef != null)
                {
                    novationDate = IDManager.getID(novationDateIDRef) as XsdTypeDate;
                    return this.novationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.novationDate != value)
                {
                    this.novationDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
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
        #region NovationTradeDate
        private XsdTypeDate novationTradeDate;
        public XsdTypeDate NovationTradeDate
        {
            get
            {
                if (this.novationTradeDate != null)
                {
                    return this.novationTradeDate; 
                }
                else if (this.novationTradeDateIDRef != null)
                {
                    novationTradeDate = IDManager.getID(novationTradeDateIDRef) as XsdTypeDate;
                    return this.novationTradeDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.novationTradeDate != value)
                {
                    this.novationTradeDate = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDateIDRef { get; set; }
        #region NovatedAmount
        private List<Money> novatedAmount;
        public List<Money> NovatedAmount
        {
            get
            {
                if (this.novatedAmount != null)
                {
                    return this.novatedAmount; 
                }
                else if (this.novatedAmountIDRef != null)
                {
                    novatedAmount = IDManager.getID(novatedAmountIDRef) as List<Money>;
                    return this.novatedAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.novatedAmount != value)
                {
                    this.novatedAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region RemainingAmount
        private List<Money> remainingAmount;
        public List<Money> RemainingAmount
        {
            get
            {
                if (this.remainingAmount != null)
                {
                    return this.remainingAmount; 
                }
                else if (this.remainingAmountIDRef != null)
                {
                    remainingAmount = IDManager.getID(remainingAmountIDRef) as List<Money>;
                    return this.remainingAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.remainingAmount != value)
                {
                    this.remainingAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region NovatedNumberOfOptions
        private XsdTypeDecimal novatedNumberOfOptions;
        public XsdTypeDecimal NovatedNumberOfOptions
        {
            get
            {
                if (this.novatedNumberOfOptions != null)
                {
                    return this.novatedNumberOfOptions; 
                }
                else if (this.novatedNumberOfOptionsIDRef != null)
                {
                    novatedNumberOfOptions = IDManager.getID(novatedNumberOfOptionsIDRef) as XsdTypeDecimal;
                    return this.novatedNumberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.novatedNumberOfOptions != value)
                {
                    this.novatedNumberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region RemainingNumberOfOptions
        private XsdTypeDecimal remainingNumberOfOptions;
        public XsdTypeDecimal RemainingNumberOfOptions
        {
            get
            {
                if (this.remainingNumberOfOptions != null)
                {
                    return this.remainingNumberOfOptions; 
                }
                else if (this.remainingNumberOfOptionsIDRef != null)
                {
                    remainingNumberOfOptions = IDManager.getID(remainingNumberOfOptionsIDRef) as XsdTypeDecimal;
                    return this.remainingNumberOfOptions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.remainingNumberOfOptions != value)
                {
                    this.remainingNumberOfOptions = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region NovatedNumberOfUnits
        private XsdTypeDecimal novatedNumberOfUnits;
        public XsdTypeDecimal NovatedNumberOfUnits
        {
            get
            {
                if (this.novatedNumberOfUnits != null)
                {
                    return this.novatedNumberOfUnits; 
                }
                else if (this.novatedNumberOfUnitsIDRef != null)
                {
                    novatedNumberOfUnits = IDManager.getID(novatedNumberOfUnitsIDRef) as XsdTypeDecimal;
                    return this.novatedNumberOfUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.novatedNumberOfUnits != value)
                {
                    this.novatedNumberOfUnits = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region RemainingNumberOfUnits
        private XsdTypeDecimal remainingNumberOfUnits;
        public XsdTypeDecimal RemainingNumberOfUnits
        {
            get
            {
                if (this.remainingNumberOfUnits != null)
                {
                    return this.remainingNumberOfUnits; 
                }
                else if (this.remainingNumberOfUnitsIDRef != null)
                {
                    remainingNumberOfUnits = IDManager.getID(remainingNumberOfUnitsIDRef) as XsdTypeDecimal;
                    return this.remainingNumberOfUnits; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.remainingNumberOfUnits != value)
                {
                    this.remainingNumberOfUnits = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region FullFirstCalculationPeriod
        private XsdTypeBoolean fullFirstCalculationPeriod;
        public XsdTypeBoolean FullFirstCalculationPeriod
        {
            get
            {
                if (this.fullFirstCalculationPeriod != null)
                {
                    return this.fullFirstCalculationPeriod; 
                }
                else if (this.fullFirstCalculationPeriodIDRef != null)
                {
                    fullFirstCalculationPeriod = IDManager.getID(fullFirstCalculationPeriodIDRef) as XsdTypeBoolean;
                    return this.fullFirstCalculationPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fullFirstCalculationPeriod != value)
                {
                    this.fullFirstCalculationPeriod = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region FirstPeriodStartDate
        private List<FirstPeriodStartDate> firstPeriodStartDate;
        public List<FirstPeriodStartDate> FirstPeriodStartDate
        {
            get
            {
                if (this.firstPeriodStartDate != null)
                {
                    return this.firstPeriodStartDate; 
                }
                else if (this.firstPeriodStartDateIDRef != null)
                {
                    firstPeriodStartDate = IDManager.getID(firstPeriodStartDateIDRef) as List<FirstPeriodStartDate>;
                    return this.firstPeriodStartDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.firstPeriodStartDate != value)
                {
                    this.firstPeriodStartDate = value;
                }
            }
        }
        #endregion
        
        public string FirstPeriodStartDateIDRef { get; set; }
        #region NonReliance
        private Empty nonReliance;
        public Empty NonReliance
        {
            get
            {
                if (this.nonReliance != null)
                {
                    return this.nonReliance; 
                }
                else if (this.nonRelianceIDRef != null)
                {
                    nonReliance = IDManager.getID(nonRelianceIDRef) as Empty;
                    return this.nonReliance; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.nonReliance != value)
                {
                    this.nonReliance = value;
                }
            }
        }
        #endregion
        
        public string EmptyIDRef { get; set; }
        #region CreditDerivativesNotices
        private CreditDerivativesNotices creditDerivativesNotices;
        public CreditDerivativesNotices CreditDerivativesNotices
        {
            get
            {
                if (this.creditDerivativesNotices != null)
                {
                    return this.creditDerivativesNotices; 
                }
                else if (this.creditDerivativesNoticesIDRef != null)
                {
                    creditDerivativesNotices = IDManager.getID(creditDerivativesNoticesIDRef) as CreditDerivativesNotices;
                    return this.creditDerivativesNotices; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.creditDerivativesNotices != value)
                {
                    this.creditDerivativesNotices = value;
                }
            }
        }
        #endregion
        
        public string CreditDerivativesNoticesIDRef { get; set; }
        #region ContractualDefinitions
        private List<ContractualDefinitions> contractualDefinitions;
        public List<ContractualDefinitions> ContractualDefinitions
        {
            get
            {
                if (this.contractualDefinitions != null)
                {
                    return this.contractualDefinitions; 
                }
                else if (this.contractualDefinitionsIDRef != null)
                {
                    contractualDefinitions = IDManager.getID(contractualDefinitionsIDRef) as List<ContractualDefinitions>;
                    return this.contractualDefinitions; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contractualDefinitions != value)
                {
                    this.contractualDefinitions = value;
                }
            }
        }
        #endregion
        
        public string ContractualDefinitionsIDRef { get; set; }
        #region ContractualTermsSupplement
        private List<ContractualTermsSupplement> contractualTermsSupplement;
        public List<ContractualTermsSupplement> ContractualTermsSupplement
        {
            get
            {
                if (this.contractualTermsSupplement != null)
                {
                    return this.contractualTermsSupplement; 
                }
                else if (this.contractualTermsSupplementIDRef != null)
                {
                    contractualTermsSupplement = IDManager.getID(contractualTermsSupplementIDRef) as List<ContractualTermsSupplement>;
                    return this.contractualTermsSupplement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.contractualTermsSupplement != value)
                {
                    this.contractualTermsSupplement = value;
                }
            }
        }
        #endregion
        
        public string ContractualTermsSupplementIDRef { get; set; }
        #region Payment
        private Payment payment;
        public Payment Payment
        {
            get
            {
                if (this.payment != null)
                {
                    return this.payment; 
                }
                else if (this.paymentIDRef != null)
                {
                    payment = IDManager.getID(paymentIDRef) as Payment;
                    return this.payment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.payment != value)
                {
                    this.payment = value;
                }
            }
        }
        #endregion
        
        public string PaymentIDRef { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        public string choiceStr_2;
        public string choiceStr_3;
        public string choiceStr_4;
        public string choiceStr_5;
        public string choiceStr_6;
        public string choiceStr_7;
        
    
        
    
    }
    
}

