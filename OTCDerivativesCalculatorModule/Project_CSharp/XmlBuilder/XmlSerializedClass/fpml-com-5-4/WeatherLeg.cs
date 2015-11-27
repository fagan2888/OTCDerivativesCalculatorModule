using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class WeatherLeg : FinancialSwapLeg
    {
        public WeatherLeg(XmlNode xmlNode)
        : base(xmlNode)
        {
            XmlNode weatherIndexLevelNode = xmlNode.SelectSingleNode("weatherIndexLevel");
            
            if (weatherIndexLevelNode != null)
            {
                if (weatherIndexLevelNode.Attributes["href"] != null || weatherIndexLevelNode.Attributes["id"] != null) 
                {
                    if (weatherIndexLevelNode.Attributes["id"] != null) 
                    {
                        weatherIndexLevelIDRef_ = weatherIndexLevelNode.Attributes["id"].Value;
                        WeatherIndex ob = new WeatherIndex(weatherIndexLevelNode);
                        IDManager.SetID(weatherIndexLevelIDRef_, ob);
                    }
                    else if (weatherIndexLevelNode.Attributes["href"] != null)
                    {
                        weatherIndexLevelIDRef_ = weatherIndexLevelNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherIndexLevel_ = new WeatherIndex(weatherIndexLevelNode);
                    }
                }
                else
                {
                    weatherIndexLevel_ = new WeatherIndex(weatherIndexLevelNode);
                }
            }
            
        
            XmlNode weatherCalculationPeriodsNode = xmlNode.SelectSingleNode("weatherCalculationPeriods");
            
            if (weatherCalculationPeriodsNode != null)
            {
                if (weatherCalculationPeriodsNode.Attributes["href"] != null || weatherCalculationPeriodsNode.Attributes["id"] != null) 
                {
                    if (weatherCalculationPeriodsNode.Attributes["id"] != null) 
                    {
                        weatherCalculationPeriodsIDRef_ = weatherCalculationPeriodsNode.Attributes["id"].Value;
                        WeatherCalculationPeriods ob = new WeatherCalculationPeriods(weatherCalculationPeriodsNode);
                        IDManager.SetID(weatherCalculationPeriodsIDRef_, ob);
                    }
                    else if (weatherCalculationPeriodsNode.Attributes["href"] != null)
                    {
                        weatherCalculationPeriodsIDRef_ = weatherCalculationPeriodsNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherCalculationPeriods_ = new WeatherCalculationPeriods(weatherCalculationPeriodsNode);
                    }
                }
                else
                {
                    weatherCalculationPeriods_ = new WeatherCalculationPeriods(weatherCalculationPeriodsNode);
                }
            }
            
        
            XmlNode weatherCalculationPeriodsReferenceNode = xmlNode.SelectSingleNode("weatherCalculationPeriodsReference");
            
            if (weatherCalculationPeriodsReferenceNode != null)
            {
                if (weatherCalculationPeriodsReferenceNode.Attributes["href"] != null || weatherCalculationPeriodsReferenceNode.Attributes["id"] != null) 
                {
                    if (weatherCalculationPeriodsReferenceNode.Attributes["id"] != null) 
                    {
                        weatherCalculationPeriodsReferenceIDRef_ = weatherCalculationPeriodsReferenceNode.Attributes["id"].Value;
                        CalculationPeriodsReference ob = new CalculationPeriodsReference(weatherCalculationPeriodsReferenceNode);
                        IDManager.SetID(weatherCalculationPeriodsReferenceIDRef_, ob);
                    }
                    else if (weatherCalculationPeriodsReferenceNode.Attributes["href"] != null)
                    {
                        weatherCalculationPeriodsReferenceIDRef_ = weatherCalculationPeriodsReferenceNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherCalculationPeriodsReference_ = new CalculationPeriodsReference(weatherCalculationPeriodsReferenceNode);
                    }
                }
                else
                {
                    weatherCalculationPeriodsReference_ = new CalculationPeriodsReference(weatherCalculationPeriodsReferenceNode);
                }
            }
            
        
            XmlNode weatherNotionalAmountNode = xmlNode.SelectSingleNode("weatherNotionalAmount");
            
            if (weatherNotionalAmountNode != null)
            {
                if (weatherNotionalAmountNode.Attributes["href"] != null || weatherNotionalAmountNode.Attributes["id"] != null) 
                {
                    if (weatherNotionalAmountNode.Attributes["id"] != null) 
                    {
                        weatherNotionalAmountIDRef_ = weatherNotionalAmountNode.Attributes["id"].Value;
                        NonNegativeMoney ob = new NonNegativeMoney(weatherNotionalAmountNode);
                        IDManager.SetID(weatherNotionalAmountIDRef_, ob);
                    }
                    else if (weatherNotionalAmountNode.Attributes["href"] != null)
                    {
                        weatherNotionalAmountIDRef_ = weatherNotionalAmountNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherNotionalAmount_ = new NonNegativeMoney(weatherNotionalAmountNode);
                    }
                }
                else
                {
                    weatherNotionalAmount_ = new NonNegativeMoney(weatherNotionalAmountNode);
                }
            }
            
        
            XmlNode calculationNode = xmlNode.SelectSingleNode("calculation");
            
            if (calculationNode != null)
            {
                if (calculationNode.Attributes["href"] != null || calculationNode.Attributes["id"] != null) 
                {
                    if (calculationNode.Attributes["id"] != null) 
                    {
                        calculationIDRef_ = calculationNode.Attributes["id"].Value;
                        WeatherLegCalculation ob = new WeatherLegCalculation(calculationNode);
                        IDManager.SetID(calculationIDRef_, ob);
                    }
                    else if (calculationNode.Attributes["href"] != null)
                    {
                        calculationIDRef_ = calculationNode.Attributes["href"].Value;
                    }
                    else
                    {
                        calculation_ = new WeatherLegCalculation(calculationNode);
                    }
                }
                else
                {
                    calculation_ = new WeatherLegCalculation(calculationNode);
                }
            }
            
        
            XmlNode paymentDatesNode = xmlNode.SelectSingleNode("paymentDates");
            
            if (paymentDatesNode != null)
            {
                if (paymentDatesNode.Attributes["href"] != null || paymentDatesNode.Attributes["id"] != null) 
                {
                    if (paymentDatesNode.Attributes["id"] != null) 
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["id"].Value;
                        CommodityRelativePaymentDates ob = new CommodityRelativePaymentDates(paymentDatesNode);
                        IDManager.SetID(paymentDatesIDRef_, ob);
                    }
                    else if (paymentDatesNode.Attributes["href"] != null)
                    {
                        paymentDatesIDRef_ = paymentDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        paymentDates_ = new CommodityRelativePaymentDates(paymentDatesNode);
                    }
                }
                else
                {
                    paymentDates_ = new CommodityRelativePaymentDates(paymentDatesNode);
                }
            }
            
        
            XmlNode weatherIndexDataNode = xmlNode.SelectSingleNode("weatherIndexData");
            
            if (weatherIndexDataNode != null)
            {
                if (weatherIndexDataNode.Attributes["href"] != null || weatherIndexDataNode.Attributes["id"] != null) 
                {
                    if (weatherIndexDataNode.Attributes["id"] != null) 
                    {
                        weatherIndexDataIDRef_ = weatherIndexDataNode.Attributes["id"].Value;
                        WeatherIndexData ob = new WeatherIndexData(weatherIndexDataNode);
                        IDManager.SetID(weatherIndexDataIDRef_, ob);
                    }
                    else if (weatherIndexDataNode.Attributes["href"] != null)
                    {
                        weatherIndexDataIDRef_ = weatherIndexDataNode.Attributes["href"].Value;
                    }
                    else
                    {
                        weatherIndexData_ = new WeatherIndexData(weatherIndexDataNode);
                    }
                }
                else
                {
                    weatherIndexData_ = new WeatherIndexData(weatherIndexDataNode);
                }
            }
            
        
        }
        
    
        #region WeatherIndexLevel_
        private WeatherIndex weatherIndexLevel_;
        public WeatherIndex WeatherIndexLevel_
        {
            get
            {
                if (this.weatherIndexLevel_ != null)
                {
                    return this.weatherIndexLevel_; 
                }
                else if (this.weatherIndexLevelIDRef_ != null)
                {
                    weatherIndexLevel_ = IDManager.getID(weatherIndexLevelIDRef_) as WeatherIndex;
                    return this.weatherIndexLevel_; 
                }
                else
                {
                      return this.weatherIndexLevel_; 
                }
            }
            set
            {
                if (this.weatherIndexLevel_ != value)
                {
                    this.weatherIndexLevel_ = value;
                }
            }
        }
        #endregion
        
        public string weatherIndexLevelIDRef_ { get; set; }
        #region WeatherCalculationPeriods_
        private WeatherCalculationPeriods weatherCalculationPeriods_;
        public WeatherCalculationPeriods WeatherCalculationPeriods_
        {
            get
            {
                if (this.weatherCalculationPeriods_ != null)
                {
                    return this.weatherCalculationPeriods_; 
                }
                else if (this.weatherCalculationPeriodsIDRef_ != null)
                {
                    weatherCalculationPeriods_ = IDManager.getID(weatherCalculationPeriodsIDRef_) as WeatherCalculationPeriods;
                    return this.weatherCalculationPeriods_; 
                }
                else
                {
                      return this.weatherCalculationPeriods_; 
                }
            }
            set
            {
                if (this.weatherCalculationPeriods_ != value)
                {
                    this.weatherCalculationPeriods_ = value;
                }
            }
        }
        #endregion
        
        public string weatherCalculationPeriodsIDRef_ { get; set; }
        #region WeatherCalculationPeriodsReference_
        private CalculationPeriodsReference weatherCalculationPeriodsReference_;
        public CalculationPeriodsReference WeatherCalculationPeriodsReference_
        {
            get
            {
                if (this.weatherCalculationPeriodsReference_ != null)
                {
                    return this.weatherCalculationPeriodsReference_; 
                }
                else if (this.weatherCalculationPeriodsReferenceIDRef_ != null)
                {
                    weatherCalculationPeriodsReference_ = IDManager.getID(weatherCalculationPeriodsReferenceIDRef_) as CalculationPeriodsReference;
                    return this.weatherCalculationPeriodsReference_; 
                }
                else
                {
                      return this.weatherCalculationPeriodsReference_; 
                }
            }
            set
            {
                if (this.weatherCalculationPeriodsReference_ != value)
                {
                    this.weatherCalculationPeriodsReference_ = value;
                }
            }
        }
        #endregion
        
        public string weatherCalculationPeriodsReferenceIDRef_ { get; set; }
        #region WeatherNotionalAmount_
        private NonNegativeMoney weatherNotionalAmount_;
        public NonNegativeMoney WeatherNotionalAmount_
        {
            get
            {
                if (this.weatherNotionalAmount_ != null)
                {
                    return this.weatherNotionalAmount_; 
                }
                else if (this.weatherNotionalAmountIDRef_ != null)
                {
                    weatherNotionalAmount_ = IDManager.getID(weatherNotionalAmountIDRef_) as NonNegativeMoney;
                    return this.weatherNotionalAmount_; 
                }
                else
                {
                      return this.weatherNotionalAmount_; 
                }
            }
            set
            {
                if (this.weatherNotionalAmount_ != value)
                {
                    this.weatherNotionalAmount_ = value;
                }
            }
        }
        #endregion
        
        public string weatherNotionalAmountIDRef_ { get; set; }
        #region Calculation_
        private WeatherLegCalculation calculation_;
        public WeatherLegCalculation Calculation_
        {
            get
            {
                if (this.calculation_ != null)
                {
                    return this.calculation_; 
                }
                else if (this.calculationIDRef_ != null)
                {
                    calculation_ = IDManager.getID(calculationIDRef_) as WeatherLegCalculation;
                    return this.calculation_; 
                }
                else
                {
                      return this.calculation_; 
                }
            }
            set
            {
                if (this.calculation_ != value)
                {
                    this.calculation_ = value;
                }
            }
        }
        #endregion
        
        public string calculationIDRef_ { get; set; }
        #region PaymentDates_
        private CommodityRelativePaymentDates paymentDates_;
        public CommodityRelativePaymentDates PaymentDates_
        {
            get
            {
                if (this.paymentDates_ != null)
                {
                    return this.paymentDates_; 
                }
                else if (this.paymentDatesIDRef_ != null)
                {
                    paymentDates_ = IDManager.getID(paymentDatesIDRef_) as CommodityRelativePaymentDates;
                    return this.paymentDates_; 
                }
                else
                {
                      return this.paymentDates_; 
                }
            }
            set
            {
                if (this.paymentDates_ != value)
                {
                    this.paymentDates_ = value;
                }
            }
        }
        #endregion
        
        public string paymentDatesIDRef_ { get; set; }
        #region WeatherIndexData_
        private WeatherIndexData weatherIndexData_;
        public WeatherIndexData WeatherIndexData_
        {
            get
            {
                if (this.weatherIndexData_ != null)
                {
                    return this.weatherIndexData_; 
                }
                else if (this.weatherIndexDataIDRef_ != null)
                {
                    weatherIndexData_ = IDManager.getID(weatherIndexDataIDRef_) as WeatherIndexData;
                    return this.weatherIndexData_; 
                }
                else
                {
                      return this.weatherIndexData_; 
                }
            }
            set
            {
                if (this.weatherIndexData_ != value)
                {
                    this.weatherIndexData_ = value;
                }
            }
        }
        #endregion
        
        public string weatherIndexDataIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

