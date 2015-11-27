using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CashSettlementTerms
    {
        public CashSettlementTerms(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList valuationDateNodeList = xmlNode.SelectNodes("valuationDate");
            if (valuationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationDateIDRef = item.Attributes["id"].Name;
                        ValuationDate ob = ValuationDate();
                        IDManager.SetID(valuationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationDate = new ValuationDate(item);
                    }
                }
            }
            
        
            XmlNodeList valuationTimeNodeList = xmlNode.SelectNodes("valuationTime");
            if (valuationTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(valuationTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
            XmlNodeList quotationMethodNodeList = xmlNode.SelectNodes("quotationMethod");
            if (quotationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quotationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quotationMethodIDRef = item.Attributes["id"].Name;
                        QuotationRateTypeEnum ob = QuotationRateTypeEnum();
                        IDManager.SetID(quotationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quotationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quotationMethod = new QuotationRateTypeEnum(item);
                    }
                }
            }
            
        
            XmlNodeList quotationAmountNodeList = xmlNode.SelectNodes("quotationAmount");
            if (quotationAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in quotationAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        quotationAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(quotationAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        quotationAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        quotationAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList minimumQuotationAmountNodeList = xmlNode.SelectNodes("minimumQuotationAmount");
            if (minimumQuotationAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in minimumQuotationAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        minimumQuotationAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(minimumQuotationAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        minimumQuotationAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        minimumQuotationAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList dealerNodeList = xmlNode.SelectNodes("dealer");
            
            foreach (XmlNode item in dealerNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dealerIDRef = item.Attributes["id"].Name;
                        XsdTypeString ob = new XsdTypeString();
                        ob.Add(new XsdTypeString(item));
                        IDManager.SetID(dealerIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dealerIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    dealer.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
            XmlNodeList cashSettlementBusinessDaysNodeList = xmlNode.SelectNodes("cashSettlementBusinessDays");
            if (cashSettlementBusinessDaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementBusinessDaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementBusinessDaysIDRef = item.Attributes["id"].Name;
                        XsdTypeNonNegativeInteger ob = XsdTypeNonNegativeInteger();
                        IDManager.SetID(cashSettlementBusinessDaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementBusinessDaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlementBusinessDays = new XsdTypeNonNegativeInteger(item);
                    }
                }
            }
            
        
            XmlNodeList cashSettlementAmountNodeList = xmlNode.SelectNodes("cashSettlementAmount");
            if (cashSettlementAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementAmountIDRef = item.Attributes["id"].Name;
                        Money ob = Money();
                        IDManager.SetID(cashSettlementAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlementAmount = new Money(item);
                    }
                }
            }
            
        
            XmlNodeList recoveryFactorNodeList = xmlNode.SelectNodes("recoveryFactor");
            if (recoveryFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in recoveryFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        recoveryFactorIDRef = item.Attributes["id"].Name;
                        RestrictedPercentage ob = RestrictedPercentage();
                        IDManager.SetID(recoveryFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        recoveryFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        recoveryFactor = new RestrictedPercentage(item);
                    }
                }
            }
            
        
            XmlNodeList fixedSettlementNodeList = xmlNode.SelectNodes("fixedSettlement");
            if (fixedSettlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedSettlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedSettlementIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(fixedSettlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedSettlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedSettlement = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList accruedInterestNodeList = xmlNode.SelectNodes("accruedInterest");
            if (accruedInterestNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in accruedInterestNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        accruedInterestIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(accruedInterestIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        accruedInterestIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        accruedInterest = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList valuationMethodNodeList = xmlNode.SelectNodes("valuationMethod");
            if (valuationMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in valuationMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        valuationMethodIDRef = item.Attributes["id"].Name;
                        ValuationMethodEnum ob = ValuationMethodEnum();
                        IDManager.SetID(valuationMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        valuationMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        valuationMethod = new ValuationMethodEnum(item);
                    }
                }
            }
            
        
        }
        
    
        #region ValuationDate
        private ValuationDate valuationDate;
        public ValuationDate ValuationDate
        {
            get
            {
                if (this.valuationDate != null)
                {
                    return this.valuationDate; 
                }
                else if (this.valuationDateIDRef != null)
                {
                    valuationDate = IDManager.getID(valuationDateIDRef) as ValuationDate;
                    return this.valuationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationDate != value)
                {
                    this.valuationDate = value;
                }
            }
        }
        #endregion
        
        public string ValuationDateIDRef { get; set; }
        #region ValuationTime
        private BusinessCenterTime valuationTime;
        public BusinessCenterTime ValuationTime
        {
            get
            {
                if (this.valuationTime != null)
                {
                    return this.valuationTime; 
                }
                else if (this.valuationTimeIDRef != null)
                {
                    valuationTime = IDManager.getID(valuationTimeIDRef) as BusinessCenterTime;
                    return this.valuationTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationTime != value)
                {
                    this.valuationTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
        #region QuotationMethod
        private QuotationRateTypeEnum quotationMethod;
        public QuotationRateTypeEnum QuotationMethod
        {
            get
            {
                if (this.quotationMethod != null)
                {
                    return this.quotationMethod; 
                }
                else if (this.quotationMethodIDRef != null)
                {
                    quotationMethod = IDManager.getID(quotationMethodIDRef) as QuotationRateTypeEnum;
                    return this.quotationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quotationMethod != value)
                {
                    this.quotationMethod = value;
                }
            }
        }
        #endregion
        
        public string QuotationRateTypeEnumIDRef { get; set; }
        #region QuotationAmount
        private Money quotationAmount;
        public Money QuotationAmount
        {
            get
            {
                if (this.quotationAmount != null)
                {
                    return this.quotationAmount; 
                }
                else if (this.quotationAmountIDRef != null)
                {
                    quotationAmount = IDManager.getID(quotationAmountIDRef) as Money;
                    return this.quotationAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.quotationAmount != value)
                {
                    this.quotationAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region MinimumQuotationAmount
        private Money minimumQuotationAmount;
        public Money MinimumQuotationAmount
        {
            get
            {
                if (this.minimumQuotationAmount != null)
                {
                    return this.minimumQuotationAmount; 
                }
                else if (this.minimumQuotationAmountIDRef != null)
                {
                    minimumQuotationAmount = IDManager.getID(minimumQuotationAmountIDRef) as Money;
                    return this.minimumQuotationAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.minimumQuotationAmount != value)
                {
                    this.minimumQuotationAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region Dealer
        private XsdTypeString dealer;
        public XsdTypeString Dealer
        {
            get
            {
                if (this.dealer != null)
                {
                    return this.dealer; 
                }
                else if (this.dealerIDRef != null)
                {
                    dealer = IDManager.getID(dealerIDRef) as XsdTypeString;
                    return this.dealer; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dealer != value)
                {
                    this.dealer = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeStringIDRef { get; set; }
        #region CashSettlementBusinessDays
        private XsdTypeNonNegativeInteger cashSettlementBusinessDays;
        public XsdTypeNonNegativeInteger CashSettlementBusinessDays
        {
            get
            {
                if (this.cashSettlementBusinessDays != null)
                {
                    return this.cashSettlementBusinessDays; 
                }
                else if (this.cashSettlementBusinessDaysIDRef != null)
                {
                    cashSettlementBusinessDays = IDManager.getID(cashSettlementBusinessDaysIDRef) as XsdTypeNonNegativeInteger;
                    return this.cashSettlementBusinessDays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlementBusinessDays != value)
                {
                    this.cashSettlementBusinessDays = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeNonNegativeIntegerIDRef { get; set; }
        #region CashSettlementAmount
        private Money cashSettlementAmount;
        public Money CashSettlementAmount
        {
            get
            {
                if (this.cashSettlementAmount != null)
                {
                    return this.cashSettlementAmount; 
                }
                else if (this.cashSettlementAmountIDRef != null)
                {
                    cashSettlementAmount = IDManager.getID(cashSettlementAmountIDRef) as Money;
                    return this.cashSettlementAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlementAmount != value)
                {
                    this.cashSettlementAmount = value;
                }
            }
        }
        #endregion
        
        public string MoneyIDRef { get; set; }
        #region RecoveryFactor
        private RestrictedPercentage recoveryFactor;
        public RestrictedPercentage RecoveryFactor
        {
            get
            {
                if (this.recoveryFactor != null)
                {
                    return this.recoveryFactor; 
                }
                else if (this.recoveryFactorIDRef != null)
                {
                    recoveryFactor = IDManager.getID(recoveryFactorIDRef) as RestrictedPercentage;
                    return this.recoveryFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.recoveryFactor != value)
                {
                    this.recoveryFactor = value;
                }
            }
        }
        #endregion
        
        public string RestrictedPercentageIDRef { get; set; }
        #region FixedSettlement
        private XsdTypeBoolean fixedSettlement;
        public XsdTypeBoolean FixedSettlement
        {
            get
            {
                if (this.fixedSettlement != null)
                {
                    return this.fixedSettlement; 
                }
                else if (this.fixedSettlementIDRef != null)
                {
                    fixedSettlement = IDManager.getID(fixedSettlementIDRef) as XsdTypeBoolean;
                    return this.fixedSettlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedSettlement != value)
                {
                    this.fixedSettlement = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region AccruedInterest
        private XsdTypeBoolean accruedInterest;
        public XsdTypeBoolean AccruedInterest
        {
            get
            {
                if (this.accruedInterest != null)
                {
                    return this.accruedInterest; 
                }
                else if (this.accruedInterestIDRef != null)
                {
                    accruedInterest = IDManager.getID(accruedInterestIDRef) as XsdTypeBoolean;
                    return this.accruedInterest; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.accruedInterest != value)
                {
                    this.accruedInterest = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region ValuationMethod
        private ValuationMethodEnum valuationMethod;
        public ValuationMethodEnum ValuationMethod
        {
            get
            {
                if (this.valuationMethod != null)
                {
                    return this.valuationMethod; 
                }
                else if (this.valuationMethodIDRef != null)
                {
                    valuationMethod = IDManager.getID(valuationMethodIDRef) as ValuationMethodEnum;
                    return this.valuationMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.valuationMethod != value)
                {
                    this.valuationMethod = value;
                }
            }
        }
        #endregion
        
        public string ValuationMethodEnumIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

