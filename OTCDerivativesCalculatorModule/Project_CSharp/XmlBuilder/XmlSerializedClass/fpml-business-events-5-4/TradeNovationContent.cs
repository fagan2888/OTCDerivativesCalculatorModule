using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class TradeNovationContent : AbstractEvent
    {
        public TradeNovationContent(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList newTradeIdentifierNodeList = xmlNode.SelectNodes("newTradeIdentifier");
            
            if (newTradeIdentifierNodeList != null)
            {
                this.newTradeIdentifier_ = new List<PartyTradeIdentifier>();
                foreach (XmlNode item in newTradeIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            newTradeIdentifierIDRef_ = item.Attributes["id"].Value;
                            newTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                            IDManager.SetID(newTradeIdentifierIDRef_, newTradeIdentifier_[newTradeIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            newTradeIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        newTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                        }
                    }
                    else
                    {
                        newTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNode newTradeNode = xmlNode.SelectSingleNode("newTrade");
            
            if (newTradeNode != null)
            {
                if (newTradeNode.Attributes["href"] != null || newTradeNode.Attributes["id"] != null) 
                {
                    if (newTradeNode.Attributes["id"] != null) 
                    {
                        newTradeIDRef_ = newTradeNode.Attributes["id"].Value;
                        Trade ob = new Trade(newTradeNode);
                        IDManager.SetID(newTradeIDRef_, ob);
                    }
                    else if (newTradeNode.Attributes["href"] != null)
                    {
                        newTradeIDRef_ = newTradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        newTrade_ = new Trade(newTradeNode);
                    }
                }
                else
                {
                    newTrade_ = new Trade(newTradeNode);
                }
            }
            
        
            XmlNodeList oldTradeIdentifierNodeList = xmlNode.SelectNodes("oldTradeIdentifier");
            
            if (oldTradeIdentifierNodeList != null)
            {
                this.oldTradeIdentifier_ = new List<PartyTradeIdentifier>();
                foreach (XmlNode item in oldTradeIdentifierNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            oldTradeIdentifierIDRef_ = item.Attributes["id"].Value;
                            oldTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                            IDManager.SetID(oldTradeIdentifierIDRef_, oldTradeIdentifier_[oldTradeIdentifier_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            oldTradeIdentifierIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        oldTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                        }
                    }
                    else
                    {
                        oldTradeIdentifier_.Add(new PartyTradeIdentifier(item));
                    }
                }
            }
            
        
            XmlNode oldTradeNode = xmlNode.SelectSingleNode("oldTrade");
            
            if (oldTradeNode != null)
            {
                if (oldTradeNode.Attributes["href"] != null || oldTradeNode.Attributes["id"] != null) 
                {
                    if (oldTradeNode.Attributes["id"] != null) 
                    {
                        oldTradeIDRef_ = oldTradeNode.Attributes["id"].Value;
                        Trade ob = new Trade(oldTradeNode);
                        IDManager.SetID(oldTradeIDRef_, ob);
                    }
                    else if (oldTradeNode.Attributes["href"] != null)
                    {
                        oldTradeIDRef_ = oldTradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        oldTrade_ = new Trade(oldTradeNode);
                    }
                }
                else
                {
                    oldTrade_ = new Trade(oldTradeNode);
                }
            }
            
        
            XmlNode feeTradeIdentifierNode = xmlNode.SelectSingleNode("feeTradeIdentifier");
            
            if (feeTradeIdentifierNode != null)
            {
                if (feeTradeIdentifierNode.Attributes["href"] != null || feeTradeIdentifierNode.Attributes["id"] != null) 
                {
                    if (feeTradeIdentifierNode.Attributes["id"] != null) 
                    {
                        feeTradeIdentifierIDRef_ = feeTradeIdentifierNode.Attributes["id"].Value;
                        PartyTradeIdentifier ob = new PartyTradeIdentifier(feeTradeIdentifierNode);
                        IDManager.SetID(feeTradeIdentifierIDRef_, ob);
                    }
                    else if (feeTradeIdentifierNode.Attributes["href"] != null)
                    {
                        feeTradeIdentifierIDRef_ = feeTradeIdentifierNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feeTradeIdentifier_ = new PartyTradeIdentifier(feeTradeIdentifierNode);
                    }
                }
                else
                {
                    feeTradeIdentifier_ = new PartyTradeIdentifier(feeTradeIdentifierNode);
                }
            }
            
        
            XmlNode feeTradeNode = xmlNode.SelectSingleNode("feeTrade");
            
            if (feeTradeNode != null)
            {
                if (feeTradeNode.Attributes["href"] != null || feeTradeNode.Attributes["id"] != null) 
                {
                    if (feeTradeNode.Attributes["id"] != null) 
                    {
                        feeTradeIDRef_ = feeTradeNode.Attributes["id"].Value;
                        Trade ob = new Trade(feeTradeNode);
                        IDManager.SetID(feeTradeIDRef_, ob);
                    }
                    else if (feeTradeNode.Attributes["href"] != null)
                    {
                        feeTradeIDRef_ = feeTradeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        feeTrade_ = new Trade(feeTradeNode);
                    }
                }
                else
                {
                    feeTrade_ = new Trade(feeTradeNode);
                }
            }
            
        
            XmlNode transferorNode = xmlNode.SelectSingleNode("transferor");
            
            if (transferorNode != null)
            {
                if (transferorNode.Attributes["href"] != null || transferorNode.Attributes["id"] != null) 
                {
                    if (transferorNode.Attributes["id"] != null) 
                    {
                        transferorIDRef_ = transferorNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(transferorNode);
                        IDManager.SetID(transferorIDRef_, ob);
                    }
                    else if (transferorNode.Attributes["href"] != null)
                    {
                        transferorIDRef_ = transferorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        transferor_ = new PartyReference(transferorNode);
                    }
                }
                else
                {
                    transferor_ = new PartyReference(transferorNode);
                }
            }
            
        
            XmlNode transferorAccountNode = xmlNode.SelectSingleNode("transferorAccount");
            
            if (transferorAccountNode != null)
            {
                if (transferorAccountNode.Attributes["href"] != null || transferorAccountNode.Attributes["id"] != null) 
                {
                    if (transferorAccountNode.Attributes["id"] != null) 
                    {
                        transferorAccountIDRef_ = transferorAccountNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(transferorAccountNode);
                        IDManager.SetID(transferorAccountIDRef_, ob);
                    }
                    else if (transferorAccountNode.Attributes["href"] != null)
                    {
                        transferorAccountIDRef_ = transferorAccountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        transferorAccount_ = new AccountReference(transferorAccountNode);
                    }
                }
                else
                {
                    transferorAccount_ = new AccountReference(transferorAccountNode);
                }
            }
            
        
            XmlNode transfereeNode = xmlNode.SelectSingleNode("transferee");
            
            if (transfereeNode != null)
            {
                if (transfereeNode.Attributes["href"] != null || transfereeNode.Attributes["id"] != null) 
                {
                    if (transfereeNode.Attributes["id"] != null) 
                    {
                        transfereeIDRef_ = transfereeNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(transfereeNode);
                        IDManager.SetID(transfereeIDRef_, ob);
                    }
                    else if (transfereeNode.Attributes["href"] != null)
                    {
                        transfereeIDRef_ = transfereeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        transferee_ = new PartyReference(transfereeNode);
                    }
                }
                else
                {
                    transferee_ = new PartyReference(transfereeNode);
                }
            }
            
        
            XmlNode otherTransfereeNode = xmlNode.SelectSingleNode("otherTransferee");
            
            if (otherTransfereeNode != null)
            {
                if (otherTransfereeNode.Attributes["href"] != null || otherTransfereeNode.Attributes["id"] != null) 
                {
                    if (otherTransfereeNode.Attributes["id"] != null) 
                    {
                        otherTransfereeIDRef_ = otherTransfereeNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(otherTransfereeNode);
                        IDManager.SetID(otherTransfereeIDRef_, ob);
                    }
                    else if (otherTransfereeNode.Attributes["href"] != null)
                    {
                        otherTransfereeIDRef_ = otherTransfereeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        otherTransferee_ = new PartyReference(otherTransfereeNode);
                    }
                }
                else
                {
                    otherTransferee_ = new PartyReference(otherTransfereeNode);
                }
            }
            
        
            XmlNode transfereeAccountNode = xmlNode.SelectSingleNode("transfereeAccount");
            
            if (transfereeAccountNode != null)
            {
                if (transfereeAccountNode.Attributes["href"] != null || transfereeAccountNode.Attributes["id"] != null) 
                {
                    if (transfereeAccountNode.Attributes["id"] != null) 
                    {
                        transfereeAccountIDRef_ = transfereeAccountNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(transfereeAccountNode);
                        IDManager.SetID(transfereeAccountIDRef_, ob);
                    }
                    else if (transfereeAccountNode.Attributes["href"] != null)
                    {
                        transfereeAccountIDRef_ = transfereeAccountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        transfereeAccount_ = new AccountReference(transfereeAccountNode);
                    }
                }
                else
                {
                    transfereeAccount_ = new AccountReference(transfereeAccountNode);
                }
            }
            
        
            XmlNode otherTransfereeAccountNode = xmlNode.SelectSingleNode("otherTransfereeAccount");
            
            if (otherTransfereeAccountNode != null)
            {
                if (otherTransfereeAccountNode.Attributes["href"] != null || otherTransfereeAccountNode.Attributes["id"] != null) 
                {
                    if (otherTransfereeAccountNode.Attributes["id"] != null) 
                    {
                        otherTransfereeAccountIDRef_ = otherTransfereeAccountNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(otherTransfereeAccountNode);
                        IDManager.SetID(otherTransfereeAccountIDRef_, ob);
                    }
                    else if (otherTransfereeAccountNode.Attributes["href"] != null)
                    {
                        otherTransfereeAccountIDRef_ = otherTransfereeAccountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        otherTransfereeAccount_ = new AccountReference(otherTransfereeAccountNode);
                    }
                }
                else
                {
                    otherTransfereeAccount_ = new AccountReference(otherTransfereeAccountNode);
                }
            }
            
        
            XmlNode remainingPartyNode = xmlNode.SelectSingleNode("remainingParty");
            
            if (remainingPartyNode != null)
            {
                if (remainingPartyNode.Attributes["href"] != null || remainingPartyNode.Attributes["id"] != null) 
                {
                    if (remainingPartyNode.Attributes["id"] != null) 
                    {
                        remainingPartyIDRef_ = remainingPartyNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(remainingPartyNode);
                        IDManager.SetID(remainingPartyIDRef_, ob);
                    }
                    else if (remainingPartyNode.Attributes["href"] != null)
                    {
                        remainingPartyIDRef_ = remainingPartyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        remainingParty_ = new PartyReference(remainingPartyNode);
                    }
                }
                else
                {
                    remainingParty_ = new PartyReference(remainingPartyNode);
                }
            }
            
        
            XmlNode remainingPartyAccountNode = xmlNode.SelectSingleNode("remainingPartyAccount");
            
            if (remainingPartyAccountNode != null)
            {
                if (remainingPartyAccountNode.Attributes["href"] != null || remainingPartyAccountNode.Attributes["id"] != null) 
                {
                    if (remainingPartyAccountNode.Attributes["id"] != null) 
                    {
                        remainingPartyAccountIDRef_ = remainingPartyAccountNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(remainingPartyAccountNode);
                        IDManager.SetID(remainingPartyAccountIDRef_, ob);
                    }
                    else if (remainingPartyAccountNode.Attributes["href"] != null)
                    {
                        remainingPartyAccountIDRef_ = remainingPartyAccountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        remainingPartyAccount_ = new AccountReference(remainingPartyAccountNode);
                    }
                }
                else
                {
                    remainingPartyAccount_ = new AccountReference(remainingPartyAccountNode);
                }
            }
            
        
            XmlNode otherRemainingPartyNode = xmlNode.SelectSingleNode("otherRemainingParty");
            
            if (otherRemainingPartyNode != null)
            {
                if (otherRemainingPartyNode.Attributes["href"] != null || otherRemainingPartyNode.Attributes["id"] != null) 
                {
                    if (otherRemainingPartyNode.Attributes["id"] != null) 
                    {
                        otherRemainingPartyIDRef_ = otherRemainingPartyNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(otherRemainingPartyNode);
                        IDManager.SetID(otherRemainingPartyIDRef_, ob);
                    }
                    else if (otherRemainingPartyNode.Attributes["href"] != null)
                    {
                        otherRemainingPartyIDRef_ = otherRemainingPartyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        otherRemainingParty_ = new PartyReference(otherRemainingPartyNode);
                    }
                }
                else
                {
                    otherRemainingParty_ = new PartyReference(otherRemainingPartyNode);
                }
            }
            
        
            XmlNode otherRemainingPartyAccountNode = xmlNode.SelectSingleNode("otherRemainingPartyAccount");
            
            if (otherRemainingPartyAccountNode != null)
            {
                if (otherRemainingPartyAccountNode.Attributes["href"] != null || otherRemainingPartyAccountNode.Attributes["id"] != null) 
                {
                    if (otherRemainingPartyAccountNode.Attributes["id"] != null) 
                    {
                        otherRemainingPartyAccountIDRef_ = otherRemainingPartyAccountNode.Attributes["id"].Value;
                        AccountReference ob = new AccountReference(otherRemainingPartyAccountNode);
                        IDManager.SetID(otherRemainingPartyAccountIDRef_, ob);
                    }
                    else if (otherRemainingPartyAccountNode.Attributes["href"] != null)
                    {
                        otherRemainingPartyAccountIDRef_ = otherRemainingPartyAccountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        otherRemainingPartyAccount_ = new AccountReference(otherRemainingPartyAccountNode);
                    }
                }
                else
                {
                    otherRemainingPartyAccount_ = new AccountReference(otherRemainingPartyAccountNode);
                }
            }
            
        
            XmlNode novationDateNode = xmlNode.SelectSingleNode("novationDate");
            
            if (novationDateNode != null)
            {
                if (novationDateNode.Attributes["href"] != null || novationDateNode.Attributes["id"] != null) 
                {
                    if (novationDateNode.Attributes["id"] != null) 
                    {
                        novationDateIDRef_ = novationDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(novationDateNode);
                        IDManager.SetID(novationDateIDRef_, ob);
                    }
                    else if (novationDateNode.Attributes["href"] != null)
                    {
                        novationDateIDRef_ = novationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        novationDate_ = new XsdTypeDate(novationDateNode);
                    }
                }
                else
                {
                    novationDate_ = new XsdTypeDate(novationDateNode);
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
            
        
            XmlNode novationTradeDateNode = xmlNode.SelectSingleNode("novationTradeDate");
            
            if (novationTradeDateNode != null)
            {
                if (novationTradeDateNode.Attributes["href"] != null || novationTradeDateNode.Attributes["id"] != null) 
                {
                    if (novationTradeDateNode.Attributes["id"] != null) 
                    {
                        novationTradeDateIDRef_ = novationTradeDateNode.Attributes["id"].Value;
                        XsdTypeDate ob = new XsdTypeDate(novationTradeDateNode);
                        IDManager.SetID(novationTradeDateIDRef_, ob);
                    }
                    else if (novationTradeDateNode.Attributes["href"] != null)
                    {
                        novationTradeDateIDRef_ = novationTradeDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        novationTradeDate_ = new XsdTypeDate(novationTradeDateNode);
                    }
                }
                else
                {
                    novationTradeDate_ = new XsdTypeDate(novationTradeDateNode);
                }
            }
            
        
            XmlNodeList novatedAmountNodeList = xmlNode.SelectNodes("novatedAmount");
            
            if (novatedAmountNodeList != null)
            {
                this.novatedAmount_ = new List<Money>();
                foreach (XmlNode item in novatedAmountNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            novatedAmountIDRef_ = item.Attributes["id"].Value;
                            novatedAmount_.Add(new Money(item));
                            IDManager.SetID(novatedAmountIDRef_, novatedAmount_[novatedAmount_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            novatedAmountIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        novatedAmount_.Add(new Money(item));
                        }
                    }
                    else
                    {
                        novatedAmount_.Add(new Money(item));
                    }
                }
            }
            
        
            XmlNodeList remainingAmountNodeList = xmlNode.SelectNodes("remainingAmount");
            
            if (remainingAmountNodeList != null)
            {
                this.remainingAmount_ = new List<Money>();
                foreach (XmlNode item in remainingAmountNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            remainingAmountIDRef_ = item.Attributes["id"].Value;
                            remainingAmount_.Add(new Money(item));
                            IDManager.SetID(remainingAmountIDRef_, remainingAmount_[remainingAmount_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            remainingAmountIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        remainingAmount_.Add(new Money(item));
                        }
                    }
                    else
                    {
                        remainingAmount_.Add(new Money(item));
                    }
                }
            }
            
        
            XmlNode novatedNumberOfOptionsNode = xmlNode.SelectSingleNode("novatedNumberOfOptions");
            
            if (novatedNumberOfOptionsNode != null)
            {
                if (novatedNumberOfOptionsNode.Attributes["href"] != null || novatedNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (novatedNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        novatedNumberOfOptionsIDRef_ = novatedNumberOfOptionsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(novatedNumberOfOptionsNode);
                        IDManager.SetID(novatedNumberOfOptionsIDRef_, ob);
                    }
                    else if (novatedNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        novatedNumberOfOptionsIDRef_ = novatedNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        novatedNumberOfOptions_ = new XsdTypeDecimal(novatedNumberOfOptionsNode);
                    }
                }
                else
                {
                    novatedNumberOfOptions_ = new XsdTypeDecimal(novatedNumberOfOptionsNode);
                }
            }
            
        
            XmlNode remainingNumberOfOptionsNode = xmlNode.SelectSingleNode("remainingNumberOfOptions");
            
            if (remainingNumberOfOptionsNode != null)
            {
                if (remainingNumberOfOptionsNode.Attributes["href"] != null || remainingNumberOfOptionsNode.Attributes["id"] != null) 
                {
                    if (remainingNumberOfOptionsNode.Attributes["id"] != null) 
                    {
                        remainingNumberOfOptionsIDRef_ = remainingNumberOfOptionsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(remainingNumberOfOptionsNode);
                        IDManager.SetID(remainingNumberOfOptionsIDRef_, ob);
                    }
                    else if (remainingNumberOfOptionsNode.Attributes["href"] != null)
                    {
                        remainingNumberOfOptionsIDRef_ = remainingNumberOfOptionsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        remainingNumberOfOptions_ = new XsdTypeDecimal(remainingNumberOfOptionsNode);
                    }
                }
                else
                {
                    remainingNumberOfOptions_ = new XsdTypeDecimal(remainingNumberOfOptionsNode);
                }
            }
            
        
            XmlNode novatedNumberOfUnitsNode = xmlNode.SelectSingleNode("novatedNumberOfUnits");
            
            if (novatedNumberOfUnitsNode != null)
            {
                if (novatedNumberOfUnitsNode.Attributes["href"] != null || novatedNumberOfUnitsNode.Attributes["id"] != null) 
                {
                    if (novatedNumberOfUnitsNode.Attributes["id"] != null) 
                    {
                        novatedNumberOfUnitsIDRef_ = novatedNumberOfUnitsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(novatedNumberOfUnitsNode);
                        IDManager.SetID(novatedNumberOfUnitsIDRef_, ob);
                    }
                    else if (novatedNumberOfUnitsNode.Attributes["href"] != null)
                    {
                        novatedNumberOfUnitsIDRef_ = novatedNumberOfUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        novatedNumberOfUnits_ = new XsdTypeDecimal(novatedNumberOfUnitsNode);
                    }
                }
                else
                {
                    novatedNumberOfUnits_ = new XsdTypeDecimal(novatedNumberOfUnitsNode);
                }
            }
            
        
            XmlNode remainingNumberOfUnitsNode = xmlNode.SelectSingleNode("remainingNumberOfUnits");
            
            if (remainingNumberOfUnitsNode != null)
            {
                if (remainingNumberOfUnitsNode.Attributes["href"] != null || remainingNumberOfUnitsNode.Attributes["id"] != null) 
                {
                    if (remainingNumberOfUnitsNode.Attributes["id"] != null) 
                    {
                        remainingNumberOfUnitsIDRef_ = remainingNumberOfUnitsNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(remainingNumberOfUnitsNode);
                        IDManager.SetID(remainingNumberOfUnitsIDRef_, ob);
                    }
                    else if (remainingNumberOfUnitsNode.Attributes["href"] != null)
                    {
                        remainingNumberOfUnitsIDRef_ = remainingNumberOfUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        remainingNumberOfUnits_ = new XsdTypeDecimal(remainingNumberOfUnitsNode);
                    }
                }
                else
                {
                    remainingNumberOfUnits_ = new XsdTypeDecimal(remainingNumberOfUnitsNode);
                }
            }
            
        
            XmlNode fullFirstCalculationPeriodNode = xmlNode.SelectSingleNode("fullFirstCalculationPeriod");
            
            if (fullFirstCalculationPeriodNode != null)
            {
                if (fullFirstCalculationPeriodNode.Attributes["href"] != null || fullFirstCalculationPeriodNode.Attributes["id"] != null) 
                {
                    if (fullFirstCalculationPeriodNode.Attributes["id"] != null) 
                    {
                        fullFirstCalculationPeriodIDRef_ = fullFirstCalculationPeriodNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(fullFirstCalculationPeriodNode);
                        IDManager.SetID(fullFirstCalculationPeriodIDRef_, ob);
                    }
                    else if (fullFirstCalculationPeriodNode.Attributes["href"] != null)
                    {
                        fullFirstCalculationPeriodIDRef_ = fullFirstCalculationPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fullFirstCalculationPeriod_ = new XsdTypeBoolean(fullFirstCalculationPeriodNode);
                    }
                }
                else
                {
                    fullFirstCalculationPeriod_ = new XsdTypeBoolean(fullFirstCalculationPeriodNode);
                }
            }
            
        
            XmlNodeList firstPeriodStartDateNodeList = xmlNode.SelectNodes("firstPeriodStartDate");
            
            if (firstPeriodStartDateNodeList != null)
            {
                this.firstPeriodStartDate_ = new List<FirstPeriodStartDate>();
                foreach (XmlNode item in firstPeriodStartDateNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            firstPeriodStartDateIDRef_ = item.Attributes["id"].Value;
                            firstPeriodStartDate_.Add(new FirstPeriodStartDate(item));
                            IDManager.SetID(firstPeriodStartDateIDRef_, firstPeriodStartDate_[firstPeriodStartDate_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            firstPeriodStartDateIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        firstPeriodStartDate_.Add(new FirstPeriodStartDate(item));
                        }
                    }
                    else
                    {
                        firstPeriodStartDate_.Add(new FirstPeriodStartDate(item));
                    }
                }
            }
            
        
            XmlNode nonRelianceNode = xmlNode.SelectSingleNode("nonReliance");
            
            if (nonRelianceNode != null)
            {
                if (nonRelianceNode.Attributes["href"] != null || nonRelianceNode.Attributes["id"] != null) 
                {
                    if (nonRelianceNode.Attributes["id"] != null) 
                    {
                        nonRelianceIDRef_ = nonRelianceNode.Attributes["id"].Value;
                        Empty ob = new Empty(nonRelianceNode);
                        IDManager.SetID(nonRelianceIDRef_, ob);
                    }
                    else if (nonRelianceNode.Attributes["href"] != null)
                    {
                        nonRelianceIDRef_ = nonRelianceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonReliance_ = new Empty(nonRelianceNode);
                    }
                }
                else
                {
                    nonReliance_ = new Empty(nonRelianceNode);
                }
            }
            
        
            XmlNode creditDerivativesNoticesNode = xmlNode.SelectSingleNode("creditDerivativesNotices");
            
            if (creditDerivativesNoticesNode != null)
            {
                if (creditDerivativesNoticesNode.Attributes["href"] != null || creditDerivativesNoticesNode.Attributes["id"] != null) 
                {
                    if (creditDerivativesNoticesNode.Attributes["id"] != null) 
                    {
                        creditDerivativesNoticesIDRef_ = creditDerivativesNoticesNode.Attributes["id"].Value;
                        CreditDerivativesNotices ob = new CreditDerivativesNotices(creditDerivativesNoticesNode);
                        IDManager.SetID(creditDerivativesNoticesIDRef_, ob);
                    }
                    else if (creditDerivativesNoticesNode.Attributes["href"] != null)
                    {
                        creditDerivativesNoticesIDRef_ = creditDerivativesNoticesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        creditDerivativesNotices_ = new CreditDerivativesNotices(creditDerivativesNoticesNode);
                    }
                }
                else
                {
                    creditDerivativesNotices_ = new CreditDerivativesNotices(creditDerivativesNoticesNode);
                }
            }
            
        
            XmlNodeList contractualDefinitionsNodeList = xmlNode.SelectNodes("contractualDefinitions");
            
            if (contractualDefinitionsNodeList != null)
            {
                this.contractualDefinitions_ = new List<ContractualDefinitions>();
                foreach (XmlNode item in contractualDefinitionsNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            contractualDefinitionsIDRef_ = item.Attributes["id"].Value;
                            contractualDefinitions_.Add(new ContractualDefinitions(item));
                            IDManager.SetID(contractualDefinitionsIDRef_, contractualDefinitions_[contractualDefinitions_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            contractualDefinitionsIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        contractualDefinitions_.Add(new ContractualDefinitions(item));
                        }
                    }
                    else
                    {
                        contractualDefinitions_.Add(new ContractualDefinitions(item));
                    }
                }
            }
            
        
            XmlNodeList contractualTermsSupplementNodeList = xmlNode.SelectNodes("contractualTermsSupplement");
            
            if (contractualTermsSupplementNodeList != null)
            {
                this.contractualTermsSupplement_ = new List<ContractualTermsSupplement>();
                foreach (XmlNode item in contractualTermsSupplementNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            contractualTermsSupplementIDRef_ = item.Attributes["id"].Value;
                            contractualTermsSupplement_.Add(new ContractualTermsSupplement(item));
                            IDManager.SetID(contractualTermsSupplementIDRef_, contractualTermsSupplement_[contractualTermsSupplement_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            contractualTermsSupplementIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        contractualTermsSupplement_.Add(new ContractualTermsSupplement(item));
                        }
                    }
                    else
                    {
                        contractualTermsSupplement_.Add(new ContractualTermsSupplement(item));
                    }
                }
            }
            
        
            XmlNode paymentNode = xmlNode.SelectSingleNode("payment");
            
            if (paymentNode != null)
            {
                if (paymentNode.Attributes["href"] != null || paymentNode.Attributes["id"] != null) 
                {
                    if (paymentNode.Attributes["id"] != null) 
                    {
                        paymentIDRef_ = paymentNode.Attributes["id"].Value;
                        Payment ob = new Payment(paymentNode);
                        IDManager.SetID(paymentIDRef_, ob);
                    }
                    else if (paymentNode.Attributes["href"] != null)
                    {
                        paymentIDRef_ = paymentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        payment_ = new Payment(paymentNode);
                    }
                }
                else
                {
                    payment_ = new Payment(paymentNode);
                }
            }
            
        
        }
        
    
        #region NewTradeIdentifier_
        private List<PartyTradeIdentifier> newTradeIdentifier_;
        public List<PartyTradeIdentifier> NewTradeIdentifier_
        {
            get
            {
                if (this.newTradeIdentifier_ != null)
                {
                    return this.newTradeIdentifier_; 
                }
                else if (this.newTradeIdentifierIDRef_ != null)
                {
                    return this.newTradeIdentifier_; 
                }
                else
                {
                      return this.newTradeIdentifier_; 
                }
            }
            set
            {
                if (this.newTradeIdentifier_ != value)
                {
                    this.newTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string newTradeIdentifierIDRef_ { get; set; }
        #region NewTrade_
        private Trade newTrade_;
        public Trade NewTrade_
        {
            get
            {
                if (this.newTrade_ != null)
                {
                    return this.newTrade_; 
                }
                else if (this.newTradeIDRef_ != null)
                {
                    newTrade_ = IDManager.getID(newTradeIDRef_) as Trade;
                    return this.newTrade_; 
                }
                else
                {
                      return this.newTrade_; 
                }
            }
            set
            {
                if (this.newTrade_ != value)
                {
                    this.newTrade_ = value;
                }
            }
        }
        #endregion
        
        public string newTradeIDRef_ { get; set; }
        #region OldTradeIdentifier_
        private List<PartyTradeIdentifier> oldTradeIdentifier_;
        public List<PartyTradeIdentifier> OldTradeIdentifier_
        {
            get
            {
                if (this.oldTradeIdentifier_ != null)
                {
                    return this.oldTradeIdentifier_; 
                }
                else if (this.oldTradeIdentifierIDRef_ != null)
                {
                    return this.oldTradeIdentifier_; 
                }
                else
                {
                      return this.oldTradeIdentifier_; 
                }
            }
            set
            {
                if (this.oldTradeIdentifier_ != value)
                {
                    this.oldTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string oldTradeIdentifierIDRef_ { get; set; }
        #region OldTrade_
        private Trade oldTrade_;
        public Trade OldTrade_
        {
            get
            {
                if (this.oldTrade_ != null)
                {
                    return this.oldTrade_; 
                }
                else if (this.oldTradeIDRef_ != null)
                {
                    oldTrade_ = IDManager.getID(oldTradeIDRef_) as Trade;
                    return this.oldTrade_; 
                }
                else
                {
                      return this.oldTrade_; 
                }
            }
            set
            {
                if (this.oldTrade_ != value)
                {
                    this.oldTrade_ = value;
                }
            }
        }
        #endregion
        
        public string oldTradeIDRef_ { get; set; }
        #region FeeTradeIdentifier_
        private PartyTradeIdentifier feeTradeIdentifier_;
        public PartyTradeIdentifier FeeTradeIdentifier_
        {
            get
            {
                if (this.feeTradeIdentifier_ != null)
                {
                    return this.feeTradeIdentifier_; 
                }
                else if (this.feeTradeIdentifierIDRef_ != null)
                {
                    feeTradeIdentifier_ = IDManager.getID(feeTradeIdentifierIDRef_) as PartyTradeIdentifier;
                    return this.feeTradeIdentifier_; 
                }
                else
                {
                      return this.feeTradeIdentifier_; 
                }
            }
            set
            {
                if (this.feeTradeIdentifier_ != value)
                {
                    this.feeTradeIdentifier_ = value;
                }
            }
        }
        #endregion
        
        public string feeTradeIdentifierIDRef_ { get; set; }
        #region FeeTrade_
        private Trade feeTrade_;
        public Trade FeeTrade_
        {
            get
            {
                if (this.feeTrade_ != null)
                {
                    return this.feeTrade_; 
                }
                else if (this.feeTradeIDRef_ != null)
                {
                    feeTrade_ = IDManager.getID(feeTradeIDRef_) as Trade;
                    return this.feeTrade_; 
                }
                else
                {
                      return this.feeTrade_; 
                }
            }
            set
            {
                if (this.feeTrade_ != value)
                {
                    this.feeTrade_ = value;
                }
            }
        }
        #endregion
        
        public string feeTradeIDRef_ { get; set; }
        #region Transferor_
        private PartyReference transferor_;
        public PartyReference Transferor_
        {
            get
            {
                if (this.transferor_ != null)
                {
                    return this.transferor_; 
                }
                else if (this.transferorIDRef_ != null)
                {
                    transferor_ = IDManager.getID(transferorIDRef_) as PartyReference;
                    return this.transferor_; 
                }
                else
                {
                      return this.transferor_; 
                }
            }
            set
            {
                if (this.transferor_ != value)
                {
                    this.transferor_ = value;
                }
            }
        }
        #endregion
        
        public string transferorIDRef_ { get; set; }
        #region TransferorAccount_
        private AccountReference transferorAccount_;
        public AccountReference TransferorAccount_
        {
            get
            {
                if (this.transferorAccount_ != null)
                {
                    return this.transferorAccount_; 
                }
                else if (this.transferorAccountIDRef_ != null)
                {
                    transferorAccount_ = IDManager.getID(transferorAccountIDRef_) as AccountReference;
                    return this.transferorAccount_; 
                }
                else
                {
                      return this.transferorAccount_; 
                }
            }
            set
            {
                if (this.transferorAccount_ != value)
                {
                    this.transferorAccount_ = value;
                }
            }
        }
        #endregion
        
        public string transferorAccountIDRef_ { get; set; }
        #region Transferee_
        private PartyReference transferee_;
        public PartyReference Transferee_
        {
            get
            {
                if (this.transferee_ != null)
                {
                    return this.transferee_; 
                }
                else if (this.transfereeIDRef_ != null)
                {
                    transferee_ = IDManager.getID(transfereeIDRef_) as PartyReference;
                    return this.transferee_; 
                }
                else
                {
                      return this.transferee_; 
                }
            }
            set
            {
                if (this.transferee_ != value)
                {
                    this.transferee_ = value;
                }
            }
        }
        #endregion
        
        public string transfereeIDRef_ { get; set; }
        #region OtherTransferee_
        private PartyReference otherTransferee_;
        public PartyReference OtherTransferee_
        {
            get
            {
                if (this.otherTransferee_ != null)
                {
                    return this.otherTransferee_; 
                }
                else if (this.otherTransfereeIDRef_ != null)
                {
                    otherTransferee_ = IDManager.getID(otherTransfereeIDRef_) as PartyReference;
                    return this.otherTransferee_; 
                }
                else
                {
                      return this.otherTransferee_; 
                }
            }
            set
            {
                if (this.otherTransferee_ != value)
                {
                    this.otherTransferee_ = value;
                }
            }
        }
        #endregion
        
        public string otherTransfereeIDRef_ { get; set; }
        #region TransfereeAccount_
        private AccountReference transfereeAccount_;
        public AccountReference TransfereeAccount_
        {
            get
            {
                if (this.transfereeAccount_ != null)
                {
                    return this.transfereeAccount_; 
                }
                else if (this.transfereeAccountIDRef_ != null)
                {
                    transfereeAccount_ = IDManager.getID(transfereeAccountIDRef_) as AccountReference;
                    return this.transfereeAccount_; 
                }
                else
                {
                      return this.transfereeAccount_; 
                }
            }
            set
            {
                if (this.transfereeAccount_ != value)
                {
                    this.transfereeAccount_ = value;
                }
            }
        }
        #endregion
        
        public string transfereeAccountIDRef_ { get; set; }
        #region OtherTransfereeAccount_
        private AccountReference otherTransfereeAccount_;
        public AccountReference OtherTransfereeAccount_
        {
            get
            {
                if (this.otherTransfereeAccount_ != null)
                {
                    return this.otherTransfereeAccount_; 
                }
                else if (this.otherTransfereeAccountIDRef_ != null)
                {
                    otherTransfereeAccount_ = IDManager.getID(otherTransfereeAccountIDRef_) as AccountReference;
                    return this.otherTransfereeAccount_; 
                }
                else
                {
                      return this.otherTransfereeAccount_; 
                }
            }
            set
            {
                if (this.otherTransfereeAccount_ != value)
                {
                    this.otherTransfereeAccount_ = value;
                }
            }
        }
        #endregion
        
        public string otherTransfereeAccountIDRef_ { get; set; }
        #region RemainingParty_
        private PartyReference remainingParty_;
        public PartyReference RemainingParty_
        {
            get
            {
                if (this.remainingParty_ != null)
                {
                    return this.remainingParty_; 
                }
                else if (this.remainingPartyIDRef_ != null)
                {
                    remainingParty_ = IDManager.getID(remainingPartyIDRef_) as PartyReference;
                    return this.remainingParty_; 
                }
                else
                {
                      return this.remainingParty_; 
                }
            }
            set
            {
                if (this.remainingParty_ != value)
                {
                    this.remainingParty_ = value;
                }
            }
        }
        #endregion
        
        public string remainingPartyIDRef_ { get; set; }
        #region RemainingPartyAccount_
        private AccountReference remainingPartyAccount_;
        public AccountReference RemainingPartyAccount_
        {
            get
            {
                if (this.remainingPartyAccount_ != null)
                {
                    return this.remainingPartyAccount_; 
                }
                else if (this.remainingPartyAccountIDRef_ != null)
                {
                    remainingPartyAccount_ = IDManager.getID(remainingPartyAccountIDRef_) as AccountReference;
                    return this.remainingPartyAccount_; 
                }
                else
                {
                      return this.remainingPartyAccount_; 
                }
            }
            set
            {
                if (this.remainingPartyAccount_ != value)
                {
                    this.remainingPartyAccount_ = value;
                }
            }
        }
        #endregion
        
        public string remainingPartyAccountIDRef_ { get; set; }
        #region OtherRemainingParty_
        private PartyReference otherRemainingParty_;
        public PartyReference OtherRemainingParty_
        {
            get
            {
                if (this.otherRemainingParty_ != null)
                {
                    return this.otherRemainingParty_; 
                }
                else if (this.otherRemainingPartyIDRef_ != null)
                {
                    otherRemainingParty_ = IDManager.getID(otherRemainingPartyIDRef_) as PartyReference;
                    return this.otherRemainingParty_; 
                }
                else
                {
                      return this.otherRemainingParty_; 
                }
            }
            set
            {
                if (this.otherRemainingParty_ != value)
                {
                    this.otherRemainingParty_ = value;
                }
            }
        }
        #endregion
        
        public string otherRemainingPartyIDRef_ { get; set; }
        #region OtherRemainingPartyAccount_
        private AccountReference otherRemainingPartyAccount_;
        public AccountReference OtherRemainingPartyAccount_
        {
            get
            {
                if (this.otherRemainingPartyAccount_ != null)
                {
                    return this.otherRemainingPartyAccount_; 
                }
                else if (this.otherRemainingPartyAccountIDRef_ != null)
                {
                    otherRemainingPartyAccount_ = IDManager.getID(otherRemainingPartyAccountIDRef_) as AccountReference;
                    return this.otherRemainingPartyAccount_; 
                }
                else
                {
                      return this.otherRemainingPartyAccount_; 
                }
            }
            set
            {
                if (this.otherRemainingPartyAccount_ != value)
                {
                    this.otherRemainingPartyAccount_ = value;
                }
            }
        }
        #endregion
        
        public string otherRemainingPartyAccountIDRef_ { get; set; }
        #region NovationDate_
        private XsdTypeDate novationDate_;
        public XsdTypeDate NovationDate_
        {
            get
            {
                if (this.novationDate_ != null)
                {
                    return this.novationDate_; 
                }
                else if (this.novationDateIDRef_ != null)
                {
                    novationDate_ = IDManager.getID(novationDateIDRef_) as XsdTypeDate;
                    return this.novationDate_; 
                }
                else
                {
                      return this.novationDate_; 
                }
            }
            set
            {
                if (this.novationDate_ != value)
                {
                    this.novationDate_ = value;
                }
            }
        }
        #endregion
        
        public string novationDateIDRef_ { get; set; }
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
        #region NovationTradeDate_
        private XsdTypeDate novationTradeDate_;
        public XsdTypeDate NovationTradeDate_
        {
            get
            {
                if (this.novationTradeDate_ != null)
                {
                    return this.novationTradeDate_; 
                }
                else if (this.novationTradeDateIDRef_ != null)
                {
                    novationTradeDate_ = IDManager.getID(novationTradeDateIDRef_) as XsdTypeDate;
                    return this.novationTradeDate_; 
                }
                else
                {
                      return this.novationTradeDate_; 
                }
            }
            set
            {
                if (this.novationTradeDate_ != value)
                {
                    this.novationTradeDate_ = value;
                }
            }
        }
        #endregion
        
        public string novationTradeDateIDRef_ { get; set; }
        #region NovatedAmount_
        private List<Money> novatedAmount_;
        public List<Money> NovatedAmount_
        {
            get
            {
                if (this.novatedAmount_ != null)
                {
                    return this.novatedAmount_; 
                }
                else if (this.novatedAmountIDRef_ != null)
                {
                    return this.novatedAmount_; 
                }
                else
                {
                      return this.novatedAmount_; 
                }
            }
            set
            {
                if (this.novatedAmount_ != value)
                {
                    this.novatedAmount_ = value;
                }
            }
        }
        #endregion
        
        public string novatedAmountIDRef_ { get; set; }
        #region RemainingAmount_
        private List<Money> remainingAmount_;
        public List<Money> RemainingAmount_
        {
            get
            {
                if (this.remainingAmount_ != null)
                {
                    return this.remainingAmount_; 
                }
                else if (this.remainingAmountIDRef_ != null)
                {
                    return this.remainingAmount_; 
                }
                else
                {
                      return this.remainingAmount_; 
                }
            }
            set
            {
                if (this.remainingAmount_ != value)
                {
                    this.remainingAmount_ = value;
                }
            }
        }
        #endregion
        
        public string remainingAmountIDRef_ { get; set; }
        #region NovatedNumberOfOptions_
        private XsdTypeDecimal novatedNumberOfOptions_;
        public XsdTypeDecimal NovatedNumberOfOptions_
        {
            get
            {
                if (this.novatedNumberOfOptions_ != null)
                {
                    return this.novatedNumberOfOptions_; 
                }
                else if (this.novatedNumberOfOptionsIDRef_ != null)
                {
                    novatedNumberOfOptions_ = IDManager.getID(novatedNumberOfOptionsIDRef_) as XsdTypeDecimal;
                    return this.novatedNumberOfOptions_; 
                }
                else
                {
                      return this.novatedNumberOfOptions_; 
                }
            }
            set
            {
                if (this.novatedNumberOfOptions_ != value)
                {
                    this.novatedNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string novatedNumberOfOptionsIDRef_ { get; set; }
        #region RemainingNumberOfOptions_
        private XsdTypeDecimal remainingNumberOfOptions_;
        public XsdTypeDecimal RemainingNumberOfOptions_
        {
            get
            {
                if (this.remainingNumberOfOptions_ != null)
                {
                    return this.remainingNumberOfOptions_; 
                }
                else if (this.remainingNumberOfOptionsIDRef_ != null)
                {
                    remainingNumberOfOptions_ = IDManager.getID(remainingNumberOfOptionsIDRef_) as XsdTypeDecimal;
                    return this.remainingNumberOfOptions_; 
                }
                else
                {
                      return this.remainingNumberOfOptions_; 
                }
            }
            set
            {
                if (this.remainingNumberOfOptions_ != value)
                {
                    this.remainingNumberOfOptions_ = value;
                }
            }
        }
        #endregion
        
        public string remainingNumberOfOptionsIDRef_ { get; set; }
        #region NovatedNumberOfUnits_
        private XsdTypeDecimal novatedNumberOfUnits_;
        public XsdTypeDecimal NovatedNumberOfUnits_
        {
            get
            {
                if (this.novatedNumberOfUnits_ != null)
                {
                    return this.novatedNumberOfUnits_; 
                }
                else if (this.novatedNumberOfUnitsIDRef_ != null)
                {
                    novatedNumberOfUnits_ = IDManager.getID(novatedNumberOfUnitsIDRef_) as XsdTypeDecimal;
                    return this.novatedNumberOfUnits_; 
                }
                else
                {
                      return this.novatedNumberOfUnits_; 
                }
            }
            set
            {
                if (this.novatedNumberOfUnits_ != value)
                {
                    this.novatedNumberOfUnits_ = value;
                }
            }
        }
        #endregion
        
        public string novatedNumberOfUnitsIDRef_ { get; set; }
        #region RemainingNumberOfUnits_
        private XsdTypeDecimal remainingNumberOfUnits_;
        public XsdTypeDecimal RemainingNumberOfUnits_
        {
            get
            {
                if (this.remainingNumberOfUnits_ != null)
                {
                    return this.remainingNumberOfUnits_; 
                }
                else if (this.remainingNumberOfUnitsIDRef_ != null)
                {
                    remainingNumberOfUnits_ = IDManager.getID(remainingNumberOfUnitsIDRef_) as XsdTypeDecimal;
                    return this.remainingNumberOfUnits_; 
                }
                else
                {
                      return this.remainingNumberOfUnits_; 
                }
            }
            set
            {
                if (this.remainingNumberOfUnits_ != value)
                {
                    this.remainingNumberOfUnits_ = value;
                }
            }
        }
        #endregion
        
        public string remainingNumberOfUnitsIDRef_ { get; set; }
        #region FullFirstCalculationPeriod_
        private XsdTypeBoolean fullFirstCalculationPeriod_;
        public XsdTypeBoolean FullFirstCalculationPeriod_
        {
            get
            {
                if (this.fullFirstCalculationPeriod_ != null)
                {
                    return this.fullFirstCalculationPeriod_; 
                }
                else if (this.fullFirstCalculationPeriodIDRef_ != null)
                {
                    fullFirstCalculationPeriod_ = IDManager.getID(fullFirstCalculationPeriodIDRef_) as XsdTypeBoolean;
                    return this.fullFirstCalculationPeriod_; 
                }
                else
                {
                      return this.fullFirstCalculationPeriod_; 
                }
            }
            set
            {
                if (this.fullFirstCalculationPeriod_ != value)
                {
                    this.fullFirstCalculationPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string fullFirstCalculationPeriodIDRef_ { get; set; }
        #region FirstPeriodStartDate_
        private List<FirstPeriodStartDate> firstPeriodStartDate_;
        public List<FirstPeriodStartDate> FirstPeriodStartDate_
        {
            get
            {
                if (this.firstPeriodStartDate_ != null)
                {
                    return this.firstPeriodStartDate_; 
                }
                else if (this.firstPeriodStartDateIDRef_ != null)
                {
                    return this.firstPeriodStartDate_; 
                }
                else
                {
                      return this.firstPeriodStartDate_; 
                }
            }
            set
            {
                if (this.firstPeriodStartDate_ != value)
                {
                    this.firstPeriodStartDate_ = value;
                }
            }
        }
        #endregion
        
        public string firstPeriodStartDateIDRef_ { get; set; }
        #region NonReliance_
        private Empty nonReliance_;
        public Empty NonReliance_
        {
            get
            {
                if (this.nonReliance_ != null)
                {
                    return this.nonReliance_; 
                }
                else if (this.nonRelianceIDRef_ != null)
                {
                    nonReliance_ = IDManager.getID(nonRelianceIDRef_) as Empty;
                    return this.nonReliance_; 
                }
                else
                {
                      return this.nonReliance_; 
                }
            }
            set
            {
                if (this.nonReliance_ != value)
                {
                    this.nonReliance_ = value;
                }
            }
        }
        #endregion
        
        public string nonRelianceIDRef_ { get; set; }
        #region CreditDerivativesNotices_
        private CreditDerivativesNotices creditDerivativesNotices_;
        public CreditDerivativesNotices CreditDerivativesNotices_
        {
            get
            {
                if (this.creditDerivativesNotices_ != null)
                {
                    return this.creditDerivativesNotices_; 
                }
                else if (this.creditDerivativesNoticesIDRef_ != null)
                {
                    creditDerivativesNotices_ = IDManager.getID(creditDerivativesNoticesIDRef_) as CreditDerivativesNotices;
                    return this.creditDerivativesNotices_; 
                }
                else
                {
                      return this.creditDerivativesNotices_; 
                }
            }
            set
            {
                if (this.creditDerivativesNotices_ != value)
                {
                    this.creditDerivativesNotices_ = value;
                }
            }
        }
        #endregion
        
        public string creditDerivativesNoticesIDRef_ { get; set; }
        #region ContractualDefinitions_
        private List<ContractualDefinitions> contractualDefinitions_;
        public List<ContractualDefinitions> ContractualDefinitions_
        {
            get
            {
                if (this.contractualDefinitions_ != null)
                {
                    return this.contractualDefinitions_; 
                }
                else if (this.contractualDefinitionsIDRef_ != null)
                {
                    return this.contractualDefinitions_; 
                }
                else
                {
                      return this.contractualDefinitions_; 
                }
            }
            set
            {
                if (this.contractualDefinitions_ != value)
                {
                    this.contractualDefinitions_ = value;
                }
            }
        }
        #endregion
        
        public string contractualDefinitionsIDRef_ { get; set; }
        #region ContractualTermsSupplement_
        private List<ContractualTermsSupplement> contractualTermsSupplement_;
        public List<ContractualTermsSupplement> ContractualTermsSupplement_
        {
            get
            {
                if (this.contractualTermsSupplement_ != null)
                {
                    return this.contractualTermsSupplement_; 
                }
                else if (this.contractualTermsSupplementIDRef_ != null)
                {
                    return this.contractualTermsSupplement_; 
                }
                else
                {
                      return this.contractualTermsSupplement_; 
                }
            }
            set
            {
                if (this.contractualTermsSupplement_ != value)
                {
                    this.contractualTermsSupplement_ = value;
                }
            }
        }
        #endregion
        
        public string contractualTermsSupplementIDRef_ { get; set; }
        #region Payment_
        private Payment payment_;
        public Payment Payment_
        {
            get
            {
                if (this.payment_ != null)
                {
                    return this.payment_; 
                }
                else if (this.paymentIDRef_ != null)
                {
                    payment_ = IDManager.getID(paymentIDRef_) as Payment;
                    return this.payment_; 
                }
                else
                {
                      return this.payment_; 
                }
            }
            set
            {
                if (this.payment_ != value)
                {
                    this.payment_ = value;
                }
            }
        }
        #endregion
        
        public string paymentIDRef_ { get; set; }
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

