using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CashSettlementTerms : SettlementTerms
    {
        public CashSettlementTerms(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode valuationDateNode = xmlNode.SelectSingleNode("valuationDate");
            
            if (valuationDateNode != null)
            {
                if (valuationDateNode.Attributes["href"] != null || valuationDateNode.Attributes["id"] != null) 
                {
                    if (valuationDateNode.Attributes["id"] != null) 
                    {
                        valuationDateIDRef_ = valuationDateNode.Attributes["id"].Value;
                        ValuationDate ob = new ValuationDate(valuationDateNode);
                        IDManager.SetID(valuationDateIDRef_, ob);
                    }
                    else if (valuationDateNode.Attributes["href"] != null)
                    {
                        valuationDateIDRef_ = valuationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationDate_ = new ValuationDate(valuationDateNode);
                    }
                }
                else
                {
                    valuationDate_ = new ValuationDate(valuationDateNode);
                }
            }
            
        
            XmlNode valuationTimeNode = xmlNode.SelectSingleNode("valuationTime");
            
            if (valuationTimeNode != null)
            {
                if (valuationTimeNode.Attributes["href"] != null || valuationTimeNode.Attributes["id"] != null) 
                {
                    if (valuationTimeNode.Attributes["id"] != null) 
                    {
                        valuationTimeIDRef_ = valuationTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(valuationTimeNode);
                        IDManager.SetID(valuationTimeIDRef_, ob);
                    }
                    else if (valuationTimeNode.Attributes["href"] != null)
                    {
                        valuationTimeIDRef_ = valuationTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationTime_ = new BusinessCenterTime(valuationTimeNode);
                    }
                }
                else
                {
                    valuationTime_ = new BusinessCenterTime(valuationTimeNode);
                }
            }
            
        
            XmlNode quotationMethodNode = xmlNode.SelectSingleNode("quotationMethod");
            
            if (quotationMethodNode != null)
            {
                if (quotationMethodNode.Attributes["href"] != null || quotationMethodNode.Attributes["id"] != null) 
                {
                    if (quotationMethodNode.Attributes["id"] != null) 
                    {
                        quotationMethodIDRef_ = quotationMethodNode.Attributes["id"].Value;
                        QuotationRateTypeEnum ob = new QuotationRateTypeEnum(quotationMethodNode);
                        IDManager.SetID(quotationMethodIDRef_, ob);
                    }
                    else if (quotationMethodNode.Attributes["href"] != null)
                    {
                        quotationMethodIDRef_ = quotationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quotationMethod_ = new QuotationRateTypeEnum(quotationMethodNode);
                    }
                }
                else
                {
                    quotationMethod_ = new QuotationRateTypeEnum(quotationMethodNode);
                }
            }
            
        
            XmlNode quotationAmountNode = xmlNode.SelectSingleNode("quotationAmount");
            
            if (quotationAmountNode != null)
            {
                if (quotationAmountNode.Attributes["href"] != null || quotationAmountNode.Attributes["id"] != null) 
                {
                    if (quotationAmountNode.Attributes["id"] != null) 
                    {
                        quotationAmountIDRef_ = quotationAmountNode.Attributes["id"].Value;
                        Money ob = new Money(quotationAmountNode);
                        IDManager.SetID(quotationAmountIDRef_, ob);
                    }
                    else if (quotationAmountNode.Attributes["href"] != null)
                    {
                        quotationAmountIDRef_ = quotationAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        quotationAmount_ = new Money(quotationAmountNode);
                    }
                }
                else
                {
                    quotationAmount_ = new Money(quotationAmountNode);
                }
            }
            
        
            XmlNode minimumQuotationAmountNode = xmlNode.SelectSingleNode("minimumQuotationAmount");
            
            if (minimumQuotationAmountNode != null)
            {
                if (minimumQuotationAmountNode.Attributes["href"] != null || minimumQuotationAmountNode.Attributes["id"] != null) 
                {
                    if (minimumQuotationAmountNode.Attributes["id"] != null) 
                    {
                        minimumQuotationAmountIDRef_ = minimumQuotationAmountNode.Attributes["id"].Value;
                        Money ob = new Money(minimumQuotationAmountNode);
                        IDManager.SetID(minimumQuotationAmountIDRef_, ob);
                    }
                    else if (minimumQuotationAmountNode.Attributes["href"] != null)
                    {
                        minimumQuotationAmountIDRef_ = minimumQuotationAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        minimumQuotationAmount_ = new Money(minimumQuotationAmountNode);
                    }
                }
                else
                {
                    minimumQuotationAmount_ = new Money(minimumQuotationAmountNode);
                }
            }
            
        
            XmlNodeList dealerNodeList = xmlNode.SelectNodes("dealer");
            
            if (dealerNodeList != null)
            {
                this.dealer_ = new List<XsdTypeString>();
                foreach (XmlNode item in dealerNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            dealerIDRef_ = item.Attributes["id"].Value;
                            dealer_.Add(new XsdTypeString(item));
                            IDManager.SetID(dealerIDRef_, dealer_[dealer_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            dealerIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        dealer_.Add(new XsdTypeString(item));
                        }
                    }
                    else
                    {
                        dealer_.Add(new XsdTypeString(item));
                    }
                }
            }
            
        
            XmlNode cashSettlementBusinessDaysNode = xmlNode.SelectSingleNode("cashSettlementBusinessDays");
            
            if (cashSettlementBusinessDaysNode != null)
            {
                if (cashSettlementBusinessDaysNode.Attributes["href"] != null || cashSettlementBusinessDaysNode.Attributes["id"] != null) 
                {
                    if (cashSettlementBusinessDaysNode.Attributes["id"] != null) 
                    {
                        cashSettlementBusinessDaysIDRef_ = cashSettlementBusinessDaysNode.Attributes["id"].Value;
                        XsdTypeNonNegativeInteger ob = new XsdTypeNonNegativeInteger(cashSettlementBusinessDaysNode);
                        IDManager.SetID(cashSettlementBusinessDaysIDRef_, ob);
                    }
                    else if (cashSettlementBusinessDaysNode.Attributes["href"] != null)
                    {
                        cashSettlementBusinessDaysIDRef_ = cashSettlementBusinessDaysNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlementBusinessDays_ = new XsdTypeNonNegativeInteger(cashSettlementBusinessDaysNode);
                    }
                }
                else
                {
                    cashSettlementBusinessDays_ = new XsdTypeNonNegativeInteger(cashSettlementBusinessDaysNode);
                }
            }
            
        
            XmlNode cashSettlementAmountNode = xmlNode.SelectSingleNode("cashSettlementAmount");
            
            if (cashSettlementAmountNode != null)
            {
                if (cashSettlementAmountNode.Attributes["href"] != null || cashSettlementAmountNode.Attributes["id"] != null) 
                {
                    if (cashSettlementAmountNode.Attributes["id"] != null) 
                    {
                        cashSettlementAmountIDRef_ = cashSettlementAmountNode.Attributes["id"].Value;
                        Money ob = new Money(cashSettlementAmountNode);
                        IDManager.SetID(cashSettlementAmountIDRef_, ob);
                    }
                    else if (cashSettlementAmountNode.Attributes["href"] != null)
                    {
                        cashSettlementAmountIDRef_ = cashSettlementAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlementAmount_ = new Money(cashSettlementAmountNode);
                    }
                }
                else
                {
                    cashSettlementAmount_ = new Money(cashSettlementAmountNode);
                }
            }
            
        
            XmlNode recoveryFactorNode = xmlNode.SelectSingleNode("recoveryFactor");
            
            if (recoveryFactorNode != null)
            {
                if (recoveryFactorNode.Attributes["href"] != null || recoveryFactorNode.Attributes["id"] != null) 
                {
                    if (recoveryFactorNode.Attributes["id"] != null) 
                    {
                        recoveryFactorIDRef_ = recoveryFactorNode.Attributes["id"].Value;
                        RestrictedPercentage ob = new RestrictedPercentage(recoveryFactorNode);
                        IDManager.SetID(recoveryFactorIDRef_, ob);
                    }
                    else if (recoveryFactorNode.Attributes["href"] != null)
                    {
                        recoveryFactorIDRef_ = recoveryFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        recoveryFactor_ = new RestrictedPercentage(recoveryFactorNode);
                    }
                }
                else
                {
                    recoveryFactor_ = new RestrictedPercentage(recoveryFactorNode);
                }
            }
            
        
            XmlNode fixedSettlementNode = xmlNode.SelectSingleNode("fixedSettlement");
            
            if (fixedSettlementNode != null)
            {
                if (fixedSettlementNode.Attributes["href"] != null || fixedSettlementNode.Attributes["id"] != null) 
                {
                    if (fixedSettlementNode.Attributes["id"] != null) 
                    {
                        fixedSettlementIDRef_ = fixedSettlementNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(fixedSettlementNode);
                        IDManager.SetID(fixedSettlementIDRef_, ob);
                    }
                    else if (fixedSettlementNode.Attributes["href"] != null)
                    {
                        fixedSettlementIDRef_ = fixedSettlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedSettlement_ = new XsdTypeBoolean(fixedSettlementNode);
                    }
                }
                else
                {
                    fixedSettlement_ = new XsdTypeBoolean(fixedSettlementNode);
                }
            }
            
        
            XmlNode accruedInterestNode = xmlNode.SelectSingleNode("accruedInterest");
            
            if (accruedInterestNode != null)
            {
                if (accruedInterestNode.Attributes["href"] != null || accruedInterestNode.Attributes["id"] != null) 
                {
                    if (accruedInterestNode.Attributes["id"] != null) 
                    {
                        accruedInterestIDRef_ = accruedInterestNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(accruedInterestNode);
                        IDManager.SetID(accruedInterestIDRef_, ob);
                    }
                    else if (accruedInterestNode.Attributes["href"] != null)
                    {
                        accruedInterestIDRef_ = accruedInterestNode.Attributes["href"].Value;
                    }
                    else
                    {
                        accruedInterest_ = new XsdTypeBoolean(accruedInterestNode);
                    }
                }
                else
                {
                    accruedInterest_ = new XsdTypeBoolean(accruedInterestNode);
                }
            }
            
        
            XmlNode valuationMethodNode = xmlNode.SelectSingleNode("valuationMethod");
            
            if (valuationMethodNode != null)
            {
                if (valuationMethodNode.Attributes["href"] != null || valuationMethodNode.Attributes["id"] != null) 
                {
                    if (valuationMethodNode.Attributes["id"] != null) 
                    {
                        valuationMethodIDRef_ = valuationMethodNode.Attributes["id"].Value;
                        ValuationMethodEnum ob = new ValuationMethodEnum(valuationMethodNode);
                        IDManager.SetID(valuationMethodIDRef_, ob);
                    }
                    else if (valuationMethodNode.Attributes["href"] != null)
                    {
                        valuationMethodIDRef_ = valuationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        valuationMethod_ = new ValuationMethodEnum(valuationMethodNode);
                    }
                }
                else
                {
                    valuationMethod_ = new ValuationMethodEnum(valuationMethodNode);
                }
            }
            
        
        }
        
    
        #region ValuationDate_
        private ValuationDate valuationDate_;
        public ValuationDate ValuationDate_
        {
            get
            {
                if (this.valuationDate_ != null)
                {
                    return this.valuationDate_; 
                }
                else if (this.valuationDateIDRef_ != null)
                {
                    valuationDate_ = IDManager.getID(valuationDateIDRef_) as ValuationDate;
                    return this.valuationDate_; 
                }
                else
                {
                      return this.valuationDate_; 
                }
            }
            set
            {
                if (this.valuationDate_ != value)
                {
                    this.valuationDate_ = value;
                }
            }
        }
        #endregion
        
        public string valuationDateIDRef_ { get; set; }
        #region ValuationTime_
        private BusinessCenterTime valuationTime_;
        public BusinessCenterTime ValuationTime_
        {
            get
            {
                if (this.valuationTime_ != null)
                {
                    return this.valuationTime_; 
                }
                else if (this.valuationTimeIDRef_ != null)
                {
                    valuationTime_ = IDManager.getID(valuationTimeIDRef_) as BusinessCenterTime;
                    return this.valuationTime_; 
                }
                else
                {
                      return this.valuationTime_; 
                }
            }
            set
            {
                if (this.valuationTime_ != value)
                {
                    this.valuationTime_ = value;
                }
            }
        }
        #endregion
        
        public string valuationTimeIDRef_ { get; set; }
        #region QuotationMethod_
        private QuotationRateTypeEnum quotationMethod_;
        public QuotationRateTypeEnum QuotationMethod_
        {
            get
            {
                if (this.quotationMethod_ != null)
                {
                    return this.quotationMethod_; 
                }
                else if (this.quotationMethodIDRef_ != null)
                {
                    quotationMethod_ = IDManager.getID(quotationMethodIDRef_) as QuotationRateTypeEnum;
                    return this.quotationMethod_; 
                }
                else
                {
                      return this.quotationMethod_; 
                }
            }
            set
            {
                if (this.quotationMethod_ != value)
                {
                    this.quotationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string quotationMethodIDRef_ { get; set; }
        #region QuotationAmount_
        private Money quotationAmount_;
        public Money QuotationAmount_
        {
            get
            {
                if (this.quotationAmount_ != null)
                {
                    return this.quotationAmount_; 
                }
                else if (this.quotationAmountIDRef_ != null)
                {
                    quotationAmount_ = IDManager.getID(quotationAmountIDRef_) as Money;
                    return this.quotationAmount_; 
                }
                else
                {
                      return this.quotationAmount_; 
                }
            }
            set
            {
                if (this.quotationAmount_ != value)
                {
                    this.quotationAmount_ = value;
                }
            }
        }
        #endregion
        
        public string quotationAmountIDRef_ { get; set; }
        #region MinimumQuotationAmount_
        private Money minimumQuotationAmount_;
        public Money MinimumQuotationAmount_
        {
            get
            {
                if (this.minimumQuotationAmount_ != null)
                {
                    return this.minimumQuotationAmount_; 
                }
                else if (this.minimumQuotationAmountIDRef_ != null)
                {
                    minimumQuotationAmount_ = IDManager.getID(minimumQuotationAmountIDRef_) as Money;
                    return this.minimumQuotationAmount_; 
                }
                else
                {
                      return this.minimumQuotationAmount_; 
                }
            }
            set
            {
                if (this.minimumQuotationAmount_ != value)
                {
                    this.minimumQuotationAmount_ = value;
                }
            }
        }
        #endregion
        
        public string minimumQuotationAmountIDRef_ { get; set; }
        #region Dealer_
        private List<XsdTypeString> dealer_;
        public List<XsdTypeString> Dealer_
        {
            get
            {
                if (this.dealer_ != null)
                {
                    return this.dealer_; 
                }
                else if (this.dealerIDRef_ != null)
                {
                    return this.dealer_; 
                }
                else
                {
                      return this.dealer_; 
                }
            }
            set
            {
                if (this.dealer_ != value)
                {
                    this.dealer_ = value;
                }
            }
        }
        #endregion
        
        public string dealerIDRef_ { get; set; }
        #region CashSettlementBusinessDays_
        private XsdTypeNonNegativeInteger cashSettlementBusinessDays_;
        public XsdTypeNonNegativeInteger CashSettlementBusinessDays_
        {
            get
            {
                if (this.cashSettlementBusinessDays_ != null)
                {
                    return this.cashSettlementBusinessDays_; 
                }
                else if (this.cashSettlementBusinessDaysIDRef_ != null)
                {
                    cashSettlementBusinessDays_ = IDManager.getID(cashSettlementBusinessDaysIDRef_) as XsdTypeNonNegativeInteger;
                    return this.cashSettlementBusinessDays_; 
                }
                else
                {
                      return this.cashSettlementBusinessDays_; 
                }
            }
            set
            {
                if (this.cashSettlementBusinessDays_ != value)
                {
                    this.cashSettlementBusinessDays_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementBusinessDaysIDRef_ { get; set; }
        #region CashSettlementAmount_
        private Money cashSettlementAmount_;
        public Money CashSettlementAmount_
        {
            get
            {
                if (this.cashSettlementAmount_ != null)
                {
                    return this.cashSettlementAmount_; 
                }
                else if (this.cashSettlementAmountIDRef_ != null)
                {
                    cashSettlementAmount_ = IDManager.getID(cashSettlementAmountIDRef_) as Money;
                    return this.cashSettlementAmount_; 
                }
                else
                {
                      return this.cashSettlementAmount_; 
                }
            }
            set
            {
                if (this.cashSettlementAmount_ != value)
                {
                    this.cashSettlementAmount_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementAmountIDRef_ { get; set; }
        #region RecoveryFactor_
        private RestrictedPercentage recoveryFactor_;
        public RestrictedPercentage RecoveryFactor_
        {
            get
            {
                if (this.recoveryFactor_ != null)
                {
                    return this.recoveryFactor_; 
                }
                else if (this.recoveryFactorIDRef_ != null)
                {
                    recoveryFactor_ = IDManager.getID(recoveryFactorIDRef_) as RestrictedPercentage;
                    return this.recoveryFactor_; 
                }
                else
                {
                      return this.recoveryFactor_; 
                }
            }
            set
            {
                if (this.recoveryFactor_ != value)
                {
                    this.recoveryFactor_ = value;
                }
            }
        }
        #endregion
        
        public string recoveryFactorIDRef_ { get; set; }
        #region FixedSettlement_
        private XsdTypeBoolean fixedSettlement_;
        public XsdTypeBoolean FixedSettlement_
        {
            get
            {
                if (this.fixedSettlement_ != null)
                {
                    return this.fixedSettlement_; 
                }
                else if (this.fixedSettlementIDRef_ != null)
                {
                    fixedSettlement_ = IDManager.getID(fixedSettlementIDRef_) as XsdTypeBoolean;
                    return this.fixedSettlement_; 
                }
                else
                {
                      return this.fixedSettlement_; 
                }
            }
            set
            {
                if (this.fixedSettlement_ != value)
                {
                    this.fixedSettlement_ = value;
                }
            }
        }
        #endregion
        
        public string fixedSettlementIDRef_ { get; set; }
        #region AccruedInterest_
        private XsdTypeBoolean accruedInterest_;
        public XsdTypeBoolean AccruedInterest_
        {
            get
            {
                if (this.accruedInterest_ != null)
                {
                    return this.accruedInterest_; 
                }
                else if (this.accruedInterestIDRef_ != null)
                {
                    accruedInterest_ = IDManager.getID(accruedInterestIDRef_) as XsdTypeBoolean;
                    return this.accruedInterest_; 
                }
                else
                {
                      return this.accruedInterest_; 
                }
            }
            set
            {
                if (this.accruedInterest_ != value)
                {
                    this.accruedInterest_ = value;
                }
            }
        }
        #endregion
        
        public string accruedInterestIDRef_ { get; set; }
        #region ValuationMethod_
        private ValuationMethodEnum valuationMethod_;
        public ValuationMethodEnum ValuationMethod_
        {
            get
            {
                if (this.valuationMethod_ != null)
                {
                    return this.valuationMethod_; 
                }
                else if (this.valuationMethodIDRef_ != null)
                {
                    valuationMethod_ = IDManager.getID(valuationMethodIDRef_) as ValuationMethodEnum;
                    return this.valuationMethod_; 
                }
                else
                {
                      return this.valuationMethod_; 
                }
            }
            set
            {
                if (this.valuationMethod_ != value)
                {
                    this.valuationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string valuationMethodIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

