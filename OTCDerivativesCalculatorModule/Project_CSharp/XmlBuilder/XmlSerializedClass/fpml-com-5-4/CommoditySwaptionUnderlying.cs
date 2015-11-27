using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class CommoditySwaptionUnderlying : ISerialized
    {
        public CommoditySwaptionUnderlying(XmlNode xmlNode)
        {
            XmlNode effectiveDateNode = xmlNode.SelectSingleNode("effectiveDate");
            
            if (effectiveDateNode != null)
            {
                if (effectiveDateNode.Attributes["href"] != null || effectiveDateNode.Attributes["id"] != null) 
                {
                    if (effectiveDateNode.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(effectiveDateNode);
                        IDManager.SetID(effectiveDateIDRef_, ob);
                    }
                    else if (effectiveDateNode.Attributes["href"] != null)
                    {
                        effectiveDateIDRef_ = effectiveDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        effectiveDate_ = new AdjustableOrRelativeDate(effectiveDateNode);
                    }
                }
                else
                {
                    effectiveDate_ = new AdjustableOrRelativeDate(effectiveDateNode);
                }
            }
            
        
            XmlNode terminationDateNode = xmlNode.SelectSingleNode("terminationDate");
            
            if (terminationDateNode != null)
            {
                if (terminationDateNode.Attributes["href"] != null || terminationDateNode.Attributes["id"] != null) 
                {
                    if (terminationDateNode.Attributes["id"] != null) 
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["id"].Value;
                        AdjustableOrRelativeDate ob = new AdjustableOrRelativeDate(terminationDateNode);
                        IDManager.SetID(terminationDateIDRef_, ob);
                    }
                    else if (terminationDateNode.Attributes["href"] != null)
                    {
                        terminationDateIDRef_ = terminationDateNode.Attributes["href"].Value;
                    }
                    else
                    {
                        terminationDate_ = new AdjustableOrRelativeDate(terminationDateNode);
                    }
                }
                else
                {
                    terminationDate_ = new AdjustableOrRelativeDate(terminationDateNode);
                }
            }
            
        
            XmlNode settlementCurrencyNode = xmlNode.SelectSingleNode("settlementCurrency");
            
            if (settlementCurrencyNode != null)
            {
                if (settlementCurrencyNode.Attributes["href"] != null || settlementCurrencyNode.Attributes["id"] != null) 
                {
                    if (settlementCurrencyNode.Attributes["id"] != null) 
                    {
                        settlementCurrencyIDRef_ = settlementCurrencyNode.Attributes["id"].Value;
                        IdentifiedCurrency ob = new IdentifiedCurrency(settlementCurrencyNode);
                        IDManager.SetID(settlementCurrencyIDRef_, ob);
                    }
                    else if (settlementCurrencyNode.Attributes["href"] != null)
                    {
                        settlementCurrencyIDRef_ = settlementCurrencyNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementCurrency_ = new IdentifiedCurrency(settlementCurrencyNode);
                    }
                }
                else
                {
                    settlementCurrency_ = new IdentifiedCurrency(settlementCurrencyNode);
                }
            }
            
        
            XmlNode commoditySwapLegNode = xmlNode.SelectSingleNode("commoditySwapLeg");
            
            if (commoditySwapLegNode != null)
            {
                if (commoditySwapLegNode.Attributes["href"] != null || commoditySwapLegNode.Attributes["id"] != null) 
                {
                    if (commoditySwapLegNode.Attributes["id"] != null) 
                    {
                        commoditySwapLegIDRef_ = commoditySwapLegNode.Attributes["id"].Value;
                        CommoditySwapLeg ob = new CommoditySwapLeg(commoditySwapLegNode);
                        IDManager.SetID(commoditySwapLegIDRef_, ob);
                    }
                    else if (commoditySwapLegNode.Attributes["href"] != null)
                    {
                        commoditySwapLegIDRef_ = commoditySwapLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commoditySwapLeg_ = new CommoditySwapLeg(commoditySwapLegNode);
                    }
                }
                else
                {
                    commoditySwapLeg_ = new CommoditySwapLeg(commoditySwapLegNode);
                }
            }
            
        
            XmlNode coalPhysicalLegNode = xmlNode.SelectSingleNode("coalPhysicalLeg");
            
            if (coalPhysicalLegNode != null)
            {
                if (coalPhysicalLegNode.Attributes["href"] != null || coalPhysicalLegNode.Attributes["id"] != null) 
                {
                    if (coalPhysicalLegNode.Attributes["id"] != null) 
                    {
                        coalPhysicalLegIDRef_ = coalPhysicalLegNode.Attributes["id"].Value;
                        CoalPhysicalLeg ob = new CoalPhysicalLeg(coalPhysicalLegNode);
                        IDManager.SetID(coalPhysicalLegIDRef_, ob);
                    }
                    else if (coalPhysicalLegNode.Attributes["href"] != null)
                    {
                        coalPhysicalLegIDRef_ = coalPhysicalLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        coalPhysicalLeg_ = new CoalPhysicalLeg(coalPhysicalLegNode);
                    }
                }
                else
                {
                    coalPhysicalLeg_ = new CoalPhysicalLeg(coalPhysicalLegNode);
                }
            }
            
        
            XmlNode electricityPhysicalLegNode = xmlNode.SelectSingleNode("electricityPhysicalLeg");
            
            if (electricityPhysicalLegNode != null)
            {
                if (electricityPhysicalLegNode.Attributes["href"] != null || electricityPhysicalLegNode.Attributes["id"] != null) 
                {
                    if (electricityPhysicalLegNode.Attributes["id"] != null) 
                    {
                        electricityPhysicalLegIDRef_ = electricityPhysicalLegNode.Attributes["id"].Value;
                        ElectricityPhysicalLeg ob = new ElectricityPhysicalLeg(electricityPhysicalLegNode);
                        IDManager.SetID(electricityPhysicalLegIDRef_, ob);
                    }
                    else if (electricityPhysicalLegNode.Attributes["href"] != null)
                    {
                        electricityPhysicalLegIDRef_ = electricityPhysicalLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        electricityPhysicalLeg_ = new ElectricityPhysicalLeg(electricityPhysicalLegNode);
                    }
                }
                else
                {
                    electricityPhysicalLeg_ = new ElectricityPhysicalLeg(electricityPhysicalLegNode);
                }
            }
            
        
            XmlNode environmentalPhysicalLegNode = xmlNode.SelectSingleNode("environmentalPhysicalLeg");
            
            if (environmentalPhysicalLegNode != null)
            {
                if (environmentalPhysicalLegNode.Attributes["href"] != null || environmentalPhysicalLegNode.Attributes["id"] != null) 
                {
                    if (environmentalPhysicalLegNode.Attributes["id"] != null) 
                    {
                        environmentalPhysicalLegIDRef_ = environmentalPhysicalLegNode.Attributes["id"].Value;
                        EnvironmentalPhysicalLeg ob = new EnvironmentalPhysicalLeg(environmentalPhysicalLegNode);
                        IDManager.SetID(environmentalPhysicalLegIDRef_, ob);
                    }
                    else if (environmentalPhysicalLegNode.Attributes["href"] != null)
                    {
                        environmentalPhysicalLegIDRef_ = environmentalPhysicalLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        environmentalPhysicalLeg_ = new EnvironmentalPhysicalLeg(environmentalPhysicalLegNode);
                    }
                }
                else
                {
                    environmentalPhysicalLeg_ = new EnvironmentalPhysicalLeg(environmentalPhysicalLegNode);
                }
            }
            
        
            XmlNode fixedLegNode = xmlNode.SelectSingleNode("fixedLeg");
            
            if (fixedLegNode != null)
            {
                if (fixedLegNode.Attributes["href"] != null || fixedLegNode.Attributes["id"] != null) 
                {
                    if (fixedLegNode.Attributes["id"] != null) 
                    {
                        fixedLegIDRef_ = fixedLegNode.Attributes["id"].Value;
                        FixedPriceLeg ob = new FixedPriceLeg(fixedLegNode);
                        IDManager.SetID(fixedLegIDRef_, ob);
                    }
                    else if (fixedLegNode.Attributes["href"] != null)
                    {
                        fixedLegIDRef_ = fixedLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fixedLeg_ = new FixedPriceLeg(fixedLegNode);
                    }
                }
                else
                {
                    fixedLeg_ = new FixedPriceLeg(fixedLegNode);
                }
            }
            
        
            XmlNode floatingLegNode = xmlNode.SelectSingleNode("floatingLeg");
            
            if (floatingLegNode != null)
            {
                if (floatingLegNode.Attributes["href"] != null || floatingLegNode.Attributes["id"] != null) 
                {
                    if (floatingLegNode.Attributes["id"] != null) 
                    {
                        floatingLegIDRef_ = floatingLegNode.Attributes["id"].Value;
                        FloatingPriceLeg ob = new FloatingPriceLeg(floatingLegNode);
                        IDManager.SetID(floatingLegIDRef_, ob);
                    }
                    else if (floatingLegNode.Attributes["href"] != null)
                    {
                        floatingLegIDRef_ = floatingLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        floatingLeg_ = new FloatingPriceLeg(floatingLegNode);
                    }
                }
                else
                {
                    floatingLeg_ = new FloatingPriceLeg(floatingLegNode);
                }
            }
            
        
            XmlNode gasPhysicalLegNode = xmlNode.SelectSingleNode("gasPhysicalLeg");
            
            if (gasPhysicalLegNode != null)
            {
                if (gasPhysicalLegNode.Attributes["href"] != null || gasPhysicalLegNode.Attributes["id"] != null) 
                {
                    if (gasPhysicalLegNode.Attributes["id"] != null) 
                    {
                        gasPhysicalLegIDRef_ = gasPhysicalLegNode.Attributes["id"].Value;
                        GasPhysicalLeg ob = new GasPhysicalLeg(gasPhysicalLegNode);
                        IDManager.SetID(gasPhysicalLegIDRef_, ob);
                    }
                    else if (gasPhysicalLegNode.Attributes["href"] != null)
                    {
                        gasPhysicalLegIDRef_ = gasPhysicalLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        gasPhysicalLeg_ = new GasPhysicalLeg(gasPhysicalLegNode);
                    }
                }
                else
                {
                    gasPhysicalLeg_ = new GasPhysicalLeg(gasPhysicalLegNode);
                }
            }
            
        
            XmlNode oilPhysicalLegNode = xmlNode.SelectSingleNode("oilPhysicalLeg");
            
            if (oilPhysicalLegNode != null)
            {
                if (oilPhysicalLegNode.Attributes["href"] != null || oilPhysicalLegNode.Attributes["id"] != null) 
                {
                    if (oilPhysicalLegNode.Attributes["id"] != null) 
                    {
                        oilPhysicalLegIDRef_ = oilPhysicalLegNode.Attributes["id"].Value;
                        OilPhysicalLeg ob = new OilPhysicalLeg(oilPhysicalLegNode);
                        IDManager.SetID(oilPhysicalLegIDRef_, ob);
                    }
                    else if (oilPhysicalLegNode.Attributes["href"] != null)
                    {
                        oilPhysicalLegIDRef_ = oilPhysicalLegNode.Attributes["href"].Value;
                    }
                    else
                    {
                        oilPhysicalLeg_ = new OilPhysicalLeg(oilPhysicalLegNode);
                    }
                }
                else
                {
                    oilPhysicalLeg_ = new OilPhysicalLeg(oilPhysicalLegNode);
                }
            }
            
        
            XmlNodeList weatherLegNodeList = xmlNode.SelectNodes("weatherLeg");
            
            if (weatherLegNodeList != null)
            {
                this.weatherLeg_ = new List<WeatherLeg>();
                foreach (XmlNode item in weatherLegNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            weatherLegIDRef_ = item.Attributes["id"].Value;
                            weatherLeg_.Add(new WeatherLeg(item));
                            IDManager.SetID(weatherLegIDRef_, weatherLeg_[weatherLeg_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            weatherLegIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        weatherLeg_.Add(new WeatherLeg(item));
                        }
                    }
                    else
                    {
                        weatherLeg_.Add(new WeatherLeg(item));
                    }
                }
            }
            
        
            XmlNode commonPricingNode = xmlNode.SelectSingleNode("commonPricing");
            
            if (commonPricingNode != null)
            {
                if (commonPricingNode.Attributes["href"] != null || commonPricingNode.Attributes["id"] != null) 
                {
                    if (commonPricingNode.Attributes["id"] != null) 
                    {
                        commonPricingIDRef_ = commonPricingNode.Attributes["id"].Value;
                        XsdTypeBoolean ob = new XsdTypeBoolean(commonPricingNode);
                        IDManager.SetID(commonPricingIDRef_, ob);
                    }
                    else if (commonPricingNode.Attributes["href"] != null)
                    {
                        commonPricingIDRef_ = commonPricingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        commonPricing_ = new XsdTypeBoolean(commonPricingNode);
                    }
                }
                else
                {
                    commonPricing_ = new XsdTypeBoolean(commonPricingNode);
                }
            }
            
        
            XmlNode marketDisruptionNode = xmlNode.SelectSingleNode("marketDisruption");
            
            if (marketDisruptionNode != null)
            {
                if (marketDisruptionNode.Attributes["href"] != null || marketDisruptionNode.Attributes["id"] != null) 
                {
                    if (marketDisruptionNode.Attributes["id"] != null) 
                    {
                        marketDisruptionIDRef_ = marketDisruptionNode.Attributes["id"].Value;
                        CommodityMarketDisruption ob = new CommodityMarketDisruption(marketDisruptionNode);
                        IDManager.SetID(marketDisruptionIDRef_, ob);
                    }
                    else if (marketDisruptionNode.Attributes["href"] != null)
                    {
                        marketDisruptionIDRef_ = marketDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        marketDisruption_ = new CommodityMarketDisruption(marketDisruptionNode);
                    }
                }
                else
                {
                    marketDisruption_ = new CommodityMarketDisruption(marketDisruptionNode);
                }
            }
            
        
            XmlNode settlementDisruptionNode = xmlNode.SelectSingleNode("settlementDisruption");
            
            if (settlementDisruptionNode != null)
            {
                if (settlementDisruptionNode.Attributes["href"] != null || settlementDisruptionNode.Attributes["id"] != null) 
                {
                    if (settlementDisruptionNode.Attributes["id"] != null) 
                    {
                        settlementDisruptionIDRef_ = settlementDisruptionNode.Attributes["id"].Value;
                        CommodityBullionSettlementDisruptionEnum ob = new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode);
                        IDManager.SetID(settlementDisruptionIDRef_, ob);
                    }
                    else if (settlementDisruptionNode.Attributes["href"] != null)
                    {
                        settlementDisruptionIDRef_ = settlementDisruptionNode.Attributes["href"].Value;
                    }
                    else
                    {
                        settlementDisruption_ = new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode);
                    }
                }
                else
                {
                    settlementDisruption_ = new CommodityBullionSettlementDisruptionEnum(settlementDisruptionNode);
                }
            }
            
        
            XmlNode roundingNode = xmlNode.SelectSingleNode("rounding");
            
            if (roundingNode != null)
            {
                if (roundingNode.Attributes["href"] != null || roundingNode.Attributes["id"] != null) 
                {
                    if (roundingNode.Attributes["id"] != null) 
                    {
                        roundingIDRef_ = roundingNode.Attributes["id"].Value;
                        Rounding ob = new Rounding(roundingNode);
                        IDManager.SetID(roundingIDRef_, ob);
                    }
                    else if (roundingNode.Attributes["href"] != null)
                    {
                        roundingIDRef_ = roundingNode.Attributes["href"].Value;
                    }
                    else
                    {
                        rounding_ = new Rounding(roundingNode);
                    }
                }
                else
                {
                    rounding_ = new Rounding(roundingNode);
                }
            }
            
        
        }
        
    
        #region EffectiveDate_
        private AdjustableOrRelativeDate effectiveDate_;
        public AdjustableOrRelativeDate EffectiveDate_
        {
            get
            {
                if (this.effectiveDate_ != null)
                {
                    return this.effectiveDate_; 
                }
                else if (this.effectiveDateIDRef_ != null)
                {
                    effectiveDate_ = IDManager.getID(effectiveDateIDRef_) as AdjustableOrRelativeDate;
                    return this.effectiveDate_; 
                }
                else
                {
                      return this.effectiveDate_; 
                }
            }
            set
            {
                if (this.effectiveDate_ != value)
                {
                    this.effectiveDate_ = value;
                }
            }
        }
        #endregion
        
        public string effectiveDateIDRef_ { get; set; }
        #region TerminationDate_
        private AdjustableOrRelativeDate terminationDate_;
        public AdjustableOrRelativeDate TerminationDate_
        {
            get
            {
                if (this.terminationDate_ != null)
                {
                    return this.terminationDate_; 
                }
                else if (this.terminationDateIDRef_ != null)
                {
                    terminationDate_ = IDManager.getID(terminationDateIDRef_) as AdjustableOrRelativeDate;
                    return this.terminationDate_; 
                }
                else
                {
                      return this.terminationDate_; 
                }
            }
            set
            {
                if (this.terminationDate_ != value)
                {
                    this.terminationDate_ = value;
                }
            }
        }
        #endregion
        
        public string terminationDateIDRef_ { get; set; }
        #region SettlementCurrency_
        private IdentifiedCurrency settlementCurrency_;
        public IdentifiedCurrency SettlementCurrency_
        {
            get
            {
                if (this.settlementCurrency_ != null)
                {
                    return this.settlementCurrency_; 
                }
                else if (this.settlementCurrencyIDRef_ != null)
                {
                    settlementCurrency_ = IDManager.getID(settlementCurrencyIDRef_) as IdentifiedCurrency;
                    return this.settlementCurrency_; 
                }
                else
                {
                      return this.settlementCurrency_; 
                }
            }
            set
            {
                if (this.settlementCurrency_ != value)
                {
                    this.settlementCurrency_ = value;
                }
            }
        }
        #endregion
        
        public string settlementCurrencyIDRef_ { get; set; }
        #region CommoditySwapLeg_
        private CommoditySwapLeg commoditySwapLeg_;
        public CommoditySwapLeg CommoditySwapLeg_
        {
            get
            {
                if (this.commoditySwapLeg_ != null)
                {
                    return this.commoditySwapLeg_; 
                }
                else if (this.commoditySwapLegIDRef_ != null)
                {
                    commoditySwapLeg_ = IDManager.getID(commoditySwapLegIDRef_) as CommoditySwapLeg;
                    return this.commoditySwapLeg_; 
                }
                else
                {
                      return this.commoditySwapLeg_; 
                }
            }
            set
            {
                if (this.commoditySwapLeg_ != value)
                {
                    this.commoditySwapLeg_ = value;
                }
            }
        }
        #endregion
        
        public string commoditySwapLegIDRef_ { get; set; }
        #region CoalPhysicalLeg_
        private CoalPhysicalLeg coalPhysicalLeg_;
        public CoalPhysicalLeg CoalPhysicalLeg_
        {
            get
            {
                if (this.coalPhysicalLeg_ != null)
                {
                    return this.coalPhysicalLeg_; 
                }
                else if (this.coalPhysicalLegIDRef_ != null)
                {
                    coalPhysicalLeg_ = IDManager.getID(coalPhysicalLegIDRef_) as CoalPhysicalLeg;
                    return this.coalPhysicalLeg_; 
                }
                else
                {
                      return this.coalPhysicalLeg_; 
                }
            }
            set
            {
                if (this.coalPhysicalLeg_ != value)
                {
                    this.coalPhysicalLeg_ = value;
                }
            }
        }
        #endregion
        
        public string coalPhysicalLegIDRef_ { get; set; }     // substitude
        #region ElectricityPhysicalLeg_
        private ElectricityPhysicalLeg electricityPhysicalLeg_;
        public ElectricityPhysicalLeg ElectricityPhysicalLeg_
        {
            get
            {
                if (this.electricityPhysicalLeg_ != null)
                {
                    return this.electricityPhysicalLeg_; 
                }
                else if (this.electricityPhysicalLegIDRef_ != null)
                {
                    electricityPhysicalLeg_ = IDManager.getID(electricityPhysicalLegIDRef_) as ElectricityPhysicalLeg;
                    return this.electricityPhysicalLeg_; 
                }
                else
                {
                      return this.electricityPhysicalLeg_; 
                }
            }
            set
            {
                if (this.electricityPhysicalLeg_ != value)
                {
                    this.electricityPhysicalLeg_ = value;
                }
            }
        }
        #endregion
        
        public string electricityPhysicalLegIDRef_ { get; set; }     // substitude
        #region EnvironmentalPhysicalLeg_
        private EnvironmentalPhysicalLeg environmentalPhysicalLeg_;
        public EnvironmentalPhysicalLeg EnvironmentalPhysicalLeg_
        {
            get
            {
                if (this.environmentalPhysicalLeg_ != null)
                {
                    return this.environmentalPhysicalLeg_; 
                }
                else if (this.environmentalPhysicalLegIDRef_ != null)
                {
                    environmentalPhysicalLeg_ = IDManager.getID(environmentalPhysicalLegIDRef_) as EnvironmentalPhysicalLeg;
                    return this.environmentalPhysicalLeg_; 
                }
                else
                {
                      return this.environmentalPhysicalLeg_; 
                }
            }
            set
            {
                if (this.environmentalPhysicalLeg_ != value)
                {
                    this.environmentalPhysicalLeg_ = value;
                }
            }
        }
        #endregion
        
        public string environmentalPhysicalLegIDRef_ { get; set; }     // substitude
        #region FixedLeg_
        private FixedPriceLeg fixedLeg_;
        public FixedPriceLeg FixedLeg_
        {
            get
            {
                if (this.fixedLeg_ != null)
                {
                    return this.fixedLeg_; 
                }
                else if (this.fixedLegIDRef_ != null)
                {
                    fixedLeg_ = IDManager.getID(fixedLegIDRef_) as FixedPriceLeg;
                    return this.fixedLeg_; 
                }
                else
                {
                      return this.fixedLeg_; 
                }
            }
            set
            {
                if (this.fixedLeg_ != value)
                {
                    this.fixedLeg_ = value;
                }
            }
        }
        #endregion
        
        public string fixedLegIDRef_ { get; set; }     // substitude
        #region FloatingLeg_
        private FloatingPriceLeg floatingLeg_;
        public FloatingPriceLeg FloatingLeg_
        {
            get
            {
                if (this.floatingLeg_ != null)
                {
                    return this.floatingLeg_; 
                }
                else if (this.floatingLegIDRef_ != null)
                {
                    floatingLeg_ = IDManager.getID(floatingLegIDRef_) as FloatingPriceLeg;
                    return this.floatingLeg_; 
                }
                else
                {
                      return this.floatingLeg_; 
                }
            }
            set
            {
                if (this.floatingLeg_ != value)
                {
                    this.floatingLeg_ = value;
                }
            }
        }
        #endregion
        
        public string floatingLegIDRef_ { get; set; }     // substitude
        #region GasPhysicalLeg_
        private GasPhysicalLeg gasPhysicalLeg_;
        public GasPhysicalLeg GasPhysicalLeg_
        {
            get
            {
                if (this.gasPhysicalLeg_ != null)
                {
                    return this.gasPhysicalLeg_; 
                }
                else if (this.gasPhysicalLegIDRef_ != null)
                {
                    gasPhysicalLeg_ = IDManager.getID(gasPhysicalLegIDRef_) as GasPhysicalLeg;
                    return this.gasPhysicalLeg_; 
                }
                else
                {
                      return this.gasPhysicalLeg_; 
                }
            }
            set
            {
                if (this.gasPhysicalLeg_ != value)
                {
                    this.gasPhysicalLeg_ = value;
                }
            }
        }
        #endregion
        
        public string gasPhysicalLegIDRef_ { get; set; }     // substitude
        #region OilPhysicalLeg_
        private OilPhysicalLeg oilPhysicalLeg_;
        public OilPhysicalLeg OilPhysicalLeg_
        {
            get
            {
                if (this.oilPhysicalLeg_ != null)
                {
                    return this.oilPhysicalLeg_; 
                }
                else if (this.oilPhysicalLegIDRef_ != null)
                {
                    oilPhysicalLeg_ = IDManager.getID(oilPhysicalLegIDRef_) as OilPhysicalLeg;
                    return this.oilPhysicalLeg_; 
                }
                else
                {
                      return this.oilPhysicalLeg_; 
                }
            }
            set
            {
                if (this.oilPhysicalLeg_ != value)
                {
                    this.oilPhysicalLeg_ = value;
                }
            }
        }
        #endregion
        
        public string oilPhysicalLegIDRef_ { get; set; }     // substitude
        #region WeatherLeg_
        private List<WeatherLeg> weatherLeg_;
        public List<WeatherLeg> WeatherLeg_
        {
            get
            {
                if (this.weatherLeg_ != null)
                {
                    return this.weatherLeg_; 
                }
                else if (this.weatherLegIDRef_ != null)
                {
                    return this.weatherLeg_; 
                }
                else
                {
                      return this.weatherLeg_; 
                }
            }
            set
            {
                if (this.weatherLeg_ != value)
                {
                    this.weatherLeg_ = value;
                }
            }
        }
        #endregion
        
        public string weatherLegIDRef_ { get; set; }
        #region CommonPricing_
        private XsdTypeBoolean commonPricing_;
        public XsdTypeBoolean CommonPricing_
        {
            get
            {
                if (this.commonPricing_ != null)
                {
                    return this.commonPricing_; 
                }
                else if (this.commonPricingIDRef_ != null)
                {
                    commonPricing_ = IDManager.getID(commonPricingIDRef_) as XsdTypeBoolean;
                    return this.commonPricing_; 
                }
                else
                {
                      return this.commonPricing_; 
                }
            }
            set
            {
                if (this.commonPricing_ != value)
                {
                    this.commonPricing_ = value;
                }
            }
        }
        #endregion
        
        public string commonPricingIDRef_ { get; set; }
        #region MarketDisruption_
        private CommodityMarketDisruption marketDisruption_;
        public CommodityMarketDisruption MarketDisruption_
        {
            get
            {
                if (this.marketDisruption_ != null)
                {
                    return this.marketDisruption_; 
                }
                else if (this.marketDisruptionIDRef_ != null)
                {
                    marketDisruption_ = IDManager.getID(marketDisruptionIDRef_) as CommodityMarketDisruption;
                    return this.marketDisruption_; 
                }
                else
                {
                      return this.marketDisruption_; 
                }
            }
            set
            {
                if (this.marketDisruption_ != value)
                {
                    this.marketDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string marketDisruptionIDRef_ { get; set; }
        #region SettlementDisruption_
        private CommodityBullionSettlementDisruptionEnum settlementDisruption_;
        public CommodityBullionSettlementDisruptionEnum SettlementDisruption_
        {
            get
            {
                if (this.settlementDisruption_ != null)
                {
                    return this.settlementDisruption_; 
                }
                else if (this.settlementDisruptionIDRef_ != null)
                {
                    settlementDisruption_ = IDManager.getID(settlementDisruptionIDRef_) as CommodityBullionSettlementDisruptionEnum;
                    return this.settlementDisruption_; 
                }
                else
                {
                      return this.settlementDisruption_; 
                }
            }
            set
            {
                if (this.settlementDisruption_ != value)
                {
                    this.settlementDisruption_ = value;
                }
            }
        }
        #endregion
        
        public string settlementDisruptionIDRef_ { get; set; }
        #region Rounding_
        private Rounding rounding_;
        public Rounding Rounding_
        {
            get
            {
                if (this.rounding_ != null)
                {
                    return this.rounding_; 
                }
                else if (this.roundingIDRef_ != null)
                {
                    rounding_ = IDManager.getID(roundingIDRef_) as Rounding;
                    return this.rounding_; 
                }
                else
                {
                      return this.rounding_; 
                }
            }
            set
            {
                if (this.rounding_ != value)
                {
                    this.rounding_ = value;
                }
            }
        }
        #endregion
        
        public string roundingIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

