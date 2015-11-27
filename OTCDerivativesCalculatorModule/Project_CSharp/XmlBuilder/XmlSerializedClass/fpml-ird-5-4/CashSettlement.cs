using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CashSettlement : ISerialized
    {
        public CashSettlement(XmlNode xmlNode)
        {
            XmlNode cashSettlementValuationTimeNode = xmlNode.SelectSingleNode("cashSettlementValuationTime");
            
            if (cashSettlementValuationTimeNode != null)
            {
                if (cashSettlementValuationTimeNode.Attributes["href"] != null || cashSettlementValuationTimeNode.Attributes["id"] != null) 
                {
                    if (cashSettlementValuationTimeNode.Attributes["id"] != null) 
                    {
                        cashSettlementValuationTimeIDRef_ = cashSettlementValuationTimeNode.Attributes["id"].Value;
                        BusinessCenterTime ob = new BusinessCenterTime(cashSettlementValuationTimeNode);
                        IDManager.SetID(cashSettlementValuationTimeIDRef_, ob);
                    }
                    else if (cashSettlementValuationTimeNode.Attributes["href"] != null)
                    {
                        cashSettlementValuationTimeIDRef_ = cashSettlementValuationTimeNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlementValuationTime_ = new BusinessCenterTime(cashSettlementValuationTimeNode);
                    }
                }
                else
                {
                    cashSettlementValuationTime_ = new BusinessCenterTime(cashSettlementValuationTimeNode);
                }
            }
            
        
            XmlNode cashSettlementValuationDateNode = xmlNode.SelectSingleNode("cashSettlementValuationDate");
            
            if (cashSettlementValuationDateNode != null)
            {
                if (cashSettlementValuationDateNode.Attributes["href"] != null || cashSettlementValuationDateNode.Attributes["id"] != null) 
                {
                    if (cashSettlementValuationDateNode.Attributes["id"] != null) 
                    {
                        cashSettlementValuationDateIDRef_ = cashSettlementValuationDateNode.Attributes["id"].Value;
                        RelativeDateOffset ob = new RelativeDateOffset(cashSettlementValuationDateNode);
                        IDManager.SetID(cashSettlementValuationDateIDRef_, ob);
                    }
                    else if (cashSettlementValuationDateNode.Attributes["href"] != null)
                    {
                        cashSettlementValuationDateIDRef_ = cashSettlementValuationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlementValuationDate_ = new RelativeDateOffset(cashSettlementValuationDateNode);
                    }
                }
                else
                {
                    cashSettlementValuationDate_ = new RelativeDateOffset(cashSettlementValuationDateNode);
                }
            }
            
        
            XmlNode cashSettlementPaymentDateNode = xmlNode.SelectSingleNode("cashSettlementPaymentDate");
            
            if (cashSettlementPaymentDateNode != null)
            {
                if (cashSettlementPaymentDateNode.Attributes["href"] != null || cashSettlementPaymentDateNode.Attributes["id"] != null) 
                {
                    if (cashSettlementPaymentDateNode.Attributes["id"] != null) 
                    {
                        cashSettlementPaymentDateIDRef_ = cashSettlementPaymentDateNode.Attributes["id"].Value;
                        CashSettlementPaymentDate ob = new CashSettlementPaymentDate(cashSettlementPaymentDateNode);
                        IDManager.SetID(cashSettlementPaymentDateIDRef_, ob);
                    }
                    else if (cashSettlementPaymentDateNode.Attributes["href"] != null)
                    {
                        cashSettlementPaymentDateIDRef_ = cashSettlementPaymentDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashSettlementPaymentDate_ = new CashSettlementPaymentDate(cashSettlementPaymentDateNode);
                    }
                }
                else
                {
                    cashSettlementPaymentDate_ = new CashSettlementPaymentDate(cashSettlementPaymentDateNode);
                }
            }
            
        
            XmlNode cashPriceMethodNode = xmlNode.SelectSingleNode("cashPriceMethod");
            
            if (cashPriceMethodNode != null)
            {
                if (cashPriceMethodNode.Attributes["href"] != null || cashPriceMethodNode.Attributes["id"] != null) 
                {
                    if (cashPriceMethodNode.Attributes["id"] != null) 
                    {
                        cashPriceMethodIDRef_ = cashPriceMethodNode.Attributes["id"].Value;
                        CashPriceMethod ob = new CashPriceMethod(cashPriceMethodNode);
                        IDManager.SetID(cashPriceMethodIDRef_, ob);
                    }
                    else if (cashPriceMethodNode.Attributes["href"] != null)
                    {
                        cashPriceMethodIDRef_ = cashPriceMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashPriceMethod_ = new CashPriceMethod(cashPriceMethodNode);
                    }
                }
                else
                {
                    cashPriceMethod_ = new CashPriceMethod(cashPriceMethodNode);
                }
            }
            
        
            XmlNode cashPriceAlternateMethodNode = xmlNode.SelectSingleNode("cashPriceAlternateMethod");
            
            if (cashPriceAlternateMethodNode != null)
            {
                if (cashPriceAlternateMethodNode.Attributes["href"] != null || cashPriceAlternateMethodNode.Attributes["id"] != null) 
                {
                    if (cashPriceAlternateMethodNode.Attributes["id"] != null) 
                    {
                        cashPriceAlternateMethodIDRef_ = cashPriceAlternateMethodNode.Attributes["id"].Value;
                        CashPriceMethod ob = new CashPriceMethod(cashPriceAlternateMethodNode);
                        IDManager.SetID(cashPriceAlternateMethodIDRef_, ob);
                    }
                    else if (cashPriceAlternateMethodNode.Attributes["href"] != null)
                    {
                        cashPriceAlternateMethodIDRef_ = cashPriceAlternateMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        cashPriceAlternateMethod_ = new CashPriceMethod(cashPriceAlternateMethodNode);
                    }
                }
                else
                {
                    cashPriceAlternateMethod_ = new CashPriceMethod(cashPriceAlternateMethodNode);
                }
            }
            
        
            XmlNode parYieldCurveAdjustedMethodNode = xmlNode.SelectSingleNode("parYieldCurveAdjustedMethod");
            
            if (parYieldCurveAdjustedMethodNode != null)
            {
                if (parYieldCurveAdjustedMethodNode.Attributes["href"] != null || parYieldCurveAdjustedMethodNode.Attributes["id"] != null) 
                {
                    if (parYieldCurveAdjustedMethodNode.Attributes["id"] != null) 
                    {
                        parYieldCurveAdjustedMethodIDRef_ = parYieldCurveAdjustedMethodNode.Attributes["id"].Value;
                        YieldCurveMethod ob = new YieldCurveMethod(parYieldCurveAdjustedMethodNode);
                        IDManager.SetID(parYieldCurveAdjustedMethodIDRef_, ob);
                    }
                    else if (parYieldCurveAdjustedMethodNode.Attributes["href"] != null)
                    {
                        parYieldCurveAdjustedMethodIDRef_ = parYieldCurveAdjustedMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        parYieldCurveAdjustedMethod_ = new YieldCurveMethod(parYieldCurveAdjustedMethodNode);
                    }
                }
                else
                {
                    parYieldCurveAdjustedMethod_ = new YieldCurveMethod(parYieldCurveAdjustedMethodNode);
                }
            }
            
        
            XmlNode zeroCouponYieldAdjustedMethodNode = xmlNode.SelectSingleNode("zeroCouponYieldAdjustedMethod");
            
            if (zeroCouponYieldAdjustedMethodNode != null)
            {
                if (zeroCouponYieldAdjustedMethodNode.Attributes["href"] != null || zeroCouponYieldAdjustedMethodNode.Attributes["id"] != null) 
                {
                    if (zeroCouponYieldAdjustedMethodNode.Attributes["id"] != null) 
                    {
                        zeroCouponYieldAdjustedMethodIDRef_ = zeroCouponYieldAdjustedMethodNode.Attributes["id"].Value;
                        YieldCurveMethod ob = new YieldCurveMethod(zeroCouponYieldAdjustedMethodNode);
                        IDManager.SetID(zeroCouponYieldAdjustedMethodIDRef_, ob);
                    }
                    else if (zeroCouponYieldAdjustedMethodNode.Attributes["href"] != null)
                    {
                        zeroCouponYieldAdjustedMethodIDRef_ = zeroCouponYieldAdjustedMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        zeroCouponYieldAdjustedMethod_ = new YieldCurveMethod(zeroCouponYieldAdjustedMethodNode);
                    }
                }
                else
                {
                    zeroCouponYieldAdjustedMethod_ = new YieldCurveMethod(zeroCouponYieldAdjustedMethodNode);
                }
            }
            
        
            XmlNode parYieldCurveUnadjustedMethodNode = xmlNode.SelectSingleNode("parYieldCurveUnadjustedMethod");
            
            if (parYieldCurveUnadjustedMethodNode != null)
            {
                if (parYieldCurveUnadjustedMethodNode.Attributes["href"] != null || parYieldCurveUnadjustedMethodNode.Attributes["id"] != null) 
                {
                    if (parYieldCurveUnadjustedMethodNode.Attributes["id"] != null) 
                    {
                        parYieldCurveUnadjustedMethodIDRef_ = parYieldCurveUnadjustedMethodNode.Attributes["id"].Value;
                        YieldCurveMethod ob = new YieldCurveMethod(parYieldCurveUnadjustedMethodNode);
                        IDManager.SetID(parYieldCurveUnadjustedMethodIDRef_, ob);
                    }
                    else if (parYieldCurveUnadjustedMethodNode.Attributes["href"] != null)
                    {
                        parYieldCurveUnadjustedMethodIDRef_ = parYieldCurveUnadjustedMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        parYieldCurveUnadjustedMethod_ = new YieldCurveMethod(parYieldCurveUnadjustedMethodNode);
                    }
                }
                else
                {
                    parYieldCurveUnadjustedMethod_ = new YieldCurveMethod(parYieldCurveUnadjustedMethodNode);
                }
            }
            
        
            XmlNode crossCurrencyMethodNode = xmlNode.SelectSingleNode("crossCurrencyMethod");
            
            if (crossCurrencyMethodNode != null)
            {
                if (crossCurrencyMethodNode.Attributes["href"] != null || crossCurrencyMethodNode.Attributes["id"] != null) 
                {
                    if (crossCurrencyMethodNode.Attributes["id"] != null) 
                    {
                        crossCurrencyMethodIDRef_ = crossCurrencyMethodNode.Attributes["id"].Value;
                        CrossCurrencyMethod ob = new CrossCurrencyMethod(crossCurrencyMethodNode);
                        IDManager.SetID(crossCurrencyMethodIDRef_, ob);
                    }
                    else if (crossCurrencyMethodNode.Attributes["href"] != null)
                    {
                        crossCurrencyMethodIDRef_ = crossCurrencyMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        crossCurrencyMethod_ = new CrossCurrencyMethod(crossCurrencyMethodNode);
                    }
                }
                else
                {
                    crossCurrencyMethod_ = new CrossCurrencyMethod(crossCurrencyMethodNode);
                }
            }
            
        
            XmlNode collateralizedCashPriceMethodNode = xmlNode.SelectSingleNode("collateralizedCashPriceMethod");
            
            if (collateralizedCashPriceMethodNode != null)
            {
                if (collateralizedCashPriceMethodNode.Attributes["href"] != null || collateralizedCashPriceMethodNode.Attributes["id"] != null) 
                {
                    if (collateralizedCashPriceMethodNode.Attributes["id"] != null) 
                    {
                        collateralizedCashPriceMethodIDRef_ = collateralizedCashPriceMethodNode.Attributes["id"].Value;
                        YieldCurveMethod ob = new YieldCurveMethod(collateralizedCashPriceMethodNode);
                        IDManager.SetID(collateralizedCashPriceMethodIDRef_, ob);
                    }
                    else if (collateralizedCashPriceMethodNode.Attributes["href"] != null)
                    {
                        collateralizedCashPriceMethodIDRef_ = collateralizedCashPriceMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        collateralizedCashPriceMethod_ = new YieldCurveMethod(collateralizedCashPriceMethodNode);
                    }
                }
                else
                {
                    collateralizedCashPriceMethod_ = new YieldCurveMethod(collateralizedCashPriceMethodNode);
                }
            }
            
        
        }
        
    
        #region CashSettlementValuationTime_
        private BusinessCenterTime cashSettlementValuationTime_;
        public BusinessCenterTime CashSettlementValuationTime_
        {
            get
            {
                if (this.cashSettlementValuationTime_ != null)
                {
                    return this.cashSettlementValuationTime_; 
                }
                else if (this.cashSettlementValuationTimeIDRef_ != null)
                {
                    cashSettlementValuationTime_ = IDManager.getID(cashSettlementValuationTimeIDRef_) as BusinessCenterTime;
                    return this.cashSettlementValuationTime_; 
                }
                else
                {
                      return this.cashSettlementValuationTime_; 
                }
            }
            set
            {
                if (this.cashSettlementValuationTime_ != value)
                {
                    this.cashSettlementValuationTime_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementValuationTimeIDRef_ { get; set; }
        #region CashSettlementValuationDate_
        private RelativeDateOffset cashSettlementValuationDate_;
        public RelativeDateOffset CashSettlementValuationDate_
        {
            get
            {
                if (this.cashSettlementValuationDate_ != null)
                {
                    return this.cashSettlementValuationDate_; 
                }
                else if (this.cashSettlementValuationDateIDRef_ != null)
                {
                    cashSettlementValuationDate_ = IDManager.getID(cashSettlementValuationDateIDRef_) as RelativeDateOffset;
                    return this.cashSettlementValuationDate_; 
                }
                else
                {
                      return this.cashSettlementValuationDate_; 
                }
            }
            set
            {
                if (this.cashSettlementValuationDate_ != value)
                {
                    this.cashSettlementValuationDate_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementValuationDateIDRef_ { get; set; }
        #region CashSettlementPaymentDate_
        private CashSettlementPaymentDate cashSettlementPaymentDate_;
        public CashSettlementPaymentDate CashSettlementPaymentDate_
        {
            get
            {
                if (this.cashSettlementPaymentDate_ != null)
                {
                    return this.cashSettlementPaymentDate_; 
                }
                else if (this.cashSettlementPaymentDateIDRef_ != null)
                {
                    cashSettlementPaymentDate_ = IDManager.getID(cashSettlementPaymentDateIDRef_) as CashSettlementPaymentDate;
                    return this.cashSettlementPaymentDate_; 
                }
                else
                {
                      return this.cashSettlementPaymentDate_; 
                }
            }
            set
            {
                if (this.cashSettlementPaymentDate_ != value)
                {
                    this.cashSettlementPaymentDate_ = value;
                }
            }
        }
        #endregion
        
        public string cashSettlementPaymentDateIDRef_ { get; set; }
        #region CashPriceMethod_
        private CashPriceMethod cashPriceMethod_;
        public CashPriceMethod CashPriceMethod_
        {
            get
            {
                if (this.cashPriceMethod_ != null)
                {
                    return this.cashPriceMethod_; 
                }
                else if (this.cashPriceMethodIDRef_ != null)
                {
                    cashPriceMethod_ = IDManager.getID(cashPriceMethodIDRef_) as CashPriceMethod;
                    return this.cashPriceMethod_; 
                }
                else
                {
                      return this.cashPriceMethod_; 
                }
            }
            set
            {
                if (this.cashPriceMethod_ != value)
                {
                    this.cashPriceMethod_ = value;
                }
            }
        }
        #endregion
        
        public string cashPriceMethodIDRef_ { get; set; }
        #region CashPriceAlternateMethod_
        private CashPriceMethod cashPriceAlternateMethod_;
        public CashPriceMethod CashPriceAlternateMethod_
        {
            get
            {
                if (this.cashPriceAlternateMethod_ != null)
                {
                    return this.cashPriceAlternateMethod_; 
                }
                else if (this.cashPriceAlternateMethodIDRef_ != null)
                {
                    cashPriceAlternateMethod_ = IDManager.getID(cashPriceAlternateMethodIDRef_) as CashPriceMethod;
                    return this.cashPriceAlternateMethod_; 
                }
                else
                {
                      return this.cashPriceAlternateMethod_; 
                }
            }
            set
            {
                if (this.cashPriceAlternateMethod_ != value)
                {
                    this.cashPriceAlternateMethod_ = value;
                }
            }
        }
        #endregion
        
        public string cashPriceAlternateMethodIDRef_ { get; set; }
        #region ParYieldCurveAdjustedMethod_
        private YieldCurveMethod parYieldCurveAdjustedMethod_;
        public YieldCurveMethod ParYieldCurveAdjustedMethod_
        {
            get
            {
                if (this.parYieldCurveAdjustedMethod_ != null)
                {
                    return this.parYieldCurveAdjustedMethod_; 
                }
                else if (this.parYieldCurveAdjustedMethodIDRef_ != null)
                {
                    parYieldCurveAdjustedMethod_ = IDManager.getID(parYieldCurveAdjustedMethodIDRef_) as YieldCurveMethod;
                    return this.parYieldCurveAdjustedMethod_; 
                }
                else
                {
                      return this.parYieldCurveAdjustedMethod_; 
                }
            }
            set
            {
                if (this.parYieldCurveAdjustedMethod_ != value)
                {
                    this.parYieldCurveAdjustedMethod_ = value;
                }
            }
        }
        #endregion
        
        public string parYieldCurveAdjustedMethodIDRef_ { get; set; }
        #region ZeroCouponYieldAdjustedMethod_
        private YieldCurveMethod zeroCouponYieldAdjustedMethod_;
        public YieldCurveMethod ZeroCouponYieldAdjustedMethod_
        {
            get
            {
                if (this.zeroCouponYieldAdjustedMethod_ != null)
                {
                    return this.zeroCouponYieldAdjustedMethod_; 
                }
                else if (this.zeroCouponYieldAdjustedMethodIDRef_ != null)
                {
                    zeroCouponYieldAdjustedMethod_ = IDManager.getID(zeroCouponYieldAdjustedMethodIDRef_) as YieldCurveMethod;
                    return this.zeroCouponYieldAdjustedMethod_; 
                }
                else
                {
                      return this.zeroCouponYieldAdjustedMethod_; 
                }
            }
            set
            {
                if (this.zeroCouponYieldAdjustedMethod_ != value)
                {
                    this.zeroCouponYieldAdjustedMethod_ = value;
                }
            }
        }
        #endregion
        
        public string zeroCouponYieldAdjustedMethodIDRef_ { get; set; }
        #region ParYieldCurveUnadjustedMethod_
        private YieldCurveMethod parYieldCurveUnadjustedMethod_;
        public YieldCurveMethod ParYieldCurveUnadjustedMethod_
        {
            get
            {
                if (this.parYieldCurveUnadjustedMethod_ != null)
                {
                    return this.parYieldCurveUnadjustedMethod_; 
                }
                else if (this.parYieldCurveUnadjustedMethodIDRef_ != null)
                {
                    parYieldCurveUnadjustedMethod_ = IDManager.getID(parYieldCurveUnadjustedMethodIDRef_) as YieldCurveMethod;
                    return this.parYieldCurveUnadjustedMethod_; 
                }
                else
                {
                      return this.parYieldCurveUnadjustedMethod_; 
                }
            }
            set
            {
                if (this.parYieldCurveUnadjustedMethod_ != value)
                {
                    this.parYieldCurveUnadjustedMethod_ = value;
                }
            }
        }
        #endregion
        
        public string parYieldCurveUnadjustedMethodIDRef_ { get; set; }
        #region CrossCurrencyMethod_
        private CrossCurrencyMethod crossCurrencyMethod_;
        public CrossCurrencyMethod CrossCurrencyMethod_
        {
            get
            {
                if (this.crossCurrencyMethod_ != null)
                {
                    return this.crossCurrencyMethod_; 
                }
                else if (this.crossCurrencyMethodIDRef_ != null)
                {
                    crossCurrencyMethod_ = IDManager.getID(crossCurrencyMethodIDRef_) as CrossCurrencyMethod;
                    return this.crossCurrencyMethod_; 
                }
                else
                {
                      return this.crossCurrencyMethod_; 
                }
            }
            set
            {
                if (this.crossCurrencyMethod_ != value)
                {
                    this.crossCurrencyMethod_ = value;
                }
            }
        }
        #endregion
        
        public string crossCurrencyMethodIDRef_ { get; set; }
        #region CollateralizedCashPriceMethod_
        private YieldCurveMethod collateralizedCashPriceMethod_;
        public YieldCurveMethod CollateralizedCashPriceMethod_
        {
            get
            {
                if (this.collateralizedCashPriceMethod_ != null)
                {
                    return this.collateralizedCashPriceMethod_; 
                }
                else if (this.collateralizedCashPriceMethodIDRef_ != null)
                {
                    collateralizedCashPriceMethod_ = IDManager.getID(collateralizedCashPriceMethodIDRef_) as YieldCurveMethod;
                    return this.collateralizedCashPriceMethod_; 
                }
                else
                {
                      return this.collateralizedCashPriceMethod_; 
                }
            }
            set
            {
                if (this.collateralizedCashPriceMethod_ != value)
                {
                    this.collateralizedCashPriceMethod_ = value;
                }
            }
        }
        #endregion
        
        public string collateralizedCashPriceMethodIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

