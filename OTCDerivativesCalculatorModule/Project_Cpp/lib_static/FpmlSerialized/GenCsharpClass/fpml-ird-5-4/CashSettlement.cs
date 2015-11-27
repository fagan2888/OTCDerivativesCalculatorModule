using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CashSettlement
    {
        public CashSettlement(XmlNode xmlNode)
        {
            XmlNodeList cashSettlementValuationTimeNodeList = xmlNode.SelectNodes("cashSettlementValuationTime");
            if (cashSettlementValuationTimeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementValuationTimeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementValuationTimeIDRef = item.Attributes["id"].Name;
                        BusinessCenterTime ob = BusinessCenterTime();
                        IDManager.SetID(cashSettlementValuationTimeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementValuationTimeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlementValuationTime = new BusinessCenterTime(item);
                    }
                }
            }
            
        
            XmlNodeList cashSettlementValuationDateNodeList = xmlNode.SelectNodes("cashSettlementValuationDate");
            if (cashSettlementValuationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementValuationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementValuationDateIDRef = item.Attributes["id"].Name;
                        RelativeDateOffset ob = RelativeDateOffset();
                        IDManager.SetID(cashSettlementValuationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementValuationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlementValuationDate = new RelativeDateOffset(item);
                    }
                }
            }
            
        
            XmlNodeList cashSettlementPaymentDateNodeList = xmlNode.SelectNodes("cashSettlementPaymentDate");
            if (cashSettlementPaymentDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashSettlementPaymentDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashSettlementPaymentDateIDRef = item.Attributes["id"].Name;
                        CashSettlementPaymentDate ob = CashSettlementPaymentDate();
                        IDManager.SetID(cashSettlementPaymentDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashSettlementPaymentDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashSettlementPaymentDate = new CashSettlementPaymentDate(item);
                    }
                }
            }
            
        
            XmlNodeList cashPriceMethodNodeList = xmlNode.SelectNodes("cashPriceMethod");
            if (cashPriceMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashPriceMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashPriceMethodIDRef = item.Attributes["id"].Name;
                        CashPriceMethod ob = CashPriceMethod();
                        IDManager.SetID(cashPriceMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashPriceMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashPriceMethod = new CashPriceMethod(item);
                    }
                }
            }
            
        
            XmlNodeList cashPriceAlternateMethodNodeList = xmlNode.SelectNodes("cashPriceAlternateMethod");
            if (cashPriceAlternateMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in cashPriceAlternateMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        cashPriceAlternateMethodIDRef = item.Attributes["id"].Name;
                        CashPriceMethod ob = CashPriceMethod();
                        IDManager.SetID(cashPriceAlternateMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        cashPriceAlternateMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        cashPriceAlternateMethod = new CashPriceMethod(item);
                    }
                }
            }
            
        
            XmlNodeList parYieldCurveAdjustedMethodNodeList = xmlNode.SelectNodes("parYieldCurveAdjustedMethod");
            if (parYieldCurveAdjustedMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in parYieldCurveAdjustedMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        parYieldCurveAdjustedMethodIDRef = item.Attributes["id"].Name;
                        YieldCurveMethod ob = YieldCurveMethod();
                        IDManager.SetID(parYieldCurveAdjustedMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        parYieldCurveAdjustedMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        parYieldCurveAdjustedMethod = new YieldCurveMethod(item);
                    }
                }
            }
            
        
            XmlNodeList zeroCouponYieldAdjustedMethodNodeList = xmlNode.SelectNodes("zeroCouponYieldAdjustedMethod");
            if (zeroCouponYieldAdjustedMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in zeroCouponYieldAdjustedMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        zeroCouponYieldAdjustedMethodIDRef = item.Attributes["id"].Name;
                        YieldCurveMethod ob = YieldCurveMethod();
                        IDManager.SetID(zeroCouponYieldAdjustedMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        zeroCouponYieldAdjustedMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        zeroCouponYieldAdjustedMethod = new YieldCurveMethod(item);
                    }
                }
            }
            
        
            XmlNodeList parYieldCurveUnadjustedMethodNodeList = xmlNode.SelectNodes("parYieldCurveUnadjustedMethod");
            if (parYieldCurveUnadjustedMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in parYieldCurveUnadjustedMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        parYieldCurveUnadjustedMethodIDRef = item.Attributes["id"].Name;
                        YieldCurveMethod ob = YieldCurveMethod();
                        IDManager.SetID(parYieldCurveUnadjustedMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        parYieldCurveUnadjustedMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        parYieldCurveUnadjustedMethod = new YieldCurveMethod(item);
                    }
                }
            }
            
        
            XmlNodeList crossCurrencyMethodNodeList = xmlNode.SelectNodes("crossCurrencyMethod");
            if (crossCurrencyMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in crossCurrencyMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        crossCurrencyMethodIDRef = item.Attributes["id"].Name;
                        CrossCurrencyMethod ob = CrossCurrencyMethod();
                        IDManager.SetID(crossCurrencyMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        crossCurrencyMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        crossCurrencyMethod = new CrossCurrencyMethod(item);
                    }
                }
            }
            
        
            XmlNodeList collateralizedCashPriceMethodNodeList = xmlNode.SelectNodes("collateralizedCashPriceMethod");
            if (collateralizedCashPriceMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in collateralizedCashPriceMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        collateralizedCashPriceMethodIDRef = item.Attributes["id"].Name;
                        YieldCurveMethod ob = YieldCurveMethod();
                        IDManager.SetID(collateralizedCashPriceMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        collateralizedCashPriceMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        collateralizedCashPriceMethod = new YieldCurveMethod(item);
                    }
                }
            }
            
        
        }
        
    
        #region CashSettlementValuationTime
        private BusinessCenterTime cashSettlementValuationTime;
        public BusinessCenterTime CashSettlementValuationTime
        {
            get
            {
                if (this.cashSettlementValuationTime != null)
                {
                    return this.cashSettlementValuationTime; 
                }
                else if (this.cashSettlementValuationTimeIDRef != null)
                {
                    cashSettlementValuationTime = IDManager.getID(cashSettlementValuationTimeIDRef) as BusinessCenterTime;
                    return this.cashSettlementValuationTime; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlementValuationTime != value)
                {
                    this.cashSettlementValuationTime = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterTimeIDRef { get; set; }
        #region CashSettlementValuationDate
        private RelativeDateOffset cashSettlementValuationDate;
        public RelativeDateOffset CashSettlementValuationDate
        {
            get
            {
                if (this.cashSettlementValuationDate != null)
                {
                    return this.cashSettlementValuationDate; 
                }
                else if (this.cashSettlementValuationDateIDRef != null)
                {
                    cashSettlementValuationDate = IDManager.getID(cashSettlementValuationDateIDRef) as RelativeDateOffset;
                    return this.cashSettlementValuationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlementValuationDate != value)
                {
                    this.cashSettlementValuationDate = value;
                }
            }
        }
        #endregion
        
        public string RelativeDateOffsetIDRef { get; set; }
        #region CashSettlementPaymentDate
        private CashSettlementPaymentDate cashSettlementPaymentDate;
        public CashSettlementPaymentDate CashSettlementPaymentDate
        {
            get
            {
                if (this.cashSettlementPaymentDate != null)
                {
                    return this.cashSettlementPaymentDate; 
                }
                else if (this.cashSettlementPaymentDateIDRef != null)
                {
                    cashSettlementPaymentDate = IDManager.getID(cashSettlementPaymentDateIDRef) as CashSettlementPaymentDate;
                    return this.cashSettlementPaymentDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashSettlementPaymentDate != value)
                {
                    this.cashSettlementPaymentDate = value;
                }
            }
        }
        #endregion
        
        public string CashSettlementPaymentDateIDRef { get; set; }
        #region CashPriceMethod
        private CashPriceMethod cashPriceMethod;
        public CashPriceMethod CashPriceMethod
        {
            get
            {
                if (this.cashPriceMethod != null)
                {
                    return this.cashPriceMethod; 
                }
                else if (this.cashPriceMethodIDRef != null)
                {
                    cashPriceMethod = IDManager.getID(cashPriceMethodIDRef) as CashPriceMethod;
                    return this.cashPriceMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashPriceMethod != value)
                {
                    this.cashPriceMethod = value;
                }
            }
        }
        #endregion
        
        public string CashPriceMethodIDRef { get; set; }
        #region CashPriceAlternateMethod
        private CashPriceMethod cashPriceAlternateMethod;
        public CashPriceMethod CashPriceAlternateMethod
        {
            get
            {
                if (this.cashPriceAlternateMethod != null)
                {
                    return this.cashPriceAlternateMethod; 
                }
                else if (this.cashPriceAlternateMethodIDRef != null)
                {
                    cashPriceAlternateMethod = IDManager.getID(cashPriceAlternateMethodIDRef) as CashPriceMethod;
                    return this.cashPriceAlternateMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.cashPriceAlternateMethod != value)
                {
                    this.cashPriceAlternateMethod = value;
                }
            }
        }
        #endregion
        
        public string CashPriceMethodIDRef { get; set; }
        #region ParYieldCurveAdjustedMethod
        private YieldCurveMethod parYieldCurveAdjustedMethod;
        public YieldCurveMethod ParYieldCurveAdjustedMethod
        {
            get
            {
                if (this.parYieldCurveAdjustedMethod != null)
                {
                    return this.parYieldCurveAdjustedMethod; 
                }
                else if (this.parYieldCurveAdjustedMethodIDRef != null)
                {
                    parYieldCurveAdjustedMethod = IDManager.getID(parYieldCurveAdjustedMethodIDRef) as YieldCurveMethod;
                    return this.parYieldCurveAdjustedMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.parYieldCurveAdjustedMethod != value)
                {
                    this.parYieldCurveAdjustedMethod = value;
                }
            }
        }
        #endregion
        
        public string YieldCurveMethodIDRef { get; set; }
        #region ZeroCouponYieldAdjustedMethod
        private YieldCurveMethod zeroCouponYieldAdjustedMethod;
        public YieldCurveMethod ZeroCouponYieldAdjustedMethod
        {
            get
            {
                if (this.zeroCouponYieldAdjustedMethod != null)
                {
                    return this.zeroCouponYieldAdjustedMethod; 
                }
                else if (this.zeroCouponYieldAdjustedMethodIDRef != null)
                {
                    zeroCouponYieldAdjustedMethod = IDManager.getID(zeroCouponYieldAdjustedMethodIDRef) as YieldCurveMethod;
                    return this.zeroCouponYieldAdjustedMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.zeroCouponYieldAdjustedMethod != value)
                {
                    this.zeroCouponYieldAdjustedMethod = value;
                }
            }
        }
        #endregion
        
        public string YieldCurveMethodIDRef { get; set; }
        #region ParYieldCurveUnadjustedMethod
        private YieldCurveMethod parYieldCurveUnadjustedMethod;
        public YieldCurveMethod ParYieldCurveUnadjustedMethod
        {
            get
            {
                if (this.parYieldCurveUnadjustedMethod != null)
                {
                    return this.parYieldCurveUnadjustedMethod; 
                }
                else if (this.parYieldCurveUnadjustedMethodIDRef != null)
                {
                    parYieldCurveUnadjustedMethod = IDManager.getID(parYieldCurveUnadjustedMethodIDRef) as YieldCurveMethod;
                    return this.parYieldCurveUnadjustedMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.parYieldCurveUnadjustedMethod != value)
                {
                    this.parYieldCurveUnadjustedMethod = value;
                }
            }
        }
        #endregion
        
        public string YieldCurveMethodIDRef { get; set; }
        #region CrossCurrencyMethod
        private CrossCurrencyMethod crossCurrencyMethod;
        public CrossCurrencyMethod CrossCurrencyMethod
        {
            get
            {
                if (this.crossCurrencyMethod != null)
                {
                    return this.crossCurrencyMethod; 
                }
                else if (this.crossCurrencyMethodIDRef != null)
                {
                    crossCurrencyMethod = IDManager.getID(crossCurrencyMethodIDRef) as CrossCurrencyMethod;
                    return this.crossCurrencyMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.crossCurrencyMethod != value)
                {
                    this.crossCurrencyMethod = value;
                }
            }
        }
        #endregion
        
        public string CrossCurrencyMethodIDRef { get; set; }
        #region CollateralizedCashPriceMethod
        private YieldCurveMethod collateralizedCashPriceMethod;
        public YieldCurveMethod CollateralizedCashPriceMethod
        {
            get
            {
                if (this.collateralizedCashPriceMethod != null)
                {
                    return this.collateralizedCashPriceMethod; 
                }
                else if (this.collateralizedCashPriceMethodIDRef != null)
                {
                    collateralizedCashPriceMethod = IDManager.getID(collateralizedCashPriceMethodIDRef) as YieldCurveMethod;
                    return this.collateralizedCashPriceMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.collateralizedCashPriceMethod != value)
                {
                    this.collateralizedCashPriceMethod = value;
                }
            }
        }
        #endregion
        
        public string YieldCurveMethodIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

