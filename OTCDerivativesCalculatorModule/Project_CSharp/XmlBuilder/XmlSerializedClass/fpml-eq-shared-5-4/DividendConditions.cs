using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class DividendConditions : ISerialized
    {
        public DividendConditions(XmlNode xmlNode)
        {
            XmlNode dividendReinvestmentNode = xmlNode.SelectSingleNode("dividendReinvestment");
            
            if (dividendReinvestmentNode != null)
            {
                if (dividendReinvestmentNode.Attributes["href"] != null || dividendReinvestmentNode.Attributes["id"] != null) 
                {
                    if (dividendReinvestmentNode.Attributes["id"] != null) 
                    {
                        dividendReinvestmentIDRef_ = dividendReinvestmentNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(dividendReinvestmentNode);
                        IDManager.SetID(dividendReinvestmentIDRef_, ob);
                    }
                    else if (dividendReinvestmentNode.Attributes["href"] != null)
                    {
                        dividendReinvestmentIDRef_ = dividendReinvestmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendReinvestment_ = new XsdTypeBoolean(dividendReinvestmentNode);
                    }
                }
                else
                {
                    dividendReinvestment_ = new XsdTypeBoolean(dividendReinvestmentNode);
                }
            }
            
        
            XmlNode dividendEntitlementNode = xmlNode.SelectSingleNode("dividendEntitlement");
            
            if (dividendEntitlementNode != null)
            {
                if (dividendEntitlementNode.Attributes["href"] != null || dividendEntitlementNode.Attributes["id"] != null) 
                {
                    if (dividendEntitlementNode.Attributes["id"] != null) 
                    {
                        dividendEntitlementIDRef_ = dividendEntitlementNode.Attributes["id"].Value;
                        DividendEntitlementEnum ob = new DividendEntitlementEnum(dividendEntitlementNode);
                        IDManager.SetID(dividendEntitlementIDRef_, ob);
                    }
                    else if (dividendEntitlementNode.Attributes["href"] != null)
                    {
                        dividendEntitlementIDRef_ = dividendEntitlementNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendEntitlement_ = new DividendEntitlementEnum(dividendEntitlementNode);
                    }
                }
                else
                {
                    dividendEntitlement_ = new DividendEntitlementEnum(dividendEntitlementNode);
                }
            }
            
        
            XmlNode dividendAmountNode = xmlNode.SelectSingleNode("dividendAmount");
            
            if (dividendAmountNode != null)
            {
                if (dividendAmountNode.Attributes["href"] != null || dividendAmountNode.Attributes["id"] != null) 
                {
                    if (dividendAmountNode.Attributes["id"] != null) 
                    {
                        dividendAmountIDRef_ = dividendAmountNode.Attributes["id"].Value;
                        DividendAmountTypeEnum ob = new DividendAmountTypeEnum(dividendAmountNode);
                        IDManager.SetID(dividendAmountIDRef_, ob);
                    }
                    else if (dividendAmountNode.Attributes["href"] != null)
                    {
                        dividendAmountIDRef_ = dividendAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendAmount_ = new DividendAmountTypeEnum(dividendAmountNode);
                    }
                }
                else
                {
                    dividendAmount_ = new DividendAmountTypeEnum(dividendAmountNode);
                }
            }
            
        
            XmlNode dividendPaymentDateNode = xmlNode.SelectSingleNode("dividendPaymentDate");
            
            if (dividendPaymentDateNode != null)
            {
                if (dividendPaymentDateNode.Attributes["href"] != null || dividendPaymentDateNode.Attributes["id"] != null) 
                {
                    if (dividendPaymentDateNode.Attributes["id"] != null) 
                    {
                        dividendPaymentDateIDRef_ = dividendPaymentDateNode.Attributes["id"].Value;
                        DividendPaymentDate ob = new DividendPaymentDate(dividendPaymentDateNode);
                        IDManager.SetID(dividendPaymentDateIDRef_, ob);
                    }
                    else if (dividendPaymentDateNode.Attributes["href"] != null)
                    {
                        dividendPaymentDateIDRef_ = dividendPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendPaymentDate_ = new DividendPaymentDate(dividendPaymentDateNode);
                    }
                }
                else
                {
                    dividendPaymentDate_ = new DividendPaymentDate(dividendPaymentDateNode);
                }
            }
            
        
            XmlNode dividendPeriodEffectiveDateNode = xmlNode.SelectSingleNode("dividendPeriodEffectiveDate");
            
            if (dividendPeriodEffectiveDateNode != null)
            {
                if (dividendPeriodEffectiveDateNode.Attributes["href"] != null || dividendPeriodEffectiveDateNode.Attributes["id"] != null) 
                {
                    if (dividendPeriodEffectiveDateNode.Attributes["id"] != null) 
                    {
                        dividendPeriodEffectiveDateIDRef_ = dividendPeriodEffectiveDateNode.Attributes["id"].Value;
                        DateReference ob = new DateReference(dividendPeriodEffectiveDateNode);
                        IDManager.SetID(dividendPeriodEffectiveDateIDRef_, ob);
                    }
                    else if (dividendPeriodEffectiveDateNode.Attributes["href"] != null)
                    {
                        dividendPeriodEffectiveDateIDRef_ = dividendPeriodEffectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendPeriodEffectiveDate_ = new DateReference(dividendPeriodEffectiveDateNode);
                    }
                }
                else
                {
                    dividendPeriodEffectiveDate_ = new DateReference(dividendPeriodEffectiveDateNode);
                }
            }
            
        
            XmlNode dividendPeriodEndDateNode = xmlNode.SelectSingleNode("dividendPeriodEndDate");
            
            if (dividendPeriodEndDateNode != null)
            {
                if (dividendPeriodEndDateNode.Attributes["href"] != null || dividendPeriodEndDateNode.Attributes["id"] != null) 
                {
                    if (dividendPeriodEndDateNode.Attributes["id"] != null) 
                    {
                        dividendPeriodEndDateIDRef_ = dividendPeriodEndDateNode.Attributes["id"].Value;
                        DateReference ob = new DateReference(dividendPeriodEndDateNode);
                        IDManager.SetID(dividendPeriodEndDateIDRef_, ob);
                    }
                    else if (dividendPeriodEndDateNode.Attributes["href"] != null)
                    {
                        dividendPeriodEndDateIDRef_ = dividendPeriodEndDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendPeriodEndDate_ = new DateReference(dividendPeriodEndDateNode);
                    }
                }
                else
                {
                    dividendPeriodEndDate_ = new DateReference(dividendPeriodEndDateNode);
                }
            }
            
        
            XmlNode dividendPeriodNode = xmlNode.SelectSingleNode("dividendPeriod");
            
            if (dividendPeriodNode != null)
            {
                if (dividendPeriodNode.Attributes["href"] != null || dividendPeriodNode.Attributes["id"] != null) 
                {
                    if (dividendPeriodNode.Attributes["id"] != null) 
                    {
                        dividendPeriodIDRef_ = dividendPeriodNode.Attributes["id"].Value;
                        DividendPeriodEnum ob = new DividendPeriodEnum(dividendPeriodNode);
                        IDManager.SetID(dividendPeriodIDRef_, ob);
                    }
                    else if (dividendPeriodNode.Attributes["href"] != null)
                    {
                        dividendPeriodIDRef_ = dividendPeriodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendPeriod_ = new DividendPeriodEnum(dividendPeriodNode);
                    }
                }
                else
                {
                    dividendPeriod_ = new DividendPeriodEnum(dividendPeriodNode);
                }
            }
            
        
            XmlNode extraOrdinaryDividendsNode = xmlNode.SelectSingleNode("extraOrdinaryDividends");
            
            if (extraOrdinaryDividendsNode != null)
            {
                if (extraOrdinaryDividendsNode.Attributes["href"] != null || extraOrdinaryDividendsNode.Attributes["id"] != null) 
                {
                    if (extraOrdinaryDividendsNode.Attributes["id"] != null) 
                    {
                        extraOrdinaryDividendsIDRef_ = extraOrdinaryDividendsNode.Attributes["id"].Value;
                        PartyReference ob = new PartyReference(extraOrdinaryDividendsNode);
                        IDManager.SetID(extraOrdinaryDividendsIDRef_, ob);
                    }
                    else if (extraOrdinaryDividendsNode.Attributes["href"] != null)
                    {
                        extraOrdinaryDividendsIDRef_ = extraOrdinaryDividendsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        extraOrdinaryDividends_ = new PartyReference(extraOrdinaryDividendsNode);
                    }
                }
                else
                {
                    extraOrdinaryDividends_ = new PartyReference(extraOrdinaryDividendsNode);
                }
            }
            
        
            XmlNode excessDividendAmountNode = xmlNode.SelectSingleNode("excessDividendAmount");
            
            if (excessDividendAmountNode != null)
            {
                if (excessDividendAmountNode.Attributes["href"] != null || excessDividendAmountNode.Attributes["id"] != null) 
                {
                    if (excessDividendAmountNode.Attributes["id"] != null) 
                    {
                        excessDividendAmountIDRef_ = excessDividendAmountNode.Attributes["id"].Value;
                        DividendAmountTypeEnum ob = new DividendAmountTypeEnum(excessDividendAmountNode);
                        IDManager.SetID(excessDividendAmountIDRef_, ob);
                    }
                    else if (excessDividendAmountNode.Attributes["href"] != null)
                    {
                        excessDividendAmountIDRef_ = excessDividendAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        excessDividendAmount_ = new DividendAmountTypeEnum(excessDividendAmountNode);
                    }
                }
                else
                {
                    excessDividendAmount_ = new DividendAmountTypeEnum(excessDividendAmountNode);
                }
            }
            
        
            XmlNode currencyNode = xmlNode.SelectSingleNode("currency");
            
            if (currencyNode != null)
            {
                if (currencyNode.Attributes["href"] != null || currencyNode.Attributes["id"] != null) 
                {
                    if (currencyNode.Attributes["id"] != null) 
                    {
                        currencyIDRef_ = currencyNode.Attributes["id"].Value;
                        IdentifiedCurrency ob = new IdentifiedCurrency(currencyNode);
                        IDManager.SetID(currencyIDRef_, ob);
                    }
                    else if (currencyNode.Attributes["href"] != null)
                    {
                        currencyIDRef_ = currencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currency_ = new IdentifiedCurrency(currencyNode);
                    }
                }
                else
                {
                    currency_ = new IdentifiedCurrency(currencyNode);
                }
            }
            
        
            XmlNode determinationMethodNode = xmlNode.SelectSingleNode("determinationMethod");
            
            if (determinationMethodNode != null)
            {
                if (determinationMethodNode.Attributes["href"] != null || determinationMethodNode.Attributes["id"] != null) 
                {
                    if (determinationMethodNode.Attributes["id"] != null) 
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["id"].Value;
                        DeterminationMethod ob = new DeterminationMethod(determinationMethodNode);
                        IDManager.SetID(determinationMethodIDRef_, ob);
                    }
                    else if (determinationMethodNode.Attributes["href"] != null)
                    {
                        determinationMethodIDRef_ = determinationMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                    }
                }
                else
                {
                    determinationMethod_ = new DeterminationMethod(determinationMethodNode);
                }
            }
            
        
            XmlNode currencyReferenceNode = xmlNode.SelectSingleNode("currencyReference");
            
            if (currencyReferenceNode != null)
            {
                if (currencyReferenceNode.Attributes["href"] != null || currencyReferenceNode.Attributes["id"] != null) 
                {
                    if (currencyReferenceNode.Attributes["id"] != null) 
                    {
                        currencyReferenceIDRef_ = currencyReferenceNode.Attributes["id"].Value;
                        IdentifiedCurrencyReference ob = new IdentifiedCurrencyReference(currencyReferenceNode);
                        IDManager.SetID(currencyReferenceIDRef_, ob);
                    }
                    else if (currencyReferenceNode.Attributes["href"] != null)
                    {
                        currencyReferenceIDRef_ = currencyReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        currencyReference_ = new IdentifiedCurrencyReference(currencyReferenceNode);
                    }
                }
                else
                {
                    currencyReference_ = new IdentifiedCurrencyReference(currencyReferenceNode);
                }
            }
            
        
            XmlNode dividendFxTriggerDateNode = xmlNode.SelectSingleNode("dividendFxTriggerDate");
            
            if (dividendFxTriggerDateNode != null)
            {
                if (dividendFxTriggerDateNode.Attributes["href"] != null || dividendFxTriggerDateNode.Attributes["id"] != null) 
                {
                    if (dividendFxTriggerDateNode.Attributes["id"] != null) 
                    {
                        dividendFxTriggerDateIDRef_ = dividendFxTriggerDateNode.Attributes["id"].Value;
                        DividendPaymentDate ob = new DividendPaymentDate(dividendFxTriggerDateNode);
                        IDManager.SetID(dividendFxTriggerDateIDRef_, ob);
                    }
                    else if (dividendFxTriggerDateNode.Attributes["href"] != null)
                    {
                        dividendFxTriggerDateIDRef_ = dividendFxTriggerDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendFxTriggerDate_ = new DividendPaymentDate(dividendFxTriggerDateNode);
                    }
                }
                else
                {
                    dividendFxTriggerDate_ = new DividendPaymentDate(dividendFxTriggerDateNode);
                }
            }
            
        
            XmlNode interestAccrualsMethodNode = xmlNode.SelectSingleNode("interestAccrualsMethod");
            
            if (interestAccrualsMethodNode != null)
            {
                if (interestAccrualsMethodNode.Attributes["href"] != null || interestAccrualsMethodNode.Attributes["id"] != null) 
                {
                    if (interestAccrualsMethodNode.Attributes["id"] != null) 
                    {
                        interestAccrualsMethodIDRef_ = interestAccrualsMethodNode.Attributes["id"].Value;
                        InterestAccrualsCompoundingMethod ob = new InterestAccrualsCompoundingMethod(interestAccrualsMethodNode);
                        IDManager.SetID(interestAccrualsMethodIDRef_, ob);
                    }
                    else if (interestAccrualsMethodNode.Attributes["href"] != null)
                    {
                        interestAccrualsMethodIDRef_ = interestAccrualsMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        interestAccrualsMethod_ = new InterestAccrualsCompoundingMethod(interestAccrualsMethodNode);
                    }
                }
                else
                {
                    interestAccrualsMethod_ = new InterestAccrualsCompoundingMethod(interestAccrualsMethodNode);
                }
            }
            
        
            XmlNode numberOfIndexUnitsNode = xmlNode.SelectSingleNode("numberOfIndexUnits");
            
            if (numberOfIndexUnitsNode != null)
            {
                if (numberOfIndexUnitsNode.Attributes["href"] != null || numberOfIndexUnitsNode.Attributes["id"] != null) 
                {
                    if (numberOfIndexUnitsNode.Attributes["id"] != null) 
                    {
                        numberOfIndexUnitsIDRef_ = numberOfIndexUnitsNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(numberOfIndexUnitsNode);
                        IDManager.SetID(numberOfIndexUnitsIDRef_, ob);
                    }
                    else if (numberOfIndexUnitsNode.Attributes["href"] != null)
                    {
                        numberOfIndexUnitsIDRef_ = numberOfIndexUnitsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        numberOfIndexUnits_ = new NonNegativeDecimal(numberOfIndexUnitsNode);
                    }
                }
                else
                {
                    numberOfIndexUnits_ = new NonNegativeDecimal(numberOfIndexUnitsNode);
                }
            }
            
        
            XmlNode declaredCashDividendPercentageNode = xmlNode.SelectSingleNode("declaredCashDividendPercentage");
            
            if (declaredCashDividendPercentageNode != null)
            {
                if (declaredCashDividendPercentageNode.Attributes["href"] != null || declaredCashDividendPercentageNode.Attributes["id"] != null) 
                {
                    if (declaredCashDividendPercentageNode.Attributes["id"] != null) 
                    {
                        declaredCashDividendPercentageIDRef_ = declaredCashDividendPercentageNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(declaredCashDividendPercentageNode);
                        IDManager.SetID(declaredCashDividendPercentageIDRef_, ob);
                    }
                    else if (declaredCashDividendPercentageNode.Attributes["href"] != null)
                    {
                        declaredCashDividendPercentageIDRef_ = declaredCashDividendPercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        declaredCashDividendPercentage_ = new NonNegativeDecimal(declaredCashDividendPercentageNode);
                    }
                }
                else
                {
                    declaredCashDividendPercentage_ = new NonNegativeDecimal(declaredCashDividendPercentageNode);
                }
            }
            
        
            XmlNode declaredCashEquivalentDividendPercentageNode = xmlNode.SelectSingleNode("declaredCashEquivalentDividendPercentage");
            
            if (declaredCashEquivalentDividendPercentageNode != null)
            {
                if (declaredCashEquivalentDividendPercentageNode.Attributes["href"] != null || declaredCashEquivalentDividendPercentageNode.Attributes["id"] != null) 
                {
                    if (declaredCashEquivalentDividendPercentageNode.Attributes["id"] != null) 
                    {
                        declaredCashEquivalentDividendPercentageIDRef_ = declaredCashEquivalentDividendPercentageNode.Attributes["id"].Value;
                        NonNegativeDecimal ob = new NonNegativeDecimal(declaredCashEquivalentDividendPercentageNode);
                        IDManager.SetID(declaredCashEquivalentDividendPercentageIDRef_, ob);
                    }
                    else if (declaredCashEquivalentDividendPercentageNode.Attributes["href"] != null)
                    {
                        declaredCashEquivalentDividendPercentageIDRef_ = declaredCashEquivalentDividendPercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        declaredCashEquivalentDividendPercentage_ = new NonNegativeDecimal(declaredCashEquivalentDividendPercentageNode);
                    }
                }
                else
                {
                    declaredCashEquivalentDividendPercentage_ = new NonNegativeDecimal(declaredCashEquivalentDividendPercentageNode);
                }
            }
            
        
            XmlNode nonCashDividendTreatmentNode = xmlNode.SelectSingleNode("nonCashDividendTreatment");
            
            if (nonCashDividendTreatmentNode != null)
            {
                if (nonCashDividendTreatmentNode.Attributes["href"] != null || nonCashDividendTreatmentNode.Attributes["id"] != null) 
                {
                    if (nonCashDividendTreatmentNode.Attributes["id"] != null) 
                    {
                        nonCashDividendTreatmentIDRef_ = nonCashDividendTreatmentNode.Attributes["id"].Value;
                        NonCashDividendTreatmentEnum ob = new NonCashDividendTreatmentEnum(nonCashDividendTreatmentNode);
                        IDManager.SetID(nonCashDividendTreatmentIDRef_, ob);
                    }
                    else if (nonCashDividendTreatmentNode.Attributes["href"] != null)
                    {
                        nonCashDividendTreatmentIDRef_ = nonCashDividendTreatmentNode.Attributes["href"].Value;
                    }
                    else
                    {
                        nonCashDividendTreatment_ = new NonCashDividendTreatmentEnum(nonCashDividendTreatmentNode);
                    }
                }
                else
                {
                    nonCashDividendTreatment_ = new NonCashDividendTreatmentEnum(nonCashDividendTreatmentNode);
                }
            }
            
        
            XmlNode dividendCompositionNode = xmlNode.SelectSingleNode("dividendComposition");
            
            if (dividendCompositionNode != null)
            {
                if (dividendCompositionNode.Attributes["href"] != null || dividendCompositionNode.Attributes["id"] != null) 
                {
                    if (dividendCompositionNode.Attributes["id"] != null) 
                    {
                        dividendCompositionIDRef_ = dividendCompositionNode.Attributes["id"].Value;
                        DividendCompositionEnum ob = new DividendCompositionEnum(dividendCompositionNode);
                        IDManager.SetID(dividendCompositionIDRef_, ob);
                    }
                    else if (dividendCompositionNode.Attributes["href"] != null)
                    {
                        dividendCompositionIDRef_ = dividendCompositionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        dividendComposition_ = new DividendCompositionEnum(dividendCompositionNode);
                    }
                }
                else
                {
                    dividendComposition_ = new DividendCompositionEnum(dividendCompositionNode);
                }
            }
            
        
            XmlNode specialDividendsNode = xmlNode.SelectSingleNode("specialDividends");
            
            if (specialDividendsNode != null)
            {
                if (specialDividendsNode.Attributes["href"] != null || specialDividendsNode.Attributes["id"] != null) 
                {
                    if (specialDividendsNode.Attributes["id"] != null) 
                    {
                        specialDividendsIDRef_ = specialDividendsNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(specialDividendsNode);
                        IDManager.SetID(specialDividendsIDRef_, ob);
                    }
                    else if (specialDividendsNode.Attributes["href"] != null)
                    {
                        specialDividendsIDRef_ = specialDividendsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        specialDividends_ = new XsdTypeBoolean(specialDividendsNode);
                    }
                }
                else
                {
                    specialDividends_ = new XsdTypeBoolean(specialDividendsNode);
                }
            }
            
        
        }
        
    
        #region DividendReinvestment_
        private XsdTypeBoolean dividendReinvestment_;
        public XsdTypeBoolean DividendReinvestment_
        {
            get
            {
                if (this.dividendReinvestment_ != null)
                {
                    return this.dividendReinvestment_; 
                }
                else if (this.dividendReinvestmentIDRef_ != null)
                {
                    dividendReinvestment_ = IDManager.getID(dividendReinvestmentIDRef_) as XsdTypeBoolean;
                    return this.dividendReinvestment_; 
                }
                else
                {
                      return this.dividendReinvestment_; 
                }
            }
            set
            {
                if (this.dividendReinvestment_ != value)
                {
                    this.dividendReinvestment_ = value;
                }
            }
        }
        #endregion
        
        public string dividendReinvestmentIDRef_ { get; set; }
        #region DividendEntitlement_
        private DividendEntitlementEnum dividendEntitlement_;
        public DividendEntitlementEnum DividendEntitlement_
        {
            get
            {
                if (this.dividendEntitlement_ != null)
                {
                    return this.dividendEntitlement_; 
                }
                else if (this.dividendEntitlementIDRef_ != null)
                {
                    dividendEntitlement_ = IDManager.getID(dividendEntitlementIDRef_) as DividendEntitlementEnum;
                    return this.dividendEntitlement_; 
                }
                else
                {
                      return this.dividendEntitlement_; 
                }
            }
            set
            {
                if (this.dividendEntitlement_ != value)
                {
                    this.dividendEntitlement_ = value;
                }
            }
        }
        #endregion
        
        public string dividendEntitlementIDRef_ { get; set; }
        #region DividendAmount_
        private DividendAmountTypeEnum dividendAmount_;
        public DividendAmountTypeEnum DividendAmount_
        {
            get
            {
                if (this.dividendAmount_ != null)
                {
                    return this.dividendAmount_; 
                }
                else if (this.dividendAmountIDRef_ != null)
                {
                    dividendAmount_ = IDManager.getID(dividendAmountIDRef_) as DividendAmountTypeEnum;
                    return this.dividendAmount_; 
                }
                else
                {
                      return this.dividendAmount_; 
                }
            }
            set
            {
                if (this.dividendAmount_ != value)
                {
                    this.dividendAmount_ = value;
                }
            }
        }
        #endregion
        
        public string dividendAmountIDRef_ { get; set; }
        #region DividendPaymentDate_
        private DividendPaymentDate dividendPaymentDate_;
        public DividendPaymentDate DividendPaymentDate_
        {
            get
            {
                if (this.dividendPaymentDate_ != null)
                {
                    return this.dividendPaymentDate_; 
                }
                else if (this.dividendPaymentDateIDRef_ != null)
                {
                    dividendPaymentDate_ = IDManager.getID(dividendPaymentDateIDRef_) as DividendPaymentDate;
                    return this.dividendPaymentDate_; 
                }
                else
                {
                      return this.dividendPaymentDate_; 
                }
            }
            set
            {
                if (this.dividendPaymentDate_ != value)
                {
                    this.dividendPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string dividendPaymentDateIDRef_ { get; set; }
        #region DividendPeriodEffectiveDate_
        private DateReference dividendPeriodEffectiveDate_;
        public DateReference DividendPeriodEffectiveDate_
        {
            get
            {
                if (this.dividendPeriodEffectiveDate_ != null)
                {
                    return this.dividendPeriodEffectiveDate_; 
                }
                else if (this.dividendPeriodEffectiveDateIDRef_ != null)
                {
                    dividendPeriodEffectiveDate_ = IDManager.getID(dividendPeriodEffectiveDateIDRef_) as DateReference;
                    return this.dividendPeriodEffectiveDate_; 
                }
                else
                {
                      return this.dividendPeriodEffectiveDate_; 
                }
            }
            set
            {
                if (this.dividendPeriodEffectiveDate_ != value)
                {
                    this.dividendPeriodEffectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string dividendPeriodEffectiveDateIDRef_ { get; set; }
        #region DividendPeriodEndDate_
        private DateReference dividendPeriodEndDate_;
        public DateReference DividendPeriodEndDate_
        {
            get
            {
                if (this.dividendPeriodEndDate_ != null)
                {
                    return this.dividendPeriodEndDate_; 
                }
                else if (this.dividendPeriodEndDateIDRef_ != null)
                {
                    dividendPeriodEndDate_ = IDManager.getID(dividendPeriodEndDateIDRef_) as DateReference;
                    return this.dividendPeriodEndDate_; 
                }
                else
                {
                      return this.dividendPeriodEndDate_; 
                }
            }
            set
            {
                if (this.dividendPeriodEndDate_ != value)
                {
                    this.dividendPeriodEndDate_ = value;
                }
            }
        }
        #endregion
        
        public string dividendPeriodEndDateIDRef_ { get; set; }
        #region DividendPeriod_
        private DividendPeriodEnum dividendPeriod_;
        public DividendPeriodEnum DividendPeriod_
        {
            get
            {
                if (this.dividendPeriod_ != null)
                {
                    return this.dividendPeriod_; 
                }
                else if (this.dividendPeriodIDRef_ != null)
                {
                    dividendPeriod_ = IDManager.getID(dividendPeriodIDRef_) as DividendPeriodEnum;
                    return this.dividendPeriod_; 
                }
                else
                {
                      return this.dividendPeriod_; 
                }
            }
            set
            {
                if (this.dividendPeriod_ != value)
                {
                    this.dividendPeriod_ = value;
                }
            }
        }
        #endregion
        
        public string dividendPeriodIDRef_ { get; set; }
        #region ExtraOrdinaryDividends_
        private PartyReference extraOrdinaryDividends_;
        public PartyReference ExtraOrdinaryDividends_
        {
            get
            {
                if (this.extraOrdinaryDividends_ != null)
                {
                    return this.extraOrdinaryDividends_; 
                }
                else if (this.extraOrdinaryDividendsIDRef_ != null)
                {
                    extraOrdinaryDividends_ = IDManager.getID(extraOrdinaryDividendsIDRef_) as PartyReference;
                    return this.extraOrdinaryDividends_; 
                }
                else
                {
                      return this.extraOrdinaryDividends_; 
                }
            }
            set
            {
                if (this.extraOrdinaryDividends_ != value)
                {
                    this.extraOrdinaryDividends_ = value;
                }
            }
        }
        #endregion
        
        public string extraOrdinaryDividendsIDRef_ { get; set; }
        #region ExcessDividendAmount_
        private DividendAmountTypeEnum excessDividendAmount_;
        public DividendAmountTypeEnum ExcessDividendAmount_
        {
            get
            {
                if (this.excessDividendAmount_ != null)
                {
                    return this.excessDividendAmount_; 
                }
                else if (this.excessDividendAmountIDRef_ != null)
                {
                    excessDividendAmount_ = IDManager.getID(excessDividendAmountIDRef_) as DividendAmountTypeEnum;
                    return this.excessDividendAmount_; 
                }
                else
                {
                      return this.excessDividendAmount_; 
                }
            }
            set
            {
                if (this.excessDividendAmount_ != value)
                {
                    this.excessDividendAmount_ = value;
                }
            }
        }
        #endregion
        
        public string excessDividendAmountIDRef_ { get; set; }
        #region Currency_
        private IdentifiedCurrency currency_;
        public IdentifiedCurrency Currency_
        {
            get
            {
                if (this.currency_ != null)
                {
                    return this.currency_; 
                }
                else if (this.currencyIDRef_ != null)
                {
                    currency_ = IDManager.getID(currencyIDRef_) as IdentifiedCurrency;
                    return this.currency_; 
                }
                else
                {
                      return this.currency_; 
                }
            }
            set
            {
                if (this.currency_ != value)
                {
                    this.currency_ = value;
                }
            }
        }
        #endregion
        
        public string currencyIDRef_ { get; set; }
        #region DeterminationMethod_
        private DeterminationMethod determinationMethod_;
        public DeterminationMethod DeterminationMethod_
        {
            get
            {
                if (this.determinationMethod_ != null)
                {
                    return this.determinationMethod_; 
                }
                else if (this.determinationMethodIDRef_ != null)
                {
                    determinationMethod_ = IDManager.getID(determinationMethodIDRef_) as DeterminationMethod;
                    return this.determinationMethod_; 
                }
                else
                {
                      return this.determinationMethod_; 
                }
            }
            set
            {
                if (this.determinationMethod_ != value)
                {
                    this.determinationMethod_ = value;
                }
            }
        }
        #endregion
        
        public string determinationMethodIDRef_ { get; set; }
        #region CurrencyReference_
        private IdentifiedCurrencyReference currencyReference_;
        public IdentifiedCurrencyReference CurrencyReference_
        {
            get
            {
                if (this.currencyReference_ != null)
                {
                    return this.currencyReference_; 
                }
                else if (this.currencyReferenceIDRef_ != null)
                {
                    currencyReference_ = IDManager.getID(currencyReferenceIDRef_) as IdentifiedCurrencyReference;
                    return this.currencyReference_; 
                }
                else
                {
                      return this.currencyReference_; 
                }
            }
            set
            {
                if (this.currencyReference_ != value)
                {
                    this.currencyReference_ = value;
                }
            }
        }
        #endregion
        
        public string currencyReferenceIDRef_ { get; set; }
        #region DividendFxTriggerDate_
        private DividendPaymentDate dividendFxTriggerDate_;
        public DividendPaymentDate DividendFxTriggerDate_
        {
            get
            {
                if (this.dividendFxTriggerDate_ != null)
                {
                    return this.dividendFxTriggerDate_; 
                }
                else if (this.dividendFxTriggerDateIDRef_ != null)
                {
                    dividendFxTriggerDate_ = IDManager.getID(dividendFxTriggerDateIDRef_) as DividendPaymentDate;
                    return this.dividendFxTriggerDate_; 
                }
                else
                {
                      return this.dividendFxTriggerDate_; 
                }
            }
            set
            {
                if (this.dividendFxTriggerDate_ != value)
                {
                    this.dividendFxTriggerDate_ = value;
                }
            }
        }
        #endregion
        
        public string dividendFxTriggerDateIDRef_ { get; set; }
        #region InterestAccrualsMethod_
        private InterestAccrualsCompoundingMethod interestAccrualsMethod_;
        public InterestAccrualsCompoundingMethod InterestAccrualsMethod_
        {
            get
            {
                if (this.interestAccrualsMethod_ != null)
                {
                    return this.interestAccrualsMethod_; 
                }
                else if (this.interestAccrualsMethodIDRef_ != null)
                {
                    interestAccrualsMethod_ = IDManager.getID(interestAccrualsMethodIDRef_) as InterestAccrualsCompoundingMethod;
                    return this.interestAccrualsMethod_; 
                }
                else
                {
                      return this.interestAccrualsMethod_; 
                }
            }
            set
            {
                if (this.interestAccrualsMethod_ != value)
                {
                    this.interestAccrualsMethod_ = value;
                }
            }
        }
        #endregion
        
        public string interestAccrualsMethodIDRef_ { get; set; }
        #region NumberOfIndexUnits_
        private NonNegativeDecimal numberOfIndexUnits_;
        public NonNegativeDecimal NumberOfIndexUnits_
        {
            get
            {
                if (this.numberOfIndexUnits_ != null)
                {
                    return this.numberOfIndexUnits_; 
                }
                else if (this.numberOfIndexUnitsIDRef_ != null)
                {
                    numberOfIndexUnits_ = IDManager.getID(numberOfIndexUnitsIDRef_) as NonNegativeDecimal;
                    return this.numberOfIndexUnits_; 
                }
                else
                {
                      return this.numberOfIndexUnits_; 
                }
            }
            set
            {
                if (this.numberOfIndexUnits_ != value)
                {
                    this.numberOfIndexUnits_ = value;
                }
            }
        }
        #endregion
        
        public string numberOfIndexUnitsIDRef_ { get; set; }
        #region DeclaredCashDividendPercentage_
        private NonNegativeDecimal declaredCashDividendPercentage_;
        public NonNegativeDecimal DeclaredCashDividendPercentage_
        {
            get
            {
                if (this.declaredCashDividendPercentage_ != null)
                {
                    return this.declaredCashDividendPercentage_; 
                }
                else if (this.declaredCashDividendPercentageIDRef_ != null)
                {
                    declaredCashDividendPercentage_ = IDManager.getID(declaredCashDividendPercentageIDRef_) as NonNegativeDecimal;
                    return this.declaredCashDividendPercentage_; 
                }
                else
                {
                      return this.declaredCashDividendPercentage_; 
                }
            }
            set
            {
                if (this.declaredCashDividendPercentage_ != value)
                {
                    this.declaredCashDividendPercentage_ = value;
                }
            }
        }
        #endregion
        
        public string declaredCashDividendPercentageIDRef_ { get; set; }
        #region DeclaredCashEquivalentDividendPercentage_
        private NonNegativeDecimal declaredCashEquivalentDividendPercentage_;
        public NonNegativeDecimal DeclaredCashEquivalentDividendPercentage_
        {
            get
            {
                if (this.declaredCashEquivalentDividendPercentage_ != null)
                {
                    return this.declaredCashEquivalentDividendPercentage_; 
                }
                else if (this.declaredCashEquivalentDividendPercentageIDRef_ != null)
                {
                    declaredCashEquivalentDividendPercentage_ = IDManager.getID(declaredCashEquivalentDividendPercentageIDRef_) as NonNegativeDecimal;
                    return this.declaredCashEquivalentDividendPercentage_; 
                }
                else
                {
                      return this.declaredCashEquivalentDividendPercentage_; 
                }
            }
            set
            {
                if (this.declaredCashEquivalentDividendPercentage_ != value)
                {
                    this.declaredCashEquivalentDividendPercentage_ = value;
                }
            }
        }
        #endregion
        
        public string declaredCashEquivalentDividendPercentageIDRef_ { get; set; }
        #region NonCashDividendTreatment_
        private NonCashDividendTreatmentEnum nonCashDividendTreatment_;
        public NonCashDividendTreatmentEnum NonCashDividendTreatment_
        {
            get
            {
                if (this.nonCashDividendTreatment_ != null)
                {
                    return this.nonCashDividendTreatment_; 
                }
                else if (this.nonCashDividendTreatmentIDRef_ != null)
                {
                    nonCashDividendTreatment_ = IDManager.getID(nonCashDividendTreatmentIDRef_) as NonCashDividendTreatmentEnum;
                    return this.nonCashDividendTreatment_; 
                }
                else
                {
                      return this.nonCashDividendTreatment_; 
                }
            }
            set
            {
                if (this.nonCashDividendTreatment_ != value)
                {
                    this.nonCashDividendTreatment_ = value;
                }
            }
        }
        #endregion
        
        public string nonCashDividendTreatmentIDRef_ { get; set; }
        #region DividendComposition_
        private DividendCompositionEnum dividendComposition_;
        public DividendCompositionEnum DividendComposition_
        {
            get
            {
                if (this.dividendComposition_ != null)
                {
                    return this.dividendComposition_; 
                }
                else if (this.dividendCompositionIDRef_ != null)
                {
                    dividendComposition_ = IDManager.getID(dividendCompositionIDRef_) as DividendCompositionEnum;
                    return this.dividendComposition_; 
                }
                else
                {
                      return this.dividendComposition_; 
                }
            }
            set
            {
                if (this.dividendComposition_ != value)
                {
                    this.dividendComposition_ = value;
                }
            }
        }
        #endregion
        
        public string dividendCompositionIDRef_ { get; set; }
        #region SpecialDividends_
        private XsdTypeBoolean specialDividends_;
        public XsdTypeBoolean SpecialDividends_
        {
            get
            {
                if (this.specialDividends_ != null)
                {
                    return this.specialDividends_; 
                }
                else if (this.specialDividendsIDRef_ != null)
                {
                    specialDividends_ = IDManager.getID(specialDividendsIDRef_) as XsdTypeBoolean;
                    return this.specialDividends_; 
                }
                else
                {
                      return this.specialDividends_; 
                }
            }
            set
            {
                if (this.specialDividends_ != value)
                {
                    this.specialDividends_ = value;
                }
            }
        }
        #endregion
        
        public string specialDividendsIDRef_ { get; set; }
        public string choiceStr_0;
        public string choiceStr_1;
        
    
        
    
    }
    
}

