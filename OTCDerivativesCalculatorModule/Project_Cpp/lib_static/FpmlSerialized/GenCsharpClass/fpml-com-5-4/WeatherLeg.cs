using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class WeatherLeg
    {
        public WeatherLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNodeList weatherIndexLevelNodeList = xmlNode.SelectNodes("weatherIndexLevel");
            if (weatherIndexLevelNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherIndexLevelNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherIndexLevelIDRef = item.Attributes["id"].Name;
                        WeatherIndex ob = WeatherIndex();
                        IDManager.SetID(weatherIndexLevelIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherIndexLevelIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherIndexLevel = new WeatherIndex(item);
                    }
                }
            }
            
        
            XmlNodeList weatherCalculationPeriodsNodeList = xmlNode.SelectNodes("weatherCalculationPeriods");
            if (weatherCalculationPeriodsNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherCalculationPeriodsNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherCalculationPeriodsIDRef = item.Attributes["id"].Name;
                        WeatherCalculationPeriods ob = WeatherCalculationPeriods();
                        IDManager.SetID(weatherCalculationPeriodsIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherCalculationPeriodsIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherCalculationPeriods = new WeatherCalculationPeriods(item);
                    }
                }
            }
            
        
            XmlNodeList weatherCalculationPeriodsReferenceNodeList = xmlNode.SelectNodes("weatherCalculationPeriodsReference");
            if (weatherCalculationPeriodsReferenceNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherCalculationPeriodsReferenceNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherCalculationPeriodsReferenceIDRef = item.Attributes["id"].Name;
                        CalculationPeriodsReference ob = CalculationPeriodsReference();
                        IDManager.SetID(weatherCalculationPeriodsReferenceIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherCalculationPeriodsReferenceIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherCalculationPeriodsReference = new CalculationPeriodsReference(item);
                    }
                }
            }
            
        
            XmlNodeList weatherNotionalAmountNodeList = xmlNode.SelectNodes("weatherNotionalAmount");
            if (weatherNotionalAmountNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherNotionalAmountNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherNotionalAmountIDRef = item.Attributes["id"].Name;
                        NonNegativeMoney ob = NonNegativeMoney();
                        IDManager.SetID(weatherNotionalAmountIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherNotionalAmountIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherNotionalAmount = new NonNegativeMoney(item);
                    }
                }
            }
            
        
            XmlNodeList calculationNodeList = xmlNode.SelectNodes("calculation");
            if (calculationNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in calculationNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        calculationIDRef = item.Attributes["id"].Name;
                        WeatherLegCalculation ob = WeatherLegCalculation();
                        IDManager.SetID(calculationIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        calculationIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        calculation = new WeatherLegCalculation(item);
                    }
                }
            }
            
        
            XmlNodeList paymentDatesNodeList = xmlNode.SelectNodes("paymentDates");
            if (paymentDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in paymentDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef = item.Attributes["id"].Name;
                        CommodityRelativePaymentDates ob = CommodityRelativePaymentDates();
                        IDManager.SetID(paymentDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        paymentDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        paymentDates = new CommodityRelativePaymentDates(item);
                    }
                }
            }
            
        
            XmlNodeList weatherIndexDataNodeList = xmlNode.SelectNodes("weatherIndexData");
            if (weatherIndexDataNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in weatherIndexDataNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherIndexDataIDRef = item.Attributes["id"].Name;
                        WeatherIndexData ob = WeatherIndexData();
                        IDManager.SetID(weatherIndexDataIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherIndexDataIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        weatherIndexData = new WeatherIndexData(item);
                    }
                }
            }
            
        
        }
        
    
        #region WeatherIndexLevel
        private WeatherIndex weatherIndexLevel;
        public WeatherIndex WeatherIndexLevel
        {
            get
            {
                if (this.weatherIndexLevel != null)
                {
                    return this.weatherIndexLevel; 
                }
                else if (this.weatherIndexLevelIDRef != null)
                {
                    weatherIndexLevel = IDManager.getID(weatherIndexLevelIDRef) as WeatherIndex;
                    return this.weatherIndexLevel; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherIndexLevel != value)
                {
                    this.weatherIndexLevel = value;
                }
            }
        }
        #endregion
        
        public string WeatherIndexIDRef { get; set; }
        #region WeatherCalculationPeriods
        private WeatherCalculationPeriods weatherCalculationPeriods;
        public WeatherCalculationPeriods WeatherCalculationPeriods
        {
            get
            {
                if (this.weatherCalculationPeriods != null)
                {
                    return this.weatherCalculationPeriods; 
                }
                else if (this.weatherCalculationPeriodsIDRef != null)
                {
                    weatherCalculationPeriods = IDManager.getID(weatherCalculationPeriodsIDRef) as WeatherCalculationPeriods;
                    return this.weatherCalculationPeriods; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherCalculationPeriods != value)
                {
                    this.weatherCalculationPeriods = value;
                }
            }
        }
        #endregion
        
        public string WeatherCalculationPeriodsIDRef { get; set; }
        #region WeatherCalculationPeriodsReference
        private CalculationPeriodsReference weatherCalculationPeriodsReference;
        public CalculationPeriodsReference WeatherCalculationPeriodsReference
        {
            get
            {
                if (this.weatherCalculationPeriodsReference != null)
                {
                    return this.weatherCalculationPeriodsReference; 
                }
                else if (this.weatherCalculationPeriodsReferenceIDRef != null)
                {
                    weatherCalculationPeriodsReference = IDManager.getID(weatherCalculationPeriodsReferenceIDRef) as CalculationPeriodsReference;
                    return this.weatherCalculationPeriodsReference; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherCalculationPeriodsReference != value)
                {
                    this.weatherCalculationPeriodsReference = value;
                }
            }
        }
        #endregion
        
        public string CalculationPeriodsReferenceIDRef { get; set; }
        #region WeatherNotionalAmount
        private NonNegativeMoney weatherNotionalAmount;
        public NonNegativeMoney WeatherNotionalAmount
        {
            get
            {
                if (this.weatherNotionalAmount != null)
                {
                    return this.weatherNotionalAmount; 
                }
                else if (this.weatherNotionalAmountIDRef != null)
                {
                    weatherNotionalAmount = IDManager.getID(weatherNotionalAmountIDRef) as NonNegativeMoney;
                    return this.weatherNotionalAmount; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherNotionalAmount != value)
                {
                    this.weatherNotionalAmount = value;
                }
            }
        }
        #endregion
        
        public string NonNegativeMoneyIDRef { get; set; }
        #region Calculation
        private WeatherLegCalculation calculation;
        public WeatherLegCalculation Calculation
        {
            get
            {
                if (this.calculation != null)
                {
                    return this.calculation; 
                }
                else if (this.calculationIDRef != null)
                {
                    calculation = IDManager.getID(calculationIDRef) as WeatherLegCalculation;
                    return this.calculation; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.calculation != value)
                {
                    this.calculation = value;
                }
            }
        }
        #endregion
        
        public string WeatherLegCalculationIDRef { get; set; }
        #region PaymentDates
        private CommodityRelativePaymentDates paymentDates;
        public CommodityRelativePaymentDates PaymentDates
        {
            get
            {
                if (this.paymentDates != null)
                {
                    return this.paymentDates; 
                }
                else if (this.paymentDatesIDRef != null)
                {
                    paymentDates = IDManager.getID(paymentDatesIDRef) as CommodityRelativePaymentDates;
                    return this.paymentDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.paymentDates != value)
                {
                    this.paymentDates = value;
                }
            }
        }
        #endregion
        
        public string CommodityRelativePaymentDatesIDRef { get; set; }
        #region WeatherIndexData
        private WeatherIndexData weatherIndexData;
        public WeatherIndexData WeatherIndexData
        {
            get
            {
                if (this.weatherIndexData != null)
                {
                    return this.weatherIndexData; 
                }
                else if (this.weatherIndexDataIDRef != null)
                {
                    weatherIndexData = IDManager.getID(weatherIndexDataIDRef) as WeatherIndexData;
                    return this.weatherIndexData; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherIndexData != value)
                {
                    this.weatherIndexData = value;
                }
            }
        }
        #endregion
        
        public string WeatherIndexDataIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

