using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class CommoditySwaptionUnderlying
    {
        public CommoditySwaptionUnderlying(XmlNode xmlNode)
        {
            XmlNodeList effectiveDateNodeList = xmlNode.SelectNodes("effectiveDate");
            if (effectiveDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in effectiveDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        effectiveDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(effectiveDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        effectiveDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        effectiveDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList terminationDateNodeList = xmlNode.SelectNodes("terminationDate");
            if (terminationDateNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in terminationDateNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        terminationDateIDRef = item.Attributes["id"].Name;
                        AdjustableOrRelativeDate ob = AdjustableOrRelativeDate();
                        IDManager.SetID(terminationDateIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        terminationDateIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        terminationDate = new AdjustableOrRelativeDate(item);
                    }
                }
            }
            
        
            XmlNodeList settlementCurrencyNodeList = xmlNode.SelectNodes("settlementCurrency");
            if (settlementCurrencyNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementCurrencyNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementCurrencyIDRef = item.Attributes["id"].Name;
                        IdentifiedCurrency ob = IdentifiedCurrency();
                        IDManager.SetID(settlementCurrencyIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementCurrencyIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementCurrency = new IdentifiedCurrency(item);
                    }
                }
            }
            
        
            XmlNodeList commoditySwapLegNodeList = xmlNode.SelectNodes("commoditySwapLeg");
            if (commoditySwapLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commoditySwapLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commoditySwapLegIDRef = item.Attributes["id"].Name;
                        CommoditySwapLeg ob = CommoditySwapLeg();
                        IDManager.SetID(commoditySwapLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commoditySwapLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commoditySwapLeg = new CommoditySwapLeg(item);
                    }
                }
            }
            
        
            XmlNodeList coalPhysicalLegNodeList = xmlNode.SelectNodes("coalPhysicalLeg");
            if (coalPhysicalLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in coalPhysicalLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        coalPhysicalLegIDRef = item.Attributes["id"].Name;
                        CoalPhysicalLeg ob = CoalPhysicalLeg();
                        IDManager.SetID(coalPhysicalLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        coalPhysicalLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        coalPhysicalLeg = new CoalPhysicalLeg(item);
                    }
                }
            }
            
        
            XmlNodeList electricityPhysicalLegNodeList = xmlNode.SelectNodes("electricityPhysicalLeg");
            if (electricityPhysicalLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in electricityPhysicalLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        electricityPhysicalLegIDRef = item.Attributes["id"].Name;
                        ElectricityPhysicalLeg ob = ElectricityPhysicalLeg();
                        IDManager.SetID(electricityPhysicalLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        electricityPhysicalLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        electricityPhysicalLeg = new ElectricityPhysicalLeg(item);
                    }
                }
            }
            
        
            XmlNodeList environmentalPhysicalLegNodeList = xmlNode.SelectNodes("environmentalPhysicalLeg");
            if (environmentalPhysicalLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in environmentalPhysicalLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        environmentalPhysicalLegIDRef = item.Attributes["id"].Name;
                        EnvironmentalPhysicalLeg ob = EnvironmentalPhysicalLeg();
                        IDManager.SetID(environmentalPhysicalLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        environmentalPhysicalLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        environmentalPhysicalLeg = new EnvironmentalPhysicalLeg(item);
                    }
                }
            }
            
        
            XmlNodeList fixedLegNodeList = xmlNode.SelectNodes("fixedLeg");
            if (fixedLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fixedLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fixedLegIDRef = item.Attributes["id"].Name;
                        FixedPriceLeg ob = FixedPriceLeg();
                        IDManager.SetID(fixedLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fixedLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fixedLeg = new FixedPriceLeg(item);
                    }
                }
            }
            
        
            XmlNodeList floatingLegNodeList = xmlNode.SelectNodes("floatingLeg");
            if (floatingLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in floatingLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        floatingLegIDRef = item.Attributes["id"].Name;
                        FloatingPriceLeg ob = FloatingPriceLeg();
                        IDManager.SetID(floatingLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        floatingLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        floatingLeg = new FloatingPriceLeg(item);
                    }
                }
            }
            
        
            XmlNodeList gasPhysicalLegNodeList = xmlNode.SelectNodes("gasPhysicalLeg");
            if (gasPhysicalLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in gasPhysicalLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        gasPhysicalLegIDRef = item.Attributes["id"].Name;
                        GasPhysicalLeg ob = GasPhysicalLeg();
                        IDManager.SetID(gasPhysicalLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        gasPhysicalLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        gasPhysicalLeg = new GasPhysicalLeg(item);
                    }
                }
            }
            
        
            XmlNodeList oilPhysicalLegNodeList = xmlNode.SelectNodes("oilPhysicalLeg");
            if (oilPhysicalLegNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in oilPhysicalLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        oilPhysicalLegIDRef = item.Attributes["id"].Name;
                        OilPhysicalLeg ob = OilPhysicalLeg();
                        IDManager.SetID(oilPhysicalLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        oilPhysicalLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        oilPhysicalLeg = new OilPhysicalLeg(item);
                    }
                }
            }
            
        
            XmlNodeList weatherLegNodeList = xmlNode.SelectNodes("weatherLeg");
            
            foreach (XmlNode item in weatherLegNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        weatherLegIDRef = item.Attributes["id"].Name;
                        List<WeatherLeg> ob = new List<WeatherLeg>();
                        ob.Add(new WeatherLeg(item));
                        IDManager.SetID(weatherLegIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        weatherLegIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    weatherLeg.Add(new WeatherLeg(item));
                    }
                }
            }
            
        
            XmlNodeList commonPricingNodeList = xmlNode.SelectNodes("commonPricing");
            if (commonPricingNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in commonPricingNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        commonPricingIDRef = item.Attributes["id"].Name;
                        XsdTypeBoolean ob = XsdTypeBoolean();
                        IDManager.SetID(commonPricingIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        commonPricingIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        commonPricing = new XsdTypeBoolean(item);
                    }
                }
            }
            
        
            XmlNodeList marketDisruptionNodeList = xmlNode.SelectNodes("marketDisruption");
            if (marketDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in marketDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        marketDisruptionIDRef = item.Attributes["id"].Name;
                        CommodityMarketDisruption ob = CommodityMarketDisruption();
                        IDManager.SetID(marketDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        marketDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        marketDisruption = new CommodityMarketDisruption(item);
                    }
                }
            }
            
        
            XmlNodeList settlementDisruptionNodeList = xmlNode.SelectNodes("settlementDisruption");
            if (settlementDisruptionNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in settlementDisruptionNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        settlementDisruptionIDRef = item.Attributes["id"].Name;
                        CommodityBullionSettlementDisruptionEnum ob = CommodityBullionSettlementDisruptionEnum();
                        IDManager.SetID(settlementDisruptionIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        settlementDisruptionIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        settlementDisruption = new CommodityBullionSettlementDisruptionEnum(item);
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
        
    
        #region EffectiveDate
        private AdjustableOrRelativeDate effectiveDate;
        public AdjustableOrRelativeDate EffectiveDate
        {
            get
            {
                if (this.effectiveDate != null)
                {
                    return this.effectiveDate; 
                }
                else if (this.effectiveDateIDRef != null)
                {
                    effectiveDate = IDManager.getID(effectiveDateIDRef) as AdjustableOrRelativeDate;
                    return this.effectiveDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.effectiveDate != value)
                {
                    this.effectiveDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region TerminationDate
        private AdjustableOrRelativeDate terminationDate;
        public AdjustableOrRelativeDate TerminationDate
        {
            get
            {
                if (this.terminationDate != null)
                {
                    return this.terminationDate; 
                }
                else if (this.terminationDateIDRef != null)
                {
                    terminationDate = IDManager.getID(terminationDateIDRef) as AdjustableOrRelativeDate;
                    return this.terminationDate; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.terminationDate != value)
                {
                    this.terminationDate = value;
                }
            }
        }
        #endregion
        
        public string AdjustableOrRelativeDateIDRef { get; set; }
        #region SettlementCurrency
        private IdentifiedCurrency settlementCurrency;
        public IdentifiedCurrency SettlementCurrency
        {
            get
            {
                if (this.settlementCurrency != null)
                {
                    return this.settlementCurrency; 
                }
                else if (this.settlementCurrencyIDRef != null)
                {
                    settlementCurrency = IDManager.getID(settlementCurrencyIDRef) as IdentifiedCurrency;
                    return this.settlementCurrency; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementCurrency != value)
                {
                    this.settlementCurrency = value;
                }
            }
        }
        #endregion
        
        public string IdentifiedCurrencyIDRef { get; set; }
        #region CommoditySwapLeg
        private CommoditySwapLeg commoditySwapLeg;
        public CommoditySwapLeg CommoditySwapLeg
        {
            get
            {
                if (this.commoditySwapLeg != null)
                {
                    return this.commoditySwapLeg; 
                }
                else if (this.commoditySwapLegIDRef != null)
                {
                    commoditySwapLeg = IDManager.getID(commoditySwapLegIDRef) as CommoditySwapLeg;
                    return this.commoditySwapLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commoditySwapLeg != value)
                {
                    this.commoditySwapLeg = value;
                }
            }
        }
        #endregion
        
        public string CommoditySwapLegIDRef { get; set; }
        #region CoalPhysicalLeg
        private CoalPhysicalLeg coalPhysicalLeg;
        public CoalPhysicalLeg CoalPhysicalLeg
        {
            get
            {
                if (this.coalPhysicalLeg != null)
                {
                    return this.coalPhysicalLeg; 
                }
                else if (this.coalPhysicalLegIDRef != null)
                {
                    coalPhysicalLeg = IDManager.getID(coalPhysicalLegIDRef) as CoalPhysicalLeg;
                    return this.coalPhysicalLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.coalPhysicalLeg != value)
                {
                    this.coalPhysicalLeg = value;
                }
            }
        }
        #endregion
        
        public string CoalPhysicalLegIDRef { get; set; }     // substitude
        #region ElectricityPhysicalLeg
        private ElectricityPhysicalLeg electricityPhysicalLeg;
        public ElectricityPhysicalLeg ElectricityPhysicalLeg
        {
            get
            {
                if (this.electricityPhysicalLeg != null)
                {
                    return this.electricityPhysicalLeg; 
                }
                else if (this.electricityPhysicalLegIDRef != null)
                {
                    electricityPhysicalLeg = IDManager.getID(electricityPhysicalLegIDRef) as ElectricityPhysicalLeg;
                    return this.electricityPhysicalLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.electricityPhysicalLeg != value)
                {
                    this.electricityPhysicalLeg = value;
                }
            }
        }
        #endregion
        
        public string ElectricityPhysicalLegIDRef { get; set; }     // substitude
        #region EnvironmentalPhysicalLeg
        private EnvironmentalPhysicalLeg environmentalPhysicalLeg;
        public EnvironmentalPhysicalLeg EnvironmentalPhysicalLeg
        {
            get
            {
                if (this.environmentalPhysicalLeg != null)
                {
                    return this.environmentalPhysicalLeg; 
                }
                else if (this.environmentalPhysicalLegIDRef != null)
                {
                    environmentalPhysicalLeg = IDManager.getID(environmentalPhysicalLegIDRef) as EnvironmentalPhysicalLeg;
                    return this.environmentalPhysicalLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.environmentalPhysicalLeg != value)
                {
                    this.environmentalPhysicalLeg = value;
                }
            }
        }
        #endregion
        
        public string EnvironmentalPhysicalLegIDRef { get; set; }     // substitude
        #region FixedLeg
        private FixedPriceLeg fixedLeg;
        public FixedPriceLeg FixedLeg
        {
            get
            {
                if (this.fixedLeg != null)
                {
                    return this.fixedLeg; 
                }
                else if (this.fixedLegIDRef != null)
                {
                    fixedLeg = IDManager.getID(fixedLegIDRef) as FixedPriceLeg;
                    return this.fixedLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fixedLeg != value)
                {
                    this.fixedLeg = value;
                }
            }
        }
        #endregion
        
        public string FixedPriceLegIDRef { get; set; }     // substitude
        #region FloatingLeg
        private FloatingPriceLeg floatingLeg;
        public FloatingPriceLeg FloatingLeg
        {
            get
            {
                if (this.floatingLeg != null)
                {
                    return this.floatingLeg; 
                }
                else if (this.floatingLegIDRef != null)
                {
                    floatingLeg = IDManager.getID(floatingLegIDRef) as FloatingPriceLeg;
                    return this.floatingLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.floatingLeg != value)
                {
                    this.floatingLeg = value;
                }
            }
        }
        #endregion
        
        public string FloatingPriceLegIDRef { get; set; }     // substitude
        #region GasPhysicalLeg
        private GasPhysicalLeg gasPhysicalLeg;
        public GasPhysicalLeg GasPhysicalLeg
        {
            get
            {
                if (this.gasPhysicalLeg != null)
                {
                    return this.gasPhysicalLeg; 
                }
                else if (this.gasPhysicalLegIDRef != null)
                {
                    gasPhysicalLeg = IDManager.getID(gasPhysicalLegIDRef) as GasPhysicalLeg;
                    return this.gasPhysicalLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.gasPhysicalLeg != value)
                {
                    this.gasPhysicalLeg = value;
                }
            }
        }
        #endregion
        
        public string GasPhysicalLegIDRef { get; set; }     // substitude
        #region OilPhysicalLeg
        private OilPhysicalLeg oilPhysicalLeg;
        public OilPhysicalLeg OilPhysicalLeg
        {
            get
            {
                if (this.oilPhysicalLeg != null)
                {
                    return this.oilPhysicalLeg; 
                }
                else if (this.oilPhysicalLegIDRef != null)
                {
                    oilPhysicalLeg = IDManager.getID(oilPhysicalLegIDRef) as OilPhysicalLeg;
                    return this.oilPhysicalLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.oilPhysicalLeg != value)
                {
                    this.oilPhysicalLeg = value;
                }
            }
        }
        #endregion
        
        public string OilPhysicalLegIDRef { get; set; }     // substitude
        #region WeatherLeg
        private List<WeatherLeg> weatherLeg;
        public List<WeatherLeg> WeatherLeg
        {
            get
            {
                if (this.weatherLeg != null)
                {
                    return this.weatherLeg; 
                }
                else if (this.weatherLegIDRef != null)
                {
                    weatherLeg = IDManager.getID(weatherLegIDRef) as List<WeatherLeg>;
                    return this.weatherLeg; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.weatherLeg != value)
                {
                    this.weatherLeg = value;
                }
            }
        }
        #endregion
        
        public string WeatherLegIDRef { get; set; }
        #region CommonPricing
        private XsdTypeBoolean commonPricing;
        public XsdTypeBoolean CommonPricing
        {
            get
            {
                if (this.commonPricing != null)
                {
                    return this.commonPricing; 
                }
                else if (this.commonPricingIDRef != null)
                {
                    commonPricing = IDManager.getID(commonPricingIDRef) as XsdTypeBoolean;
                    return this.commonPricing; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.commonPricing != value)
                {
                    this.commonPricing = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeBooleanIDRef { get; set; }
        #region MarketDisruption
        private CommodityMarketDisruption marketDisruption;
        public CommodityMarketDisruption MarketDisruption
        {
            get
            {
                if (this.marketDisruption != null)
                {
                    return this.marketDisruption; 
                }
                else if (this.marketDisruptionIDRef != null)
                {
                    marketDisruption = IDManager.getID(marketDisruptionIDRef) as CommodityMarketDisruption;
                    return this.marketDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.marketDisruption != value)
                {
                    this.marketDisruption = value;
                }
            }
        }
        #endregion
        
        public string CommodityMarketDisruptionIDRef { get; set; }
        #region SettlementDisruption
        private CommodityBullionSettlementDisruptionEnum settlementDisruption;
        public CommodityBullionSettlementDisruptionEnum SettlementDisruption
        {
            get
            {
                if (this.settlementDisruption != null)
                {
                    return this.settlementDisruption; 
                }
                else if (this.settlementDisruptionIDRef != null)
                {
                    settlementDisruption = IDManager.getID(settlementDisruptionIDRef) as CommodityBullionSettlementDisruptionEnum;
                    return this.settlementDisruption; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.settlementDisruption != value)
                {
                    this.settlementDisruption = value;
                }
            }
        }
        #endregion
        
        public string CommodityBullionSettlementDisruptionEnumIDRef { get; set; }
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
        public string choiceStr_0;
        
    
        
    
    }
    
}

