using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class DividendSwapOptionTransactionSupplement
    {
        public DividendSwapOptionTransactionSupplement(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList equityPremiumNodeList = xmlNode.SelectNodes("equityPremium");
            if (equityPremiumNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityPremiumNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityPremiumIDRef = item.Attributes["id"].Name;
                        EquityPremium ob = EquityPremium();
                        IDManager.SetID(equityPremiumIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityPremiumIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityPremium = new EquityPremium(item);
                    }
                }
            }
            
        
            XmlNodeList equityExerciseNodeList = xmlNode.SelectNodes("equityExercise");
            if (equityExerciseNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in equityExerciseNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        equityExerciseIDRef = item.Attributes["id"].Name;
                        EquityExerciseValuationSettlement ob = EquityExerciseValuationSettlement();
                        IDManager.SetID(equityExerciseIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        equityExerciseIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        equityExercise = new EquityExerciseValuationSettlement(item);
                    }
                }
            }
            
        
            XmlNodeList exchangeLookAlikeNodeList = xmlNode.SelectNodes("exchangeLookAlike");
            if (exchangeLookAlikeNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in exchangeLookAlikeNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        exchangeLookAlikeIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(exchangeLookAlikeIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        exchangeLookAlikeIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        exchangeLookAlike = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList methodOfAdjustmentNodeList = xmlNode.SelectNodes("methodOfAdjustment");
            if (methodOfAdjustmentNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in methodOfAdjustmentNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        methodOfAdjustmentIDRef = item.Attributes["id"].Name;
                        MethodOfAdjustmentEnum ob = MethodOfAdjustmentEnum();
                        IDManager.SetID(methodOfAdjustmentIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        methodOfAdjustmentIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        methodOfAdjustment = new MethodOfAdjustmentEnum(item);
                    }
                }
            }
            
        
            XmlNodeList optionEntitlementNodeList = xmlNode.SelectNodes("optionEntitlement");
            if (optionEntitlementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in optionEntitlementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        optionEntitlementIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(optionEntitlementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        optionEntitlementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        optionEntitlement = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList multiplierNodeList = xmlNode.SelectNodes("multiplier");
            if (multiplierNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in multiplierNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        multiplierIDRef = item.Attributes["id"].Name;
                        PositiveDecimal ob = PositiveDecimal();
                        IDManager.SetID(multiplierIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        multiplierIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        multiplier = new PositiveDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList dividendSwapTransactionSupplementNodeList = xmlNode.SelectNodes("dividendSwapTransactionSupplement");
            if (dividendSwapTransactionSupplementNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dividendSwapTransactionSupplementNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dividendSwapTransactionSupplementIDRef = item.Attributes["id"].Name;
                        DividendSwapTransactionSupplement ob = DividendSwapTransactionSupplement();
                        IDManager.SetID(dividendSwapTransactionSupplementIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dividendSwapTransactionSupplementIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dividendSwapTransactionSupplement = new DividendSwapTransactionSupplement(item);
                    }
                }
            }
            
        
        }
        
    
        #region EquityPremium
        private EquityPremium equityPremium;
        public EquityPremium EquityPremium
        {
            get
            {
                if (this.equityPremium != null)
                {
                    return this.equityPremium; 
                }
                else if (this.equityPremiumIDRef != null)
                {
                    equityPremium = IDManager.getID(equityPremiumIDRef) as EquityPremium;
                    return this.equityPremium; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityPremium != value)
                {
                    this.equityPremium = value;
                }
            }
        }
        #endregion
        
        public string EquityPremiumIDRef { get; set; }
        #region EquityExercise
        private EquityExerciseValuationSettlement equityExercise;
        public EquityExerciseValuationSettlement EquityExercise
        {
            get
            {
                if (this.equityExercise != null)
                {
                    return this.equityExercise; 
                }
                else if (this.equityExerciseIDRef != null)
                {
                    equityExercise = IDManager.getID(equityExerciseIDRef) as EquityExerciseValuationSettlement;
                    return this.equityExercise; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.equityExercise != value)
                {
                    this.equityExercise = value;
                }
            }
        }
        #endregion
        
        public string EquityExerciseValuationSettlementIDRef { get; set; }
        #region ExchangeLookAlike
        private XsdTypeBoolean exchangeLookAlike;
        public XsdTypeBoolean ExchangeLookAlike
        {
            get
            {
                if (this.exchangeLookAlike != null)
                {
                    return this.exchangeLookAlike; 
                }
                else if (this.exchangeLookAlikeIDRef != null)
                {
                    exchangeLookAlike = IDManager.getID(exchangeLookAlikeIDRef) as XsdTypeBoolean;
                    return this.exchangeLookAlike; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.exchangeLookAlike != value)
                {
                    this.exchangeLookAlike = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region MethodOfAdjustment
        private MethodOfAdjustmentEnum methodOfAdjustment;
        public MethodOfAdjustmentEnum MethodOfAdjustment
        {
            get
            {
                if (this.methodOfAdjustment != null)
                {
                    return this.methodOfAdjustment; 
                }
                else if (this.methodOfAdjustmentIDRef != null)
                {
                    methodOfAdjustment = IDManager.getID(methodOfAdjustmentIDRef) as MethodOfAdjustmentEnum;
                    return this.methodOfAdjustment; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.methodOfAdjustment != value)
                {
                    this.methodOfAdjustment = value;
                }
            }
        }
        #endregion
        
        public string MethodOfAdjustmentEnumIDRef { get; set; }
        #region OptionEntitlement
        private PositiveDecimal optionEntitlement;
        public PositiveDecimal OptionEntitlement
        {
            get
            {
                if (this.optionEntitlement != null)
                {
                    return this.optionEntitlement; 
                }
                else if (this.optionEntitlementIDRef != null)
                {
                    optionEntitlement = IDManager.getID(optionEntitlementIDRef) as PositiveDecimal;
                    return this.optionEntitlement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.optionEntitlement != value)
                {
                    this.optionEntitlement = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region Multiplier
        private PositiveDecimal multiplier;
        public PositiveDecimal Multiplier
        {
            get
            {
                if (this.multiplier != null)
                {
                    return this.multiplier; 
                }
                else if (this.multiplierIDRef != null)
                {
                    multiplier = IDManager.getID(multiplierIDRef) as PositiveDecimal;
                    return this.multiplier; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.multiplier != value)
                {
                    this.multiplier = value;
                }
            }
        }
        #endregion
        
        public string PositiveDecimalIDRef { get; set; }
        #region DividendSwapTransactionSupplement
        private DividendSwapTransactionSupplement dividendSwapTransactionSupplement;
        public DividendSwapTransactionSupplement DividendSwapTransactionSupplement
        {
            get
            {
                if (this.dividendSwapTransactionSupplement != null)
                {
                    return this.dividendSwapTransactionSupplement; 
                }
                else if (this.dividendSwapTransactionSupplementIDRef != null)
                {
                    dividendSwapTransactionSupplement = IDManager.getID(dividendSwapTransactionSupplementIDRef) as DividendSwapTransactionSupplement;
                    return this.dividendSwapTransactionSupplement; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dividendSwapTransactionSupplement != value)
                {
                    this.dividendSwapTransactionSupplement = value;
                }
            }
        }
        #endregion
        
        public string DividendSwapTransactionSupplementIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

