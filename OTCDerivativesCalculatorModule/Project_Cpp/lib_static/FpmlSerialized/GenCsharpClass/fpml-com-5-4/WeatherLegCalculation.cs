using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class WeatherLegCalculation
    {
        public WeatherLegCalculation(XmlNode xmlNode)
        {
            XmlNodeList settlementLevelNodeList = xmlNode.SelectNodes("settlementLevel");
            if (settlementLevelNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementLevelNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementLevelIDRef = item.Attributes["id"].Name;
                        WeatherSettlementLevelEnum ob = WeatherSettlementLevelEnum();
                        IDManager.SetID(settlementLevelIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementLevelIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementLevel = new WeatherSettlementLevelEnum(item);
                    }
                }
            }
            
        
            XmlNodeList referenceLevelEqualsZeroNodeList = xmlNode.SelectNodes("referenceLevelEqualsZero");
            if (referenceLevelEqualsZeroNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in referenceLevelEqualsZeroNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        referenceLevelEqualsZeroIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(referenceLevelEqualsZeroIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        referenceLevelEqualsZeroIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        referenceLevelEqualsZero = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList calculationDateNodeList = xmlNode.SelectNodes("calculationDate");
            if (calculationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationDateIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(calculationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculationDate = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList businessDaysNodeList = xmlNode.SelectNodes("businessDays");
            if (businessDaysNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in businessDaysNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        businessDaysIDRef = item.Attributes["id"].Name;
                        BusinessCenter ob = BusinessCenter();
                        IDManager.SetID(businessDaysIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        businessDaysIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        businessDays = new BusinessCenter(item);
                    }
                }
            }
            
        
            XmlNodeList dataCorrectionNodeList = xmlNode.SelectNodes("dataCorrection");
            if (dataCorrectionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in dataCorrectionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        dataCorrectionIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(dataCorrectionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        dataCorrectionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        dataCorrection = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList correctionPeriodNodeList = xmlNode.SelectNodes("correctionPeriod");
            if (correctionPeriodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in correctionPeriodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        correctionPeriodIDRef = item.Attributes["id"].Name;
                        Period ob = Period();
                        IDManager.SetID(correctionPeriodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        correctionPeriodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        correctionPeriod = new Period(item);
                    }
                }
            }
            
        
            XmlNodeList maximumPaymentAmountNodeList = xmlNode.SelectNodes("maximumPaymentAmount");
            if (maximumPaymentAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumPaymentAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumPaymentAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(maximumPaymentAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumPaymentAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumPaymentAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList maximumTransactionPaymentAmountNodeList = xmlNode.SelectNodes("maximumTransactionPaymentAmount");
            if (maximumTransactionPaymentAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in maximumTransactionPaymentAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        maximumTransactionPaymentAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(maximumTransactionPaymentAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        maximumTransactionPaymentAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        maximumTransactionPaymentAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList roundingNodeList = xmlNode.SelectNodes("rounding");
            if (roundingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in roundingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        roundingIDRef = item.Attributes["id"].Name;
                        Rounding ob = Rounding();
                        IDManager.SetID(roundingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        roundingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        rounding = new Rounding(item);
                    }
                }
            }
            
        
        }
        
    
        #region SettlementLevel
        private WeatherSettlementLevelEnum settlementLevel;
        public WeatherSettlementLevelEnum SettlementLevel
        {
            get
            {
                if (this.settlementLevel != null)
                {
                    return this.settlementLevel; 
                }
                else if (this.settlementLevelIDRef != null)
                {
                    settlementLevel = IDManager.getID(settlementLevelIDRef) as WeatherSettlementLevelEnum;
                    return this.settlementLevel; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementLevel != value)
                {
                    this.settlementLevel = value;
                }
            }
        }
        #endregion
        
        public string WeatherSettlementLevelEnumIDRef { get; set; }
        #region ReferenceLevelEqualsZero
        private XsdTypeBoolean referenceLevelEqualsZero;
        public XsdTypeBoolean ReferenceLevelEqualsZero
        {
            get
            {
                if (this.referenceLevelEqualsZero != null)
                {
                    return this.referenceLevelEqualsZero; 
                }
                else if (this.referenceLevelEqualsZeroIDRef != null)
                {
                    referenceLevelEqualsZero = IDManager.getID(referenceLevelEqualsZeroIDRef) as XsdTypeBoolean;
                    return this.referenceLevelEqualsZero; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.referenceLevelEqualsZero != value)
                {
                    this.referenceLevelEqualsZero = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region CalculationDate
        private Period calculationDate;
        public Period CalculationDate
        {
            get
            {
                if (this.calculationDate != null)
                {
                    return this.calculationDate; 
                }
                else if (this.calculationDateIDRef != null)
                {
                    calculationDate = IDManager.getID(calculationDateIDRef) as Period;
                    return this.calculationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculationDate != value)
                {
                    this.calculationDate = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region BusinessDays
        private BusinessCenter businessDays;
        public BusinessCenter BusinessDays
        {
            get
            {
                if (this.businessDays != null)
                {
                    return this.businessDays; 
                }
                else if (this.businessDaysIDRef != null)
                {
                    businessDays = IDManager.getID(businessDaysIDRef) as BusinessCenter;
                    return this.businessDays; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.businessDays != value)
                {
                    this.businessDays = value;
                }
            }
        }
        #endregion
        
        public string BusinessCenterIDRef { get; set; }
        #region DataCorrection
        private XsdTypeBoolean dataCorrection;
        public XsdTypeBoolean DataCorrection
        {
            get
            {
                if (this.dataCorrection != null)
                {
                    return this.dataCorrection; 
                }
                else if (this.dataCorrectionIDRef != null)
                {
                    dataCorrection = IDManager.getID(dataCorrectionIDRef) as XsdTypeBoolean;
                    return this.dataCorrection; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.dataCorrection != value)
                {
                    this.dataCorrection = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region CorrectionPeriod
        private Period correctionPeriod;
        public Period CorrectionPeriod
        {
            get
            {
                if (this.correctionPeriod != null)
                {
                    return this.correctionPeriod; 
                }
                else if (this.correctionPeriodIDRef != null)
                {
                    correctionPeriod = IDManager.getID(correctionPeriodIDRef) as Period;
                    return this.correctionPeriod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.correctionPeriod != value)
                {
                    this.correctionPeriod = value;
                }
            }
        }
        #endregion
        
        public string PeriodIDRef { get; set; }
        #region MaximumPaymentAmount
        private NonNegativeMoney maximumPaymentAmount;
        public NonNegativeMoney MaximumPaymentAmount
        {
            get
            {
                if (this.maximumPaymentAmount != null)
                {
                    return this.maximumPaymentAmount; 
                }
                else if (this.maximumPaymentAmountIDRef != null)
                {
                    maximumPaymentAmount = IDManager.getID(maximumPaymentAmountIDRef) as NonNegativeMoney;
                    return this.maximumPaymentAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumPaymentAmount != value)
                {
                    this.maximumPaymentAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region MaximumTransactionPaymentAmount
        private NonNegativeMoney maximumTransactionPaymentAmount;
        public NonNegativeMoney MaximumTransactionPaymentAmount
        {
            get
            {
                if (this.maximumTransactionPaymentAmount != null)
                {
                    return this.maximumTransactionPaymentAmount; 
                }
                else if (this.maximumTransactionPaymentAmountIDRef != null)
                {
                    maximumTransactionPaymentAmount = IDManager.getID(maximumTransactionPaymentAmountIDRef) as NonNegativeMoney;
                    return this.maximumTransactionPaymentAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.maximumTransactionPaymentAmount != value)
                {
                    this.maximumTransactionPaymentAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region Rounding
        private Rounding rounding;
        public Rounding Rounding
        {
            get
            {
                if (this.rounding != null)
                {
                    return this.rounding; 
                }
                else if (this.roundingIDRef != null)
                {
                    rounding = IDManager.getID(roundingIDRef) as Rounding;
                    return this.rounding; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.rounding != value)
                {
                    this.rounding = value;
                }
            }
        }
        #endregion
        
        public string RoundingIDRef { get; set; }
        
    
        
    
    }
    
}

