using System;
using System.Text;
using System.Xml;
using CSharpCodeGen;

namespace FpmlSerializedCSharp
{
    public class FloatingLegCalculation
    {
        public FloatingLegCalculation(XmlNode xmlNode)
        {
            XmlNodeList pricingDatesNodeList = xmlNode.SelectNodes("pricingDates");
            if (pricingDatesNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in pricingDatesNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        pricingDatesIDRef = item.Attributes["id"].Name;
                        CommodityPricingDates ob = CommodityPricingDates();
                        IDManager.SetID(pricingDatesIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        pricingDatesIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        pricingDates = new CommodityPricingDates(item);
                    }
                }
            }
            
        
            XmlNodeList averagingMethodNodeList = xmlNode.SelectNodes("averagingMethod");
            if (averagingMethodNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in averagingMethodNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        averagingMethodIDRef = item.Attributes["id"].Name;
                        AveragingMethodEnum ob = AveragingMethodEnum();
                        IDManager.SetID(averagingMethodIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        averagingMethodIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        averagingMethod = new AveragingMethodEnum(item);
                    }
                }
            }
            
        
            XmlNodeList conversionFactorNodeList = xmlNode.SelectNodes("conversionFactor");
            if (conversionFactorNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in conversionFactorNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        conversionFactorIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(conversionFactorIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        conversionFactorIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        conversionFactor = new XsdTypeDecimal(item);
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
            
        
            XmlNodeList spreadNodeList = xmlNode.SelectNodes("spread");
            if (spreadNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spreadNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadIDRef = item.Attributes["id"].Name;
                        CommoditySpread ob = CommoditySpread();
                        IDManager.SetID(spreadIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spread = new CommoditySpread(item);
                    }
                }
            }
            
        
            XmlNodeList spreadScheduleNodeList = xmlNode.SelectNodes("spreadSchedule");
            
            foreach (XmlNode item in spreadScheduleNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadScheduleIDRef = item.Attributes["id"].Name;
                        List<CommoditySpreadSchedule> ob = new List<CommoditySpreadSchedule>();
                        ob.Add(new CommoditySpreadSchedule(item));
                        IDManager.SetID(spreadScheduleIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadScheduleIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                    spreadSchedule.Add(new CommoditySpreadSchedule(item));
                    }
                }
            }
            
        
            XmlNodeList spreadPercentageNodeList = xmlNode.SelectNodes("spreadPercentage");
            if (spreadPercentageNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in spreadPercentageNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        spreadPercentageIDRef = item.Attributes["id"].Name;
                        XsdTypeDecimal ob = XsdTypeDecimal();
                        IDManager.SetID(spreadPercentageIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        spreadPercentageIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        spreadPercentage = new XsdTypeDecimal(item);
                    }
                }
            }
            
        
            XmlNodeList fxNodeList = xmlNode.SelectNodes("fx");
            if (fxNodeList.Count > 1 )
            {
                    throw new Exception();
            }
            
            foreach (XmlNode item in fxNodeList)
            {
                if (item.Attributes["href"] != null || item.Attributes["id"] == null) 
                {
                    if (item.Attributes["id"] != null) 
                    {
                        fxIDRef = item.Attributes["id"].Name;
                        CommodityFx ob = CommodityFx();
                        IDManager.SetID(fxIDRef, ob);
                    }
                    else if (item.Attributes.ToString() == "href")
                    {
                        fxIDRef = item.Attributes["href"].Name;
                    }
                    else
                    {
                        fx = new CommodityFx(item);
                    }
                }
            }
            
        
        }
        
    
        #region PricingDates
        private CommodityPricingDates pricingDates;
        public CommodityPricingDates PricingDates
        {
            get
            {
                if (this.pricingDates != null)
                {
                    return this.pricingDates; 
                }
                else if (this.pricingDatesIDRef != null)
                {
                    pricingDates = IDManager.getID(pricingDatesIDRef) as CommodityPricingDates;
                    return this.pricingDates; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.pricingDates != value)
                {
                    this.pricingDates = value;
                }
            }
        }
        #endregion
        
        public string CommodityPricingDatesIDRef { get; set; }
        #region AveragingMethod
        private AveragingMethodEnum averagingMethod;
        public AveragingMethodEnum AveragingMethod
        {
            get
            {
                if (this.averagingMethod != null)
                {
                    return this.averagingMethod; 
                }
                else if (this.averagingMethodIDRef != null)
                {
                    averagingMethod = IDManager.getID(averagingMethodIDRef) as AveragingMethodEnum;
                    return this.averagingMethod; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.averagingMethod != value)
                {
                    this.averagingMethod = value;
                }
            }
        }
        #endregion
        
        public string AveragingMethodEnumIDRef { get; set; }
        #region ConversionFactor
        private XsdTypeDecimal conversionFactor;
        public XsdTypeDecimal ConversionFactor
        {
            get
            {
                if (this.conversionFactor != null)
                {
                    return this.conversionFactor; 
                }
                else if (this.conversionFactorIDRef != null)
                {
                    conversionFactor = IDManager.getID(conversionFactorIDRef) as XsdTypeDecimal;
                    return this.conversionFactor; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.conversionFactor != value)
                {
                    this.conversionFactor = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
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
        #region Spread
        private CommoditySpread spread;
        public CommoditySpread Spread
        {
            get
            {
                if (this.spread != null)
                {
                    return this.spread; 
                }
                else if (this.spreadIDRef != null)
                {
                    spread = IDManager.getID(spreadIDRef) as CommoditySpread;
                    return this.spread; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spread != value)
                {
                    this.spread = value;
                }
            }
        }
        #endregion
        
        public string CommoditySpreadIDRef { get; set; }
        #region SpreadSchedule
        private List<CommoditySpreadSchedule> spreadSchedule;
        public List<CommoditySpreadSchedule> SpreadSchedule
        {
            get
            {
                if (this.spreadSchedule != null)
                {
                    return this.spreadSchedule; 
                }
                else if (this.spreadScheduleIDRef != null)
                {
                    spreadSchedule = IDManager.getID(spreadScheduleIDRef) as List<CommoditySpreadSchedule>;
                    return this.spreadSchedule; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spreadSchedule != value)
                {
                    this.spreadSchedule = value;
                }
            }
        }
        #endregion
        
        public string CommoditySpreadScheduleIDRef { get; set; }
        #region SpreadPercentage
        private XsdTypeDecimal spreadPercentage;
        public XsdTypeDecimal SpreadPercentage
        {
            get
            {
                if (this.spreadPercentage != null)
                {
                    return this.spreadPercentage; 
                }
                else if (this.spreadPercentageIDRef != null)
                {
                    spreadPercentage = IDManager.getID(spreadPercentageIDRef) as XsdTypeDecimal;
                    return this.spreadPercentage; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.spreadPercentage != value)
                {
                    this.spreadPercentage = value;
                }
            }
        }
        #endregion
        
        public string XsdTypeDecimalIDRef { get; set; }
        #region Fx
        private CommodityFx fx;
        public CommodityFx Fx
        {
            get
            {
                if (this.fx != null)
                {
                    return this.fx; 
                }
                else if (this.fxIDRef != null)
                {
                    fx = IDManager.getID(fxIDRef) as CommodityFx;
                    return this.fx; 
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            set
            {
                if (this.fx != value)
                {
                    this.fx = value;
                }
            }
        }
        #endregion
        
        public string CommodityFxIDRef { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

