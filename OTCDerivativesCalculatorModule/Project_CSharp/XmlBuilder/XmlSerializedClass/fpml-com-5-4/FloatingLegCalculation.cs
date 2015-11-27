using System;
using System.Text;
using System.Collections.Generic;
using System.Xml;

namespace FpmlSerializedCSharp
{
    public class FloatingLegCalculation : ISerialized
    {
        public FloatingLegCalculation(XmlNode xmlNode)
        {
            XmlNode pricingDatesNode = xmlNode.SelectSingleNode("pricingDates");
            
            if (pricingDatesNode != null)
            {
                if (pricingDatesNode.Attributes["href"] != null || pricingDatesNode.Attributes["id"] != null) 
                {
                    if (pricingDatesNode.Attributes["id"] != null) 
                    {
                        pricingDatesIDRef_ = pricingDatesNode.Attributes["id"].Value;
                        CommodityPricingDates ob = new CommodityPricingDates(pricingDatesNode);
                        IDManager.SetID(pricingDatesIDRef_, ob);
                    }
                    else if (pricingDatesNode.Attributes["href"] != null)
                    {
                        pricingDatesIDRef_ = pricingDatesNode.Attributes["href"].Value;
                    }
                    else
                    {
                        pricingDates_ = new CommodityPricingDates(pricingDatesNode);
                    }
                }
                else
                {
                    pricingDates_ = new CommodityPricingDates(pricingDatesNode);
                }
            }
            
        
            XmlNode averagingMethodNode = xmlNode.SelectSingleNode("averagingMethod");
            
            if (averagingMethodNode != null)
            {
                if (averagingMethodNode.Attributes["href"] != null || averagingMethodNode.Attributes["id"] != null) 
                {
                    if (averagingMethodNode.Attributes["id"] != null) 
                    {
                        averagingMethodIDRef_ = averagingMethodNode.Attributes["id"].Value;
                        AveragingMethodEnum ob = new AveragingMethodEnum(averagingMethodNode);
                        IDManager.SetID(averagingMethodIDRef_, ob);
                    }
                    else if (averagingMethodNode.Attributes["href"] != null)
                    {
                        averagingMethodIDRef_ = averagingMethodNode.Attributes["href"].Value;
                    }
                    else
                    {
                        averagingMethod_ = new AveragingMethodEnum(averagingMethodNode);
                    }
                }
                else
                {
                    averagingMethod_ = new AveragingMethodEnum(averagingMethodNode);
                }
            }
            
        
            XmlNode conversionFactorNode = xmlNode.SelectSingleNode("conversionFactor");
            
            if (conversionFactorNode != null)
            {
                if (conversionFactorNode.Attributes["href"] != null || conversionFactorNode.Attributes["id"] != null) 
                {
                    if (conversionFactorNode.Attributes["id"] != null) 
                    {
                        conversionFactorIDRef_ = conversionFactorNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(conversionFactorNode);
                        IDManager.SetID(conversionFactorIDRef_, ob);
                    }
                    else if (conversionFactorNode.Attributes["href"] != null)
                    {
                        conversionFactorIDRef_ = conversionFactorNode.Attributes["href"].Value;
                    }
                    else
                    {
                        conversionFactor_ = new XsdTypeDecimal(conversionFactorNode);
                    }
                }
                else
                {
                    conversionFactor_ = new XsdTypeDecimal(conversionFactorNode);
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
            
        
            XmlNode spreadNode = xmlNode.SelectSingleNode("spread");
            
            if (spreadNode != null)
            {
                if (spreadNode.Attributes["href"] != null || spreadNode.Attributes["id"] != null) 
                {
                    if (spreadNode.Attributes["id"] != null) 
                    {
                        spreadIDRef_ = spreadNode.Attributes["id"].Value;
                        CommoditySpread ob = new CommoditySpread(spreadNode);
                        IDManager.SetID(spreadIDRef_, ob);
                    }
                    else if (spreadNode.Attributes["href"] != null)
                    {
                        spreadIDRef_ = spreadNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spread_ = new CommoditySpread(spreadNode);
                    }
                }
                else
                {
                    spread_ = new CommoditySpread(spreadNode);
                }
            }
            
        
            XmlNodeList spreadScheduleNodeList = xmlNode.SelectNodes("spreadSchedule");
            
            if (spreadScheduleNodeList != null)
            {
                this.spreadSchedule_ = new List<CommoditySpreadSchedule>();
                foreach (XmlNode item in spreadScheduleNodeList)
                {
                    if (item.Attributes["href"] != null || item.Attributes["id"] != null) 
                    {
                        if (item.Attributes["id"] != null) 
                        {
                            spreadScheduleIDRef_ = item.Attributes["id"].Value;
                            spreadSchedule_.Add(new CommoditySpreadSchedule(item));
                            IDManager.SetID(spreadScheduleIDRef_, spreadSchedule_[spreadSchedule_.Count - 1 ]);
                        }
                        else if (item.Attributes["href"] != null)
                        {
                            spreadScheduleIDRef_ = item.Attributes["href"].Value;
                        }
                        else
                        {
                        spreadSchedule_.Add(new CommoditySpreadSchedule(item));
                        }
                    }
                    else
                    {
                        spreadSchedule_.Add(new CommoditySpreadSchedule(item));
                    }
                }
            }
            
        
            XmlNode spreadPercentageNode = xmlNode.SelectSingleNode("spreadPercentage");
            
            if (spreadPercentageNode != null)
            {
                if (spreadPercentageNode.Attributes["href"] != null || spreadPercentageNode.Attributes["id"] != null) 
                {
                    if (spreadPercentageNode.Attributes["id"] != null) 
                    {
                        spreadPercentageIDRef_ = spreadPercentageNode.Attributes["id"].Value;
                        XsdTypeDecimal ob = new XsdTypeDecimal(spreadPercentageNode);
                        IDManager.SetID(spreadPercentageIDRef_, ob);
                    }
                    else if (spreadPercentageNode.Attributes["href"] != null)
                    {
                        spreadPercentageIDRef_ = spreadPercentageNode.Attributes["href"].Value;
                    }
                    else
                    {
                        spreadPercentage_ = new XsdTypeDecimal(spreadPercentageNode);
                    }
                }
                else
                {
                    spreadPercentage_ = new XsdTypeDecimal(spreadPercentageNode);
                }
            }
            
        
            XmlNode fxNode = xmlNode.SelectSingleNode("fx");
            
            if (fxNode != null)
            {
                if (fxNode.Attributes["href"] != null || fxNode.Attributes["id"] != null) 
                {
                    if (fxNode.Attributes["id"] != null) 
                    {
                        fxIDRef_ = fxNode.Attributes["id"].Value;
                        CommodityFx ob = new CommodityFx(fxNode);
                        IDManager.SetID(fxIDRef_, ob);
                    }
                    else if (fxNode.Attributes["href"] != null)
                    {
                        fxIDRef_ = fxNode.Attributes["href"].Value;
                    }
                    else
                    {
                        fx_ = new CommodityFx(fxNode);
                    }
                }
                else
                {
                    fx_ = new CommodityFx(fxNode);
                }
            }
            
        
        }
        
    
        #region PricingDates_
        private CommodityPricingDates pricingDates_;
        public CommodityPricingDates PricingDates_
        {
            get
            {
                if (this.pricingDates_ != null)
                {
                    return this.pricingDates_; 
                }
                else if (this.pricingDatesIDRef_ != null)
                {
                    pricingDates_ = IDManager.getID(pricingDatesIDRef_) as CommodityPricingDates;
                    return this.pricingDates_; 
                }
                else
                {
                      return this.pricingDates_; 
                }
            }
            set
            {
                if (this.pricingDates_ != value)
                {
                    this.pricingDates_ = value;
                }
            }
        }
        #endregion
        
        public string pricingDatesIDRef_ { get; set; }
        #region AveragingMethod_
        private AveragingMethodEnum averagingMethod_;
        public AveragingMethodEnum AveragingMethod_
        {
            get
            {
                if (this.averagingMethod_ != null)
                {
                    return this.averagingMethod_; 
                }
                else if (this.averagingMethodIDRef_ != null)
                {
                    averagingMethod_ = IDManager.getID(averagingMethodIDRef_) as AveragingMethodEnum;
                    return this.averagingMethod_; 
                }
                else
                {
                      return this.averagingMethod_; 
                }
            }
            set
            {
                if (this.averagingMethod_ != value)
                {
                    this.averagingMethod_ = value;
                }
            }
        }
        #endregion
        
        public string averagingMethodIDRef_ { get; set; }
        #region ConversionFactor_
        private XsdTypeDecimal conversionFactor_;
        public XsdTypeDecimal ConversionFactor_
        {
            get
            {
                if (this.conversionFactor_ != null)
                {
                    return this.conversionFactor_; 
                }
                else if (this.conversionFactorIDRef_ != null)
                {
                    conversionFactor_ = IDManager.getID(conversionFactorIDRef_) as XsdTypeDecimal;
                    return this.conversionFactor_; 
                }
                else
                {
                      return this.conversionFactor_; 
                }
            }
            set
            {
                if (this.conversionFactor_ != value)
                {
                    this.conversionFactor_ = value;
                }
            }
        }
        #endregion
        
        public string conversionFactorIDRef_ { get; set; }
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
        #region Spread_
        private CommoditySpread spread_;
        public CommoditySpread Spread_
        {
            get
            {
                if (this.spread_ != null)
                {
                    return this.spread_; 
                }
                else if (this.spreadIDRef_ != null)
                {
                    spread_ = IDManager.getID(spreadIDRef_) as CommoditySpread;
                    return this.spread_; 
                }
                else
                {
                      return this.spread_; 
                }
            }
            set
            {
                if (this.spread_ != value)
                {
                    this.spread_ = value;
                }
            }
        }
        #endregion
        
        public string spreadIDRef_ { get; set; }
        #region SpreadSchedule_
        private List<CommoditySpreadSchedule> spreadSchedule_;
        public List<CommoditySpreadSchedule> SpreadSchedule_
        {
            get
            {
                if (this.spreadSchedule_ != null)
                {
                    return this.spreadSchedule_; 
                }
                else if (this.spreadScheduleIDRef_ != null)
                {
                    return this.spreadSchedule_; 
                }
                else
                {
                      return this.spreadSchedule_; 
                }
            }
            set
            {
                if (this.spreadSchedule_ != value)
                {
                    this.spreadSchedule_ = value;
                }
            }
        }
        #endregion
        
        public string spreadScheduleIDRef_ { get; set; }
        #region SpreadPercentage_
        private XsdTypeDecimal spreadPercentage_;
        public XsdTypeDecimal SpreadPercentage_
        {
            get
            {
                if (this.spreadPercentage_ != null)
                {
                    return this.spreadPercentage_; 
                }
                else if (this.spreadPercentageIDRef_ != null)
                {
                    spreadPercentage_ = IDManager.getID(spreadPercentageIDRef_) as XsdTypeDecimal;
                    return this.spreadPercentage_; 
                }
                else
                {
                      return this.spreadPercentage_; 
                }
            }
            set
            {
                if (this.spreadPercentage_ != value)
                {
                    this.spreadPercentage_ = value;
                }
            }
        }
        #endregion
        
        public string spreadPercentageIDRef_ { get; set; }
        #region Fx_
        private CommodityFx fx_;
        public CommodityFx Fx_
        {
            get
            {
                if (this.fx_ != null)
                {
                    return this.fx_; 
                }
                else if (this.fxIDRef_ != null)
                {
                    fx_ = IDManager.getID(fxIDRef_) as CommodityFx;
                    return this.fx_; 
                }
                else
                {
                      return this.fx_; 
                }
            }
            set
            {
                if (this.fx_ != value)
                {
                    this.fx_ = value;
                }
            }
        }
        #endregion
        
        public string fxIDRef_ { get; set; }
        public string choiceStr_0;
        
    
        
    
    }
    
}

